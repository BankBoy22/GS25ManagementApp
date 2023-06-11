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
    public partial class infomation : Form
    {
        private string phoneNumber, name, rank, worktime, start_work;

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        public infomation(string phoneNumber)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
            string sql = "SELECT * FROM worker WHERE phoneNumber = '" + phoneNumber + "'";
            MySqlDataReader rdr = DBConnection.Select(sql);
            if (rdr.Read())
            {
                name = rdr["name"].ToString();
                rank = rdr["rank"].ToString();
                worktime = rdr["worktime"].ToString();
                start_work = rdr["workstart"].ToString();
                name_label.Text = name;
                rank_label.Text = rank;
                worktime_label.Text = worktime;
                workstart_label.Text = start_work;
                phoneNumber_label.Text = phoneNumber;
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            //메인화면으로 이동
            MainForm mainForm = new MainForm(phoneNumber);
            mainForm.Show();
            this.Hide();
        }

        private void info_change_btn_Click(object sender, EventArgs e)
        {
            //info_change_form으로 이동
            info_change info_change_form = new info_change(phoneNumber);
            info_change_form.Show();
            this.Hide();
        }

        private void infomation_Load(object sender, EventArgs e)
        {

        }
    }
}
