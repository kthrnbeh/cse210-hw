public abstract class Events
{
    // Private fields (encapsulation)
    private string _type;
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Events(string type, string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetEventType() //needed to get type
    {
        return _type;
    }

    public void SetEventType(string type)
    {
        _type = type;
    }
     public string GetTitle()
    {
        // TODO: return the _title
        return $"{_title}";
    }

    public void SetTitle(string title)
    {
        // TODO: set _title = title
        _title = title;
    }

    public string GetDescription()
    {
        // TODO: return the _description
        return $"{_description}";
    }

    public void SetDescription(string description)
    {
        // TODO: set _description = description
        _description = description;
    }

    public DateTime GetDate()
    {
        // TODO: return the _date
        return _date;
    }

    public void SetDate(DateTime date)
    {
        // TODO: set _date = date
        _date = date;
    }

    public TimeSpan GetTime()
    {
        // TODO: return the _time
        return _time;
    }

    public void SetTime(TimeSpan time)
    {
        // TODO: set _time = time
        _time = time;
    }

    public Address GetAddress()
    {
        // TODO: return the _address
        return _address;
    }

    public void SetAddress(Address address)
    {
        // TODO: set _address = address
        _address = address;
    }

    public string GetStandardDetails()
    {
        // TODO:
        // 1. Format date: _date.ToString("MM/dd/yyyy")
        // 2. Format time: DateTime.Today.Add(_time).ToString("h:mm tt")
        // 3. Use _address.ToString() (Address class handles formatting)
        // 4. Combine and return all parts:
        //    Title, Description, Date, Time, Address (each on its own line)
        string date =_date.ToString("MM/dd/yyyy");
        string time =DateTime.Today.Add(_time).ToString("h:mm tt"); //I always forget "" then it won't work and I get frustrated...
        string address=_address.ToString();
        return $" +{ _type}+
        +{ _title} +
        { _description} +
        {_date} +
        {_time} +
        {_address}"; //looking up how to put them on their own line... 
        //oh yes \n
    }

    public virtual string GetAllDetails()
    {
        // TODO:
        // 1. Start with GetStandardDetails()
        // 2. Append "\nType: " + this.GetType().Name // I have no idea what this is so I looked it up... https://www.geeksforgeeks.org/c-sharp/c-sharp-this-keyword/
        // 3. Derived classes (Lecture, Reception, OutdoorGathering) will override this
        //    and add their unique fields (Speaker, RSVP, Weather)
       
        return $"{ GetStandardDetails()}";
    }

    public string GetShortDescription()
    {
        // TODO:
        // 1. Format date string: _date.ToString("MM/dd/yyyy")
        // 2. Get type name: this.GetType().Name
        // 3. Return something like:
        //    $"{this.GetType().Name}: {_title} — {_date.ToString("MM/dd/yyyy")}"
        

        return $"{_type} {_title} {_date.ToString("MM/dd/yyyy")}";
    }

    
   

}