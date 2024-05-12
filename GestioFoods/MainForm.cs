using FontAwesome.Sharp;
using Gaming_Bros_Desktop_App;
using Logic_Layer;
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
        public MainForm()
        {
            productmanager = new ProductManager();
            editForm = new ModifyProductForm(productmanager);
            addForm = new AddProductForm(editForm, productmanager);
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

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(30, 168, 150));
            OpenChildForm(new SeeIngredientsForm());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
