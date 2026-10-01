using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> printJobs=new Queue<string>();
        HashSet<string> emails=new HashSet<string>();
        Dictionary<string,double> prices=new Dictionary<string, double>();
        Stack<string> undoStack=new Stack<string>();

        Console.WriteLine("Print jobs: Queue");
        Console.WriteLine("Unique emails: HashSet");
        Console.WriteLine("Price lookup: Dictionary");
        Console.WriteLine("Undo feature: Stack");
    }
}