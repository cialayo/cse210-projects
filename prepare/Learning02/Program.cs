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

        Job job2 = new Job();
        job2._company = "Javidowsky";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2028;

        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Cristobal Alayo";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}