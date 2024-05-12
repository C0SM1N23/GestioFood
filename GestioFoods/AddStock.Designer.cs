namespace Desktop_App_.NET_8._0
{
    partial class AddStock
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
            nudStock = new NumericUpDown();
            label3 = new Label();
            btnAddStock = new Button();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.FromArgb(30, 168, 150);
            nudStock.BorderStyle = BorderStyle.None;
            nudStock.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudStock.ForeColor = Color.White;
            nudStock.Location = new Point(168, 58);
            nudStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(91, 28);
            nudStock.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(89, 59);
            label3.Name = "label3";
            label3.Size = new Size(73, 24);
            label3.TabIndex = 25;
            label3.Text = "Stock:";
            label3.Click += label3_Click;
            // 
            // btnAddStock
            // 
            btnAddStock.BackColor = Color.FromArgb(30, 168, 150);
            btnAddStock.FlatAppearance.BorderSize = 0;
            btnAddStock.FlatStyle = FlatStyle.Flat;
            btnAddStock.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStock.ForeColor = Color.White;
            btnAddStock.Location = new Point(89, 123);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(170, 42);
            btnAddStock.TabIndex = 37;
            btnAddStock.Text = "Add Stock";
            btnAddStock.UseVisualStyleBackColor = false;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // AddStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 47);
            ClientSize = new Size(365, 199);
            Controls.Add(btnAddStock);
            Controls.Add(nudStock);
            Controls.Add(label3);
            Name = "AddStock";
            Text = "AddStock";
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudStock;
        private Label label3;
        private Button btnAddStock;
    }
}