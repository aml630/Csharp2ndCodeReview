using Nancy;
using RepeatCounterNS.Objects;
using System.Collections.Generic;

namespace RepeatCounterModuleNS
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
        return View ["outputs.cshtml", RepeatCounter.CountRepeats(Request.Form["word"], Request.Form["phrase"])];
      };
    }
  }
}
