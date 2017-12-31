# Delete Review 8 From book 1

## Get Book 1 reviews pre-delete
```
Get Book 1 Reviews 
GET /books/1/Reviews HTTP/1.1
Host: localhost:4793
Cache-Control: no-cache
```
```javascript
{
    "data": [
        {
            "type": "reviews",
            "id": "1",
            "attributes": {
                "BookId": 1,
                "ReviewerName": "Sanjay",
                "ReviewBody": "Tough read!"
            }
        },
        {
            "type": "reviews",
            "id": "7",
            "attributes": {
                "BookId": 1,
                "ReviewerName": "Diane",
                "ReviewBody": "Very interesting read"
            }
        },
        {
            "type": "reviews",
            "id": "8",
            "attributes": {
                "BookId": 1,
                "ReviewerName": "Max",
                "ReviewBody": "Chaning my review to: Wow, I don't know what to say!"
            }
        }
    ],
    "meta": {
        "total-records": 0
    }
}
```

## Delete Review 8
```
DELETE /reviews/8 HTTP/1.1
Host: localhost:4793
Content-Type: application/vnd.api+json
Accept: [{"key":"Content-Type","value":"application/vnd.api+json","description":"","enabled":true}]
Cache-Control: no-cache
```
Reponse:
```
HTTP/1.1 204 No Content
Server: Kestrel
X-SourceFiles: =?UTF-8?B?QzpcZGhfY29kZVxKc29uQXBpQ29yZUJvb2tzU2FtcGxlXHJldmlld3NcOA==?=
X-Powered-By: ASP.NET
Date: Sun, 31 Dec 2017 20:47:03 GMT
```

## Get Book 1 Reviews post-delete (no more 8)
```
GET /books/1/Reviews HTTP/1.1
Host: localhost:4793
Cache-Control: no-cache
```
Delete Response:
```
HTTP/1.1 200 OK
Transfer-Encoding: chunked
Content-Type: application/vnd.api+json
Server: Kestrel
X-SourceFiles: =?UTF-8?B?QzpcZGhfY29kZVxKc29uQXBpQ29yZUJvb2tzU2FtcGxlXGJvb2tzXDFcUmV2aWV3cw==?=
X-Powered-By: ASP.NET
Date: Sun, 31 Dec 2017 20:52:59 GMT
```
```javascript
{
    "data": [
        {
            "type": "reviews",
            "id": "1",
            "attributes": {
                "BookId": 1,
                "ReviewerName": "Sanjay",
                "ReviewBody": "Tough read!"
            }
        },
        {
            "type": "reviews",
            "id": "7",
            "attributes": {
                "BookId": 1,
                "ReviewerName": "Diane",
                "ReviewBody": "Very interesting read"
            }
        }
    ],
    "meta": {
        "total-records": 0
    }
}
```