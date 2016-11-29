using Nancy;
using System.Collections.Generic;
using Anagram.Objects;

namespace Anagram
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        //List<string> anagramList = new List<string>();
        return View["index.cshtml"];
      };
      Post["/anagram"] = _ =>{
        AnagramChecker newAnagram = new AnagramChecker(Request.Form["user-word"], Request.Form["user-anagrams"]);
        var anagramList = newAnagram.Check();
        return View["anagram.cshtml", anagramList];
      };
    }
  }
}
