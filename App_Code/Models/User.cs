using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
<<<<<<< HEAD
<<<<<<< HEAD

    public int userID;
    String username;
    String password;
    public bool isLoggedIn;
    public int orderInList;

=======
    String userID;
    String username;
    String password;
>>>>>>> parent of 8314b20... Ediit task
=======
    String userID;
    String username;
    String password;
>>>>>>> parent of 8314b20... Ediit task
    public User()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Password { get => password; set => password = value; }
    public string Username { get => username; set => username = value; }
    public string UserID { get => userID; set => userID = value; }
}