public abstract class Events
{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected TimeSpan _time;
    protected Address _address; //because of the file I need to get it from

    public Events(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }
     public string GetTitle()
    {
        // TODO: return the _title
        return "";
    }

    public void SetTitle(string title)
    {
        // TODO: set _title = title
    }

    public string GetDescription()
    {
        // TODO: return the _description
        return "";
    }

    public void SetDescription(string description)
    {
        // TODO: set _description = description
    }

    public DateTime GetDate()
    {
        // TODO: return the _date
        return default;
    }

    public void SetDate(DateTime date)
    {
        // TODO: set _date = date
    }

    public TimeSpan GetTime()
    {
        // TODO: return the _time
        return default;
    }

    public void SetTime(TimeSpan time)
    {
        // TODO: set _time = time
    }

    public Address GetAddress()
    {
        // TODO: return the _address
        return null;
    }

    public void SetAddress(Address address)
    {
        // TODO: set _address = address
    }

    public string GetStandardDetails()
    {
        // TODO:
        // 1. Format date: _date.ToString("MM/dd/yyyy")
        // 2. Format time: DateTime.Today.Add(_time).ToString("h:mm tt")
        // 3. Use _address.ToString() (Address class handles formatting)
        // 4. Combine and return all parts:
        //    Title, Description, Date, Time, Address (each on its own line)
        return "";
    }

    public virtual string GetAllDetails()
    {
        // TODO:
        // 1. Start with GetStandardDetails()
        // 2. Append "\nType: " + this.GetType().Name
        // 3. Derived classes (Lecture, Reception, OutdoorGathering) will override this
        //    and add their unique fields (Speaker, RSVP, Weather)
        return "";
    }

    public string GetShortDescription()
    {
        // TODO:
        // 1. Format date string: _date.ToString("MM/dd/yyyy")
        // 2. Get type name: this.GetType().Name
        // 3. Return something like:
        //    $"{this.GetType().Name}: {_title} — {_date.ToString("MM/dd/yyyy")}"
        return "";
    }

    // OPTIONAL helper if you want to identify type separately (not required)
    public string EventType()
    {
        // TODO: Return the event’s runtime type name
        // Example: return this.GetType().Name;
        return "";
    }

}