/*
 *  Program.cs
 *  Cody Fagley
 *  Authored May 15, 2017
 */

/*
 *  This file contains the Main() function for the Lending Library project.  
 *  
 *  NOTE:  If something doesn't have to be in here, it probably shouldn't be
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LendingLibrary.Database;

namespace LendingLibrary
{
    static class Program
    {
        /*  LendingLibrary Return Codes:
         *      0, if program exits successfully
         *     -1, if the database is not created correctly
         *     -2, if the table is not created correctly
         */
        [STAThread]
        static int Main()
        {
            //  Before opening the program, Layout the database and table
            LLDatabase data = new LLDatabase();
            int rtn = data.init();
            if (rtn < 0) return rtn;

            //  Create a Main Menu Window
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProgMenu(data));

            //  Exit Program
            return 0;
        }
    }
}
