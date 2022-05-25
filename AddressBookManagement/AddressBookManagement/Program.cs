// See https://aka.ms/new-console-template for more information
AddressBookManagement.Person person = new AddressBookManagement.Person();
AddressBookManagement.AddressBookDetails details = new AddressBookManagement.AddressBookDetails();
Console.WriteLine("Enter a number to add that many contact details");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < number; i++)
{
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