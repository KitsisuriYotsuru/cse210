class Reflection : Activity
{
    private List<string> _questions;
    private List<string> _reflectionQuestions;

    public Reflection(string activityName, string welcome, string description)
    : base(activityName, welcome, description)
    {
        _questions.Add("Think of a time when you stood up for someone else.");
        _questions.Add("Think of a time when you did something really difficult.");
        _questions.Add("Think of a time when you helped someone in need.");
        _questions.Add("Think of a time when you did something truly selfless.");
        _reflectionQuestions.Add("Why was this experience meaningful to you?");
        _reflectionQuestions.Add("Have you ever done anything like this before?");
        _reflectionQuestions.Add("How did you get started?");
        _reflectionQuestions.Add("How did you feel when it was complete?");
        _reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        _reflectionQuestions.Add("What is your favorite thing about this experience?");
        _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectionQuestions.Add("What did you learn about yourself through this experience?");
        _reflectionQuestions.Add("How can you keep this experience in mind in the future?");
    }   

}