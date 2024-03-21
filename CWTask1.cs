using System;
using System.Collections.Generic;
public class Task_1
{
    public class Contact {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string emailAddress;
        private Guid uniqueID;
        public Contact(string fName, string lName, string pNumber, string eAddress) {
            this.firstName = fName;
            this.lastName = lName;
            this.phoneNumber = pNumber;
            this.emailAddress = eAddress;
            this.uniqueID = Guid.NewGuid();
        }
        public string FirstName {
            get {
                return this.firstName;
            }
        }
        public string LastName {
            get {
                return this.lastName;
            }
        }
        public string PhoneNumber {
            get {
                return this.phoneNumber;
            }
        }
        public string EmailAddress {
            get {
                return this.emailAddress;
            }
        }
        public Guid UniqueID {
            get {
                return this.uniqueID;
            }
        }
        public void logContact() {
            Console.WriteLine(String.Format("{0,10} | {1,10} | {2,15} | {3,20} | {4,20}",this.firstName,this.lastName,this.phoneNumber,this.emailAddress, this.uniqueID));
        }
    }
    public static void Main(string[] args)
    {
        List<Contact> contactList = new List<Contact>();
        Contact c1 = new Contact("Check","Check","78004221531","check@gmail.com");
        Contact c2 = new Contact("Aheck","Check","78004221531","check@gmail.com");
        Contact c3 = new Contact("Bheck","Check","78004221531","check@gmail.com");
        Contact c4 = new Contact("Jheck","Check","78004221531","check@gmail.com");
        Contact c5 = new Contact("Check","Aheck","78004221531","check@gmail.com");

        contactList.Add(c1);
        contactList.Add(c2);
        contactList.Add(c3);
        contactList.Add(c4);
        contactList.Add(c5);
        
        for (int i = 0; i < contactList.Count; ++i) 
        {
            for (int j = i + 1; j < contactList.Count; ++j) 
            {
                if (String.Compare(contactList[i].FirstName,contactList[j].FirstName) > 0|| contactList[i].FirstName == contactList[j].FirstName && String.Compare(contactList[i].LastName,contactList[j].LastName) > 0) 
                {
                    Contact buf = contactList[i];
                    contactList[i] = contactList[j];
                    contactList[j] = buf;
                }
            }
        }
        Console.WriteLine(String.Format("{0,10} | {1,10} | {2,15} | {3,20} | {4,20}","First Name","Last Name","Phone Number","Email Address", "Unique ID"));
        for (int i = 0; i <contactList.Count;++i) {
            contactList[i].logContact();
        }
    }
}
