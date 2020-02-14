# Xero OAuth2 .Net SDK

This code is generated from the openapi-generator based on [Xero OpenAPI 3.0 Specification](https://github.com/XeroAPI/Xero-OpenAPI)

[![NuGet.org](https://img.shields.io/badge/NuGet.org-Xero.NetStandard.OAuth2.v0.1.0-brightgreen?style=plastic&logo=appveyor)](https://www.nuget.org/packages/Xero.NetStandard.OAuth2/)

# Current release of SDK with OAuth2 support
Version Xero-NetStandard SDK only supports OAuth2 authentication and the following API sets.
* accounting
* identity

Coming soon
* bank feeds 
* projects
* payroll
* files 
* fixed asset 
* xero hq

## How to handle OAuth 2.0 authentication & authorization?
We have built Xero OAuth 2.0 Client. Check out [Xero.NetStandard.OAuth2Client](https://github.com/XeroAPI/Xero-NetStandard/tree/oauth2/Xero.NetStandard.OAuth2Client)

[![NuGet.org](https://img.shields.io/badge/NuGet.org-Xero.NetStandard.OAuth2Client.v0.0.2-brightgreen?style=plastic&logo=appveyor)](https://www.nuget.org/packages/Xero.NetStandard.OAuth2Client/)

To learn more about how our OAuth 2.0 flow works and how to use the OAuth 2.0 client, check out our Xero developer blog post: [Up and running with .NET and Xero OAuth 2.0](https://devblog.xero.com/xero-oauth-2-with-ruby-313a6ea37989)

## Looking for previous SDK with oAuth 1.0a support?
Codebase, samples and setup instructions located in [oauth1 branch](https://github.com/XeroAPI/Xero-NetStandard/tree/oauth1).

## Getting Started

### Create a Xero App
Follow these steps to create your Xero app

* Create a free Xero user account (if you don't have one)
* Use this URL for beta access to oAuth2 [https://developer.xero.com/myapps](https://developer.xero.com/myapps)
* Click "New app" link
* Enter your App name, company url, privacy policy url, and redirect URI (this is your callback url - localhost, etc)
* Agree to terms and condition and click "Create App".
* Click "Generate a secret" button.
* Copy your client id and client secret and save for use later.
* Click the "Save" button. You secret is now hidden.

### Installation
Use Nuget to download the package
```
	dotnet add package Xero.NetStandard.OAuth2
	dotnet add package Xero.NetStandard.OAuth2Client
```
or using the Package Manager Console inside Visual Studio

```
	Install-Package Xero.NetStandard.OAuth2
	Install-Package Xero.NetStandard.OAuth2Client
```
or you can download the source code from https://github.com/XeroAPI/Xero-NetStandard and compile it by yourself.

To get started there are a few main classes.

* The AccountingApi class
* XeroOAuth2

The AccountingApi class is not coupled to the OAuth2 class, so feel free to use your own.


To get started you will just need two things to make calls to the Accounting Api.
* xero-tenant-id
* accessToken


Build the login link (a .NET Core Mvc example):
```csharp
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Xero.NetStandard.OAuth2.Client;
    using Xero.NetStandard.OAuth2.Config;
    using Xero.NetStandard.OAuth2.Token;
    using Microsoft.Extensions.Options;
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Xero.NetStandard.OAuth2.Models;
    using System.Collections.Generic;


    namespace XeroNetStandardApp.Controllers
    {
      public class XeroOauth2Controller : Controller
      {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<XeroConfiguration> XeroConfig;
        private readonly IHttpClientFactory httpClientFactory;

        public XeroOauth2Controller(IOptions<XeroConfiguration> config, IHttpClientFactory httpClientFactory, ILogger<HomeController> logger)
        {
          _logger = logger;
          this.XeroConfig = config;
          this.httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
          XeroConfiguration xconfig = new XeroConfiguration();
          xconfig.ClientId = "yourClientId";
          xconfig.ClientSecret = "yourClientSecret";
          xconfig.CallbackUri = new Uri("https://localhost:5001"); //default for standard webapi template
          xconfig.Scope = "openid profile email offline_access files accounting.transactions accounting.contacts";

          var client = new XeroClient(xconfig, httpClientFactory);

          return Redirect(client.BuildLoginUri());
        }
      }
    }
```

From here the user will be redirected to login, authorise access and get redirected back

On the way back you will get a parameter with code and state
* code
* state

```csharp
	XeroConfiguration xconfig = new XeroConfiguration(); 
    
	xconfig.ClientId = "yourClientId";
	xconfig.ClientSecret = "yourClientSecret";
	xconfig.CallbackUri = new Uri("https://localhost:5001") //default for standard webapi template
	xconfig.Scope = "openid profile email files accounting.transactions accounting.contacts offline_access";
	
	var client = new XeroClient(xconfig);
	
	//before getting the access token please check that the state matches
	await client.RequestAccessTokenAsync(code, "yourState");
    
	//from here you will need to access your Xero Tenants
	List<Tenant> tenants = await client.GetConnections();
    
	// you will now have the tenant id and access token
	foreach (Tenant tenant in tenants)
	{
		// do something with your tenant and access token
		//client.AccessToken;
		//tenant.TenantId;
	}
```

To refresh your token. Just call the refresh 
```csharp
	xeroClient.RefreshTokenAsync(xeroToken); //use the latest token you have
```

```csharp
	//Here is a full example using a webapi
	[HttpGet]
	public async Task<ActionResult> Index(string code, string state)
	{
		var client = new XeroClient(config.Value, httpClientFactory);
		var xeroToken = (XeroOAuth2Token)await client.RequestXeroTokenAsync(code);
		TokenUtilities.StoreToken(Environment.MachineName, xeroToken);
		return RedirectToAction("Invoices", "Accounting");
	}
```

To setup the main API object see the snippet below

```csharp
	var AccountingApi = new AccountingApi();
	var response = await AccountingApi.GetInvoicesAsync(accessToken, xeroTenantId);
	
	Console.WriteLine(AccountingApi.GetInvoices().ToJson();)
```

## TLS 1.0 deprecation
As of June 30, 2018, Xero's API will remove support for TLS 1.0.  

The easiest way to force TLS 1.2 is to set the Runtime Environment for your server (Tomcat, etc) to Java 1.8 which defaults to TLS 1.2.

## License

This software is published under the [MIT License](http://en.wikipedia.org/wiki/MIT_License).

	Copyright (c) 2019 Xero Limited

	Permission is hereby granted, free of charge, to any person
	obtaining a copy of this software and associated documentation
	files (the "Software"), to deal in the Software without
	restriction, including without limitation the rights to use,
	copy, modify, merge, publish, distribute, sublicense, and/or sell
	copies of the Software, and to permit persons to whom the
	Software is furnished to do so, subject to the following
	conditions:

	The above copyright notice and this permission notice shall be
	included in all copies or substantial portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
	EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
	OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
	NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
	HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
	WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
	FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
	OTHER DEALINGS IN THE SOFTWARE.
