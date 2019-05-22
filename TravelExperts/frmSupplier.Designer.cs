namespace TravelExperts
{
    partial class frmSupplier
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
            this.pnlSuppliers = new System.Windows.Forms.Panel();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.Label();
            this.btnAcceptEdit = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnSupplierEdit = new System.Windows.Forms.Button();
            this.btnSupplierClose = new System.Windows.Forms.Button();
            this.lblSupplierProducts = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.lblSupName = new System.Windows.Forms.Label();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblSupplierView = new System.Windows.Forms.Label();
            this.pnlSuppliers.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuppliers
            // 
            this.pnlSuppliers.Controls.Add(this.pnlUpdate);
            this.pnlSuppliers.Controls.Add(this.btnAcceptEdit);
            this.pnlSuppliers.Controls.Add(this.btnAddSupplier);
            this.pnlSuppliers.Controls.Add(this.btnSupplierEdit);
            this.pnlSuppliers.Controls.Add(this.btnSupplierClose);
            this.pnlSuppliers.Controls.Add(this.lblSupplierProducts);
            this.pnlSuppliers.Controls.Add(this.lstProducts);
            this.pnlSuppliers.Controls.Add(this.txtSupplierID);
            this.pnlSuppliers.Controls.Add(this.lblSupName);
            this.pnlSuppliers.Controls.Add(this.txtSupName);
            this.pnlSuppliers.Controls.Add(this.lblSupplierID);
            this.pnlSuppliers.Controls.Add(this.lblSupplierView);
            this.pnlSuppliers.Location = new System.Drawing.Point(12, 12);
            this.pnlSuppliers.Name = "pnlSuppliers";
            this.pnlSuppliers.Size = new System.Drawing.Size(315, 495);
            this.pnlSuppliers.TabIndex = 20;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.btnAdd);
            this.pnlUpdate.Controls.Add(this.cboProducts);
            this.pnlUpdate.Controls.Add(this.btnRemove);
            this.pnlUpdate.Controls.Add(this.lbProducts);
            this.pnlUpdate.Location = new System.Drawing.Point(3, 297);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(307, 122);
            this.pnlUpdate.TabIndex = 27;
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
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(3, 60);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(301, 21);
            this.cboProducts.TabIndex = 23;
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
            // lbProducts
            // 
            this.lbProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbProducts.Location = new System.Drawing.Point(3, 36);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(302, 20);
            this.lbProducts.TabIndex = 21;
            this.lbProducts.Text = "Products";
            this.lbProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAcceptEdit
            // 
            this.btnAcceptEdit.Location = new System.Drawing.Point(56, 453);
            this.btnAcceptEdit.Name = "btnAcceptEdit";
            this.btnAcceptEdit.Size = new System.Drawing.Size(80, 23);
            this.btnAcceptEdit.TabIndex = 26;
            this.btnAcceptEdit.Text = "&Accept";
            this.btnAcceptEdit.UseVisualStyleBackColor = true;
            this.btnAcceptEdit.Click += new System.EventHandler(this.btnAcceptEdit_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(142, 453);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(80, 23);
            this.btnAddSupplier.TabIndex = 25;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnSupplierEdit
            // 
            this.btnSupplierEdit.Location = new System.Drawing.Point(228, 424);
            this.btnSupplierEdit.Name = "btnSupplierEdit";
            this.btnSupplierEdit.Size = new System.Drawing.Size(80, 23);
            this.btnSupplierEdit.TabIndex = 24;
            this.btnSupplierEdit.Text = "Update";
            this.btnSupplierEdit.UseVisualStyleBackColor = true;
            this.btnSupplierEdit.Click += new System.EventHandler(this.btnSupplierEdit_Click);
            // 
            // btnSupplierClose
            // 
            this.btnSupplierClose.Location = new System.Drawing.Point(228, 453);
            this.btnSupplierClose.Name = "btnSupplierClose";
            this.btnSupplierClose.Size = new System.Drawing.Size(80, 23);
            this.btnSupplierClose.TabIndex = 23;
            this.btnSupplierClose.Text = "Close";
            this.btnSupplierClose.UseVisualStyleBackColor = true;
            this.btnSupplierClose.Click += new System.EventHandler(this.btnSupplierClose_Click_1);
            // 
            // lblSupplierProducts
            // 
            this.lblSupplierProducts.AutoSize = true;
            this.lblSupplierProducts.Location = new System.Drawing.Point(3, 75);
            this.lblSupplierProducts.Name = "lblSupplierProducts";
            this.lblSupplierProducts.Size = new System.Drawing.Size(99, 13);
            this.lblSupplierProducts.TabIndex = 20;
            this.lblSupplierProducts.Text = "Products Supplied: ";
            // 
            // lstProducts
            // 
            this.lstProducts.Enabled = false;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(6, 91);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(303, 199);
            this.lstProducts.TabIndex = 19;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Enabled = false;
            this.txtSupplierID.Location = new System.Drawing.Point(209, 25);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierID.TabIndex = 2;
            this.txtSupplierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(3, 55);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(82, 13);
            this.lblSupName.TabIndex = 2;
            this.lblSupName.Text = "Supplier Name: ";
            // 
            // txtSupName
            // 
            this.txtSupName.Enabled = false;
            this.txtSupName.Location = new System.Drawing.Point(109, 52);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(200, 20);
            this.txtSupName.TabIndex = 3;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(138, 28);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(65, 13);
            this.lblSupplierID.TabIndex = 1;
            this.lblSupplierID.Text = "Supplier ID: ";
            this.lblSupplierID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupplierView
            // 
            this.lblSupplierView.AutoSize = true;
            this.lblSupplierView.Location = new System.Drawing.Point(3, 0);
            this.lblSupplierView.Name = "lblSupplierView";
            this.lblSupplierView.Size = new System.Drawing.Size(71, 13);
            this.lblSupplierView.TabIndex = 0;
            this.lblSupplierView.Text = "Supplier View";
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 524);
            this.Controls.Add(this.pnlSuppliers);
            this.Name = "frmSupplier";
            this.Text = "frmViewSupplier";
            this.Load += new System.EventHandler(this.frmViewSupplier_Load);
            this.pnlSuppliers.ResumeLayout(false);
            this.pnlSuppliers.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuppliers;
        private System.Windows.Forms.Label lblSupplierProducts;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblSupplierView;
        private System.Windows.Forms.Button btnAcceptEdit;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnSupplierEdit;
        private System.Windows.Forms.Button btnSupplierClose;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lbProducts;
    }
}