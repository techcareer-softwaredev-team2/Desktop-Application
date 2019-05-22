namespace TravelExperts
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
            this.lstView = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDatabases = new System.Windows.Forms.GroupBox();
            this.radSuppliers = new System.Windows.Forms.RadioButton();
            this.radPackages = new System.Windows.Forms.RadioButton();
            this.radProducts = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpDatabases.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstView
            // 
            this.lstView.FormattingEnabled = true;
            this.lstView.Location = new System.Drawing.Point(18, 90);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(303, 303);
            this.lstView.TabIndex = 11;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(125, 422);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(90, 23);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "&View Item";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 422);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "&Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(231, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpDatabases
            // 
            this.grpDatabases.Controls.Add(this.radSuppliers);
            this.grpDatabases.Controls.Add(this.radPackages);
            this.grpDatabases.Controls.Add(this.radProducts);
            this.grpDatabases.Location = new System.Drawing.Point(18, 12);
            this.grpDatabases.Name = "grpDatabases";
            this.grpDatabases.Size = new System.Drawing.Size(303, 72);
            this.grpDatabases.TabIndex = 22;
            this.grpDatabases.TabStop = false;
            this.grpDatabases.Text = "Select database";
            // 
            // radSuppliers
            // 
            this.radSuppliers.AutoSize = true;
            this.radSuppliers.Location = new System.Drawing.Point(222, 30);
            this.radSuppliers.Name = "radSuppliers";
            this.radSuppliers.Size = new System.Drawing.Size(68, 17);
            this.radSuppliers.TabIndex = 25;
            this.radSuppliers.TabStop = true;
            this.radSuppliers.Text = "Suppliers";
            this.radSuppliers.UseVisualStyleBackColor = true;
            this.radSuppliers.CheckedChanged += new System.EventHandler(this.radSuppliers_CheckedChanged);
            // 
            // radPackages
            // 
            this.radPackages.AutoSize = true;
            this.radPackages.Location = new System.Drawing.Point(17, 30);
            this.radPackages.Name = "radPackages";
            this.radPackages.Size = new System.Drawing.Size(73, 17);
            this.radPackages.TabIndex = 23;
            this.radPackages.TabStop = true;
            this.radPackages.Text = "Packages";
            this.radPackages.UseVisualStyleBackColor = true;
            this.radPackages.CheckedChanged += new System.EventHandler(this.radPackages_CheckedChanged);
            // 
            // radProducts
            // 
            this.radProducts.AutoSize = true;
            this.radProducts.Location = new System.Drawing.Point(122, 30);
            this.radProducts.Name = "radProducts";
            this.radProducts.Size = new System.Drawing.Size(67, 17);
            this.radProducts.TabIndex = 24;
            this.radProducts.TabStop = true;
            this.radProducts.Text = "Products";
            this.radProducts.UseVisualStyleBackColor = true;
            this.radProducts.CheckedChanged += new System.EventHandler(this.radProducts_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(231, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "&Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 524);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grpDatabases);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lstView);
            this.Name = "frmMain";
            this.Text = "Travel Experts | Agent Portal";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpDatabases.ResumeLayout(false);
            this.grpDatabases.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpDatabases;
        private System.Windows.Forms.RadioButton radSuppliers;
        private System.Windows.Forms.RadioButton radPackages;
        private System.Windows.Forms.RadioButton radProducts;
        private System.Windows.Forms.Button btnDelete;
    }
}

