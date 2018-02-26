﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Task
/// </summary>
public class Task
{
    public String name;
    public String taskID;
    public Subject subject;
    public List<User> assignees;
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
    public string TaskID { get => taskID; set => taskID = value; }
    public Subject Subject { get => subject; set => subject = value; }
    public List<User> Assignees { get => assignees; set => assignees = value; }
    public DateTime Deadline { get => deadline; set => deadline = value; }
    public string Description { get => description; set => description = value; }
    public string Urgency { get => urgency; set => urgency = value; }
    public string TaskType { get => taskType; set => taskType = value; }
}