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
    public class AuthorsController : JsonApiController<Author>
    {
        public AuthorsController(
        IJsonApiContext jsonApiContext,
        IResourceService<Author> resourceService,
        ILoggerFactory loggerFactory)
    : base(jsonApiContext, resourceService, loggerFactory)
        { }
    }
}