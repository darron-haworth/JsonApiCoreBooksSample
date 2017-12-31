# JsonApiCoreBooksSample

The purpose of this project is to give a sense for how well I am able to get started building REST APIs using [.Net Core](https://www.nuget.org/packages/Microsoft.AspNetCore.All/2.0.3) and [JSON API .Net Core](https://json-api-dotnet.github.io/JsonApiDotNetCore/) framework while following the [JSONAPI](http://jsonapi.org/) specification.

I haven't yet had explicit .NET Core experience so this is a great opportunity for me to get my feet wet and demonstrate my abilty to complete a basic set of api tasks.  

I've chosen to use my Windows 10 laptop because dotNetCore 2.x has macOs 10.12 "Sierra" as a prerequisite and the MacBook pro I use is on  10.11.06.  I used Visual Studio Enterprise 2017 as my Integrated Development Environment.

As directed, I will be using [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) alongside JSONAPI .Net Core to create a few models, define their structure, and then create controllers to expose them to the outside world with the typical set of CRUD operations.
For convenience sake I have choosen [SQLite](https://www.sqlite.org/) for my database, normally I prefer SQL Server 2012 for corporate projects, and Postgres for open source projects.

I've also created all of the solution files in one WebApi project, normally I would inlude separate class libraries with one for Repositories (DAL), and another for Domain (Models) but this is being created simply to demonstrate basic competency in .Net Core Web Api.

I've created three models as follows:

Author | 
--- | 
*Id* | 
FirstName | 
LastName | 
Books| 

Book | 
--- | 
*Id* | 
Title | 
Isbn | 
PublishDate | 
Reviews |

Review | 
--- | 
*Id* | 
ReviewerName | 
ReviewBody | 
  
 The relationships defined between these models are such that authors have many books, and books have many reviews.
 
 The models are exposed via the following JSONAPI REST API endpoints:
 * /authors
 * /books
 * /reviews
 
 Each of these endpoints support basic CRUD operations following the JSONApi standard Http Verbs. (POST, GET, PATCH, and DELETE)
 
 See my the [Sample ReadMe](/Sample/ReadMe.md) file for links to the completed Requests and responses that demonstrate successful completion of each of the CRUD operations.
 
