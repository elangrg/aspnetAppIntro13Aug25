using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAppEg.Models
{
    public class Employee
    {

        public int EmpID { get; set; }
        public string EmpName { get; set; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{EmpID}-{EmpName}";
        }

    }




    public class BookTitle
    {
        public string Title { get; set; }
        public string DateOfPurchase { get; set; }

    }

}