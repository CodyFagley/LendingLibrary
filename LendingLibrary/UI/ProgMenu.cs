/*
 *  ProgMenu.cs
 *  Cody Fagley
 *  Authored on May 15, 2017
 */

/*
 *  The Main Application window for the Lending Library project
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LendingLibrary.Database;

namespace LendingLibrary
{
    public partial class ProgMenu : Form
    {
        LLDatabase db;

        public ProgMenu(LLDatabase DB)
        {
            InitializeComponent();
            db = DB;
        }

        //  Creates an instance of AddEntryPopup
        private void addEntryButton_Click(object sender, EventArgs e)
        {
            AddEntryPopup aep = new AddEntryPopup(db);
            aep.ShowDialog();
        }


    }
}
