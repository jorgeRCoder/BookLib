namespace BookLibForms
{
    partial class SearchJournals
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
            this.lblTitleJournals = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtYearPrinted = new System.Windows.Forms.TextBox();
            this.btnSearchJournals = new System.Windows.Forms.Button();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblYearPrinted = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleJournals
            // 
            this.lblTitleJournals.AutoSize = true;
            this.lblTitleJournals.Location = new System.Drawing.Point(36, 11);
            this.lblTitleJournals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleJournals.Name = "lblTitleJournals";
            this.lblTitleJournals.Size = new System.Drawing.Size(62, 17);
            this.lblTitleJournals.TabIndex = 1;
            this.lblTitleJournals.Text = "Journals";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(265, 194);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(173, 22);
            this.txtPrice.TabIndex = 68;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(519, 194);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 22);
            this.txtID.TabIndex = 66;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearPrinted_KeyPress);
            // 
            // txtYearPrinted
            // 
            this.txtYearPrinted.Location = new System.Drawing.Point(271, 48);
            this.txtYearPrinted.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearPrinted.Name = "txtYearPrinted";
            this.txtYearPrinted.Size = new System.Drawing.Size(173, 22);
            this.txtYearPrinted.TabIndex = 65;
            this.txtYearPrinted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearPrinted_KeyPress);
            // 
            // btnSearchJournals
            // 
            this.btnSearchJournals.Location = new System.Drawing.Point(39, 460);
            this.btnSearchJournals.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchJournals.Name = "btnSearchJournals";
            this.btnSearchJournals.Size = new System.Drawing.Size(167, 69);
            this.btnSearchJournals.TabIndex = 62;
            this.btnSearchJournals.Text = "Search Journals";
            this.btnSearchJournals.UseVisualStyleBackColor = true;
            this.btnSearchJournals.Click += new System.EventHandler(this.btnSearchJournals_Click);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(39, 194);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(161, 22);
            this.txtPublisher.TabIndex = 61;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(519, 49);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(161, 22);
            this.txtAuthor.TabIndex = 60;
            // 
            // lblYearPrinted
            // 
            this.lblYearPrinted.AutoSize = true;
            this.lblYearPrinted.Location = new System.Drawing.Point(261, 98);
            this.lblYearPrinted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearPrinted.Name = "lblYearPrinted";
            this.lblYearPrinted.Size = new System.Drawing.Size(157, 17);
            this.lblYearPrinted.TabIndex = 59;
            this.lblYearPrinted.Text = "Year Printed (start 500)";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(35, 242);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(67, 17);
            this.lblPublisher.TabIndex = 57;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(261, 242);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 56;
            this.lblPrice.Text = "Price";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(519, 98);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(50, 17);
            this.lblAuthor.TabIndex = 55;
            this.lblAuthor.Text = "Author";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(515, 242);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 17);
            this.lblId.TabIndex = 54;
            this.lblId.Text = "ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(35, 98);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(39, 49);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(161, 22);
            this.txtTitle.TabIndex = 51;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(760, 79);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 17);
            this.lblResult.TabIndex = 69;
            this.lblResult.Text = "Results";
            // 
            // SearchJournals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtYearPrinted);
            this.Controls.Add(this.btnSearchJournals);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblYearPrinted);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitleJournals);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchJournals";
            this.Text = "SearchJournals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleJournals;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtYearPrinted;
        private System.Windows.Forms.Button btnSearchJournals;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblYearPrinted;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblResult;
    }
}