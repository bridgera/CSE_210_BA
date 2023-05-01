using System;
using System.Collections.Generic;

public class Resume
{
    //Set class attribute//
    public string _userName;
    // Create new list from Job instances created//
    public List<Job> _jobList = new List<Job>();

    //Display entire resume//
    public string Display()
    {
        Console.WriteLine($"Name: {_userName}");
        Console.WriteLine($"Jobs:");

        // note job is a Class type of Job //
        foreach (Job job in _jobList)
        {
           job.Display();
        }
        return null;
    }
}