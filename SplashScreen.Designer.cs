namespace AssOneForm
{
    partial class SplashScreen
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
            this.btnOpenEntryCreation = new System.Windows.Forms.Button();
            this.btnEntryList = new System.Windows.Forms.Button();
            this.BtnExitFull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenEntryCreation
            // 
            this.btnOpenEntryCreation.Location = new System.Drawing.Point(88, 102);
            this.btnOpenEntryCreation.Name = "btnOpenEntryCreation";
            this.btnOpenEntryCreation.Size = new System.Drawing.Size(87, 23);
            this.btnOpenEntryCreation.TabIndex = 0;
            this.btnOpenEntryCreation.Text = "Entry Creation";
            this.btnOpenEntryCreation.UseVisualStyleBackColor = true;
            this.btnOpenEntryCreation.Click += new System.EventHandler(this.btnOpenEntryCreation_Click);
            // 
            // btnEntryList
            // 
            this.btnEntryList.Location = new System.Drawing.Point(205, 102);
            this.btnEntryList.Name = "btnEntryList";
            this.btnEntryList.Size = new System.Drawing.Size(75, 23);
            this.btnEntryList.TabIndex = 1;
            this.btnEntryList.Text = "Entry List";
            this.btnEntryList.UseVisualStyleBackColor = true;
            this.btnEntryList.Click += new System.EventHandler(this.btnEntryList_Click);
            // 
            // BtnExitFull
            // 
            this.BtnExitFull.Location = new System.Drawing.Point(322, 101);
            this.BtnExitFull.Name = "BtnExitFull";
            this.BtnExitFull.Size = new System.Drawing.Size(75, 23);
            this.BtnExitFull.TabIndex = 2;
            this.BtnExitFull.Text = "Exit";
            this.BtnExitFull.UseVisualStyleBackColor = true;
            this.BtnExitFull.Click += new System.EventHandler(this.BtnExitFull_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 147);
            this.Controls.Add(this.BtnExitFull);
            this.Controls.Add(this.btnEntryList);
            this.Controls.Add(this.btnOpenEntryCreation);
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenEntryCreation;
        private System.Windows.Forms.Button btnEntryList;
        private System.Windows.Forms.Button BtnExitFull;
    }
}