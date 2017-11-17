using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW.Models.Employee;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
//using Microsoft.Extensions.Configuration;

namespace DataAccess.DAL
{
    public class Employee: IEmployee
    {
       
        public List<Emp> GetEmployees()
        {
            List<Emp> Employees = new List<Emp>();
            Emp Emp = new Emp();

            using (SqlConnection conn= new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringReadOnly"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.Employee_Load", conn))
                {

                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;                   
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds!= null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        DataTable dtItems = ds.Tables[0];


                        foreach (DataRow dr in dtItems.Rows)
                        {
                            Emp.EmpId = Convert.ToInt32(dr["EmpId"]);
                            Emp.EmpName = dr["EmpName"].ToString();
                            Emp.City = dr["City"].ToString();
                          
                            Employees.Add(Emp);

                        }
                    }
                                          
                        conn.Close();
                }
            }

                    return Employees;
        }

    }
}