public class Scripture {
    private Reference reference;
    private List<Word> words;

    // Property to get and set the reference
    public Reference Reference {
        get { return reference; }
        set { reference = value; }
    }

    // Property to get and set the list of words
    public List<Word> Words {
        get { return words; }
        set { words = value; }
    }

    // Constructor to initialize the Scripture with a reference and text
    public Scripture(Reference reference, string text) {
        this.reference = reference;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Method to hide all words in the scripture
    public void HideWords() {
        foreach (var word in words) {
            word.Hide();
        }
    }

    // Method to get the text of the scripture with hidden words replaced by underscores of the same length
    public string GetText() {
        return string.Join(" ", words.Select(word => word.IsHidden ? new string('_', word.Text.Length) : word.Text));
    }
}