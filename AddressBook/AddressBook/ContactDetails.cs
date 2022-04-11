using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class ContactDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailId { get; set; }
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
        public override string ToString()
        {
            return " Details of " + FirstName + " " + LastName + " are: " + "Address: " + Address + " City: " + City + "\n"
                                  + "                                   " + " State:   " + State + " Zipcode: " + Zipcode + "\n"
                                  + "                                   " + "Phone Number:" + PhoneNumber + "\n"
                                  + "                                   " + "EmailId: " + EmailId;
        }
    }
}