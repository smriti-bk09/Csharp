//Declare variables for principal, rate, and time, then calculate simple interest.

using System;
using System.Runtime.InteropServices.Marshalling;
public class Question8
{
    public void SimpleIntrest()
    {
        double principle = 2000;
        double time = 2;
        double rate = 5;
        double si;


         si = (principle* rate* time)/100; 

        Console.WriteLine($"the simple intrest is {si} ");
        
        
        
    }
}