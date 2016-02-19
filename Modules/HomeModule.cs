using Nancy;
using WordCountNS.Objects;
using System.Collections.Generic;

namespace WordCounterMNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      // 
      // Post["/updatePage"] = _ =>
      // {
      //   string input = Request.Form["inputWord"];
      //   List<string> output = Word.CompareWord(input);
      //   return View ["matchedWords.cshtml", output];
      // };

    }
  }
}
