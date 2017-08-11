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

      if (_inputSentence.IndexOf(_inputWord) != -1)
      {
        _wordCounter += 1;
      } else 
      {
        _wordCounter = 0;
      }


      // string[] sentenceArray =_inputSentence.Split(' ');
      // for (int i = 0; i < sentenceArray.Length; i++)
      // {
      //   if (sentenceArray[i].IndexOf(_inputWord) = -1)
      //   {
      //     _wordCounter = 0;
      //   }
      // }
      return _wordCounter;
    }
  }
}
