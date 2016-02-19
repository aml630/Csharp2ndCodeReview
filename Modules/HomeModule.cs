// using Nancy;
// using RepeatCounterNS.Objects;
// using System.Collections.Generic;
//
// namespace RepeatCounterModuleNS
// {
//   public class HomeModule : NancyModule
//   {
//     public HomeModule()
//     {
//       Get["/"] = _ =>
//       {
//         return View["index.cshtml"];
//       };
//
//       Post["/outputs"] = _ =>
//       {
//         string inputWord = Request.Form["word"];
//         string inputPhrase = Request.Form["phrase"];
//         RepeatCounter output = new RepeatCounter(inputWord, inputPhrase);
//
//         return View ["outputs.cshtml", output.CountRepeats()];
//       };
//
//     }
//   }
// }
