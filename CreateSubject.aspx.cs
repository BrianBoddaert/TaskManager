using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateSubject : System.Web.UI.Page
{

    MySql.Data.MySqlClient.MySqlConnection conn;
    MySql.Data.MySqlClient.MySqlCommand cmd;
    string querStr;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void addSubject(object sender, EventArgs e)
    {
        connect();
    }

    public void connect()
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

        querStr = "INSERT INTO taskmanager.subjects (name, color)" +
             "VALUES('" + subjectName.Text + "','" + subjectColor.SelectedIndex.ToString() + "')";

        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        cmd.ExecuteReader();

        conn.Close();

    }
}