/*
Contains the name, product id, price per unit, and quantity of each product.
The total cost of this product is computed by multiplying the price per unit and the quantity. 
If the price per unit was $3 and they bought 5, the product total cost would be $15.
*/
public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;

    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;

    }
    public string GetProductId()
    {
        return _productId;
    }
    public void SetProductId(string productId)
    {
        _productId = productId;
    }
    public double GetPricePerUnit()
    {
        
    }
}