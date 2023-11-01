using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Address
    {
        #region Fields area
        private string city = string.Empty;
        private Country country;
        private string street = string.Empty;
        private string zipCode = string.Empty;

        #endregion

        #region Manual methods
        public Address() : this(string.Empty, string.Empty, string.Empty) //done
        {
            //calling on the third constructor with street, zip and city
        }
        public Address(Address theOther)//done
        {
            //Copy constructor for locate a new area in a memory, not using the original object
            this.street = theOther.street;
            this.zipCode = theOther.zipCode;
            this.city = theOther.city;
            this.country = theOther.country;
        }
        public Address(string street, string zip, string city) : this(street, zip, city, Country.Sverige) //done
        {}
        public Address(string street, string zip, string city, Country country)//done
        {
            this.street = street;
            zipCode = zip;
            this.city = city;
            this.country = country;
        }
        //public string GetAddressLabel()//done
        //{
        //    string addressLabel = street + Environment.NewLine;

        //    addressLabel += zipCode + " " + city;

        //    return addressLabel;
        //}
        public override string ToString() //done
        {
            //this class is to write a data that will put in a listbox to string
            string stringOut = $"{street, -30} {zipCode, -30} {city, -30}";

            return stringOut;
        }
        public bool ValidateCity() //done
        { 
            //Control so at least City is not an empty null string
            bool validCity = !string.IsNullOrEmpty(city);

            return validCity;
        }

        #endregion

        #region Property
        public string City //done
        {
            get { return city; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    city = value; 
                }   
            }
        }
        public Country Country //done
        {
            get { return country; }
            set => country = value; 
        }
        public string Street //done
        { 
            get { return street; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    street = value;
                }
            }
        }
        public string ZipCode //done
        { 
            get { return zipCode; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    zipCode = value;
                }
            }
        }

        #endregion


    }
}
