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
        return View["index.cshtml"];
      };
    }
  }
}
