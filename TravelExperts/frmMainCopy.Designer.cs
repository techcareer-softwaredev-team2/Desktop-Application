﻿namespace TravelExperts
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTableNames = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cboId = new System.Windows.Forms.ComboBox();
            this.lstProductSupplierId = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.pnlName2 = new System.Windows.Forms.Panel();
            this.lstView = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlName.SuspendLayout();
            this.pnlName2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a database";
            // 
            // cboTableNames
            // 
            this.cboTableNames.FormattingEnabled = true;
            this.cboTableNames.Location = new System.Drawing.Point(127, 18);
            this.cboTableNames.Name = "cboTableNames";
            this.cboTableNames.Size = new System.Drawing.Size(172, 21);
            this.cboTableNames.TabIndex = 1;
            this.cboTableNames.SelectedIndexChanged += new System.EventHandler(this.cboTableNames_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(27, 47);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID";
            // 
            // cboId
            // 
            this.cboId.FormattingEnabled = true;
            this.cboId.Location = new System.Drawing.Point(127, 47);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(172, 21);
            this.cboId.TabIndex = 3;
            this.cboId.SelectedIndexChanged += new System.EventHandler(this.cboId_SelectedIndexChanged);
            // 
            // lstProductSupplierId
            // 
            this.lstProductSupplierId.FormattingEnabled = true;
            this.lstProductSupplierId.Location = new System.Drawing.Point(345, 15);
            this.lstProductSupplierId.Name = "lstProductSupplierId";
            this.lstProductSupplierId.Size = new System.Drawing.Size(305, 134);
            this.lstProductSupplierId.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Product Name";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(106, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtName2
            // 
            this.txtName2.Enabled = false;
            this.txtName2.Location = new System.Drawing.Point(105, 1);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(172, 20);
            this.txtName2.TabIndex = 8;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(5, 8);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(76, 13);
            this.lblName2.TabIndex = 7;
            this.lblName2.Text = "Supplier Name";
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Location = new System.Drawing.Point(21, 74);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(306, 33);
            this.pnlName.TabIndex = 9;
            // 
            // pnlName2
            // 
            this.pnlName2.Controls.Add(this.txtName2);
            this.pnlName2.Controls.Add(this.lblName2);
            this.pnlName2.Location = new System.Drawing.Point(22, 113);
            this.pnlName2.Name = "pnlName2";
            this.pnlName2.Size = new System.Drawing.Size(305, 24);
            this.pnlName2.TabIndex = 10;
            // 
            // lstView
            // 
            this.lstView.FormattingEnabled = true;
            this.lstView.Location = new System.Drawing.Point(16, 162);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(633, 225);
            this.lstView.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(675, 151);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(675, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(675, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(675, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 395);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.pnlName2);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.lstProductSupplierId);
            this.Controls.Add(this.cboId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cboTableNames);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlName2.ResumeLayout(false);
            this.pnlName2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTableNames;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cboId;
        private System.Windows.Forms.ListBox lstProductSupplierId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Panel pnlName2;
        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
    }
}

