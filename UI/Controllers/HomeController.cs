using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

//using CW.Soloist.WebApplication.Filters.ActionFilters;


namespace UI.Controllers
{
    /// <summary>
    /// Controller responsible for handling requestes on the home page,
    /// and general util services for the other controllers such as 
    /// retrieving the path for the parent directory on the file server.
    /// </summary>
    [AllowAnonymous]
    public class HomeController : Controller
    {

        // Home page 
        public ActionResult Index() => View();


        // About page 
        public ActionResult About() => View();


        // Contact info 
        //[CrawlerFilter]
        public ActionResult Contact() => View();

    }
}