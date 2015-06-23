using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        // GET: Cuisine
       
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);

            return Content(message);
        }
    }
}