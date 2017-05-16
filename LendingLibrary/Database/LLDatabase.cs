/*
 *  Database.cs
 *  Cody Fagley
 *  Authored on May 16, 2017
 */

/*
 *  Handles the initialization of a Database according to a static filepath
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LendingLibrary.Database
{
    class LLDatabase
    {
        private SqlConnection conn;
        private string filepath;

        //  Constructors
        public LLDatabase()
        {

        }

        /*  init() either opens a database or creates one at filepath
         *  Returns:
         *      0, if successful
         *     -1, if the database is not successfully populated
         */
        public int init()
        {
            //  Create a connection to a localhost server
            conn = new SqlConnection("Server=CODY-PC\\LENDLIBRARY;Integrated security=SSPI;database=master");

            //  Define the Database Creation String
            String commStr = "CREATE DATABASE Inventory ON PRIMARY " +
                "(NAME = Items_Data, FILENAME = 'C:\\ItemsData.mdf', " +
                "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                "LOG ON (NAME = Items_Log, FILENAME = 'C:\\ItemsLog.ldf', " +
                "SIZE = 1MB, MAXSIZE = 5MB, FILEGROWTH = 10%)";

            //  Create the Database
            int rtn = performCommand(commStr);

            return rtn;
        }


        /*  performCommand() executes a command on a given connection
         *  Returns:
         *      0, if successful
         *     -1, if connection doesn't open
         */
        private int performCommand(string commStr)
        {
            SqlCommand c = new SqlCommand(commStr, conn);
            try
            {
                //  Open the Connection
                conn.Open();
                c.ExecuteNonQuery();
            } catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return -1;
            }

            //  Close the Connection if it is open
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            
            return 0;
        }
    }
}
