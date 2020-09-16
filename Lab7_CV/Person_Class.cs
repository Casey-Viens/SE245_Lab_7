using Lab5_CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CV
{
    public class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;
        private string feedback;

        public string Feedback
        {
            get
            {
                return feedback;
            }
            set
            {
                feedback = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                //Checks the first name data for bad words
                if(!Validation_Library.BadWords(value))
                {
                    firstName = value;
                }
                else
                {
                    Feedback += "\nError: First Name contains a bad word.";
                }
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                //Checks the middle name data for bad words
                if (!Validation_Library.BadWords(value))
                {
                    middleName = value;
                }
                else
                {
                    Feedback += "\nError: Middle Name contains a bad word.";
                }
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                //Checks the last name data for bad words
                if (!Validation_Library.BadWords(value))
                {
                    lastName = value;
                }
                else
                {
                    Feedback += "\nError: Last Name contains a bad word.";
                }
            }
        }
        public string Street1
        {
            get
            {
                return street1;
            }
            set
            {
                street1 = value;
            }
        }
        public string Street2
        {
            get
            {
                return street2;
            }
            set
            {
                street2 = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                //Ensures teh State data is two characters long
                if (value.Length == 2)
                {
                    state = value;
                }
                else
                {
                    Feedback += "\nError: The State needs to be abbreviated. EX: CT";
                }
            }
        }
        public string Zip
        {
            get
            {
                return zip;
            }
            set
            {
                //Ensures the data in contact.Zip is equal to 5 digits and therefore not an areacode
                if (value.Length == 5 && value.All(char.IsDigit))
                {
                    zip = value;
                }
                else
                {
                    Feedback += "\nError: The zipcode needs to be 5 digits.";
                }
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                //Removes all "-" from the data in contact.Phone
                string tempPhone = value.Replace("-", "");
                //Ensures the phone number is the right number of characters
                if (tempPhone.Length == 10 && tempPhone.All(char.IsDigit))
                {
                    phone = tempPhone;
                }
                else
                {
                    Feedback += "\nError: The phone number needs to be 10 digits.";
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                //Ensures the email entered is valid based on the 2@2.2 rule
                int atLocation = value.IndexOf("@");
                int periodLocation = value.LastIndexOf(".");
                if (value.Length >= 8 && atLocation >= 2 && (periodLocation + 3) <= value.Length)
                {
                    email = value;
                }
                else
                {
                    Feedback += "\nError: The email entered does not meet the 2@2.2 format.";
                }
            }
        }

        //Constructor for the Person class to fill the variables with empty strings.
        public Person()
        {
            firstName = "";
            middleName = "";
            lastName = "";
            street1 = "";
            street2 = "";
            city = "";
            state = "";
            zip = "";
            phone = "";
            email = "";
            feedback = "";
        }
    }
}
