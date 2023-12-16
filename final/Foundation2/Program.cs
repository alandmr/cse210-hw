using System;

class Program
{
    static void Main(string[] args)
    {
        // DATA FOR ORDER1
        Address address1 = new Address("Av 3","Guayana","Bolivar","Venezuela",false);
        Customer customer1 = new Customer("Aland Muñoz",address1);        
        Order order1 = new Order(customer1);
        
        Product product1 = new Product("Milk","0001",3.41,2); 
        Product product2 = new Product("Bread","B002",1.00,5); 
        Product product3 = new Product("Orange Juice","J010",2.15,1); 

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // DATA FOR ORDER2
        Address address2 = new Address("Av Lehi","Saratoga","Utah","United States",true);
        Customer customer2 = new Customer("Luis Muñoz",address2);        
        Order order2 = new Order(customer2);

        Product product4 = new Product("Meat","M015",10.46,1); 
        Product product5 = new Product("Fresh Chicken","C001",8.90,4); 
        Product product6 = new Product("Wheat Flour","F005",1.25,3);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // DISPLAYING ORDER 1
        Console.Clear();
        Console.WriteLine("****** PACKING LABEL ******");
        order1.PackingLabel();
        Console.WriteLine("");
        Console.WriteLine("****** SHIPPING LABEL ******");
        order1.ShippingLabel();        
        Console.WriteLine("****** TOTAL ******");
        Console.WriteLine($"Total price of products: {order1.TotalPrice(customer1.GetCustomerAddress().GetInsideUS())}");
        
        Console.WriteLine("");
        Console.WriteLine("");
        // DISPLAYING ORDER 2
        Console.WriteLine("****** PACKING LABEL ******");
        order2.PackingLabel();
        Console.WriteLine("");
        Console.WriteLine("****** SHIPPING LABEL ******");
        order2.ShippingLabel();        
        Console.WriteLine("****** TOTAL ******");
        Console.WriteLine($"Total price of products: {order2.TotalPrice(customer2.GetCustomerAddress().GetInsideUS())}");
        

        
    }
}