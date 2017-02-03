using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AssOneForm
{
    public partial class Entry_Creation : Form
    {
        //================================================
        // Module : frmEntry_Creaton
        // Project : NRC Student Database
        // Version : 1.1
        // Date : 03/02/17
        // Author : Rorry Kelly
        // Description : For when a entirely new user needs an account 
        // before booking
        //================================================
        public Entry_Creation()
        {
            InitializeComponent();
            LoadCombos();//loading the combo options in this form in a different function.
        }
        #region Event Handlers
        private void btnCreateEntry_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"User Entries\User Entries List.txt", true))//declaration of the code using stream writer to write on a .txt file (used thanks to the using system.io line at the top). The suffix 'true' statement is to make the function know to encode the text line.
            {
                Random rnd = new Random();
                sw.WriteLine(comboTitle.Text + "|" + txtSurname.Text + "|" + txtFirstName.Text + "|" + txtAddress.Text + "|" + comboDOBDay.Text + "-" + comboDOBMonth.Text + "-" + comboDOBYear.Text + "   #" + rnd.Next(1, 1000));//writing a new line in the text file. Splitting it up with a '|' so that we can later seperate it.
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region ComboEntries
        private void LoadCombos()
        {
            //================================================
            // Procedure : LoadCombos
            // Date : 03/02/17
            // Author : Rorry Kelly
            // Parameters : None
            // Description : Dynamically adds the entriesof the combo box.
            //================================================

            //Comboboxes entries for Title
            comboTitle.Items.Add("Mr");
            comboTitle.Items.Add("Miss");
            comboTitle.Items.Add("Mrs");
            //Comboboxes entries for DOB Day
            comboDOBDay.Items.Add("1");
            comboDOBDay.Items.Add("2");
            comboDOBDay.Items.Add("3");
            comboDOBDay.Items.Add("4");
            comboDOBDay.Items.Add("5");
            comboDOBDay.Items.Add("6");
            comboDOBDay.Items.Add("7");
            comboDOBDay.Items.Add("8");
            comboDOBDay.Items.Add("9");
            comboDOBDay.Items.Add("10");
            comboDOBDay.Items.Add("11");
            comboDOBDay.Items.Add("12");
            comboDOBDay.Items.Add("13");
            comboDOBDay.Items.Add("14");
            comboDOBDay.Items.Add("15");
            comboDOBDay.Items.Add("16");
            comboDOBDay.Items.Add("17");
            comboDOBDay.Items.Add("18");
            comboDOBDay.Items.Add("19");
            comboDOBDay.Items.Add("20");
            comboDOBDay.Items.Add("21");
            comboDOBDay.Items.Add("22");
            comboDOBDay.Items.Add("23");
            comboDOBDay.Items.Add("24");
            comboDOBDay.Items.Add("25");
            comboDOBDay.Items.Add("26");
            comboDOBDay.Items.Add("27");
            comboDOBDay.Items.Add("28");
            comboDOBDay.Items.Add("29");
            comboDOBDay.Items.Add("30");
            comboDOBDay.Items.Add("31");
            //Comboentries for DOB Month
            comboDOBMonth.Items.Add("1");
            comboDOBMonth.Items.Add("2");
            comboDOBMonth.Items.Add("3");
            comboDOBMonth.Items.Add("4");
            comboDOBMonth.Items.Add("5");
            comboDOBMonth.Items.Add("6");
            comboDOBMonth.Items.Add("7");
            comboDOBMonth.Items.Add("8");
            comboDOBMonth.Items.Add("9");
            comboDOBMonth.Items.Add("10");
            comboDOBMonth.Items.Add("11");
            comboDOBMonth.Items.Add("12");
            //Combo entries for DOB Year
            comboDOBYear.Items.Add("1998");
            comboDOBYear.Items.Add("1997");
            comboDOBYear.Items.Add("1996");
            comboDOBYear.Items.Add("1995");
            comboDOBYear.Items.Add("1994");
            comboDOBYear.Items.Add("1993");
            comboDOBYear.Items.Add("1992");
            comboDOBYear.Items.Add("1991");
            comboDOBYear.Items.Add("1990");
            comboDOBYear.Items.Add("1989");
            comboDOBYear.Items.Add("1988");
            comboDOBYear.Items.Add("1987");
            comboDOBYear.Items.Add("1986");
            comboDOBYear.Items.Add("1985");
            comboDOBYear.Items.Add("1984");
            comboDOBYear.Items.Add("1983");
            comboDOBYear.Items.Add("1982");
            comboDOBYear.Items.Add("1981");
            comboDOBYear.Items.Add("1980");
            comboDOBYear.Items.Add("1979");
            comboDOBYear.Items.Add("1978");
            comboDOBYear.Items.Add("1977");
            comboDOBYear.Items.Add("1976");
            comboDOBYear.Items.Add("1975");
            comboDOBYear.Items.Add("1974");
            comboDOBYear.Items.Add("1973");
            comboDOBYear.Items.Add("1972");
            comboDOBYear.Items.Add("1971");
            comboDOBYear.Items.Add("1970");
            comboDOBYear.Items.Add("1969");
        }
        #endregion
    }
}
