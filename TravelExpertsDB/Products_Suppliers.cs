using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /*
     * Travel Experts 2.0
     * 
     * Purpose: Products_Suppliers class constructor
     * Authors: Mingyu Zhang, Kolin Lovett, Ryan Dionne, Fred Fernandez
     * Date started: April 01, 2019
     * Date submitted: May 24, 2019
     * NOTES: Majority of code for class library for TravelExpertsDB created by Mingyu
     */

    public class Products_Suppliers
    {
        public int ProductSupplierId { get; set; }
        public int? ProductId { get; set; }
        public int? SupplierId { get; set; }
        public string ProdName { get; set; }
        public string SupName { get; set; }

        public override string ToString()
        {
            return ProductSupplierId.ToString() + " | " + ProdName + " | " + SupName;
        }
    }
}
