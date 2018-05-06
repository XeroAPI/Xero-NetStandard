using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Xero.Api.Example.MVC.Helpers;
using Xero.Api.Infrastructure.OAuth;
using IMvcAuthenticator = Xero.Api.Example.MVC.Authenticators.IMvcAuthenticator;

namespace Xero.Api.Example.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMvcAuthenticator _authenticator;
        private readonly ApiUser _user;

        public HomeController(IOptions<XeroApiSettings> settings)
        {
            _user = XeroApiHelper.User();

            _authenticator = XeroApiHelper.MvcAuthenticator(settings.Value);
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
