/*
 *  QueryResultsPopup.cs
 *  Cody Fagley
 *  Authored on May 18, 2017
 */

/*
 *  Dialog Window containing the results of a query
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
using System.Data.SqlClient;

namespace LendingLibrary.UI
{
    public partial class QueryResultsPopup : Form
    {
        LLDatabase db;
        DataTable t;

        //  Constructor
        public QueryResultsPopup(LLDatabase DB)
        {
            InitializeComponent();
            db = DB;
            t = new DataTable();
            queryDataViewer.MultiSelect = false;
        }

        /*
         *  showData() populates the docked gridviewer with table data
         */
        public void showData(SqlDataAdapter sda)
        {
            try
            {
                sda.Fill(t);
                
                queryDataViewer.DataSource = t;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "LendingLibrary", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /*  
         *  Creates Return Entry window for the selected entry
         */
        private void returnEntryButton_Click(object sender, EventArgs e)
        {
            //  Get selected row in dataviewer and retrieve primary key value
            int row = queryDataViewer.SelectedRows[0].Index;
            int key = t.Rows[row].Field<int>(0);
            //MessageBox.Show(key.ToString());

            ReturnEntryPopup rep = new ReturnEntryPopup(key, db);
            rep.Text = t.Rows[row].Field<string>(2);
            rep.ShowDialog();
            Close();
        }

        /*
         *  Creates Delete Entry Window for the Selected Entry
         */
        private void deleteEntryButton_Click(object sender, EventArgs e)
        {
            //  Get selected row in dataviewer and retrieve primary key value
            int row = queryDataViewer.SelectedRows[0].Index;
            int key = t.Rows[row].Field<int>(0);
            //MessageBox.Show(key.ToString());

            db.deleteItem(key);
            Close();
        }

        /*
         *  Creates Update Entry Window for the Selected Entry
         */
        private void updateEntryButton_Click(object sender, EventArgs e)
        {
            //  Get selected row in dataviewer and retrieve primary key value
            int row = queryDataViewer.SelectedRows[0].Index;
            int key = t.Rows[row].Field<int>(0);
            //MessageBox.Show(key.ToString());
            UpdateEntryPopup uep = new UpdateEntryPopup(db, key);

            //  Existing Fields
            String iname = t.Rows[row].Field<String>(2);
            String ilendee = t.Rows[row].Field<String>(1);
            String idescript = t.Rows[row].Field<String>(3);
            DateTime ilend = t.Rows[row].Field<DateTime>(4);
            DateTime ireturn;
            if (t.Rows[row].IsNull(5))
            {
                uep.init(iname, ilendee, ilend, idescript);
            }
            else
            {
                ireturn = t.Rows[row].Field<DateTime>(5);

                //  Populate Form
                uep.init(iname, ilendee, ilend, ireturn, idescript);
            }

            uep.ShowDialog();
            Close();
        }

    }
}
