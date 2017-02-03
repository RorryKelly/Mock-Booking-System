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

    public partial class Add_Booking : Form
    {
        //================================================
        // Module : frmAdd_Booking.
        // Project : NRC Student Database
        // Version : 1.1
        // Date : 03/02/17
        // Author : Rorry Kelly
        // Description : Allows already made users to actually 
        // create a booking with dates, venues, etc.
        //================================================
        public Add_Booking()//main
        {
            InitializeComponent();
            LoadStats();//loading the proceedure to load stats. 
        }
        #region Proceedures and Functions
        private void LoadStats()
        {
            //================================================
            // Procedure : LoadStats
            // Date : 03/02/17
            // Author : Rorry Kelly
            // Parameters : None
            // Description :Loads stats from the user making the booking
            //================================================

            using (StreamReader TEMP = new StreamReader(@"User Entries\TEMP.txt"))//using streamreader on the TEMP file from Entry View.
            {
                string[] STATS = TEMP.ReadLine().Split('|');//splitting the line up to different values every time there's a '|'.
                //dynamically changing the properties of the textbox using the different values held in the STATS array.
                txtTitle.Text = STATS[0];
                txtSurname.Text = STATS[1];
                txtFirstName.Text = STATS[2];
                txtCurrentAddress.Text = STATS[3];
                txtDOB.Text = STATS[4];
                //
                //adding items into a combo box, the different venues.
                comboVenue.Items.Add("Alamond Plasa w/ Business Class Suite");
                comboVenue.Items.Add("Alamond Plasa w/ Luxury Class Suite");
                comboVenue.Items.Add("Herbery Ward w/ Business Class Suite");
                comboVenue.Items.Add("Herbery Ward w/ Luxury Class Suite");
            }
        }
        private float findTotal()
        {
            //================================================
            // Procedure : findTotal
            // Date : 03/02/17
            // Author : Rorry KElly
            // Parameters : float Venue
            // Returns : float venuecost
            // Description : Caluclates the total cost of the venue.
            //================================================


            float venuecost = 0;//setting the venue cost to 0 after being declared.
            switch (comboVenue.SelectedItem.ToString())//creating a switch function
            {
                case "Alamond Plasa w/ Business Class Suite"://if the combovenue is Alamond Plasa w/ Business Class Suite then:
                    venuecost = 25;//do this
                    break;
                case "Alamond Plasa w/ Luxury Class Suite"://if the combovenue is Alamond Plasa w/ Luxury Class Suite then:
                    venuecost = 20;//do this.
                    break;
                case "Herbery Ward w/ Business Class Suite"://if the combovenue is Herbery Ward w/ Business Class Suite then:
                    venuecost = 10;//do this.
                    break;
                case "Herbery Ward w/ Luxury Class Suite"://if the combovenue is Herbery Ward w/ Luxury Class Suite then:
                    venuecost = 5;//do this.
                    break;
                default://as defualt: 
                    venuecost = 0;//do this.
                    break;
            }
            return venuecost;//returning the value.
        }

        private float findTime(float time)
        {
            //================================================
            // Procedure : findTime
            // Date : 03/02/17
            // Author : Rorry Kelly
            // Parameters : float time
            // Returns : float thetimeF
            // Description : calculates the cost of the time spent at the venue.
            //================================================


            var thetime = (dateEnd.Value - dateStart.Value).TotalDays;//finding the total amount of days in the start and end dates
            float thetimeF = Convert.ToSingle(thetime) * 3;//multiplying the days by 3.
            return thetimeF;//returning the value.
        }
        #endregion
        #region Event Handlers
        private void btnCreate_Click(object sender, EventArgs e)//event handler for when the create button is clicked.
        {
            //declaring variables.
            float time = 0;
            float total = findTotal();
            //
            findTime(time);//calling the find time proceedure.
            if (total == 0)//checking if total was not changed in the proceedure. If it wasn't then we know that there was none of the comboboxes were selected.
            {
                MessageBox.Show("You've failed to enter in a venue please do so.");//showing messagebox saying to try again.
            }

            using (StreamWriter FULL = new StreamWriter(@"User Entries\FULL.txt", true))//streamwriter being used, with encoding to ensure that there will be multiple lines written.
            {
                Random rnd = new Random();//declaring a new random value
                float VAT = 1.3f;//declaring a VAT on its on so that it is easily changed in future iterations.
                total += time;//adding both total and time together to make the total price.
                total *= VAT;//multipling
                FULL.WriteLine(txtTitle.Text + txtSurname.Text + txtFirstName.Text + " ariving at " + comboVenue.Text + " on  the " + dateStart.Text + "-" + dateEnd.Text + " || " + txtCurrentAddress.Text + txtDOB.Text + rnd.Next(1, 1000));//storing the completed booking in a new text file.
                MessageBox.Show("The total cost is: " + total + " The VAT is at " + Convert.ToString(VAT) + "%");//telling the user the cost + VAT.
            }
        }

        private void btnExit_Click(object sender, EventArgs e)//event handler for the button being closed.
        {
            this.Close();//closing the form.
        }
        #endregion
    }
}
