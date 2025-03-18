public class Scripture 
{
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
        int i = 0;
        List<Word> notHiddenWords = [];
        foreach(Word word in words)
        {
            if(!word.IsHidden){notHiddenWords.Add(word);}
        }
        while(i < 3) {
            Random random = new Random();
            int randomIndex = random.Next(words.Count);
            if(!words[randomIndex].IsHidden)
            {
                words[randomIndex].SetIsHidden();
                i++;
            } else if (notHiddenWords.Count < 3) {
                foreach(Word word in notHiddenWords)
                {
                    word.SetIsHidden();
                }
                break;
            }
        }
    }

    // Method to get the text of the scripture with hidden words replaced by underscores of the same length
    public string GetText() {
        return string.Join(" ", words.Select(word => {
            if (word.IsHidden) {
                if (int.TryParse(word.GetWordString, out _)) {
                    return word.GetWordString;
                }
                if (word.GetWordString.EndsWith(",") || word.GetWordString.EndsWith(".")) {
                    char punctuation = word.GetWordString.Last();
                    return new string('_', word.GetWordString.Length - 1) + punctuation;
                }
                return new string('_', word.GetWordString.Length);
            }
            return word.GetWordString;
        }));
    }
}