using System.Linq;
using System.Data;
using System.Data.SqlClient;

string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True";
#region Ajouter Users
//using (SqlConnection conn = new SqlConnection(connectionString))
//{
//    using (SqlCommand cmd = conn.CreateCommand())
//    {
//        cmd.CommandText = "AddStudent";
//        cmd.CommandType = CommandType.StoredProcedure;
//        cmd.Parameters.AddWithValue("firstname", "Martin");
//        cmd.Parameters.AddWithValue("lastname", "Coutellier");
//        cmd.Parameters.AddWithValue("sectionID", 1010);
//        cmd.Parameters.AddWithValue("yearResult", 18);
//        cmd.Parameters.AddWithValue("birthDate", new DateTime(1992, 11, 08));

//        conn.Open();
//        cmd.ExecuteNonQuery();
//        conn.Close();

//    }
//    using (SqlCommand cmd2 = conn.CreateCommand()) 
//    {
//        cmd2.CommandText = "AddStudent";
//        cmd2.CommandType = CommandType.StoredProcedure;
//        cmd2.Parameters.AddWithValue("firstname", "Emilie");
//        cmd2.Parameters.AddWithValue("lastname", "Henreaux");
//        cmd2.Parameters.AddWithValue("sectionID", 1010);
//        cmd2.Parameters.AddWithValue("yearResult", 2);
//        cmd2.Parameters.AddWithValue("birthdate", new DateTime(1996, 2, 1));
//        conn.Open();
//        cmd2.ExecuteNonQuery();
//        conn.Close();
//    }
//};
#endregion

using (SqlConnection conn2 = new SqlConnection(connectionString))
{
    using (SqlCommand cmd = conn2.CreateCommand())
    {
        cmd.CommandText = "UpdateStudent";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("sectionId", 1020);
        cmd.Parameters.AddWithValue("yearResult", 18);
        cmd.Parameters.AddWithValue("studentId", 26);
        conn2.Open();
        cmd.ExecuteNonQuery();
        conn2.Close();
    }
}


using (SqlConnection conn3 = new SqlConnection(connectionString))
{
    using (SqlCommand cmd2 = conn3.CreateCommand())
    {
        cmd2.CommandText = "DeleteStudent";
        cmd2.CommandType = CommandType.StoredProcedure;
        cmd2.Parameters.AddWithValue("id", 27);
        conn3.Open();
        cmd2.ExecuteNonQuery();
        conn3.Close();

    }
}
