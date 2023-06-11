using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GS25ManagementApp
{
    public partial class MainForm : Form
    {
        private string phoneNumber;
        private string name, rank, worktime, start_work;
        private const string ApiKey = "d1987ce8c0bffa4a16ad60e4660da327";
        private const string ApiUrl = "https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&appid={2}";

        public MainForm(string phoneNumber)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
            //로그인 폼에서 입력한 id를 이용해 worker 테이블에서 이름을 가져옴
            //이름을 가져와서 name_label에 출력
            string sql = "SELECT * FROM worker WHERE phoneNumber = '" + phoneNumber + "'";
            MySqlDataReader rdr = DBConnection.Select(sql);
            if (rdr.Read())
            {
                name = rdr["name"].ToString();
                rank = rdr["rank"].ToString();
                worktime = rdr["worktime"].ToString();
                start_work = rdr["workstart"].ToString();
                Name_label.Text = "\"" + name + "\"" + "님";
                rank_label.Text = rank;
                worktime_label.Text = worktime + " 근무자";
                start_work_label.Text = start_work + " 입사";
            }
            double latitude = 35.179554;  // 예시로 부산의 위도를 사용
            double longitude = 129.075642;  // 예시로 부산의 경도를 사용
            string apiUrl = string.Format(ApiUrl, latitude, longitude, ApiKey); ;
            try
            {
                using (var client = new WebClient())
                {
                    var jsonData = client.DownloadString(apiUrl);
                    dynamic weatherData = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);

                    string cityName = weatherData.name;
                    string weatherDescription = weatherData.weather[0].description;
                    double temperature = weatherData.main.temp;

                    string result = $"City: {cityName}\nWeather: {weatherDescription}\nTemperature: {temperature}°C";

                    labelWeather.Text = result;
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            //프로그램 종료
            Application.Exit();
        }

        private void Btn_Work_Click(object sender, EventArgs e)//근무사항 버튼 , worklistForm을 띄워준다.
        {
            workListForm worklistForm = new workListForm(phoneNumber);
            worklistForm.Show();
            this.Hide();
        }

        private void Btn_notice_Click(object sender, EventArgs e)//전달사항 버튼 , noticeForm을 띄워준다.
        {
            Notice noticeForm = new Notice(phoneNumber);
            noticeForm.Show();
            this.Hide();
        }

        private void btn_timecheck_Click(object sender, EventArgs e)//근무자 스케줄 버튼 , WokrSchedule을 띄워준다.
        {
            WorkSchedule WorkScheduleForm = new WorkSchedule(phoneNumber);
            WorkScheduleForm.Show();
            this.Hide();
        }

        private void btn_eventcheck_Click(object sender, EventArgs e)//행사확인 버튼 , eventcheck를 띄워준다.
        {
            eventcheck eventcheck = new eventcheck(phoneNumber);
            eventcheck.Show();
            this.Hide();
        }

        private void btn_leavetimecheck_Click(object sender, EventArgs e)//유통기한 확인 버튼 . expiration date를 띄워준다. 
        {
            expiration_date expiration = new expiration_date(phoneNumber);
            expiration.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_calcu_Click(object sender, EventArgs e)//급여 계산 버튼, 근무자의 급여를 계산해준다.
        {
            //오늘이 몇월달인지 확인하고 그 달의 근무자의 월급을 계산하여 출력해준다.
            int hourly_rate = 9650; //시급
            string sql = "SELECT worktime FROM worker WHERE phoneNumber = '" + phoneNumber + "'";
            MySqlDataReader rdr = DBConnection.Select(sql);
            while (rdr.Read())
            {
                worktime = rdr["worktime"].ToString();
                DateTime now = DateTime.Now;
                int day = 0; //평일 근무 일수
                int day_weekend = 0; //주말 근무 일수
                int year = now.Year;
                int month = now.Month;
                int days = DateTime.DaysInMonth(year, month);
                for (int i = 1; i <= days; i++)
                {
                    DateTime date = new DateTime(year, month, i);
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        day_weekend++;
                    }
                    else
                    {
                        day++;
                    }
                }
                if (rank == "평일 오전1")
                {
                    //평일 오전1의 월급 계산

                    int salary = hourly_rate * 7 * day;
                    MessageBox.Show("이번달 급여는 " + salary + "원 입니다.");
                    return;
                }
                else if (rank == "평일 오전2")
                {
                    double salary = hourly_rate * 2.5 * day;
                    MessageBox.Show("이번달 급여는 " + salary + "원 입니다.");
                    return;
                }
                else if (rank == "평일 오후")
                {
                    int salary = hourly_rate * 9 * day;
                    MessageBox.Show("이번달 급여는 " + salary + "원 입니다.");
                    return;
                }
                else if (rank == "주말 오전")
                {
                    int salary = hourly_rate * 7 * day_weekend;
                    MessageBox.Show("이번달 급여는 " + salary + "원 입니다.");
                    return;
                }
                else
                {
                    int salary = hourly_rate * 6 * day_weekend;
                    MessageBox.Show("이번달 급여는 " + salary + "원 입니다.");
                    return;
                }
            }
        }

        private void Btn_info_Click(object sender, EventArgs e)//근무자 정보 버튼,infomation을 띄워준다.
        {
            infomation infomation = new infomation(phoneNumber);
            infomation.Show();
            this.Hide();
        }

        private void Btn_Pos_Click(object sender, EventArgs e) //포스기 버튼
        {
            GS25POS pos = new GS25POS(phoneNumber);
            pos.Show();
            this.Hide();
        }

    }
}
