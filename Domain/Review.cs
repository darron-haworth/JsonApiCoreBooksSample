using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonApiCoreBooksSample.Domain
{
    public class Review : Identifiable
    {
        [Attr("BookId")]
        public int BookId { get; set; }

        [Attr("ReviewerName")]
        public string ReviewerName { get; set; }

        [Attr("ReviewBody")]
        public string ReviewBody { get; set; }
    }
}
