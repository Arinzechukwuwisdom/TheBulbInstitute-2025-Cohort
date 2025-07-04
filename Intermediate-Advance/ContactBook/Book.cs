using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    public class Book
    {
        public Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();

        public Contact AddContract(string name, string phoneNumber)
        {
            try
            {

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber))
                {
                    throw new ArgumentException("Name and phone number cannot be null or empty.");
                }
                if (contacts.ContainsKey(name))
                {
                    throw new InvalidOperationException("Contact with this name already exists.");
                }
                var contact = new Contact
                {
                    Name = name,
                    PhoneNumber = phoneNumber
                };
                //contacts.Add(name, contact);
                contacts[name] = contact;
                return contact;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding contact: {ex.Message}");
                return null;
            }


        }
        public string FindContact(string input)
        {
            try
            {
                //if (string.IsNullOrEmpty(input))
                //{
                //    throw new ArgumentException("Input cannot be null or empty.");
                //}
                //else if (contacts.ContainsKey(input))
                //{
                //    return contacts[input].PhoneNumber;
                //}
                //else
                //{
                //    return "Contact not found.";
                //}

                var contact = contacts.FirstOrDefault(c => c.Key.Equals(input, StringComparison.OrdinalIgnoreCase)
                || c.Value.PhoneNumber.Equals(input, StringComparison.OrdinalIgnoreCase));

                //var contact = contacts[input].PhoneNumber;
                //return contact;
                return contact.Value.PhoneNumber ?? "Contact not found.";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error finding contact: {ex.Message}");
                return null;
            }
        }
    }
}
