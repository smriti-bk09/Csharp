//Create variables for five subject marks and calculate the average.


using System;
public class Question9
{
    public void SubjectMarksAvg()
    {
    double science =50;
    double math =60;
    double social =70;
    double nepali = 40 ;
    double english =40;
    double avg;
    avg = (science + math + social + nepali + english)/5;

    Console.WriteLine($"the avg of all subject is {avg}");
    }
}