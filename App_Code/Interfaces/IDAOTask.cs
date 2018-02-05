using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IDAOTask
/// </summary>
public interface IDAOTask
{
   void saveTask(Task task);
   void updateTask(Task task);
   void deleteTask(String taskID);
}