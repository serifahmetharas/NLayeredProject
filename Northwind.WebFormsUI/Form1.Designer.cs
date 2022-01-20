
namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblProductName2 = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.tbxProductName2 = new System.Windows.Forms.TextBox();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitInStock = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(33, 185);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(886, 145);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            this.dgwProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellContentClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(33, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(886, 67);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            this.gbxCategory.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(87, 28);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(119, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 28);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(61, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.tbxProductName);
            this.gbxProduct.Controls.Add(this.lblProduct);
            this.gbxProduct.Location = new System.Drawing.Point(33, 85);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(886, 94);
            this.gbxProduct.TabIndex = 2;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Ürün Adına Göre Ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(89, 31);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(100, 22);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(20, 36);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(63, 17);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Ürün Adı";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxStock);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryId);
            this.gbxProductAdd.Controls.Add(this.tbxProductName2);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblStock);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblProductName2);
            this.gbxProductAdd.Location = new System.Drawing.Point(33, 350);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(577, 160);
            this.gbxProductAdd.TabIndex = 2;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // lblProductName2
            // 
            this.lblProductName2.AutoSize = true;
            this.lblProductName2.Location = new System.Drawing.Point(20, 27);
            this.lblProductName2.Name = "lblProductName2";
            this.lblProductName2.Size = new System.Drawing.Size(63, 17);
            this.lblProductName2.TabIndex = 3;
            this.lblProductName2.Text = "Ürün Adı";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(20, 62);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(61, 17);
            this.lblCategoryId.TabIndex = 3;
            this.lblCategoryId.Text = "Kategori";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(20, 90);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(76, 17);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Birim Fiyatı";
            this.lblUnitPrice.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(296, 27);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(76, 17);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stok Adedi";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(293, 62);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(79, 17);
            this.lblQuantityPerUnit.TabIndex = 3;
            this.lblQuantityPerUnit.Text = "Birim Adedi";
            // 
            // tbxProductName2
            // 
            this.tbxProductName2.Location = new System.Drawing.Point(106, 24);
            this.tbxProductName2.Name = "tbxProductName2";
            this.tbxProductName2.Size = new System.Drawing.Size(121, 22);
            this.tbxProductName2.TabIndex = 4;
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(106, 55);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(121, 24);
            this.cbxCategoryId.TabIndex = 3;
            this.cbxCategoryId.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryId_SelectedIndexChanged);
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(106, 85);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(121, 22);
            this.tbxUnitPrice.TabIndex = 5;
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(378, 24);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(116, 22);
            this.tbxStock.TabIndex = 6;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(378, 62);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(116, 22);
            this.tbxQuantityPerUnit.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(378, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.gbxUpdate.Controls.Add(this.tbxUpdateUnitInStock);
            this.gbxUpdate.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.cbxUpdateCategory);
            this.gbxUpdate.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdate.Controls.Add(this.label1);
            this.gbxUpdate.Controls.Add(this.label2);
            this.gbxUpdate.Controls.Add(this.label3);
            this.gbxUpdate.Controls.Add(this.label4);
            this.gbxUpdate.Controls.Add(this.label5);
            this.gbxUpdate.Location = new System.Drawing.Point(33, 516);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(577, 160);
            this.gbxUpdate.TabIndex = 3;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Ürün Güncelle";
            this.gbxUpdate.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(378, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(378, 62);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(116, 22);
            this.tbxUpdateQuantityPerUnit.TabIndex = 7;
            // 
            // tbxUpdateUnitInStock
            // 
            this.tbxUpdateUnitInStock.Location = new System.Drawing.Point(378, 24);
            this.tbxUpdateUnitInStock.Name = "tbxUpdateUnitInStock";
            this.tbxUpdateUnitInStock.Size = new System.Drawing.Size(116, 22);
            this.tbxUpdateUnitInStock.TabIndex = 6;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(106, 85);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(121, 22);
            this.tbxUpdateUnitPrice.TabIndex = 5;
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(106, 55);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(121, 24);
            this.cbxUpdateCategory.TabIndex = 3;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(106, 24);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(121, 22);
            this.tbxUpdateProductName.TabIndex = 4;
            this.tbxUpdateProductName.TextChanged += new System.EventHandler(this.tbxUpdateProductName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Birim Adedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Birim Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün Adı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(803, 336);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(116, 35);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 876);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürün Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblProductName2;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.TextBox tbxProductName2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateUnitInStock;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.ComboBox cbxUpdateCategory;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
    }
}

