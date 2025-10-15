public abstract class Goal
{
    //Constuctor(name, description, points)
    public abstract int RecordEvent();

    public abstract bool InComplete();
    
    public string GetDetails()
    {
        return "details";
    }
    public abstract string GetStringRepresentation();
    
}