using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raven.Client;
using Raven.Client.Document;
using RavenDb.Poco;
using System.Collections.Generic;

namespace RavenDB.UnitTest
{
    [TestClass]
    public class RavenDbUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //We need a document store and a session to connect to RavenDB server
            using (var documentStore = new DocumentStore(){Url="http://localhost:8080"}.Initialize())
            {
                //create a session
                using (var session = documentStore.OpenSession())
                {                   
                    Contact ct = new Contact();
                    ct.ContactId = 1;
                    ct.Name = "Work";
                    List<Person> persons = new List<Person>
                    {
                       new Person{PersonId  =1,FirstName = "Rennish",LastName = "Joseph"},
                       new Person{PersonId  =2,FirstName = "Anupama",LastName = "Joseph"},
                       new Person{PersonId  =3,FirstName = "Nathan",LastName = "Joseph"}
                    };

                    ct.Persons.AddRange(persons);
                    session.Store(ct);
                    //this gets saved to the RavenDB
                    session.SaveChanges();
                }
            }
        }
    }
}
