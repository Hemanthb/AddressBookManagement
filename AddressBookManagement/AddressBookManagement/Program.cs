// See https://aka.ms/new-console-template for more information
AddressBookManagement.ContactPerson person;
AddressBookManagement.AddressBookDetails details = new AddressBookManagement.AddressBookDetails();

string yes_no = "y";
while (yes_no.ToLower() == "y")
{
    Console.WriteLine("Enter your choice -- \n1 - To add contact Details\n2 - To Edit Contacts\n3 - To delete a contact\n");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter a number to add that many contact details");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                person = new AddressBookManagement.ContactPerson();
                Console.WriteLine("Enter the First Name of a Person");
                person.FirstName = Console.ReadLine();
                Console.WriteLine("Enter the Last Name of a Person");
                person.LastName = Console.ReadLine();
                Console.WriteLine("Enter the Address of a Person");
                person.Address = Console.ReadLine();
                Console.WriteLine("Enter the City of a Person");
                person.City = Console.ReadLine();
                Console.WriteLine("Enter the State of a Person");
                person.State = Console.ReadLine();
                Console.WriteLine("Enter the Postal code of a Person");
                person.PostalCode = Console.ReadLine();
                Console.WriteLine("Enter the Phonne No. of a Person");
                person.PhoneNo = Console.ReadLine();
                Console.WriteLine("Enter the EmailId of a Person");
                person.Email = Console.ReadLine();
                details.AddPersonContacts(person);
            }
            break;
        case 2:
            details.DisplayDetails();
            Console.WriteLine("Enter the name of a person to edit contact details");
            string editContact = Console.ReadLine();
            details.EditContacts(editContact.ToLower());
            break;
        case 3:
            Console.WriteLine("Enter the name of a person to delete contact");
            string deleteContact = Console.ReadLine();
            details.DeleteContact(deleteContact.ToLower());
            break;
        default:
            Console.WriteLine("Enter a valid value from 1-3");
            break;
    }
    Console.WriteLine("Enter y to continue or n to exxit");
    yes_no = Console.ReadLine();
}
details.DisplayDetails();
