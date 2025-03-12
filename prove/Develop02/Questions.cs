using System;
using System.Collections.Generic;

class Questions 
{
    private List<string> _questions;
    
    public Questions()
    {
        _questions = new List<string>();
        _questions.Add("Who was the most interesting person I interacted with today?");
        _questions.Add("What was the best part of my day?");
        _questions.Add("How did I see the hand of the Lord in my life today?");
        _questions.Add("What was the strongest emotion I felt today?");
        _questions.Add("If I had one thing I could do over today, what would it be?");
    }

    public string GetQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        return _questions[randomIndex];
    }
}