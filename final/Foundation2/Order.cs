using System;

class Order{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;

    public Order(Customer c){
        this._customer = c;
    }

    public void PackingLabel(){
        Console.WriteLine($"Customer: {_customer.GetCustomerName()}");
        Console.WriteLine("");
        Console.WriteLine("Products:");
        foreach(Product product in _productList){
            Console.WriteLine($"> {product.GetProductId()}");
        }
    }

    public void ShippingLabel(){
        Console.WriteLine($"Customer Name: {_customer.GetCustomerName()}");        
        Console.WriteLine($"Address: {_customer.GetCustomerAddress().GetAddress()}");
        Console.WriteLine("");
    }

    public double TotalPrice(bool insideUS){       
        double productTotalCost =0;
        int shippingCost;

        foreach (Product product in _productList)
        {
            productTotalCost += product.TotalCost(product.GetProductPrice(),product.GetProductQuantity());            
        }        
        
        if (insideUS){
            shippingCost = 5;
        }            
        else{
            shippingCost = 35;
        }

        Console.WriteLine("");
        Console.WriteLine($"Sub Total: {productTotalCost}");
        Console.WriteLine($"Shipping Cost: {shippingCost}");     
        Console.WriteLine("");   
                    
        return productTotalCost + shippingCost;
        
    }

    public void AddProduct(Product p){
        this._productList.Add(p);
    }   

    
}