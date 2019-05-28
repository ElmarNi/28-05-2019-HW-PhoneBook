using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook["elm"] = "0553347347";
            phoneBook["tuncay"] = "0550505";
            Console.WriteLine(phoneBook["elm"]);
            Console.WriteLine(phoneBook["tuncay"]);
        }
    }
    public class PhoneBook
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        private int PhoneIndex;
        public PhoneBook[] phones;
        public PhoneBook()
        {
            phones = new PhoneBook[100];
        }
        public object this[string name]
        {
            get
            {
                if (name.Length >2)
                {
                    return FindPhone(name);
                }
                throw new ArgumentException("Name is too short(It must be more than 2 characters)");
            }
            set {
                phones[PhoneIndex++] = new PhoneBook
                {
                    Name = name,
                    PhoneNumber = (string)value
                };
            }
        }
        public string FindPhone(string name)
        {
            foreach (var item in phones)
            {
                if (item != null && item.Name == name)
                {
                    return item.PhoneNumber;
                }
            }
            return "Your phonebook does not exsist this person";
        }
        
    }
}
