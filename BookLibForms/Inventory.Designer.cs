namespace BookLibForms
{
    partial class Inventory
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
            this.lblInvTitle = new System.Windows.Forms.Label();
            this.lblInv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInvTitle
            // 
            this.lblInvTitle.AutoSize = true;
            this.lblInvTitle.Location = new System.Drawing.Point(55, 15);
            this.lblInvTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvTitle.Name = "lblInvTitle";
            this.lblInvTitle.Size = new System.Drawing.Size(66, 17);
            this.lblInvTitle.TabIndex = 0;
            this.lblInvTitle.Text = "Inventory";
            // 
            // lblInv
            // 
            this.lblInv.AutoSize = true;
            this.lblInv.Location = new System.Drawing.Point(65, 76);
            this.lblInv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInv.Name = "lblInv";
            this.lblInv.Size = new System.Drawing.Size(102, 17);
            this.lblInv.TabIndex = 1;
            this.lblInv.Text = "show inventory";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 577);
            this.Controls.Add(this.lblInv);
            this.Controls.Add(this.lblInvTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvTitle;
        private System.Windows.Forms.Label lblInv;
    }
}