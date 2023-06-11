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
    public partial class joinForm : Form
    {
        string rank;
        public joinForm() //회원가입폼
        {
            InitializeComponent();
        }

        private void btn_workerUpdate_Click(object sender, EventArgs e)//가입신청 버튼
        {
            //DB에 저장
            //worker 테이블에 저장
            //이름과 전화번호 중복확인
            //중복확인이 되면 저장
            //중복확인이 안되면 저장안됨
            int pid;
            //pid 값은 4자리의 숫자로 이루어져있고 랜덤 값임
            Random random = new Random();
            pid = random.Next(1000, 10000);
            string sql = "INSERT INTO `gs25`.`worker` (`pid`, `name`, `password`, `phoneNumber`, `rank`, `worktime`, `workstart`) VALUES (" + pid + ",'" + TB_Name.Text + "', '" + TB_PW.Text + "', '" + TB_PN.Text + "', '" + rank + "', '" + comboBox_WorkTime.Text + "', '" + TB_Starttime.Text + "')";
            DBConnection.Insert(sql);
            MessageBox.Show("가입신청이 완료되었습니다.");
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//경영주 체크박스
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//스토어 매니저 체크박스
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
