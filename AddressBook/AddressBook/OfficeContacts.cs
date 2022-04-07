using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class OfficeContacts
    {
        private ArrayList contactDetailsList;
        private Dictionary<string, ContactDetails> contactDetailsMap;
        public OfficeContacts()
        {
            contactDetailsList = new ArrayList();
            contactDetailsMap = new Dictionary<string, ContactDetails>();
        }
        public void AddDetails()
        {
            int noOfPersons;
            Console.WriteLine("Enter a number of Persons to Add");
            noOfPersons = int.Parse(Console.ReadLine());
            for (int i = 1; i <= noOfPersons; i++)
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
        }
        public void ComputeDetails()
        {
            foreach (KeyValuePair<string, ContactDetails> item in contactDetailsMap)
            {
                Console.WriteLine(item.Value);
            }
        }
        public void EditDetails(string key)
        {
            if (contactDetailsMap.ContainsKey(key))
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
                contactDetailsMap[key] = contactDetails;
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter The Key to Delete Contact ");
            string input = Console.ReadLine();
            if (contactDetailsMap.ContainsKey(input))
            {
                contactDetailsMap.Remove(input);
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }
    }
}
