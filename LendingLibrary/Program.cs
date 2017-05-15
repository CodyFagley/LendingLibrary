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

namespace LendingLibrary
{
    static class Program
    {
        /*  LendingLibrary Return Codes:
         *      0, if program exits successfully
         */
        [STAThread]
        static int Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProgMenu());

            return 0;
        }
    }
}
