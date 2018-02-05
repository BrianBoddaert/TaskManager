using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Task
/// </summary>
public class Task
{
    String name;
    String taskID;
    Subject subject;
    List<User> assignees;
    DateTime deadline;
    String description;


    public Task()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Name { get => name; set => name = value; }
    public string TaskID { get => taskID; set => taskID = value; }
    public Subject Subject { get => subject; set => subject = value; }
    public List<User> Assignees { get => assignees; set => assignees = value; }
    public DateTime Deadline { get => deadline; set => deadline = value; }
    public string Description { get => description; set => description = value; }
}