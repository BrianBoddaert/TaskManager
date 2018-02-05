using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAOUser
/// </summary>
public class DAOUser : IDAOUser
{
    List<User> allUsers;
    public void deleteUser(string userID)
    {
        foreach (User u in allUsers)
        {
            if (u.UserID.Equals(userID))
            {
                allUsers.Remove(u);
            }
        }
    }

    public void saveUser(User user)
    {
        allUsers.Add(user);
    }

    public void updateUser(User user)
    {
        foreach (User u in allUsers)
        {
            if (u.UserID.Equals(user.UserID))
            {
                u.Username = user.Username;
                u.Password = user.Password;
            }
        }
    }
}