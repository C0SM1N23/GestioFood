
using ClassLibrary1.class1;

namespace Desktop_App_.NET_8._0
{
    public partial class AddProductForm : Form
    {
        private ModifyProductForm editProductForm;
        private ProductManager productManager;
        readonly SqlDatabase sqlDB = new SqlDatabase();


        public AddProductForm(ModifyProductForm editForm, ProductManager ProductManager)
        {
            InitializeComponent();
            editProductForm = editForm;
            productManager = ProductManager;

            rbGame.Checked = true;
        }

        private void rbGame_CheckedChanged(object sender, EventArgs e)
        {
            panelHardware.Visible = false;
        }

        private void rbHardware_CheckedChanged(object sender, EventArgs e)
        {
            panelHardware.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            decimal price = Convert.ToDecimal(nudPrice.Text);

            bool productExists = productManager.GetProducts().Any(p => p.Name == name);

            if (productExists)
            {
                MessageBox.Show("Product already exists in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(name) || !double.TryParse(nudPrice.Text, out price))
                {
                    MessageBox.Show("All fields should be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rbGame.Checked)
                    {
                        string courseType = cmbCourse.SelectedItem.ToString();
                        string Cuisine = cmbCuisine.SelectedItem.ToString();

                        if (courseType == null || Cuisine == null)
                        {
                            MessageBox.Show("All fields should be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            List<Ingredients> selectedIngredients = new List<Ingredients>();

                            // Event handler for Add Product button click

                            foreach (Control control in this.Controls)
                            {
                                if (control is RadioButton && ((RadioButton)control).Checked)
                                {
                                    string ingredientName = control.Text;
                                    Ingredients ingredient = new Ingredients(ingredientName, 0);
                                    selectedIngredients.Add(ingredient);
                                }
                            }
                            
                            Food food = new Food(name, price, selectedIngredients) ;
                            productManager.AddProduct(food);
                            editProductForm.UpdateProductList(productManager.GetProducts());
                            MessageBox.Show("Menu item added succesfully!");
                        }
                    }
                    else
                    {
                        Beverage beverage = new Beverage(name, price, 0);    
                        productManager.AddProduct(beverage);
                        editProductForm.UpdateProductList(productManager.GetProducts());
                        MessageBox.Show("Beverage added succesfully!");

                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}