using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Task
/// </summary>
public class Task
{
    public String name;
<<<<<<< HEAD
    public int taskID;
    public Subject subject;
=======
    public String taskID;
    public Subject subject = new Subject();
>>>>>>> 0e76954a1bead33234fa79f8b5c8b72285a07414
    public int assignees;
    public DateTime deadline;
    public String description;
    public String urgency;
    public String taskType;

    public Task()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Name { get => name; set => name = value; }
    public int TaskID { get => taskID; set => taskID = value; }
    public Subject Subject { get => subject; set => subject = value; }
    public int Assignees { get => assignees; set => assignees = value; }
    public DateTime Deadline { get => deadline; set => deadline = value; }
    public string Description { get => description; set => description = value; }
    public string Urgency { get => urgency; set => urgency = value; }
}