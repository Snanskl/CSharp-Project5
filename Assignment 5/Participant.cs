using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Participant
    {
        #region Fields area
        private Address address;
        private string firstName = string.Empty;
        private string lastName = string.Empty;

        #endregion

        #region Manual Methods
        public Participant(): this (null, "", "") // default chain calling
        { 
            address = new Address(); 
        }
        public Participant(Participant theOther)//done
        { 
            this.firstName = theOther.firstName;
            this.lastName = theOther.lastName;
            this.address = new Address(theOther.address); //will send to copy constructor in Address class
        }
        public Participant(Address address, string firstName, string lastName) //done
        {
            this.firstName = firstName;
            this.lastName = lastName;

            if (address != null)
            {
                this.address = address;
            }
            else
            { address = new Address(); } //recreate address again if it is null(loop)
        }
        public override string ToString()//done
        {
            //return a string that will be put out in a listbox
            //This method  can in turn  call the ToString() method in the Address class
            string stringOut = $"{FullName, -50} {address.ToString()}";

            return stringOut; 
        }
        //public bool ValidateName()//done
        //{
        //    //Check so that the name are not empty
        //    bool validName = false;

        //    if ((!string.IsNullOrEmpty(lastName)) && (!string.IsNullOrEmpty(firstName)))
        //    {
        //        validName = true;
        //    }
        //    return validName;
        //}

        #endregion

        #region Property area
        public Address Address //done
        {
            get { return address; }
            set { address = value; } 
        }
        public string FirstName //done
        {
            get { return firstName; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                { 
                    firstName = value;
                }
            }
        }
        public string LastName//done
        { 
            get { return lastName; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    lastName = value; 
                }
            }
        }
        public string FullName 
        {
            get { return $"{lastName},  {firstName}"; }
        }


        #endregion
    }
}
