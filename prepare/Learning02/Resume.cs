class Resume
{
    private string name;
    private List<Job> jobs;

    public Resume (string name)
    {
        this.name = name;
        this.jobs = new List<Job>();
    }

    public void AddJob(Job job)
    {
        jobs.Add(job);
    }

    public void Display()
    {
        Console.WriteLine($"{name}'s Resume:\n");
        foreach (Job job in jobs)
        {
            job.DisplayJob();
        }

    }
}