using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW.Models.Employee;


namespace DataAccess.DAL
{
    interface IEmployee
    {

        List<Emp> GetEmployees();

    }
}
