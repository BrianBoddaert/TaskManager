using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Subject
/// </summary>
public class Subject
{
    String subjectID;
    String name;
    String color;
    public Subject()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Name { get => name; set => name = value; }
    public string SubjectID { get => subjectID; set => subjectID = value; }
    public string Color { get => color; set => color = value; }
}