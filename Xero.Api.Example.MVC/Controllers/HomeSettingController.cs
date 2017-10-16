using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Xero.Api.Example.MVC.Authenticators;
using Xero.Api.Example.MVC.Helpers;
using Xero.Api.Infrastructure.OAuth;

namespace Xero.Api.Example.MVC.Controllers
{
    public class HomeSettingController : Controller
    {
        private IMvcAuthenticator _authenticator;
        private ApiUser _user;
        private ApplicationSettings _applicationSettings;
        public HomeSettingController(IOptions<ApplicationSettings> applicationSettings)
        {
            _user = XeroApiHelper.User();
            _applicationSettings = applicationSettings.Value;
            _authenticator = XeroApiHelper.MvcAuthenticator(_applicationSettings);
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Connect()
        {
            var authorizeUrl = _authenticator.GetRequestTokenAuthorizeUrl(_user.Identifier);

            return Redirect(authorizeUrl);
        }

        public ActionResult Authorize(string oauth_token, string oauth_verifier, string org)
        {
            var accessToken = _authenticator.RetrieveAndStoreAccessToken(_user.Identifier, oauth_token, oauth_verifier);
            if (accessToken == null)
                return View("NoAuthorized");

            return View(accessToken);
        }
    }
}
