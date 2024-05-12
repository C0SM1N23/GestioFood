using Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_App_.NET_8._0
{
    public partial class AddStock : Form
    {
        ModifyProductForm modifyForm;
        ProductManager productManager;
        Product editedProduct;
        public AddStock(ModifyProductForm modifyform, ProductManager productmanager, Product selectedProduct)
        {
            InitializeComponent();
            this.modifyForm = modifyform; 
            this.productManager = productmanager;
            this.editedProduct = selectedProduct;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            int stock = Convert.ToInt32(nudStock.Value);
            productManager.AddStock(editedProduct.Id, stock);
            modifyForm.UpdateProductList(productManager.GetProducts());
            MessageBox.Show("Stock succesfully updated!");
            this.Close();
        }
    }
}
