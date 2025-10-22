using System;
using System.Net.Sockets;

class Program
{//Encapsulation Part 2
    static void Main(string[] args)
    {
        Console.Write("Time to see the Order information");
          // TODO: Create at least two Address objects (USA and non-USA).
          Address address1 = new Address("825 E 12500 S", "Draper", "UT",84020, "USA");
          Address address2 = new Address("320 W 500 S", "Lindon", "UT",84042, "Canada");//oops
          
        // TODO: Create at least two Customer objects using those addresses.
        Customer customer1 = new Customer("Pierce Morgan", address1);
        Customer customer2 = new Customer("Chris Hansen", address2);
        // TODO: Create 2–3 Product objects per order with names, ids, prices, quantities.
        Product product1 = new Product("Coloring Book", "CB001", 2.99, 2);
        Product product2 = new Product("Sketch Pad", "SP002", 3.99, 1);
        Product product3 = new Product("Drawing Pencils", "DP003", 11.99, 1);
        Product product4 = new Product("Water Colors", "WC004", 2.99, 1);
        Product product5 = new Product("Paint Brushes", "PB005", 3.99, 5);

        // TODO: Create at least two Order objects with different customers.
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        // TODO: Add products to each order via AddProduct().
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total:{order1.GetTotalCost()}");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: {order2.GetTotalCost}");
        
            // TODO: For each order, display:
            //       - Packing Label (GetPackingLabel())
            //       - Shipping Label (GetShippingLabel())
            //       - Total Price (GetTotalCost())

    }
}
//https://byui-cse.github.io/cse210-course-2023/unit02/prepare.html
//https://byui-cse.github.io/cse210-course-2023/unit03/prepare.html
//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/
/*
Make sure that all member variables are private and getters, setters, and constructors are created as needed.

Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, the shipping label, 
and the total price of the order, and display the results of these methods.
*/