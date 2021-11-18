[![badge](https://img.shields.io/twitter/follow/api_video?style=social)](https://twitter.com/intent/follow?screen_name=api_video) &nbsp; [![badge](https://img.shields.io/github/stars/apivideo/api.video-csharp-client?style=social)](https://github.com/apivideo/api.video-csharp-client) &nbsp; [![badge](https://img.shields.io/discourse/topics?server=https%3A%2F%2Fcommunity.api.video)](https://community.api.video)
![](https://github.com/apivideo/API_OAS_file/blob/master/apivideo_banner.png)
<h1 align="center">api.video C# client</h1>

[api.video](https://api.video) is the video infrastructure for product builders. Lightning fast video APIs for integrating, scaling, and managing on-demand & low latency live streaming features in your app.

# Table of contents

- [Project description](#project-description)
- [Getting started](#getting-started)
  - [Requirements](#requirements)
    - [Frameworks supported](#frameworks-supported)
    - [Dependencies](#dependencies)
  - [Installation](#installation)
    - [Using Nuget](#using-nuget)
    - [Generating the DLL yourself](#generating-the-dll-yourself)
  - [Code sample](#code-sample)
- [Documentation](#documentation)
  - [API Endpoints](#api-endpoints)
    - [CaptionsApi](#captionsapi)
    - [ChaptersApi](#chaptersapi)
    - [LiveStreamsApi](#livestreamsapi)
    - [PlayerThemesApi](#playerthemesapi)
    - [RawStatisticsApi](#rawstatisticsapi)
    - [UploadTokensApi](#uploadtokensapi)
    - [VideosApi](#videosapi)
    - [WebhooksApi](#webhooksapi)
  - [Models](#models)
  - [Authorization](#authorization)
    - [API token](#api-token)
    - [Public endpoints](#public-endpoints)
  - [Recommendation](#recommendation)
- [Have you gotten use from this API client?](#have-you-gotten-use-from-this-api-client-)
- [Contribution](#contribution)

# Project description

api.video's C# API client streamlines the coding process. Chunking files is handled for you, as is pagination and refreshing your tokens.

# Getting started

## Requirements

### Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

### Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

### Using Nuget

```
Install-Package ApiVideo
```

### Generating the DLL yourself

Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using ApiVideo.Api;
using ApiVideo.Client;
using ApiVideo.Model;

```

## Code sample

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.IO;
using ApiVideo.Api;
using ApiVideo.Client;
using ApiVideo.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {
            var apiKey = "YOUR_API_KEY";

            var apiVideoClient = new ApiVideoClient(apiKey);
            // if you rather like to use the sandbox environment:
            // var apiVideoClient = new ApiVideoClient(apiKey, ApiVideo.Client.Environment.SANDBOX);

            var videoPayload = new VideoCreationPayload()
            {
                title = "Example video title",
                description = "Example video description",
                mp4support = true,
                tags = new List<string>()
                {
                    "first","video","test","c#","client"
                }
            };

            var myVideoFile = File.OpenRead("my-video.mp4");

            try {
                var newVideo = apiVideoClient.Videos().create(videoPayload);
                var video = apiVideoClient.Videos().upload(newVideo.videoid,myVideoFile);
                Console.WriteLine(video);
            } catch (ApiException e) {
                Console.WriteLine(e.ErrorCode);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

# Documentation

## API Endpoints

All URIs are relative to *https://ws.api.video*



### CaptionsApi


#### Retrieve an instance of CaptionsApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
CaptionsApi captions = client.Captions()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete**](docs/CaptionsApi.md#delete) | **DELETE** /videos/{videoId}/captions/{language} | Delete a caption
[**list**](docs/CaptionsApi.md#list) | **GET** /videos/{videoId}/captions | List video captions
[**get**](docs/CaptionsApi.md#get) | **GET** /videos/{videoId}/captions/{language} | Show a caption
[**update**](docs/CaptionsApi.md#update) | **PATCH** /videos/{videoId}/captions/{language} | Update caption
[**upload**](docs/CaptionsApi.md#upload) | **POST** /videos/{videoId}/captions/{language} | Upload a caption


### ChaptersApi


#### Retrieve an instance of ChaptersApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
ChaptersApi chapters = client.Chapters()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete**](docs/ChaptersApi.md#delete) | **DELETE** /videos/{videoId}/chapters/{language} | Delete a chapter
[**list**](docs/ChaptersApi.md#list) | **GET** /videos/{videoId}/chapters | List video chapters
[**get**](docs/ChaptersApi.md#get) | **GET** /videos/{videoId}/chapters/{language} | Show a chapter
[**upload**](docs/ChaptersApi.md#upload) | **POST** /videos/{videoId}/chapters/{language} | Upload a chapter


### LiveStreamsApi


#### Retrieve an instance of LiveStreamsApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
LiveStreamsApi liveStreams = client.LiveStreams()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete**](docs/LiveStreamsApi.md#delete) | **DELETE** /live-streams/{liveStreamId} | Delete a live stream
[**deleteThumbnail**](docs/LiveStreamsApi.md#deleteThumbnail) | **DELETE** /live-streams/{liveStreamId}/thumbnail | Delete a thumbnail
[**list**](docs/LiveStreamsApi.md#list) | **GET** /live-streams | List all live streams
[**get**](docs/LiveStreamsApi.md#get) | **GET** /live-streams/{liveStreamId} | Show live stream
[**update**](docs/LiveStreamsApi.md#update) | **PATCH** /live-streams/{liveStreamId} | Update a live stream
[**create**](docs/LiveStreamsApi.md#create) | **POST** /live-streams | Create live stream
[**uploadThumbnail**](docs/LiveStreamsApi.md#uploadThumbnail) | **POST** /live-streams/{liveStreamId}/thumbnail | Upload a thumbnail


### PlayerThemesApi


#### Retrieve an instance of PlayerThemesApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
PlayerThemesApi playerThemes = client.PlayerThemes()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete**](docs/PlayerThemesApi.md#delete) | **DELETE** /players/{playerId} | Delete a player
[**deleteLogo**](docs/PlayerThemesApi.md#deleteLogo) | **DELETE** /players/{playerId}/logo | Delete logo
[**list**](docs/PlayerThemesApi.md#list) | **GET** /players | List all players
[**get**](docs/PlayerThemesApi.md#get) | **GET** /players/{playerId} | Show a player
[**update**](docs/PlayerThemesApi.md#update) | **PATCH** /players/{playerId} | Update a player
[**create**](docs/PlayerThemesApi.md#create) | **POST** /players | Create a player
[**uploadLogo**](docs/PlayerThemesApi.md#uploadLogo) | **POST** /players/{playerId}/logo | Upload a logo


### RawStatisticsApi


#### Retrieve an instance of RawStatisticsApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
RawStatisticsApi rawStatistics = client.RawStatistics()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**listLiveStreamSessions**](docs/RawStatisticsApi.md#listLiveStreamSessions) | **GET** /analytics/live-streams/{liveStreamId} | List live stream player sessions
[**listSessionEvents**](docs/RawStatisticsApi.md#listSessionEvents) | **GET** /analytics/sessions/{sessionId}/events | List player session events
[**listVideoSessions**](docs/RawStatisticsApi.md#listVideoSessions) | **GET** /analytics/videos/{videoId} | List video player sessions


### UploadTokensApi


#### Retrieve an instance of UploadTokensApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
UploadTokensApi uploadTokens = client.UploadTokens()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteToken**](docs/UploadTokensApi.md#deleteToken) | **DELETE** /upload-tokens/{uploadToken} | Delete an upload token
[**list**](docs/UploadTokensApi.md#list) | **GET** /upload-tokens | List all active upload tokens.
[**getToken**](docs/UploadTokensApi.md#getToken) | **GET** /upload-tokens/{uploadToken} | Show upload token
[**createToken**](docs/UploadTokensApi.md#createToken) | **POST** /upload-tokens | Generate an upload token


### VideosApi


#### Retrieve an instance of VideosApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
VideosApi videos = client.Videos()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete**](docs/VideosApi.md#delete) | **DELETE** /videos/{videoId} | Delete a video
[**get**](docs/VideosApi.md#get) | **GET** /videos/{videoId} | Show a video
[**getStatus**](docs/VideosApi.md#getStatus) | **GET** /videos/{videoId}/status | Show video status
[**list**](docs/VideosApi.md#list) | **GET** /videos | List all videos
[**update**](docs/VideosApi.md#update) | **PATCH** /videos/{videoId} | Update a video
[**pickThumbnail**](docs/VideosApi.md#pickThumbnail) | **PATCH** /videos/{videoId}/thumbnail | Pick a thumbnail
[**uploadWithUploadToken**](docs/VideosApi.md#uploadWithUploadToken) | **POST** /upload | Upload with an upload token
[**create**](docs/VideosApi.md#create) | **POST** /videos | Create a video
[**upload**](docs/VideosApi.md#upload) | **POST** /videos/{videoId}/source | Upload a video
[**uploadThumbnail**](docs/VideosApi.md#uploadThumbnail) | **POST** /videos/{videoId}/thumbnail | Upload a thumbnail


### WebhooksApi


#### Retrieve an instance of WebhooksApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
WebhooksApi webhooks = client.Webhooks()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete**](docs/WebhooksApi.md#delete) | **DELETE** /webhooks/{webhookId} | Delete a Webhook
[**get**](docs/WebhooksApi.md#get) | **GET** /webhooks/{webhookId} | Show Webhook details
[**list**](docs/WebhooksApi.md#list) | **GET** /webhooks | List all webhooks
[**create**](docs/WebhooksApi.md#create) | **POST** /webhooks | Create Webhook



## Models

 - [AccessToken](docs/AccessToken.md)
 - [AuthenticatePayload](docs/AuthenticatePayload.md)
 - [BadRequest](docs/BadRequest.md)
 - [BytesRange](docs/BytesRange.md)
 - [Caption](docs/Caption.md)
 - [CaptionsListResponse](docs/CaptionsListResponse.md)
 - [CaptionsUpdatePayload](docs/CaptionsUpdatePayload.md)
 - [Chapter](docs/Chapter.md)
 - [ChaptersListResponse](docs/ChaptersListResponse.md)
 - [Link](docs/Link.md)
 - [LiveStream](docs/LiveStream.md)
 - [LiveStreamAssets](docs/LiveStreamAssets.md)
 - [LiveStreamCreationPayload](docs/LiveStreamCreationPayload.md)
 - [LiveStreamListResponse](docs/LiveStreamListResponse.md)
 - [LiveStreamSession](docs/LiveStreamSession.md)
 - [LiveStreamSessionClient](docs/LiveStreamSessionClient.md)
 - [LiveStreamSessionDevice](docs/LiveStreamSessionDevice.md)
 - [LiveStreamSessionLocation](docs/LiveStreamSessionLocation.md)
 - [LiveStreamSessionReferrer](docs/LiveStreamSessionReferrer.md)
 - [LiveStreamSessionSession](docs/LiveStreamSessionSession.md)
 - [LiveStreamUpdatePayload](docs/LiveStreamUpdatePayload.md)
 - [Metadata](docs/Metadata.md)
 - [NotFound](docs/NotFound.md)
 - [Pagination](docs/Pagination.md)
 - [PaginationLink](docs/PaginationLink.md)
 - [PlayerSessionEvent](docs/PlayerSessionEvent.md)
 - [PlayerTheme](docs/PlayerTheme.md)
 - [PlayerThemeAssets](docs/PlayerThemeAssets.md)
 - [PlayerThemeCreationPayload](docs/PlayerThemeCreationPayload.md)
 - [PlayerThemeUpdatePayload](docs/PlayerThemeUpdatePayload.md)
 - [PlayerThemesListResponse](docs/PlayerThemesListResponse.md)
 - [Quality](docs/Quality.md)
 - [RawStatisticsListLiveStreamAnalyticsResponse](docs/RawStatisticsListLiveStreamAnalyticsResponse.md)
 - [RawStatisticsListPlayerSessionEventsResponse](docs/RawStatisticsListPlayerSessionEventsResponse.md)
 - [RawStatisticsListSessionsResponse](docs/RawStatisticsListSessionsResponse.md)
 - [RefreshTokenPayload](docs/RefreshTokenPayload.md)
 - [TokenCreationPayload](docs/TokenCreationPayload.md)
 - [TokenListResponse](docs/TokenListResponse.md)
 - [UploadToken](docs/UploadToken.md)
 - [Video](docs/Video.md)
 - [VideoAssets](docs/VideoAssets.md)
 - [VideoCreationPayload](docs/VideoCreationPayload.md)
 - [VideoSession](docs/VideoSession.md)
 - [VideoSessionClient](docs/VideoSessionClient.md)
 - [VideoSessionDevice](docs/VideoSessionDevice.md)
 - [VideoSessionLocation](docs/VideoSessionLocation.md)
 - [VideoSessionOs](docs/VideoSessionOs.md)
 - [VideoSessionReferrer](docs/VideoSessionReferrer.md)
 - [VideoSessionSession](docs/VideoSessionSession.md)
 - [VideoSource](docs/VideoSource.md)
 - [VideoSourceLiveStream](docs/VideoSourceLiveStream.md)
 - [VideoSourceLiveStreamLink](docs/VideoSourceLiveStreamLink.md)
 - [VideoStatus](docs/VideoStatus.md)
 - [VideoStatusEncoding](docs/VideoStatusEncoding.md)
 - [VideoStatusEncodingMetadata](docs/VideoStatusEncodingMetadata.md)
 - [VideoStatusIngest](docs/VideoStatusIngest.md)
 - [VideoThumbnailPickPayload](docs/VideoThumbnailPickPayload.md)
 - [VideoUpdatePayload](docs/VideoUpdatePayload.md)
 - [VideosListResponse](docs/VideosListResponse.md)
 - [Webhook](docs/Webhook.md)
 - [WebhooksCreationPayload](docs/WebhooksCreationPayload.md)
 - [WebhooksListResponse](docs/WebhooksListResponse.md)


## Authorization

### API token

Most endpoints required to be authenticated using the API token mechanism described in our [documentation](https://docs.api.video/reference#authentication).
The access token generation mechanism is automatically handled by the client. All you have to do is provide an API token when instantiating the ApiVideoClient:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
```

### Public endpoints

Some endpoints don't require authentication. These one can be called with an ApiVideoClient instantiated without API token:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient();
```

## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Have you gotten use from this API client?

Please take a moment to leave a star on the client ⭐

This helps other users to find the clients and also helps us understand which clients are most popular. Thank you!


# Contribution

Since this API client is generated from an OpenAPI description, we cannot accept pull requests made directly to the repository. If you want to contribute, you can open a pull request on the repository of our [client generator](https://github.com/apivideo/api-client-generator). Otherwise, you can also simply open an issue detailing your need on this repository.