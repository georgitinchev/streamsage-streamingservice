using EmployeesProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace EmployeesProject.Pages
{
    [Authorize(Roles = nameof(UserRole.Employee))]
    public class EmployeeDetailsModel : PageModel
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi524441;User Id=dbi524441;Password=e9999619;";
        public Employee? Employee { get; set; }

        public void OnGet(int? id)
        {
            if (!id.HasValue)
            {
                ModelState.AddModelError("errormsg", "id is required");
                return;
            }

            GetEmployee(id);
        }

        public void GetEmployee(int? id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    string query = $"SELECT id, first_name, last_name, avatar " +
                        $"FROM dbo.MOCK_EMPLOYEE_DATA " +
                        $"WHERE id = {id}";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Employee = new Employee(
                            Convert.ToInt32(dr["id"]),
                            dr["first_name"].ToString(),
                            dr["last_name"].ToString(),
                            dr["avatar"].ToString()
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("errormsg", ex.Message);
            }
        }
    }
}
