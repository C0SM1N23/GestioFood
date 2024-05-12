namespace Desktop_App_.NET_8._0
{
	partial class AddProductForm
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
            tbName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nudPrice = new NumericUpDown();
            label4 = new Label();
            rbGame = new RadioButton();
            rbHardware = new RadioButton();
            label5 = new Label();
            cmbGenre = new ComboBox();
            cmbPlatform = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            releaseDate = new DateTimePicker();
            panelHardware = new Panel();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton13 = new RadioButton();
            radioButton14 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            rtbDough = new RadioButton();
            label10 = new Label();
            tbModel = new TextBox();
            label9 = new Label();
            tbManufacturer = new TextBox();
            Manufaturer = new Label();
            btnAdd = new Button();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton10 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            panelHardware.SuspendLayout();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.BackColor = Color.FromArgb(30, 168, 150);
            tbName.BorderStyle = BorderStyle.None;
            tbName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbName.ForeColor = Color.White;
            tbName.Location = new Point(131, 58);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(189, 19);
            tbName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 58);
            label1.Name = "label1";
            label1.Size = new Size(57, 18);
            label1.TabIndex = 6;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(259, 15);
            label2.Name = "label2";
            label2.Size = new Size(165, 24);
            label2.TabIndex = 8;
            label2.Text = "Create a product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(69, 88);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 9;
            label3.Text = "Price:";
            // 
            // nudPrice
            // 
            nudPrice.BackColor = Color.FromArgb(30, 168, 150);
            nudPrice.BorderStyle = BorderStyle.None;
            nudPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudPrice.ForeColor = Color.White;
            nudPrice.Location = new Point(131, 88);
            nudPrice.Margin = new Padding(3, 2, 3, 2);
            nudPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(108, 22);
            nudPrice.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(69, 119);
            label4.Name = "label4";
            label4.Size = new Size(154, 17);
            label4.TabIndex = 11;
            label4.Text = "Select product type:";
            // 
            // rbGame
            // 
            rbGame.AutoSize = true;
            rbGame.Checked = true;
            rbGame.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbGame.ForeColor = Color.White;
            rbGame.Location = new Point(69, 145);
            rbGame.Margin = new Padding(3, 2, 3, 2);
            rbGame.Name = "rbGame";
            rbGame.Size = new Size(62, 21);
            rbGame.TabIndex = 12;
            rbGame.TabStop = true;
            rbGame.Text = "Food";
            rbGame.UseVisualStyleBackColor = true;
            rbGame.CheckedChanged += rbGame_CheckedChanged;
            // 
            // rbHardware
            // 
            rbHardware.AutoSize = true;
            rbHardware.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbHardware.ForeColor = Color.White;
            rbHardware.Location = new Point(182, 145);
            rbHardware.Margin = new Padding(3, 2, 3, 2);
            rbHardware.Name = "rbHardware";
            rbHardware.Size = new Size(95, 21);
            rbHardware.TabIndex = 13;
            rbHardware.Text = "Beverage";
            rbHardware.UseVisualStyleBackColor = true;
            rbHardware.CheckedChanged += rbHardware_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(69, 192);
            label5.Name = "label5";
            label5.Size = new Size(59, 18);
            label5.TabIndex = 14;
            label5.Text = "Genre:";
            // 
            // cmbGenre
            // 
            cmbGenre.BackColor = Color.FromArgb(30, 168, 150);
            cmbGenre.FlatStyle = FlatStyle.Flat;
            cmbGenre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbGenre.ForeColor = Color.White;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(135, 188);
            cmbGenre.Margin = new Padding(3, 2, 3, 2);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(139, 28);
            cmbGenre.TabIndex = 15;
            // 
            // cmbPlatform
            // 
            cmbPlatform.BackColor = Color.FromArgb(30, 168, 150);
            cmbPlatform.FlatStyle = FlatStyle.Flat;
            cmbPlatform.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPlatform.ForeColor = Color.White;
            cmbPlatform.FormattingEnabled = true;
            cmbPlatform.Location = new Point(427, 188);
            cmbPlatform.Margin = new Padding(3, 2, 3, 2);
            cmbPlatform.Name = "cmbPlatform";
            cmbPlatform.Size = new Size(139, 28);
            cmbPlatform.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(343, 192);
            label6.Name = "label6";
            label6.Size = new Size(77, 18);
            label6.TabIndex = 16;
            label6.Text = "Platform:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(194, 248);
            label7.Name = "label7";
            label7.Size = new Size(111, 18);
            label7.TabIndex = 18;
            label7.Text = "Release date:";
            // 
            // releaseDate
            // 
            releaseDate.CalendarMonthBackground = Color.FromArgb(30, 168, 150);
            releaseDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            releaseDate.Location = new Point(312, 244);
            releaseDate.Margin = new Padding(3, 2, 3, 2);
            releaseDate.Name = "releaseDate";
            releaseDate.Size = new Size(219, 26);
            releaseDate.TabIndex = 19;
            releaseDate.Value = new DateTime(2024, 3, 28, 0, 0, 0, 0);
            // 
            // panelHardware
            // 
            panelHardware.Controls.Add(radioButton4);
            panelHardware.Controls.Add(radioButton5);
            panelHardware.Controls.Add(radioButton10);
            panelHardware.Controls.Add(radioButton11);
            panelHardware.Controls.Add(radioButton12);
            panelHardware.Controls.Add(radioButton13);
            panelHardware.Controls.Add(radioButton14);
            panelHardware.Controls.Add(radioButton6);
            panelHardware.Controls.Add(radioButton7);
            panelHardware.Controls.Add(radioButton8);
            panelHardware.Controls.Add(radioButton9);
            panelHardware.Controls.Add(radioButton3);
            panelHardware.Controls.Add(radioButton2);
            panelHardware.Controls.Add(radioButton1);
            panelHardware.Controls.Add(rtbDough);
            panelHardware.Controls.Add(label10);
            panelHardware.Controls.Add(tbModel);
            panelHardware.Controls.Add(label9);
            panelHardware.Controls.Add(tbManufacturer);
            panelHardware.Controls.Add(Manufaturer);
            panelHardware.Location = new Point(69, 178);
            panelHardware.Margin = new Padding(3, 2, 3, 2);
            panelHardware.Name = "panelHardware";
            panelHardware.Size = new Size(608, 157);
            panelHardware.TabIndex = 20;
            panelHardware.Visible = false;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton11.ForeColor = Color.White;
            radioButton11.Location = new Point(409, 116);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(74, 19);
            radioButton11.TabIndex = 39;
            radioButton11.TabStop = true;
            radioButton11.Text = "Sausage";
            radioButton11.TextAlign = ContentAlignment.TopLeft;
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton12.ForeColor = Color.White;
            radioButton12.Location = new Point(302, 116);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(85, 19);
            radioButton12.TabIndex = 38;
            radioButton12.TabStop = true;
            radioButton12.Text = "Parmesan ";
            radioButton12.TextAlign = ContentAlignment.TopLeft;
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton13.ForeColor = Color.White;
            radioButton13.Location = new Point(206, 117);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(64, 19);
            radioButton13.TabIndex = 37;
            radioButton13.TabStop = true;
            radioButton13.Text = "Onions";
            radioButton13.TextAlign = ContentAlignment.TopLeft;
            radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            radioButton14.AutoSize = true;
            radioButton14.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton14.ForeColor = Color.White;
            radioButton14.Location = new Point(105, 117);
            radioButton14.Name = "radioButton14";
            radioButton14.Size = new Size(86, 19);
            radioButton14.TabIndex = 36;
            radioButton14.TabStop = true;
            radioButton14.Text = "Mozzarella";
            radioButton14.TextAlign = ContentAlignment.TopLeft;
            radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton6.ForeColor = Color.White;
            radioButton6.Location = new Point(409, 91);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(69, 19);
            radioButton6.TabIndex = 34;
            radioButton6.TabStop = true;
            radioButton6.Text = "Chicken";
            radioButton6.TextAlign = ContentAlignment.TopLeft;
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton7.ForeColor = Color.White;
            radioButton7.Location = new Point(302, 91);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(57, 19);
            radioButton7.TabIndex = 33;
            radioButton7.TabStop = true;
            radioButton7.Text = "Garlic";
            radioButton7.TextAlign = ContentAlignment.TopLeft;
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton8.ForeColor = Color.White;
            radioButton8.Location = new Point(206, 92);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(91, 19);
            radioButton8.TabIndex = 32;
            radioButton8.TabStop = true;
            radioButton8.Text = "Mushrooms";
            radioButton8.TextAlign = ContentAlignment.TopLeft;
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton9.ForeColor = Color.White;
            radioButton9.Location = new Point(105, 92);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(103, 19);
            radioButton9.TabIndex = 31;
            radioButton9.TabStop = true;
            radioButton9.Text = "Tomato sauce";
            radioButton9.TextAlign = ContentAlignment.TopLeft;
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.White;
            radioButton3.Location = new Point(409, 66);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(63, 19);
            radioButton3.TabIndex = 29;
            radioButton3.TabStop = true;
            radioButton3.Text = "Ricotta";
            radioButton3.TextAlign = ContentAlignment.TopLeft;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(302, 66);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 19);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "Olives";
            radioButton2.TextAlign = ContentAlignment.TopLeft;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(206, 67);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 19);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pepperoni";
            radioButton1.TextAlign = ContentAlignment.TopLeft;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // rtbDough
            // 
            rtbDough.AutoSize = true;
            rtbDough.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbDough.ForeColor = Color.White;
            rtbDough.Location = new Point(105, 67);
            rtbDough.Name = "rtbDough";
            rtbDough.Size = new Size(62, 19);
            rtbDough.TabIndex = 26;
            rtbDough.TabStop = true;
            rtbDough.Text = "Dough";
            rtbDough.TextAlign = ContentAlignment.TopLeft;
            rtbDough.UseVisualStyleBackColor = true;
            rtbDough.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(4, 68);
            label10.Name = "label10";
            label10.Size = new Size(95, 18);
            label10.TabIndex = 25;
            label10.Text = "Ingredients:";
            // 
            // tbModel
            // 
            tbModel.BackColor = Color.FromArgb(30, 168, 150);
            tbModel.BorderStyle = BorderStyle.None;
            tbModel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbModel.ForeColor = Color.White;
            tbModel.Location = new Point(69, 39);
            tbModel.Margin = new Padding(3, 2, 3, 2);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(189, 19);
            tbModel.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(4, 40);
            label9.Name = "label9";
            label9.Size = new Size(69, 18);
            label9.TabIndex = 23;
            label9.Text = "Cuisine:";
            // 
            // tbManufacturer
            // 
            tbManufacturer.BackColor = Color.FromArgb(30, 168, 150);
            tbManufacturer.BorderStyle = BorderStyle.None;
            tbManufacturer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbManufacturer.ForeColor = Color.White;
            tbManufacturer.Location = new Point(125, 9);
            tbManufacturer.Margin = new Padding(3, 2, 3, 2);
            tbManufacturer.Name = "tbManufacturer";
            tbManufacturer.Size = new Size(189, 19);
            tbManufacturer.TabIndex = 22;
            // 
            // Manufaturer
            // 
            Manufaturer.AutoSize = true;
            Manufaturer.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manufaturer.ForeColor = Color.White;
            Manufaturer.Location = new Point(4, 12);
            Manufaturer.Name = "Manufaturer";
            Manufaturer.Size = new Size(109, 18);
            Manufaturer.TabIndex = 21;
            Manufaturer.Text = "Course Type:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(30, 168, 150);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(259, 354);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(174, 41);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = Color.White;
            radioButton4.Location = new Point(508, 116);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(86, 19);
            radioButton4.TabIndex = 42;
            radioButton4.TabStop = true;
            radioButton4.Text = "BBQ sauce";
            radioButton4.TextAlign = ContentAlignment.TopLeft;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton5.ForeColor = Color.White;
            radioButton5.Location = new Point(508, 91);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(79, 19);
            radioButton5.TabIndex = 41;
            radioButton5.TabStop = true;
            radioButton5.Text = "Prosciutto";
            radioButton5.TextAlign = ContentAlignment.TopLeft;
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton10.ForeColor = Color.White;
            radioButton10.Location = new Point(508, 66);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(60, 19);
            radioButton10.TabIndex = 40;
            radioButton10.TabStop = true;
            radioButton10.Text = "Bacon";
            radioButton10.TextAlign = ContentAlignment.TopLeft;
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 47);
            ClientSize = new Size(743, 412);
            Controls.Add(btnAdd);
            Controls.Add(panelHardware);
            Controls.Add(releaseDate);
            Controls.Add(label7);
            Controls.Add(cmbPlatform);
            Controls.Add(label6);
            Controls.Add(cmbGenre);
            Controls.Add(label5);
            Controls.Add(rbHardware);
            Controls.Add(rbGame);
            Controls.Add(label4);
            Controls.Add(nudPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            panelHardware.ResumeLayout(false);
            panelHardware.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
		private Label label1;
		private Label label2;
		private Label label3;
		private NumericUpDown nudPrice;
		private Label label4;
		private RadioButton rbGame;
		private RadioButton rbHardware;
		private Label label5;
		private ComboBox cmbGenre;
		private ComboBox cmbPlatform;
		private Label label6;
		private Label label7;
		private DateTimePicker releaseDate;
		private Panel panelHardware;
		private TextBox tbManufacturer;
		private Label Manufaturer;
		private TextBox tbModel;
		private Label label9;
		private Label label10;
		private Button btnAdd;
        private RadioButton rtbDough;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton10;
    }
}