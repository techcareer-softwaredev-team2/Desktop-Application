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
     * Purpose: Products form. Information passed from Main form that indicates 
     *          whether it is an item add or view/update.
     * Authors: Mingyu Zhang, Kolin Lovett, Ryan Dionne, Fred Fernandez
     * Date started: April 01, 2019
     * Date submitted: May 24, 2019
     */

    public partial class frmProduct : Form
    {
        string type;
        Nullable<int> prodId;
        public bool addProduct;
        public Products product;
        List<Products_Suppliers> productsSuppliersList = new List<Products_Suppliers>();
        List<Products_Suppliers> currentProductSupplierIds = new List<Products_Suppliers>();
        List<Suppliers> suppliersList = new List<Suppliers>();

        public frmProduct()
        {
            InitializeComponent();
        }

        // inherited information from Main
        public frmProduct(string t, int? i)
        {
            InitializeComponent();
            type = t;
            prodId = i;
        }

        // load data if a ProductID is passed from Main form
        private void loadData()
        {
            List<Products> productDetails = new List<Products>();
            productDetails = ProductsDB.ProductDetail((int)prodId);
            txtProductID.Text = productDetails[0].ProductId.ToString();
            txtProdName.Text = productDetails[0].ProdName.ToString();
            List<Products_Suppliers> productSuppliers = new List<Products_Suppliers>();
            productSuppliers = DisplayProductSupplier();
        }

        // display ProductSuppliers by DB method, passing through the productID inherited from main form
        private List<Products_Suppliers> DisplayProductSupplier()
        {
            lstSuppliers.Items.Clear();
            List<Products_Suppliers> productSuppliers = Products_SuppliersDB.ProductSuppliers((int)prodId);

            foreach (Products_Suppliers psup in productSuppliers)
            {
                lstSuppliers.Items.Add(psup);
            }
            return productSuppliers;
        }

        // set user inputted information to product object
        private void PutProductData(Products prod)
        {
            prod.ProdName = txtProdName.Text;
        }

        // product form load depending if the view or add button clicked from Main form
        private void frmViewProduct_Load(object sender, EventArgs e)
        {
            if (type == "View")
            {
                loadData();
                btnAddProduct.Visible = false;
                btnAcceptEdit.Visible = false;
            }
            else if (type == "Add")
            {
                btnProductEdit.Visible = false;
                btnAcceptEdit.Visible = false;
                txtProdName.ReadOnly = false;
                txtProdName.Enabled = true;
            }
        }

        // UPDATE button click, visibility and read-only toggle 
        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            List<Products_Suppliers> currentProducts = new List<Products_Suppliers>();
            btnAcceptEdit.Visible = true;
            btnProductEdit.Visible = false;
            pnlUpdate.Visible = true;
            txtProdName.ReadOnly = false;
            txtProdName.Enabled = true;
            lstSuppliers.Enabled = true;
            suppliersList = SuppliersDB.GetSuppliers();

            foreach (Suppliers sup in suppliersList)
            {
                cboSupplier.Items.Add(sup);
            }
        }

        // CLOSE this form
        private void btnProductClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ADD NEW product click
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            product = new Products();
            this.PutProductData(product);

            try
            {
                product.ProductId = ProductsDB.AddProduct(product);
                MessageBox.Show("Product added", "Success!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Another user has updated or " +
                                "deleted that product.", "Database Error");
                this.DialogResult = DialogResult.Retry;
            }
            this.Close();
        }

        // accept product UPDATE click
        private void btnAcceptEdit_Click(object sender, EventArgs e)
        {
            Products currentProduct = ProductsDB.GetProductById((int)prodId);
            Products newProduct = new Products();
            newProduct.ProductId = currentProduct.ProductId;
            this.PutProductData(newProduct);

            if (currentProduct.ProdName == null)
            {
                MessageBox.Show("Fill in name before adding product", "Please check");
                this.DialogResult = DialogResult.OK;
            }
            else if (Validator.IsPresent(txtProdName))
            {
                try
                {
                    if (!ProductsDB.UpdateProduct(currentProduct, newProduct))
                    {
                        MessageBox.Show("Another user has updated or " +
                            "deleted that product.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        product = newProduct;
                        MessageBox.Show("Product updated", "Success!");
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

        // ADD a supplier to current product click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = cboSupplier.SelectedIndex;
            int supId = suppliersList[index].SupplierId;
            Products_Suppliers productsSuppliers = new Products_Suppliers();

            if (supId < 1)
            {
                MessageBox.Show("Please select supplier to add");
            }
            else
            {
                try
                {
                    int ProductSupplierId = Products_SuppliersDB.AddSupplierById((int)prodId, supId);
                    MessageBox.Show("Supplier added", "Success!");
                    this.DialogResult = DialogResult.OK;
                    Products_Suppliers ps = Products_SuppliersDB.GetProductSupplierById(ProductSupplierId); 
                    currentProductSupplierIds.Add(ps);
                    DisplayProductSupplier();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        // DELETE a supplier to current product click
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string i = lstSuppliers.SelectedItem.ToString();
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
                    MessageBox.Show("Supplier deleted", "Success!");
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
