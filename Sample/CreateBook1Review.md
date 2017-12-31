# Create Book 1 Review - POST

## Request
```
POST /Reviews HTTP/1.1
Host: localhost:4793
Content-Type: application/vnd.api+json
Accept: [{"key":"Content-Type","value":"application/vnd.api+json","description":"","enabled":true}]
Cache-Control: no-cache

{
  "data": {
    "type": "reviews",
    "attributes": {
      "BookId": 1,
      "ReviewerName": "Max",
      "ReviewBody": "Very interesting read"
    }
  }
}
```

## Response

```
HTTP/1.1 201 Created
Content-Type: application/vnd.api+json
Location: /Reviews/8
Server: Kestrel
X-SourceFiles: =?UTF-8?B?QzpcZGhfY29kZVxKc29uQXBpQ29yZUJvb2tzU2FtcGxlXFJldmlld3M=?=
X-Powered-By: ASP.NET
Date: Sun, 31 Dec 2017 20:26:31 GMT
Content-Length: 147

{
    "data": {
        "type": "reviews",
        "id": "8",
        "attributes": {
            "BookId": 1,
            "ReviewerName": "Max",
            "ReviewBody": "Very interesting read"
        }
    },
    "meta": {
        "total-records": 0
    }
}
```


