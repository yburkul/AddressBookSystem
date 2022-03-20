using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace AddressBook
{
    class ContactDetails
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zipcode;
        public int PhoneNumber;
        public string EmailId;
        public ContactDetails(string FirstName, string LastName, string Address, string City, string State, int Zipcode, int PhoneNumber, string EmailId)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zipcode = Zipcode;
            this.PhoneNumber = PhoneNumber;
            this.EmailId = EmailId;
        }
        public string toString()
        {
            return " Details of " + FirstName + " " + LastName + " are: " + "Address: " + Address + " City: " + City + "\n"
                                  + "                                   " + " State:   " + State + " Zipcode: " + Zipcode + "\n"
                                  + "                                   " + "Phone Number:" + PhoneNumber + "\n"
                                  + "                                   " + "EmailId: " + EmailId;
        }
    }
    class Program
    {
        private ArrayList contactDetailsList;
        private Dictionary<string, ContactDetails> contactDetailsMap;
        public Program()
        {
            contactDetailsList = new ArrayList();
            contactDetailsMap = new Dictionary<string, ContactDetails>();
        }
        public void AddDetails()
        {
            Console.WriteLine("Enter Your First name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter Your City");
            string City = Console.ReadLine();
            Console.WriteLine("Enter Your State");
            string State = Console.ReadLine();
            Console.WriteLine("Enter Your Zipcode");
            int Zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Phone number");
            int PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Email Id");
            string EmailId = Console.ReadLine();
            ContactDetails contactDetails = new ContactDetails(FirstName, LastName, Address, City, State, Zipcode, PhoneNumber, EmailId);
            contactDetailsList.Add(contactDetails);
            contactDetailsMap.Add(FirstName, contactDetails);
        }

        public void EditDetails(string First_Name)
        {
            Console.WriteLine("Enter Your First name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter Your City");
            string City = Console.ReadLine();
            Console.WriteLine("Enter Your State");
            string State = Console.ReadLine();
            Console.WriteLine("Enter Your Zipcode");
            int Zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Phone number");
            int PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Email Id");
            string EmailId = Console.ReadLine();
            ContactDetails contactDetails = new ContactDetails(FirstName, LastName, Address, City, State, Zipcode, PhoneNumber, EmailId);
            contactDetailsList.Add(contactDetails);
            contactDetailsMap[First_Name] = contactDetails;
        }
        public void ComputeDetails()
        {
            foreach (ContactDetails contact in contactDetailsList)
            {
                Console.WriteLine(contact.toString());
            }
        }
        public static void Main(string[] args)
        {
            int option = 0;
            Console.WriteLine("Welcome To Address Book");
            Program details = new Program();
            do
            {
                Console.WriteLine("Choose 1: To Add a Contact Details");
                Console.WriteLine("Choose 2: To Compute Details");
                Console.WriteLine("Choose 3: To Edit a Contact Details");
                //Console.WriteLine("Choose 0: To Exit");

                try
                {
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            details.AddDetails();
                            continue;
                        case 2:
                            details.ComputeDetails();
                            continue;
                        case 3:
                            Console.WriteLine("Enter a First Name to Edit");
                            string First_Name = Console.ReadLine();
                            details.EditDetails(First_Name);
                            break;
                        default:
                            Console.WriteLine("Wrong key");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please choose option");
                }
            }
            while (option != 0);
        }
    }
}