/*
 *  ReturnEntryPopup.cs
 *  Cody Fagley
 *  Authored on May 18, 2017
 */

/*
 *  An entry should be "returned" in the database
 *  when the object has been physically returned.
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
    public partial class ReturnEntryPopup : Form
    {
        //  Current Entry Key Number
        int primKey;
        LLDatabase db;

        public ReturnEntryPopup(int key, LLDatabase DB)
        {
            InitializeComponent();
            primKey = key;
            db = DB;
        }

        //  Update current Entry, then close the dialog
        private void returnEntryButton_Click(object sender, EventArgs e)
        {
            
            db.returnItem(primKey, returnPicker.Value);
            Close();
        }
        
       

        //  Discard current entry and close the dialog
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
