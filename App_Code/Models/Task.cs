﻿using System;
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
}