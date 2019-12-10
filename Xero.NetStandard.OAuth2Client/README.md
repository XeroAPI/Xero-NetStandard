# Xero .Net OAuth Client SDK

This package will allow you to connect to Xero using OAuth2 and the authorisation code flow. It will build you a login URL, redirect your user, take the code and state to get an accessToken and finally get tenants. 

Use Nuget to download the package
```
dotnet add package Xero.NetStandard.OAuth2Client

```
or using the Package Manager Console inside Visual Studio

```
Install-Package Xero.NetStandard.OAuth2Client
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
```

From here the user will be redirected to login, authorise access and get redirected back

On the way back you will get a parameter with code and state
* code
* state

```csharp

XeroConfiguration xeroConfig = new XeroConfiguration(); 
    xeroConfig.ClientId = "yourClientId";
    xeroConfig.ClientSecret = "yourClientSecret";
    xeroConfig.CallbackUri = new Uri("https://localhost:5001") //default for standard webapi template
    xeroConfig.Scope = "openid profile email files accounting.transactions accounting.contacts offline_access";
    var client = new XeroClient(xeroConfig);
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


To setup the main API object see the snippet below

```csharp
//
var AccountingApi = new AccountingApi();
var response = await AccountingApi.GetInvoicesAsync(accessToken, xeroTenantId);
Console.WriteLine(AccountingApi.GetInvoices().ToJson());

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
