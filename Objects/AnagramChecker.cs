using System.Collections.Generic;
using System;
using System.Linq;

namespace Anagram.Objects
{
  public class AnagramChecker
  {
    private string _word;
    private string _userWordList;
    private static string[] _wordList;
    private List<string> _resultList = new List<string>();

    public AnagramChecker(string userWord, string userWordList)
    {
      _word = userWord;
      _userWordList = userWordList;
    }

    public static string SortWord(string unsortedWord)
    {
      char[] word = unsortedWord.ToCharArray();
      Array.Sort(word);
      string sortedWord = new string(word);
      return sortedWord;
    }

    public List<string> Check()
    {
      if(_userWordList.Contains(','))
      {
        _wordList = _userWordList.Split(',');
        string sortedWord = AnagramChecker.SortWord(_word);
        foreach(string possibleAnagram in _wordList)
        {
          string sortedPossibleAnagram = AnagramChecker.SortWord(possibleAnagram);
          if(sortedWord == sortedPossibleAnagram)
          {
            _resultList.Add(sortedPossibleAnagram);
          }
        }
      }
      else
      {
        string sortedWord = AnagramChecker.SortWord(_word);
        string sortedPossibleAnagram = AnagramChecker.SortWord(_userWordList);
        if(sortedWord == sortedPossibleAnagram)
        {
          _resultList.Add(sortedPossibleAnagram);
        }
      }
      return _resultList;
    }
  }
}
// char[] word = _word.ToCharArray();
// Array.Sort(word);
// string sortedWord = new string(word);
