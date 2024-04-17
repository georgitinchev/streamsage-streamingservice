using EmployeesProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace EmployeesProject.Pages
{
    public class EmployeesModel : PageModel
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi524441;User Id=dbi524441;Password=e9999619;";
        public List<Employee> Employees;

        public EmployeesModel()
        {
            Employees = new List<Employee>();
            GetEmployees();
        }

        public void GetEmployees()
        {
            try
            {
             using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    string query = "SELECT id, first_name, last_name, avatar,street_name, street_number, zip_code, city, country FROM dbo.MOCK_EMPLOYEE_DATA";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Employees.Add(new Employee(
                            Convert.ToInt32(dr["id"]),
                            dr["first_name"].ToString(),
                            dr["last_name"].ToString(),
                            dr["avatar"].ToString()
                            ));
                    }
                }
            }
            catch(Exception)
            {

            }
        }
        public void OnGet()
        {

        }
    }
}
