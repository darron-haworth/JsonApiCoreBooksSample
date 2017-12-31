using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;

namespace JsonApiCoreBooksSample.Domain
{
    public class Author : Identifiable
    {
        [Attr("FirstName")]
        public string FirstName { get; set; }
        [Attr("LastName")]
        public string LastName { get; set; }

        [Attr("Books")]
        [HasMany("Books")]
        public List<Book> AuthorBooks { get; set; }
    }
}
