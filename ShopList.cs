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
    public partial class ShopList : Form
    {
        private string phoneNumber;
        public ShopList(string phoneNumber)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
        }

        private void pictureBox2_Click(object sender, EventArgs e)//뒤로가기 버튼
        {
            GS25POS pos = new GS25POS(phoneNumber);
            pos.Show();
            this.Close();
        }

        private void ShopList_Load(object sender, EventArgs e)
        {
            DisplayShoplist();  //판매내역 출력
        }

        private void DisplayShoplist()
        {
            //DB에서 상품 정보를 가져와서 리스트에 추가
            string sql = "SELECT * FROM gs25.gs25pos";
            MySqlDataReader rdr = DBConnection.Select(sql);
            while (rdr.Read())
            {
                int id = (int)rdr["No."];
                string name = (string)rdr["name"];
                int price = (int)rdr["price"];
                int count = (int)rdr["count"];
                int total = (int)rdr["total"];

                dataGridView.Rows.Add(id, name, price, count, total);
            }
        }
    }

}
