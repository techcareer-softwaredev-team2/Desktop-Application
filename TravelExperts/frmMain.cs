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
    public partial class frmMain : Form
    {
        // List<string> tableNames = null; //all table names // use this for combobox implementation
        // List<int> packageIds = null;//package Ids // use this for combobox implementation
        // List<int> productIds = null; // productIds // use this for combobox implementation
        // List<int> supplierIds = null; // supplierIds // use this for combobox implementation
        // List<int> productSupplierIds = null; // product supplierIds // use this for combobox implementation

        Packages currentPackage = null;// empty package
        List<Packages> packagesList = null;//empty pacakge list

        Products currentProduct = null; // empty product
        List<Products> productsList = null;//empty products list

        Suppliers currentSupplier = null; // empty supplier
        List<Suppliers> suppliersList = null;//empty products list 

        Products_Suppliers currentProductSupplier = null; // empty product supplier
        List<Products_Suppliers> productSuppliers = null; //empt products_suppliers list

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // LoadComboBox(); // for combobox use
        }

        private void radPackages_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPackages();
        }

        private void radProducts_CheckedChanged(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void radSuppliers_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySuppliers();
        }

        public void DisplayPackages()
        {
            packagesList = PackagesDB.GetPackages();
            if (packagesList != null) // if we have product suppliers to display
            {
                lstView.Items.Clear();//start with empty list box
                foreach (Packages pkg in packagesList)
                {
                    lstView.Items.Add(pkg);
                    lstView.Refresh();
                }
            }
            else // null this package does not exist - need to refresh combo box
            {
                MessageBox.Show("There is no package to display.");
            }
        }

        private void DisplayProducts()
        {
            productsList = ProductsDB.GetProducts();
            if (productsList != null) // if we have products to display
            {
                lstView.Items.Clear();//start with empty list box
                foreach (Products prod in productsList)
                {
                    lstView.Items.Add(prod);
                }
            }
            else // null this product does not exist - need to refresh combo box
            {
                MessageBox.Show("There is no product to display.");
            }
        }

        private void DisplaySuppliers()
        {
            suppliersList = SuppliersDB.GetSuppliers();
            if (suppliersList != null) // if we have product suppliers to display
            {
                lstView.Items.Clear();//start with empty list box
                foreach (Suppliers sup in suppliersList)
                {
                    lstView.Items.Add(sup);
                }
            }
            else // null this supplier does not exist - need to refresh combo box
            {
                MessageBox.Show("There is no supplier to display.");
            }
        }

        private void DisplayProductSupplier()
        {
            productSuppliers = Products_SuppliersDB.GetProductSupplier();
            if (productSuppliers != null) // if we have product suppliers to display
            {
                lstView.Items.Clear();//start with empty list box
                foreach (Products_Suppliers prodsup in productSuppliers)
                {
                    lstView.Items.Add(prodsup);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (radPackages.Checked == false && radProducts.Checked == false && radSuppliers.Checked == false)
            {
                MessageBox.Show("Please select a database to add to.", "Select a Database");
            }
            else if (radPackages.Checked)
            {
                frmPackage viewPackage = new frmPackage("Add", null);
                viewPackage.Show();
            }
            else if (radProducts.Checked)
            {
                frmProduct viewProduct = new frmProduct("Add", null);
                viewProduct.Show();
            }
            else if (radSuppliers.Checked)
            {
                frmSupplier viewSupplier = new frmSupplier("Add", null);
                viewSupplier.Show();
            }
            this.lstView.Refresh();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (radPackages.Checked == false && radProducts.Checked == false && radSuppliers.Checked == false)
            {
                MessageBox.Show("Please select a database to view.", "Select a Database");
            }
            else if (radPackages.Checked)
            {
                try
                {
                    string i = lstView.SelectedItem.ToString();
                    string[] s = i.Split('|');
                    int packId = Int32.Parse(s[0].Trim());
                    frmPackage viewPackage = new frmPackage("View", packId);
                    viewPackage.Show();
                }
                catch
                {
                    MessageBox.Show("Please select an item from the list before clicking the View button.");
                }
            }
            else if (radProducts.Checked)
            {
                try
                {
                    string i = lstView.SelectedItem.ToString();
                    string[] s = i.Split('|');
                    int proId = Int32.Parse(s[0].Trim());
                    frmProduct viewProduct = new frmProduct("View", proId);
                    viewProduct.Show();
                }
                catch
                {
                    MessageBox.Show("Please select an item from the list before clicking the View button.");
                }
            }
            else if (radSuppliers.Checked)
            {
                try
                {
                    string i = lstView.SelectedItem.ToString();
                    string[] s = i.Split('|');
                    int supId = Int32.Parse(s[0].Trim());
                    frmSupplier viewSupplier = new frmSupplier("View", supId);
                    viewSupplier.Show();
                }
                catch
                {
                    MessageBox.Show("Please select an item from the list before clicking the View button.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (radPackages.Checked == false && radProducts.Checked == false && radSuppliers.Checked == false)
            {
                MessageBox.Show("Please select a database to delete from.", "Select a Database");
            }
            else if (radPackages.Checked)
            {
                string i = lstView.SelectedItem.ToString();
                string[] s = i.Split('|');
                int packageId = Int32.Parse(s[0].Trim());
                string nameSelected = s[1].Trim();

                currentPackage = PackagesDB.GetPackageById(packageId);

                DialogResult result = MessageBox.Show("Delete Packages " + nameSelected + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!PackagesDB.DeletePackage(currentPackage))
                        {
                            MessageBox.Show("Another user has updated or deleted " +
                                "that package.", "Database Error");
                            currentPackage = PackagesDB.GetPackageById(packageId);
                        }
                        else
                        {
                            this.DisplayPackages();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
            else if (radProducts.Checked)
            {
                string i = lstView.SelectedItem.ToString();
                string[] s = i.Split('|');
                int productId = Int32.Parse(s[0].Trim());
                string nameSelected = s[1].Trim();

                currentProduct = ProductsDB.GetProductById(productId);

                DialogResult result = MessageBox.Show("Delete Product " + nameSelected + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!ProductsDB.DeleteProduct(currentProduct))
                        {
                            MessageBox.Show("Another user has updated or deleted " +
                                "that package.", "Database Error");
                            currentProduct = ProductsDB.GetProductById(productId);
                        }
                        else
                        {
                            this.DisplayProducts();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
            else if (radSuppliers.Checked)
            {
                string i = lstView.SelectedItem.ToString();
                string[] s = i.Split('|');
                int supplierId = Int32.Parse(s[0].Trim());
                string nameSelected = s[1].Trim();

                currentSupplier = SuppliersDB.GetSupplierById(supplierId);

                DialogResult result = MessageBox.Show("Delete Supplier " + nameSelected + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!SuppliersDB.DeleteSupplier(currentSupplier))
                        {
                            MessageBox.Show("Another user has updated or deleted " +
                                "that package.", "Database Error");
                            currentSupplier = SuppliersDB.GetSupplierById(supplierId);
                        }
                        else
                        {
                            this.DisplaySuppliers();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }
    }
}
