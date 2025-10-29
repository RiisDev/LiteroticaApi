# 📚 LiteroticaApi
### A Modern, Fully Asynchronous .NET API for Accessing data from Literotica.com with EPUB Export Capabilities

![C#](https://img.shields.io/badge/-.NET%20Standard-blueviolet?style=for-the-badge&logo=windows&logoColor=white)
[![Support Server](https://img.shields.io/discord/477201632204161025.svg?label=Discord&logo=Discord&colorB=7289da&style=for-the-badge)](https://discord.gg/yyuggrH)
![GitHub](https://img.shields.io/github/license/RiisDev/LiteroticaApi?style=for-the-badge)
![Nuget All Releases](https://img.shields.io/nuget/dt/LiteroticaApi?label=Nuget%20Downloads&style=for-the-badge)

---

## ✨ Overview

**LiteroticaApi** is a fully asynchronous, modern C# library that provides direct access to stories, authors, series, tags, and metadata from [Literotica.com](https://literotica.com).  
It enables developers to programmatically fetch, process, and even **export stories or entire series into EPUB format**.

This API is ideal for:
- Power users who want to automate content export or generate offline EPUB versions.
- Developers building applications that integrate Literotica content.
- Anyone looking for a robust, easy-to-use .NET library to interact with Literotica's vast collection of stories.

---

## 🚀 Features

- ✅ **Async-first design** – All operations are `async/await`-friendly.  
- 📖 **Story and series fetching** – Retrieve stories, series, authors, and related metadata.  
- 🏷️ **Advanced tag and category search** – Filter stories by tags, periods, and categories.  
- 🧠 **Smart EPUB generation** – Automatically generates valid EPUB 3.0 files from stories or entire series.  
- 🧩 **Structured data models** – Strongly typed responses for all API entities.  
- 🌍 **Language and period filters** – Easily query content by language and publication period.  
- ⚡ **Zero dependencies on external binaries** – Pure .NET and XML-based EPUB construction.
> System.Text.Json, System.Net.Http.Json, and System.IO are the only dependencies.

---

## 📦 Installation

Install via **NuGet Package Manager**:

```bash
dotnet add package LiteroticaApi
````

Or via **Package Manager Console**:

```powershell
Install-Package LiteroticaApi
```

---

## 💡 Quick Start

Below is a basic example showing how to download and export a Literotica story to EPUB.

```csharp
using LiteroticaApi.EpubWriter;
using LiteroticaApi.Api;

public class Example
{
    public static async Task Main()
    {
        string storyUrl = "https://www.literotica.com/s/some-story-slug";
        string outputPath = Path.Combine(Environment.CurrentDirectory, "epubs");

        await StoryWriter.CreateEpubFromStory(storyUrl, outputPath);

        Console.WriteLine("EPUB created successfully!");
    }
}
```

To export an **entire series** instead:

```csharp
string seriesUrl = "https://www.literotica.com/s/series-slug";
await StoryWriter.CreateEpubFromSeries(seriesUrl, outputPath);
```

---

## 🧱 Core Components

### 🗂 **API Modules**

| Class        | Description                                                    |
| ------------ | -------------------------------------------------------------- |
| `StoryApi`   | Fetches story content, info, top stories, and recommendations. |
| `SeriesApi`  | Retrieves series info, covers, and related works.              |
| `AuthorsApi` | Retrieves author profiles and their associated works.          |
| `TagsApi`    | Provides tag-based search, filtering, and related tag lookups. |
| `Comments`   | Retrieves comment data using a variety of options.             |
| `Users`      | Retrieves user data using a variety of options.                |

### 📘 **EPUB Writer**

The `EpubWriter` namespace contains everything needed to generate compliant EPUB 3.0 files.
It includes:

* `StoryWriter` – Handles EPUB structure creation, packaging, and cleanup.
* `EpubStory` & `EpubSeries` records – Define the metadata and content structure of an EPUB.
* `WriterUtil` – Generates internal EPUB XML structures like `toc.ncx`, `content.opf`, and `nav.xhtml`.

---

## 🧰 Example: Custom EPUB Creation

If you already have your story data and just want to generate an EPUB manually:

```csharp
var story = new EpubStory(
    Title: "Custom Story",
    Language: "English",
    Author: "John Doe",
    Series: new EpubSeries("Sample Series", 1),
    Tags: new[] { "romance", "fiction" },
    Chapters: new[] { "chapter1.txt", "chapter2.txt" },
    CoverPath: "cover.jpg"
);

StoryWriter.CreateEpub(story, "./output");
```

## ⚙️ Requirements

* .NET Standard 2.0 applicable environment
* Windows, Linux, or macOS
* Internet access for API calls

---

## 🧾 License

This project is licensed under the **MIT License**.
