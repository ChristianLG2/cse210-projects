using System;

public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public override string ToString()
    {
        return $"{street}, {city}, {state}, {country}";
    }
}

public abstract class Event
{
    private string title;
    private string description;
    private DateTime date;
    private string time;
    private Address address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"{title}\n{description}\nDate: {date.ToShortDateString()}, Time: {time}\nLocation: {address}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"{GetType().Name.Replace("Event", "")}: {title} on {date.ToShortDateString()}";
    }
}

public class LectureEvent : Event
{
    private string speaker;
    private int capacity;

    public LectureEvent(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {speaker}, Capacity: {capacity}";
    }
}

public class ReceptionEvent : Event
{
    private string rsvpEmail;

    public ReceptionEvent(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP at: {rsvpEmail}";
    }
}

public class OutdoorGatheringEvent : Event
{
    private string weatherForecast;

    public OutdoorGatheringEvent(string title, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather Forecast: {weatherForecast}";
    }
}

class Program
{
    static void Main()
    {
        var lecture = new LectureEvent("Science Talk", "A talk on recent scientific discoveries", new DateTime(2023, 5, 25), "18:00", new Address("123 Science Rd", "Techville", "CA", "USA"), "Dr. Jane Doe", 100);
        var reception = new ReceptionEvent("Art Gala", "An evening of art and conversation", new DateTime(2023, 6, 15), "19:00", new Address("456 Art St", "Culture City", "NY", "USA"), "rsvp@artgala.com");
        var outdoor = new OutdoorGatheringEvent("Community Picnic", "A fun day out for families", new DateTime(2023, 7, 4), "11:00", new Address("789 Park Ave", "Green Town", "OR", "USA"), "Sunny with a slight chance of rain");

        PrintEventDetails(lecture);
        PrintEventDetails(reception);
        PrintEventDetails(outdoor);
    }

    static void PrintEventDetails(Event eventObj)
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(eventObj.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(eventObj.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(eventObj.GetShortDescription());
        Console.WriteLine("--------------------------------------------------");
    }
}