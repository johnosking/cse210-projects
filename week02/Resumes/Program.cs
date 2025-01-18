using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Google";
        job1._startYear = " 2020";
        job1._endYear = " 2024";
        job1.DisplayJobDetails();

    
        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "IBM";
        job2._startYear = " 2018";
        job2._endYear = " 2023";
        job2.DisplayJobDetails();


        Resume resume1 = new Resume();
        resume1._givingName = "Mary Jane";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.DisplayResume();
    }
}