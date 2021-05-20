using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using BL;
using System.Net;

namespace UI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        //private ApplicationSignInManager _signInManager;
        //private ApplicationUserManager _userManager;
        private BLImp _bLImp;

        public AccountController()
        {
        }

        /*public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        */



        // GET: /Account/Login

        public ActionResult Login()
        {
            return View();
        }


    }
}