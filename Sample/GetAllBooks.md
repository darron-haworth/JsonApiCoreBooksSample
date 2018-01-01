# /books

## Request
```
GET http://localhost:4793/books HTTP/1.1
Host: localhost:4793
Connection: keep-alive
User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.84 Safari/537.36
Upgrade-Insecure-Requests: 1
Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8
Accept-Encoding: gzip, deflate, br
Accept-Language: en-US,en;q=0.9
```

## Response
```
HTTP/1.1 200 OK
Transfer-Encoding: chunked
Content-Type: application/vnd.api+json
Server: Kestrel
X-SourceFiles: =?UTF-8?B?QzpcZGhfY29kZVxKc29uQXBpQ29yZUJvb2tzU2FtcGxlXGJvb2tz?=
X-Powered-By: ASP.NET
Date: Mon, 01 Jan 2018 01:26:50 GMT
```
```javascript
{
  "data": [
    {
      "type": "books",
      "id": "1",
      "attributes": {
        "Title": "The Gulag Archipelago",
        "ISBN": "978-1843430858",
        "PublishDate": "2003-01-03T00:00:00",
        "Reviews": null
      },
      "relationships": {
        "Reviews": {
          "links": {
            "self": "http://localhost:4793/books/1/relationships/Reviews",
            "related": "http://localhost:4793/books/1/Reviews"
          }
        }
      }
    },
    {
      "type": "books",
      "id": "2",
      "attributes": {
        "Title": "12 Rules for Life: An Antidote to Chaos",
        "ISBN": "978-0345816023",
        "PublishDate": "2018-01-23T00:00:00",
        "Reviews": null
      },
      "relationships": {
        "Reviews": {
          "links": {
            "self": "http://localhost:4793/books/2/relationships/Reviews",
            "related": "http://localhost:4793/books/2/Reviews"
          }
        }
      }
    },
    {
      "type": "books",
      "id": "3",
      "attributes": {
        "Title": "Don't Hurt People and Don't Take Their Stuff: A Libertarian Manifesto",
        "ISBN": "978-0062308276",
        "PublishDate": "2015-03-31T00:00:00",
        "Reviews": null
      },
      "relationships": {
        "Reviews": {
          "links": {
            "self": "http://localhost:4793/books/3/relationships/Reviews",
            "related": "http://localhost:4793/books/3/Reviews"
          }
        }
      }
    },
    {
      "type": "books",
      "id": "4",
      "attributes": {
        "Title": "Design Patterns: Elements of Reusable Object-Oriented Software",
        "ISBN": "978-0201633610",
        "PublishDate": "1994-11-10T00:00:00",
        "Reviews": null
      },
      "relationships": {
        "Reviews": {
          "links": {
            "self": "http://localhost:4793/books/4/relationships/Reviews",
            "related": "http://localhost:4793/books/4/Reviews"
          }
        }
      }
    }
  ],
  "meta": {
    "total-records": 4
  }
}
```