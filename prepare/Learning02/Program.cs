using System;

class Program
{
    static void Main(string[] args)
    {
        // RESUME PROGRAM
        Job job1 = new Job();
        job1._jobTitle = "Frontend Engineer";
        job1._company = "Mvend";
        job1._startYear = 2020;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Student Mentor";
        job2._company = "Altschool Africa";
        job2._startYear = 2022;
        job2._endYear = 2023;
        // Create a resume instance
        Resume myResume = new Resume();
        myResume._name = "Victor Patrick";
        // Add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        // Display the resume details
        myResume.Display();


    }
}
