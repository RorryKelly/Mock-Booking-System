using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssOneForm
{

    public partial class SplashScreen : Form
    {
        //================================================
        // Module : frmSplashScreen
        // Project : NRC Student Database
        // Version : 1.1
        // Date : 03/02/17
        // Author : Rorry Kelly
        // Description : For whenever the program first starts
        // this screen shows a selection of options of where to go.
        //================================================

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void btnOpenEntryCreation_Click(object sender, EventArgs e)
        {
            Entry_Creation frm1 = new Entry_Creation();
            frm1.Show();
        }

        private void btnEntryList_Click(object sender, EventArgs e)
        {
            Entry_View frm = new Entry_View();
            frm.Show();
        }

        private void BtnExitFull_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
