public class Resume
{
    public string name;

    public List<Job> jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Resume: ");

        foreach(Job job in jobs)
        {
            job.JobInfo();
        }
    }
}