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
     * Purpose: Products database and methods
     * Authors: Mingyu Zhang, Kolin Lovett, Ryan Dionne, Fred Fernandez
     * Date started: April 01, 2019
     * Date submitted: May 24, 2019
     * NOTES: Majority of code for class library for TravelExpertsDB created by Mingyu
     */

    public static class ProductsDB
    {
        public static List<Products> GetProducts()
        {
            List<Products> products = new List<Products>(); // empty list of Products

            //create the connection
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // create select command
                string query = "SELECT ProductId, ProdName " +
                               "FROM Products";
                // any exception not handled here is automaticlly thrown to the form
                // where the method was called
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    // close connection as soon as done with reading
                    while (reader.Read())
                    {
                        Products prod = new Products(); // for reading
                        prod.ProductId = (int)reader["ProductId"];
                        prod.ProdName = reader["ProdName"].ToString();
                        products.Add(prod);
                    }
                } // command object recycled
            } // connection object recyled
            return products;
        }

        public static Products GetProduct(int item)
        {
            Products product = new Products();
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT ProductId, ProdName " +
                               "FROM Products";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.Read()) // if there is a product with this ID
                    {
                        product = new Products();
                        product.ProductId = (int)reader["ProductId"];
                        product.ProdName = reader["ProdName"].ToString();
                    }
                } // command object recycled
            } // connection object recyled
            return product;
        }


        public static List<Products> ProductDetail(int i)
        {
            List<Products> product = new List<Products>();

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT ProductId, ProdName " +
                                        "FROM Products " +
                                        "WHERE ProductId = " + i;
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (reader.Read())
                    {
                        Products prod = new Products();
                        prod.ProductId = (int)reader["ProductID"];
                        prod.ProdName = reader["ProdName"].ToString();
                        product.Add(prod);
                    }
                    return product;
                }
            }
        }


        // get all Products IDs
        public static List<int> GetProductsIds()
        {
            List<int> productIds = new List<int>(); // empty list of product Ids
            int id; // for reading
            //create the connection
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // create select command
                string query = "SELECT ProductId FROM Products "+
                               "ORDER BY ProductId";
                // any exception not handled here is automaticlly thrown to the form
                // where the method was called
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    // close connection as soon as done with reading
                    while (reader.Read())
                    {
                        id = (int)reader["ProductId"];
                        productIds.Add(id);
                    }
                } // command object recycled
            } // connection object recyled
            return productIds;
        }

        // retrieve product info with given product ID
        public static Products GetProductById(int productId)
        {
            Products product = null;

            //create the conneciton
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // create select command
                string query = "SELECT ProductId, ProdName " + 
                               "FROM Products " +
                               "WHERE ProductId=@ProductId";
                // any exception not handled here is automaticlly thrown to the form
                // where the method was called
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    //supply parameter value
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    //open the connection
                    connection.Open();
                    //run the command
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    // close connection as soon as done with reading
                    //build product object to return
                    if (reader.Read()) // if there is a product with this ID
                    {
                        product = new Products();
                        product.ProductId = (int)reader["ProductId"];
                        product.ProdName = reader["ProdName"].ToString();
                    }
                } // command object recycled
            } // connection object recyled
            return product;
        }

        // insert a new product into Products table
        // return new product ID
        public static int AddProduct(Products product)
        {
            int productId = 0;
            // create the connection 
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // create INSERT command
                // CustomerID is IDENTITY so no value provided
                string insertStatement = "INSERT INTO Products(ProdName) " +
                                         "OUTPUT inserted.ProductId " +
                                         "VALUES(@ProdName)";

                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    //supply paramter value, this way can avoid sql injection problem
                    cmd.Parameters.AddWithValue("@ProdName", product.ProdName);
                    // execute INSERT command
                    try
                    {
                        // open the connection
                        connection.Open();
                        // execute insert command and get inserted ID
                        productId = (int)cmd.ExecuteScalar();
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
            return productId;
        }

        // delete a product from Products table
        // return indicator of success
        public static bool DeleteProduct(Products product)
        {
            bool success = false;

            // create the connection 
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string deleteStatement1 =
                    "DELETE FROM Packages_Products_Suppliers " +
                    "WHERE  ProductSupplierId IN " +
                    "(SELECT ProductSupplierId " +
                    "FROM Products_Suppliers " +
                    "WHERE ProductId=@ProductId)";

                string deleteStatement2 =
                    "DELETE FROM Products_Suppliers " +
                    "WHERE ProductId=@ProductId";

                string deleteStatement3 =
                    "DELETE FROM Products " +
                    "WHERE ProductId=@ProductId " + // need for identification
                    "AND ProdName=@ProdName";  // the AND is to ensure no one is updating this product

                connection.Open();
                // start a location transaction
                SqlTransaction sqlTran = connection.BeginTransaction();

                // Enlist a command in the current transaction
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;
               //supply paramter value, this way can avoid sql injection problem
                command.Parameters.AddWithValue("@ProductId", product.ProductId);
                command.Parameters.AddWithValue("@ProdName", product.ProdName);

                try
                {
                   // Execute three separate commands
                     command.CommandText = deleteStatement1;
                     command.ExecuteNonQuery();
                     command.CommandText = deleteStatement2;
                     command.ExecuteNonQuery();
                     command.CommandText = deleteStatement3;
                     command.ExecuteNonQuery();

                  // Commit the transaction
                     sqlTran.Commit();
                     success = true;
                }
                catch (Exception )
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

        // Update Product: oldProduct - before update, newProduct - new data
        public static bool UpdateProduct(Products oldProduct, Products newProduct)
        {
            bool success = false;

            // create the connection 
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string updateStatement =
                    "UPDATE Products SET " +
                    "ProdName=@NewProdName " + // only product name can be updated
                    "WHERE ProductId=@OldProductId " + // need for identification
                    "AND ProdName=@OldProdName";  // the AND is to ensure no one is updating this product
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    //supply paramter value, this way can avoid sql injection problem
                    cmd.Parameters.AddWithValue("@NewProdName", newProduct.ProdName);
                    cmd.Parameters.AddWithValue("@OldProductId", oldProduct.ProductId);
                    cmd.Parameters.AddWithValue("@OldProdName", oldProduct.ProdName);

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
    }// class
}// namespace
