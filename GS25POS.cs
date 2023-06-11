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
    public partial class GS25POS : Form
    {
        private string phoneNumber;
        DataTable table = new DataTable();
        public GS25POS(string phoneNumber)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Count", typeof(string));
            table.Columns.Add("Total", typeof(string));

            dataGridView.DataSource = table;
            numericUpDown1.Value = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e) //뒤로가기 버튼
        {
            MainForm frm = new MainForm(phoneNumber);
            frm.Show();
            this.Close();
        }

        private void Btn_cancle_Click(object sender, EventArgs e)
        {
            //행 지우기
            foreach (DataGridViewRow item in this.dataGridView.SelectedRows)
            {
                dataGridView.Rows.RemoveAt(item.Index);
            }

            //합계창에 수정된 값 넣기
            decimal all = 0;
            for (int i = 0; i < dataGridView.Rows.Count; ++i)
            {
                all += Convert.ToDecimal(dataGridView.Rows[i].Cells[3].Value);
            }

            label_total.Text = all.ToString(); ;
        }

        private void Btn_plus_Click(object sender, EventArgs e) //담기 버튼
        {
            //상품명, 가격, 수량을 입력하고 추가 버튼을 누르면 쇼핑리스트에 상품이 추가됨
            if (TB_productsname.Text == "" || TB_price.Text == "" || numericUpDown1.Value == 0)
            {
                MessageBox.Show("상품명과 가격,수량을 정확히 입력해주세요.");
            }
            else
            {
                //합계를 구하기 위해 상품명과 가격을 정의하고 total로 합침
                decimal price = decimal.Parse(TB_price.Text);
                decimal count = numericUpDown1.Value;
                decimal total = price * count;


                //textbox내의 정보를 표에 삽입
                table.Rows.Add(TB_productsname.Text, TB_price.Text, numericUpDown1.Value, total);
                dataGridView.DataSource = table;

                //text box 초기화
                TB_productsname.Text = "";
                TB_price.Text = "";
                numericUpDown1.Value = 1;

                //합계
                decimal sum = 0;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[3].Value);
                }
                label_total.Text = sum.ToString();
            }
        }

        private void Btn_pay_Click(object sender, EventArgs e) //계산하기 버튼
        {
            //계산하기
            for (int i = 0; i < dataGridView.Rows.Count-1; i++)
            {
                //DB에 저장
                string name = dataGridView.Rows[i].Cells[0].Value.ToString();
                string price = dataGridView.Rows[i].Cells[1].Value.ToString();
                string count = dataGridView.Rows[i].Cells[2].Value.ToString();
                string total = dataGridView.Rows[i].Cells[3].Value.ToString();

                //DB에 저장
                string sql = string.Format("INSERT INTO `gs25`.`gs25pos` (name,price,count,total,c_num) VALUES('{0}',{1},{2},{3},{4})", @name, @price, @count, @total, @i);
                DBConnection.Insert(sql);
            }
            MessageBox.Show("결제가 완료되었습니다.");
            int rowCount = dataGridView.Rows.Count;
            //데이터 그리드뷰 초기화
            for (int j = 0; j < rowCount; j++)
            {
                if (dataGridView.Rows[0].IsNewRow == false)
                {
                    dataGridView.Rows.RemoveAt(0);
                }
            }
            //총합 초기화
            label_total.Text = "0";
        }

        private void Btn_ICE_CUPL_Click(object sender, EventArgs e)
        {
            //아이스컵(L) 1000원 담기 버튼
            UpdateItem("아이스컵(L)", 1000);
        }

        private void Btn_ICECUPM_Click(object sender, EventArgs e)
        {
            //아이스컵(M) 800원 담기 버튼
            UpdateItem("아이스컵(M)", 800);
        }

        private void Btn_candy_Click(object sender, EventArgs e)
        {
            //츄파츕스 300원 담기 버튼
            UpdateItem("츄파츕스", 300);
        }

        private void Btn_water_Click(object sender, EventArgs e)
        {
            //아이시스 500ml 1100원 담기 버튼
            UpdateItem("아이시스 500ml", 1100);
        }

        private void Btn_banana_Click(object sender, EventArgs e)
        {
            //바나나 3700원 담기 버튼
            UpdateItem("바나나", 3700);
        }

        private void UpdateItem(string name, int price)
        {
            TB_productsname.Text = name;
            TB_price.Text = price.ToString();
            Btn_plus_Click(null, null);
        }

        private void Btn_change_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentRow.Index;
            int quantity = (int)numericUpDown2.Value;

            if (index >= 0)
            {
                // 선택한 행의 수량 업데이트
                dataGridView.Rows[index].Cells[2].Value = quantity;

                // 선택한 행의 상품명 가져오기
                string productName = dataGridView.Rows[index].Cells[0].Value.ToString();

                // 같은 상품명이 이미 테이블에 있는지 확인
                DataRow[] rows = table.Select($"Name = '{productName}'");
                if (rows.Length > 0)
                {
                    // 이미 있는 상품인 경우 수량만 변경
                    decimal price = decimal.Parse(rows[0]["Price"].ToString());
                    decimal total = price * quantity;
                    rows[0]["Count"] = quantity.ToString();
                    rows[0]["Total"] = total.ToString();
                }
            }

            // 합계 업데이트
            UpdateTotalLabel();


        }

        private void UpdateTotalLabel()
        {
            decimal total = 0;
            foreach (DataRow row in table.Rows)
            {
                total += decimal.Parse(row["Total"].ToString());
            }
            label_total.Text = total.ToString();
        }


        private void Btn_list_Click(object sender, EventArgs e) //판매내역 버튼
        {
            ShopList list = new ShopList(phoneNumber);
            list.Show();
            this.Close();
        }

        private void GS25POS_Load(object sender, EventArgs e)
        {

        }
        
    }


}
