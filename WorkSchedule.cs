using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Utilities.Collections;
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
    public partial class WorkSchedule : Form
    {
        private string phoneNumber;
        private List<workSchedule> workSchedules; // 근무일정 리스트
        private DateTime[] boldedDates;
        public WorkSchedule(string phoneNumber)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
            workSchedules = new List<workSchedule>();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            //메인화면으로 이동
            MainForm mainForm = new MainForm(phoneNumber);
            mainForm.Show();
            this.Hide();
        }

        private void WorkSchedule_Load(object sender, EventArgs e)
        {
            LoadWorkSchedule();
            
        }

        private void LoadWorkSchedule()
        {
            // DB에 worker 테이블에서 phoneNumber에 해당하는 worker의 rank를 가져옴
            string sql = "SELECT worktime FROM gs25.worker WHERE phoneNumber = '" + phoneNumber + "'";
            MySqlDataReader rdr = DBConnection.Select(sql);
            while(rdr.Read())
            {
                string startTime,endTime;
                string worktime = rdr["worktime"].ToString();
                DisplayRankDays(worktime);
                if (worktime == "평일 오전1")
                {
                    //평일 오전1이면 평일 오전1 근무일정을 가져옴
                    //근무 시작 시간은 7시, 근무 종료 시간은 12시
                    //workSchedule 클래스의 인스턴스를 생성하여 workSchedules 리스트에 추가
                    startTime = "07:00";
                    endTime = "14:00";
                    for (int i = 0; i < boldedDates.Length; i++)
                    {
                        workSchedule workSchedule = new workSchedule("평일 오전1", boldedDates[i], startTime, endTime);
                        workSchedules.Add(workSchedule);
                    }
                    UpdateWorkScheduleDisplay();
                    return;
                }
                else if (worktime == "평일 오전2")
                {
                    startTime = "07:00";
                    endTime = "09:30";
                    for (int i = 0; i < boldedDates.Length; i++)
                    {
                        workSchedule workSchedule = new workSchedule("평일 오전2", boldedDates[i], startTime, endTime);
                        workSchedules.Add(workSchedule);
                    }
                    UpdateWorkScheduleDisplay();
                    return;
                }
                else if (worktime == "평일 오후")
                {
                    startTime = "14:00";
                    endTime = "23:00";
                    for (int i = 0; i < boldedDates.Length; i++)
                    {
                        workSchedule workSchedule = new workSchedule("평일 오후", boldedDates[i], startTime, endTime);
                        workSchedules.Add(workSchedule);
                    }
                    UpdateWorkScheduleDisplay();
                    return;
                }
                else if (worktime == "주말 오전")
                {
                    startTime = "07:00";
                    endTime = "14:00";
                    for (int i = 0; i < boldedDates.Length; i++)
                    {
                        workSchedule workSchedule = new workSchedule("주말오전", boldedDates[i], startTime, endTime);
                        workSchedules.Add(workSchedule);
                    }
                    UpdateWorkScheduleDisplay();
                    return;
                }
                else if (worktime == "주말 오후")
                {
                    startTime = "14:00";
                    endTime = "23:00";
                    for (int i = 0; i < boldedDates.Length; i++)
                    {
                        workSchedule workSchedule = new workSchedule("주말오후", boldedDates[i], startTime, endTime);
                        workSchedules.Add(workSchedule);
                    }
                    UpdateWorkScheduleDisplay();
                    return;
                }
            }
        }

        private void UpdateWorkScheduleDisplay()
        {
            listView.Items.Clear();
            foreach (workSchedule workSchedule in workSchedules)
            {
                ListViewItem item = new ListViewItem(workSchedule.WorkType);
                item.SubItems.Add(workSchedule.Date.ToString("yyyy-MM-dd"));
                item.SubItems.Add(workSchedule.StartTime);
                item.SubItems.Add(workSchedule.EndTime);
                listView.Items.Add(item);
            }
        }


        private void DisplayRankDays(string worktime)
        {
            if (worktime == "평일 오전1" || worktime == "평일 오전2" || worktime == "평일 오후")
            {
                boldedDates = Enumerable.Range(1, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
                                          .Select(day => new DateTime(DateTime.Now.Year, DateTime.Now.Month, day))
                                          .Where(date => date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                                          .ToArray();
            }
            else if (worktime == "주말 오전" || worktime == "주말 오후")
            {
                boldedDates = Enumerable.Range(1, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
                                          .Select(day => new DateTime(DateTime.Now.Year, DateTime.Now.Month, day))
                                          .Where(date => date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                                          .ToArray();
            }
            else
            {
                boldedDates = new DateTime[] { };
            }

            monthCalendar.BoldedDates = boldedDates;
            monthCalendar.Refresh();
        }

    }

    public class workSchedule
    {
        public string WorkType { get; set; }
        public DateTime Date { get; set; }
        public string StartTime { get; set; } // 근무 시작시간
        public string EndTime { get; set; } //근무 마치는 시간

        public workSchedule(string workType, DateTime date, string startTime, string endTime)
        {
            WorkType = workType;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
