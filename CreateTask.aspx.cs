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
<<<<<<< HEAD
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
=======
>>>>>>> parent of 8314b20... Ediit task

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

        querStr = "INSERT INTO taskmanager.tasks (name, subject_id, assignee_id, deadline, description, urgency)" +
            "VALUES('" + nameTextBox.Text + "','" + 1 + "', '" + 1 + "','" + deadlineDate.Value + "','" + desTestBox.Text + "','" + urgencyList.SelectedIndex.ToString() + "')";

        cmd = new MySql.Data.MySqlClient.MySqlCommand(querStr, conn);

        cmd.ExecuteReader();

        conn.Close();

    }
}