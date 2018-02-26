using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for Program
/// </summary>
static class Program
{

    public static void Main(string[] args)
    {

        Console.Write("Main function!");

        string connectString = "datasource = localhost; username = root; password=; database = taskmanager";
        MySqlConnection DBConnect = new MySqlConnection(connectString);
        try
        {
            DBConnect.Open();
            Console.Write("Connected! :)");

        }
        catch (Exception e)
        {
            Console.Write("Not Connected! :(");
        }
    }

}