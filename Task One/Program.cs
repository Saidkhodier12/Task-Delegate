namespace Task_One;

internal class Program
{
    static void PerformActionOnCustomers(List<Customer> customers, Action<Customer> action)
    {
        foreach (var customer in customers)
        {
            action(customer);
        }
    }
    static void PrintCustomerDetails(Customer customer)
    {
        Console.WriteLine($"Name: {customer.Name}, Mobile: {customer.Mobile}, Email: {customer.Email}");
    }
    static void SendWelcomeEmail(Customer customer)
    {
        Console.WriteLine($"Sending welcome email to {customer.Email} Welcome, {customer.Name}!");
    }

    static void Main(string[] args)
    {
        var customers = new List<Customer>
        {
            new Customer("Alice", "0123456789", "alice@example.com"),
            new Customer("Bob", "0987654321", "bob@example.com")
        };
        
        Console.WriteLine("Customer Details:");
        PerformActionOnCustomers(customers, PrintCustomerDetails);

        Console.WriteLine("\nSending Welcome Emails:");
        PerformActionOnCustomers(customers, SendWelcomeEmail);
    }
}
