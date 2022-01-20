using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.Entity_Framework;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts(); // Ürünlerin gelmesi için kendimizin oluşturduğu bir method.
            LoadCategories();
        }
        private IProductService _productService;
        private ICategoryService _categoryService;
        private void LoadCategories()
        {
            // Ürün aramadaki kategoriler bölümü için getirir.
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            // Ekleme bölümündeki kategoriler bölümü için getirir.
            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

            // Update bölüöündeki kategoriler bölümü için getirir.
            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryId";


        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add işleminin business katmanına validation kurallarını ve exceptionlarını zaten tanımladık.
            // Try catch a koyarız ve verdiği hatayı yazdırırız.
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategory.SelectedValue), // Listeden seçilen kategorinin Idsini alıp yeni ürüne ekliyor. 
                    ProductName = tbxProductName2.Text,
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStock.Text)

                });

                MessageBox.Show("Ürün eklendi!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
            
        }

        private void cbxCategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxUpdateProductName.Text,
                    CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                    UnitsInStock = Convert.ToInt16(tbxUpdateUnitInStock.Text),
                    QuantityPerUnit = (tbxUpdateQuantityPerUnit.Text),
                    UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text)
                });
                MessageBox.Show("Ürün güncellendi!");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void tbxUpdateProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Form Design üzerinden eventlerden CellClick seçildi. 
            // Tıklandığında değerlerin formlara dolmasını istediğimiz için.

            var row = dgwProduct.CurrentRow; // Alt satır gibi de yapılabilir böyle bir kısayol da üretilebilir.
            tbxUpdateProductName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            cbxUpdateCategory.SelectedValue = row.Cells[2].Value;
            tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = row.Cells[4].Value.ToString();
            tbxUpdateUnitInStock.Text = row.Cells[5].Value.ToString();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwProduct.CurrentRow != null) // Silerken veritabanı hatası alınmaması için bu if içerisine alındı.
                                                   // Herhangi bir şey seçmeden silme işlemi gerçekleşmesin diye.
                {                                  // Hata yönetimi hiçbir zaman arayüzde yapılmaz. 
                                                   // Her zaman business katmanında hata yönetimi yapılır.
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün silindi!");
                    LoadProducts();
                }
            }
            catch (Exception exception) // Detayları iş katmanında verilmeli.
            {

                MessageBox.Show(exception.Message); // Kendi mesajımız verilir. Güvenlik zayifiyetlerini de önler.
            }




        }
    }
}

