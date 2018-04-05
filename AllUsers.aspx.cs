using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AllUsers : System.Web.UI.Page
{
    MySql.Data.MySqlClient.MySqlConnection conn;
    MySql.Data.MySqlClient.MySqlCommand cmd;
    string querStr;

    public List<User> allUsers = new List<User>();

    protected void Page_Load(object sender, EventArgs e)
    {
        getAllUsers();

    }

    private void getAllUsers() {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

        querStr = "SELECT * FROM users";

        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        //READ FROM DB
        MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

        allUsers.Clear();

        while (reader.Read())
        {
            User u = new User();
            u.Username = reader["username"].ToString();
            u.UserID = Convert.ToInt32(reader["id"].ToString()); 

            allUsers.Add(u);
        }

        conn.Close();
    }
}