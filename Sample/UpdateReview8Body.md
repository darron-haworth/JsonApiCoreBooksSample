# Update Review 8 

## Request
```javascript
PATCH /Reviews/8 HTTP/1.1
Host: localhost:4793
Content-Type: application/vnd.api+json
Accept: [{"key":"Content-Type","value":"application/vnd.api+json","description":"","enabled":true}]
Cache-Control: no-cache

{
  "data": {
    "type": "reviews",
    "id": "8",
    "attributes": {
      "ReviewBody": "Chaning my review to: Wow, I don't know what to say!",
    }
  }
}
```
## Response
```javascript
Response:
HTTP/1.1 200 OK
Transfer-Encoding: chunked
Content-Type: application/vnd.api+json
Server: Kestrel
X-SourceFiles: =?UTF-8?B?QzpcZGhfY29kZVxKc29uQXBpQ29yZUJvb2tzU2FtcGxlXFJldmlld3NcOA==?=
X-Powered-By: ASP.NET
Date: Sun, 31 Dec 2017 20:34:44 GMT
{
    "data": {
        "type": "reviews",
        "id": "8",
        "attributes": {
            "BookId": 1,
            "ReviewerName": "Max",
            "ReviewBody": "Chaning my review to: Wow, I don't know what to say!"
        }
    },
    "meta": {
        "total-records": 0
    }
}
```