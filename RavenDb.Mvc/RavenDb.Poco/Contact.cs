using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavenDb.Poco
{
    public class Contact
    {
        public Contact()
        {
            this.Persons = new List<Person>();
        }
        public int ContactId { get; set; }
        public string Name { get; set; }
        public List<Person> Persons { get; set; }
    }

    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
