# Xero OAuth2 .Net SDK

This code is generated from the openapi-generator based on [Xero OpenAPI 3.0 Specification](https://github.com/XeroAPI/Xero-OpenAPI)

[![NuGet.org](https://img.shields.io/badge/NuGet.org-Xero.NetStandard.OAuth2.v3.1.0-brightgreen?style=plastic&logo=appveyor)](https://www.nuget.org/packages/Xero.NetStandard.OAuth2/)

# Current release of SDK with OAuth2 support
Version Xero-NetStandard SDK only supports OAuth2 authentication and the following API sets.
* accounting
* fixed asset
* identity
* payroll AU

Coming soon
* bank feeds
* projects
* payroll UK
* payroll NZ
* files
* xero hq

## How to handle OAuth 2.0 authentication & authorization?
We have built Xero OAuth 2.0 Client. Check out [Xero.NetStandard.OAuth2Client](https://github.com/XeroAPI/Xero-NetStandard/tree/oauth2/Xero.NetStandard.OAuth2Client)

[![NuGet.org](https://img.shields.io/badge/NuGet.org-Xero.NetStandard.OAuth2Client.v1.1.0-brightgreen?style=plastic&logo=appveyor)](https://www.nuget.org/packages/Xero.NetStandard.OAuth2Client/)

To learn more about how our OAuth 2.0 flow works and how to use the OAuth 2.0 client, check out our Xero developer blog post: [Up and running with .NET and Xero OAuth 2.0](https://devblog.xero.com/getting-started-with-net-xero-oauth2-0-763ba468a916)

## Looking for previous SDK with oAuth 1.0a support?
Codebase, samples and setup instructions located in [oauth1 branch](https://github.com/XeroAPI/Xero-NetStandard/tree/oauth1).

## Getting Started

## Sample apps
Looking for sample apps for this SDK? A dotnet core 3.1 MVC one is available [here](https://github.com/XeroAPI/xero-netstandard-oauth2-starter-dotnet-core). A .NET Framework 4.6.1 one is availble [here](https://github.com/XeroAPI/xero-netstandard-oauth2-starter-app-dotnet-framework). 

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

** Note: starting from Xero.NetStandard.OAuth2Client v1.0.0, we have dropped the dependency on IHttpClientFatory. Plase refer to older IHttpClientFactory implementation example for ![dotnet core](https://github.com/XeroAPI/xero-netstandard-oauth2-starter-dotnet-core/tree/ihttpclientfactory-example) and ![dotnet framework](https://github.com/XeroAPI/xero-netstandard-oauth2-starter-app-dotnet-framework/tree/ihttpclientfactory-example). 

### Build the login link - the code flow (a .NET Core Mvc example):
```csharp
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Xero.NetStandard.OAuth2.Client;
    using Xero.NetStandard.OAuth2.Config;
    using Xero.NetStandard.OAuth2.Token;
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

        public XeroOauth2Controller(IOptions<XeroConfiguration> config, ILogger<HomeController> logger)
        {
          _logger = logger;
          this.XeroConfig = config;
        }

        public IActionResult Index()
        {
          XeroConfiguration xconfig = new XeroConfiguration();
          xconfig.ClientId = "yourClientId";
          xconfig.ClientSecret = "yourClientSecret";
          xconfig.CallbackUri = new Uri("https://localhost:5001"); //default for standard webapi template
          xconfig.Scope = "openid profile email offline_access files accounting.transactions accounting.contacts";

          var client = new XeroClient(xconfig);

          return Redirect(client.BuildLoginUri());
        }
      }
    }
```

### From here the user will be redirected to login, authorise access and get redirected back

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
	await client.RequestAccessTokenAsync(code);
    
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

### Build the login link - the PKCE flow (a .NET Core Mvc example):
```csharp
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Xero.NetStandard.OAuth2.Client;
    using Xero.NetStandard.OAuth2.Config;
    using Xero.NetStandard.OAuth2.Token;
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

        public XeroOauth2Controller(IOptions<XeroConfiguration> config, ILogger<HomeController> logger)
        {
          _logger = logger;
          this.XeroConfig = config;
        }

        public IActionResult Index()
        {
          XeroConfiguration xconfig = new XeroConfiguration();
          xconfig.ClientId = "yourClientId";
          xconfig.CallbackUri = new Uri("https://localhost:5001"); //default for standard webapi template
          xconfig.Scope = "openid profile email offline_access files accounting.transactions accounting.contacts";
	  xconfig.State = "YOUR_STATE"

          var client = new XeroClient(xconfig);

          // generate a random codeVerifier
          var validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-._~";          
          Random random = new Random();
          int charsLength = random.Next(43, 128);
          char[] randomChars = new char[charsLength];
          for (int i = 0; i < charsLength; i++)  
          {  
              randomChars[i] = validChars[random.Next(0, validChars.Length)];  
          }  
          string codeVerifier = new String(randomChars);

          return Redirect(client.BuildLoginUriPkce(codeVerifier));
        }
      }
    }
```

### From here the user will be redirected to login, authorise access and get redirected back using the Pkce method

```csharp
	XeroConfiguration xconfig = new XeroConfiguration(); 
	xconfig.ClientId = "yourClientId";
	xconfig.CallbackUri = new Uri("https://localhost:5001") //default for standard webapi template
	xconfig.Scope = "openid profile email files accounting.transactions accounting.contacts offline_access";
	
	var client = new XeroClient(xconfig);
  	string codeVerifier = "Aaaaaaaaaa.Bbbbbbbbbb.0000000000.1111111111";

	await client.RequestAccessTokenPkceAsync(code, codeVerifier);
```

### To refresh your token. Just call the refresh (shared between code & PKCE flows)
```csharp
	client.RefreshTokenAsync(xeroToken);
```

To setup the main API object see the snippet below:

### Accounting APIs:
- Get All invoices  
```csharp
	var AccountingApi = new AccountingApi();
	var response = await AccountingApi.GetInvoicesAsync(accessToken, xeroTenantId);
```

- Get invoices from the last 7 days: 
```csharp
      var AccountingApi = new AccountingApi();


      var sevenDaysAgo = DateTime.Now.AddDays(-7).ToString("yyyy, MM, dd");
      var invoicesFilter = "Date >= DateTime(" + sevenDaysAgo + ")";

      var response = await AccountingApi.GetInvoicesAsync(accessToken, xeroTenantId, null, invoicesFilter);
```

- Create an invoice (Accounting APIs): 
```csharp
      var contact = new Contact();
      contact.Name = "John Smith";
      
      var line = new LineItem() {
        Description = "A golf ball",
        Quantity = float.Parse(LineQuantity),
        UnitAmount = float.Parse(LineUnitAmount),
        AccountCode = "200"
      };

      var lines = new List<LineItem>() {
        line
      };

      var invoice = new Invoice() {
        Type = Invoice.TypeEnum.ACCREC,
        Contact = contact,
        Date = DateTime.Today,
        DueDate = DateTime.Today.AddDays(30),
        LineItems = lines
      };

      var invoiceList = new List<Invoice>();
      invoiceList.Add(invoice);

      var invoices = new Invoices();
      invoices._Invoices = invoiceList;

      var AccountingApi = new AccountingApi();
      var response = await AccountingApi.CreateInvoicesAsync(accessToken, xeroTenantId, invoices);
```

### Fixed Asset APIs
- Get All Fixed Assets:
```csharp
      var AssetApi = new AssetApi();
      var response = await AssetApi.GetAssetsAsync(accessToken, xeroTenantId, AssetStatusQueryParam.DRAFT);
```


- Create a fixed asset:
```csharp
      var asset = new Asset() {
        AssetName = "Office Computer",
        AssetNumber = "FA-001"
      };

      var AssetApi = new AssetApi();
      var response = await AssetApi.CreateAssetAsync(accessToken, xeroTenantId, asset);
```

### Identity APIs:
- Get Xero API Tenant/Org connections:
```csharp
      var IdentityApi = new IdentityApi();
      var response = await IdentityApi.GetConnectionsAsync(accessToken);
```

- Delete a Xero API Tenant/Org connection:
```csharp
      Guid connectionIdGuid = Guid.Parse(connectionId);

      var IdentityApi = new IdentityApi();
      await IdentityApi.DeleteConnectionAsync(accessToken, connectionIdGuid);
```

### Payroll AU APIs: 
- Get Employees: 
```csharp
      var PayrollAUApi = new PayrollAUApi();
      var response = await PayrollAUApi.GetEmployeesAsync(accessToken, xeroTenantId);

      var employees = response._Employees;
```

- Create a Employee: 
```csharp
      DateTime dob = DateTime.Today.AddYears(-20);

      HomeAddress homeAddress = new HomeAddress() {
        AddressLine1 = "6 MeatMe Street",
        AddressLine2 = " ",
        Region = State.VIC,
        City = "Long Island",
        PostalCode = "0000", 
        Country = "New York"
      };

      Employee employee = new Employee() {
        FirstName = "Bob",
        LastName = "Belcher",
        DateOfBirth = dob,
        HomeAddress = homeAddress
      };

      var employees = new List<Employee>() { employee };

      var PayrollAUApi = new PayrollAUApi();
      var response = await PayrollAUApi.CreateEmployeeAsync(accessToken, xeroTenantId, employees);
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
