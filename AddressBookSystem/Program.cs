using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBookSystem Program");
            bool value = true;

            while (value)
            {
                Console.WriteLine("Please select the Options :\n" +
                    "1)Enter Details & add Contact in List\n" +
                    "2)Add new Contact\n");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddressBook address = new AddressBook();
                        Console.WriteLine(" ");
                        address.createContact();
                        break;

                    case 2:
                        AddressBook address1 = new AddressBook();
                        address1.createContact();
                        Console.WriteLine("Entered Details of Person given as :");
                        address1.Display();
                        address1.addPerson();
                        break;
                    case 3:

                        AddressBook address2 = new AddressBook();
                        bool value1 = true;

                        while (value1)
                        {
                            Console.WriteLine("Follow Steps to add details:\n" +
                               "1.addContact\n" + " 2.Edit Contact\n" +
                               "3.Display Contact\n");

                            int option = Convert.ToInt32(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    address2.addPerson();
                                    break;
                                case 2:
                                    address2.EditContact();
                                    break;

                                case 3:
                                    address2.Display();
                                    break;

                                default:

                                    value = !value;
                                    break;
                            }

                        }
                        break;

                    default:
                        Console.WriteLine("Please choice correct option");
                        break;
                }
                value = false;
                Console.WriteLine("Try Again");
                break;
            }
        }
    }
}