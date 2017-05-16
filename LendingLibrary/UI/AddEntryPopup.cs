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
using System.Data.SqlClient;

namespace LendingLibrary
{
    public partial class AddEntryPopup : Form
    {
        //  Constructor
        public AddEntryPopup()
        {
            InitializeComponent();
        }

        //  Discard the current entry and close the window
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //  Add the current entry, then close the window
        private void addEntryButton_Click(object sender, EventArgs e)
        {
            //  Create a connection to the local database
            SqlConnection c = new SqlConnection();
            c.ConnectionString = Properties.Settings.Default.LoanedItemsConnectionString;
            try
            {
                c.Open();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }

            SqlCommand comm = new SqlCommand();
            comm.Connection = c;

            //  Prepare Strings as System Strings
            if (itemAverageCheckbox.Checked)
            {
                comm.CommandText = "INSERT INTO Items (ITEM_NAME, ITEM_LENDEE," +
                    "ITEM_DATE_LEND, ITEM_DESCRIPTION, ITEM_INCLUDE_IN_AVG) " +
                    "VALUES ('" + itemNameText.Text + "', '" +
                    itemLendeeText.Text + "', @datelend, '" +
                    itemDescriptionText.Text + "', 1)";
                comm.Parameters.AddWithValue("@datelend", itemDatePicker.Value);
            }
            else
            {
                comm.CommandText = "INSERT INTO Items (ITEM_NAME, ITEM_LENDEE," +
                    "ITEM_DATE_LEND, ITEM_DESCRIPTION, ITEM_INCLUDE_IN_AVG) " +
                    "VALUES ('" + itemNameText.Text + "', '" +
                    itemLendeeText.Text + "', @datelend, '" +
                    itemDescriptionText.Text + "', 0)";
                comm.Parameters.AddWithValue("@datelend", itemDatePicker.Value);
            }

            int rtn = comm.ExecuteNonQuery();
            if (rtn == 0)
            {
                //  Add Appropriate Error Message
            }


            //  Close the connection to the database and exit dialog
            c.Close();
            Close();
        }
    }
}
