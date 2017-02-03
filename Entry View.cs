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
    public partial class Entry_View : Form
    {
        //================================================
        // Module : frmEntry_View
        // Project : NRC Student Database
        // Version : 1.1
        // Date : 03/02/17
        // Author : Rorry Kelly
        // Description : Allows controllers to view all customers
        // and access bookings
        //================================================
        public Entry_View()//main
        {
            InitializeComponent();
            //loading proceedures
            Load_CheckedListBox();
            Load_FullBookings();
            //
        }
        #region Proceedures
        private void Load_FullBookings()
        {
            //================================================
            // Procedure : Load_FullBookings
            // Date : 03/02/17
            // Author : Rorry Kelly
            // Parameters : None
            // Description : puts the list of completed bookings into a rich text file.
            //================================================

            using (StreamReader sr = new StreamReader(@"User Entries\FULL.txt"))//declaring streamreader.
                richFullBookings.Text = sr.ReadToEnd();//placing the read txt file into the richfullbookings text box.
        }

        private void Load_CheckedListBox()
        {
            //================================================
            // Procedure : Load_checkedlistbox
            // Date : 03/02/17
            // Author : RorryKelly
            // Parameters : None
            // Description : Loads all the needed entrylist that may need a full booking.
            //================================================

            var userList = new List<string>();//creating a new list and storing it as a var.
            int noUsers = 0;//declaring an int and assigning it a value of 0

            using (StreamReader sr = new StreamReader(@"User Entries\User Entries List.txt"))//using streamreader again but for user entries list.txt.
            {
                string line;//declaring a string
                while ((line = sr.ReadLine()) != null)//assigning line with each line of the user entry list text file and checking if the line has anything in it, if it does have something in it then it will prompt the if statement.
                {
                    userList.Add(line);//adding the line variable to the userList var.
                    noUsers = noUsers + 1;//a counter for noUsers.
                    string[] EntryVar = line.Split('|');//splitting the line up where there's '|' and storring it in an array.
                    comboEntryList1.Items.Add(EntryVar[0] + " " + EntryVar[1] + ", " + EntryVar[2] + " || " + EntryVar[3] + " || " + EntryVar[4]);//formatting the array into a combo box.
                }
            }
        }
        #endregion
        #region Event Handler
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//closing the form.
        }

        private void btnBooking_Click(object sender, EventArgs e)//event handler for when the booking button is clicked.
        {
            var userList = new List<string>();//declaring a new lsit
            int noUsers = 0;//declaring a new int.

            using (StreamReader sr = new StreamReader(@"User Entries\User Entries List.txt"))//using stream reader with user entry list.
            {
                string line;//declaring a string named 'line'.
                while ((line = sr.ReadLine()) != null)//assigning line with each line of the user entry list text file and checking if the line has anything in it, if it does have something in it then it will prompt the if statement.
                {
                    userList.Add(line);//adding each line to the user list.
                    noUsers = noUsers + 1;//a counter for noUsers.
                }
                string[] ComboGL = comboEntryList1.Text.Split('#');//splitting the combo entry list where theres a # and storing it in an array.
                for (int i = 0; i < noUsers; i++)//for loop checking if I is ever larger than no of users.
                {
                    string[] EntryGL = userList[i].Split('#');//splitting the userList entry (different everytime depending what number i is, EG: when i = 3 it will be the third entry).
                    if (ComboGL[1] == EntryGL[1])//checking if the two arrays are the saeme (the randomly gen ticket numbers).
                    {
                        line = userList[i];//if true the string line is assigned to the specific userlist entry.
                        i = noUsers;//assigning i to the number of users so that the for loop does not repeat again.
                        using (StreamWriter temp = new StreamWriter(@"User Entries\TEMP.txt"))//using streamreader for TEMP.Does not have encoding so it will overwrite and only accept one line of text.
                        {
                            temp.Write(EntryGL[0]);//writting the first part of the array, the details of the user.
                        }
                        Add_Booking AB = new Add_Booking();//openning a new booking system add_booking
                        AB.Show();//showing the form.
                    }
                }
            }
        }
        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            var userList = new List<string>();
            int noUsers = 0;
            using (StreamReader sr = new StreamReader(@"User Entries\User Entries List.txt"))
            {
                string[] ComboRL = comboEntryList1.Text.Split('#');
                string[] EntryRL;
                for (int i = 0; i < noUsers; i++)
                {
                    EntryRL = userList[i].Split('#');
                    if (EntryRL[1] == ComboRL[1])
                    {
                        userList.RemoveAt(i);
                        using (StreamWriter SW = new StreamWriter(@"User Entries\User Entries List.txt"))
                            SW.Write(userList);
                        i = noUsers;
                    }
                }
            }
        }
        #endregion
    }
}
