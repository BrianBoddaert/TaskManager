using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EdditTask : System.Web.UI.Page
{

    MySql.Data.MySqlClient.MySqlConnection conn;
    MySql.Data.MySqlClient.MySqlCommand cmd;
    string querStr;

    public int finalCurrentTaskID;

    public int currentTaskID
    {
        get;
        set;
    }

    public Task currentTask = new Task();

    public List<User> allUsers = new List<User>();
    public List<Subject> allSubjects = new List<Subject>();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        finalCurrentTaskID = Convert.ToInt32(Request.QueryString["currentTaskID"]);

        currentTask = getCurrentTask();

        getAllUsers();
        foreach(User u in allUsers)
        {
            assigneeDropList.Items.Add(new ListItem(u.Username, u.UserID.ToString()));
        }

        getAllSubjects();
        foreach (Subject s in allSubjects)
        {
            subjectDropList.Items.Add(new ListItem(s.Name, s.SubjectID.ToString()));
        }

        nameTextBox.Text = currentTask.name;
        subjectDropList.SelectedIndex = currentTask.subject.orderInList; // hier
        assigneeDropList.SelectedIndex = getUser(currentTask.assignees).orderInList;
        desTestBox.Text = currentTask.description;
        urgencyList.SelectedIndex = Convert.ToInt32(currentTask.urgency); 
        typeList.SelectedIndex = Convert.ToInt32(currentTask.taskType);

    }

    private User getUser(int id)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

        querStr = "SELECT * FROM users WHERE id = '" + id + "'";

        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        //READ FROM DB
        MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

        User tempUser = new User();

        while (reader.Read())
        {

            tempUser.Username = reader["username"].ToString();
            tempUser.UserID = Convert.ToInt32(reader["id"].ToString());
        }

        conn.Close();

        return tempUser;

    }

    private Subject getSubject(int id) {
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

    private Task getCurrentTask()
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

        querStr = "SELECT * FROM tasks WHERE id = '" + finalCurrentTaskID + "'";

        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        //READ FROM DB
        MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

        Task tempTask = new Task();

        while (reader.Read())
        {
            tempTask.name = reader["name"].ToString();
            tempTask.subject = getSubject(Convert.ToInt32(reader["subject_id"].ToString()));
            tempTask.TaskID = Convert.ToInt32(reader["id"].ToString());
            tempTask.assignees = Convert.ToInt32(reader["assignee_id"].ToString());
            tempTask.description = reader["description"].ToString();
            tempTask.urgency = reader["urgency"].ToString();
            tempTask.taskType = reader["type"].ToString();
        }

        conn.Close();

        return tempTask;

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

    public void editTask(object sender, EventArgs e)
    {
        connect();
    }

    public void connect()
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

        conn.Open();

        querStr = "";

        //SET CURRENT TASK
        currentTask.name = nameTextBox.Text;
        currentTask.subject.SubjectID = Convert.ToInt32(subjectDropList.SelectedValue);
        currentTask.assignees = Convert.ToInt32(assigneeDropList.SelectedValue);
        currentTask.description = desTestBox.Text;
        currentTask.urgency = urgencyList.SelectedIndex.ToString();
        currentTask.taskType = typeList.SelectedIndex.ToString();

        querStr = "UPDATE taskmanager.tasks(name, subject_id, assignee_id, deadline, description, urgency, type)" +
             "VALUES('" + currentTask.name + "','" + currentTask.subject.SubjectID + "', '" + currentTask.assignees + "','" + currentTask.deadline.ToString() + "','" + currentTask.description + "','" + currentTask.urgency + "','" + currentTask.taskType + "')";

        //querStr = "UPDATE taskmanager.tasks SET name='" + currentTask.name + "', subject_id='" + currentTask.subject.SubjectID + "', assignee_id='" + currentTask.assignees + "', deadline='" + currentTask.deadline.ToString() + "', description='" + currentTask.description + "', urgency='" + currentTask.urgency + "', type='" + currentTask.taskType + "'";

        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        cmd.ExecuteReader();

        conn.Close();

        Response.Redirect("http://localhost:59252/");

    }



}