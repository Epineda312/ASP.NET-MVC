/*Challenge Task 1 of 2

    Move the data in the Detail.cshtml view to the ComicBooksController.cs 
    controller's Detail action method.

    1.  Use the title variable value in the Detail.cshtml view to set a 
          ViewBag.Title property value in the ComicBooksController.cs controller's 
          Detail action method.
     2.  Repeat that process for the Detail.cshtml view's description 
          and characters variables by moving their values to ViewBag Description 
          and Characters properties. 
    
    Challenge Task 2 of 2

    Update the Detail.cshtml view to use the ViewBag data.

    1.  Remove the title, description, and characters variables.
    2.  Replace the title, description, and characters references 
        with the respective ViewBag properties.

*/
using System.Web.Mvc;

namespace Treehouse.Controllers
{
    public class VideoGamesController : Controller
    {
        public ActionResult Detail()
        {
              
         ViewBag.Title = "Super Mario 64";
         ViewBag.Description = @"Super Mario 64 is a 1996 platform video game 
                                developed and published by Nintendo for the 
                                Nintendo 64.";
         ViewBag.Characters = new string[]
         {
            "Mario",
            "Princess Peach",
            "Bowser",
            "Toad",
            "Yoshi"
        };

            return View();
        }
    }
}
