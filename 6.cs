//  Common and exclusive skills
// Two candidates each have a set of skills. Print the skills they share, the skills only the first has,
// and the combined set of all skills.
// E X P E C T E D O U T P U T
// Shared: C#, SQL
// Only Amit: Python
// All skills: C#, SQL, Python, React, Azure

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> amit=new HashSet<string>{"C#","SQL","Python"};
        HashSet<string> rahul=new HashSet<string>{"C#","SQL","React","Azure"};

        HashSet<string> shared=new HashSet<string>(amit);
        shared.IntersectWith(rahul);

        HashSet<string> onlyAmit=new HashSet<string>(amit);
        onlyAmit.ExceptWith(rahul);

        HashSet<string> allSkills=new HashSet<string>(amit);
        allSkills.UnionWith(rahul);

        Console.WriteLine("Shared: "+string.Join(", ",shared));
        Console.WriteLine("Only Amit: "+string.Join(", ",onlyAmit));
        Console.WriteLine("All skills: "+string.Join(", ",allSkills));
    }
}