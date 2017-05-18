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
using System.IO;

namespace LendingLibrary.Database
{
    public class LLDatabase
    {
        //  COMPUTER SPECIFIC CONSTANTS
        String server = "Server=CODY-PC\\LENDLIBRARY";
        String ssis = "Integrated security=SSPI";
        String dbname = "Inventory";

        //  Stored Variables
        private SqlConnection conn;

        //  Constructors
        public LLDatabase()
        {
        }

        /*  init() either opens a database or creates one at filepath
         *  Returns:
         *      1, if Database exists and is loaded correctly
         *      0, if successfully Creates a Database
         *     -1, if the database is not successfully populated
         *     -2, if the items table is no successfully created
         */
        public int init()
        {
            conn = new SqlConnection(server + ";" + ssis + ";database=master");

            bool fileExist = File.Exists("C:\\"+dbname+"Data.mdf");
            int rtn = 0;

            if (!fileExist)
            {
                //  Attempt to create Database
                if (createDatabase(dbname) < 0) return -1;
                conn = new SqlConnection(server + ";" + ssis + ";database="+dbname);

                //  Attempt to create Table within Database
                rtn = createItemsTable();
                if (rtn < 0) return -2;
            }
            else
            {
                conn = new SqlConnection(server + ";" + ssis + ";database="+dbname);


                rtn = 1;
            }

            return rtn;
        }

        //
        //      DATABASE OPERATIONS
        //

        /*  createDatabase() creates a new ItemsData file
         *  Returns:
         *      0, if successful
         */
        private int createDatabase(String DBname)
        {
            //  Define the Database Creation String
            String commStr = "CREATE DATABASE "+DBname+" ON PRIMARY " +
                "(NAME = "+DBname+"_Data,FILENAME = 'C:\\"+DBname+"Data.mdf',"+
                "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                "LOG ON (NAME = "+DBname+"_Log, FILENAME = 'C:\\"+DBname+
                "Log.ldf', SIZE = 1MB, MAXSIZE = 5MB, FILEGROWTH = 10%)";

            //  Create the Database
            return performCommand(commStr);
        }

        private int deleteDatabase(String DBname)
        {
            //  Define the Command String
            String commStr = "DROP DATABASE " + DBname;

            //  Delete the Database
            return performCommand(commStr);
        }

        //
        //      TABLE OPERATIONS
        //

        /*  createItemsTable() creates a new Table within the database
         *      NOTE:  Intentionally left ungeneralized
         *      
         *  Returns:
         *      0, if successful
         *     -1, if the Items table is not created
         */
        private int createItemsTable()
        {
            String commStr = "CREATE TABLE dbo.Items " +
                "(ITEM_ID int IDENTITY(1,1) PRIMARY KEY NOT NULL," +
                "ITEM_NAME varchar(50) NOT NULL," +
                "ITEM_LENDEE varchar(50) NOT NULL," +
                "ITEM_DATE_LEND date NOT NULL," +
                "ITEM_DATE_RETURN date," +
                "ITEM_DESCRIPTION varchar(255)," +
                "ITEM_INCLUDE_IN_AVG bit NOT NULL," +
                "ITEM_IS_DELETED bit NOT NULL)";

            return performCommand(commStr);
        }

        /*  insertToItems() adds an entry into the Items Table
         * 
         *  Returns:
         *      0, if Successful
         *     -1, if the Item is not added
         */
        public int insertToItems(String name, String lendee, DateTime lend, String descript, Boolean avg)
        {
            String commStr = "INSERT INTO dbo.Items (ITEM_NAME,ITEM_LENDEE," +
                "ITEM_DATE_LEND,ITEM_DESCRIPTION,ITEM_INCLUDE_IN_AVG," +
                "ITEM_IS_DELETED) VALUES (@name, @lendee, @lenddate, @descript, @avg, @del)";
            SqlCommand c = new SqlCommand(commStr, conn);

            c.Parameters.AddWithValue("@name", name);
            c.Parameters.AddWithValue("@lendee", lendee);
            c.Parameters.AddWithValue("@lenddate", lend);
            c.Parameters.AddWithValue("@descript", descript);
            c.Parameters.AddWithValue("@avg", avg);
            c.Parameters.AddWithValue("@del", false);

            try
            {
                //  Open Connection
                conn.Open();
                c.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "LendingLibrary", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return -1;
            }

            //  Close the Connection if it is open
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();

            return 0;
        }

        /*  deleteItem() updates isDeleted to be true for item, primKey
         *  
         *      Returns:
         *          0, if successful
         *         -1, if item is not soft deleted
         */     
        public int deleteItem(int primKey)
        {
            String commStr = String.Format("UPDATE " + dbname + " SET ITEM_IS_DELETED = 1 " +
                "WHERE ITEM_ID = {0}", primKey);

            return performCommand(commStr);
        }

        /*  
         *  queryLendee() returns a data adapter for filling a data table with one lendee
         *      NOTE:  NEED TO CLOSE CONNECTION AFTER USING THIS
         */
        public SqlDataAdapter query(String lendee)
        {
            conn.Open();
            String commStr = "SELECT ITEM_LENDEE, ITEM_NAME, ITEM_DESCRIPTION, "+
                "ITEM_DATE_LEND, ITEM_DATE_RETURN, ITEM_INCLUDE_IN_AVG "+
                "FROM Items WHERE ITEM_LENDEE='" + lendee + "' AND " +
                "ITEM_IS_DELETED=0";

            return new SqlDataAdapter(commStr, conn);
            //  NOTE:  NEED TO CLOSE THE CONNECTION AFTER USING THIS FUNCTION!!
        }

        /*
         *  queryAll() returns a data adapter for filling a data table with all data
         *      NOTE:  NEED TO CLOSE CONNECTION AFTER USING THIS
         */
        public SqlDataAdapter query()
        {
            conn.Open();
            String commStr = "SELECT ITEM_LENDEE, ITEM_NAME, ITEM_DESCRIPTION, " +
                "ITEM_DATE_LEND, ITEM_DATE_RETURN, ITEM_INCLUDE_IN_AVG FROM Items " +
                "WHERE ITEM_IS_DELETED=0";

            return new SqlDataAdapter(commStr, conn);
            //  NOTE:  NEED TO CLOSE THE CONNECTION AFTER USING THIS FUNCTION!!
        }

        //
        //  Helper Functions
        //

        /*
         *  Opens the connection to the server
         *      Use with caution, annotate heavily, and always close the connection
         */
        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
        }

        /*
         *  Closes the connection to the server
         *      Use with caution and annotate heavily
         */
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();
        }

        /*  performCommand() executes a command on a given 
         *  Returns:
         *      0, if successful
         *     -1, if unsuccessful
         */
        private int performCommand(string commStr)
        {
            SqlCommand c = new SqlCommand(commStr, conn);
            try
            {
                //  Open the Connection
                conn.Open();
                c.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "LendingLibrary", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return -1;
            }

            //  Close the Connection if it is open
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();

            return 0;
        }
    }
}
