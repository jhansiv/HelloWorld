using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW.Models.Employee
{
    public class Emp
    {
        public int EmpId { get; set; }
        public String EmpName { get; set; }
        public String City{ get; set; }

        public Emp()
        {

            EmpId = 0;
            EmpName = string.Empty;         
            City = String.Empty;
        }


    }
}