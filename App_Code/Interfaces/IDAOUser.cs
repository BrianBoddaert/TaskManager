using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IDAOUser
/// </summary>
public interface IDAOUser
{
    void saveUser(User user);
    void updateUser(User user);
    void deleteUser(String userID);
}