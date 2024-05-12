using Gaming_Bros_Desktop_App;
using Logic_Layer;

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
            cmbGenre.DataSource = Enum.GetValues(typeof(Genre));
            cmbPlatform.DataSource = Enum.GetValues(typeof(Platform));
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
            double price = Convert.ToDouble(nudPrice.Text);

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
                        ProductType producttype = ProductType.Game;
                        Genre genre = (Genre)cmbGenre.SelectedItem;
                        Platform platform = (Platform)cmbPlatform.SelectedItem;
                        DateTime releasedate = releaseDate.Value.Date;
                        if (genre == null || platform == null || releasedate == DateTime.MinValue)
                        {
                            MessageBox.Show("All fields should be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Game game = new Game(name, ProductType.Game, price, genre, platform, releasedate, 0);
                            productManager.AddProductDB(game);
                            editProductForm.UpdateProductList(productManager.GetProducts());
                            MessageBox.Show("Game added succesfully!");
                        }
                    }
                    else
                    {
                        ProductType productType = ProductType.Hardware;
                        string manufacturer = tbManufacturer.Text;
                        string model = tbModel.Text;
                        string specifications = rtbSpecs.Text;
                        if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(specifications))
                        {
                            MessageBox.Show("All fields should be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            Hardware hardware = new Hardware(name, ProductType.Hardware, price, manufacturer, model, specifications, 0);
                            productManager.AddProductDB(hardware);
                            editProductForm.UpdateProductList(productManager.GetProducts());
                            MessageBox.Show("Hardware added succesfully!");
                        }
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}