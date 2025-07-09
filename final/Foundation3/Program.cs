using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Event> listOfEvents = new List<Event>();
        listOfEvents.Add(new LectureEvent("Tech for beginners","How to use the company's software","07/14/2025","9:00 AM","Collin Cartwright",20));
        listOfEvents[0].SetEventAddress("Main Street","Manhattan","NY","USA");
        listOfEvents.Add(new ReceptionEvent("Freddie's party","Bring your pillow","11/13/1987","11:59 PM","hi@sleep.com"));
        listOfEvents[1].SetEventAddress("Elm Street", "EastWick", "Pensylvania","USA");
        listOfEvents.Add(new OutdoorEvent("HQ Camp","Team building activities","08/24/2025","10:00 AM","Sunny"));
        listOfEvents[2].SetEventAddress("Sunset Boulevard","Los Angeles","CA","USA");

        foreach (var e in listOfEvents)
        {
            Console.WriteLine($"\n****** START OF THREE MESSAGES TYPES ******\n{e.DisplayShortText()}");
            Console.WriteLine($"{e.DisplayStandardText()}");
            Console.WriteLine($"{e.DisplayFullText()}");
        }
    }
}
/*
Program 3: Inheritance with Event Planning

Scenario
You have been hired by an event planning company. They help organize 
and market events throughout the world. They need you to write a 
program to track each of these events and produce the marketing 
material to distribute on social media. They typically handle a 
few main types of events:

Lectures, which have a speaker and have a limited capacity.
Receptions, which require people to RSVP, or register, beforehand.
Outdoor gatherings, which do not have a limit on attendees, but need 
to track the weather forecast.
Regardless of the type, all events need to have an Event Title, 
Description, Date, Time, and Address.

They would like the ability to generate three different messages:

Standard details - Lists the title, description, date, time, and address.
Full details - Lists all of the above, plus type of event and information 
specific to that event type. For lectures, this includes the speaker name 
and capacity. For receptions this includes an email for RSVP. For outdoor 
gatherings, this includes a statement of the weather.
Short description - Lists the type of event, title, and the date.

Program Specification
Write a program that has a base Event class along with derived classes 
for each type of event. These classes should contain the necessary data 
and provide methods to return strings for each of the messages the 
company desires.

Remember that any data or methods that are common among all types of 
events should be in the base class.

Once you have the classes in place, write a program that creates at 
least one event of each type and sets all of their values. Then, for 
each event, call each of the methods to generate the marketing messages 
and output their results to the screen.

In addition, your program must:

Use inheritance to avoid duplicating shared attributes and methods.
Use an address class for the addresses.
Follow the principles of encapsulation, making sure each member variable 
is private.

*/