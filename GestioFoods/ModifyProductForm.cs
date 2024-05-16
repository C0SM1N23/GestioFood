

using ClassLibrary1.class1;
using System.Data;

namespace Desktop_App_.NET_8._0
{

    public partial class ModifyProductForm : Form
    {
        private ProductManager productManager;
        private Product selectedProduct;
        private Ingredients selectedIngredient;
        private SqlDatabase db;
        private IngredientManager ingredientManager;

        public ModifyProductForm(ProductManager productmanager, IngredientManager ingredientmanager)
        {
            InitializeComponent();
            db = new SqlDatabase();
            productManager = productmanager;
            ingredientManager = ingredientmanager;
            //cmbType.DataSource = Enum.GetValues(typeof(ProductType));
            foreach (Product p in productManager.GetProducts())
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
        public void UpdateIngredientsList(List<Ingredients> ingredients)
        {
            lbIngredients.Items.Clear();
            foreach (Ingredients i in ingredients)
            {
                lbIngredients.Items.Add(i);
            }

        }
        private void ModifyProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    EditDetailsForm editForm = new EditDetailsForm(this, productManager, selectedProduct);
        //    editForm.Show();
        //}

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
            


            lblProductName.Text = selectedProduct.Name;
            lblPrice.Text = selectedProduct.Price.ToString();
            lblType.Text = selectedProduct.ProductType.ToString();

            gbDetails.Visible = true;

            if (selectedProduct is Food food)
            {
                panelHardware.Visible = true;
                UpdateIngredientsList(food.Ingredients);

                

            }
            else if (selectedProduct is Beverage beverage)
            {
                panelHardware.Visible = false;

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lbIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbIngredients.SelectedItem is null)
            {
                //
                return;
            }

            if (!(lbIngredients.SelectedItem is Ingredients))
            {
                //
                return;
            }
            selectedIngredient = (Ingredients)lbIngredients.SelectedItem;
            

        }

        internal void UpdateProductList(List<Ingredients> ingredients)
        {
            throw new NotImplementedException();
        }
    }
}
