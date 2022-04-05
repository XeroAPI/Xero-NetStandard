# Xero-NetStandard
[![Github forks](https://img.shields.io/github/forks/XeroAPI/Xero-NetStandard.svg)](https://github.com/XeroAPI/Xero-NetStandard/network)
[![Github stars](https://img.shields.io/github/stars/XeroAPI/Xero-NetStandard.svg)](https://github.com/XeroAPI/Xero-NetStandard/stargazers)

The Xero-NetStandard SDK makes it easy for developers to access Xero's APIs in their Csharp code, and build robust applications and software using small business & general ledger accounting data.

# Table of Contents
- [API Client documentation](#api-client-documentation)
- [Sample Applications](#sample-applications)
- [Xero Account Requirements](#xero-account-requirements)
- [Installation](#installation)
- [Configuration](#configuration)
- [Authentication](#authentication)
- [Auth with PKCE](#auth-with-pkce)
- [Custom Connections](#custom-connections)
- [App Store Subscriptions](#app-store-subscriptions)
- [API Clients](#api-clients)
- [Helper Methods](#helper-methods)
- [Usage Examples](#usage-examples)
- [SDK conventions](#sdk-conventions)
- [Contributing](#contributing)

<hr>

## API Client documentation
This SDK supports full method coverage for the following Xero API sets:

| API Set | Description |
| --- | --- |
| [`Accounting`](https://xeroapi.github.io/Xero-NetStandard/accounting/index.html) | The Accounting API exposes accounting functions of the main Xero application *(most commonly used)*
| [Assets](https://xeroapi.github.io/Xero-NetStandard/assets/index.html) | The Assets API exposes fixed asset related functions of the Xero Accounting application |
| [Files](https://xeroapi.github.io/Xero-NetStandard/files/index.html) | The Files API provides access to the files, folders, and the association of files within a Xero organisation |
| [Projects](https://xeroapi.github.io/Xero-NetStandard/projects/index.html) | Xero Projects allows businesses to track time and costs on projects/jobs and report on profitability |
| [Payroll (AU)](https://xeroapi.github.io/Xero-NetStandard/payroll-au/index.html) | The (AU) Payroll API exposes payroll related functions of the payroll Xero application |
| [Payroll (UK)](https://xeroapi.github.io/Xero-NetStandard/payroll-uk/index.html) | The (UK) Payroll API exposes payroll related functions of the payroll Xero application |
| [Payroll (NZ)](https://xeroapi.github.io/Xero-NetStandard/payroll-nz/index.html) | The (NZ) Payroll API exposes payroll related functions of the payroll Xero application |
| [Bankfeeds](https://xeroapi.github.io/Xero-NetStandard/bankfeeds/index.html) | The Bankfeeds API facilitates the flow of transaction and statement data |
| [AppStore](https://xeroapi.github.io/Xero-NetStandard/appstore/index.html) | The AppStore API encapsulates subscription based endpoints |

<img src="https://i.imgur.com/6sWYrEl.png" alt="drawing" width="300"/>

<hr>

## Sample Applications
Sample apps can get you started quickly with simple auth flows to advanced usage.
| Sample App | Description | Screenshot |
| --- | --- | --- |
| [`xero-netstandard-oauth2-app`](https://github.com/XeroAPI/xero-netstandard-oauth2-app) | This is a companion app built with .NET Core 3.1 MVC to demonstrate Xero OAuth 2.0 Client Authentication & OAuth 2.0 APIs. | <img src="https://i.imgur.com/7vmC39L.png" alt="gif" width="300"/>
| [`xero-netstandard-oauth2-starter-dotnet-core`](https://github.com/XeroAPI/xero-netstandard-oauth2-starter-dotnet-core) | This is a starter app build with .NET Core 3.1 MVC to demonstrate Xero OAuth 2.0 Client Authentication & OAuth 2.0 APIs. | <img src="https://user-images.githubusercontent.com/41350731/76293982-27636380-6306-11ea-8b83-e4dda46b7365.gif" alt="gif" width="300"/>
| [`xero-netstandard-oauth2-blazor-pkce`](https://github.com/XeroAPI/xero-netstandard-oauth2-blazor-pkce) | This project is a Blazor WebAssembly Demo Application demonstrating the use of the Xero Files API, using the Xero NetStandard SDK to upload and delete files, folders and associations. | <img src="https://github.com/XeroAPI/xero-netstandard-oauth2-blazor-pkce/raw/main/demonstration.gif" alt="blazor" width="500"/>
| [`Xero-NetStandard-custom-connections-starter`](https://github.com/XeroAPI/Xero-NetStandard-custom-connections-starter) | A getting started command line app showing Custom Connections (aka `client_credentials` auth) a Xero [premium option](https://developer.xero.com/documentation/oauth2/custom-connections) for building M2M integrations to a single org | <img src="https://i.imgur.com/WDDRe5F.png" alt="customs-starter" width="300"/>
| [`xeropracticemanager-dotnetcore-oauth2-sample`](https://github.com/XeroAPI/xeropracticemanager-dotnetcore-oauth2-sample) | This is an example dotnet core MVC application making use of Xero sign in, and Xero Practice Manager API access using OAuth2.0. | <img src="https://github.com/XeroAPI/xeropracticemanager-dotnetcore-oauth2-sample/raw/master/Docs/Images/redirecturis.png" alt="customs-starter" width="300"/>
| [`Xero-NetStandard-Webhooks-Receiver`](https://github.com/XeroAPI/Xero-NetStandard-Webhooks-Receiver) | This application demonstrates how to receive webhooks from Xero. | <img src="https://i.imgur.com/CrAOISQ.png" alt="customs-starter" width="300"/>

<hr>

## Xero Account Requirements
- Create a [free Xero user account](https://www.xero.com/us/signup/api/)
- Login to your Xero developer [dashboard](https://developer.xero.com/app/manage) and create an API application
- Copy the credentials from your API app and store them using a secure ENV variable strategy
- Decide the [neccesary scopes](https://developer.xero.com/documentation/oauth2/scopes) for your app's functionality

# Installation
This project is broken into 2 Nuget packages.

[`Xero.NetStandard.OAuth2`](https://www.nuget.org/packages/Xero.NetStandard.OAuth2/) contains code to call all the XeroAPI endpoints

![OAuth2 Endpoints](https://img.shields.io/nuget/v/Xero.NetStandard.OAuth2)
![Xero-NetStandard Downloads](https://img.shields.io/nuget/dt/Xero.NetStandard.OAuth2)

[`Xero.NetStandard.OAuth2Client`](https://www.nuget.org/packages/Xero.NetStandard.OAuth2Client/) code to authenticate and manage tokens

![OAuth2Client](https://img.shields.io/nuget/v/Xero.NetStandard.OAuth2Client)
![Xero-NetStandard Downloads](https://img.shields.io/nuget/dt/Xero.NetStandard.OAuth2Client)

[OAuth2Client README](https://github.com/XeroAPI/Xero-NetStandard/tree/master/Xero.NetStandard.OAuth2Client)

---
Use Nuget to download the packages via command line:
```
dotnet add package Xero.NetStandard.OAuth2
dotnet add package Xero.NetStandard.OAuth2Client
```
Or use the Package Manager Console inside Visual Studio
```
Install-Package Xero.NetStandard.OAuth2
Install-Package Xero.NetStandard.OAuth2Client
```
You can also download the source code from https://github.com/XeroAPI/Xero-NetStandard and compile it by yourself.

To get started there are a couple main classes:
* The `AccountingApi` class
* `XeroOAuth2`

The `AccountingApi` class is not coupled to the `OAuth2` class so you easily can use another OAuth2 auth flow if you prefer.

To get started you will just need two things to make calls to the Accounting Api.
1. `xero-tenant-id`
2. `accessToken`


## Configuration

```csharp
XeroConfiguration xconfig = new XeroConfiguration();
xconfig.ClientId = "yourClientId";
xconfig.ClientSecret = "yourClientSecret";
xconfig.CallbackUri = new Uri("https://localhost:5001"); //default for standard webapi template
xconfig.Scope = "openid profile email offline_access files accounting.transactions accounting.contacts";

var client = new XeroClient(xconfig);
```

---
## Authentication

### Step 1
Build the login link and send the user through the `authorization_code` flow (a .NET Core Mvc example):

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

### Step 2
The user will be redirected to login, authorise access and get redirected back to your callback

In the callback URI, Xero will return a parameter `code` and `state` (if you passed any)
* code
* state

You can then exchange the temp `code` for a `XeroToken`
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

You can now interact with the OAuth2 token data which has been mapped from Xero's OAuth2 json response.

```json
{
  "id_token": "xxx.yyy.zz",
  "access_token": "xxx.yyy.zzz",
  "expires_in": 1800,
  "token_type": "Bearer",
  "refresh_token": "xxxxxxxxx",
  "scope": "email profile openid accounting.transactions offline_access"
}
```
...to the `XeroToken` object model.
```csharp
xeroToken.AccessToken
xeroToken.RefreshToken
xeroToken.IdToken
xeroToken.TokenType
xeroToken.ExpiresAtUtc
```

*A NOTE on Tokens* 
> You will still need to save the `XeroToken` in your datastore to keep the connection alive until you or the user disconnect. If you have a valid XeroToken in your database you can restart a XeroAPI connection by passing the token to `RefreshAccessTokenAsync` on an initialized `client`.

## Auth with PKCE
First build the login link with the PKCE(Proof Key Code Exchange) flow (a .NET Core Mvc example).

PKCE is suited for mobile and desktop applications that don't have a way to keep the `ClientSecret` private

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

The user will be redirected to login, authorise access and get redirected to your callback. You can then use the `RequestAccessTokenPkceAsync` to exchange for a `XeroToken` set.

```csharp
	XeroConfiguration xconfig = new XeroConfiguration(); 
	xconfig.ClientId = "yourClientId";
	xconfig.CallbackUri = new Uri("https://localhost:5001") //default for standard webapi template
	xconfig.Scope = "openid profile email files accounting.transactions accounting.contacts offline_access";
	
	var client = new XeroClient(xconfig);
  	string codeVerifier = "Aaaaaaaaaa.Bbbbbbbbbb.0000000000.1111111111";

	await client.RequestAccessTokenPkceAsync(code, codeVerifier);
```

---
## Custom Connections 

Custom Connections are a Xero [premium option](https://developer.xero.com/documentation/oauth2/custom-connections) used for building M2M integrations to a single organisation. A custom connection uses OAuth2.0's [`client_credentials`](https://www.oauth.com/oauth2-servers/access-tokens/client-credentials/) grant which eliminates the step of exchanging the temporary code for a token set.

To use this SDK with a Custom Connections `var xeroTenantId = "";` must still be passed to work with a Custom Connection.

Full sample code: https://github.com/XeroAPI/Xero-NetStandard-custom-connections-starter

```csharp
using System;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Config;
using System.Threading.Tasks;

namespace AsyncMain
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DotNetEnv.Env.Load();
            var helloWorld = await GetHelloWorldAsync();
            Console.WriteLine(helloWorld);
        }

        static async Task<string> GetHelloWorldAsync()
        {   
            XeroConfiguration XeroConfig = new XeroConfiguration
            {
                ClientId = System.Environment.GetEnvironmentVariable("CLIENT_ID"),
                ClientSecret = System.Environment.GetEnvironmentVariable("CLIENT_SECRET")
            };

            var client = new XeroClient(XeroConfig);
            var xeroToken = await client.RequestClientCredentialsTokenAsync();

            try {
                var apiInstance = new AccountingApi();
                var ifModifiedSince = DateTime.Parse("2000-02-06T12:17:43.202-08:00");
                var where = "Status==\"ACTIVE\"";
                var xeroTenantId = "";
                var result = await apiInstance.GetAccountsAsync(xeroToken.AccessToken, xeroTenantId, ifModifiedSince, where, null);
                return result.ToJson();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling apiInstance.GetInvoice: " + e.Message );
                return e.ToString();
            }
        }
    }
}
```
Because Custom Connections are only valid for a single organisation you don't need an actual `xero-tenant-id` however the parameter remains and still requires an empty string.

## App Store Subscriptions 
If you are implementing subscriptions to participate in Xero's App Store you will need to setup [App Store subscriptions](https://developer.xero.com/documentation/guides/how-to-guides/xero-app-store-referrals/) endpoints. When a plan is successfully purchased, the user is redirected back to the URL specified in the setup process. The Xero App Store appends the subscription Id to this URL so you can immediately determine what plan the user has subscribed to through the subscriptions API. With your app credentials you can create a client via `client_credentials` grant type with the `marketplace.billing` scope. This unique access_token will allow you to query any functions in `AppStoreApi`. Client Credentials tokens to query app store endpoints will only work for apps that have completed the App Store on-boarding process.

> => /post-purchase-url?subscriptionId=03bc74f2-1237-4477-b782-2dfb1a6d8b21

> csharp.csproj
```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="DotNetEnv" Version="2.1.1" />
    <PackageReference Include="IdentityModel" Version="4.0.0" />
    <PackageReference Include="Xero.NetStandard.OAuth2" Version="3.19.0" />
    <PackageReference Include="Xero.NetStandard.OAuth2Client" Version="1.5.0" />
  </ItemGroup>
</Project>
```
> Program.cs
```csharp
using System;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Config;
using System.Threading.Tasks;

namespace AsyncMain
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DotNetEnv.Env.Load();
            var helloWorld = await GetHelloWorldAsync();
            Console.WriteLine(helloWorld);
        }

        static async Task<string> GetHelloWorldAsync()
        {   
            XeroConfiguration XeroConfig = new XeroConfiguration
            {
                ClientId = System.Environment.GetEnvironmentVariable("APPSTORE_CLIENT_ID"),
                ClientSecret = System.Environment.GetEnvironmentVariable("APPSTORE_CLIENT_SECRET")
            };

            var client = new XeroClient(XeroConfig);
            var xeroToken = await client.RequestClientCredentialsTokenAsync(false);
            
            Guid subscriptionId = Guid.Parse("03bc74f2-1237-4477-b782-2dfb1a6d8b21");

            try {
                var apiInstance = new AppStoreApi();
                var result = await apiInstance.GetSubscriptionAsync(xeroToken.AccessToken, subscriptionId);
                return result.ToJson();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling apiInstance.GetSubscriptionAsync: " + e.Message );
                return e.ToString();
            }
        }
    }
}
```

```json
// dotnet run
{
  "currentPeriodEnd": "2021-09-02T14:08:58.772536Z",
  "id": "03bc74f2-1237-4477-b782-2dfb1a6d8b21",
  "organisationId": "79e8b2e5-c63d-4dce-888f-e0f3e9eac647",
  "plans": [
    {
      "status": "ACTIVE",
      "id": "6abc26f3-9390-4194-8b25-ce8b9942fda9",
      "name": "Small",
      "subscriptionItems": [
        {
          "id": "834cff4c-b753-4de2-9e7a-3451e14fa17a",
          "price": {
            "amount": 10.0000,
            "currency": "NZD",
            "id": "2310de92-c7c0-4bcb-b972-fb7612177bc7"
          },
          "product": {
            "type": "FIXED",
            "id": "9586421f-7325-4493-bac9-d93be06a6a38",
            "name": ""
          },
          "startDate": "2021-08-02T14:08:58.772536Z",
          "testMode": true
        }
      ]
    }
  ],
  "startDate": "2021-08-02T14:08:58.772536Z",
  "status": "ACTIVE",
  "testMode": true
}
```
You should use the subscription data to provision user access/permissions to your application.
### App Store Subscription Webhooks
In additon to a subscription Id being passed through the URL, when a purchase or an upgrade takes place you will be notified via a webhook. You can then use the subscription Id in the webhook payload to query the AppStore endpoints and determine what plan the user purchased, upgraded, downgraded or cancelled.
Refer to Xero's documenation to learn more about setting up and receiving webhooks or review [this blogpost](https://devblog.xero.com/getting-started-with-xero-webhooks-and-net-cbda8b7f5b5) explaing webhooks using this sdk.
> https://developer.xero.com/documentation/guides/webhooks/overview/

---
## API Clients
You can access the different API sets and their available methods through the following:

```csharp
var AccountingApi = new AccountingApi();
var AssetApi = new AssetApi();
var BankFeedsApi = new BankFeedsApi();
var FilesApi = new FilesApi();
var IdentityApi = new IdentityApi();
var PayrollAUApi = new PayrollAUApi();
var PayrollNZApi = new PayrollNZApi();
var PayrollUkApi = new PayrollUkApi();
var ProjectApi = new ProjectApi();
var AppStoreApi = new AppStoreApi();
```
---
## Helper Methods

A full list of the SDK client's methods:

```csharp
XeroConfiguration xconfig = new XeroConfiguration();
xconfig.ClientId = "yourClientId";
xconfig.ClientSecret = "yourClientSecret";
xconfig.CallbackUri = new Uri("https://localhost:5001");
xconfig.Scope = "openid profile email offline_access files accounting.transactions ...etc";

var client = new XeroClient(xconfig);
```
| Method | Description |
| --- | --- |
| client.`BuildLoginUri()` | Returns a Xero authorize URI to start OAuth flow
| client.`BuildLoginUri(string state, string scope)` | Returns a Xero authorize URI (with state attached) to start OAuth flow
| client.`BuildLoginUriPkce(string codeVerifier, string state, string scope)` | Returns a Xero authorize URI to start OAuth flow with PKCE
| client.`GetConnectionsAsync(IXeroToken xeroToken)` | List of Tenants attached to accesstoken
| client.`DeleteConnectionAsync(IXeroToken xeroToken, Tenant xeroTenant)` | List of remaining Tenants attached to accesstoken
| client.`RevokeAccessTokenAsync(IXeroToken xeroToken)` | Revokes a IXeroToken and returns null
| client.`RefreshAccessTokenAsync(IXeroToken xeroToken)` | Returns a IXeroToken
| client.`RequestClientCredentialsTokenAsync(Boolean fetchTenants=true)` | Returns a IXeroToken, and defaults to calling GetConnections unless specified
| client.`RequestAccessTokenAsync(string code)` | Returns a IXeroToken
| client.`RequestAccessTokenPkceAsync(string code, string codeVerifier)` | Returns a IXeroToken
| client.`GetCurrentValidTokenAsync(IXeroToken xeroToken)` | Returns a IXeroToken
---

## Usage Examples

### Refresh your token
- Call the refresh (shared between code & PKCE flows)
```csharp
client.RefreshTokenAsync(xeroToken);
```

### Accounting API
---
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

### Fixed Asset API
---
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

### Payroll AU API
---
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

### Bankfeed API
---
Before trying the APIs, please make sure your company had been approved for Bankfeed endpoints and have the bankfeed scope enabled on your Xero OAuth 2.0 app. If you intend to become a Xero bankfeed partner please start by [registering here](https://developer.xero.com/partner/app-partner). 

- Create a bankfeed connection
```csharp
var feedConnection = new FeedConnection{
  AccountToken = accountToken, 
  AccountNumber = accountNumber,
  AccountType =  accountTypeEnum,
  AccountName = accountName,
  Currency = currencyCode,
  Country = countryCode
};

List<FeedConnection> list = new List<FeedConnection>();
list.Add(feedConnection);

FeedConnections items = new FeedConnections{
  Pagination = new Pagination(),
  Items = list
};

var BankfeedsApi = new BankFeedsApi();
await BankfeedsApi.CreateFeedConnectionsAsync(accessToken, xeroTenantId, items);
```

- Get all bankfeed connections
```csharp
var BankFeedsApi = new BankFeedsApi();
var response = await BankFeedsApi.GetFeedConnectionsAsync(accessToken, xeroTenantId);
var feedConnections = response.Items;
```

- Delete a bankfeed connection
```csharp
Guid bankfeedConnectionIdGuid = Guid.Parse(bankfeedConnectionId);

List<FeedConnection> list = new List<FeedConnection>();

list.Add(
  new FeedConnection {
    Id = bankfeedConnectionIdGuid
  }
);

var feedConnections = new FeedConnections{
    Items = list
};

var BankFeedsApi = new BankFeedsApi();
await BankFeedsApi.DeleteFeedConnectionsAsync(accessToken, xeroTenantId, feedConnections);
```
- Create statements against a bankfeed connection (plase ensure your start balance, end balance and statement amounts are mathematically correct)
```csharp
StartBalance startBalance = new StartBalance{
  Amount = decimal.Parse(startBalanceAmount),
  CreditDebitIndicator = startIndicatorEnum
};

StatementLine statementLine = new StatementLine{
  PostedDate = DateTime.Today,
  Description = "A bankfeed satemement description",
  Amount = 10,
  CreditDebitIndicator = startIndicatorEnum,
  TransactionId = new Guid().ToString()
};

EndBalance endBalance = new EndBalance{
  Amount = decimal.Parse(startBalanceAmount) + statementLine.Amount,
  CreditDebitIndicator = startIndicatorEnum
};

List<StatementLine> statementLines = new List<StatementLine>();
statementLines.Add(statementLine);

var statement = new Statement{
  FeedConnectionId = new Guid(feedConnectionId),
  StartDate = DateTime.Today.AddDays(-20),
  EndDate = DateTime.Today,
  StartBalance = startBalance,
  EndBalance = endBalance,
  StatementLines = statementLines,
};

List<Statement> statementList = new List<Statement>();
statementList.Add(statement);

Statements statements = new Statements{
  Pagination = new Pagination(),
  Items = statementList
};

var BankfeedsApi = new BankFeedsApi();
await BankfeedsApi.CreateStatementsAsync(accessToken, xeroTenantId, statements);
```

- Get all statements from all bankfeed connections
```csharp
var BankFeedsApi = new BankFeedsApi();
var response = await BankFeedsApi.GetStatementsAsync(accessToken, xeroTenantId);
```
For full documentation please refer to [Xero Bankfeed API documentation](https://developer.xero.com/documentation/bank-feeds-api/overview). 

### Files API
---
- Upload a file: 
```csharp
var FilesApi = new FilesApi();

// Convet IFormFile to byte array
byte[] byteArray; 
using (MemoryStream data = new MemoryStream())
{
  file.CopyTo(data);
  byteArray = data.ToArray();
}

// Upload file
var response = await FilesApi.UploadFileAsync(
    accessToken,
    xeroTenantId,
    null,
    byteArray,
    file.FileName,
    file.ContentType
);
```
- Get Files: 
```csharp
var FilesApi = new FilesApi();
var response = await FilesApi.GetFilesAsync(accessToken, xeroTenantId);
var filesItems = response.Items;
```
- Delete a File: 
```csharp
Guid fileIDGuid = Guid.Parse(fileID);

var filesApi = new FilesApi();
await filesApi.DeleteFileAsync(accessToken, xeroTenantId, fileIDGuid);
```
- Rename a File: 
```csharp
Guid fileIDGuid = Guid.Parse(fileID);

var filesApi = new FilesApi();
FileObject file = await filesApi.GetFileAsync(accessToken, xeroTenantId, fileIDGuid);
file.Name = newName;

var response = await filesApi.UpdateFileAsync(accessToken, xeroTenantId, fileIDGuid, file);
```
- Get Associations
```csharp
var FilesApi = new FilesApi();
var response = await FilesApi.GetFileAssociationsAsync(accessToken, xeroTenantId, new Guid(fileId));
```
- Create an Association
```csharp
var FilesApi = new FilesApi();

var fileIdGuid = new Guid(fileId);
var invoiceIdGuid = new Guid(invoiceId);
Enum.TryParse<ObjectType>(objectType, out var objectTypeEnum);

Association association = new Association{
    FileId = fileIdGuid,
    ObjectId = invoiceIdGuid,
    ObjectType = objectTypeEnum,
    ObjectGroup = ObjectGroup.Invoice
};

var response = await FilesApi.CreateFileAssociationAsync(accessToken, xeroTenantId, fileIdGuid, association);
```
- Delete an Association
```csharp
var fileIdGuid = new Guid(fileId);
var objectIdGuid = new Guid(objectId);

var FilesApi = new FilesApi();
await FilesApi.DeleteFileAssociationAsync(accessToken, xeroTenantId, fileIdGuid, objectIdGuid);
```

---
## SDK conventions

## Security (state check & Jwt validation)
Checking state in OAuth 2.0 flow can prevent CSFR attack. When acccess token and id token is returned, it is also security best practice to validate them. 

Examples of checking state and jwt validation: 

```csharp
      var clientState = TokenUtilities.GetCurrentState();
      
      if (state != clientState) {
        return Content("Cross site forgery attack detected!");
      }    

      var client = new XeroClient(XeroConfig.Value);
      var xeroToken = (XeroOAuth2Token)await client.RequestAccessTokenAsync(code);

      var decodedIdToken = JwtUtils.decode(xeroToken.IdToken);

      if ( !JwtUtils.validateIdToken(xeroToken.IdToken, XeroConfig.Value.ClientId) )
      {
        return Content("ID token is not valid");
      }

      if ( !JwtUtils.validateAccessToken(xeroToken.IdToken) )
      {
        return Content("Access token is not valid");
      }
```

### TLS 1.0 deprecation
As of June 30, 2018, Xero's API will remove support for TLS 1.0.  

The easiest way to force TLS 1.2 is to set the Runtime Environment for your server (Tomcat, etc) to Java 1.8 which defaults to TLS 1.2.

---
## Contributing
This SDK is one of a number of SDK’s that the Xero Developer team builds and maintains. We are grateful for all the contributions that the community makes. 

Here are a few things you should be aware of as a contributor:
* Xero has adopted the Contributor Covenant [Code of Conduct](https://github.com/XeroAPI/Xero-NetStandard/blob/master/CODE_OF_CONDUCT.md), we expect all contributors in our community to adhere to it
* If you raise an issue then please make sure to fill out the github issue template, doing so helps us help you 
* You’re welcome to raise PRs. As our SDKs are generated we may use your code in the core SDK build instead of merging your code directly.
* We have a [contribution guide](https://github.com/XeroAPI/Xero-NetStandard/blob/master/CONTRIBUTING.md) for you to follow when contributing to this SDK
* Curious about how we generate our SDK’s? Have a [read of our process](https://devblog.xero.com/building-sdks-for-the-future-b79ff726dfd6) and have a look at our [OpenAPISpec](https://github.com/XeroAPI/Xero-OpenAPI)
* This software is published under the [MIT License](https://github.com/XeroAPI/Xero-NetStandard/blob/master/LICENSE)
 
For questions that aren’t related to SDKs please refer to our [developer support page](https://developer.xero.com/support/).
