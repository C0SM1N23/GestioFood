namespace Desktop_App_.NET_8._0
{
	partial class SeeIngredientsForm
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
            listIngredients = new ListBox();
            Butonadd = new Button();
            SuspendLayout();
            // 
            // listIngredients
            // 
            listIngredients.BackColor = Color.FromArgb(54, 57, 74);
            listIngredients.FormattingEnabled = true;
            listIngredients.ItemHeight = 15;
            listIngredients.Location = new Point(2, 1);
            listIngredients.Name = "listIngredients";
            listIngredients.Size = new Size(510, 334);
            listIngredients.TabIndex = 0;
            listIngredients.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Butonadd
            // 
            Butonadd.BackColor = Color.FromArgb(30, 168, 150);
            Butonadd.Font = new Font("Segoe UI", 14F);
            Butonadd.ForeColor = Color.Black;
            Butonadd.Location = new Point(529, 133);
            Butonadd.Name = "Butonadd";
            Butonadd.Size = new Size(149, 56);
            Butonadd.TabIndex = 1;
            Butonadd.Text = "Order Stock";
            Butonadd.UseVisualStyleBackColor = false;
            // 
            // SeeIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 47);
            ClientSize = new Size(700, 338);
            Controls.Add(Butonadd);
            Controls.Add(listIngredients);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SeeIngredientsForm";
            Text = "SeeRatingsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listIngredients;
        private Button Butonadd;
    }
}