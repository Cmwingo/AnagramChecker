using System.Collections.Generic;
using System;

namespace Anagram.Objects
{
  public class AnagramChecker
  {
    private string _word;
    private string _wordList;

    public AnagramChecker(string userWord, string userWordList)
    {
      _word = userWord;
      _wordList = userWordList;
    }

    public bool Check()
    {
      char[] word = _word.ToCharArray();
      char[] list = _wordList.ToCharArray();
      Array.Sort(word);
      Array.Sort(list);
      string sortedWord = new string(word);
      string sortedWordList = new string(list);
      if(sortedWord == sortedWordList)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
