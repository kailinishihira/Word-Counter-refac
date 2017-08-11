using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _inputSentence;
    private string _inputWord;
    private int _wordCounter;

    public RepeatCounter (string inputSentence, string inputWord)
    {
      _inputSentence = inputSentence;
      _inputWord = inputWord;
    }

    public int CountRepeats()
    {
      _wordCounter = 0;
      string sentence = _inputSentence.ToLower();
      string word = _inputWord.ToLower();
      string [] sentenceArray = sentence.Split(' ');
      if (sentenceArray.Length <= 0 || word.Length <= 0)
      {
        _wordCounter = 0;
      } else
      {
        for (int i = 0; i < sentenceArray.Length; i++)
        {
          if (sentenceArray[i].IndexOf(word) != -1)
          {
            _wordCounter += 1;
          } else
          {
            _wordCounter += 0;
          }
        }
      }
      return _wordCounter;
    }
  }
}
