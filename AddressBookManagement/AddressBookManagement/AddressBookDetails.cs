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
    }
}
