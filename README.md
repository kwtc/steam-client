# Steam client
Client project for retrieving app ids and details from Steam.

## Features
- [X] Get all app ids as JSON or deserialized.
- [X] Get single app details as JSON or deserialized.
    - Supports Steam app ids filter when used in combination with price_overview filter.
    - Supports country code parameter affecting pricing.
    - Supports language parameter.
    - Supports filters determining what data is returned.

## Configuration
A Steam API key must be defined in appsettings.json.

```json
{
  "SteamConfig": {
    "ApiKey": "STEAMKEY"
  }
}
```