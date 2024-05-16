namespace Desktop_App_.NET_8._0
{
	partial class ModifyProductForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbProducts = new ListBox();
            gbDetails = new GroupBox();
            panelHardware = new Panel();
            lblModel = new Label();
            lblManufacturer = new Label();
            label12 = new Label();
            label16 = new Label();
            label17 = new Label();
            lblPrice = new Label();
            lblType = new Label();
            lblProductName = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnEdit = new Button();
            btnStock = new Button();
            lbIngredients = new ListBox();
            gbDetails.SuspendLayout();
            panelHardware.SuspendLayout();
            SuspendLayout();
            // 
            // lbProducts
            // 
            lbProducts.BackColor = Color.FromArgb(54, 57, 74);
            lbProducts.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProducts.ForeColor = Color.White;
            lbProducts.FormattingEnabled = true;
            lbProducts.ItemHeight = 17;
            lbProducts.Location = new Point(5, 4);
            lbProducts.Margin = new Padding(3, 2, 3, 2);
            lbProducts.Name = "lbProducts";
            lbProducts.Size = new Size(382, 378);
            lbProducts.TabIndex = 0;
            lbProducts.SelectedIndexChanged += lbProducts_SelectedIndexChanged;
            // 
            // gbDetails
            // 
            gbDetails.BackColor = Color.FromArgb(35, 36, 47);
            gbDetails.Controls.Add(panelHardware);
            gbDetails.Controls.Add(lblPrice);
            gbDetails.Controls.Add(lblType);
            gbDetails.Controls.Add(lblProductName);
            gbDetails.Controls.Add(label8);
            gbDetails.Controls.Add(label7);
            gbDetails.Controls.Add(label6);
            gbDetails.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDetails.ForeColor = Color.White;
            gbDetails.Location = new Point(393, 11);
            gbDetails.Margin = new Padding(3, 2, 3, 2);
            gbDetails.Name = "gbDetails";
            gbDetails.Padding = new Padding(3, 2, 3, 2);
            gbDetails.Size = new Size(345, 335);
            gbDetails.TabIndex = 10;
            gbDetails.TabStop = false;
            gbDetails.Text = "Selected Product";
            gbDetails.Visible = false;
            // 
            // panelHardware
            // 
            panelHardware.Controls.Add(lbIngredients);
            panelHardware.Controls.Add(lblModel);
            panelHardware.Controls.Add(lblManufacturer);
            panelHardware.Controls.Add(label12);
            panelHardware.Controls.Add(label16);
            panelHardware.Controls.Add(label17);
            panelHardware.Location = new Point(10, 103);
            panelHardware.Margin = new Padding(3, 2, 3, 2);
            panelHardware.Name = "panelHardware";
            panelHardware.Size = new Size(329, 228);
            panelHardware.TabIndex = 25;
            panelHardware.Visible = false;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModel.Location = new Point(71, 26);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(39, 17);
            lblModel.TabIndex = 23;
            lblModel.Text = "Text";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManufacturer.Location = new Point(128, 2);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(39, 17);
            lblManufacturer.TabIndex = 20;
            lblManufacturer.Text = "Text";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(5, 48);
            label12.Name = "label12";
            label12.Size = new Size(95, 18);
            label12.TabIndex = 22;
            label12.Text = "Ingredients:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(5, 25);
            label16.Name = "label16";
            label16.Size = new Size(69, 18);
            label16.TabIndex = 21;
            label16.Text = "Cuisine:";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(5, 2);
            label17.Name = "label17";
            label17.Size = new Size(109, 18);
            label17.TabIndex = 20;
            label17.Text = "Course Type:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(69, 73);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(39, 17);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Text";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(67, 50);
            lblType.Name = "lblType";
            lblType.Size = new Size(39, 17);
            lblType.TabIndex = 17;
            lblType.Text = "Text";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(135, 26);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(39, 17);
            lblProductName.TabIndex = 16;
            lblProductName.Text = "Text";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 72);
            label8.Name = "label8";
            label8.Size = new Size(52, 18);
            label8.TabIndex = 14;
            label8.Text = "Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 49);
            label7.Name = "label7";
            label7.Size = new Size(49, 18);
            label7.TabIndex = 13;
            label7.Text = "Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 25);
            label6.Name = "label6";
            label6.Size = new Size(118, 18);
            label6.TabIndex = 12;
            label6.Text = "Product name:";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(30, 168, 150);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(408, 350);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(133, 32);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit details";
            btnEdit.UseVisualStyleBackColor = false;
            // btnEdit.Click += btnEdit_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(30, 168, 150);
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStock.ForeColor = Color.White;
            btnStock.Location = new Point(578, 350);
            btnStock.Margin = new Padding(3, 2, 3, 2);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(133, 32);
            btnStock.TabIndex = 12;
            btnStock.Text = "Add Stock";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // lbIngredients
            // 
            lbIngredients.BackColor = Color.FromArgb(54, 57, 74);
            lbIngredients.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIngredients.ForeColor = Color.White;
            lbIngredients.FormattingEnabled = true;
            lbIngredients.ItemHeight = 17;
            lbIngredients.Location = new Point(5, 68);
            lbIngredients.Margin = new Padding(3, 2, 3, 2);
            lbIngredients.Name = "lbIngredients";
            lbIngredients.Size = new Size(321, 157);
            lbIngredients.TabIndex = 13;
            lbIngredients.SelectedIndexChanged += lbIngredients_SelectedIndexChanged;
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 47);
            ClientSize = new Size(759, 386);
            Controls.Add(btnStock);
            Controls.Add(btnEdit);
            Controls.Add(lbProducts);
            Controls.Add(gbDetails);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModifyProductForm";
            Text = "ModifyProductForm";
            Load += ModifyProductForm_Load;
            gbDetails.ResumeLayout(false);
            gbDetails.PerformLayout();
            panelHardware.ResumeLayout(false);
            panelHardware.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbProducts;
		private GroupBox gbDetails;
		private Label label7;
		private Label label6;
		private Label label8;
		private Label lblType;
		private Label lblProductName;
		private Label lblPrice;
		private Button btnEdit;
		private Button btnStock;
		private Panel panelHardware;
		private Label lblModel;
		private Label lblManufacturer;
		private Label label12;
		private Label label16;
		private Label label17;
        private ListBox lbIngredients;
    }
}