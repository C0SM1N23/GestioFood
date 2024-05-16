using ClassLibrary1.class1;

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
        IngredientManager ingredientManager;
        Ingredients editedIngredient;
        private ModifyProductForm modifyProductForm;
        private ProductManager productManager;
        private Product selectedProduct;

        public AddStock(ModifyProductForm modifyform, Ingredients selectedIngredient, IngredientManager ingredientManager)
        {
            InitializeComponent();
            this.modifyForm = modifyform;
            this.ingredientManager = ingredientManager;
            this.editedIngredient = selectedIngredient;
        }

        public AddStock(ModifyProductForm modifyProductForm, ProductManager productManager, Product selectedProduct)
        {
            this.modifyProductForm = modifyProductForm;
            this.productManager = productManager;
            this.selectedProduct = selectedProduct;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            int stock = Convert.ToInt32(nudStock.Value);
            ingredientManager.AddStock(editedIngredient ,stock);
            modifyForm.UpdateProductList(ingredientManager.getIngredients());
            MessageBox.Show("Stock succesfully updated!");
            this.Close();
        }

        private void AddStock_Load(object sender, EventArgs e)
        {

        }
    }
}
