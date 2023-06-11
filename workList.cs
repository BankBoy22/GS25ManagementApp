using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GS25ManagementApp
{
    public partial class workListForm : Form
    {
        private string phoneNumber;
        private List<WorkItem> workItems; // 근무 체크리스트 아이템을 저장할 리스트

        private bool isMorningSelected; // 오전 버튼 선택 여부
        private bool isAfternoonSelected; // 오후 버튼 선택 여부

        public workListForm(string phoneNumber)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
            workItems = new List<WorkItem>();
        }

        private void workList_Load(object sender, EventArgs e)
        {
            UpdateWorkItemDisplay();
            dataGridView.CellClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                bool completed = (bool)dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !completed;
                workItems[e.RowIndex].IsCompleted = !completed;

                // DB에 체크리스트 상태를 업데이트합니다.
                string sql = $"UPDATE worklist SET is_completed = {(completed ? 0 : 1)} WHERE id = {workItems[e.RowIndex].Id}";
                DBConnection.Update(sql);
                UpdateWorkItemDisplay();
            }
        }

        private void UpdateWorkItemDisplay()
        {
            workItems.Clear(); // workItems 초기화
                               //DB에서 근무목록 가져와서 출력
            string sql = "SELECT * FROM worklist";
            MySqlDataReader rdr = DBConnection.Select(sql);
            while (rdr.Read())
            {
                int id = (int)rdr["id"];
                string item = (string)rdr["item"];
                bool isCompleted = (bool)rdr["is_completed"];

                WorkItem workItem = new WorkItem(id, item, isCompleted);
                workItems.Add(workItem);
            }

            List<WorkItem> displayItems = workItems;

            if (isMorningSelected)
            {
                displayItems = GetMorningItems();
            }
            else if (isAfternoonSelected)
            {
                displayItems = GetAfternoonItems();
            }

            dataGridView.DataSource = displayItems;
        }

        private List<WorkItem> GetMorningItems()
        {
            return workItems.FindAll(item => item.ItemType == WorkItemType.Morning);
        }

        private List<WorkItem> GetAfternoonItems()
        {
            return workItems.FindAll(item => item.ItemType == WorkItemType.Afternoon);
        }

        private void AddNewWorkItem(string newItem, WorkItemType itemType)
        {
            // DB에 새로운 근무 목록을 추가
            string sql = "INSERT INTO worklist (item, is_completed, type) VALUES ('" + newItem + "', 0, '" + itemType + "')";
            DBConnection.Insert(sql);
            UpdateWorkItemDisplay();
        }

        private void RemoveWorkItem(int id)
        {
            // DB에서 근무 목록을 삭제합니다.
            string sql = $"DELETE FROM worklist WHERE id = {id}";
            DBConnection.Delete(sql);
            UpdateWorkItemDisplay();
        }

        private void btnMorning_Click(object sender, EventArgs e)
        {
            isMorningSelected = true;
            isAfternoonSelected = false;
            UpdateWorkItemDisplay();
        }

        private void btnAfternoon_Click(object sender, EventArgs e)
        {
            isMorningSelected = false;
            isAfternoonSelected = true;

            UpdateWorkItemDisplay();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            //메인화면으로 이동
            MainForm mainForm = new MainForm(phoneNumber);
            mainForm.Show();
            this.Hide();
        }


        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedRows[0].Index; // 선택한 행의 인덱스
                int itemId = workItems[rowIndex].Id;               // 선택한 아이템의 ID
                RemoveWorkItem(itemId);                             // 선택한 아이템을 삭제합니다.
                UpdateWorkItemDisplay();                            // 삭제된 아이템이 보이지 않도록 업데이트합니다.
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string newItem = textBox1.Text.Trim(); // 폼에서 사용자가 입력한 아이템을 가져옵니다.
            if (!string.IsNullOrEmpty(newItem))
            {
                // 선택된 아이템 타입을 확인하고 적절한 구분으로 추가합니다.
                WorkItemType itemType = isMorningSelected ? WorkItemType.Morning : WorkItemType.Afternoon;
                AddNewWorkItem(newItem, itemType);
                textBox1.Clear(); // 아이템 추가 후 텍스트 박스를 비웁니다.
                UpdateWorkItemDisplay(); // 추가된 아이템이 보이도록 업데이트합니다.
            }
        }
    }

    public enum WorkItemType
    {
        Morning,
        Afternoon
    }

    public class WorkItem
    {
        public int Id { get; }
        public string Item { get; }
        public bool IsCompleted { get; set; }
        public WorkItemType ItemType { get; }

        public WorkItem(int id, string item, bool isCompleted)
        {
            Id = id;
            Item = item;
            IsCompleted = isCompleted;
            ItemType = DetermineWorkItemType();
        }

        private WorkItemType DetermineWorkItemType()
        {
            // 아이템의 이름을 기반으로 아침 또는 오후로 분류
            // 여기서는 예시로 "오전"이나 "AM"이 들어간 아이템을 오전으로 분류하고, 그 외는 오후로 분류합니다.
            if (Item.Contains("오전") || Item.Contains("AM"))
            {
                return WorkItemType.Morning;
            }
            else
            {
                return WorkItemType.Afternoon;
            }
        }
    }
}