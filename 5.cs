// Unique visitors
// A website log records user IDs, with repeats. Use a HashSet to count how many distinct users
// visited, and report how many log entries were repeats.
// E X P E C T E D O U T P U T
// Log entries: 8
// Unique visitors: 5
// Repeat entries: 3

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> logs=new List<int>{101,102,101,103,104,102,105,101};
        HashSet<int> uniqueUsers=new HashSet<int>();
        int repeatEntries=0;

        foreach(int user in logs)
        {
            if(uniqueUsers.Contains(user))
                repeatEntries++;
            else
                uniqueUsers.Add(user);
        }

        Console.WriteLine("Log entries: " +logs.Count);
        Console.WriteLine("Unique visitors: "+uniqueUsers.Count);
        Console.WriteLine("Repeat entries: "+repeatEntries);
    }
}