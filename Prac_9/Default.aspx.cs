using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace Prac_9
{
    public partial class _Default : Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["PlacementDBConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadOverviewMetrics();
                LoadAllStudentsTable();
            }
        }

        private void LoadOverviewMetrics()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                SqlCommand cmdPlaced = new SqlCommand("SELECT COUNT(*) FROM Students WHERE IsPlaced = 1", con);
                lblTotalPlaced.Text = cmdPlaced.ExecuteScalar().ToString();

                SqlCommand cmdStats = new SqlCommand(
                    "SELECT ISNULL(MAX(PackageLPA), 0), ISNULL(AVG(PackageLPA), 0) FROM Placements", con);

                using (SqlDataReader reader = cmdStats.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblHighestPackage.Text = string.Format("{0:0.00} LPA", reader[0]);
                        lblAvgPackage.Text = string.Format("{0:0.00} LPA", reader[1]);
                    }
                }
            }
        }

        private void LoadAllStudentsTable()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"SELECT 
                                    s.EnrollmentNo, 
                                    s.StudentName, 
                                    s.Department, 
                                    CASE WHEN s.IsPlaced = 1 THEN 'Placed' ELSE 'Not Placed' END AS [Status],
                                    ISNULL(p.CompanyName, '-') AS [Company Name], 
                                    ISNULL(p.JobRole, '-') AS [Job Role], 
                                    ISNULL(CAST(p.PackageLPA AS VARCHAR), '-') AS [Package (LPA)]
                                 FROM Students s
                                 LEFT JOIN Placements p ON s.StudentId = p.StudentId
                                 ORDER BY s.StudentId";

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvAllStudents.DataSource = dt;
                    gvAllStudents.DataBind();
                }
            }
        }
    }
}