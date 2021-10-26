namespace BookLibForms
{
    partial class SearchBooks
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
            this.lblTitleBooks = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtYearPrinted = new System.Windows.Forms.TextBox();
            this.combxGenre = new System.Windows.Forms.ComboBox();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblYearPrinted = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleBooks
            // 
            this.lblTitleBooks.AutoSize = true;
            this.lblTitleBooks.Location = new System.Drawing.Point(61, 25);
            this.lblTitleBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleBooks.Name = "lblTitleBooks";
            this.lblTitleBooks.Size = new System.Drawing.Size(47, 17);
            this.lblTitleBooks.TabIndex = 0;
            this.lblTitleBooks.Text = "Books";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(277, 205);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(173, 22);
            this.txtPrice.TabIndex = 48;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(265, 360);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(173, 22);
            this.txtISBN.TabIndex = 47;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearPrinted_KeyPress);
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(531, 205);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(173, 22);
            this.txtEdition.TabIndex = 46;
            this.txtEdition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearPrinted_KeyPress);
            // 
            // txtYearPrinted
            // 
            this.txtYearPrinted.Location = new System.Drawing.Point(283, 59);
            this.txtYearPrinted.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearPrinted.Name = "txtYearPrinted";
            this.txtYearPrinted.Size = new System.Drawing.Size(173, 22);
            this.txtYearPrinted.TabIndex = 45;
            this.txtYearPrinted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearPrinted_KeyPress);
            // 
            // combxGenre
            // 
            this.combxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combxGenre.FormattingEnabled = true;
            this.combxGenre.Items.AddRange(new object[] {
            "None",
            "Arts",
            "Biography",
            "Money",
            "Children",
            "Computers",
            "Cookboks",
            "Health",
            "History",
            "Literature",
            "Science",
            "SelfHelp"});
            this.combxGenre.Location = new System.Drawing.Point(51, 360);
            this.combxGenre.Margin = new System.Windows.Forms.Padding(4);
            this.combxGenre.Name = "combxGenre";
            this.combxGenre.Size = new System.Drawing.Size(167, 24);
            this.combxGenre.TabIndex = 44;
            this.combxGenre.DataSourceChanged += new System.EventHandler(this.combxGenre_DataSourceChanged);
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Location = new System.Drawing.Point(51, 471);
            this.btnSearchBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(117, 69);
            this.btnSearchBooks.TabIndex = 42;
            this.btnSearchBooks.Text = "Search Book";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(51, 205);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(161, 22);
            this.txtPublisher.TabIndex = 41;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(531, 60);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(161, 22);
            this.txtAuthor.TabIndex = 40;
            // 
            // lblYearPrinted
            // 
            this.lblYearPrinted.AutoSize = true;
            this.lblYearPrinted.Location = new System.Drawing.Point(273, 109);
            this.lblYearPrinted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearPrinted.Name = "lblYearPrinted";
            this.lblYearPrinted.Size = new System.Drawing.Size(157, 17);
            this.lblYearPrinted.TabIndex = 39;
            this.lblYearPrinted.Text = "Year Printed (start 500)";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(47, 408);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 17);
            this.lblGenre.TabIndex = 38;
            this.lblGenre.Text = "Genre";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(47, 253);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(67, 17);
            this.lblPublisher.TabIndex = 37;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(273, 253);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 36;
            this.lblPrice.Text = "Price";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(531, 109);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(50, 17);
            this.lblAuthor.TabIndex = 35;
            this.lblAuthor.Text = "Author";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Location = new System.Drawing.Point(527, 253);
            this.lblEdition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(105, 17);
            this.lblEdition.TabIndex = 34;
            this.lblEdition.Text = "Edition Number";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(273, 408);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(93, 17);
            this.lblISBN.TabIndex = 33;
            this.lblISBN.Text = "ISBN Number";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(47, 109);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(51, 60);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(161, 22);
            this.txtTitle.TabIndex = 31;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(781, 125);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 17);
            this.lblResult.TabIndex = 51;
            this.lblResult.Text = "Results";
            // 
            // SearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 605);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.txtYearPrinted);
            this.Controls.Add(this.combxGenre);
            this.Controls.Add(this.btnSearchBooks);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblYearPrinted);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitleBooks);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchBooks";
            this.Text = "SearchBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleBooks;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.TextBox txtYearPrinted;
        private System.Windows.Forms.ComboBox combxGenre;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblYearPrinted;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblResult;
    }
}