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
    public partial class frmSupplier : Form
    {
        public bool addSupplier;
        public Suppliers supplier;
        string type;
        Nullable<int> supId;

        List<Products> productsList = new List<Products>();
        List<Products_Suppliers> currentProductSupplierIds = new List<Products_Suppliers>();

        public frmSupplier()
        {
            InitializeComponent();
        }
        public frmSupplier(string t, int? i)
        {
            InitializeComponent();
            type = t;
            supId = i;
        }

        private void loadData()
        {
            lstProducts.Items.Clear();
            List<Suppliers> supplierDetails = new List<Suppliers>();
            supplierDetails = SuppliersDB.SupplierDetail((int)supId);
            txtSupplierID.Text = supplierDetails[0].SupplierId.ToString();
            txtSupName.Text = supplierDetails[0].SupName.ToString();
            List<Products_Suppliers> supplierProducts = new List<Products_Suppliers>();
            supplierProducts = Products_SuppliersDB.SupplierProducts((int)supId);
            foreach (Products_Suppliers sprod in supplierProducts)
            {
                lstProducts.Items.Add(sprod);
            }
        }
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

                txtSupplierID.ReadOnly = false;
                txtSupplierID.Enabled = true;
                txtSupName.ReadOnly = false;
                txtSupName.Enabled = true;
            }
        }

        private void btnSupplierClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSupplierEdit_Click(object sender, EventArgs e)
        {
            btnAcceptEdit.Visible = true;
            btnSupplierEdit.Visible = false;
            pnlUpdate.Visible = true;
            lstProducts.Enabled = true;
            txtSupplierID.ReadOnly = false;
            txtSupplierID.Enabled = true;
            txtSupName.ReadOnly = false;
            txtSupName.Enabled = true;

            productsList = ProductsDB.GetProducts();
            foreach (Products prod in productsList)
            {
                cboProducts.Items.Add(prod);
            }
        }

        private void btnSupplierClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

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

        private void PutSupplierData(Suppliers sup)
        {
            sup.SupplierId = Convert.ToInt32(txtSupplierID.Text);
            sup.SupName = txtSupName.Text;
        }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = cboProducts.SelectedIndex;
            int prodId = productsList[index].ProductId;
            Products_Suppliers productsSuppliers = new Products_Suppliers();

            if (prodId < 1) // no selection
            {
                MessageBox.Show("Please select supplier to add");
            }
            else // user selected a product to add
            {
                try
                {
                    int ProductSupplierId = Products_SuppliersDB.AddSupplierById(prodId, (int)supId);
                    MessageBox.Show("Product deleted", "Success!");
                    this.DialogResult = DialogResult.OK;
                    Products_Suppliers ps = Products_SuppliersDB.GetProductSupplierById(ProductSupplierId); // selected product
                                                                                                            //add selected product
                    currentProductSupplierIds.Add(ps); // add to current  product supplier list
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                //DisplayCurrentPackageProductSupplierData();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string i = lstProducts.SelectedItem.ToString();
            string[] s = i.Split('|');
            int prodSupId = Int32.Parse(s[0].Trim());

            Products_Suppliers productsSuppliers = new Products_Suppliers();


            if (prodSupId < 1) // no selection
            {
                MessageBox.Show("Please select supplier to add");
            }
            else // user selected a product to add
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
