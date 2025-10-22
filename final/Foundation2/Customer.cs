/*
The customer contains a name and an address.
The name is a string, but the Address is a class.
The customer should have a method that can return whether 
they live in the USA or not. (Hint this should call a method on the address to find this.)
*/
public class Customer
{
    private string _name;
    private int _address;
    public Customer(string name, int address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public int GetAddress()
    {
        return _address;
    }
    public void SetAddress(int address)
    {
        _address = address;
    }
    
}