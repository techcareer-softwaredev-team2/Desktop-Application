namespace TravelExperts
{
    partial class frmPackage
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
            this.pnlPackages = new System.Windows.Forms.Panel();
            this.pnlUpdate2 = new System.Windows.Forms.Panel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentProducts = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstPackProdSupp = new System.Windows.Forms.ListBox();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstProdSup = new System.Windows.Forms.ListBox();
            this.btnAcceptEdit = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnPackageEdit = new System.Windows.Forms.Button();
            this.btnPackageClose = new System.Windows.Forms.Button();
            this.lblAgencyCommission = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.lblPackageID = new System.Windows.Forms.Label();
            this.pnlPackages.SuspendLayout();
            this.pnlUpdate2.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPackages
            // 
            this.pnlPackages.Controls.Add(this.pnlUpdate2);
            this.pnlPackages.Controls.Add(this.pnlUpdate);
            this.pnlPackages.Controls.Add(this.btnAcceptEdit);
            this.pnlPackages.Controls.Add(this.btnAddPackage);
            this.pnlPackages.Controls.Add(this.btnPackageEdit);
            this.pnlPackages.Controls.Add(this.btnPackageClose);
            this.pnlPackages.Controls.Add(this.lblAgencyCommission);
            this.pnlPackages.Controls.Add(this.lblBasePrice);
            this.pnlPackages.Controls.Add(this.txtBasePrice);
            this.pnlPackages.Controls.Add(this.txtCommission);
            this.pnlPackages.Controls.Add(this.lblDescription);
            this.pnlPackages.Controls.Add(this.txtPkgDesc);
            this.pnlPackages.Controls.Add(this.lblEndDate);
            this.pnlPackages.Controls.Add(this.dtpEndDate);
            this.pnlPackages.Controls.Add(this.lblPkgStartDate);
            this.pnlPackages.Controls.Add(this.lblPkgName);
            this.pnlPackages.Controls.Add(this.dtpStartDate);
            this.pnlPackages.Controls.Add(this.txtPkgName);
            this.pnlPackages.Controls.Add(this.txtPackageId);
            this.pnlPackages.Controls.Add(this.lblPackageID);
            this.pnlPackages.Location = new System.Drawing.Point(12, 12);
            this.pnlPackages.Name = "pnlPackages";
            this.pnlPackages.Size = new System.Drawing.Size(314, 495);
            this.pnlPackages.TabIndex = 2;
            // 
            // pnlUpdate2
            // 
            this.pnlUpdate2.Controls.Add(this.pnlAdd);
            this.pnlUpdate2.Controls.Add(this.lblCurrentProducts);
            this.pnlUpdate2.Controls.Add(this.btnDelete);
            this.pnlUpdate2.Controls.Add(this.lstPackProdSupp);
            this.pnlUpdate2.Location = new System.Drawing.Point(3, 284);
            this.pnlUpdate2.Name = "pnlUpdate2";
            this.pnlUpdate2.Size = new System.Drawing.Size(307, 86);
            this.pnlUpdate2.TabIndex = 22;
            this.pnlUpdate2.Visible = false;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(308, 168);
            this.pnlAdd.TabIndex = 21;
            this.pnlAdd.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Create a package then update to add products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentProducts
            // 
            this.lblCurrentProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentProducts.Location = new System.Drawing.Point(3, 4);
            this.lblCurrentProducts.Name = "lblCurrentProducts";
            this.lblCurrentProducts.Size = new System.Drawing.Size(302, 20);
            this.lblCurrentProducts.TabIndex = 21;
            this.lblCurrentProducts.Text = "Added products";
            this.lblCurrentProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(224, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstPackProdSupp
            // 
            this.lstPackProdSupp.Enabled = false;
            this.lstPackProdSupp.FormattingEnabled = true;
            this.lstPackProdSupp.Location = new System.Drawing.Point(3, 27);
            this.lstPackProdSupp.Name = "lstPackProdSupp";
            this.lstPackProdSupp.Size = new System.Drawing.Size(215, 56);
            this.lstPackProdSupp.TabIndex = 17;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.label8);
            this.pnlUpdate.Controls.Add(this.btnAdd);
            this.pnlUpdate.Controls.Add(this.lstProdSup);
            this.pnlUpdate.Location = new System.Drawing.Point(3, 366);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(308, 86);
            this.pnlUpdate.TabIndex = 3;
            this.pnlUpdate.Visible = false;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Add a product to your vacation package";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstProdSup
            // 
            this.lstProdSup.FormattingEnabled = true;
            this.lstProdSup.Location = new System.Drawing.Point(3, 27);
            this.lstProdSup.Name = "lstProdSup";
            this.lstProdSup.Size = new System.Drawing.Size(214, 56);
            this.lstProdSup.TabIndex = 16;
            // 
            // btnAcceptEdit
            // 
            this.btnAcceptEdit.Location = new System.Drawing.Point(140, 453);
            this.btnAcceptEdit.Name = "btnAcceptEdit";
            this.btnAcceptEdit.Size = new System.Drawing.Size(80, 23);
            this.btnAcceptEdit.TabIndex = 18;
            this.btnAcceptEdit.Text = "&Accept";
            this.btnAcceptEdit.UseVisualStyleBackColor = true;
            this.btnAcceptEdit.Click += new System.EventHandler(this.btnAcceptEdit_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(141, 453);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(80, 23);
            this.btnAddPackage.TabIndex = 15;
            this.btnAddPackage.Text = "Add";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnPackageEdit
            // 
            this.btnPackageEdit.Location = new System.Drawing.Point(227, 424);
            this.btnPackageEdit.Name = "btnPackageEdit";
            this.btnPackageEdit.Size = new System.Drawing.Size(80, 23);
            this.btnPackageEdit.TabIndex = 14;
            this.btnPackageEdit.Text = "Update";
            this.btnPackageEdit.UseVisualStyleBackColor = true;
            this.btnPackageEdit.Click += new System.EventHandler(this.btnPackageEdit_Click);
            // 
            // btnPackageClose
            // 
            this.btnPackageClose.Location = new System.Drawing.Point(227, 453);
            this.btnPackageClose.Name = "btnPackageClose";
            this.btnPackageClose.Size = new System.Drawing.Size(80, 23);
            this.btnPackageClose.TabIndex = 13;
            this.btnPackageClose.Text = "Close";
            this.btnPackageClose.UseVisualStyleBackColor = true;
            this.btnPackageClose.Click += new System.EventHandler(this.btnPackageClose_Click);
            // 
            // lblAgencyCommission
            // 
            this.lblAgencyCommission.AutoSize = true;
            this.lblAgencyCommission.Location = new System.Drawing.Point(95, 266);
            this.lblAgencyCommission.Name = "lblAgencyCommission";
            this.lblAgencyCommission.Size = new System.Drawing.Size(107, 13);
            this.lblAgencyCommission.TabIndex = 12;
            this.lblAgencyCommission.Text = "Agency Commission: ";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(138, 240);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(64, 13);
            this.lblBasePrice.TabIndex = 11;
            this.lblBasePrice.Text = "Base Price: ";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Enabled = false;
            this.txtBasePrice.Location = new System.Drawing.Point(208, 237);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtBasePrice.TabIndex = 10;
            this.txtBasePrice.Tag = "Package Base Price";
            this.txtBasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCommission
            // 
            this.txtCommission.Enabled = false;
            this.txtCommission.Location = new System.Drawing.Point(208, 263);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(100, 20);
            this.txtCommission.TabIndex = 9;
            this.txtCommission.Tag = "Package Agency Commision";
            this.txtCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 134);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description: ";
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Enabled = false;
            this.txtPkgDesc.Location = new System.Drawing.Point(109, 131);
            this.txtPkgDesc.Multiline = true;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(200, 100);
            this.txtPkgDesc.TabIndex = 7;
            this.txtPkgDesc.Tag = "Package Description";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(3, 108);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 13);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End Date: ";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(109, 105);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 6;
            this.dtpEndDate.Tag = "Package End Date";
            // 
            // lblPkgStartDate
            // 
            this.lblPkgStartDate.AutoSize = true;
            this.lblPkgStartDate.Location = new System.Drawing.Point(3, 81);
            this.lblPkgStartDate.Name = "lblPkgStartDate";
            this.lblPkgStartDate.Size = new System.Drawing.Size(61, 13);
            this.lblPkgStartDate.TabIndex = 3;
            this.lblPkgStartDate.Text = "Start Date: ";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(3, 55);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(87, 13);
            this.lblPkgName.TabIndex = 2;
            this.lblPkgName.Text = "Package Name: ";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Location = new System.Drawing.Point(109, 78);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 5;
            this.dtpStartDate.Tag = "Package Start Date";
            // 
            // txtPkgName
            // 
            this.txtPkgName.Enabled = false;
            this.txtPkgName.Location = new System.Drawing.Point(109, 52);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(200, 20);
            this.txtPkgName.TabIndex = 3;
            this.txtPkgName.Tag = "Package Name";
            // 
            // txtPackageId
            // 
            this.txtPackageId.Enabled = false;
            this.txtPackageId.Location = new System.Drawing.Point(208, 25);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.ReadOnly = true;
            this.txtPackageId.Size = new System.Drawing.Size(101, 20);
            this.txtPackageId.TabIndex = 2;
            this.txtPackageId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPackageID
            // 
            this.lblPackageID.AutoSize = true;
            this.lblPackageID.Location = new System.Drawing.Point(132, 28);
            this.lblPackageID.Name = "lblPackageID";
            this.lblPackageID.Size = new System.Drawing.Size(70, 13);
            this.lblPackageID.TabIndex = 1;
            this.lblPackageID.Text = "Package ID: ";
            this.lblPackageID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 524);
            this.Controls.Add(this.pnlPackages);
            this.Name = "frmPackage";
            this.Text = "Packages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPackage_FormClosing);
            this.Load += new System.EventHandler(this.frmViewPackage_Load);
            this.pnlPackages.ResumeLayout(false);
            this.pnlPackages.PerformLayout();
            this.pnlUpdate2.ResumeLayout(false);
            this.pnlAdd.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPackages;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnPackageEdit;
        private System.Windows.Forms.Button btnPackageClose;
        private System.Windows.Forms.Label lblAgencyCommission;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.Label lblPackageID;
        private System.Windows.Forms.Button btnAcceptEdit;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurrentProducts;
        private System.Windows.Forms.ListBox lstProdSup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstPackProdSupp;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Panel pnlUpdate2;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label label1;
    }
}