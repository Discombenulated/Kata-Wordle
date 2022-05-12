namespace Wordle;

public class Word
{
    private string word;
    public Word(string word){
        this.word = word.ToLower();
    }

    public string CompareTo(Word actual)
    {
        if (this.word == actual.word) return "22222";
        throw new NotImplementedException();
    }
}