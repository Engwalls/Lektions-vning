using System;
using System.Collections.Generic;
using System.Text;

namespace Lektionsövning
{
    class Customer
    {
        private int id;
        private string firstname;
        private string lastname;
        private string email;
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("ID får inte vara negativt");
                }
                else
                {
                    this.id = value;
                }
            }
        }

        public string FirstName
        {
            get
            {
                //return this.firstname;
                if (string.IsNullOrEmpty(firstname))
                {
                    return "No first Name";
                }
                return firstname;
            }
            set
            {
                //if (string.IsNullOrEmpty(firstname))
                //{
                //    Console.WriteLine("No first Name");
                //}
                //else
                //{
                //    this.firstname = value;
                //}
                this.firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastname;
            }
            set
            {
                if (string.IsNullOrEmpty(lastname))
                {
                    Console.WriteLine("No last Name");
                }
                else
                {
                    this.lastname = value;
                }
            }
        }



        public Customer(int id, string firstname, string lastname, string email)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }
        public Customer()
        {

        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Email is empty");
                }
                else
                {
                    this.email = value;
                }
            }
        }
        public override string ToString()
        {
            return "ID: " + id + " Firstname: " + firstname + " Lastname: " + lastname + " Email: " + email;
        }
    }
}

