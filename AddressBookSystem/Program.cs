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
             Createcontact contacts = new Createcontact();
            {
                contacts. First_Name = "Sachin";
                contacts. Last_Name = "Mahajan";
                contacts.Address = "Pimpri Chinchwad";
                contacts.city = "Pune";
                contacts.state = "Maharastra";
                contacts.zip = 412105;
                contacts.PhoneNo = 9370844315;
                contacts.Email = "sachinmahajan782@gmail.com";
            }
            Console.WriteLine(contacts.First_Name + "\n" + contacts.Last_Name + "\n" + contacts.Address + "\n" + contacts.city + "\n"
            + contacts.state + "\n" + contacts.zip + "\n" + contacts.PhoneNo + "\n" + contacts.Email);
            Console.ReadLine();

        }
    }
}
