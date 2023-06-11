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
    public partial class Notice : Form
    {
        private string phoneNumber;

        public Notice(string phoneNumber)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
        }

        private void Notice_Load(object sender, EventArgs e)
        {
            // Notice 데이터 가져오기
            LoadNoticeData();
        }

        private void LoadNoticeData()
        {
            listViewNotice.Items.Clear();
            //DB에서 공지사항 데이터를 가져와서 출력
            string sql = "SELECT * FROM notice";
            MySqlDataReader rdr = DBConnection.Select(sql);
            while (rdr.Read())
            {
                int id = (int)rdr["id"];
                DateTime inputTime = (DateTime)rdr["inputTime"];
                string content = (string)rdr["content"];

                ListViewItem item = new ListViewItem(id.ToString());
                item.SubItems.Add(inputTime.ToString());
                item.SubItems.Add(content);

                listViewNotice.Items.Add(item);
            }

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            //메인화면으로 이동
            MainForm mainForm = new MainForm(phoneNumber);
            mainForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //공지사항 추가
            string content = txtContent.Text.Trim();
            if (content.Length == 0)
            {
                MessageBox.Show("내용을 입력해주세요.");
                return;
            }

            string sql = "INSERT INTO notice (content) VALUES ('" + content + "')";
            DBConnection.Insert(sql);
            LoadNoticeData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //공지사항 삭제
            if (listViewNotice.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 공지사항을 선택해주세요.");
                return;
            }

            int id = int.Parse(listViewNotice.SelectedItems[0].Text);
            string sql = "DELETE FROM notice WHERE id = " + id;
            DBConnection.Delete(sql);
            LoadNoticeData();
        }
    }
}
