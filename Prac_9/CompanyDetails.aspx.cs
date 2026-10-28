using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace Prac_9
{
    public partial class CompanyDetails : Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["PlacementDBConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCompanySummary();
                LoadPlacedStudents();
            }
        }

        private void LoadCompanySummary()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"SELECT 
                                    CompanyName, 
                                    COUNT(StudentId) AS [Total Hired], 
                                    MAX(PackageLPA) AS [Max Package (LPA)], 
                                    AVG(PackageLPA) AS [Avg Package (LPA)]
                                 FROM Placements 
                                 GROUP BY CompanyName";

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvCompanySummary.DataSource = dt;
                    gvCompanySummary.DataBind();
                }
            }
        }

        private void LoadPlacedStudents()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"SELECT 
                                    s.EnrollmentNo, 
                                    s.StudentName, 
                                    s.Department, 
                                    p.CompanyName, 
                                    p.JobRole, 
                                    p.PackageLPA 
                                 FROM Placements p 
                                 INNER JOIN Students s ON p.StudentId = s.StudentId 
                                 ORDER BY p.CompanyName, s.StudentName";

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvPlacedStudents.DataSource = dt;
                    gvPlacedStudents.DataBind();
                }
            }
        }
    }
}