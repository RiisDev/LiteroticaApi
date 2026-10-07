# LiteroticaApi

Asynchronous .NET client for [Literotica.com](https://literotica.com). Fetch stories, series, authors, tags, comments and users as typed objects.

![C#](https://img.shields.io/badge/-.NET%20Standard-blueviolet?style=for-the-badge&logo=windows&logoColor=white)
[![Support Server](https://img.shields.io/discord/477201632204161025.svg?label=Discord&logo=Discord&colorB=7289da&style=for-the-badge)](https://discord.gg/yyuggrH)
![GitHub](https://img.shields.io/github/license/RiisDev/LiteroticaApi?style=for-the-badge)
![Nuget All Releases](https://img.shields.io/nuget/dt/LiteroticaApi?label=Nuget%20Downloads&style=for-the-badge)

## Install

```
dotnet add package LiteroticaApi
```

Targets .NET Standard 2.0. The only dependencies are System.Text.Json and System.Net.Http.Json.

## Usage

```csharp
using LiteroticaApi.Api;

string[] pages = await StoryApi.GetStoryContentAsync("https://www.literotica.com/s/some-story-slug");
var series = await SeriesApi.GetSeriesInfoAsync("https://www.literotica.com/series/se/123456");
var author = await AuthorsApi.GetAuthorByUsernameAsync("someone");
```

To use your own `HttpClient` (proxy, headers, handlers), set `Client.HttpClientInstance`.

## API classes

| Class | Description |
| --- | --- |
| `StoryApi` | Story content and info, top and new stories. |
| `SeriesApi` | Series info, covers, works, and ranked lists. |
| `AuthorsApi` | Author profiles, works, series, and rankings. |
| `TagsApi` | Tag search and related tags. |
| `CommentsApi` | Story comments, recent comments, top commenters. |
| `UsersApi` | User data. |

## EPUB export

Version 3.0 no longer includes EPUB writing. It lives in [EpubManager](https://github.com/RiisDev/EpubManager), with one plugin package per site:

```
dotnet add package EpubManager
dotnet add package EpubManager.Writers.Literotica
```

```csharp
var writer = EpubManager.EpubManager.Writers.Literotica!;
await writer.CreateEpubFromStoryAsync("https://www.literotica.com/s/some-story-slug", "./epubs");
await writer.CreateEpubFromSeriesAsync("https://www.literotica.com/series/se/123456", "./epubs");
```

If you were using `LiteroticaApi.EpubWriter` on 2.x, switch to the packages above.

## License

MIT
