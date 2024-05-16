using ClassLibrary1.class1;
using FontAwesome.Sharp;

using Color = System.Drawing.Color;

namespace Desktop_App_.NET_8._0
{
    public partial class MainForm : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private ModifyProductForm editForm;
        private AddProductForm addForm;
        private ProductManager productmanager;
        private IngredientManager ingredientmanager;
        public MainForm()
        {   
            ingredientmanager = new IngredientManager();
            productmanager = new ProductManager();
            editForm = new ModifyProductForm(productmanager, ingredientmanager);
            addForm = new AddProductForm(editForm, productmanager, ingredientmanager);
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(54, 57, 74);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(54, 57, 74);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(30, 168, 150));
            OpenChildForm(addForm);
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(30, 168, 150));
            OpenChildForm(editForm);
        }

        private void iconbutton3_click_1(object sender, EventArgs e)
        {
        //    activatebutton(sender, color.fromargb(30, 168, 150));
        //    openchildform(new seeingredientsform());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
