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
     * Purpose: Suppliers class constructor
     * Authors: Mingyu Zhang, Kolin Lovett, Ryan Dionne, Fred Fernandez
     * Date started: April 01, 2019
     * Date submitted: May 24, 2019
     * NOTES: Majority of code for class library for TravelExpertsDB created by Mingyu
     */

    public class Suppliers
    {
        public int SupplierId { get; set; }
        public string SupName { get; set; }
        public override string ToString()
        {
            return SupplierId.ToString() + " | " + SupName;
        }
    }
}
