namespace BookSalesApp.Views.AdminViews
{
    partial class AddCategory
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
            this.txtCategoryname = new System.Windows.Forms.TextBox();
            this.txtCategorydesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCategoryname
            // 
            this.txtCategoryname.Location = new System.Drawing.Point(93, 47);
            this.txtCategoryname.Name = "txtCategoryname";
            this.txtCategoryname.Size = new System.Drawing.Size(150, 20);
            this.txtCategoryname.TabIndex = 0;
            // 
            // txtCategorydesc
            // 
            this.txtCategorydesc.Location = new System.Drawing.Point(93, 84);
            this.txtCategorydesc.Name = "txtCategorydesc";
            this.txtCategorydesc.Size = new System.Drawing.Size(150, 20);
            this.txtCategorydesc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama:";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(155, 119);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(88, 23);
            this.btnCategoryAdd.TabIndex = 4;
            this.btnCategoryAdd.Text = "Kategori Ekle";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.btnCategoryAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategorydesc);
            this.Controls.Add(this.txtCategoryname);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCategory_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryname;
        private System.Windows.Forms.TextBox txtCategorydesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCategoryAdd;
    }
}