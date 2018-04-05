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
    public String getSubjectName(int id) {
        //CONNECT TO DB
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    private Subject getSubject(int id)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

=======
>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414
        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

<<<<<<< HEAD
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

=======
    protected void addTask(Object sender, EventArgs e)
    {
         
>>>>>>> parent of 8314b20... Ediit task
=======
    protected void addTask(Object sender, EventArgs e)
    {
         
>>>>>>> parent of 8314b20... Ediit task
    }
=======
        //CREATE A COMMAND
        querStr = "SELECT * FROM subjects WHERE id = '" + id + "'";
        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);
>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414

        //READ FROM DB
        MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
        Subject s = new Subject();
        while (reader.Read())
        {
            s.Name = reader["name"].ToString();
        }

        conn.Close();
        return s.Name;
    }
    public void getAllTasks()
    {
        //CONNECT TO DB
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

        //CREATE A COMMAND
        querStr = "SELECT * FROM tasks";
        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        

        //READ FROM DB
        MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Task t = new Task();
            t.name = reader["name"].ToString();
            t.description = reader["description"].ToString();
            t.urgency = reader["urgency"].ToString();
<<<<<<< HEAD
<<<<<<< HEAD
            t.taskType = reader["type"].ToString();
<<<<<<< HEAD
            t.taskID = Convert.ToInt32(reader["id"].ToString());
=======
=======
>>>>>>> parent of 8314b20... Ediit task
            //name += reader["name"].ToString();
            //temp += reader["deadline"].ToString();
            //desc += reader["description"].ToString();
            // urg += reader["urgency"].ToString();
<<<<<<< HEAD
>>>>>>> parent of 8314b20... Ediit task

=======
            t.subject.Name = getSubjectName(Int32.Parse(reader["subject_id"].ToString()));
>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414
=======

>>>>>>> parent of 8314b20... Ediit task
            allTasks.Add(t);
        }

        conn.Close();

    }

}