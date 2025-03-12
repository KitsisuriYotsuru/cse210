public class Reference {
    private string book;
    private int chapter;
    private int verse;

    // Property to get and set the book name
    public string Book {
        get { return book; }
        set { book = value; }
    }

    // Property to get and set the chapter number
    public int Chapter {
        get { return chapter; }
        set { chapter = value; }
    }

    // Property to get and set the verse number
    public int Verse {
        get { return verse; }
        set { verse = value; }
    }

    // Constructor to initialize the Reference with book, chapter, and verse
    public Reference(string book, int chapter, int verse) {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
    }

    // Method to get the formatted reference as a string
    public string GetReference() {
        return $"{Book} {Chapter}:{Verse}";
    }
}
