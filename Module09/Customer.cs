
namespace Module09
{
    public class Customer
    {
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }

        public Customer()
        {
            Name = "";
            ContactPhone = "";
            Revenue = -1;
        }
        public Customer(string name, decimal revenue, string phone)
        {
            Name = name;
            ContactPhone = phone;
            Revenue = revenue;
        }
    }
}
