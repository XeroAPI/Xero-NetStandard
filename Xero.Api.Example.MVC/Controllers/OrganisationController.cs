using System;
using Microsoft.AspNetCore.Mvc;
using Xero.Api.Example.MVC.Helpers;
using Xero.Api.Infrastructure.Exceptions;

namespace Xero.Api.Example.MVC.Controllers
{
    public class OrganisationController : Controller
    {
        public ActionResult Index()
        {
            var api = XeroApiHelper.CoreApi();

            try
            {
                var organisation = api.FindOrganisationAsync().Result;

                return View(organisation);
            }
            catch (RenewTokenException e)
            {
                Console.WriteLine(e);
                return RedirectToAction("Connect", "Home");
            }
        }
    }
}
