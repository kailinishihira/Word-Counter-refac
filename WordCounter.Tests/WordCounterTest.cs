using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountRepeats_DoesNotAppearInSentence_0()
    {
      RepeatCounter newCount = new RepeatCounter("hello", "hi");
      int expected = 0;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_DoesNotAppearInMultiWordSentence_0()
    {
      RepeatCounter newCount = new RepeatCounter("hello there", "hi");
      int expected = 0;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_MatchesOneWordSentence_1()
    {
      RepeatCounter newCount = new RepeatCounter("Hello", "Hello");
      int expected = 1;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_MatchesOneWordLowerCase_1()
    {
      RepeatCounter newCount = new RepeatCounter("Hello", "hello");
      int expected = 1;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_MatchesTwoWords_2()
    {
      RepeatCounter newCount = new RepeatCounter("Hello Hello", "hello");
      int expected = 2;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_MatchesOneWordInMultiWordSentence_1()
    {
      RepeatCounter newCount = new RepeatCounter("Hello there", "hello");
      int expected = 1;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_MatchesOneWordInMiddleOfMultiWordSentence_1()
    {
      RepeatCounter newCount = new RepeatCounter("Why hello there", "hello");
      int expected = 1;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_MatchesMultipleWordsInMiddleOfMultiWordSentence_6()
    {
      RepeatCounter newCount = new RepeatCounter("You know Dasher and Dancer and Prancer and Vixen, you know Comet and Cupid and Donner and Blitzen", "and");
      int expected = 6;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_MatcheWordWithPeriod_1()
    {
      RepeatCounter newCount = new RepeatCounter("Say hello.", "hello");
      int expected = 1;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_NoMatchesForBlankFields_0()
    {
      RepeatCounter newCount = new RepeatCounter(" ", " ");
      int expected = 0;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_PartialMatches_0()
    {
      RepeatCounter newCount = new RepeatCounter("cathedral", "cat");
      int expected = 0;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }
  }
}
