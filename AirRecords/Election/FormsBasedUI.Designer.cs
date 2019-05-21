namespace Election
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
            this.constituencyBtn = new System.Windows.Forms.Button();
            this.partiesBtn = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.reportLbl = new System.Windows.Forms.Label();
            this.candidateListbox = new System.Windows.Forms.ListBox();
            this.partyListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // configBtn
            // 
            this.configBtn.Location = new System.Drawing.Point(50, 42);
            this.configBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.configBtn.Name = "configBtn";
            this.configBtn.Size = new System.Drawing.Size(382, 61);
            this.configBtn.TabIndex = 0;
            this.configBtn.Text = "Create Config Data";
            this.configBtn.UseVisualStyleBackColor = true;
            this.configBtn.Click += new System.EventHandler(this.configBtn_Click);
            // 
            // RunProducerConsumerBtn
            // 
            this.RunProducerConsumerBtn.Enabled = false;
            this.RunProducerConsumerBtn.Location = new System.Drawing.Point(50, 141);
            this.RunProducerConsumerBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RunProducerConsumerBtn.Name = "RunProducerConsumerBtn";
            this.RunProducerConsumerBtn.Size = new System.Drawing.Size(382, 56);
            this.RunProducerConsumerBtn.TabIndex = 1;
            this.RunProducerConsumerBtn.Text = "Load Candidate Data";
            this.RunProducerConsumerBtn.UseVisualStyleBackColor = true;
            this.RunProducerConsumerBtn.Click += new System.EventHandler(this.RunProducerConsumerBtn_Click);
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Location = new System.Drawing.Point(576, 42);
            this.progressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(144, 25);
            this.progressLbl.TabIndex = 2;
            this.progressLbl.Text = "Awaiting Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // LocationListbox
            // 
            this.LocationListbox.FormattingEnabled = true;
            this.LocationListbox.ItemHeight = 25;
            this.LocationListbox.Location = new System.Drawing.Point(496, 181);
            this.LocationListbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LocationListbox.Name = "LocationListbox";
            this.LocationListbox.Size = new System.Drawing.Size(434, 354);
            this.LocationListbox.TabIndex = 4;
            this.LocationListbox.SelectedIndexChanged += new System.EventHandler(this.constituencyListbox_SelectedIndexChanged);
            // 
            // constituencyBtn
            // 
            this.constituencyBtn.Enabled = false;
            this.constituencyBtn.Location = new System.Drawing.Point(50, 244);
            this.constituencyBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.constituencyBtn.Name = "constituencyBtn";
            this.constituencyBtn.Size = new System.Drawing.Size(270, 61);
            this.constituencyBtn.TabIndex = 5;
            this.constituencyBtn.Text = "Display Constituencies";
            this.constituencyBtn.UseVisualStyleBackColor = true;
            this.constituencyBtn.Click += new System.EventHandler(this.constituenciesBtn_Click);
            // 
            // partiesBtn
            // 
            this.partiesBtn.Enabled = false;
            this.partiesBtn.Location = new System.Drawing.Point(50, 341);
            this.partiesBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.partiesBtn.Name = "partiesBtn";
            this.partiesBtn.Size = new System.Drawing.Size(270, 61);
            this.partiesBtn.TabIndex = 6;
            this.partiesBtn.Text = "Display Party Votes";
            this.partiesBtn.UseVisualStyleBackColor = true;
            this.partiesBtn.Click += new System.EventHandler(this.partiesBtn_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(496, 141);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(94, 25);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location";
            // 
            // reportLbl
            // 
            this.reportLbl.AutoSize = true;
            this.reportLbl.Location = new System.Drawing.Point(750, 141);
            this.reportLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reportLbl.Name = "reportLbl";
            this.reportLbl.Size = new System.Drawing.Size(0, 25);
            this.reportLbl.TabIndex = 8;
            // 
            // candidateListbox
            // 
            this.candidateListbox.FormattingEnabled = true;
            this.candidateListbox.ItemHeight = 25;
            this.candidateListbox.Location = new System.Drawing.Point(938, 181);
            this.candidateListbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.candidateListbox.Name = "candidateListbox";
            this.candidateListbox.Size = new System.Drawing.Size(631, 354);
            this.candidateListbox.TabIndex = 9;
            // 
            // partyListbox
            // 
            this.partyListbox.FormattingEnabled = true;
            this.partyListbox.ItemHeight = 25;
            this.partyListbox.Location = new System.Drawing.Point(696, 580);
            this.partyListbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.partyListbox.Name = "partyListbox";
            this.partyListbox.Size = new System.Drawing.Size(873, 354);
            this.partyListbox.TabIndex = 10;
            // 
            // FormsBasedUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 1117);
            this.Controls.Add(this.partyListbox);
            this.Controls.Add(this.candidateListbox);
            this.Controls.Add(this.reportLbl);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.partiesBtn);
            this.Controls.Add(this.constituencyBtn);
            this.Controls.Add(this.LocationListbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.RunProducerConsumerBtn);
            this.Controls.Add(this.configBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormsBasedUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormsBasedUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button configBtn;
        private System.Windows.Forms.Button RunProducerConsumerBtn;
        private System.Windows.Forms.Label progressLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LocationListbox;
        private System.Windows.Forms.Button constituencyBtn;
        private System.Windows.Forms.Button partiesBtn;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label reportLbl;
        private System.Windows.Forms.ListBox candidateListbox;
        private System.Windows.Forms.ListBox partyListbox;
    }
}

