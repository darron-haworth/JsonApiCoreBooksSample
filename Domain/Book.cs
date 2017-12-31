using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;

namespace JsonApiCoreBooksSample.Domain
{
    public class Book : Identifiable
    {
        [Attr("Title")]
        public string Title { get; set; }
        [Attr("ISBN")]
        public string Isbn { get; set; }
        [Attr("PublishDate")]
        public DateTime PublishDate { get; set; }

        [Attr("Reviews")]
        [HasMany("Reviews")]
        public List<Review> BookReviews { get; set; }

    }
}
