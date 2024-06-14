using System;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();

        int endHistory = 1; //This is to end the job history loop.
        Console.WriteLine("Hello!");
        Console.Write("Enter your name: ");
        myResume.name = Console.ReadLine(); // looked at the solution for this line.

        Console.WriteLine("Write your latest job history (to exit type '0' in the job title");
        do
        {
            Job job = new Job();
            Console.Write("Job Title: ");
            string _jobTitle = Console.ReadLine();

            if (_jobTitle != "0")
            {
                job.jobTitle = _jobTitle;

                Console.Write("Company: ");
                job.company = Console.ReadLine();

                Console.Write("Start Year: ");
                job.startYear = int.Parse(Console.ReadLine());

                Console.Write("End Year: ");
                job.endYear = int.Parse(Console.ReadLine());

                myResume.jobs.Add(job);
            }
            else
            {
                endHistory = 0;
            }
        }while(endHistory !=0);

        myResume.Display();

    }
}