//Swap two variables without using a third variable.


using System;
public class Question6
{
    public void UsingThirdVariable()
    {
        int a = 15;
        int b = 5;
        int c = 10;
        Console.WriteLine($"swapping using without variable a is {a} b is {b} c is{c} ");
         
         a = c;
         b = a;
         c = b;
         Console.WriteLine($"swapping a is {a} b is {b} c is {c}");

    }
}