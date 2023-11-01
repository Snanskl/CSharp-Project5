using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class MainForm : Form
    {
        #region Fields area
        private EventManager eventManager;

        #endregion

        #region Main functions
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            titleTextBox.Text = string.Empty;
            costperPersonTextBox.Text = string.Empty;
            feeParticipantsTextBox.Text = string.Empty;
            firstNameLabel.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            streetTextBox.Text = string.Empty;
            cityTextBox.Text = string.Empty;
            zipCodeLabel.Text = string.Empty;
            
            infoListBox.Items.Clear();
            numbParticipantOutput.Text = string.Empty;
            totalCostOutput.Text = string.Empty;
            totalFeesOutput.Text = string.Empty;
            surplusDefOutput.Text = string.Empty;
            addGroupBox.Enabled = false;

            InitializeComboBox();
        }
        private void InitializeComboBox()//Done
        {
            string[] countryElement = Enum.GetNames(typeof(Country));

            foreach (string item in countryElement)
            { countryComboList.Items.Add(item.Replace("_", " ")); }

            countryComboList.SelectedItem = "Sverige"; //Default selection of combo box

        }
        private void Form1_Load(object sender, EventArgs e)//Done
        { CenterToScreen(); }
        #endregion

        #region Program button functions
        private void addButton_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant();//Create a new object call default constructor

            if (ReadInput(ref participant) && ReadName(ref participant))
            {
                eventManager.Participant.AddParticipant(participant);
                UpdateGUI();
                EmptyTextBoxes(addGroupBox);
            }
           

            
        }
        private void changeButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = infoListBox.SelectedIndex;
            Participant participant = eventManager.Participant.GetParticipantAt(selectedIndex);

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select the item you wanty to change", "Error!", MessageBoxButtons.OK);
            }
            else if(ReadParticipantData(ref participant))
            {
                eventManager.Participant.ChangeParticipantAt(participant,selectedIndex);
                UpdateGUI();
            }
        }
        private void createEventButton_Click(object sender, EventArgs e)
        {
            addGroupBox.Enabled = true;

            infoListBox.Items.Clear();
            CreateEvent();
        }
        private void deleteButton_Click(object sender, EventArgs e)//done??
        {
           int selectedDeleteIndex = infoListBox.SelectedIndex;

            if (selectedDeleteIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm delete", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    eventManager.Participant.DeleteParticipantAt(selectedDeleteIndex);
                    UpdateGUI();
                }
            }
        }
        private void infoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = infoListBox.SelectedIndex;

            if (selectedIndex >= 0)
            {
                Participant participant = eventManager.Participant.GetParticipantAt(selectedIndex);

                firstNameTextbox.Text = participant.FirstName;
                lastNameTextBox.Text = participant.LastName;
                streetTextBox.Text = participant.Address.Street;
                cityTextBox.Text = participant.Address.City;
                zipCodeTextBox.Text = participant.Address.ZipCode;

                countryComboList.SelectedIndex = (int)participant.Address.Country;
            }
            else
            {
                MessageBox.Show("The item you selected is invalid, try again", "Error!", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region Manual Methods
        private void CreateEvent()//Done
        { 
            eventManager = new EventManager();
            ReadTitle();

            //bool validCost = ReadCostPerPerson();
            //bool validFee = ReadFeePerPerson();

            if ((ReadFeePerPerson() == true) && (ReadCostPerPerson() == true))
            {
                addGroupBox.Enabled = true;
                UpdateGUI();
            }
        }
        private void EmptyTextBoxes(GroupBox groupbox)
        { 
            //titleTextBox.Text = string.Empty;
            //costperPersonTextBox.Text = string.Empty;
            //feeParticipantsTextBox.Text = string.Empty;
        
            firstNameTextbox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            streetTextBox.Text = string.Empty;
            cityTextBox.Text = string.Empty ;
            zipCodeTextBox.Text = string.Empty;
            countryComboList.SelectedItem = "Sverige";
        }
        private Address ReadAddress()//Done
        {
            //Ties together all data in the address object
            Address address = new Address();

            address.Street = streetTextBox.Text;
            address.City = cityTextBox.Text;
            address.ZipCode = zipCodeTextBox.Text;

            address.Country = (Country)countryComboList.SelectedIndex ;

            return address;
        }
        private bool ReadCostPerPerson()//done??
        {
            double costPerPerson = 0;

            bool validCost = double.TryParse(costperPersonTextBox.Text, out costPerPerson);

            if ((validCost) && (costPerPerson >=0))
            {
                eventManager.CostPerPerson = costPerPerson;
                validCost = true;
            }
            else
            { 
                MessageBox.Show("The cost value you given are invalid", "Error!", MessageBoxButtons.OK); 
                validCost = false;
            }

            return validCost;
        }
        private bool ReadFeePerPerson()//done
        {
            double feePerPerson = 0;

            bool validFee = double.TryParse(feeParticipantsTextBox.Text, out feePerPerson);

            if ((validFee) && (feePerPerson >= 0))
            {
                eventManager.FeePerPerson = feePerPerson;
                validFee = true;
            }
            else
            { 
                MessageBox.Show("The fee value you given is invalid", "Error!",MessageBoxButtons.OK); 
                validFee = false;
            }

            return validFee;
        }
        private bool ReadInput(ref Participant participant)//Done
        {
            bool validInput = ReadParticipantData(ref participant);

            if (!validInput )
           
            {
                MessageBox.Show("you must provide all the infomation before adding an event", "Error", MessageBoxButtons.OK);
            }

            return validInput;
        }
        private bool ReadName(ref Participant participant)//done
        {
            bool validName = false;
            string firstName = firstNameTextbox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();

            //When you pass an object as an argument to a method, it is passed by value by
            //default. This means that a copy of the object is created, and any changes made
            //to the object within the method are made to the copy, not the original object.
            //When the method returns, the original object remains unchanged.

            //However, when you use ref before the object parameter,
            //it means that you are passing the object by reference.
            //This means that the method can modify the original object,
            //rather than a copy of it.Any changes made to the object within
            //the method will be reflected in the original object when the method returns.

            //In the case of the ReadName method, ref Participant means that the
            //participant parameter is passed by reference, so any changes made to
            //the participant object within the method will be reflected in the original
            //object that was passed in as an argument.


            if ((!string.IsNullOrEmpty(firstName)) && (!string.IsNullOrEmpty(lastName)))
            {
                participant.FirstName = firstName;
                participant.LastName = lastName;
                validName = true;
            }

            return validName;

        }
        private void ReadTitle()//Done
        {
            string title = titleTextBox.Text;

            if (!string.IsNullOrEmpty(title))
            {
                eventManager.Title = title;
                this.Text = $"{eventManager.Title} By Ploypailin Junker";
            }
            else
            {
                eventManager.Title = "Unnamed event";
                this.Text = $"Unnamed event By Ploypailin Junker";
            }
        }
        private bool ReadParticipantData(ref Participant participant)//Done
        {
            participant.FirstName = firstNameTextbox.Text;
            participant.LastName = lastNameTextBox.Text;

            Address address = ReadAddress();

            participant.Address = address;

            bool validAddress = address.ValidateCity();

            return validAddress;
        
        }
        private void UpdateGUI()//Done
        {
            string[] updateArr = eventManager.Participant.GetParticipantsInfo();

            if (updateArr != null)
            {
                infoListBox.Items.Clear();
                infoListBox.Items.AddRange(updateArr);
                numbParticipantOutput.Text = infoListBox.Items.Count.ToString();
            }

            double totalCost = eventManager.CalcTotalCost();
            totalCostOutput.Text = totalCost.ToString("0.00");
            numbParticipantOutput.Text = eventManager.Participant.Count.ToString();

            double totalFee = eventManager.CalcTotalFees();
            totalFeesOutput.Text = totalFee.ToString("0.00");
            surplusDefOutput.Text = (totalFee - totalCost).ToString("0.00");
        }


        #endregion
    }
}
