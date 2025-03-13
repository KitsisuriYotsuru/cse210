public class Word 
{
    private string word;
    private bool isHidden;

    // Property to get and set the text of the word
    public string GetWordString {
        get { return word; }
        set { word = value; }
    }

    // Property to get and set the hidden status of the word
    public bool IsHidden {
        get { return isHidden; }
        set { isHidden = value; }
    }

    // Constructor to initialize the Word with text
    public Word(string word) {
        this.word = word;
        this.isHidden = false;
    }

    // Method to hide the word
    public void SetIsHidden() {
        IsHidden = true;
    }
}
