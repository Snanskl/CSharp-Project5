namespace Assignment_5
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.newEventGroupBox = new System.Windows.Forms.GroupBox();
            this.createEventButton = new System.Windows.Forms.Button();
            this.feeParticipantsTextBox = new System.Windows.Forms.TextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            this.costperPersonTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.countryComboList = new System.Windows.Forms.ComboBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.lastNamrLabel = new System.Windows.Forms.Label();
            this.infoListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.economyGroupBox = new System.Windows.Forms.GroupBox();
            this.surplusDefOutput = new System.Windows.Forms.Label();
            this.totalFeesOutput = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.numbParticipantOutput = new System.Windows.Forms.Label();
            this.surpDefLabel = new System.Windows.Forms.Label();
            this.totalFeesLabel = new System.Windows.Forms.Label();
            this.totaltCostLabel = new System.Windows.Forms.Label();
            this.numbOfParticiPantLabel = new System.Windows.Forms.Label();
            this.newEventGroupBox.SuspendLayout();
            this.addGroupBox.SuspendLayout();
            this.economyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newEventGroupBox
            // 
            this.newEventGroupBox.Controls.Add(this.createEventButton);
            this.newEventGroupBox.Controls.Add(this.feeParticipantsTextBox);
            this.newEventGroupBox.Controls.Add(this.feeLabel);
            this.newEventGroupBox.Controls.Add(this.costperPersonTextBox);
            this.newEventGroupBox.Controls.Add(this.costLabel);
            this.newEventGroupBox.Controls.Add(this.titleTextBox);
            this.newEventGroupBox.Controls.Add(this.titleLabel);
            this.newEventGroupBox.Location = new System.Drawing.Point(12, 12);
            this.newEventGroupBox.Name = "newEventGroupBox";
            this.newEventGroupBox.Size = new System.Drawing.Size(654, 350);
            this.newEventGroupBox.TabIndex = 0;
            this.newEventGroupBox.TabStop = false;
            this.newEventGroupBox.Text = "New Event";
            // 
            // createEventButton
            // 
            this.createEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEventButton.Location = new System.Drawing.Point(205, 300);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(248, 46);
            this.createEventButton.TabIndex = 1;
            this.createEventButton.Text = "Create Event";
            this.createEventButton.UseVisualStyleBackColor = true;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // feeParticipantsTextBox
            // 
            this.feeParticipantsTextBox.Location = new System.Drawing.Point(368, 223);
            this.feeParticipantsTextBox.Name = "feeParticipantsTextBox";
            this.feeParticipantsTextBox.Size = new System.Drawing.Size(274, 44);
            this.feeParticipantsTextBox.TabIndex = 4;
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(23, 226);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(303, 37);
            this.feeLabel.TabIndex = 3;
            this.feeLabel.Text = "Fee per participant";
            // 
            // costperPersonTextBox
            // 
            this.costperPersonTextBox.Location = new System.Drawing.Point(368, 146);
            this.costperPersonTextBox.Name = "costperPersonTextBox";
            this.costperPersonTextBox.Size = new System.Drawing.Size(274, 44);
            this.costperPersonTextBox.TabIndex = 2;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(23, 150);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(316, 37);
            this.costLabel.TabIndex = 1;
            this.costLabel.Text = "Cost per participant";
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.titleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.titleTextBox.Location = new System.Drawing.Point(235, 73);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(407, 44);
            this.titleTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(23, 76);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(166, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Event title";
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.zipCodeLabel);
            this.addGroupBox.Controls.Add(this.firstNameLabel);
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.countryComboList);
            this.addGroupBox.Controls.Add(this.zipCodeTextBox);
            this.addGroupBox.Controls.Add(this.cityTextBox);
            this.addGroupBox.Controls.Add(this.streetTextBox);
            this.addGroupBox.Controls.Add(this.lastNameTextBox);
            this.addGroupBox.Controls.Add(this.firstNameTextbox);
            this.addGroupBox.Controls.Add(this.countryLabel);
            this.addGroupBox.Controls.Add(this.cityLabel);
            this.addGroupBox.Controls.Add(this.streetLabel);
            this.addGroupBox.Controls.Add(this.lastNamrLabel);
            this.addGroupBox.Location = new System.Drawing.Point(12, 368);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(654, 547);
            this.addGroupBox.TabIndex = 1;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add participant";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(23, 353);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(155, 37);
            this.zipCodeLabel.TabIndex = 14;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(20, 71);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(185, 37);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(205, 492);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(248, 49);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // countryComboList
            // 
            this.countryComboList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboList.FormattingEnabled = true;
            this.countryComboList.Location = new System.Drawing.Point(275, 426);
            this.countryComboList.Name = "countryComboList";
            this.countryComboList.Size = new System.Drawing.Size(367, 45);
            this.countryComboList.TabIndex = 13;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(275, 350);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(367, 44);
            this.zipCodeTextBox.TabIndex = 12;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(275, 276);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(367, 44);
            this.cityTextBox.TabIndex = 11;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(275, 204);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(367, 44);
            this.streetTextBox.TabIndex = 10;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(275, 127);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(367, 44);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(275, 53);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(367, 44);
            this.firstNameTextbox.TabIndex = 8;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(23, 429);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(136, 37);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(23, 282);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(75, 37);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(23, 203);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(107, 37);
            this.streetLabel.TabIndex = 6;
            this.streetLabel.Text = "Street";
            // 
            // lastNamrLabel
            // 
            this.lastNamrLabel.AutoSize = true;
            this.lastNamrLabel.Location = new System.Drawing.Point(23, 131);
            this.lastNamrLabel.Name = "lastNamrLabel";
            this.lastNamrLabel.Size = new System.Drawing.Size(182, 37);
            this.lastNamrLabel.TabIndex = 7;
            this.lastNamrLabel.Text = "Last Name";
            // 
            // infoListBox
            // 
            this.infoListBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoListBox.ForeColor = System.Drawing.Color.IndianRed;
            this.infoListBox.FormattingEnabled = true;
            this.infoListBox.ItemHeight = 36;
            this.infoListBox.Location = new System.Drawing.Point(714, 63);
            this.infoListBox.Name = "infoListBox";
            this.infoListBox.Size = new System.Drawing.Size(897, 400);
            this.infoListBox.TabIndex = 2;
            this.infoListBox.SelectedIndexChanged += new System.EventHandler(this.infoListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(774, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Participant";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(1343, 12);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(142, 37);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(839, 511);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(207, 49);
            this.changeButton.TabIndex = 6;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1260, 511);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(207, 46);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // economyGroupBox
            // 
            this.economyGroupBox.Controls.Add(this.surplusDefOutput);
            this.economyGroupBox.Controls.Add(this.totalFeesOutput);
            this.economyGroupBox.Controls.Add(this.totalCostOutput);
            this.economyGroupBox.Controls.Add(this.numbParticipantOutput);
            this.economyGroupBox.Controls.Add(this.surpDefLabel);
            this.economyGroupBox.Controls.Add(this.totalFeesLabel);
            this.economyGroupBox.Controls.Add(this.totaltCostLabel);
            this.economyGroupBox.Controls.Add(this.numbOfParticiPantLabel);
            this.economyGroupBox.Location = new System.Drawing.Point(705, 584);
            this.economyGroupBox.Name = "economyGroupBox";
            this.economyGroupBox.Size = new System.Drawing.Size(891, 273);
            this.economyGroupBox.TabIndex = 8;
            this.economyGroupBox.TabStop = false;
            this.economyGroupBox.Text = "Event economy";
            // 
            // surplusDefOutput
            // 
            this.surplusDefOutput.BackColor = System.Drawing.Color.Snow;
            this.surplusDefOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.surplusDefOutput.Location = new System.Drawing.Point(435, 205);
            this.surplusDefOutput.Name = "surplusDefOutput";
            this.surplusDefOutput.Size = new System.Drawing.Size(446, 42);
            this.surplusDefOutput.TabIndex = 16;
            // 
            // totalFeesOutput
            // 
            this.totalFeesOutput.BackColor = System.Drawing.Color.Snow;
            this.totalFeesOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalFeesOutput.Location = new System.Drawing.Point(435, 152);
            this.totalFeesOutput.Name = "totalFeesOutput";
            this.totalFeesOutput.Size = new System.Drawing.Size(446, 42);
            this.totalFeesOutput.TabIndex = 15;
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.BackColor = System.Drawing.Color.Snow;
            this.totalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostOutput.Location = new System.Drawing.Point(435, 101);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(446, 42);
            this.totalCostOutput.TabIndex = 14;
            // 
            // numbParticipantOutput
            // 
            this.numbParticipantOutput.BackColor = System.Drawing.Color.Snow;
            this.numbParticipantOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numbParticipantOutput.Location = new System.Drawing.Point(435, 51);
            this.numbParticipantOutput.Name = "numbParticipantOutput";
            this.numbParticipantOutput.Size = new System.Drawing.Size(446, 42);
            this.numbParticipantOutput.TabIndex = 13;
            // 
            // surpDefLabel
            // 
            this.surpDefLabel.AutoSize = true;
            this.surpDefLabel.Location = new System.Drawing.Point(30, 214);
            this.surpDefLabel.Name = "surpDefLabel";
            this.surpDefLabel.Size = new System.Drawing.Size(233, 37);
            this.surpDefLabel.TabIndex = 12;
            this.surpDefLabel.Text = "Surplus/deficit";
            // 
            // totalFeesLabel
            // 
            this.totalFeesLabel.AutoSize = true;
            this.totalFeesLabel.Location = new System.Drawing.Point(30, 161);
            this.totalFeesLabel.Name = "totalFeesLabel";
            this.totalFeesLabel.Size = new System.Drawing.Size(167, 37);
            this.totalFeesLabel.TabIndex = 11;
            this.totalFeesLabel.Text = "Total fees";
            // 
            // totaltCostLabel
            // 
            this.totaltCostLabel.AutoSize = true;
            this.totaltCostLabel.Location = new System.Drawing.Point(30, 106);
            this.totaltCostLabel.Name = "totaltCostLabel";
            this.totaltCostLabel.Size = new System.Drawing.Size(167, 37);
            this.totaltCostLabel.TabIndex = 10;
            this.totaltCostLabel.Text = "Total cost";
            // 
            // numbOfParticiPantLabel
            // 
            this.numbOfParticiPantLabel.AutoSize = true;
            this.numbOfParticiPantLabel.Location = new System.Drawing.Point(30, 51);
            this.numbOfParticiPantLabel.Name = "numbOfParticiPantLabel";
            this.numbOfParticiPantLabel.Size = new System.Drawing.Size(364, 37);
            this.numbOfParticiPantLabel.TabIndex = 9;
            this.numbOfParticiPantLabel.Text = "Number of participants";
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1626, 940);
            this.Controls.Add(this.economyGroupBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.infoListBox);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.newEventGroupBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.newEventGroupBox.ResumeLayout(false);
            this.newEventGroupBox.PerformLayout();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.economyGroupBox.ResumeLayout(false);
            this.economyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox newEventGroupBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.TextBox feeParticipantsTextBox;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.TextBox costperPersonTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox countryComboList;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label lastNamrLabel;
        private System.Windows.Forms.ListBox infoListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox economyGroupBox;
        private System.Windows.Forms.Label surpDefLabel;
        private System.Windows.Forms.Label totalFeesLabel;
        private System.Windows.Forms.Label totaltCostLabel;
        private System.Windows.Forms.Label numbOfParticiPantLabel;
        private System.Windows.Forms.Label surplusDefOutput;
        private System.Windows.Forms.Label totalFeesOutput;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Label numbParticipantOutput;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label firstNameLabel;
    }
}

