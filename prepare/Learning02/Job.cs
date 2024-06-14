using System.Dynamic;

public class Job
{
    public string jobTitle;
    public string company;
    public int startYear;
    public int endYear;

    public void JobInfo()
    {
        Console.WriteLine($"{jobTitle}, {company}, {startYear} -- {endYear}");
    }
}