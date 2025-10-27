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

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
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