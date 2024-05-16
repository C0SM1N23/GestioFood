namespace Desktop_App_.NET_8._0
{
	partial class EditDetailsForm
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
            panelHardware = new Panel();
            rtbSpecs = new RichTextBox();
            label10 = new Label();
            tbModel = new TextBox();
            label9 = new Label();
            tbManufacturer = new TextBox();
            Manufaturer = new Label();
            dateTime = new DateTimePicker();
            label7 = new Label();
            cmbPlatform = new ComboBox();
            label6 = new Label();
            cmbGenre = new ComboBox();
            label5 = new Label();
            nudPrice = new NumericUpDown();
            label3 = new Label();
            tbName = new TextBox();
            label1 = new Label();
            panelGame = new Panel();
            btnEdit = new Button();
            label2 = new Label();
            btnDelete = new Button();
            checkBox1 = new CheckBox();
            panelHardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            panelGame.SuspendLayout();
            SuspendLayout();
            // 
            // panelHardware
            // 
            panelHardware.Controls.Add(rtbSpecs);
            panelHardware.Controls.Add(label10);
            panelHardware.Controls.Add(tbModel);
            panelHardware.Controls.Add(label9);
            panelHardware.Controls.Add(tbManufacturer);
            panelHardware.Controls.Add(Manufaturer);
            panelHardware.Location = new Point(12, 132);
            panelHardware.Name = "panelHardware";
            panelHardware.Size = new Size(415, 204);
            panelHardware.TabIndex = 34;
            panelHardware.Visible = false;
            // 
            // rtbSpecs
            // 
            rtbSpecs.BackColor = Color.FromArgb(30, 168, 150);
            rtbSpecs.BorderStyle = BorderStyle.None;
            rtbSpecs.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            rtbSpecs.ForeColor = Color.White;
            rtbSpecs.Location = new Point(135, 91);
            rtbSpecs.Name = "rtbSpecs";
            rtbSpecs.Size = new Size(257, 86);
            rtbSpecs.TabIndex = 26;
            rtbSpecs.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(4, 90);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 25;
            label10.Text = "Specifications:";
            // 
            // tbModel
            // 
            tbModel.BackColor = Color.FromArgb(30, 168, 150);
            tbModel.BorderStyle = BorderStyle.None;
            tbModel.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            tbModel.ForeColor = Color.White;
            tbModel.Location = new Point(74, 54);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(216, 19);
            tbModel.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(4, 54);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 23;
            label9.Text = "Model:";
            // 
            // tbManufacturer
            // 
            tbManufacturer.BackColor = Color.FromArgb(30, 168, 150);
            tbManufacturer.BorderStyle = BorderStyle.None;
            tbManufacturer.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            tbManufacturer.ForeColor = Color.White;
            tbManufacturer.Location = new Point(135, 16);
            tbManufacturer.Name = "tbManufacturer";
            tbManufacturer.Size = new Size(216, 19);
            tbManufacturer.TabIndex = 22;
            // 
            // Manufaturer
            // 
            Manufaturer.AutoSize = true;
            Manufaturer.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            Manufaturer.ForeColor = Color.White;
            Manufaturer.Location = new Point(4, 16);
            Manufaturer.Name = "Manufaturer";
            Manufaturer.Size = new Size(125, 20);
            Manufaturer.TabIndex = 21;
            Manufaturer.Text = "Manufacturer:";
            // 
            // dateTime
            // 
            dateTime.CalendarMonthBackground = Color.FromArgb(30, 168, 150);
            dateTime.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTime.Location = new Point(146, 92);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(250, 26);
            dateTime.TabIndex = 33;
            dateTime.Value = new DateTime(2024, 3, 28, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 95);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 32;
            label7.Text = "Release date:";
            // 
            // cmbPlatform
            // 
            cmbPlatform.BackColor = Color.FromArgb(30, 168, 150);
            cmbPlatform.FlatStyle = FlatStyle.Flat;
            cmbPlatform.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            cmbPlatform.ForeColor = Color.White;
            cmbPlatform.FormattingEnabled = true;
            cmbPlatform.Location = new Point(110, 48);
            cmbPlatform.Name = "cmbPlatform";
            cmbPlatform.Size = new Size(158, 27);
            cmbPlatform.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 52);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 30;
            label6.Text = "Platform:";
            // 
            // cmbGenre
            // 
            cmbGenre.BackColor = Color.FromArgb(30, 168, 150);
            cmbGenre.FlatStyle = FlatStyle.Flat;
            cmbGenre.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            cmbGenre.ForeColor = Color.White;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(91, 5);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(144, 27);
            cmbGenre.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 7);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 28;
            label5.Text = "Genre:";
            // 
            // nudPrice
            // 
            nudPrice.BackColor = Color.FromArgb(30, 168, 150);
            nudPrice.BorderStyle = BorderStyle.None;
            nudPrice.DecimalPlaces = 2;
            nudPrice.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            nudPrice.ForeColor = Color.White;
            nudPrice.Location = new Point(103, 104);
            nudPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(123, 22);
            nudPrice.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 105);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 23;
            label3.Text = "Price:";
            // 
            // tbName
            // 
            tbName.BackColor = Color.FromArgb(30, 168, 150);
            tbName.BorderStyle = BorderStyle.None;
            tbName.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            tbName.ForeColor = Color.White;
            tbName.Location = new Point(103, 67);
            tbName.Name = "tbName";
            tbName.Size = new Size(216, 19);
            tbName.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 67);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 21;
            label1.Text = "Name:";
            // 
            // panelGame
            // 
            panelGame.Controls.Add(cmbGenre);
            panelGame.Controls.Add(dateTime);
            panelGame.Controls.Add(label5);
            panelGame.Controls.Add(label7);
            panelGame.Controls.Add(label6);
            panelGame.Controls.Add(cmbPlatform);
            panelGame.Location = new Point(12, 132);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(412, 148);
            panelGame.TabIndex = 35;
            panelGame.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(30, 168, 150);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(147, 357);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(197, 55);
            btnEdit.TabIndex = 36;
            btnEdit.Text = "Edit Product";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(169, 12);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 37;
            label2.Text = "Edit product";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(54, 57, 74);
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(275, 435);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(162, 40);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(15, 445);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(254, 24);
            checkBox1.TabIndex = 40;
            checkBox1.Text = "I want to delete the product";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // EditDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 47);
            ClientSize = new Size(508, 494);
            Controls.Add(checkBox1);
            Controls.Add(btnDelete);
            Controls.Add(panelHardware);
            Controls.Add(label2);
            Controls.Add(btnEdit);
            Controls.Add(nudPrice);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(panelGame);
            Name = "EditDetailsForm";
            Text = "EditDetailsForm";
            Load += EditDetailsForm_Load;
            panelHardware.ResumeLayout(false);
            panelHardware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            panelGame.ResumeLayout(false);
            panelGame.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHardware;
        private Label label10;
        private TextBox tbModel;
        private Label label9;
        private TextBox tbManufacturer;
        private Label Manufaturer;
        private DateTimePicker dateTime;
        private Label label7;
        private ComboBox cmbPlatform;
        private Label label6;
        private ComboBox cmbGenre;
        private Label label5;
        private NumericUpDown nudPrice;
        private Label label3;
        private TextBox tbName;
        private Label label1;
        private Panel panelGame;
        private Button btnEdit;
        private Label label2;
        private RichTextBox rtbSpecs;
        private Button btnDelete;
        private CheckBox checkBox1;
    }
}