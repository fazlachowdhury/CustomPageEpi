using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPICodingChallenge.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace EPICodingChallenge.Controllers
{
    public class CustomPageController : PageControllerBase<CustomPage>
    {
        public ActionResult Index(CustomPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(PageViewModel.Create(currentPage));
        }
    }
}