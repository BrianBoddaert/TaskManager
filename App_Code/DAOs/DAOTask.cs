using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAOTask
/// </summary>
public class DAOTask : IDAOTask
{
    List<Task> allTasks;
    public void deleteTask(String taskID)
    {
        foreach (Task tt in allTasks)
        {
            if (tt.TaskID.Equals(taskID))
            {
                allTasks.Remove(tt);
            }
        }
    }

    public void saveTask(Task task)
    {
        allTasks.Add(task);
    }


    public void updateTask(Task task)
    {
        foreach (Task tt in allTasks)
        {
            if (tt.TaskID.Equals(task.TaskID))
            {
                tt.Name = task.Name;
                tt.Assignees = task.Assignees;
                tt.Description = task.Description;
                tt.Deadline = task.Deadline;
                tt.Subject = task.Subject;
            }
        }
    }


}