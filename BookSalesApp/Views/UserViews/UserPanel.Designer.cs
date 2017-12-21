namespace BookSalesApp.Views.UserViews
{
    partial class UserPanel
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
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.lbBookBox = new System.Windows.Forms.ListBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(82, 90);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(281, 251);
            this.lbBooks.TabIndex = 0;
            // 
            // lbBookBox
            // 
            this.lbBookBox.FormattingEnabled = true;
            this.lbBookBox.Location = new System.Drawing.Point(456, 90);
            this.lbBookBox.Name = "lbBookBox";
            this.lbBookBox.Size = new System.Drawing.Size(340, 212);
            this.lbBookBox.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(799, 35);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "label1";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitaplar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategoriler :";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(82, 59);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(281, 21);
            this.cbCategories.TabIndex = 5;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "==>>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(369, 192);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 7;
            this.btnOut.Text = "<<==";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.Location = new System.Drawing.Point(453, 310);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(122, 23);
            this.lblSumPrice.TabIndex = 8;
            this.lblSumPrice.Text = "Toplam Fiyat : 0 TL";
            this.lblSumPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(702, 307);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(94, 23);
            this.btnFinish.TabIndex = 9;
            this.btnFinish.Text = "Tamamla";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(456, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sepet";
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblSumPrice);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lbBookBox);
            this.Controls.Add(this.lbBooks);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPanel_FormClosing);
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.ListBox lbBookBox;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lblSumPrice;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label3;
    }
}