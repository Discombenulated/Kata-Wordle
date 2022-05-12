namespace Wordle;

public class Word
{
    private string word;
    public Word(string word){
        this.word = word.ToLower();
    }

    public string CompareTo(Word other)
    {
        if (this.word == other.word) return "22222";

        var result = "";
        for (var i = 0; i < this.word.Length; i++){
            if (this.word[i] == other.word[i]) result += "2";
            else result += "0";
        }
        return result; 
    }
}