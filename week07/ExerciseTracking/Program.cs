using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run1 = new Running("03 Nov 2022", 30, 4.5f);
        Swimming swim1 = new Swimming("03 Nov 2022", 30, 20);
        Cycling cyc1 = new Cycling("03 Nov 2022", 30, 8.5f);

        activities.Add(run1);
        activities.Add(swim1);
        activities.Add(cyc1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}