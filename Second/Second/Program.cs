using System;
using System.Collections;

namespace Second
{
    class Program
    {
        private static ArrayList contacts = new ArrayList();
        static void Main(string[] args)
        {
            OpenMenu();
        }

        static void OpenMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine(" Input number of operation(1-all contacts, 2-add new contact):");
            string number = Console.ReadLine();
            switch (number)
            {
                case "1": GetAllContacts();
                    break;
                case "2": AddNewContact();
                    break;
            }
        }

        static void AddNewContact()
        {
            Console.WriteLine("Adding new contact");
           string fullName;
            string personalPN;
            string mobilePN;
            string about;

            Console.WriteLine("Input contact full name:");
            fullName = Console.ReadLine();
            Console.WriteLine("Input contact personal phone number:");
            personalPN = Console.ReadLine();
            Console.WriteLine("Input contact mobile phone number:");
            mobilePN = Console.ReadLine();
            Console.WriteLine("Input some information about contact:");
            about = Console.ReadLine();

            contacts.Add(new Contact(fullName, personalPN, mobilePN, about));
            Console.WriteLine("\nContact added.");
            GetAllContacts();
        }

        static void GetAllContacts()
        {
            Console.WriteLine("Contacts");
            int count = 1;
            foreach(Contact contact in contacts)
            {
                Console.WriteLine("Number: " + count);
                Console.WriteLine("\t Full name: " + contact.FullName);
                Console.WriteLine("\t About: " + contact.About);
                Console.WriteLine("\t Personal phone number: " + contact.PersonalPN);
                Console.WriteLine("\t Mobile phone number: " + contact.MobilePN + "\n");
                count++;
            }
            Console.WriteLine("Input number of operation(1-back to menu, 2-delete contact):");
            string number = Console.ReadLine();
            switch (number)
            {
                case "1": OpenMenu();
                    break;
                case "2": DeleteContact();
                    break;
            }
        }

        static void DeleteContact()
        {
            Console.WriteLine("Deleting contact");
            Console.WriteLine("Input contact number you want to delete (0-back to contacts):");
            int number = int.Parse(Console.ReadLine());
            if (number != 0) {
                contacts.RemoveAt(number - 1);
                Console.WriteLine("Contact deleted.");
            }
            GetAllContacts();
        }
    }
}
