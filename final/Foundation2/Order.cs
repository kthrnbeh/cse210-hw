/*
Contains a list of products and a customer. Can calculate the total cost of the order. 
Can return a string for the packing label. Can return a string for the shipping label.
The total price is calculated as the sum of the total cost of each product plus 
a one-time shipping cost.
This company is based in the USA. 
If the customer lives in the USA, then the shipping cost is $5. 
If the customer does not live in the USA, then the shipping cost is $35.
A packing label should list the name and product id of each product in the order.
A shipping label should list the name and address of the customer
*/
public class Order //so glad I did so much reading yesterday and today on encapsulation..
{
    private List<Product> _products = new List<Product>();
    private string _customer;
    private string _address;
    public Order(List<Product> products, string customer)
    {
        _products = products;
        _customer = customer;
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
    public void SetProductId(List<Product> products)
    {
        _products = products;
    }
    public string GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(string customer)
    {
        _customer = customer;
    }
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        double shippingCost = 0;
        if (_customer.Contains("USA"))//could use IndexOf instead but decided its better in case its lowercase
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return totalCost + shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product)
    }

    
}//https://www.dotnetperls.com/contains