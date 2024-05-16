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
            btnAdd = new Button();
            checkBox1 = new CheckBox();
            Manufaturer = new Label();
            label9 = new Label();
            label10 = new Label();
            cmbCourse = new ComboBox();
            cmbCuisine = new ComboBox();
            panelHardware = new Panel();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
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
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(30, 168, 150);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(259, 360);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(174, 41);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(108, 69);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 19);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Dough";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
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
            // cmbCourse
            // 
            cmbCourse.BackColor = Color.White;
            cmbCourse.ForeColor = Color.Black;
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "Breakfast", "Lunch", "Dinner" });
            cmbCourse.Location = new Point(117, 12);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(171, 23);
            cmbCourse.TabIndex = 43;
            cmbCourse.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbCuisine
            // 
            cmbCuisine.BackColor = Color.White;
            cmbCuisine.ForeColor = Color.Black;
            cmbCuisine.FormattingEnabled = true;
            cmbCuisine.Items.AddRange(new object[] { "Italian", "American" });
            cmbCuisine.Location = new Point(79, 38);
            cmbCuisine.Name = "cmbCuisine";
            cmbCuisine.Size = new Size(171, 23);
            cmbCuisine.TabIndex = 44;
            // 
            // panelHardware
            // 
            panelHardware.Controls.Add(checkBox13);
            panelHardware.Controls.Add(checkBox14);
            panelHardware.Controls.Add(checkBox15);
            panelHardware.Controls.Add(checkBox10);
            panelHardware.Controls.Add(checkBox11);
            panelHardware.Controls.Add(checkBox12);
            panelHardware.Controls.Add(checkBox7);
            panelHardware.Controls.Add(checkBox8);
            panelHardware.Controls.Add(checkBox9);
            panelHardware.Controls.Add(checkBox4);
            panelHardware.Controls.Add(checkBox5);
            panelHardware.Controls.Add(checkBox6);
            panelHardware.Controls.Add(checkBox3);
            panelHardware.Controls.Add(checkBox2);
            panelHardware.Controls.Add(checkBox1);
            panelHardware.Controls.Add(cmbCuisine);
            panelHardware.Controls.Add(cmbCourse);
            panelHardware.Controls.Add(label10);
            panelHardware.Controls.Add(label9);
            panelHardware.Controls.Add(Manufaturer);
            panelHardware.Location = new Point(69, 184);
            panelHardware.Margin = new Padding(3, 2, 3, 2);
            panelHardware.Name = "panelHardware";
            panelHardware.Size = new Size(608, 157);
            panelHardware.TabIndex = 20;
            panelHardware.Paint += panelHardware_Paint;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.ForeColor = Color.White;
            checkBox13.Location = new Point(450, 117);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(50, 19);
            checkBox13.TabIndex = 58;
            checkBox13.Text = "Basil";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.ForeColor = Color.White;
            checkBox14.Location = new Point(450, 92);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(63, 19);
            checkBox14.TabIndex = 57;
            checkBox14.Text = "Parsley";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.ForeColor = Color.White;
            checkBox15.Location = new Point(450, 67);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(73, 19);
            checkBox15.TabIndex = 56;
            checkBox15.Text = "Avocado";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.ForeColor = Color.White;
            checkBox10.Location = new Point(380, 117);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(52, 19);
            checkBox10.TabIndex = 55;
            checkBox10.Text = "Ham";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.ForeColor = Color.White;
            checkBox11.Location = new Point(380, 92);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(59, 19);
            checkBox11.TabIndex = 54;
            checkBox11.Text = "Bacon";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.ForeColor = Color.White;
            checkBox12.Location = new Point(380, 67);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(51, 19);
            checkBox12.TabIndex = 53;
            checkBox12.Text = "Eggs";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.ForeColor = Color.White;
            checkBox7.Location = new Point(293, 118);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(89, 19);
            checkBox7.TabIndex = 52;
            checkBox7.Text = "Black Olives";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.ForeColor = Color.White;
            checkBox8.Location = new Point(293, 92);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(56, 19);
            checkBox8.TabIndex = 51;
            checkBox8.Text = "Garlic";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.ForeColor = Color.White;
            checkBox9.Location = new Point(293, 68);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(80, 19);
            checkBox9.TabIndex = 50;
            checkBox9.Text = "Prosciutto";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.ForeColor = Color.White;
            checkBox4.Location = new Point(205, 118);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(64, 19);
            checkBox4.TabIndex = 49;
            checkBox4.Text = "Onions";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.ForeColor = Color.White;
            checkBox5.Location = new Point(205, 93);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(90, 19);
            checkBox5.TabIndex = 48;
            checkBox5.Text = "Mushrooms";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.ForeColor = Color.White;
            checkBox6.Location = new Point(205, 68);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(80, 19);
            checkBox6.TabIndex = 47;
            checkBox6.Text = "Pepperoni";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(108, 117);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(82, 19);
            checkBox3.TabIndex = 46;
            checkBox3.Text = "Mozzarella";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(108, 92);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(100, 19);
            checkBox2.TabIndex = 45;
            checkBox2.Text = "Tomato Sauce";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 47);
            ClientSize = new Size(743, 412);
            Controls.Add(btnAdd);
            Controls.Add(panelHardware);
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
            Load += AddProductForm_Load;
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
		private Button btnAdd;
        private CheckBox checkBox1;
        private Label Manufaturer;
        private Label label9;
        private Label label10;
        private ComboBox cmbCourse;
        private ComboBox cmbCuisine;
        private Panel panelHardware;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
    }
}