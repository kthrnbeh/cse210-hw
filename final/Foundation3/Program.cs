/*
The focus of these programs is to help you design 
and build the classes and work with the relationships 
among these classes. With that in mind, you do not need to 
create a menu system or a user interface. Instead, your Program.cs 
file can create the required objects, set their values, and display them as specified, 
without any user interaction.*/
using System.Collections.Generic;
using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        // TODO: create Address objects
        // Address address1 = new Address("123 Main St", "Draper", "UT", "84020", "USA");
        // Address address2 = new Address(...);
        // Address address3 = new Address(...);
        Address address1 = new Address("825 E 12500 S", "Draper", "UT",84020,"USA");
        Address address2 = new Address("500 E 81 N", "Monticello", "UT",84035,"USA");
        Address address3 = new Address("123 Mabini Street", "Quezon City", "Manila", 1101, "Philippines");


        // TODO: create one Lecture, one Reception, one OutdoorGathering
         // Lecture lecture = new Lecture("AI Summit", "Tech conference", new DateTime(2025, 6, 10), new TimeSpan(10, 0, 0), address1, "Dr. Adams", 200);
        Lectures lecture1 = new Lectures(
        "Lecture",
        "Coding Meeting",
         "C#",
         new DateTime(2025, 10, 10),
         new TimeSpan(10),
         address1,
         "Speaker Kevin James",
         300
         );
        Lectures lecture2 = new Lectures(
        "Lecture",
        "Love YourSelf",
        "Self Help class",
        new DateTime(2025, 12, 15),
        new TimeSpan(7),
        address2,
        "Speaker Joy Ruma",
        200
        );
        Lectures lecture3 = new Lectures(
        "Lecture",
        "Barbies a Girls Best Friend",
        "how dolls help girls",
        new DateTime(2025, 4, 8),
        new TimeSpan(3),
        address3,
        "Speaker Dolly Parton",
        40
        );
        // Reception reception = new Reception("Networking Night", "Meet industry professionals", new DateTime(2025, 7, 15), new TimeSpan(18, 0, 0), address2, "rsvp@events.com");
        Receptions receptions1 = new Receptions(
        "Reception",
        "Berry & Garry",
        "Marriage Celebration",
        new DateTime(2025, 12, 12),
        new TimeSpan(8),
        address1,
        "To Kristen at 802-387-5433"
        );
        Receptions receptions2 = new Receptions(
        "Reception",
        "Penut & Jam",
        "After Marriage Party",
        new DateTime(2025, 10, 13),
        new TimeSpan(14,6,0), //if you delete all the numbers it messes up the whole time... weird
        address2,
        "To Mary at 801-384-5453"
        );
        Receptions receptions3 = new Receptions(
        "Reception",
        "Moody & Judy",
        "Love Party",
        new DateTime(2025, 8, 15),
        new TimeSpan(2),
        address3,
        "To John at 803-385-5400"
        );

        // OutdoorGathering picnic = new OutdoorGathering("Community Picnic", "Outdoor family event", new DateTime(2025, 8, 5), new TimeSpan(12, 0, 0), address3, "Sunny with light breeze");
        Outdoor outdoor1 = new Outdoor(
        "OutDoor",
        "Community Sport",
        "Soccer Game",
        new DateTime(1989, 10, 10),
        new TimeSpan(6),
        address1,
        "Rainy, Wear a coat."
        );
        Outdoor outdoor2 = new Outdoor(
        "OutDoor",
        "Community Sport",
        "Baseball",
        new DateTime(2026, 03, 10),
        new TimeSpan(6),
        address1,
        "Sunny."
        );
        Outdoor outdoor3 = new Outdoor(
        "OutDoor",
        "Community picnic",
        "Make new friends in your community!",
        new DateTime(2025, 05, 1),
        new TimeSpan(6),
        address1,
        "Sunny, and breezy. Bring a kite!"
        );



        // TODO: display details for each event
        // Console.WriteLine(lecture.GetStandardDetails());
        // Console.WriteLine(lecture.GetFullDetails());
        // Console.WriteLine(lecture.GetShortDescription());
        // Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine(lecture1.GetAllDetails());
        Console.WriteLine(lecture1.GetShortDescription());
        
        Console.WriteLine(lecture2.GetStandardDetails());
        Console.WriteLine(lecture2.GetAllDetails());
        Console.WriteLine(lecture2.GetShortDescription());
        Console.WriteLine(lecture3.GetStandardDetails());
        Console.WriteLine(lecture3.GetAllDetails());
        Console.WriteLine(lecture3.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(receptions1.GetStandardDetails());
        Console.WriteLine(receptions1.GetAllDetails());
        Console.WriteLine(receptions1.GetShortDescription());
        Console.WriteLine(receptions2.GetStandardDetails());
        Console.WriteLine(receptions2.GetAllDetails());
        Console.WriteLine(receptions2.GetShortDescription());
        Console.WriteLine(receptions3.GetStandardDetails());
        Console.WriteLine(receptions3.GetAllDetails());
        Console.WriteLine(receptions3.GetShortDescription());
        Console.WriteLine();

        // Console.WriteLine(reception.GetStandardDetails());
        // Console.WriteLine(reception.GetFullDetails());
        // Console.WriteLine(reception.GetShortDescription());
        // Console.WriteLine();

        // Console.WriteLine(picnic.GetStandardDetails());
        // Console.WriteLine(picnic.GetFullDetails());
        // Console.WriteLine(picnic.GetShortDescription());
        Console.WriteLine(outdoor1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor1.GetAllDetails());
         Console.WriteLine();
        Console.WriteLine(outdoor1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoor2.GetStandardDetails());
         Console.WriteLine();
        Console.WriteLine(outdoor2.GetAllDetails());
         Console.WriteLine();
        Console.WriteLine(outdoor2.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoor3.GetStandardDetails());
         Console.WriteLine();
        Console.WriteLine(outdoor3.GetAllDetails());
         Console.WriteLine();
        Console.WriteLine(outdoor3.GetShortDescription());
    }
}

/*Lectures, which have a speaker and have a limited capacity.
Receptions, which require people to RSVP, or register, beforehand.
Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.

They would like the ability to generate three different messages:

Standard details - Lists the title, description, date, time, and address.
Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
Short description - Lists the type of event, title, and the date.*/