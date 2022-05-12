using NUnit.Framework;

namespace Wordle.Test;

public class WordTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldReturnAll2sWhenEqual()
    {
        var guess = new Word("world");
        var actual = new Word("world");
        Assert.AreEqual("22222", guess.CompareTo(actual));
    }

    [Test]
    public void ShouldReturnAll0sWhenNoSimilarLetters(){
        var guess = new Word("world");
        var actual = new Word("might");
        Assert.AreEqual("00000", guess.CompareTo(actual));
    }

    [Test]
    public void ShouldReturnMostly2sWhenMostlySimilarLetters(){
        var guess = new Word("fight");
        var actual = new Word("might");
        Assert.AreEqual("02222", guess.CompareTo(actual));
    }

    [Test]
    public void ShouldReturn1sWhenLetterCorrectButInWrongPlace(){
        var guess = new Word("stair");
        var actual = new Word("chore");
        Assert.AreEqual("00001", guess.CompareTo(actual));
    }

    [Test]
    public void ShouldReturnMixedResultWhenAnswerIsClose(){
        var guess = new Word("charm");
        var actual = new Word("hairy");
        Assert.AreEqual("01120", guess.CompareTo(actual));
    }
}