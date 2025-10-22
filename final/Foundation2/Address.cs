/* 

The address contains a string for the street address, the city, state/province, and country.
The address should have a method that can return whether it is in the USA or not.
The address should have a method to return a string all of its fields together
 in one string (with newline characters where appropriate)
*/
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private int _zipCode;
    private string _country;
    public Address(string streetAddress, string city, string stateProvidence, int zipCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvidence;
        _zipCode = zipCode;
        _country = country;
    }
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetStateProvince()
    {
        return _stateProvince;
    }
    public void SetStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }
    public int GetZipCode()
    {
        return _zipCode;
    }

}