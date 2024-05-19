using ClassLibrary1.class1;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace Desktop_App_.NET_8._0
{
    public partial class EditDetailsForm : Form
    {
        ModifyProductForm modifyForm;
        ProductManager productManager;
        Product editedProduct;
        public EditDetailsForm(ModifyProductForm modifyform, ProductManager productmanager, Product selectedProduct)
        {
            InitializeComponent();
            this.modifyForm = modifyform;
            this.productManager = productmanager;
            this.editedProduct = selectedProduct;
            cmbGenre.DataSource = Enum.GetValues(typeof(Food));
            cmbPlatform.DataSource = Enum.GetValues(typeof(Platform));
            tbName.Text = editedProduct.Name;
            nudPrice.Value = Convert.ToDecimal(editedProduct.Price);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            double price = Convert.ToDouble(nudPrice.Value);
            if (editedProduct is Game game)
            {

                Genre genre = (Genre)cmbGenre.SelectedItem;
                Platform platform = (Platform)cmbPlatform.SelectedItem;
                DateTime date = dateTime.Value;
                productManager.ModifyGame(game, name, price, genre, platform, date);
                modifyForm.UpdateProductList(productManager.GetProducts());
                MessageBox.Show("Game succesfully updated!");
                this.Close();
            }
            else if (editedProduct is Hardware hardware)
            {
                string manufacturer = tbManufacturer.Text;
                string model = tbModel.Text;
                string specifications = rtbSpecs.Text;
                productManager.ModifyHardware(hardware, name, price, manufacturer, model, specifications);
                modifyForm.UpdateProductList(productManager.GetProducts());
                MessageBox.Show("Hardware succesfully updated!");
                this.Close();
            }
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EditDetailsForm_Load(object sender, EventArgs e)
        {
            if (editedProduct is Game game)
            {
                cmbGenre.SelectedItem = game.Genre;
                cmbPlatform.SelectedItem = game.Platform;
                dateTime.Value = game.ReleaseDate;
                panelGame.Visible = true;
            }
            else if (editedProduct is Hardware hardware)
            {
                tbManufacturer.Text = hardware.Manufacturer;
                tbModel.Text = hardware.Model;
                rtbSpecs.Text = hardware.Specifications;
                panelHardware.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = checkBox1.Checked;
            if (btnDelete.Enabled)
            {
                btnDelete.BackColor = btnEdit.BackColor;
            }
            else
            {
                btnDelete.BackColor = Color.FromArgb(54, 57, 74);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            productManager.DeleteProduct(editedProduct.Id);
            MessageBox.Show("Product deleted permanently!");
            this.Close();
            modifyForm.UpdateProductList(productManager.GetProducts());
        }
    }
}
