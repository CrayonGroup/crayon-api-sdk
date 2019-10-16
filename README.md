# crayon-api-sdk

A C# library for the Crayon Api.

## Prerequisites

Requires .NET 4.5.1 or later and Visual Studio 2019 or later.

## Installation
To install, run the following command in the Package Manager Console:
````csharp

PM> Install-Package Crayon.Api.Sdk

````

## Dokumentation
Apart from this README, you can find details and examples of using the SDK in the following places:  

- [Github Sample Code Repository](https://github.com/CrayonGroup/crayon-api-sdk-samples)
- [API Documentation](https://apidocs.crayon.com/) 
- [API Endpoints](https://apiv1.crayon.com/docs/) 

## Usage
````csharp

var client = new CrayonApiClient("https://apiv1.crayon.com/");
var token = client.Tokens.GetUserToken(ClientId, ClientSecret, Username, Password).GetData().AccessToken;
var organizations = client.Organizations.GetOrganizations(token, new OrganizationFilter()).GetData()
            
````
