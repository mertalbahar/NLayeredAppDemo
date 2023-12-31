﻿namespace Nothwind.WebFormsUI
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
            this.btnClearCategoryFilter = new System.Windows.Forms.Button();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStockAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.cbxCategoryIdAdd = new System.Windows.Forms.ComboBox();
            this.lblUnitsInStockAdd = new System.Windows.Forms.Label();
            this.lblQuantityPerUnitAdd = new System.Windows.Forms.Label();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.lblCategoryIdAdd = new System.Windows.Forms.Label();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.gbxProductUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
            this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
            this.lblUnitsInStockUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblCategoryIdUpdate = new System.Windows.Forms.Label();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 86);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(760, 278);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.btnClearCategoryFilter);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(375, 68);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // btnClearCategoryFilter
            // 
            this.btnClearCategoryFilter.Location = new System.Drawing.Point(222, 28);
            this.btnClearCategoryFilter.Name = "btnClearCategoryFilter";
            this.btnClearCategoryFilter.Size = new System.Drawing.Size(23, 23);
            this.btnClearCategoryFilter.TabIndex = 2;
            this.btnClearCategoryFilter.Text = "X";
            this.btnClearCategoryFilter.UseVisualStyleBackColor = true;
            this.btnClearCategoryFilter.Click += new System.EventHandler(this.btnClearCategoryFilter_Click);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(60, 29);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(156, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 32);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(397, 12);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(375, 68);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adına Göre Ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(60, 27);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(156, 20);
            this.tbxProductName.TabIndex = 3;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 30);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitsInStockAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryIdAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitsInStockAdd);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.lblCategoryIdAdd);
            this.gbxProductAdd.Controls.Add(this.lblProductNameAdd);
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 399);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(375, 150);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(260, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxQuantityPerUnitAdd
            // 
            this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(249, 69);
            this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(120, 20);
            this.tbxQuantityPerUnitAdd.TabIndex = 9;
            // 
            // tbxUnitsInStockAdd
            // 
            this.tbxUnitsInStockAdd.Location = new System.Drawing.Point(249, 29);
            this.tbxUnitsInStockAdd.Name = "tbxUnitsInStockAdd";
            this.tbxUnitsInStockAdd.Size = new System.Drawing.Size(120, 20);
            this.tbxUnitsInStockAdd.TabIndex = 8;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(63, 114);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(120, 20);
            this.tbxUnitPriceAdd.TabIndex = 7;
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(63, 29);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(120, 20);
            this.tbxProductNameAdd.TabIndex = 6;
            // 
            // cbxCategoryIdAdd
            // 
            this.cbxCategoryIdAdd.FormattingEnabled = true;
            this.cbxCategoryIdAdd.Location = new System.Drawing.Point(63, 69);
            this.cbxCategoryIdAdd.Name = "cbxCategoryIdAdd";
            this.cbxCategoryIdAdd.Size = new System.Drawing.Size(120, 21);
            this.cbxCategoryIdAdd.TabIndex = 5;
            // 
            // lblUnitsInStockAdd
            // 
            this.lblUnitsInStockAdd.AutoSize = true;
            this.lblUnitsInStockAdd.Location = new System.Drawing.Point(186, 72);
            this.lblUnitsInStockAdd.Name = "lblUnitsInStockAdd";
            this.lblUnitsInStockAdd.Size = new System.Drawing.Size(59, 13);
            this.lblUnitsInStockAdd.TabIndex = 4;
            this.lblUnitsInStockAdd.Text = "Birim Adedi";
            // 
            // lblQuantityPerUnitAdd
            // 
            this.lblQuantityPerUnitAdd.AutoSize = true;
            this.lblQuantityPerUnitAdd.Location = new System.Drawing.Point(186, 32);
            this.lblQuantityPerUnitAdd.Name = "lblQuantityPerUnitAdd";
            this.lblQuantityPerUnitAdd.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnitAdd.TabIndex = 3;
            this.lblQuantityPerUnitAdd.Text = "Stok Adedi";
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(9, 117);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPriceAdd.TabIndex = 2;
            this.lblUnitPriceAdd.Text = "Fiyat";
            // 
            // lblCategoryIdAdd
            // 
            this.lblCategoryIdAdd.AutoSize = true;
            this.lblCategoryIdAdd.Location = new System.Drawing.Point(9, 72);
            this.lblCategoryIdAdd.Name = "lblCategoryIdAdd";
            this.lblCategoryIdAdd.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryIdAdd.TabIndex = 1;
            this.lblCategoryIdAdd.Text = "Kategori";
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(9, 32);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(48, 13);
            this.lblProductNameAdd.TabIndex = 0;
            this.lblProductNameAdd.Text = "Ürün Adı";
            // 
            // gbxProductUpdate
            // 
            this.gbxProductUpdate.Controls.Add(this.btnUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxUnitsInStockUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxProductNameUpdate);
            this.gbxProductUpdate.Controls.Add(this.cbxCategoryIdUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblQuantityPerUnitUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblUnitsInStockUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblCategoryIdUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblProductNameUpdate);
            this.gbxProductUpdate.Location = new System.Drawing.Point(397, 399);
            this.gbxProductUpdate.Name = "gbxProductUpdate";
            this.gbxProductUpdate.Size = new System.Drawing.Size(375, 150);
            this.gbxProductUpdate.TabIndex = 11;
            this.gbxProductUpdate.TabStop = false;
            this.gbxProductUpdate.Text = "Ürün Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(260, 114);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(249, 69);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(120, 20);
            this.tbxQuantityPerUnitUpdate.TabIndex = 9;
            // 
            // tbxUnitsInStockUpdate
            // 
            this.tbxUnitsInStockUpdate.Location = new System.Drawing.Point(249, 29);
            this.tbxUnitsInStockUpdate.Name = "tbxUnitsInStockUpdate";
            this.tbxUnitsInStockUpdate.Size = new System.Drawing.Size(120, 20);
            this.tbxUnitsInStockUpdate.TabIndex = 8;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(63, 114);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(120, 20);
            this.tbxUnitPriceUpdate.TabIndex = 7;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(63, 29);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(120, 20);
            this.tbxProductNameUpdate.TabIndex = 6;
            // 
            // cbxCategoryIdUpdate
            // 
            this.cbxCategoryIdUpdate.FormattingEnabled = true;
            this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(63, 69);
            this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(120, 21);
            this.cbxCategoryIdUpdate.TabIndex = 5;
            // 
            // lblQuantityPerUnitUpdate
            // 
            this.lblQuantityPerUnitUpdate.AutoSize = true;
            this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(186, 72);
            this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
            this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnitUpdate.TabIndex = 4;
            this.lblQuantityPerUnitUpdate.Text = "Birim Adedi";
            // 
            // lblUnitsInStockUpdate
            // 
            this.lblUnitsInStockUpdate.AutoSize = true;
            this.lblUnitsInStockUpdate.Location = new System.Drawing.Point(186, 32);
            this.lblUnitsInStockUpdate.Name = "lblUnitsInStockUpdate";
            this.lblUnitsInStockUpdate.Size = new System.Drawing.Size(59, 13);
            this.lblUnitsInStockUpdate.TabIndex = 3;
            this.lblUnitsInStockUpdate.Text = "Stok Adedi";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(9, 117);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPriceUpdate.TabIndex = 2;
            this.lblUnitPriceUpdate.Text = "Fiyat";
            // 
            // lblCategoryIdUpdate
            // 
            this.lblCategoryIdUpdate.AutoSize = true;
            this.lblCategoryIdUpdate.Location = new System.Drawing.Point(9, 72);
            this.lblCategoryIdUpdate.Name = "lblCategoryIdUpdate";
            this.lblCategoryIdUpdate.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryIdUpdate.TabIndex = 1;
            this.lblCategoryIdUpdate.Text = "Kategori";
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(9, 32);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(48, 13);
            this.lblProductNameUpdate.TabIndex = 0;
            this.lblProductNameUpdate.Text = "Ürün Adı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(657, 370);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Ürünü Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxProductUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductUpdate.ResumeLayout(false);
            this.gbxProductUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnClearCategoryFilter;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
        private System.Windows.Forms.TextBox tbxUnitsInStockAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.ComboBox cbxCategoryIdAdd;
        private System.Windows.Forms.Label lblUnitsInStockAdd;
        private System.Windows.Forms.Label lblQuantityPerUnitAdd;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.Label lblCategoryIdAdd;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxProductUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxUnitsInStockUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lblUnitsInStockUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblCategoryIdUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

