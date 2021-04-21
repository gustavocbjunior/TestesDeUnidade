namespace Store.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string name, string email)
        {
            Name = name;
            email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}