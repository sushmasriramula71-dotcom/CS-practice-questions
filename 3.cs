// Find duplicates in a list
// Given a List of integers, print every value that appears more than once, along with how many
// times. Use a Dictionary to count.
// E X P E C T E D O U T P U T
// Numbers: 3, 7, 3, 9, 7, 1, 3
// Duplicates:
// 3 appears 3 times
// 7 appears 2 times
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers=new List<int> {3,7,3,9,7,1,3};
        Dictionary<int,int> count=new Dictionary<int,int>();
        foreach(int num in numbers)
        {
            if(count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }
        }

        Console.WriteLine("Numbers:3,7,3,9,7,1,3");
        Console.WriteLine("Duplicates:");

        foreach (var item in count)
        {
            if (item.Value>1)
            {
                Console.WriteLine(item.Key+" appears "+item.Value+" times");
            }
        }
    }
}