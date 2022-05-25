using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagement
{
    public class AddressBookDetails
    {
        List<ContactPerson> persons = new List<ContactPerson>();

        public void AddPersonContacts(ContactPerson person)
        {
            persons.Add(person);
        }

        public void EditContacts(String name)
        {

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            ContactPerson editContact = persons.FirstOrDefault(x => x.FirstName.ToLower() == name);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (editContact != null)
            {
               
                string opt = "Y";
                while(opt.ToUpper() == "Y") 
                {
                    Console.WriteLine("Enter 1 - to edit first name\n2 - to edit last name\n3 - to edit Address\n" +
                    "4 - to edit city\n5 - to edit state\n6 - to edit PostalCode\n7 - to edit phoneNo\n8 - to edit EmailId");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the new First Name of a Person");
                        editContact.FirstName = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the new Last Name of a Person");
                        editContact.LastName = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter the new Address of a Person");
                        editContact.Address = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter the new City of a Person");
                        editContact.City = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Enter the new state of a Person");
                        editContact.State = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Enter the new Postal code of a Person");
                        editContact.PostalCode = Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Enter the new Phone no of a Person");
                        editContact.PhoneNo = Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Enter the new EmailId of a Person");
                        editContact.Email = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Sorry!!Enter a num from 1-8 to edit details");
                        break;
                }
                Console.WriteLine("Enter Y to edit any other details too...");
                opt = Console.ReadLine();
            }
               
                Console.WriteLine("details of person are");
                Console.WriteLine(editContact.FirstName);
                Console.WriteLine(editContact.LastName);
                Console.WriteLine(editContact.Address);
                Console.WriteLine(editContact.City);
                Console.WriteLine(editContact.State);
                Console.WriteLine(editContact.PostalCode);
                Console.WriteLine(editContact.PhoneNo);
                Console.WriteLine(editContact.Email);
            }
            else
            {
                Console.WriteLine("No Details Exist!");
            }
        }

        public void DeleteContact(string contactName)
        {
            ContactPerson deleteContact = persons.FirstOrDefault(x => x.FirstName.ToLower() == contactName);
            if(deleteContact != null)
            {
                Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)"+deleteContact.FirstName);
                
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    persons.Remove(deleteContact);
                    Console.WriteLine("Contacts of {0} removed from book", contactName);
                }
            }
            else
            {
                Console.WriteLine("No Details Exist!");
            }
        }
        
        public void DisplayDetails()
        {
            foreach (ContactPerson person in persons)
            {
                Console.WriteLine("Contact Details of - "+person.FirstName);
                Console.WriteLine("Last Name          -"+person.LastName);
                Console.WriteLine("Address            -" + person.Address);
                Console.WriteLine("City               -" + person.City);
                Console.WriteLine("State              -" + person.State);
                Console.WriteLine("Zipcode            -" + person.PostalCode);
                Console.WriteLine("Phone No           -" + person.PhoneNo);
                Console.WriteLine("Email Id           -" + person.Email);
                Console.WriteLine();
            }
        }
    }
}
