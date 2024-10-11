using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "CristiCorp";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2000;
        job1._endYear =2020;

        job1.Display();

    }
}