using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;
using System.Xml.Linq;

namespace GS25ManagementApp
{
    public partial class info_change : Form
    {
        private string phoneNumber1;
        private string rank;
        public info_change(string phoneNumber)
        {
            InitializeComponent();
            phoneNumber1 = phoneNumber;
        }
        private void btn_workerUpdate_Click(object sender, EventArgs e)
        {
            //회원의 휴대폰 번호를 이용해 정보를 업데이트
            string sql = "UPDATE `gs25`.`worker` SET `name` = '"+TB_Name.Text+"', `password` = '"+TB_PW.Text+"', `phoneNumber` = '"+TB_PN.Text+"', `rank` = '"+rank+"', `worktime` = '"+comboBox_WorkTime.Text+"', `workstart` = '"+TB_Starttime.Text+"' WHERE(`phoneNumber` = '"+phoneNumber1+"')";
            DBConnection.Update(sql);
            MessageBox.Show("정보수정이 완료되었습니다.");
            MainForm mainForm = new MainForm(TB_PN.Text);
            mainForm.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //경영주 체크박스를 체크하면
            //rank값은 "경영주"로 저장
            //경영주 체크박스를 체크해제하면
            //rank값 초기화
            //스토어 매니저 체크박스가 체크되어있으면 이 체크박스는 체크 불가능
            if (checkBox1.Checked == true)
            {
                rank = "경영주";
                checkBox2.Enabled = false;
            }
            else
            {
                rank = "";
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //스토어 매니저 체크박스를 체크하면
            //rank값은 "스토어 매니저"로 저장
            //스토어 매니저 체크박스를 체크해제하면
            //rank값 초기화
            //경영주 체크박스가 체크되어있으면 이 체크박스는 체크 불가능
            if (checkBox2.Checked == true)
            {
                rank = "스토어 매니저";
                checkBox1.Enabled = false;
            }
            else
            {
                rank = "";
                checkBox1.Enabled = true;
            }
        }
    }
}
