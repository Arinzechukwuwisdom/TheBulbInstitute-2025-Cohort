namespace OOP_contd_.models
{
    public class Customer : BaseEntity
    {
        public Customer()
        {

        }
        public Customer(int id)
        {
            Id = id;
        }
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Customer(int id, string name, string email, string phoneNumber)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return $"Customer ID: {Id}, Name: {Name}, Email: {Email}, Phone: {PhoneNumber}";
        }
    }
}
