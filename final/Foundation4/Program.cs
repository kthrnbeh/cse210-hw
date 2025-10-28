using System;
//Polymorphism
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine();
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        Cycling cycling1 = new Cycling(DateTime.Now,"Cycling",30,6.0);
        Cycling cycling2 = new Cycling(DateTime.Now,"Cycling",90,8.6);
        Cycling cycling3 = new Cycling(DateTime.Now,"Cycling",33,5.6);
        Running running1 = new Running(DateTime.Now,"Running",89,7.9);
        Running running2 = new Running(DateTime.Now,"Running",78,1.1);
        Running running3 = new Running(DateTime.Now,"Running",55,6.7);
        Swimming swimming1 = new Swimming(DateTime.Now,"Swimming",79,6.8);
        Swimming swimming2 = new Swimming(DateTime.Now,"Swimming",18,1.9);
        Swimming swimming3 = new Swimming(DateTime.Now, "Swimming", 19, 2.8);

        // List<Activity> activities = new List<Activity>();
        // activities.Add(run);
        // activities.Add(ride);
        // activities.Add(swim);
        List<Activity> activity = new List<Activity>();
        activity.Add(running1);
        activity.Add(running2);
        activity.Add(running3);

        // ----------------------------
        // DISPLAY EACH SUMMARY
        // ----------------------------
        // foreach (Activity a in activities)
        // {
        //     Console.WriteLine(a.GetSummary());
        // }



    }
}