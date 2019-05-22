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
    public partial class frmPackage : Form
    {
        public Packages package;
        public Packages_Products_Suppliers pps = null;

        public bool addPackage;
        string type;
        Nullable<int> id;
        List<int> productSupplierIds = null; // product supplierIds
        public List<int> currentProductSupplierIds = null; // current package product supplierIds

        public frmPackage()
        {
            InitializeComponent();
        }

        public frmPackage(string t, int? i)
        {
            InitializeComponent();
            type = t;
            id = i;
        }

        private void DisplayPackage()
        {
            currentProductSupplierIds = Packages_Products_SuppliersDB.GetProductSupplierIds((int)id);
            Packages currentPackage = PackagesDB.GetPackageById((int)id);

            txtPackageId.Text = currentPackage.PackageId.ToString();
            txtPkgName.Text = currentPackage.PkgName;
            txtPkgDesc.Text = currentPackage.PkgDesc;
            txtBasePrice.Text = currentPackage.PkgBasePrice.ToString();

            DisplayCurrentPackageProductSupplierData();

            if (currentPackage.PkgStartDate == null)
                dtpStartDate.Text = "";
            else
            {
                DateTime startDate = (DateTime)currentPackage.PkgStartDate;
                dtpStartDate.Text = startDate.ToShortDateString();
            }

            if (currentPackage.PkgEndDate == null)
                dtpEndDate.Text = "";
            else
            {
                DateTime endDate = (DateTime)currentPackage.PkgEndDate;
                dtpEndDate.Text = endDate.ToShortDateString();
            }

            if (currentPackage.PkgAgencyCommission.Equals(null))
                txtCommission.Text = "";
            else
                txtCommission.Text = Convert.ToDecimal(currentPackage.PkgAgencyCommission).ToString();
        }

        private void ReadOnlyToggle()
        {
            txtPackageId.ReadOnly = true;
            txtPkgName.ReadOnly = false;
            txtPkgDesc.ReadOnly = false;
            txtBasePrice.ReadOnly = false;
            txtCommission.ReadOnly = false;

            txtPkgName.Enabled = true;
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            txtPkgDesc.Enabled = true;
            txtBasePrice.Enabled = true;
            txtCommission.Enabled = true;
            lstPackProdSupp.Enabled = true;
        }

        private void DisplayProductSupplierData()
        {
            productSupplierIds = Products_SuppliersDB.GetProductSupplierIds();
            lstProdSup.Items.Clear();
            lstProdSup.Items.Add("Id " + ": " + "Product Name" + ",  " + "Supplier Name");
            foreach (int id in productSupplierIds)
            {
                Products_Suppliers ps = Products_SuppliersDB.GetProductSupplierById(id);
                lstProdSup.Items.Add(ps);
            }
        }

        private void DisplayCurrentPackageProductSupplierData()
        {
            if (currentProductSupplierIds != null) // if we have product suppliers to display
            {
                lstPackProdSupp.Items.Clear();//start with empty list box
                lstPackProdSupp.Items.Add("Id " + ": " + "Product Name" + ",  " + "Supplier Name");
                foreach (int id in currentProductSupplierIds)
                {
                    Products_Suppliers ps = Products_SuppliersDB.GetProductSupplierById((int)id);
                    lstPackProdSupp.Items.Add(ps);
                }
            }
            else // null this product does not exist - need to refresh combo box
            {
                lstPackProdSupp.Items.Clear();
            }
        }

        private void PutPackageData(Packages package)
        {
            package.PkgName = txtPkgName.Text;

            if (dtpStartDate.Text == "")
                package.PkgStartDate = null;
            else
            {
                package.PkgStartDate = Convert.ToDateTime(dtpStartDate.Text);
            }

            if (dtpEndDate.Text == "")
                package.PkgEndDate = null;
            else
            {
                package.PkgEndDate = Convert.ToDateTime(dtpEndDate.Text);
            }

            package.PkgDesc = txtPkgDesc.Text;

            package.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text);

            if (txtCommission.Text == "")
                package.PkgAgencyCommission = null;
            else
                package.PkgAgencyCommission = Convert.ToDecimal(txtCommission.Text);
        }

        // NEED TO FIX THIS CODE TO VALIDATE DATES. RETURNS BOOL
        private bool IsValidShippedDate()
        {
            DateTime startDateOut;
            if (dtpStartDate.Text != "")
            {
                if (DateTime.TryParse(dtpStartDate.Text, out startDateOut) && dtpEndDate.Text == "" && dtpEndDate.Text == "")
                {
                    return true;
                }

                else if (DateTime.TryParse(dtpStartDate.Text, out startDateOut) && dtpStartDate.Text != "" && dtpEndDate.Text != "")
                {
                    DateTime startDate = Convert.ToDateTime(dtpStartDate.Text);
                    DateTime endDate = Convert.ToDateTime(dtpEndDate.Text);
                    if (startDate >= endDate)
                    {
                        MessageBox.Show("Start Date must be ealier than end Date ", "Data Error");
                        dtpStartDate.Focus();
                        this.Close();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Date Ended in format YYYY-MM-DD", "Data Error");
                    this.Close();
                    return false;
                }
            }
            return true;
        }

        private void frmViewPackage_Load(object sender, EventArgs e)
        {
            DisplayProductSupplierData();
            if (type == "View")
            {
                lblCurrentProducts.Text = "Current Products";
                pnlUpdate.Visible = false;
                pnlUpdate2.Visible = true;
                btnDelete.Visible = false;
                btnAddPackage.Visible = false;
                btnAcceptEdit.Visible = false;
                DisplayPackage();
            }
            else if (type == "Add")
            {
                pnlAdd.Visible = true;
                pnlUpdate.Visible = false;
                pnlUpdate2.Visible = true;
                btnPackageEdit.Visible = false;
                btnAcceptEdit.Visible = false;
                ReadOnlyToggle();
            }
        }

        private void btnPackageClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPackageEdit_Click(object sender, EventArgs e)
        {
            DisplayProductSupplierData();
            btnAcceptEdit.Visible = true;
            btnPackageEdit.Visible = false;
            btnDelete.Visible = true;
            pnlUpdate.Visible = true;
            ReadOnlyToggle();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            package = new Packages();
            bool currentDates = IsValidShippedDate();

            if (Validator.IsPresent(txtPkgName) &&
                     Validator.IsPresent(txtPkgDesc) &&
                     Validator.IsDecimal(txtBasePrice) &&
                     Validator.IsDecimal(txtCommission) &&
                     currentDates == true)
            {
                
                this.PutPackageData(package);
                try
                {
                    package.PackageId = PackagesDB.AddPackage(package);
                    MessageBox.Show("Package added", "Success!");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }

            else if (package.PkgName == null ||
                package.PkgDesc == null
                )
            {
                MessageBox.Show("Fill in name and description before adding package", "Please check");
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstProdSup.SelectedIndex < 0) // no selection
            {
                MessageBox.Show("Please select product supplier to add");
            }
            else
            {
                Packages currentPackage = PackagesDB.GetPackageById((int)id);
                string i = lstProdSup.SelectedItem.ToString();
                string[] s = i.Split('|');
                int prodSupId = Int32.Parse(s[0].Trim());

                Products_Suppliers selectedProductSupplier = Products_SuppliersDB.GetProductSupplierById(prodSupId);

                try
                {
                    if (!Packages_Products_SuppliersDB.AddPackageProductSupplier(currentPackage.PackageId, selectedProductSupplier.ProductSupplierId))
                    {
                        MessageBox.Show("Product added", "Success!");
                        this.DialogResult = DialogResult.OK;
                        DisplayPackage();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstPackProdSupp.SelectedIndex;
            string i = lstPackProdSupp.SelectedItem.ToString();
            string[] s = i.Split('|');
            int pid = Int32.Parse(s[0].Trim());
            //Packages_Products_Suppliers currentPackage = Packages_Products_SuppliersDB.GetPackageIds

            if (pid < 1) // no selection
            {
                MessageBox.Show("Please select product supplier to delete");
            }
            else // user selected a product to delete
            {
                if (type == "View")
                {
                    Products_Suppliers pps = Products_SuppliersDB.GetProductSupplierById(pid); // selected product
                    DialogResult answer =
                        MessageBox.Show("Are you sure to delete " + pps.ProdName + "?",
                        "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        //delete selected package product supplier
                        try
                        {
                            if (!Packages_Products_SuppliersDB.DeletePackageProductSupplier((int)id, pps.ProductSupplierId))
                            {
                                MessageBox.Show("Another user has updated or deleted " +
                                    "that product.", "Database Error");
                            }
                            else
                                currentProductSupplierIds.RemoveAt(index - 1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                        // remove from the current  product supplier  list
                        DisplayCurrentPackageProductSupplierData();
                    }
                }
            }
        }

        private void btnAcceptEdit_Click(object sender, EventArgs e)
        {
            Packages currentPackage = PackagesDB.GetPackageById((int)id);
            Packages newPackage = new Packages();
            bool currentDates = IsValidShippedDate();

            if (currentPackage.PkgName == null ||
                currentPackage.PkgDesc == null
                )
            {
                MessageBox.Show("Fill in name and description before adding package", "Please check");

                this.DialogResult = DialogResult.OK;
            }

            else if (Validator.IsPresent(txtPkgName) &&
                     Validator.IsPresent(txtPkgDesc) &&
                     Validator.IsDecimal(txtBasePrice) &&
                     Validator.IsDecimal(txtCommission) &&
                     currentDates == true)
            {
                
                newPackage.PackageId = currentPackage.PackageId;
                this.PutPackageData(newPackage);
                try
                {
                    if (!PackagesDB.UpdatePackage(currentPackage, newPackage))
                    {
                        MessageBox.Show("Another user has updated or " +
                            "deleted that package.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else 
                    {
                        package = newPackage;
                        MessageBox.Show("Package updated", "Success!");
                        this.DialogResult = DialogResult.OK;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                this.Close();
            }
        }

        private void frmPackage_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain main = new frmMain();
            main.DisplayPackages();
        }
    }
}

