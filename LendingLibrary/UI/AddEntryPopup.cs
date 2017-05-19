/*
 *  AddEntryPopup.cs
 *  Cody Fagley
 *  Authored on May 15, 2017
 */

/*
 *  Popup Dialog for adding a new loaned item to the database
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
    public partial class AddEntryPopup : Form
    {
        private LLDatabase db;

        //  Constructor
        public AddEntryPopup(LLDatabase DB)
        {
            InitializeComponent();
            db = DB;
        }

        //  Discard the current entry and close the window
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //  Add the current entry, then close the window
        private void addEntryButton_Click(object sender, EventArgs e)
        {
            //  TODO:  Add the current entry
            int rtn = db.insertToItems(itemNameText.Text, itemLendeeText.Text, 
                itemDatePicker.Value, itemDescriptionText.Text);

            if (rtn < 0) MessageBox.Show("Entry could not be Added");

            Close();
        }
    }
}
