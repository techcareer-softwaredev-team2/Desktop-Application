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
     * Purpose: Packages class constructor
     * Authors: Mingyu Zhang, Kolin Lovett, Ryan Dionne, Fred Fernandez
     * Date started: April 01, 2019
     * Date submitted: May 24, 2019
     * NOTES: Majority of code for class library for TravelExpertsDB created by Mingyu
     */

    public class Packages
    {
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal? PkgAgencyCommission { get; set; }
        public override string ToString()
        {
            return PackageId.ToString() + " | " + PkgName;
        }
    }
}
