public class Word {
    private string text;
    private bool isHidden;

    // Property to get and set the text of the word
    public string Text {
        get { return text; }
        set { text = value; }
    }

    // Property to get and set the hidden status of the word
    public bool IsHidden {
        get { return isHidden; }
        set { isHidden = value; }
    }

    // Constructor to initialize the Word with text
    public Word(string text) {
        this.text = text;
        this.isHidden = false;
    }

    // Method to hide the word
    public void Hide() {
        IsHidden = true;
    }

    // Method to show the word
    public void Show() {
        IsHidden = false;
    }
}
