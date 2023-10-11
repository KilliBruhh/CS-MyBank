using Backend.Customers;
using Backend.Account;
using Backend.CurrentAccount;
using Backend.SavingsAccount;

class Program 
{
    static void Main()
    {
        // Static customer via constructor
        Customer c1 = new Customer("Jeffreyke", "0471817148", new DateTime(2002, 5, 5));
        // customer via questions in console
        Customer c2 = new Customer();

        Console.Write("Customer 1: \n");
        c1.printCustomer(c1);
        Console.Write("\nCustomer 2: \n");
        c2.printCustomer(c2);
    }

}