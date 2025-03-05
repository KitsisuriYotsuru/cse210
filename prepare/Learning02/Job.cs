class Job
{
    private string companyName;
    private string jobTitle;
    private int startYear;
    private int endYear;

    public Job(string name, string title, int start, int end)
    {
        companyName = name;
        jobTitle = title;
        startYear = start;
        endYear = end;
    }

    public void DisplayJob()
    {
        Console.WriteLine($"Company Name: {companyName}\nJob Title: {jobTitle}\nStart Year: {startYear}\nEnd Year: {endYear}\n");
    }
}