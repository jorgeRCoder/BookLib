namespace BookLibForms
{
    partial class Login
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
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.btnAddJournals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.Location = new System.Drawing.Point(140, 126);
            this.btnAddBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(176, 102);
            this.btnAddBooks.TabIndex = 0;
            this.btnAddBooks.Text = "Add Books";
            this.btnAddBooks.UseVisualStyleBackColor = true;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // btnAddJournals
            // 
            this.btnAddJournals.Location = new System.Drawing.Point(140, 273);
            this.btnAddJournals.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddJournals.Name = "btnAddJournals";
            this.btnAddJournals.Size = new System.Drawing.Size(176, 102);
            this.btnAddJournals.TabIndex = 1;
            this.btnAddJournals.Text = "Add Journals";
            this.btnAddJournals.UseVisualStyleBackColor = true;
            this.btnAddJournals.Click += new System.EventHandler(this.btnAddJournals_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAddJournals);
            this.Controls.Add(this.btnAddBooks);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.Button btnAddJournals;
    }
}