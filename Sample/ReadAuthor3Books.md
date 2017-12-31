# Read Author 3 Books

## PostMan Request
```
GET /authors/3/books HTTP/1.1
Host: localhost:4793
Cache-Control: no-cache
```

## PostMan Response

```json
{
    "data": [
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
        }
    ],
    "meta": {
        "total-records": 0
    }
}
```