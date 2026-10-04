public class CustomerService
{
    public Customer GetCustomer(int customerId)
    {
        Console.WriteLine("Getting customer...");
        return new Customer(customerId, "Nitesh");
    }
}