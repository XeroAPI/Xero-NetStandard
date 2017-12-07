Xero-NetStandard
========
[![Build status](https://ci.appveyor.com/api/projects/status/2251yfjmkmkvb1v8/branch/master?svg=true)](https://ci.appveyor.com/project/XeroAPI/xero-netstandard/branch/master)

A wrapper of the Xero API in the .NetStandard 2.0 framework. Supports Accounting, Payroll AU/US, and Files

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

There are different ways to install this library:

1. Download the source code from github and compile yourself: **https://github.com/XeroAPI/Xero-NetStandard**
2. Download directly into Visual Studio using the NuGet powershell command: **PM&gt; Install-Package Xero.Api.SDK.Core**
3. Add the package using the .NET CLI: **dotnet add Xero.Api.SDK.Core**

## What is supported?
### Core
* Accounts - Create, Find and Update
* Allocations - Create Credit Note/Prepayment/Overpayment Allocations
* Attachments - Add, Get and List
* Bank Transactions - Create, Find and Update. Create Prepayments/Overpayments
* Bank Transfers - Create and Find
* Branding Themes - Find
* Contacts - Create, Find and Update
* Contact Groups - Add/Remove contacts
* Credit Notes - Create, Find and Update
* Currencies - Create and Find
* Employees - Create, Find and Update
* Expense Claims - Create, Find and Update
* Invoices - Create, Find, Update and Online Invoice URL
* Items - Create, Find and Update
* Journals - Find
* Linked Transactions - Create, Find, Update and Delete
* Manual Journals - Create, Find and Update
* Organisation - Find
* Overpayments - Find, Create and Update (via Bank Transactions)
* Payments - Create, Find and Update
* Prepayments - Find, Create and Update (via Bank Transactions)
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
* Associations - Find, Create and Delete
* Files - Find, Add, Rename, Move, Remove and Get Content
* Folders - Find, Add, Rename and Remove
* Inbox - Find

## Things to note
* Some accounting endpoints support pagination. In the RESTful API these are off by default. For this SDK, they are always on and default to page 1. You'll neeed to make use of the .Page() methods on pageable to endpoints to get more 
* Contacts support including archived contacts. Like the RESTful API, this if off by default. Use IncludeArchived(true) to include them.
* Payroll supports paging on all endpoints.
* Four decimal places are supported and are always on.
* You will need an instance of the API per organisation/connection. The connection is stored as part of the API instance.
* Query parameters are cleared after each operation on an endpoint. If you use Invoices.Where("Type == \"ACCREC\"").Find() when querying invoices for example, the next Invoices.Find() will not retain the where clause query parameter.
* Requests from this SDK to Xero's API are asynchronous. Asynchronous methods have been named appropriately.
* The Endpoints are immutable. Changing query paramaters will return a new endpoint object with the changes applied only to it. This allows you to make concurrent requests to the same endpoint (or different endpoints) on Xero's API with varying query parameters.

## Samples
There are samples for each of the API endpoints which can be found in the collections of NUnit tests for the different API types. The test projects contain lots of useful examples of how to use this library to interact with the Xero API. There is also an example console application and example MVC application. Look at the specific readmes for the test/example projects for how to get each up and running.

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
	.FindAsync();
```
The following gives the same query string to the API as the example above.
```csharp
var invoices = xeroApi.Invoices  
	.Page(2)  
	.OrderByDescending("DueDate")  
	.Where("Total > 3500.0")   
	.And("Total < 10000.0")  
	.ModifiedSince(new DateTime(2014, 1, 31))  
	.FindAsync();
```		
## Application types

There are [specific classes for each of the application types](https://github.com/XeroAPI/Xero-NetStandard/tree/master/Xero.Api/Infrastructure/Applications). If these are used, you will need to have some details of your application stored in an appsettings.json file.

The config file will look like this
```json
{
  "XeroApi": {
    "BaseUrl": "https://api.xero.com",
    "CallbackUrl": "oob",
    "ConsumerKey": "Key",
    "ConsumerSecret": "Secret",
    "SigningCertPath": "path-to-signing-cert.pfx",
    "SigningCertPassword": "leave blank if your signing cert was created without a password"
  }
}
```

About the settings:
- BaseUrl, ConsumerKey, and ConsumerSecret are rerquired by all application types.
- CallbackUrl must be set to oob or your callback url when using public/partner applications
- SigningCertPath and SigningCertPassword must be set when using private/partner applications. Note if you created your signning certificate with no password you must include a blank value for SigningCertPassword

## Authenticators

The application classes all use [implementations of IAuthenticator](https://github.com/XeroAPI/Xero-NetStandard/tree/master/Xero.Api/Infrastructure/Authenticators). The authenticators are used by the base infrastructure to do the heavy lifting of the Xero API authentication. As public and partner integrations require user interaction to authorise the use of your application, they are abstract, and you will need to implement the retrieval of the authorization code from the user when not using a callbackUrl. See [here for a command line example](https://github.com/XeroAPI/Xero-NetStandard/blob/master/Xero.Api.Example.Console/Authenticators/PublicAuthenticator.cs) and [here for an authenticator used in an MVC application](https://github.com/XeroAPI/Xero-NetStandard/blob/master/Xero.Api.Example.MVC/Authenticators/PublicMvcAuthenticator.cs)

### OAuth signing
All the signing is done by a modified version of the Dust library provided by [Ben Biddington](https://github.com/ben-biddington/dust). Source is included.

## Token Stores
The interface ITokenStore has three methods.
```csharp
public interface ITokenStore
{
	IConsumer Find(string user);
	void Add(IToken token);
	void Delete(IToken token);
}
```
The example projects use a [very simple MemoryTokenStore](https://github.com/XeroAPI/Xero-NetStandard/blob/master/Xero.Api.Example.Console/TokenStores/MemoryTokenStore.cs). It is not recommended that you use a datastore this simplified and so you should create your own implementation to suit the datastore you are using for your product. Ensure the dates on the token are stored in UTC.

## Serialization

All communication with the [Xero API](http://developer.xero.com) is compressed at source. Writing to the API is done with XML. The data model classes have be attributed to give a small XML payload. All communication back from the API is JSON. These details are transparent to the user of the class library.

## Usage
To get going quickly:

1. Follow this getting started guide: http://developer.xero.com/documentation/getting-started/getting-started-guide/
2. Create a console project in VS2017 and download the following package using the NuGet powershell command: PM> Install-Package Xero.Api.SDK.Core
3. Use and modify the snippets found in the [console application](https://github.com/XeroAPI/Xero-NetStandard/tree/master/Xero.Api.Example.Console) for your application type. It may also be useful to inspect some of the classes that you may need to implement if using a public/partner application.

## Acknowledgements

Thanks for the following Open Source libraries for making the wrapper and samples easier

* [Dust](https://github.com/ben-biddington/dust) - OAuth
* [NUnit](http://www.nunit.org/) - unit tests
* [ServiceStack.Text](https://github.com/ServiceStack/ServiceStack.Text/tree/v3) - serialization

## License

This software is published under the [MIT License](http://en.wikipedia.org/wiki/MIT_License).

	Copyright (c) 2017 Xero Limited

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
