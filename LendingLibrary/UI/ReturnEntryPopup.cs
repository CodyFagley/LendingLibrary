using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LendingLibrary
{
    public partial class ReturnEntryPopup : Form
    {
        //  Current Entry Key Number
        int primKey;

        public ReturnEntryPopup(int key)
        {
            InitializeComponent();
            primKey = key;
        }

        //  Update current Entry, then close the dialog
        private void returnEntryButton_Click(object sender, EventArgs e)
        {
            
            //  TODO:  If it exists, remove the current entry
            Close();
        }
        
       

        //  Discard current entry and close the dialog
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }




        
    }
}
