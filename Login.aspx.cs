using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateTask : System.Web.UI.Page
{

    MySql.Data.MySqlClient.MySqlConnection conn;
    MySql.Data.MySqlClient.MySqlCommand cmd;
    string querStr;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void addTask(object sender, EventArgs e)
    {

    }

    protected void logout(object sender, EventArgs e)
    {
        LoggedInUser.currentUser = new User();
        LoggedInUser.currentUser.isLoggedIn = false;
        loginwarning.Text = "logged out!";
    }

    protected void login(object sender, EventArgs e)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

        querStr = "SELECT * FROM users WHERE username = '" + username.Text + "'";

        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

        string p = "";
        while (reader.Read())
        {
            p = reader["password"].ToString();

            if (p.Equals(password.Text))
            {
                string uID = "";
                uID = reader["id"].ToString();
                LoggedInUser.currentUser.Username = username.Text;
                LoggedInUser.currentUser.Password = p.ToString();
                LoggedInUser.currentUser.UserID = Int32.Parse(uID);
                LoggedInUser.currentUser.isLoggedIn = true;
                loginwarning.Text = "Succesfully logged in, welcome " + LoggedInUser.currentUser.UserID + ".";
            }
            else
            {
                loginwarning.Text = "Login failed!";
                LoggedInUser.currentUser.isLoggedIn = false;
            }
        }

        conn.Close();
    }

    protected void register(object sender, EventArgs e)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

        querStr = "INSERT INTO taskmanager.users (username, password)" +
            "VALUES('" + username_register.Text + "','" + password_register.Text + "')";

        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        cmd.ExecuteReader();

        conn.Close();

        loginwarning.Text = "Succesfully registered, welcome " + username_register.Text + "!";
    }

}