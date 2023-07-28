# ogb_bot

## Prerequisites
- dotnet 6.0

## Development

Hot reloading:

```
dotnet watch
```

## Testing

Once the dev server is up this example request should return a 200 with the same request:
```
curl --location 'http://localhost:5233/v1' \
--header 'Content-Type: application/json' \
--data '{
"attachments": [],
"avatar_url": "https://i.groupme.com/123456789",
"created_at": 1302623328,
"group_id": "1234567890",
"id": "1234567890",
"name": "John",
"sender_id": "12345",
"sender_type": "user",
"source_guid": "cece7083-9cc3-470d-ab79-f7c8f1d373d3",
"system": false,
"text": "Hello world ☃☃",
"user_id": "1234567890"
}'
```

## References
[GroupMe Bots Tutorial](https://dev.groupme.com/tutorials/bots)

