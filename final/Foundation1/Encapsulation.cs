using System;
using System.Collections.Generic;

class program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("Alice", address1);

        Address address2 = new Address("55 River Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Pen", "P001", 2.0, 10));
        order1.AddProduct(new Product("Notebook", "N101", 5.0, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("T-shirt", "T555", 15.0, 1));
        order2.AddProduct(new Product("Hat", "H777", 10.0, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total: $" + order1.GetTotalCost());
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total: $" + order2.GetTotalCost());

        Console.ReadLine();
    }
}

class Product
{
    private string name;
    private string id;
    private double price;
    private int quantity;

    public Product(string n, string i, double p, int q)
    {
        name = n;
        id = i;
        price = p;
        quantity = q;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetLabel()
    {
        return name + " (ID: " + id + ")";
    }
}

class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string s, string c, string st, string co)
    {
        street = s;
        city = c;
        state = st;
        country = co;
    }

    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return street + "\n" + city + ", " + state + "\n" + country;
    }
}

class Customer
{
    private string name;
    private Address address;

    public Customer(string n, Address a)
    {
        name = n;
        address = a;
    }

    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }
}

class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer c)
    {
        customer = c;
    }

    public void AddProduct(Product p)
    {
        products.Add(p);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product p in products)
        {
            total += p.GetTotalCost();
        }

        if (customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in products)
        {
            label += p.GetLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetName() + "\n" + customer.GetAddress().GetFullAddress();
    }
}
