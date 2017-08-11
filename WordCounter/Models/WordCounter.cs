using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _inputSentence;
    private string _inputWord;
    private char[] _removeChar = new char[] {'@', ',', '.', ';', '[', ']', '(', ')', '#', '"'};

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

      // for (int i = 0; i < _removeChar.Length; i++)
      // {
      //   if (sentence[i] == _removeChar[i])
      //   {
      //     _newSentence = sentence.Replace(sentence[i], ' ');
      //   }
      // }

      // foreach()
      string newSentence = sentence.Trim(_removeChar);

      string [] sentenceArray = newSentence.Split(' ');
      if (sentenceArray.Length <= 0 || word.Length <= 0)
      {
        wordCounter = 0;
      } else
      {
        for (int i = 0; i < sentenceArray.Length; i++)
        {
          if (sentenceArray[i].IndexOf(word) != -1)
          {
            if (sentenceArray[i].Length == word.Length)
            {
            wordCounter += 1;
            } else
            {
              wordCounter +=0;
            }
          } else
          {
            wordCounter += 0;
          }
        }
      }
      return wordCounter;
    }
  }
}
