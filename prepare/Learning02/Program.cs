using System;

namespace Learning02
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create Job 1 Instance //
            Job job1 = new Job();
            job1._jobTitle = "Software Engineer";
            job1._company = "Microsoft";
            job1._startYear = 2001;
            job1._endYear = 2008;

            // Creat Job2 Instance //
            Job job2 = new Job();
            job2._jobTitle = "CEO";
            job2._company = "Apple";
            job2._startYear = 2017;
            job2._endYear = 2023;

            // Create bridgerResume Instance //
            Resume bridgerResume = new Resume();
            bridgerResume._userName = "Bridger Allen";
            bridgerResume._jobList.Add(job1);
            bridgerResume._jobList.Add(job2);

            // Display Resume//
            bridgerResume.Display();


        }
    }
}

