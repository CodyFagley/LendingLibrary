﻿/*
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
using LendingLibrary.UI;
using System.Data.SqlClient;

namespace LendingLibrary
{
    public partial class ProgMenu : Form
    {
        LLDatabase db;

        //  Constructors
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

        //  Creates an instance of QueryResultsPopup
        private void queryEntriesButton_Click(object sender, EventArgs e)
        {
            QueryResultsPopup qrp = new QueryResultsPopup(db);
            SqlDataAdapter sda = db.query();

            qrp.showData(sda);
            qrp.ShowDialog();

            sda.Dispose();
            db.closeConnection();
        }

        //  Creates a List of items that are checked out by a lendee
        private void queryLendeeButton_Click(object sender, EventArgs e)
        {
            QueryResultsPopup qrp = new QueryResultsPopup(db);
            SqlDataAdapter sda = db.query(lendeeQueryText.Text);

            qrp.showData(sda);
            qrp.ShowDialog();

            sda.Dispose();
            db.closeConnection();
        }
    }
}
