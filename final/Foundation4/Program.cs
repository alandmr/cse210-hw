using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _listActivity = new List<Activity>();

        Running running = new Running(4.8,"14 December 2023",30,1);
        Cycling cycling = new Cycling(20,"10 December 2023",120,2);
        Swimming swimming = new Swimming(20,"05 December 2023",45,3);


        _listActivity.Add(running);
        _listActivity.Add(cycling);
        _listActivity.Add(swimming);

        Console.Clear();

        foreach (Activity activity in _listActivity){
            activity.GetSumary(activity.GetDate(),activity.GetLenghtActivity(), activity.GetDistance(), activity.GetSpeed(), activity.GetPace());
        }
    }
}