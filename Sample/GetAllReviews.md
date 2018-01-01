# Get All Reviews

## Request
```
GET http://localhost:4793/reviews HTTP/1.1
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
X-SourceFiles: =?UTF-8?B?QzpcZGhfY29kZVxKc29uQXBpQ29yZUJvb2tzU2FtcGxlXHJldmlld3M=?=
X-Powered-By: ASP.NET
Date: Mon, 01 Jan 2018 01:29:11 GMT

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
      "id": "2",
      "attributes": {
        "BookId": 2,
        "ReviewerName": "FSWarrior1",
        "ReviewBody": "Can't wait for January 23d!"
      }
    },
    {
      "type": "reviews",
      "id": "3",
      "attributes": {
        "BookId": 3,
        "ReviewerName": "TimPool",
        "ReviewBody": "Loved!"
      }
    },
    {
      "type": "reviews",
      "id": "4",
      "attributes": {
        "BookId": 3,
        "ReviewerName": "HuffPost",
        "ReviewBody": "Hated!"
      }
    },
    {
      "type": "reviews",
      "id": "5",
      "attributes": {
        "BookId": 3,
        "ReviewerName": "AverageJoe",
        "ReviewBody": "Meh"
      }
    },
    {
      "type": "reviews",
      "id": "6",
      "attributes": {
        "BookId": 4,
        "ReviewerName": "Padma",
        "ReviewBody": "A must!"
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
      "id": "9",
      "attributes": {
        "BookId": 1,
        "ReviewerName": "Max",
        "ReviewBody": "Very interesting read"
      }
    }
  ],
  "meta": {
    "total-records": 8
  }
}
```