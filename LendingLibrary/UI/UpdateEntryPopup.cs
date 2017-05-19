/*
 *  updateEntryPopup.cs
 *  Cody Fagley
 *  Authored May 18, 2017
 */

/*
 *  A Popup for updating an entry in the database
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

namespace LendingLibrary.UI
{
    public partial class UpdateEntryPopup : Form
    {
        LLDatabase db;
        int key;

        //  Constructor
        public UpdateEntryPopup(LLDatabase DB, int Key)
        {
            InitializeComponent();
            db = DB;
            key = Key;
        }

        //  Sets the current data to match the data in the table
        public void init(String name, String lendee, DateTime lend, DateTime returned,
            String description)
        {
            itemNameText.Text = name;
            itemLendeeText.Text = lendee;
            dateLendPicker.Value = lend;
            dateReturnPicker.Value = returned;
            itemDescriptionText.Text = description;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            db.fullUpdate(key, itemNameText.Text, itemLendeeText.Text, dateLendPicker.Value,
                dateReturnPicker.Value, itemDescriptionText.Text);
            Close();
        }
    }
}
