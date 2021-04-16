using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private DateTime _birthDate;
        [Column(TypeName = "datetime2")]
        public DateTime BirthDate
        {
            set
            {
                int age = CalculateAge(value);

                if (age < 0 || age > 120)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    _birthDate = value;
                }
            }
            get { return _birthDate; }
        }
        public int Age { get; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        //public List<int> PhoneNumbers { get; } = new List<int>();
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Phone> PhoneNumbers { get; set; } = new List<Phone>();

        public Customer() { }

        public Customer(int id, string firstName, string lastName, DateTime birthDate, string address, int zipCode, string city, Phone[] phoneNumbers)
        {
            CustomerId = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Age = CalculateAge(birthDate);
            Address = address;
            ZipCode = zipCode;
            City = city;

            if (phoneNumbers != null)
            {
                foreach (Phone phone in phoneNumbers)
                {
                    AddPhone(phone);
                }
            }
        }

        public void AddPhone(Phone phone)
        {
            PhoneNumbers.Add(phone);
        }

        public static int CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }
    }
}
