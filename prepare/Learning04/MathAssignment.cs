using System.Dynamic;

public class MathAssignment : Assignment
//Create this class and make sure to specify that it inherits from the base Assignment class.
{//Add the attributes as private member variables. 
 // Make sure that you do not create new member variables 
 // for the ones you inherited from the base class.
    private string _textbookSection;
    private string _problems;
    //call from previous assignment program the other variables into the section.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {//Create a constructor for your class that accepts all four parameters, 
     //have it call the base class constructor to set the base class attributes that way

        _textbookSection = textbookSection;
        _problems = problems;

    }
    public string GetHomeworkList()
    {
        return $" Section{_textbookSection}  Problems{_problems}";
    }


}
//Add the GetHomeworkList() method.
//Test your class by returning to the Main method and creating a new MathAssignment object and set its values. 
//Make sure to test both the GetSummary() and the GetHomeworkList() methods.
