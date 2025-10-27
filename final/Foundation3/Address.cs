/*Write a program that has a base Event class along with derived classes for each type of event. These classes should contain the necessary data and provide methods to return strings for each of the messages the company desires.
Remember that any data or methods that are common among all types of events should be in the base class.
Once you have the classes in place, write a program that creates at least one event of each type and sets all of their values. Then, for event event, call each of the methods to generate the marketing messages and output their results to the screen.
In addition, your program must:
Use inheritance to avoid duplicating shared attributes and methods.
Use an address class for the addresses.
Follow the principles of encapsulation, making sure each member variable is private.*/
public class Address
{
    // TODO: private fields: street, city, state/province, postalCode
    // TODO: constructor to set all fields
    // TODO: public override string ToString() to return "Street, City, ST ZIP"
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private int _zipcode;
    public Address(string street, string city, string country, string stateOrProvince, int zipcode)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _zipcode = zipcode;
        _country = country;
    }
    public string GetStreet()
    {
        return _street;

    }
    public void SetStreet(string street)
    {
        _street = street;
    }
     public string GetCity()
    {
         return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
     public string GetStateOrProvince()
    {
         return _stateOrProvince;
    }
    public void SetStateOrProvince(string stateOrProvince)
    {
        _stateOrProvince = stateOrProvince;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
     public int GetZipcode()
    {
         return _zipcode;
    }
    public void SetZipcode(int zipcode)
    {
        _zipcode = zipcode;
    }
    public string GetFullAddress()
    {
        return $"{_street},{_city},{_stateOrProvince},{_zipcode},{_country}";
    }
    


}