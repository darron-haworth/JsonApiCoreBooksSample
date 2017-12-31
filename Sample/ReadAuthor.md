# Read Author 3

## PostMan Request
```
GET /authors/3 HTTP/1.1
Host: localhost:4793
Cache-Control: no-cache
```

## PostMan Response

```javascript
{
    "data": {
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
    "meta": {
        "total-records": 0
    }
}
```