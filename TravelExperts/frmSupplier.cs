using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace TravelExperts
{
    /*
     * Travel Experts 2.0
     * 
     * Purpose: Supplier form. Information passed from Main form that indicates 
     *          whether it is an item add or view/update.
     * Authors: Mingyu Zhang, Kolin Lovett, Ryan Dionne, Fred Fernandez
     * Date started: April 01, 2019
     * Date submitted: May 24, 2019
     */

    public partial class frmSupplier : Form
    {
        string type;
        Nullable<int> supId;
        public bool addSupplier;
        public Suppliers supplier;
        List<Products> productsList = new List<Products>();
        List<Products_Suppliers> currentProductSupplierIds = new List<Products_Suppliers>();

        public frmSupplier()
        {
            InitializeComponent();
        }

        // inherited information from Main
        public frmSupplier(string t, int? i)
        {
            InitializeComponent();
            type = t;
            supId = i;
        }

        // load data if a SupplierID is passed from Main form
        private void loadData()
        {
            lstProducts.Items.Clear();
            List<Suppliers> supplierDetails = new List<Suppliers>();
            List<Products_Suppliers> supplierProducts = new List<Products_Suppliers>();
            supplierDetails = SuppliersDB.SupplierDetail((int)supId);
            txtSupplierID.Text = supplierDetails[0].SupplierId.ToString();
            txtSupName.Text = supplierDetails[0].SupName.ToString();
            supplierProducts = Products_SuppliersDB.SupplierProducts((int)supId);
            foreach (Products_Suppliers sprod in supplierProducts)
            {
                lstProducts.Items.Add(sprod);
            }
        }

        // set user inputted information to supplier object
        private void PutSupplierData(Suppliers sup)
        {
            //sup.SupplierId = Convert.ToInt32(txtSupplierID.Text);
            sup.SupName = txtSupName.Text;
        }

        // supplier form load depending if the view or add button clicked from Main form
        private void frmViewSupplier_Load(object sender, EventArgs e)
        {
            if (type == "View")
            {
                loadData();
                btnAddSupplier.Visible = false;
                btnAcceptEdit.Visible = false;
            }
            else if (type == "Add")
            {
                btnSupplierEdit.Visible = false;
                btnAcceptEdit.Visible = false;
                //txtSupplierID.ReadOnly = false;
                //txtSupplierID.Enabled = true;
                txtSupName.ReadOnly = false;
                txtSupName.Enabled = true;
            }
        }

        // UPDATE button click, visibility and read-only toggle 
        private void btnSupplierEdit_Click(object sender, EventArgs e)
        {
            btnAcceptEdit.Visible = true;
            btnSupplierEdit.Visible = false;
            pnlUpdate.Visible = true;
            lstProducts.Enabled = true;
            //txtSupplierID.ReadOnly = false;
            //txtSupplierID.Enabled = true;
            txtSupName.ReadOnly = false;
            txtSupName.Enabled = true;
            productsList = ProductsDB.GetProducts();

            foreach (Products prod in productsList)
            {
                cboProducts.Items.Add(prod);
            }
        }

        // CLOSE this form
        private void btnSupplierClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        // ADD NEW supplier click
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            supplier = new Suppliers();
            this.PutSupplierData(supplier);

            try
            {
                supplier.SupplierId = SuppliersDB.AddSupplier(supplier);
                MessageBox.Show("Supplier added", "Success!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            this.Close();
        }

        // accept supplier UPDATE click
        private void btnAcceptEdit_Click(object sender, EventArgs e)
        {
            Suppliers currentSupplier = SuppliersDB.GetSupplierById((int)supId);
            Suppliers newSupplier = new Suppliers();
            newSupplier.SupplierId = currentSupplier.SupplierId;
            this.PutSupplierData(newSupplier);

            if (currentSupplier.SupName == null)
            {
                MessageBox.Show("Fill in name before adding product", "Please check");
                this.DialogResult = DialogResult.OK;
            }

            else if (Validator.IsPresent(txtSupName))
            {
                try
                {
                    if (!SuppliersDB.UpdateSupplier(currentSupplier, newSupplier))
                    {
                        MessageBox.Show("Another user has updated or " +
                            "deleted that Supplier.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        supplier = newSupplier;
                        MessageBox.Show("Supplier updated", "Success!");
                        this.DialogResult = DialogResult.OK;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            this.Close();
        }

        // ADD a product to current supplier click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = cboProducts.SelectedIndex;
            int prodId = productsList[index].ProductId;
            Products_Suppliers productsSuppliers = new Products_Suppliers();

            if (prodId < 1)
            {
                MessageBox.Show("Please select supplier to add");
            }
            else
            {
                try
                {
                    int ProductSupplierId = Products_SuppliersDB.AddSupplierById(prodId, (int)supId);
                    MessageBox.Show("Product deleted", "Success!");
                    this.DialogResult = DialogResult.OK;
                    Products_Suppliers ps = Products_SuppliersDB.GetProductSupplierById(ProductSupplierId);
                    currentProductSupplierIds.Add(ps);
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        // DELETE a product to current supplier click
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string i = lstProducts.SelectedItem.ToString();
            string[] s = i.Split('|');
            int prodSupId = Int32.Parse(s[0].Trim());
            Products_Suppliers productsSuppliers = new Products_Suppliers();

            if (prodSupId < 1)
            {
                MessageBox.Show("Please select supplier to add");
            }
            else
            {
                try
                {
                    this.DialogResult = DialogResult.OK;
                    Products_Suppliers ps = Products_SuppliersDB.GetProductSupplierById(prodSupId);
                    Products_SuppliersDB.DeleteProductSupplier(ps);
                    MessageBox.Show("Product deleted", "Success!");
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
    }
}
