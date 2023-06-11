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
    public partial class expiration_date : Form
    {
        private string phoneNumber;
        private List<Product> products; // 상품 리스트
        public expiration_date(string phoneNumber)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
            products = new List<Product>();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            //메인화면으로 이동
            MainForm mainForm = new MainForm(phoneNumber);
            mainForm.Show();
            this.Hide();
        }

        private void expiration_date_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            // DB에서 상품 정보를 가져와서 리스트에 추가
            string sql = "SELECT * FROM gs25.products";
            MySqlDataReader rdr = DBConnection.Select(sql);
            while (rdr.Read())
            {
                int id = (int)rdr["id"];
                string name = (string)rdr["product_name"];
                DateTime expiryDate = (DateTime)rdr["expiry_date"];
                int quantity = (int)rdr["quantity"];

                Product product = new Product(id, name, expiryDate, quantity);
                products.Add(product);
            }
        }

        private void UpdateProductDisplay(List<Product> filteredProducts)//상품 리스트를 데이터 그리드 뷰에 표시
        {
            dataGridView1.Rows.Clear();

            foreach (Product product in filteredProducts)
            {
                dataGridView1.Rows.Add(product.Id, product.Name, product.ExpiryDate.ToString("yyyy-MM-dd"), product.Quantity);
            }
        }

        private void FillterSearch()//검색어로 상품을 검색
        {
            // 검색어를 입력하지 않았을 경우
            if (search_txt.Text.Trim().Length == 0)
            {
                MessageBox.Show("검색어를 입력해주세요.");
                return;
            }
            string searchKeyword = search_txt.Text.Trim();
            // 리스트에 검색한 상품이 없을경우 메시지 박스 출력
            if (products.Where(p => p.Name.Contains(searchKeyword)).ToList().Count == 0)
            {
                MessageBox.Show("검색한 상품이 없습니다.");
                return;
            }
            // 검색한 상품을 표시
            List<Product> searchedProducts = products.Where(p => p.Name.Contains(searchKeyword)).ToList();
            UpdateProductDisplay(searchedProducts);
        }

        private void FilterExpiredProducts()//유통기한이 지난 상품만 표시
        {
            List<Product> expiredProducts = products.Where(p => p.ExpiryDate < DateTime.Today).ToList();
            UpdateProductDisplay(expiredProducts);
        }

        private void FilterImminentProducts()//유통기한이 3일 이내인 상품만 표시
        {
            List<Product> imminentProducts = products.Where(p => (p.ExpiryDate - DateTime.Today).Days <= 3).ToList();
            UpdateProductDisplay(imminentProducts);
        }

        private void FilterPlentyProducts()//유통기한이 4일 이상인 상품만 표시
        {
            List<Product> plentyProducts = products.Where(p => (p.ExpiryDate - DateTime.Today).Days >= 4).ToList();
            UpdateProductDisplay(plentyProducts);
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            FilterExpiredProducts();
        }

        private void btnImminent_Click(object sender, EventArgs e)
        {
            FilterImminentProducts();
        }

        private void btnPlenty_Click(object sender, EventArgs e)
        {
            FilterPlentyProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            if(productName=="")
            {
                MessageBox.Show("상품명을 입력해주세요");
                return;
            }
            DateTime expiryDate = dateTimePicker.Value;
            int quantity = (int)numericUpDown2.Value;
            if (quantity==0)
            {
                MessageBox.Show("수량을 정확히 입력해주세요");
                return;
            }
            // 상품을 테이블에 추가
            string sql = $"INSERT INTO gs25.products (product_name, expiry_date, quantity) VALUES ('{productName}', '{expiryDate.ToString("yyyy-MM-dd")}', {quantity})";
            DBConnection.Insert(sql);

            // 추가된 상품을 리스트에 추가
            int productId = DBConnection.GetLastInsertedId();
            Product product = new Product(productId, productName, expiryDate, quantity);
            products.Add(product);

            // 추가된 상품을 데이터 그리드 뷰에 표시
            dataGridView1.Rows.Add(productId, productName, expiryDate.ToString("yyyy-MM-dd"), quantity);

            // 입력 필드 초기화
            txtProductName.Text = string.Empty;
            dateTimePicker.Value = DateTime.Today;
            numericUpDown2.Value = 1;
        }

        private void button3_Click(object sender, EventArgs e) //검색 버튼
        {
            FillterSearch();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            int productId = (int)dataGridView1.Rows[selectedRowIndex].Cells[0].Value;
            string sql = $"DELETE FROM gs25.products WHERE id = {productId}";
            DBConnection.Delete(sql);
            dataGridView1.Rows.RemoveAt(selectedRowIndex);
        }
    }

    public class Product
    {
        public int Id { get; }
        public string Name { get; }
        public DateTime ExpiryDate { get; }
        public int Quantity { get; }

        public Product(int id, string name, DateTime expiryDate, int quantity)
        {
            Id = id;
            Name = name;
            ExpiryDate = expiryDate;
            Quantity = quantity;
        }
    }
}
