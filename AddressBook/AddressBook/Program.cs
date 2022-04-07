using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace AddressBook
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int input = 0;
            do
            {
                Console.WriteLine("Welcome To Address Book");
                Console.WriteLine("1: Office contacts");
                Console.WriteLine("2: Family contacts");
                Console.WriteLine("0: Exit");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        var office = new OfficeContacts();
                        int option = 0;
                        do
                        {
                            Console.WriteLine("1: To Add a Contact Details");
                            Console.WriteLine("2: To Compute Details");
                            Console.WriteLine("3: To Edit a Contact Details");
                            Console.WriteLine("4: To Delete Contact");
                            Console.WriteLine("5: To Search Person by using City Name");
                            Console.WriteLine("6: To count");
                            Console.WriteLine("7: To Exit");
                            try
                            {
                                option = int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        office.AddDetails();
                                        break;
                                    case 2:
                                        office.ComputeDetails();
                                        break;
                                    case 3:
                                        Console.WriteLine("Enter a First Name to Edit");
                                        string key = Console.ReadLine();
                                        office.EditDetails(key);
                                        break;
                                    case 4:
                                        office.DeleteContact();
                                        break;
                                    case 5:
                                        Console.WriteLine("Enter city");
                                        string city = Console.ReadLine();
                                        office.SearchPerson(city);
                                        break;
                                    case 6:
                                        office.Countperson();
                                        break;
                                    case 7:
                                        Console.WriteLine("Exit");
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
                        while (input != 0);
                        break;
                    case 2:
                        var family = new FamilyContacts();
                        int options = 0;
                        do
                        {
                            Console.WriteLine("1: To Add a Contact Details");
                            Console.WriteLine("2: To Compute Details");
                            Console.WriteLine("3: To Edit a Contact Details");
                            Console.WriteLine("4: To Delete Contact");
                            Console.WriteLine("5: To Search Person by using City Name");
                            Console.WriteLine("6: To Exit");


                            try
                            {
                                options = int.Parse(Console.ReadLine());
                                switch (options)
                                {
                                    case 1:
                                        family.AddDetails();
                                        break;
                                    case 2:
                                        family.ComputeDetails();
                                        break;
                                    case 3:
                                        Console.WriteLine("Enter a First Name to Edit");
                                        string key = Console.ReadLine();
                                        family.EditDetails(key);
                                        break;
                                    case 4:
                                        family.DeleteContact();
                                        break;
                                    case 5:
                                        Console.WriteLine("Enter city");
                                        string city = Console.ReadLine();
                                        family.SearchPerson(city);
                                        break;
                                    case 6:
                                        Console.WriteLine("Exit");
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
                        while (options != 0);
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                }   
            } while (input != 0);
        }
    }
}