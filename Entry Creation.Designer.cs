namespace AssOneForm
{
    partial class Entry_Creation
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
            this.components = new System.ComponentModel.Container();
            this.btnCreateEntry = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboTitle = new System.Windows.Forms.ComboBox();
            this.comboDOBDay = new System.Windows.Forms.ComboBox();
            this.comboDOBMonth = new System.Windows.Forms.ComboBox();
            this.comboDOBYear = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateEntry
            // 
            this.btnCreateEntry.Location = new System.Drawing.Point(245, 271);
            this.btnCreateEntry.Name = "btnCreateEntry";
            this.btnCreateEntry.Size = new System.Drawing.Size(75, 23);
            this.btnCreateEntry.TabIndex = 0;
            this.btnCreateEntry.Text = "Create Entry";
            this.btnCreateEntry.UseVisualStyleBackColor = true;
            this.btnCreateEntry.Click += new System.EventHandler(this.btnCreateEntry_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(405, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboTitle
            // 
            this.comboTitle.FormattingEnabled = true;
            this.comboTitle.Location = new System.Drawing.Point(133, 43);
            this.comboTitle.Name = "comboTitle";
            this.comboTitle.Size = new System.Drawing.Size(46, 21);
            this.comboTitle.TabIndex = 2;
            // 
            // comboDOBDay
            // 
            this.comboDOBDay.FormattingEnabled = true;
            this.comboDOBDay.Location = new System.Drawing.Point(455, 74);
            this.comboDOBDay.Name = "comboDOBDay";
            this.comboDOBDay.Size = new System.Drawing.Size(42, 21);
            this.comboDOBDay.TabIndex = 3;
            // 
            // comboDOBMonth
            // 
            this.comboDOBMonth.FormattingEnabled = true;
            this.comboDOBMonth.Location = new System.Drawing.Point(503, 74);
            this.comboDOBMonth.Name = "comboDOBMonth";
            this.comboDOBMonth.Size = new System.Drawing.Size(48, 21);
            this.comboDOBMonth.TabIndex = 4;
            // 
            // comboDOBYear
            // 
            this.comboDOBYear.FormattingEnabled = true;
            this.comboDOBYear.Location = new System.Drawing.Point(557, 74);
            this.comboDOBYear.Name = "comboDOBYear";
            this.comboDOBYear.Size = new System.Drawing.Size(53, 21);
            this.comboDOBYear.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(133, 79);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtFirstName, "Please enter the name that you are known by");
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(133, 116);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(455, 39);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(155, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "DOB";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Entry_Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 382);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.comboDOBYear);
            this.Controls.Add(this.comboDOBMonth);
            this.Controls.Add(this.comboDOBDay);
            this.Controls.Add(this.comboTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateEntry);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Entry_Creation";
            this.Text = "Entry_Creation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEntry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboTitle;
        private System.Windows.Forms.ComboBox comboDOBDay;
        private System.Windows.Forms.ComboBox comboDOBMonth;
        private System.Windows.Forms.ComboBox comboDOBYear;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}