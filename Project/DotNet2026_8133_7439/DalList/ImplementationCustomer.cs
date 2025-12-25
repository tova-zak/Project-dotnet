
using DalApi;
using DO;
using static Dal.DataSource;
using DalList;

class ImplementationCustomer : Icustomer
{

    public string Create(string CustomerId,
    string CustomerName,
    string CustomerAddress,
    string CustomerPhone)
    {
        Customer customer = new Customer(CustomerId,
     CustomerName,
     CustomerAddress,
     CustomerPhone);
        Customers.Add(customer);
        return customer.CustomerId;
    }
    public Customer? Read(string id)
    {
        foreach (Customer c in Customers)
        {
            if (c.CustomerId == id)
                return c;
        }
        return null;
    }



    public List<Customer> ReadAll()
    {
        return Customers;
    }
    public void Update(Customer item)
    {
        int itemIndex = Customers.FindIndex(p => p?.CustomerId == item.CustomerId);
        Customers[itemIndex] = item;

    }

    public void Delete(string id)
    {
        int itemIndex = Customers.FindIndex(p => p?.CustomerId == id);
        Customers.RemoveAt(itemIndex);
    }

}

