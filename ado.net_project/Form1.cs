using System.Net.Http.Headers;

namespace ado.net_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {

            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            MessageBox.Show("Product Added");
        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Cell Content");
        }

        private void dgwProducts_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}