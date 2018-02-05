using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IDAOSubject
/// </summary>
public interface IDAOSubject
{
    void saveSubject(Subject subject);
    void updateSubject(Subject subject);
    void deleteSubject(String subjectID);
}