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

        public QueryResultsPopup(LLDatabase DB)
        {
            InitializeComponent();
            db = DB;
        }

        public void showData(SqlDataAdapter sda)
        {
            DataTable t = new DataTable();
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

    }
}
