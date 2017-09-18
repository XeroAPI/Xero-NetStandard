using Microsoft.AspNetCore.Mvc;
using Xero.Api.Example.Applications.Public;
using Xero.Api.Example.MVC.Helpers;

namespace Xero.Api.Example.MVC.Controllers
{
    public class OrganisationController : Controller
    {
        public ActionResult Index()
        {
            var api = XeroApiHelper.CoreApi();

            try
            {
                var organisation = api.Organisation;

                return View(organisation);
            }
            catch (RenewTokenException e)
            {
                return RedirectToAction("Connect", "Home");
            }
        }
    }
}
