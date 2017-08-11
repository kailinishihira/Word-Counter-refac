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
  }
}
