using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _inputSentence;
    private string _inputWord;

    public RepeatCounter (string inputSentence, string inputWord)
    {
      _inputSentence = inputSentence;
      _inputWord = inputWord;
    }

    public int CountRepeats()
    {
      int wordCounter = 0;
      string sentence = _inputSentence.ToLower();
      string word = _inputWord.ToLower();

      string [] sentenceArray = sentence.Split(' ', ',', '.', '"', '#', '-', '!', '?', '*', '(', ')', '[', ']', '{', '}', '/');

      if (sentenceArray.Length == 0 || word.Length == 0)
      {
        wordCounter = 0;
      } else
      {
        for (int i = 0; i < sentenceArray.Length; i++)
        {
          if (sentenceArray[i] == word)
          {
            wordCounter += 1;
          } else
          {
            wordCounter += 0;
          }
        }
      } return wordCounter;
    }
  }
}
