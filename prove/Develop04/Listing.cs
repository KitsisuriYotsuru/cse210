class Listing : Activity
{
    private List<string> _questions;

    public Listing(string activityName, string welcome, string description)
    : base(activityName, welcome, description)
    {
        _questions.Add("Who are people that you appreciate?");
        _questions.Add("What are personal strengths of yours?");
        _questions.Add("Who are people that you have helped this week?");
        _questions.Add("When have you felt the Holy Ghost this month?");
        _questions.Add("Who are some of your personal heroes?");
    }
}