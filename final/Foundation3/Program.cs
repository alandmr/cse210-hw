using System;

class Program
{
    static void Main(string[] args)
    {
        //string street, string city, string state, string country
        Address address1 = new Address("Sector 2 Unare 2", "Puerto Ordaz", "Bolivar", "Venezuela");
        Address address2 = new Address("Av C con Calle C1, Caurimare", "Caracas", "Caracas", "Venezuela");;
        Address address3 = new Address("Av Lehi", "Saratoga", "Utah", "United States");;

        // string title, string description, string date, string time, Address address
        Lectures lecture = new Lectures("Elder Quentin L. Cook",50,"Devotional for young adults", 
        "Devotional for young single and married adults ages 18 to 30 ","Dec 01, 2023","18:00",address1);
        
        Receptions receptions = new Receptions("aland.munoz@gmail.com","Face to Face",
        "Face-to-face event for young men and women", "Dic 10, 2023","18:30",address2);
        
        OutdoordGatherings outdoordGatherings = new OutdoordGatherings("30° C Precipitation: 0%, Humidity: 65%, Wind: 8 km/h, Mostly cloudy",
        "A Christmas Carol","Theatrical performance of a Christmas Carol","Dic 23, 2023","19:30",address3);

        Console.Clear();
        // MESSAGE FOR LECTURES
        Console.WriteLine("***** Standard Details for Lectures Event *****");
        lecture.StandardDetails();
        Console.WriteLine("");
        lecture.LecturesFullDetail();
        Console.WriteLine("");
        lecture.MessageShortDescription("Lecture", lecture.GetTitle(), lecture.GetDate());

        Console.WriteLine("");
        Console.WriteLine("");

        // MESSAGE FOR RECEPTIONS
        Console.WriteLine("***** Standard Details for Receptions Event *****");
        receptions.StandardDetails();
        Console.WriteLine("");
        receptions.ReceptionsFullDetail();
        Console.WriteLine("");
        receptions.MessageShortDescription("Receptions", receptions.GetTitle(), receptions.GetDate());

        Console.WriteLine("");
        Console.WriteLine("");

        // MESSAGE FOR OUTDOOR GATHERINGS
        Console.WriteLine("***** Standard Details for Outdoor Gatherings Event *****");
        outdoordGatherings.StandardDetails();
        Console.WriteLine("");
        outdoordGatherings.WForecastFullDetail();
        Console.WriteLine("");
        outdoordGatherings.MessageShortDescription("Outdoor Gatherings", outdoordGatherings.GetTitle(), outdoordGatherings.GetDate());


    }
}