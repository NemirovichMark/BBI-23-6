using System;
using System.Collections.Generic;
public abstract class Task_1
{
    public class Contact {
        protected string firstName;
        protected string lastName;
        protected string phoneNumber;
        protected string emailAddress;
        protected Guid uniqueID;
        public Contact(string fName, string lName, string pNumber, string eAddress) 
        {
            this.firstName = fName;
            this.lastName = lName;
            this.phoneNumber = pNumber;
            this.emailAddress = eAddress;
            this.uniqueID = Guid.NewGuid();
        }
        public string FirstName 
        {
            get 
            {
                return this.firstName;
            }
        }
        public string LastName 
        {
            get 
            {
                return this.lastName;
            }
        }
        public string PhoneNumber 
        {
            get 
            {
                return this.phoneNumber;
            }
        }
        public string EmailAddress 
        {
            get 
            {
                return this.emailAddress;
            }
        }
        public Guid UniqueID 
        {
            get 
            {
                return this.uniqueID;
            }
        }
        public virtual void logContact() {
            Console.WriteLine(String.Format("{0,10} | {1,10} | {2,15} | {3,20} | {4,20}",this.firstName,this.lastName,this.phoneNumber,this.emailAddress, this.uniqueID));
        }
    }
    public class Employee : Contact {
        private DateTime employmentStartAt;
        private int payAmount;
        public Employee(string fName, string lName, string pNumber, string eAddress, DateTime eStartAt, int pAmount) : base(fName, lName, pNumber, eAddress)
        {
            this.employmentStartAt = eStartAt;
            this.payAmount = pAmount;
        }
        public DateTime EmploymentStartAt 
        {
            get 
            {
                return this.employmentStartAt;
            }
        }
        public int PayAmount {
            get {
                return this.payAmount;
            }
        }
        public override void logContact() 
        {
             Console.WriteLine(String.Format("{0,10} | {1,10} | {2,15} | {3,20} | {4,20} | {5,20} | {6,20}",this.firstName,this.lastName,this.phoneNumber,this.emailAddress, this.uniqueID, this.employmentStartAt,this.payAmount));
        }   
        
    }
    public class Counteragent: Contact {
        private int contractPrice;
        private int contractTerm;
         public Counteragent(string fName, string lName, string pNumber, string eAddress, int cPrice, int cTerm) : base(fName, lName, pNumber, eAddress)
        {
            this.contractPrice = cPrice;
            this.contractTerm = cTerm;
        }
        public int ContractPrice {
            get {
                return this.contractPrice;
            }
        }
        public int ContractTerm {
            get {
                return this.contractTerm;
            }
        }
        public override void logContact() 
        {
             Console.WriteLine(String.Format("{0,10} | {1,10} | {2,15} | {3,20} | {4,20} | {5,20} | {6,20} | {7,20} | {8,20}",this.firstName,this.lastName,this.phoneNumber,this.emailAddress, this.uniqueID, "-","-",this.contractPrice,this.contractTerm));
        }   
    }
    public static void Main(string[] args)
    {
        List<Contact> contactList = new List<Contact>();
        Contact c1 = new Contact("Check","Check","78004221531","check@gmail.com");
        Contact c2 = new Employee("Aheck","Check","78004221531","check@gmail.com", new DateTime (2020,1,1),1000);
        Contact c3 = new Counteragent("Bheck","Check","78004221531","check@gmail.com",100,10000);
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
        Console.WriteLine(String.Format("{0,10} | {1,10} | {2,15} | {3,20} | {4,20} | {5,20} | {6,20} | {7,20} | {8,20}","First Name","Last Name","Phone Number","Email Address", "Unique ID", "Employment Start At", "Employee pay amount", "Contract price", "Contract term"));
        for (int i = 0; i <contactList.Count;++i) {
            contactList[i].logContact();
        }
    }
}
