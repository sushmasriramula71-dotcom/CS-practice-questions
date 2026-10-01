// Balanced brackets
// Use a Stack to check whether a string of brackets is balanced. Every opening bracket must be
// closed by the matching type in the right order. Test three different strings.
// E X P E C T E D O U T P U T
// {[()]} -> balanced
// {[(])} -> not balanced
// (( -> not balanced

using System;
using System.Collections.Generic;

class Program
{
    static bool IsBalanced(string text)
    {
        Stack<char> stack=new Stack<char>();

        foreach(char ch in text)
        {
            if(ch=='('||ch=='{'||ch=='[')
            {
                stack.Push(ch);
            }
            else if(ch==')'||ch=='}'||ch==']')
            {
                if(stack.Count==0)
                    return false;

                char top=stack.Pop();

                if((ch==')' && top!='(') ||
                   (ch=='}' && top!='{') ||
                   (ch==']' && top!='['))
                    return false;
            }
        }

        return stack.Count==0;
    }

    static void Main()
    {
        string[] tests={"{[()]}","{[(])}","(("};
        foreach(string text in tests)
        {
            if(IsBalanced(text))
                Console.WriteLine(text+"-> balanced");
            else
                Console.WriteLine(text+"-> not balanced");
        }
    }
}