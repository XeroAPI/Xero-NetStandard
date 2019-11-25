# Xero OAuth2 .Net SDK

This code is generated from the openapi-generator. 


# Current release of SDK with OAuth2 support
Version 0.0.1Beta of Xero-NetStandard SDK only supports OAuth2 authentication and the following API sets.
* accounting

Coming soon
* fixed asset 
* bank feeds 
* files 
* payroll
* projects
* xero hq
## Getting Started

### Installation
Use Nuget to download the package
```
dotnet add package Xero.NetStandard.OAuth2 --version 0.0.2-beta
dotnet add package Xero.NetStandard.OAuth2Client --version 0.0.1-beta
```
or using the Package Manager Console inside Visual Studio

```
Install-Package Xero.NetStandard.OAuth2
Install-Package XXero.NetStandard.OAuth2Client

```
or you can download the source code from https://github.com/XeroAPI/Xero-NetStandard and compile it by yourself.


### Create a Xero App
Follow these steps to create your Xero app

* Create a free Xero user account (if you don't have one)
* Use this URL for beta access to oAuth2 [https://developer.xero.com/myapps?code=oauth2create](https://developer.xero.com/myapps?code=oauth2create)
* Click "or Try oAuth2" link
* Enter your App name, company url, privacy policy url, and redirect URI (this is your callback url - localhost, etc)
* Agree to terms and condition and click "Create App".
* Click "Generate a secret" button.
* Copy your client id and client secret and save for use later.
* Click the "Save" button. You secret is now hidden.

To get started there are a few main classes.

* The AccountingApi class
* XeroOAuth2

The AccountingApi class is not coupled to the OAuth2 class, so feel free to use your own.


To get started you will just need two things to make calls to the Accounting Api.
* xero-tenant-id
* accessToken


Build the login link
```csharp

XeroConfiguration xconfig = new XeroConfiguration();
    xconfig.ClientId = "yourClientId";
    xconfig.ClientSecret = "yourClientSecret";
    xconfig.CallbackUri = new Uri("https://localhost:5001") //default for standard webapi template
    xconfig.Scope = "openid profile email files accounting.transactions accounting.contacts offline_access";
    var client = new XeroClient(xconfig);
    //build login link
    Console.WriteLine(client.BuildLoginUri());
//In the example app, I've used the config via appsettings so it becomes:
            var client = new Xero.NetStandard.OAuth2.Client.XeroClient(config.Value, httpClientFactory);

    
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
//
var AccountingApi = new AccountingApi();
var response = await AccountingApi.GetInvoicesAsync(accessToken, xeroTenantId);
Console.WriteLine(AccountingApi.GetInvoices().ToJson();)

```

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
