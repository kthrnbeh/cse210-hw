public class SimpleClass:Goal
{
    //Attributes
    //Constructors (name, description,points)
    //SimpleGoal():base(pass in values)

     public override int RecordEvent()
    {
        //if we were not complete
        //then mark complete and return points
        //has to return an integer
        //what if we were previously complete?
        return 0;
    }

    public override bool InComplete()
    {
        //return back whether this goal is complete or not
        //return bool
        return false;
        
    }
    public override string GetStringRepresentation()
    {
        //retrun string
        return "something";
    }
}