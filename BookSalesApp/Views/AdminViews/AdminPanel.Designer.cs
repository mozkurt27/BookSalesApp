namespace BookSalesApp.Views.AdminViews
{
    partial class AdminPanel
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
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.btnPublisherAdd = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.btnAllOrders = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(23, 38);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(95, 23);
            this.btnCategoryAdd.TabIndex = 0;
            this.btnCategoryAdd.Text = "Kategori Ekle";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // btnPublisherAdd
            // 
            this.btnPublisherAdd.Location = new System.Drawing.Point(23, 86);
            this.btnPublisherAdd.Name = "btnPublisherAdd";
            this.btnPublisherAdd.Size = new System.Drawing.Size(95, 23);
            this.btnPublisherAdd.TabIndex = 1;
            this.btnPublisherAdd.Text = "Yayıncı Ekle";
            this.btnPublisherAdd.UseVisualStyleBackColor = true;
            this.btnPublisherAdd.Click += new System.EventHandler(this.btnPublisherAdd_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(23, 135);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(95, 23);
            this.btnBookAdd.TabIndex = 2;
            this.btnBookAdd.Text = "Kitap Ekle";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.Location = new System.Drawing.Point(23, 187);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(95, 23);
            this.btnAllOrders.TabIndex = 3;
            this.btnAllOrders.Text = "Tüm Siparişler";
            this.btnAllOrders.UseVisualStyleBackColor = true;
            this.btnAllOrders.Click += new System.EventHandler(this.btnAllOrders_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPublisherAdd);
            this.groupBox1.Controls.Add(this.btnAllOrders);
            this.groupBox1.Controls.Add(this.btnCategoryAdd);
            this.groupBox1.Controls.Add(this.btnBookAdd);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 259);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbBooks);
            this.groupBox2.Controls.Add(this.lbCategories);
            this.groupBox2.Location = new System.Drawing.Point(139, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 259);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitaplar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategoriler";
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(160, 38);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(204, 199);
            this.lbBooks.TabIndex = 1;
            // 
            // lbCategories
            // 
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.Location = new System.Drawing.Point(36, 38);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(118, 199);
            this.lbCategories.TabIndex = 0;
            this.lbCategories.SelectedIndexChanged += new System.EventHandler(this.lbCategories_SelectedIndexChanged);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.VisibleChanged += new System.EventHandler(this.AdminPanel_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Button btnPublisherAdd;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Button btnAllOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.ListBox lbCategories;
    }
}