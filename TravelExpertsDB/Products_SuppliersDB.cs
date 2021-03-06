﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /*
     * Travel Experts 2.0
     * 
     * Purpose: Products_Suppliers database and methods
     * Authors: Mingyu Zhang, Kolin Lovett, Ryan Dionne, Fred Fernandez
     * Date started: April 01, 2019
     * Date submitted: May 24, 2019
     * NOTES: Majority of code for class library for TravelExpertsDB created by Mingyu
     */

    public static class Products_SuppliersDB
    {
        public static List<Products_Suppliers> GetProductSupplier()
        {
            List<Products_Suppliers> productSuppliers = new List<Products_Suppliers>();

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // create select command
                string query = "SELECT ProductSupplierId, ps.ProductId, ps.SupplierId,ProdName, SupName " +
                               "FROM Products_Suppliers ps " +
                               "JOIN Products p  ON ps.ProductId=p.ProductId " +
                               "JOIN Suppliers s  ON ps.SupplierId=s.SupplierId";
                // any exception not handled here is automaticlly thrown to the form
                // where the method was called
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    // close connection as soon as done with reading
                    while (reader.Read())
                    {
                        Products_Suppliers prodSup = new Products_Suppliers(); // for reading
                        prodSup.ProductSupplierId = (int)reader["ProductSupplierId"];

                        int col_pro = reader.GetOrdinal("ProductId"); //column number of ProductId
                        if (reader.IsDBNull(col_pro)) // if reader contains DBNull in this column
                            prodSup.ProductId = null; // make it null in the object
                        else // it is not null
                            prodSup.ProductId = (int)reader["ProductId"];

                        int col_sup = reader.GetOrdinal("SupplierId"); //column number of SupplierId
                        if (reader.IsDBNull(col_sup)) // if reader contains DBNull in this column
                            prodSup.SupplierId = null; // make it null in the object
                        else // it is not null
                            prodSup.SupplierId = (int)reader["SupplierId"];

                        prodSup.ProdName = reader["ProdName"].ToString();
                        prodSup.SupName = reader["SupName"].ToString();
                        productSuppliers.Add(prodSup);
                    }
                } // command object recycled
            } // connection object recyled
            return productSuppliers;
        }
        // get all ProductSupplier Ids

        public static List<Products_Suppliers> ProductSuppliers(int i)
        {
            List<Products_Suppliers> productSupplierList = new List<Products_Suppliers>();

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT ps.ProductSupplierId, p.ProductId, p.ProdName, s.SupplierId, s.SupName " +
                               "FROM Products_Suppliers AS ps " +
                               "INNER JOIN Products AS p on ps.ProductId = p.ProductId " +
                               "INNER JOIN Suppliers AS s on ps.SupplierId = s.SupplierId " +
                               "where p.ProductId = " + i +
                               " ORDER BY SupName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Products_Suppliers productSupplierItem = new Products_Suppliers();
                        productSupplierItem.ProductSupplierId = (int)reader[0];
                        productSupplierItem.ProductId = (int)reader[1];
                        productSupplierItem.ProdName = reader[2].ToString();
                        productSupplierItem.SupplierId = (int)reader[3];
                        productSupplierItem.SupName = reader[4].ToString();

                        productSupplierList.Add(productSupplierItem);
                    }
                    return productSupplierList;
                }
            }
        }

        public static List<Products_Suppliers> SupplierProducts(int i)
        {
            List<Products_Suppliers> supplierProductList = new List<Products_Suppliers>();

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT ps.ProductSupplierId, s.SupplierId, s.SupName, p.ProductId, p.ProdName " +
                               "FROM Products_Suppliers AS ps " +
                               "INNER JOIN Products AS p on ps.ProductId = p.ProductId " +
                               "INNER JOIN Suppliers AS s on ps.SupplierId = s.SupplierId " +
                               "WHERE s.SupplierID = " + i +
                               " ORDER BY ProdName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Products_Suppliers supplierProductItem = new Products_Suppliers();
                        supplierProductItem.ProductSupplierId = (int)reader[0];
                        supplierProductItem.SupplierId = (int)reader[1];
                        supplierProductItem.SupName = reader[2].ToString();
                        supplierProductItem.ProductId = (int)reader[3];
                        supplierProductItem.ProdName = reader[4].ToString();

                        supplierProductList.Add(supplierProductItem);
                    }
                    return supplierProductList;
                }
            }
        }

        public static List<int> GetProductSupplierIds()
        {
            List<int> productSupplierIds = new List<int>(); // empty list of ProductSupplier Ids
            int id; // for reading
            //create the connection
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // create select command
                string query = "SELECT ProductSupplierId FROM Products_Suppliers " +
                               "ORDER BY ProductSupplierId";
                // any exception not handled here is automaticlly thrown to the form
                // where the method was called
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    // close connection as soon as done with reading
                    while (reader.Read())
                    {
                        id = (int)reader["ProductSupplierId"];
                        productSupplierIds.Add(id);
                    }
                } // command object recycled
            } // connection object recyled
            return productSupplierIds;
        }

        public static int AddSupplierById(int ProductId, int SupplierId)
        {
            int productSupplierId = 0;  // product supplier id
            //create the conneciton
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // create select command
                string insertStatement = "INSERT INTO Products_Suppliers(ProductId,SupplierId) " +
                                         "OUTPUT inserted.ProductSupplierId " +
                                         "VALUES(@ProductId, @SupplierId) ";
                // any exception not handled here is automaticlly thrown to the form
                // where the method was called
                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    //supply paramter value, this way can avoid sql injection problem
                    cmd.Parameters.AddWithValue("@ProductId", ProductId);
                    cmd.Parameters.AddWithValue("@SupplierId", SupplierId);
                    // execute INSERT command
                    try
                    {
                        // open the connection
                        connection.Open();
                        // execute insert command and get inserted ID
                        productSupplierId = (int)cmd.ExecuteScalar();
                                         }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally // executes always
                    {
                        connection.Close();
                    }
                }
            }
            return productSupplierId;
        }

        public static int GetSupplierById(int ProductId, int SupplierId)
        {
            int productSupplierId = 0;  // product supplier id
            //create the conneciton
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // create select command
                string insertStatement = "SELECT ProductId, SupplierId FROM Products_Suppliers " +
                                         "ORDER BY ProductSupplierId " +
                                         "WHERE ProductId=@ProductId";
                // any exception not handled here is automaticlly thrown to the form
                // where the method was called
                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    //supply paramter value, this way can avoid sql injection problem
                    cmd.Parameters.AddWithValue("@ProductId", ProductId);
                    cmd.Parameters.AddWithValue("@SupplierId", SupplierId);
                    // execute INSERT command
                    try
                    {
                        // open the connection
                        connection.Open();
                        // execute insert command and get inserted ID
                        productSupplierId = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally // executes always
                    {
                        connection.Close();
                    }
                }
            }
            return productSupplierId;
        }

        // retrieve productSupplier info with given productSupplier Id
        public static Products_Suppliers GetProductSupplierById(int productSupplierId)
        {
            Products_Suppliers productSupplier = null;

            //create the conneciton
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // create select command
                string query = "SELECT ProductSupplierId, ps.ProductId, ps.SupplierId, ProdName, SupName " +
                               "FROM Products_Suppliers ps " +
                               "JOIN Products p  ON ps.ProductId=p.ProductId " +
                               "JOIN Suppliers s  ON ps.SupplierId=s.SupplierId " +
                               "WHERE ProductSupplierId=@ProductSupplierId";

                // any exception not handled here is automaticlly thrown to the form
                // where the method was called
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    //supply parameter value
                    cmd.Parameters.AddWithValue("@ProductSupplierId", productSupplierId);
                    //open the connection
                    connection.Open();
                    //run the command
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    // close connection as soon as done with reading
                    //build product object to return
                    if (reader.Read()) // if there is a product with this ID
                    {
                        productSupplier = new Products_Suppliers();
                        productSupplier.ProductSupplierId = (int)reader["ProductSupplierId"];

                        int col_pro = reader.GetOrdinal("ProductId"); //column number of ProductId
                        if (reader.IsDBNull(col_pro)) // if reader contains DBNull in this column
                            productSupplier.ProductId = null; // make it null in the object
                        else // it is not null
                            productSupplier.ProductId = (int)reader["ProductId"];

                        int col_sup = reader.GetOrdinal("SupplierId"); //column number of SupplierId
                        if (reader.IsDBNull(col_sup)) // if reader contains DBNull in this column
                            productSupplier.SupplierId = null; // make it null in the object
                        else // it is not null
                            productSupplier.SupplierId = (int)reader["SupplierId"];

                        productSupplier.ProdName = reader["ProdName"].ToString();
                        productSupplier.SupName = reader["SupName"].ToString();
                    }
                } // command object recycled
            } // connection object recyled
            return productSupplier;
        }

        // insert a new product supplier into Products_Suppliers table
        // return new product_supplier Id
        public static int AddProductSupplier(Products_Suppliers productSupplier)
        {
            int productSupplierId = 0;
            // create the connection 
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // create INSERT command
                // CustomerID is IDENTITY so no value provided
                string insertStatement = "INSERT INTO Products_Suppliers(ProductId, SupplierId) " +
                                         "OUTPUT inserted.ProductSupplierId " +
                                         "VALUES(@ProductId, @SupplierId)";

                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    //supply paramter value, this way can avoid sql injection problem
                    if (productSupplier.ProductId == null)
                        cmd.Parameters.AddWithValue("@ProductId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@ProductId", productSupplier.ProductId);

                    if (productSupplier.SupplierId == null)
                        cmd.Parameters.AddWithValue("@SupplierId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@SupplierId", productSupplier.SupplierId);
                    // execute INSERT command
                    try
                    {
                        // open the connection
                        connection.Open();
                        // execute insert command and get inserted ID
                        productSupplierId = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally // executes always
                    {
                        connection.Close();
                    }
                }
            }
            return productSupplierId;
        }

        // delete a product supplier from Products_Suppliers table
        // return indicator of success
        public static bool DeleteProductSupplier(Products_Suppliers productSupplier)
        {
            bool success = false;

            // create the connection 
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string deleteStatement1 =
                   "DELETE FROM Packages_Products_Suppliers " +
                   "WHERE  ProductSupplierId=@ProductSupplierId ";

                string deleteStatement2 =
                    "DELETE FROM Products_Suppliers " +
                    "WHERE ProductSupplierId=@ProductSupplierId " + // need for identification
                    "AND (ProductId=@ProductId OR ProductId IS NULL AND @ProductId IS NULL) " +
                    "AND (SupplierId=@SupplierId OR SupplierId IS NULL AND @SupplierId IS NULL)";  // the AND is to ensure no one is updating this product                

                connection.Open();
                // start a location transaction
                SqlTransaction sqlTran = connection.BeginTransaction();

                // Enlist a command in the current transaction
                SqlCommand cmd = connection.CreateCommand();
                cmd.Transaction = sqlTran;
                //supply paramter value, this way can avoid sql injection problem
                cmd.Parameters.AddWithValue("@ProductSupplierId", productSupplier.ProductSupplierId);

                if (productSupplier.ProductId == null)
                    cmd.Parameters.AddWithValue("@ProductId", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@ProductId", productSupplier.ProductId);

                if (productSupplier.SupplierId == null)
                    cmd.Parameters.AddWithValue("@SupplierId", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@SupplierId", productSupplier.SupplierId);

                try
                {
                    // Execute three separate commands
                    cmd.CommandText = deleteStatement1;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = deleteStatement2;
                    cmd.ExecuteNonQuery();

                    // Commit the transaction
                    sqlTran.Commit();
                    success = true;
                }
                catch (Exception)
                {
                    try
                    {
                        //Atttemp to roll back the transaction
                        sqlTran.Rollback();
                        success = false;
                    }
                    catch (Exception exRollback)
                    {
                        throw exRollback;
                    }
                }
                finally // executes always
                {
                    connection.Close();
                }
            }
            //return the indicator of success
            return success;
        }
        // Update Product: oldProductSupplier - before update, newProductSupplier - new data
        public static bool UpdateProductSupplier(Products_Suppliers oldProductSupplier, Products_Suppliers newProductSupplier)
        {
            bool success = false;

            // create the connection 
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string updateStatement =
                    "UPDATE Products_Suppliers SET " +
                    "ProductId=@NewProductId, " +
                    "SupplierId=@NewSupplierId " +
                    "WHERE ProductSupplierId=@OldProductSupplierId " + // need for identification
                    "AND (ProductId=@OldProductId OR ProductId IS NULL AND @OldProductId IS NULL) " +
                    "AND (SupplierId=@OldSupplierId OR SupplierId IS NULL AND @OldSupplierId IS NULL)";  // the AND is to ensure no one is updating this product
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    //supply paramter value, this way can avoid sql injection problem
                    cmd.Parameters.AddWithValue("@OldProductSupplierId", oldProductSupplier.ProductSupplierId);
                    if (newProductSupplier.ProductId == null)
                        cmd.Parameters.AddWithValue("@NewProductId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NewProductId", newProductSupplier.ProductId);

                    if (newProductSupplier.SupplierId == null)
                        cmd.Parameters.AddWithValue("@NewSupplierId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NewSupplierId", newProductSupplier.SupplierId);


                    if (oldProductSupplier.ProductId == null)
                        cmd.Parameters.AddWithValue("@OldProductId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@OldProductId", oldProductSupplier.ProductId);

                    if (oldProductSupplier.SupplierId == null)
                        cmd.Parameters.AddWithValue("@OldSupplierId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@OldSupplierId", oldProductSupplier.SupplierId);

                    try
                    {
                        // open the connection
                        connection.Open();
                        // execute the delete command 
                        int count = cmd.ExecuteNonQuery(); // returns the number of rows affected 

                        // check if successful
                        if (count > 0)
                            success = true;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally // executes always
                    {
                        connection.Close();
                    }
                }
            }
            //return the indicator of success
            return success;
        }
    }
}
