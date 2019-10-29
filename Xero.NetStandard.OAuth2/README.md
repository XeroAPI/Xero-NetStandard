# Xero Net Standard API

This client was generated using openapi-generator
https://github.com/OpenAPITools/openapi-generator


Using the following yaml spec:
https://github.com/XeroAPI/Xero-OpenAPI/blob/master/accounting-yaml/Xero_accounting_2.0.0_swagger.yaml

These classes are not coupled to the OAuth2 client. All they need to run are the accessToken and xero-tenant-id. The client is contained in this repo at: https://github.com/XeroAPI/Xero-NetStandard/tree/oauth2/Xero.NetStandard.OAuth2Client

To install :
```
dotnet add package Xero.NetStandard.OAuth2
```
or download the source code 

https://github.com/XeroAPI/Xero-NetStandard/tree/oauth2

Once you have that package it is as simple as calling
```csharp
var AccountingApi = new AccountingApi();
var response = await AccountingApi.GetInvoicesAsync(accessToken, xeroTenantId);
Console.WriteLine(AccountingApi.GetInvoices().ToJson();)
```

## Exception handling
400 errors are caught in the general ApiException Class
```csharp
//details will be emitted through the message, 
  try
            {
                var AccountingApi = new AccountingApi();
                var response = await AccountingApi.GetInvoicesAsync(accessToken, xeroTenantId);
            }
            catch (ApiException ae)
            {
                var errorCode = ae.ErrorCode; // httpcode
                var message = ae.Message;
                Error e = ae.ErrorContent;
            }

```
