namespace Backend.Customers;

public class Customer
{
    static int currentId = 0;

    public int Id { get; }
    public string Name { get; set; }
    public string ContactPhoneNumber { get; set; }
    public DateTime Birthday { get; set; }

    // Define customers data in console
    public Customer(string name, string contactphonenumber, DateTime birthday)
    {
        Id = currentId;
        Name = name;
        ContactPhoneNumber = contactphonenumber;
        Birthday = birthday;
    }

    // Create new customer by user
    public Customer() 
    {
        Id = currentId++;

        Console.Write("Enter customer name: ");
        Name = Console.ReadLine();
        Console.Write("Enter customer Phone: ");
        ContactPhoneNumber = Console.ReadLine();
        Console.Write("Enter customer Birthday: (YYYY-MM-DD)");

        bool dataValid = false;
        while (!dataValid)
        {
            if(DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
            {
                Birthday = birthday;
                dataValid  = true;
            }
            else 
            {
                Console.Write("Incorrect Date Template");
            }   
        }        
    }

    public void printCustomer(Customer c)
    {
        Console.WriteLine("Name: " + c.Name);
        Console.WriteLine("Contact Phone: " + c.ContactPhoneNumber);
        Console.WriteLine("Birthday: " + c.Birthday);
    }

}
