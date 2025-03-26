using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Constructors
{
    public class Account
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phoneNumber;
        private string _address;



        //Properties
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set {_lastName = value; } }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string DateCreated { get; set; } = DateTime.Now.ToString();

        public Account()
        {
            
        }

        public Account(string firstname, string lastname)
        {
            _firstName = firstname;
            _lastName = lastname;
           
        }
        public Account(string firstname, string lastname, string email)
        {
            
        }
        
        public Account(string firstname, string lastname, string email, string phoneNumber)
        {
            
        }

        public Account(string firstname, string lastname, string email, string phoneNumber, string address)
        {

        }

        


        public void DisplayName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public void Do(int num)
        {

        }

        public void Do(int num, string name)
        {

        }
    }
}
