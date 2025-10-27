/*
The focus of these programs is to help you design 
and build the classes and work with the relationships 
among these classes. With that in mind, you do not need to 
create a menu system or a user interface. Instead, your Program.cs 
file can create the required objects, set their values, and display them as specified, 
without any user interaction.*/
using System;
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
        Address address1 = new Address("825 e 12500s", "Draper", "UT", 84020);
        

        // TODO: create one Lecture, one Reception, one OutdoorGathering
        // Lecture lecture = new Lecture("AI Summit", "Tech conference", new DateTime(2025, 6, 10), new TimeSpan(10, 0, 0), address1, "Dr. Adams", 200);
        // Reception reception = new Reception("Networking Night", "Meet industry professionals", new DateTime(2025, 7, 15), new TimeSpan(18, 0, 0), address2, "rsvp@events.com");
        // OutdoorGathering picnic = new OutdoorGathering("Community Picnic", "Outdoor family event", new DateTime(2025, 8, 5), new TimeSpan(12, 0, 0), address3, "Sunny with light breeze");

        // TODO: display details for each event
        // Console.WriteLine(lecture.GetStandardDetails());
        // Console.WriteLine(lecture.GetFullDetails());
        // Console.WriteLine(lecture.GetShortDescription());
        // Console.WriteLine();

        // Console.WriteLine(reception.GetStandardDetails());
        // Console.WriteLine(reception.GetFullDetails());
        // Console.WriteLine(reception.GetShortDescription());
        // Console.WriteLine();

        // Console.WriteLine(picnic.GetStandardDetails());
        // Console.WriteLine(picnic.GetFullDetails());
        // Console.WriteLine(picnic.GetShortDescription());
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