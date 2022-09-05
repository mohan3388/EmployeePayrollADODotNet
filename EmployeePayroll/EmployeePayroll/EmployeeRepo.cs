using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class EmployeeRepo
    {
        public static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=demo179;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection(ConnectionString);

        public bool AddEmployee(EmployeeModel model)
        {
            try
            {
                SqlCommand command = new SqlCommand("SpAddNewEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                command.Parameters.AddWithValue("@Address", model.Address);
                command.Parameters.AddWithValue("@Department", model.Department);
                command.Parameters.AddWithValue("@Gender", model.Gender);
                command.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                command.Parameters.AddWithValue("@Deductions", model.Deductions);
                command.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                command.Parameters.AddWithValue("@Tax", model.Tax);
                command.Parameters.AddWithValue("@NetPay", model.NetPay);
                command.Parameters.AddWithValue("@StartDate", model.StartDate);
                command.Parameters.AddWithValue("@City", model.City);
                command.Parameters.AddWithValue("@Country", model.Country);
                connection.Open();
                int i = command.ExecuteNonQuery();
                connection.Close();
                if (i != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            SqlCommand command = new SqlCommand("spViewEmployeeData", connection);
            command.CommandType = CommandType.StoredProcedure;
           
            connection.Open();
            SqlDataReader row = command.ExecuteReader();
            

            EmployeeModel model = new EmployeeModel();
            while (row.Read())
            {

                model.EmployeeId = Convert.ToInt32(row["EmployeeId"]);
                model.EmployeeName = Convert.ToString(row["EmployeeName"]);
                model.PhoneNumber = Convert.ToString(row["PhoneNumber"]);
                model.Address = Convert.ToString(row["Address"]);
                model.Department = Convert.ToString(row["Department"]);
                model.Gender = Convert.ToString(row["Gender"]);
                model.BasicPay = Convert.ToInt64(row["BasicPay"]);
                model.Deductions = Convert.ToInt32(row["Deductions"]);
                model.TaxablePay = Convert.ToInt32(row["TaxablePay"]);
                model.Tax = Convert.ToInt32(row["Tax"]);
                model.NetPay = Convert.ToInt32(row["NetPay"]);
                model.StartDate = Convert.ToDateTime(row["StartDate"]);
                model.City = Convert.ToString(row["City"]);
                model.Country = Convert.ToString(row["Country"]);

                employees.Add(model);
                  
            }
            connection.Close();
            return employees;
        }
    }
}