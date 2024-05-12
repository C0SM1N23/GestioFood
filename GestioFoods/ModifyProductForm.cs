using Gaming_Bros_Desktop_App;
using Logic_Layer;
using System.Data;

namespace Desktop_App_.NET_8._0
{
    public partial class ModifyProductForm : Form
    {
        private ProductManager productManager;
        private Product selectedProduct;
        private SqlDatabase db;
        public ModifyProductForm(ProductManager productmanager)
        {
            InitializeComponent();
            db = new SqlDatabase();
            productManager = productmanager;
            cmbType.DataSource = Enum.GetValues(typeof(ProductType));
            foreach (Product p in productManager.GetDBProducts())
            {
                lbProducts.Items.Add(p);
            }
        }
        public void UpdateProductList(List<Product> products)
        {
            lbProducts.Items.Clear();
            foreach (Product product in products)
            {
                lbProducts.Items.Add(product);
            }

        }
        private void ModifyProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            lbProducts.Items.Clear();
            string name = tbxName.Text;
            ProductType productType = (ProductType)cmbType.SelectedItem;
            double price = Convert.ToInt32(nudPrice.Value);
            int stock = Convert.ToInt32(nudStock.Value);
            var filteredProducts = productManager.GetProducts().Where(p =>
                (p.ProductType == productType) &&
                (price == 0 || p.Price > price) &&
                (stock == 0 || p.Quantity > stock) &&
                (string.IsNullOrEmpty(name) || p.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase))
            );
            foreach (Product product in filteredProducts)
            {
                lbProducts.Items.Add(product);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditDetailsForm editForm = new EditDetailsForm(this, productManager, selectedProduct);
            editForm.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            AddStock addStockForm = new AddStock(this, productManager, selectedProduct);
            addStockForm.Show();
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProducts.SelectedItem is null)
            {
                //
                return;
            }

            if (!(lbProducts.SelectedItem is Product))
            {
                //
                return;
            }

            //int selectedIndex = lbProducts.SelectedIndex;
            //selectedProduct = productManager.GetProducts()[selectedIndex];

            selectedProduct = (Product)lbProducts.SelectedItem;

            lblId.Text = selectedProduct.Id.ToString();
            lblProductName.Text = selectedProduct.Name;
            lblPrice.Text = selectedProduct.Price.ToString();
            lblType.Text = selectedProduct.ProductType.ToString();
            lblStock.Text = selectedProduct.Quantity.ToString();
            gbDetails.Visible = true;

            if (selectedProduct is Game game)
            {
                panelHardware.Visible = false;
                panelGame.Visible = true;
                lblGenre.Text = game.Genre.ToString();
                lblPlatform.Text = game.Platform.ToString();
                lblReleaseDate.Text = game.ReleaseDate.ToString();

            }
            else if (selectedProduct is Hardware hardware)
            {
                panelHardware.Visible = true;
                lblManufacturer.Text = hardware.Manufacturer.ToString();
                lblModel.Text = hardware.Model.ToString();
                lblSpecs.Text = hardware.Specifications.ToString();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
