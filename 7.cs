// Support ticket queue
// Model a support desk with a Queue. Add four tickets, serve two of them, peek at who is next,
// then report how many are still waiting.
// E X P E C T E D O U T P U T
// Serving: T101
// Serving: T102
// Next up: T103
// Still waiting: 2


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> tickets=new Queue<string>();

        tickets.Enqueue("T101");
        tickets.Enqueue("T102");
        tickets.Enqueue("T103");
        tickets.Enqueue("T104");

        Console.WriteLine("Serving: "+tickets.Dequeue());
        Console.WriteLine("Serving: "+tickets.Dequeue());

        Console.WriteLine("Next up: "+tickets.Peek());
        Console.WriteLine("Still waiting: "+tickets.Count);
    }
}