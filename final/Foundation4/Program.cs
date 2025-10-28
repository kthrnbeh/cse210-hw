using System;
//Polymorphism
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine();
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        Cycling cycling1 = new Cycling(DateTime.Now,"Cycling",3.0,6.0);
        Cycling cycling2 = new Cycling(DateTime.Now,"Cycling",9.0,8.6);
        Cycling cycling3 = new Cycling(DateTime.Now,"Cycling",3.3,5.6);
        Running running1 = new Running(DateTime.Now,"Running",8.9,7.9);
        Running running2 = new Running(DateTime.Now,"Running",7.8,1.1);
        Running running3 = new Running(DateTime.Now,"Running",5.5,6.7);
        Swimming swimming1 = new Swimming(DateTime.Now,"Swimming",7.9,6.8);
        Swimming swimming2 = new Swimming(DateTime.Now,"Swimming",1.8,1.9);
        Swimming swimming3 = new Swimming(DateTime.Now,"Swimming",1.9,2.8);


    }
}