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
    public partial class FindPW : Form
    {
        public FindPW()
        {
            InitializeComponent();
        }

        private void newwork_label_Click(object sender, EventArgs e)
        {

        }

        private void FindPW_Load(object sender, EventArgs e)
        {

        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            //비밀번호 찾기 버튼
            //아이디,이름,전화번호를 입력하면 비밀번호를 찾을 수 있음 입력하지 않으면 이름과 전화번호를 입력하라는 메세지박스 출력
            if (TB_Name.Text == "" || TB_PN.Text == "")
            {
                MessageBox.Show("이름과 전화번호를 입력해주세요.");
            }
            else
            {
                string sql = "Select password from worker WHERE name = '" + TB_Name.Text + "' AND phoneNumber = '" + TB_PN.Text + "'";
                MySqlDataReader rdr = DBConnection.Select(sql);
                if (rdr.Read())
                {
                    string password = rdr["password"].ToString();
                    MessageBox.Show("비밀번호는 " + password + " 입니다.");
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("가입된 회원이 아닙니다!.");
                }
            }
        }
    }
}
