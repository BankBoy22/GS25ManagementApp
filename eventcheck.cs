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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GS25ManagementApp
{
    public partial class eventcheck : Form
    {
        private string phoneNumber;
        private List<EventItem> eventItems;
        public eventcheck(string phoneNumber)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            //메인화면으로 이동
            MainForm mainForm = new MainForm(phoneNumber);
            mainForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eventcheck_Load(object sender, EventArgs e)
        {
            LoadEventItems();
        }

        private void LoadEventItems()
        {
            eventItems = new List<EventItem>(); // eventItems 리스트 초기화
            // DB에서 행사물품 목록을 가져와서 출력
            string sql = "SELECT * FROM gs25.event";
            MySqlDataReader rdr = DBConnection.Select(sql);
            while (rdr.Read())
            {
                int id = (int)rdr["id"];
                string name = (string)rdr["name"];
                string code = (string)rdr["code"];
                string period = (string)rdr["period"];
                decimal price = (decimal)rdr["price"];
                string promotion = (string)rdr["promotion"];

                EventItem eventItem = new EventItem(id, name, code, period, price, promotion);
                eventItems.Add(eventItem);
            }

            UpdateEventItemDisplay();
        }

        private void UpdateEventItemDisplay()
        {
            // 행사물품 목록을 출력
            listViewEvent.Items.Clear();

            foreach (EventItem eventItem in eventItems)
            {
                ListViewItem item = new ListViewItem(eventItem.Name);
                item.SubItems.Add(eventItem.Code);
                item.SubItems.Add(eventItem.Period);
                item.SubItems.Add(eventItem.Price.ToString());
                item.SubItems.Add(eventItem.Promotion);

                listViewEvent.Items.Add(item);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter1Plus1_Click(object sender, EventArgs e)
        {
            FilterEventItems("1+1");
        }

        private void btnFilter2Plus1_Click(object sender, EventArgs e)
        {
            FilterEventItems("2+1");
        }

        private void btnFilterCardPromotion_Click(object sender, EventArgs e)
        {
            FilterEventItems("카드행사");
        }

        private void btnFilterFreeGift_Click(object sender, EventArgs e)
        {
            FilterEventItems("덤증정");
        }

        private void FilterEventItems(string promotionType)
        {
            // 특정 행사 종류에 따라 행사물품 필터링
            List<EventItem> filteredItems = eventItems.Where(item => item.Promotion == promotionType).ToList();
            listViewEvent.Items.Clear();

            foreach (EventItem eventItem in filteredItems)
            {
                ListViewItem item = new ListViewItem(eventItem.Name);
                item.SubItems.Add(eventItem.Code);
                item.SubItems.Add(eventItem.Period);
                item.SubItems.Add(eventItem.Price.ToString());
                item.SubItems.Add(eventItem.Promotion);

                listViewEvent.Items.Add(item);
            }
        }

        private void FilterEventItemsByName(string productName)
        {
            // 리스트에 검색한 상품이 없다면 메세지박스 출력
            if (eventItems.Where(item => item.Name.Contains(productName)).ToList().Count == 0)
            {
                MessageBox.Show("검색한 상품이 없습니다.");
                return;
            }
            // 상품명에 따라 행사물품 필터링
            List<EventItem> filteredItems = eventItems.Where(item => item.Name.Contains(productName)).ToList();
            listViewEvent.Items.Clear();

            foreach (EventItem eventItem in filteredItems)
            {
                ListViewItem item = new ListViewItem(eventItem.Name);
                item.SubItems.Add(eventItem.Code);
                item.SubItems.Add(eventItem.Period);
                item.SubItems.Add(eventItem.Price.ToString());
                item.SubItems.Add(eventItem.Promotion);

                listViewEvent.Items.Add(item);
            }
        }

        private void listViewEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// 상품 검색버튼
        {
            string productName = richTextBox1.Text;
            //만약 검색어가 없다면 메세지박스 출력
            if (productName == "")
            {
                MessageBox.Show("검색어를 입력해주세요.");
                return;
            }
            FilterEventItemsByName(productName);
        }
    }

    public class EventItem
    {
        public int Id { get; }
        public string Name { get; }
        public string Code { get; }
        public string Period { get; }
        public decimal Price { get; }
        public string Promotion { get; }

        public EventItem(int id, string name, string code, string period, decimal price, string promotion)
        {
            Id = id;
            Name = name;
            Code = code;
            Period = period;
            Price = price;
            Promotion = promotion;
        }
    }
}
