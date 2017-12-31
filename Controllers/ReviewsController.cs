using JsonApiCoreBooksSample.Domain;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;

namespace JsonApiCoreBooksSample.Controllers
{
    public class ReviewsController : JsonApiController<Review>
    {
        public ReviewsController(
        IJsonApiContext jsonApiContext,
        IResourceService<Review> resourceService,
        ILoggerFactory loggerFactory)
    : base(jsonApiContext, resourceService, loggerFactory)
        { }
    }
}