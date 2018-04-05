using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{

    public int userID;
    String username;
    String password;
    public bool isLoggedIn;
    public int orderInList;

    public User()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Password { get => password; set => password = value; }
    public string Username { get => username; set => username = value; }
    public int UserID { get => userID; set => userID = value; }
}