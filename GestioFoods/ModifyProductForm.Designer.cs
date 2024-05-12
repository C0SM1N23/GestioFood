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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nudPrice = new NumericUpDown();
            nudStock = new NumericUpDown();
            cmbType = new ComboBox();
            btnFilter = new Button();
            gbDetails = new GroupBox();
            lblStock = new Label();
            label18 = new Label();
            panelGame = new Panel();
            panelHardware = new Panel();
            lblSpecs = new Label();
            lblModel = new Label();
            lblManufacturer = new Label();
            label12 = new Label();
            label16 = new Label();
            label17 = new Label();
            lblReleaseDate = new Label();
            lblPlatform = new Label();
            lblGenre = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            lblPrice = new Label();
            lblType = new Label();
            lblProductName = new Label();
            lblId = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnEdit = new Button();
            btnStock = new Button();
            tbxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            gbDetails.SuspendLayout();
            panelGame.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 7);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(407, 32);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 2;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(407, 57);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 3;
            label3.Text = "Price above:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(407, 85);
            label4.Name = "label4";
            label4.Size = new Size(102, 17);
            label4.TabIndex = 4;
            label4.Text = "Stock above:";
            // 
            // nudPrice
            // 
            nudPrice.BackColor = Color.FromArgb(30, 168, 150);
            nudPrice.BorderStyle = BorderStyle.None;
            nudPrice.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudPrice.ForeColor = Color.White;
            nudPrice.Location = new Point(509, 56);
            nudPrice.Margin = new Padding(3, 2, 3, 2);
            nudPrice.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(77, 19);
            nudPrice.TabIndex = 6;
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.FromArgb(30, 168, 150);
            nudStock.BorderStyle = BorderStyle.None;
            nudStock.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudStock.ForeColor = Color.White;
            nudStock.Location = new Point(509, 84);
            nudStock.Margin = new Padding(3, 2, 3, 2);
            nudStock.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(77, 19);
            nudStock.TabIndex = 7;
            // 
            // cmbType
            // 
            cmbType.BackColor = Color.FromArgb(30, 168, 150);
            cmbType.FlatStyle = FlatStyle.Flat;
            cmbType.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbType.ForeColor = Color.White;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(460, 30);
            cmbType.Margin = new Padding(3, 2, 3, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(139, 23);
            cmbType.TabIndex = 8;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(30, 168, 150);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(488, 110);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(133, 24);
            btnFilter.TabIndex = 9;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // gbDetails
            // 
            gbDetails.BackColor = Color.FromArgb(35, 36, 47);
            gbDetails.Controls.Add(lblStock);
            gbDetails.Controls.Add(label18);
            gbDetails.Controls.Add(panelGame);
            gbDetails.Controls.Add(lblPrice);
            gbDetails.Controls.Add(lblType);
            gbDetails.Controls.Add(lblProductName);
            gbDetails.Controls.Add(lblId);
            gbDetails.Controls.Add(label8);
            gbDetails.Controls.Add(label7);
            gbDetails.Controls.Add(label6);
            gbDetails.Controls.Add(label5);
            gbDetails.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDetails.ForeColor = Color.White;
            gbDetails.Location = new Point(392, 139);
            gbDetails.Margin = new Padding(3, 2, 3, 2);
            gbDetails.Name = "gbDetails";
            gbDetails.Padding = new Padding(3, 2, 3, 2);
            gbDetails.Size = new Size(345, 202);
            gbDetails.TabIndex = 10;
            gbDetails.TabStop = false;
            gbDetails.Text = "Selected Product";
            gbDetails.Visible = false;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(78, 110);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 17);
            lblStock.TabIndex = 21;
            lblStock.Text = "Text";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(15, 109);
            label18.Name = "label18";
            label18.Size = new Size(57, 18);
            label18.TabIndex = 20;
            label18.Text = "Stock:";
            // 
            // panelGame
            // 
            panelGame.Controls.Add(panelHardware);
            panelGame.Controls.Add(lblReleaseDate);
            panelGame.Controls.Add(lblPlatform);
            panelGame.Controls.Add(lblGenre);
            panelGame.Controls.Add(label15);
            panelGame.Controls.Add(label14);
            panelGame.Controls.Add(label13);
            panelGame.Location = new Point(10, 129);
            panelGame.Margin = new Padding(3, 2, 3, 2);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(329, 68);
            panelGame.TabIndex = 19;
            panelGame.Visible = false;
            // 
            // panelHardware
            // 
            panelHardware.Controls.Add(lblSpecs);
            panelHardware.Controls.Add(lblModel);
            panelHardware.Controls.Add(lblManufacturer);
            panelHardware.Controls.Add(label12);
            panelHardware.Controls.Add(label16);
            panelHardware.Controls.Add(label17);
            panelHardware.Location = new Point(0, 0);
            panelHardware.Margin = new Padding(3, 2, 3, 2);
            panelHardware.Name = "panelHardware";
            panelHardware.Size = new Size(329, 71);
            panelHardware.TabIndex = 25;
            panelHardware.Visible = false;
            // 
            // lblSpecs
            // 
            lblSpecs.AutoSize = true;
            lblSpecs.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecs.Location = new Point(135, 49);
            lblSpecs.Name = "lblSpecs";
            lblSpecs.Size = new Size(39, 17);
            lblSpecs.TabIndex = 24;
            lblSpecs.Text = "Text";
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
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReleaseDate.Location = new Point(122, 49);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(39, 17);
            lblReleaseDate.TabIndex = 24;
            lblReleaseDate.Text = "Text";
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlatform.Location = new Point(89, 26);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(39, 17);
            lblPlatform.TabIndex = 23;
            lblPlatform.Text = "Text";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenre.Location = new Point(71, 2);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(39, 17);
            lblGenre.TabIndex = 20;
            lblGenre.Text = "Text";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(5, 48);
            label15.Name = "label15";
            label15.Size = new Size(111, 18);
            label15.TabIndex = 22;
            label15.Text = "Release date:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(5, 25);
            label14.Name = "label14";
            label14.Size = new Size(77, 18);
            label14.TabIndex = 21;
            label14.Text = "Platform:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(5, 2);
            label13.Name = "label13";
            label13.Size = new Size(59, 18);
            label13.TabIndex = 20;
            label13.Text = "Genre:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(74, 88);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(39, 17);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Text";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(72, 65);
            lblType.Name = "lblType";
            lblType.Size = new Size(39, 17);
            lblType.TabIndex = 17;
            lblType.Text = "Text";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(140, 41);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(39, 17);
            lblProductName.TabIndex = 16;
            lblProductName.Text = "Text";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(47, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(39, 17);
            lblId.TabIndex = 15;
            lblId.Text = "Text";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 87);
            label8.Name = "label8";
            label8.Size = new Size(52, 18);
            label8.TabIndex = 14;
            label8.Text = "Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 64);
            label7.Name = "label7";
            label7.Size = new Size(49, 18);
            label7.TabIndex = 13;
            label7.Text = "Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 40);
            label6.Name = "label6";
            label6.Size = new Size(118, 18);
            label6.TabIndex = 12;
            label6.Text = "Product name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 18);
            label5.Name = "label5";
            label5.Size = new Size(26, 18);
            label5.TabIndex = 11;
            label5.Text = "Id:";
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
            btnEdit.Click += btnEdit_Click;
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
            // tbxName
            // 
            tbxName.BackColor = Color.FromArgb(30, 168, 150);
            tbxName.BorderStyle = BorderStyle.None;
            tbxName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxName.ForeColor = Color.White;
            tbxName.Location = new Point(460, 5);
            tbxName.Margin = new Padding(3, 2, 3, 2);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(189, 19);
            tbxName.TabIndex = 13;
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 47);
            ClientSize = new Size(759, 386);
            Controls.Add(tbxName);
            Controls.Add(btnStock);
            Controls.Add(btnEdit);
            Controls.Add(btnFilter);
            Controls.Add(cmbType);
            Controls.Add(nudStock);
            Controls.Add(nudPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbProducts);
            Controls.Add(gbDetails);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModifyProductForm";
            Text = "ModifyProductForm";
            Load += ModifyProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            gbDetails.ResumeLayout(false);
            gbDetails.PerformLayout();
            panelGame.ResumeLayout(false);
            panelGame.PerformLayout();
            panelHardware.ResumeLayout(false);
            panelHardware.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbProducts;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private NumericUpDown nudPrice;
		private NumericUpDown nudStock;
		private ComboBox cmbType;
		private Button btnFilter;
		private GroupBox gbDetails;
		private Label label5;
		private Label label7;
		private Label label6;
		private Label label8;
		private Label lblId;
		private Label lblType;
		private Label lblProductName;
		private Label lblPrice;
		private Panel panelGame;
		private Button btnEdit;
		private Button btnStock;
		private Label label15;
		private Label label14;
		private Label label13;
		private Label lblReleaseDate;
		private Label lblPlatform;
		private Label lblGenre;
		private Panel panelHardware;
		private Label lblSpecs;
		private Label lblModel;
		private Label lblManufacturer;
		private Label label12;
		private Label label16;
		private Label label17;
		private Label label18;
        private TextBox tbxName;
        private Label lblStock;
    }
}