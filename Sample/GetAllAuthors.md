# Get All Authors

## Request
```
GET http://localhost:4793/authors HTTP/1.1
Host: localhost:4793
Connection: keep-alive
Cache-Control: max-age=0
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
X-SourceFiles: =?UTF-8?B?QzpcZGhfY29kZVxKc29uQXBpQ29yZUJvb2tzU2FtcGxlXGF1dGhvcnM=?=
X-Powered-By: ASP.NET
Date: Mon, 01 Jan 2018 01:24:42 GMT
```
```javascript
{
  "data": [
    {
      "type": "authors",
      "id": "1",
      "attributes": {
        "FirstName": "Aleksandr",
        "LastName": "Solzhenitsyn",
        "Books": null
      },
      "relationships": {
        "Books": {
          "links": {
            "self": "http://localhost:4793/authors/1/relationships/Books",
            "related": "http://localhost:4793/authors/1/Books"
          }
        }
      }
    },
    {
      "type": "authors",
      "id": "2",
      "attributes": {
        "FirstName": "Jordan",
        "LastName": "Peterson",
        "Books": null
      },
      "relationships": {
        "Books": {
          "links": {
            "self": "http://localhost:4793/authors/2/relationships/Books",
            "related": "http://localhost:4793/authors/2/Books"
          }
        }
      }
    },
    {
      "type": "authors",
      "id": "3",
      "attributes": {
        "FirstName": "Matt",
        "LastName": "Kibbe",
        "Books": null
      },
      "relationships": {
        "Books": {
          "links": {
            "self": "http://localhost:4793/authors/3/relationships/Books",
            "related": "http://localhost:4793/authors/3/Books"
          }
        }
      }
    },
    {
      "type": "authors",
      "id": "4",
      "attributes": {
        "FirstName": "Erich",
        "LastName": "Gamma",
        "Books": null
      },
      "relationships": {
        "Books": {
          "links": {
            "self": "http://localhost:4793/authors/4/relationships/Books",
            "related": "http://localhost:4793/authors/4/Books"
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
