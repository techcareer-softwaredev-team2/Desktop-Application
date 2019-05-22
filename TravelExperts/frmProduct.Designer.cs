namespace TravelExperts
{
    partial class frmProduct
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
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnAcceptEdit = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.btnProductClose = new System.Windows.Forms.Button();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.lblProductSuppliers = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductView = new System.Windows.Forms.Label();
            this.pnlProducts.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProducts
            // 
            this.pnlProducts.Controls.Add(this.pnlUpdate);
            this.pnlProducts.Controls.Add(this.btnAcceptEdit);
            this.pnlProducts.Controls.Add(this.btnAddProduct);
            this.pnlProducts.Controls.Add(this.btnProductEdit);
            this.pnlProducts.Controls.Add(this.btnProductClose);
            this.pnlProducts.Controls.Add(this.lstSuppliers);
            this.pnlProducts.Controls.Add(this.lblProductSuppliers);
            this.pnlProducts.Controls.Add(this.lblProdName);
            this.pnlProducts.Controls.Add(this.txtProdName);
            this.pnlProducts.Controls.Add(this.txtProductID);
            this.pnlProducts.Controls.Add(this.lblProductID);
            this.pnlProducts.Controls.Add(this.lblProductView);
            this.pnlProducts.Location = new System.Drawing.Point(12, 12);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(315, 495);
            this.pnlProducts.TabIndex = 19;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.btnAdd);
            this.pnlUpdate.Controls.Add(this.cboSupplier);
            this.pnlUpdate.Controls.Add(this.btnRemove);
            this.pnlUpdate.Controls.Add(this.lblSupplier);
            this.pnlUpdate.Location = new System.Drawing.Point(3, 297);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(307, 122);
            this.pnlUpdate.TabIndex = 23;
            this.pnlUpdate.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboSupplier
            // 
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(3, 60);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(301, 21);
            this.cboSupplier.TabIndex = 23;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(224, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 30);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSupplier
            // 
            this.lblSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSupplier.Location = new System.Drawing.Point(3, 36);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(302, 20);
            this.lblSupplier.TabIndex = 21;
            this.lblSupplier.Text = "Supplier";
            this.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAcceptEdit
            // 
            this.btnAcceptEdit.Location = new System.Drawing.Point(142, 453);
            this.btnAcceptEdit.Name = "btnAcceptEdit";
            this.btnAcceptEdit.Size = new System.Drawing.Size(80, 23);
            this.btnAcceptEdit.TabIndex = 22;
            this.btnAcceptEdit.Text = "&Accept";
            this.btnAcceptEdit.UseVisualStyleBackColor = true;
            this.btnAcceptEdit.Click += new System.EventHandler(this.btnAcceptEdit_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(142, 453);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(80, 23);
            this.btnAddProduct.TabIndex = 21;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.Location = new System.Drawing.Point(228, 424);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(80, 23);
            this.btnProductEdit.TabIndex = 20;
            this.btnProductEdit.Text = "Update";
            this.btnProductEdit.UseVisualStyleBackColor = true;
            this.btnProductEdit.Click += new System.EventHandler(this.btnProductEdit_Click);
            // 
            // btnProductClose
            // 
            this.btnProductClose.Location = new System.Drawing.Point(228, 453);
            this.btnProductClose.Name = "btnProductClose";
            this.btnProductClose.Size = new System.Drawing.Size(80, 23);
            this.btnProductClose.TabIndex = 19;
            this.btnProductClose.Text = "Close";
            this.btnProductClose.UseVisualStyleBackColor = true;
            this.btnProductClose.Click += new System.EventHandler(this.btnProductClose_Click);
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.Enabled = false;
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.Location = new System.Drawing.Point(6, 92);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(303, 199);
            this.lstSuppliers.TabIndex = 18;
            // 
            // lblProductSuppliers
            // 
            this.lblProductSuppliers.AutoSize = true;
            this.lblProductSuppliers.Location = new System.Drawing.Point(3, 75);
            this.lblProductSuppliers.Name = "lblProductSuppliers";
            this.lblProductSuppliers.Size = new System.Drawing.Size(96, 13);
            this.lblProductSuppliers.TabIndex = 17;
            this.lblProductSuppliers.Text = "Product Suppliers: ";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(3, 55);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(81, 13);
            this.lblProdName.TabIndex = 2;
            this.lblProdName.Text = "Product Name: ";
            // 
            // txtProdName
            // 
            this.txtProdName.Enabled = false;
            this.txtProdName.Location = new System.Drawing.Point(109, 52);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(200, 20);
            this.txtProdName.TabIndex = 3;
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(209, 25);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 2;
            this.txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(139, 28);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(64, 13);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID: ";
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductView
            // 
            this.lblProductView.AutoSize = true;
            this.lblProductView.Location = new System.Drawing.Point(3, 0);
            this.lblProductView.Name = "lblProductView";
            this.lblProductView.Size = new System.Drawing.Size(70, 13);
            this.lblProductView.TabIndex = 0;
            this.lblProductView.Text = "Product View";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 524);
            this.Controls.Add(this.pnlProducts);
            this.Name = "frmProduct";
            this.Text = "frmViewProduct";
            this.Load += new System.EventHandler(this.frmViewProduct_Load);
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.Label lblProductSuppliers;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductView;
        private System.Windows.Forms.Button btnAcceptEdit;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.Button btnProductClose;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.Button btnAdd;
    }
}