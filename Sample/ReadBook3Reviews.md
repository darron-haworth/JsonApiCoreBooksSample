# Read Book 3 Reviews

## PostMan Request
```
GET /books/3/reviews HTTP/1.1
Host: localhost:4793
Cache-Control: no-cache
```

## PostMan Response

```json
{
    "data": [
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
        }
    ],
    "meta": {
        "total-records": 0
    }
}
```