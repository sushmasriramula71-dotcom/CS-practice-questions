//  Browser history with undo
// Use a Stack to model browser history. Visit four pages, then press back twice, printing where
// you land each time. Finally print the current page.
// E X P E C T E D O U T P U T
// Visited (most recent first): checkout, cart, products, home
// Back to: cart
// Back to: products
// // Current page: products

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> history=new Stack<string>();
        history.Push("home");
        history.Push("products");
        history.Push("cart");
        history.Push("checkout");
        Console.WriteLine("Visited (most recent first): "+string.Join(", ",history));
        history.Pop();
        Console.WriteLine("Back to:"+history.Peek());
        history.Pop();
        Console.WriteLine("Back to:"+history.Peek());
        Console.WriteLine("Current page:"+history.Peek());
    }
}