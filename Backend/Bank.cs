namespace Backend;

using Backend.Customers;


public class Bank
{
    public List<Customer> CustomerList {get;} = new ();

    public Bank() {}

    // Add Qustomer via Questions
    public Customer CreateCustomer() 
    {
        Customer c = new Customer();
        CustomerList.Add(c);
        return c;
    }

    
}
