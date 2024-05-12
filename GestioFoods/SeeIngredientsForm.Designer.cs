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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(54, 57, 74);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(2, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(510, 334);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += this.listBox1_SelectedIndexChanged;
            // 
            // SeeIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 47);
            ClientSize = new Size(700, 338);
            Controls.Add(listBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SeeIngredientsForm";
            Text = "SeeRatingsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}