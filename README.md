# Note: This readme is still a direct copy from the one at XeroAPI/Xero-Net and so some of the information will be out of date and irrelevent. Please see release notes and runnable examples to get going.

Xero-Net
========
[![xero-api-sdk MyGet Build Status](https://www.myget.org/BuildSource/Badge/xero-api-sdk?identifier=045754d8-de3f-4f0c-960a-ae6e16608e24)](https://www.myget.org/)
[![Build status](https://ci.appveyor.com/api/projects/status/087ia0i385l506bn/branch/master?svg=true)](https://ci.appveyor.com/project/XeroAPI/xero-net/branch/master)

A skinny wrapper of the Xero API. Supports Payroll. All third party libraries are included as source code.

* [Installation](#installation)
* [What is supported?](#what-is-supported)
* [Things to note](#things-to-note)
* [Samples](#samples)
* [Querying](#querying)
* [Applications](#application-types)
* [Authenticators](#authenticators)
* [Token Stores](#token-stores)
* [Serialization](#serialization)
* [Usage](#usage)
* [Acknowledgements](#acknowledgements)
* [License](#license)

## Installation

There are different way to install this library:

1. Download the source code from github and compile yourself: **https://github.com/XeroAPI/Xero-Net**
2. Download directly into Visual Studio using the NuGet powershell command **PM&gt; Install-Package Xero.API.SDK.Minimal** to get a minimal installation.
3. Download directly into Visual Studio using the NuGet powershell command: **PM&gt; Install-Package Xero.API.SDK** to get a larger installation with sample token store using [SQLite](http://system.data.sqlite.org/).

## What is supported?
### Core
* Accounts - Create, Find and Update
* Attachments - Add, Get and List
* Bank Transactions - Create, Find and Update
* Bank Transfers - Create and Find
* Branding Themes - Find
* Contacts - Create, Find and Update
* Credit Notes - Create, Find and Update
* Currencies - Find
* Employees - Create, Find and Update
* Expense Claims - Create, Find and Update
* Invoices - Create, Find and Update
* Items - Create, Find and Update
* Journals - Find
* Manual Journals - Create, Find and Update
* Organisation - Find
* Payments - Create, Find and Update
* Purchase Orders - Create, Find and Update
* Receipts - Create, Find and Update
* Repeating Invoices - Find
* Reports - Find
* Setup - Create and Update
* Tax Rates - Create, Find and Update
* Tracked Inventory - Create and Update Tracked Inventory Items. Purchase, sell, and adjust inventory
* Tracking Categories - Create, Find and Update. Add, Update and Remove TrackingOptions
* Users - Find

### Australian Payroll
* Employees - Create and Find
* Leave Applications - Create and Find
* Pay Runs - Create and Find
* Payroll Calenders- Create and Find
* Pay Slips- Create and Find
* Settings - Find
* Super Fund Products - Find
* Super Funds - Create and Find
* Timesheets - Create and Find

### United States Payroll
* Employees - Create and Find
* Pay Runs - Create and Find
* Pay Schedules - Create and Find
* Pay Stubs- Create and Find
* Settings - Find
* Timesheets - Create and Find
* Work Locations - Create and Find

### Files API
* Files - Find, Add, Rename, Move, Remove and Get Content
* Folders - Find, Add, Rename and Remove
* Inbox - Find

## Things to note
* The library tries to do as little as possible and provides a basis to be extended. There are examples of TokenStores, Authenticators and Application types. These examples provide enough to get you going, but are not a complete solution to all your needs. You will need to adapt them for your own use and situation. Private application will work out of the box, as they do not have to deal with tokens and OAuth.
* The HTTP verbs are not used in the public part of the API. Create, Update and Find are used instead. This seperates the implementation from the the intent.
* Some accounting endpoints support pagination. In the RESTful API these are off by default. For the wrapper, they are always on and default to page 1. See the Counts or Creation code examples for how to use the Page method to get all items.
* Contacts support including archived contacts. Like the RESTful API, this if off by default. Use IncludeArchived(true) to include them.
* Payroll supports paging on all endpoints.
* Four decimal places are supported and are always on.
* You will need an instance of the API per organisation / connection. The connection is stored as part of the API instance.
* Query parameters are cleared after each operation on an endpoint. If you use Invoices.Where("Type == \"ACCREC\"").Find() when querying invoices for example, the next Invoices.Find() will not retain the where clause query parameter.

## Samples
There are samples for each of the API endpoints. These have been done as console application and also a collection of NUnit tests. See the README for each of the executable and test assemblies. The test projects contain lots of useful examples of how to use this library to interact with the Xero API.

## Querying
There are simple filters on different endpoints.

* ModifiedSince
* Where
* Or
* And
* OrderBy
* OrderByDescending
* Page
* Offset

They are used in a [Fluent](http://en.wikipedia.org/wiki/Fluent_interface) way, but are not LINQ. They simply create a query for the URL passed to the API. Nested queries are not handled using the syntax. Or and And need to come after a Where statement. OrderBy, OrderByDescending and Page can come anywhere.
```csharp
var invoices = xeroApi.Invoices  
	.ModifiedSince(new DateTime(2014, 1, 31))  
	.Where("Total > 3500.0")  
	.And("Total < 10000.0")  
	.Page(2)  
	.OrderByDescending("DueDate")  
	.Find();
```
The following gives the same query string to the API as the example above.
```csharp
var invoices = xeroApi.Invoices  
	.Page(2)  
	.OrderByDescending("DueDate")  
	.Where("Total > 3500.0")   
	.And("Total < 10000.0")  
	.ModifiedSince(new DateTime(2014, 1, 31))  
	.Find();
```		
## Application types

There are specific classes for each of the application types. If these are used, you will need to have the app.config file settings for your organisation.

For a public application you would use
```csharp
var user = new ApiUser { Name = "The users name" };
var tokenStore = new SqliteTokenStore();

var api = new Applications.Public.Core(tokenStore, user)
{
    UserAgent = "Something to show your application"
};
```
The config file will look like this
```xml
<add key="BaseUrl" value="https://api.xero.com"/>
<add key="ConsumerKey" value="Your Key"/>
<add key="ConsumerSecret" value="Your secret"/>
<add key="CallbackUrl" value="Your callback"/>
```
There are classes for Private, Public and Partner applications for the Core Xero API and Australian and American Payrolls.

A private application will need to also populate
```xml
<add key="SigningCertificate" value="Path to .pfx file"/>
```
A partner application will need to also populate
```xml
<add key="SigningCertificate" value="Path to .pfx file"/>
```
## Authenticators

The application classes all use implementations of IAuthenticator. See [PrivateAuthenticator](https://github.com/XeroAPI/Xero-Net/blob/master/Xero.Api.Example.Applications/Private/PrivateAuthenticator.cs) for an example. The authenticators are used by the base infrastructure to do the heavy lifting of the Xero API authentication.

### PrivateAuthenticator
Uses RSA-SHA1 and a public/private certificate. There are no tokens and each request has to be signed.

### PublicAuthenticator
Uses HMAC-SHA1 and the standard 3-legged [OAuth](http://tools.ietf.org/html/rfc6749) process. Tokens last for 30 minutes and cannot be renewed.

### PartnerAuthenticator
Uses RSA-SHA1 and then the standard 3-legged [OAuth](http://tools.ietf.org/html/rfc6749) process with an additional signing certificate. Tokens last for 30 minutes and be renewed. Token renewal is supported by this provider.

Examples for renewing your access tokens can be seen in the RenewToken method overrides in the PartnerAuthenticator.cs and PartnerMVCAuthenticator.cs classes.


### OAuth signing
All the signing is done by a slightly modified version of the Dust library provided by [Ben Biddington](https://github.com/ben-biddington/dust). Source is included.

## Token Stores
The token store implementations are separate and optional. (It is recommended that you do have a store.)

The interface ITokenStore has three methods.
```csharp
public interface ITokenStore
{
	IConsumer Find(string user);
	void Add(IToken token);
	void Delete(IToken token);
}
```
You can provide your own implementation to suit the database you are using for your product. Ensure the dates on the token are stored in UTC.

The examples are

* MemoryTokenStore - Dictionary of token in RAM keyed on UserId
* SqliteTokenStore - A database of tokens (file on local disk). This does not support multiple add-ons in the same database. The tokens are only for the application the database was created by.

## Serialization

All communication with the [Xero API](http://developer.xero.com) is compressed at source. Writing to the API is done with XML. The data model classes have be attributed to give a small XML payload. All communication back from the API is JSON. These details are transparent to the user of the class library.

## Usage
To get going quickly:

1. Follow this getting started guide: http://developer.xero.com/documentation/getting-started/getting-started-guide/
2. Create a console project and download the following package using the NuGet powershell command: PM> Install-Package Xero.API.SDK
3. Use the snippets below depending on the type of application, modifying keys and certificate paths.

Note, remember to implement your own custom token store before going live. The examples provided in the library Xero.Api.Example.TokenStores.dll
are for development only.
```csharp
static void Main(string[] args)
{
	// Private Application Sample
	var private_app_api = new XeroCoreApi("https://api.xero.com", new PrivateAuthenticator(@"C:\Dev\your_public_privatekey.pfx"),
        new Consumer("your-consumer-key", "your-consumer-secret"), null,
        new DefaultMapper(), new DefaultMapper());

	var org = private_app_api.Organisation;

	var user = new ApiUser { Name = Environment.MachineName };

	// Public Application Sample
    var public_app_api = new XeroCoreApi("https://api.xero.com", new PublicAuthenticator("https://api.xero.com", "https://api.xero.com", "oob",
		new MemoryTokenStore()),
        new Consumer("your-consumer-key", "your-consumer-secret"), user,
        new DefaultMapper(), new DefaultMapper());

    var public_contacts = public_app_api.Contacts.Find().ToList();

	// Partner Application Sample
	var partner_app_api = new XeroCoreApi("https://api-partner.network.xero.com", new PartnerAuthenticator("https://api-partner.network.xero.com",
        "https://api.xero.com", "oob", new MemoryTokenStore(),
        @"C:\Dev\your_public_privatekey.pfx"),
         new Consumer("your-consumer-key", "your-consumer-secret"), user,
         new DefaultMapper(), new DefaultMapper());

	var partner_contacts = partner_app_api.Contacts.Find().ToList();			
}
```
## Acknowledgements

Thanks for the following Open Source libraries for making the wrapper and samples easier

* [Dust](https://github.com/ben-biddington/dust) - OAuth
* [Dapper](https://code.google.com/p/dapper-dot-net/) - database access
* [NUnit](http://www.nunit.org/) - unit tests
* [ServiceStack.Text](https://github.com/ServiceStack/ServiceStack.Text/tree/v3) - serialization
* [SQLite](http://http://system.data.sqlite.org/) - file based database

## License

This software is published under the [MIT License](http://en.wikipedia.org/wiki/MIT_License).

	Copyright (c) 2016 Xero Limited

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
