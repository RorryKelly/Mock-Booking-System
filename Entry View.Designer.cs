namespace AssOneForm
{
    partial class Entry_View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.comboEntryList1 = new System.Windows.Forms.ComboBox();
            this.richFullBookings = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(26, 73);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(106, 23);
            this.btnBooking.TabIndex = 0;
            this.btnBooking.Text = "Add Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(413, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(317, 73);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(119, 24);
            this.btnRemoveClient.TabIndex = 2;
            this.btnRemoveClient.Text = "Remove Client";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // comboEntryList1
            // 
            this.comboEntryList1.FormattingEnabled = true;
            this.comboEntryList1.Location = new System.Drawing.Point(26, 46);
            this.comboEntryList1.Name = "comboEntryList1";
            this.comboEntryList1.Size = new System.Drawing.Size(410, 21);
            this.comboEntryList1.TabIndex = 3;
            // 
            // richFullBookings
            // 
            this.richFullBookings.Location = new System.Drawing.Point(26, 153);
            this.richFullBookings.Name = "richFullBookings";
            this.richFullBookings.Size = new System.Drawing.Size(410, 141);
            this.richFullBookings.TabIndex = 4;
            this.richFullBookings.Text = "";
            // 
            // Entry_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 380);
            this.Controls.Add(this.richFullBookings);
            this.Controls.Add(this.comboEntryList1);
            this.Controls.Add(this.btnRemoveClient);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBooking);
            this.Name = "Entry_View";
            this.Text = "Entry_View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.ComboBox comboEntryList1;
        private System.Windows.Forms.RichTextBox richFullBookings;
    }
}