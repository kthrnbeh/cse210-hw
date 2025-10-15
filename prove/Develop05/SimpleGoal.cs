public class SimpleClass:Goal
{
    //Attributes
    //Constructors (name, description,points)
    //SimpleGoal():base(pass in values)

     public override int RecordEvent()
    {
        //has to return an integer
        return 0;
    }

    public override bool InComplete()
    {
        //return bool
        return false;
        
    }
    public override string GetStringRepresentation()
    {
        //retrun string
        return "something";
    }
}