using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GS25ManagementApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) // 비밀번호를 잊어버리셧나요?
        {
            //FindPW 폼을 띄워준다.
            FindPW findPW = new FindPW();
            findPW.Show();
        }

        private void btn_newid_Click(object sender, EventArgs e) //회원가입 버튼
        {
            //회원가입 폼을 띄워준다.
            joinForm joinForm = new joinForm();
            joinForm.Show();
        }

        private void btn_log_Click(object sender, EventArgs e) //로그인버튼
        {
            //아이디와 비밀번호를 입력받아서
            //DB에 저장된 값과 비교
            //일치하면 로그인 성공
            //불일치하면 로그인 실패
            string sql = "SELECT * FROM worker WHERE phoneNumber = '" + TB_PN.Text + "' AND password = '" + TB_PW.Text + "'";
            MySqlDataReader rdr = DBConnection.Select(sql);
            if (rdr.Read())
            {
                //로그인 성공
                //MessageBox.Show("로그인 성공");
                //메인화면으로 이동
                MainForm mainForm = new MainForm(TB_PN.Text);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                //로그인 실패
                MessageBox.Show("아이디나 비밀번호가 잘못되었습니다.");
            }
        }

    }

    public class DBConnection
    {
        public static MySqlConnection conn = null;
        public static string strConn = "Server=localhost;Database=gs25;Uid=root;Pwd=eq66416642;Charset=UTF8";
        //조회 (예외처리도 필수로 해야함)
        public static MySqlDataReader Select(string sql)
        {
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                return rdr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        //삽입, 수정, 삭제 (예외처리도 필수로 해야함)
        public static void Insert(string sql)
        {
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Update(string sql)
        {
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Delete(string sql)
        {
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int GetLastInsertedId()
        {
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                Close();
            }
        }

        //DB 연결 해제
        public static void Close()
        {
            conn.Close();
        }

        //DB 연결 상태 확인
        public static ConnectionState GetState()
        {
            return conn.State;
        }
    }
}
