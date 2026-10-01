//  Running totals
// Given a List of daily sales, print a running total after each day, and the day number on which
// the cumulative total first passed 1000.
// E X P E C T E D O U T P U T
// Day 1: 250 (total 250)
// Day 2: 300 (total 550)
// Day 3: 180 (total 730)
// Day 4: 420 (total 1150)
// Day 5: 200 (total 1350)
// Passed 1000 on day 4

using System;
class Program{
    static void Main(){
        int[] sales={250,300,180,420,200};
        int total=0;
        for(int i=0;i<sales.Length;i++){
            total+=sales[i];
            Console.WriteLine($"Day {i+1}: {sales[i]} (total {total})");
            if(total>1000){
                Console.WriteLine($"Passed 1000 on day {i+1}");
                break;
            }
        }
    }
}