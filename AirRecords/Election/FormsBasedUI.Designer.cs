namespace AirRecords
{
    partial class FormsBasedUI
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
            this.configBtn = new System.Windows.Forms.Button();
            this.RunProducerConsumerBtn = new System.Windows.Forms.Button();
            this.progressLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LocationListbox = new System.Windows.Forms.ListBox();
            this.BtnDisplayLocations = new System.Windows.Forms.Button();
            this.btnhighbydate = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.reportLbl = new System.Windows.Forms.Label();
            this.DetailListbox = new System.Windows.Forms.ListBox();
            this.HighestByDateListbox = new System.Windows.Forms.ListBox();
            this.btnsort = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblHightByDate = new System.Windows.Forms.Label();
            this.DisplayHighByLacationListBox = new System.Windows.Forms.ListBox();
            this.lblbyLoc = new System.Windows.Forms.Label();
            this.btnHighLocation = new System.Windows.Forms.Button();
            this.btnhighValue = new System.Windows.Forms.Button();
            this.lblhighestValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // configBtn
            // 
            this.configBtn.Location = new System.Drawing.Point(25, 22);
            this.configBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.configBtn.Name = "configBtn";
            this.configBtn.Size = new System.Drawing.Size(191, 32);
            this.configBtn.TabIndex = 0;
            this.configBtn.Text = "Create Config Data";
            this.configBtn.UseVisualStyleBackColor = true;
            this.configBtn.Click += new System.EventHandler(this.configBtn_Click);
            // 
            // RunProducerConsumerBtn
            // 
            this.RunProducerConsumerBtn.Enabled = false;
            this.RunProducerConsumerBtn.Location = new System.Drawing.Point(25, 73);
            this.RunProducerConsumerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RunProducerConsumerBtn.Name = "RunProducerConsumerBtn";
            this.RunProducerConsumerBtn.Size = new System.Drawing.Size(191, 29);
            this.RunProducerConsumerBtn.TabIndex = 1;
            this.RunProducerConsumerBtn.Text = "Load Particulates Data";
            this.RunProducerConsumerBtn.UseVisualStyleBackColor = true;
            this.RunProducerConsumerBtn.Click += new System.EventHandler(this.RunProducerConsumerBtn_Click);
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Location = new System.Drawing.Point(288, 22);
            this.progressLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(73, 13);
            this.progressLbl.TabIndex = 2;
            this.progressLbl.Text = "Awaiting Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // LocationListbox
            // 
            this.LocationListbox.FormattingEnabled = true;
            this.LocationListbox.Location = new System.Drawing.Point(248, 77);
            this.LocationListbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LocationListbox.Name = "LocationListbox";
            this.LocationListbox.Size = new System.Drawing.Size(219, 121);
            this.LocationListbox.TabIndex = 4;
            this.LocationListbox.SelectedIndexChanged += new System.EventHandler(this.LocationListbox_SelectedIndexChanged);
            // 
            // BtnDisplayLocations
            // 
            this.BtnDisplayLocations.Enabled = false;
            this.BtnDisplayLocations.Location = new System.Drawing.Point(25, 132);
            this.BtnDisplayLocations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDisplayLocations.Name = "BtnDisplayLocations";
            this.BtnDisplayLocations.Size = new System.Drawing.Size(135, 32);
            this.BtnDisplayLocations.TabIndex = 5;
            this.BtnDisplayLocations.Text = "Display Locations";
            this.BtnDisplayLocations.UseVisualStyleBackColor = true;
            this.BtnDisplayLocations.Click += new System.EventHandler(this.constituenciesBtn_Click);
            // 
            // btnhighbydate
            // 
            this.btnhighbydate.Enabled = false;
            this.btnhighbydate.Location = new System.Drawing.Point(488, 353);
            this.btnhighbydate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnhighbydate.Name = "btnhighbydate";
            this.btnhighbydate.Size = new System.Drawing.Size(196, 32);
            this.btnhighbydate.TabIndex = 6;
            this.btnhighbydate.Text = "Display Total Values By Date";
            this.btnhighbydate.UseVisualStyleBackColor = true;
            this.btnhighbydate.Click += new System.EventHandler(this.btnhighbydate_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(246, 57);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location";
            // 
            // reportLbl
            // 
            this.reportLbl.AutoSize = true;
            this.reportLbl.Location = new System.Drawing.Point(375, 73);
            this.reportLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reportLbl.Name = "reportLbl";
            this.reportLbl.Size = new System.Drawing.Size(0, 13);
            this.reportLbl.TabIndex = 8;
            // 
            // DetailListbox
            // 
            this.DetailListbox.FormattingEnabled = true;
            this.DetailListbox.Location = new System.Drawing.Point(488, 77);
            this.DetailListbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DetailListbox.Name = "DetailListbox";
            this.DetailListbox.Size = new System.Drawing.Size(298, 121);
            this.DetailListbox.TabIndex = 9;
            // 
            // HighestByDateListbox
            // 
            this.HighestByDateListbox.FormattingEnabled = true;
            this.HighestByDateListbox.Location = new System.Drawing.Point(488, 253);
            this.HighestByDateListbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HighestByDateListbox.Name = "HighestByDateListbox";
            this.HighestByDateListbox.Size = new System.Drawing.Size(298, 95);
            this.HighestByDateListbox.TabIndex = 10;
            // 
            // btnsort
            // 
            this.btnsort.Enabled = false;
            this.btnsort.Location = new System.Drawing.Point(25, 177);
            this.btnsort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(135, 32);
            this.btnsort.TabIndex = 11;
            this.btnsort.Text = "Alphabetical Sort";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(486, 57);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(83, 13);
            this.lblDetails.TabIndex = 12;
            this.lblDetails.Text = "Location Details";
            // 
            // lblHightByDate
            // 
            this.lblHightByDate.AutoSize = true;
            this.lblHightByDate.Location = new System.Drawing.Point(486, 222);
            this.lblHightByDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHightByDate.Name = "lblHightByDate";
            this.lblHightByDate.Size = new System.Drawing.Size(107, 13);
            this.lblHightByDate.TabIndex = 13;
            this.lblHightByDate.Text = "Total Values By Date";
            // 
            // DisplayHighByLacationListBox
            // 
            this.DisplayHighByLacationListBox.FormattingEnabled = true;
            this.DisplayHighByLacationListBox.Location = new System.Drawing.Point(248, 253);
            this.DisplayHighByLacationListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisplayHighByLacationListBox.Name = "DisplayHighByLacationListBox";
            this.DisplayHighByLacationListBox.Size = new System.Drawing.Size(219, 82);
            this.DisplayHighByLacationListBox.TabIndex = 14;
            // 
            // lblbyLoc
            // 
            this.lblbyLoc.AutoSize = true;
            this.lblbyLoc.Location = new System.Drawing.Point(246, 222);
            this.lblbyLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbyLoc.Name = "lblbyLoc";
            this.lblbyLoc.Size = new System.Drawing.Size(130, 13);
            this.lblbyLoc.TabIndex = 15;
            this.lblbyLoc.Text = "Total Values By Locations";
            // 
            // btnHighLocation
            // 
            this.btnHighLocation.Enabled = false;
            this.btnHighLocation.Location = new System.Drawing.Point(248, 345);
            this.btnHighLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHighLocation.Name = "btnHighLocation";
            this.btnHighLocation.Size = new System.Drawing.Size(193, 32);
            this.btnHighLocation.TabIndex = 16;
            this.btnHighLocation.Text = "Display Total Values By Locations";
            this.btnHighLocation.UseVisualStyleBackColor = true;
            this.btnHighLocation.Click += new System.EventHandler(this.btnHighLocation_Click);
            // 
            // btnhighValue
            // 
            this.btnhighValue.Enabled = false;
            this.btnhighValue.Location = new System.Drawing.Point(12, 473);
            this.btnhighValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnhighValue.Name = "btnhighValue";
            this.btnhighValue.Size = new System.Drawing.Size(196, 32);
            this.btnhighValue.TabIndex = 17;
            this.btnhighValue.Text = "Display Highest Value";
            this.btnhighValue.UseVisualStyleBackColor = true;
            this.btnhighValue.Click += new System.EventHandler(this.btnhighValue_Click);
            // 
            // lblhighestValue
            // 
            this.lblhighestValue.AutoSize = true;
            this.lblhighestValue.Location = new System.Drawing.Point(10, 449);
            this.lblhighestValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhighestValue.Name = "lblhighestValue";
            this.lblhighestValue.Size = new System.Drawing.Size(0, 13);
            this.lblhighestValue.TabIndex = 18;
            // 
            // FormsBasedUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 520);
            this.Controls.Add(this.lblhighestValue);
            this.Controls.Add(this.btnhighValue);
            this.Controls.Add(this.btnHighLocation);
            this.Controls.Add(this.lblbyLoc);
            this.Controls.Add(this.DisplayHighByLacationListBox);
            this.Controls.Add(this.lblHightByDate);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnsort);
            this.Controls.Add(this.HighestByDateListbox);
            this.Controls.Add(this.DetailListbox);
            this.Controls.Add(this.reportLbl);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnhighbydate);
            this.Controls.Add(this.BtnDisplayLocations);
            this.Controls.Add(this.LocationListbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.RunProducerConsumerBtn);
            this.Controls.Add(this.configBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormsBasedUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button configBtn;
        private System.Windows.Forms.Button RunProducerConsumerBtn;
        private System.Windows.Forms.Label progressLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LocationListbox;
        private System.Windows.Forms.Button BtnDisplayLocations;
        private System.Windows.Forms.Button btnhighbydate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label reportLbl;
        private System.Windows.Forms.ListBox DetailListbox;
        private System.Windows.Forms.ListBox HighestByDateListbox;
        private System.Windows.Forms.Button btnsort;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblHightByDate;
        private System.Windows.Forms.ListBox DisplayHighByLacationListBox;
        private System.Windows.Forms.Label lblbyLoc;
        private System.Windows.Forms.Button btnHighLocation;
        private System.Windows.Forms.Button btnhighValue;
        private System.Windows.Forms.Label lblhighestValue;
    }
}

