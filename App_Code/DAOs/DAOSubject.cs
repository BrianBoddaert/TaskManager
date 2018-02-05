using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAOSubject
/// </summary>
public class DAOSubject : IDAOSubject
{
    List<Subject> allSubjects;
    public void deleteSubject(string subjectID)
    {
        foreach (Subject s in allSubjects)
        {
            if (s.SubjectID.Equals(subjectID))
            {
                allSubjects.Remove(s);
            }
        }
    }

    public void saveSubject(Subject subject)
    {
        allSubjects.Add(subject);
    }

    public void updateSubject(Subject subject)
    {
        foreach (Subject s in allSubjects)
        {
            if (s.SubjectID.Equals(subject.SubjectID))
            {
                s.Name = subject.Name;
                s.Color = subject.Color;
            }
        }
    }
}