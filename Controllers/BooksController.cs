using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiCoreBooksSample.Domain;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JsonApiCoreBooksSample.Controllers
{
    public class BooksController : JsonApiController<Book>
    {
        public BooksController(
        IJsonApiContext jsonApiContext,
        IResourceService<Book>
        resourceService,
        ILoggerFactory loggerFactory)
    : base(jsonApiContext, resourceService, loggerFactory)
        { }
    }
}