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

    public List<User> allUsers = new List<User>();
    public List<Subject> allSubjects = new List<Subject>();

    protected void Page_Load(object sender, EventArgs e)
    {
        getAllUsers();

        int order1 = 0;
        foreach (User u in allUsers)
        {
            u.orderInList = order1;
            order1++;
        }
       foreach(User u in allUsers)
        {

            assigneeDropList.Items.Add(new ListItem(u.Username, u.UserID.ToString()));
        }

        getAllSubjects();

        int order = 0;
        foreach (Subject s in allSubjects)
        {
            s.orderInList = order;
            order++;

        }
        foreach (Subject s in allSubjects)
        {
            subjectDropList.Items.Add(new ListItem(s.Name, s.SubjectID.ToString()));
        }

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

    private void getAllSubjects()
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

        querStr = "SELECT * FROM subjects";

        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        //READ FROM DB
        MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

        allSubjects.Clear();

        while (reader.Read())
        {
            Subject s = new Subject();
            s.Name = reader["name"].ToString();
            s.SubjectID = Convert.ToInt32(reader["id"].ToString());

            allSubjects.Add(s);
        }

        conn.Close();
    }

    protected void addTask(object sender, EventArgs e)
    {
        connect();
    }

    public void connect()
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

        querStr = "INSERT INTO taskmanager.tasks (name, subject_id, assignee_id, deadline, description, urgency, type)" +
             "VALUES('" + nameTextBox.Text + "','" + subjectDropList.SelectedValue.ToString() + "', '" + assigneeDropList.SelectedValue.ToString() + "','" + deadlineDate.Value + "','" + desTestBox.Text + "','" + urgencyList.SelectedIndex.ToString() + "','" + typeList.SelectedIndex.ToString() + "')";

        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        cmd.ExecuteReader();

        conn.Close();

    }
}