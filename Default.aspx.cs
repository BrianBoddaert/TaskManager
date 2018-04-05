using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    public List<Task> allTasks = new List<Task>();
    MySql.Data.MySqlClient.MySqlConnection conn;
    MySql.Data.MySqlClient.MySqlCommand cmd;
    string querStr;

    protected void Page_Load(object sender, EventArgs e)
    {
        allTasks.Clear();
        getAllTasks();
    }

    private Subject getSubject(int id)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

        querStr = "SELECT * FROM subjects WHERE id = '" + id + "'";

        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        //READ FROM DB
        MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

        Subject tempSubject = new Subject();

        while (reader.Read())
        {

            tempSubject.Name = reader["name"].ToString();
            tempSubject.SubjectID = Convert.ToInt32(reader["id"].ToString());
            tempSubject.Color = reader["color"].ToString();
        }

        conn.Close();

        return tempSubject;

    }

    public void getAllTasks()
    {
        //CONNECT TO DB
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

        //CREATE A COMMAND
        querStr = "SELECT * FROM tasks WHERE assignee_id = '" + LoggedInUser.currentUser.UserID + "'";
        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        //READ FROM DB
        MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Task t = new Task();
            t.name = reader["name"].ToString();
            t.description = reader["description"].ToString();
            Console.WriteLine("OKEEEE " + Convert.ToInt32(reader["subject_id"].ToString()));
            t.subject = getSubject(Convert.ToInt32(reader["subject_id"].ToString()));
            t.urgency = reader["urgency"].ToString();
            t.taskType = reader["type"].ToString();
            t.taskID = Convert.ToInt32(reader["id"].ToString());

            allTasks.Add(t);
        }

        conn.Close();

    }

    protected void btnRedirect_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("lol");
        Response.Redirect("EdditTask.aspx");
    }

}