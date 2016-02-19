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

      Post["/outputs"] = _ =>
      {
        string inputWord = Request.Form["word"];
        string inputPhrase = Request.Form["phrase"];
        WordCounter output = new WordCounter(inputWord, inputPhrase);

        return View ["outputs.cshtml", output.RepeatCounter()];
      };

    }
  }
}
