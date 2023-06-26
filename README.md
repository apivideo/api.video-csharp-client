[![badge](https://img.shields.io/twitter/follow/api_video?style=social)](https://twitter.com/intent/follow?screen_name=api_video) &nbsp; [![badge](https://img.shields.io/github/stars/apivideo/api.video-csharp-client?style=social)](https://github.com/apivideo/api.video-csharp-client) &nbsp; [![badge](https://img.shields.io/discourse/topics?server=https%3A%2F%2Fcommunity.api.video)](https://community.api.video)
![](https://github.com/apivideo/.github/blob/main/assets/apivideo_banner.png)
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
    - [AnalyticsApi](#analyticsapi)
    - [CaptionsApi](#captionsapi)
    - [ChaptersApi](#chaptersapi)
    - [LiveStreamsApi](#livestreamsapi)
    - [PlayerThemesApi](#playerthemesapi)
    - [RawStatisticsApi](#rawstatisticsapi)
    - [UploadTokensApi](#uploadtokensapi)
    - [VideosApi](#videosapi)
    - [WatermarksApi](#watermarksapi)
    - [WebhooksApi](#webhooksapi)
  - [Models](#models)
  - [Authorization](#authorization)
    - [API key](#api-key)
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



### AnalyticsApi


#### Retrieve an instance of AnalyticsApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_KEY");
AnalyticsApi analytics = client.Analytics()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**getLiveStreamsPlays**](docs/AnalyticsApi.md#getLiveStreamsPlays) | **GET** /analytics/live-streams/plays | Get play events for live stream
[**getVideosPlays**](docs/AnalyticsApi.md#getVideosPlays) | **GET** /analytics/videos/plays | Get play events for video


### CaptionsApi


#### Retrieve an instance of CaptionsApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_KEY");
CaptionsApi captions = client.Captions()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**upload**](docs/CaptionsApi.md#upload) | **POST** /videos/{videoId}/captions/{language} | Upload a caption
[**get**](docs/CaptionsApi.md#get) | **GET** /videos/{videoId}/captions/{language} | Retrieve a caption
[**update**](docs/CaptionsApi.md#update) | **PATCH** /videos/{videoId}/captions/{language} | Update a caption
[**delete**](docs/CaptionsApi.md#delete) | **DELETE** /videos/{videoId}/captions/{language} | Delete a caption
[**list**](docs/CaptionsApi.md#list) | **GET** /videos/{videoId}/captions | List video captions


### ChaptersApi


#### Retrieve an instance of ChaptersApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_KEY");
ChaptersApi chapters = client.Chapters()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**upload**](docs/ChaptersApi.md#upload) | **POST** /videos/{videoId}/chapters/{language} | Upload a chapter
[**get**](docs/ChaptersApi.md#get) | **GET** /videos/{videoId}/chapters/{language} | Retrieve a chapter
[**delete**](docs/ChaptersApi.md#delete) | **DELETE** /videos/{videoId}/chapters/{language} | Delete a chapter
[**list**](docs/ChaptersApi.md#list) | **GET** /videos/{videoId}/chapters | List video chapters


### LiveStreamsApi


#### Retrieve an instance of LiveStreamsApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_KEY");
LiveStreamsApi liveStreams = client.LiveStreams()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**create**](docs/LiveStreamsApi.md#create) | **POST** /live-streams | Create live stream
[**get**](docs/LiveStreamsApi.md#get) | **GET** /live-streams/{liveStreamId} | Retrieve live stream
[**update**](docs/LiveStreamsApi.md#update) | **PATCH** /live-streams/{liveStreamId} | Update a live stream
[**delete**](docs/LiveStreamsApi.md#delete) | **DELETE** /live-streams/{liveStreamId} | Delete a live stream
[**list**](docs/LiveStreamsApi.md#list) | **GET** /live-streams | List all live streams
[**uploadThumbnail**](docs/LiveStreamsApi.md#uploadThumbnail) | **POST** /live-streams/{liveStreamId}/thumbnail | Upload a thumbnail
[**deleteThumbnail**](docs/LiveStreamsApi.md#deleteThumbnail) | **DELETE** /live-streams/{liveStreamId}/thumbnail | Delete a thumbnail


### PlayerThemesApi


#### Retrieve an instance of PlayerThemesApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_KEY");
PlayerThemesApi playerThemes = client.PlayerThemes()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**create**](docs/PlayerThemesApi.md#create) | **POST** /players | Create a player
[**get**](docs/PlayerThemesApi.md#get) | **GET** /players/{playerId} | Retrieve a player
[**update**](docs/PlayerThemesApi.md#update) | **PATCH** /players/{playerId} | Update a player
[**delete**](docs/PlayerThemesApi.md#delete) | **DELETE** /players/{playerId} | Delete a player
[**list**](docs/PlayerThemesApi.md#list) | **GET** /players | List all player themes
[**uploadLogo**](docs/PlayerThemesApi.md#uploadLogo) | **POST** /players/{playerId}/logo | Upload a logo
[**deleteLogo**](docs/PlayerThemesApi.md#deleteLogo) | **DELETE** /players/{playerId}/logo | Delete logo


### RawStatisticsApi


#### Retrieve an instance of RawStatisticsApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_KEY");
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
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_KEY");
UploadTokensApi uploadTokens = client.UploadTokens()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**createToken**](docs/UploadTokensApi.md#createToken) | **POST** /upload-tokens | Generate an upload token
[**getToken**](docs/UploadTokensApi.md#getToken) | **GET** /upload-tokens/{uploadToken} | Retrieve upload token
[**deleteToken**](docs/UploadTokensApi.md#deleteToken) | **DELETE** /upload-tokens/{uploadToken} | Delete an upload token
[**list**](docs/UploadTokensApi.md#list) | **GET** /upload-tokens | List all active upload tokens


### VideosApi


#### Retrieve an instance of VideosApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_KEY");
VideosApi videos = client.Videos()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**create**](docs/VideosApi.md#create) | **POST** /videos | Create a video object
[**upload**](docs/VideosApi.md#upload) | **POST** /videos/{videoId}/source | Upload a video
[**uploadWithUploadToken**](docs/VideosApi.md#uploadWithUploadToken) | **POST** /upload | Upload with an delegated upload token
[**get**](docs/VideosApi.md#get) | **GET** /videos/{videoId} | Retrieve a video object
[**update**](docs/VideosApi.md#update) | **PATCH** /videos/{videoId} | Update a video object
[**delete**](docs/VideosApi.md#delete) | **DELETE** /videos/{videoId} | Delete a video object
[**list**](docs/VideosApi.md#list) | **GET** /videos | List all video objects
[**uploadThumbnail**](docs/VideosApi.md#uploadThumbnail) | **POST** /videos/{videoId}/thumbnail | Upload a thumbnail
[**pickThumbnail**](docs/VideosApi.md#pickThumbnail) | **PATCH** /videos/{videoId}/thumbnail | Set a thumbnail
[**getStatus**](docs/VideosApi.md#getStatus) | **GET** /videos/{videoId}/status | Retrieve video status and details


### WatermarksApi


#### Retrieve an instance of WatermarksApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_KEY");
WatermarksApi watermarks = client.Watermarks()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**upload**](docs/WatermarksApi.md#upload) | **POST** /watermarks | Upload a watermark
[**delete**](docs/WatermarksApi.md#delete) | **DELETE** /watermarks/{watermarkId} | Delete a watermark
[**list**](docs/WatermarksApi.md#list) | **GET** /watermarks | List all watermarks


### WebhooksApi


#### Retrieve an instance of WebhooksApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_KEY");
WebhooksApi webhooks = client.Webhooks()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**create**](docs/WebhooksApi.md#create) | **POST** /webhooks | Create Webhook
[**get**](docs/WebhooksApi.md#get) | **GET** /webhooks/{webhookId} | Retrieve Webhook details
[**delete**](docs/WebhooksApi.md#delete) | **DELETE** /webhooks/{webhookId} | Delete a Webhook
[**list**](docs/WebhooksApi.md#list) | **GET** /webhooks | List all webhooks



## Models

 - [AccessToken](docs/AccessToken.md)
 - [AdditionalBadRequestErrors](docs/AdditionalBadRequestErrors.md)
 - [AnalyticsData](docs/AnalyticsData.md)
 - [AnalyticsPlays400Error](docs/AnalyticsPlays400Error.md)
 - [AnalyticsPlaysResponse](docs/AnalyticsPlaysResponse.md)
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
 - [RestreamsRequestObject](docs/RestreamsRequestObject.md)
 - [RestreamsResponseObject](docs/RestreamsResponseObject.md)
 - [TokenCreationPayload](docs/TokenCreationPayload.md)
 - [TokenListResponse](docs/TokenListResponse.md)
 - [UploadToken](docs/UploadToken.md)
 - [Video](docs/Video.md)
 - [VideoAssets](docs/VideoAssets.md)
 - [VideoClip](docs/VideoClip.md)
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
 - [VideoStatusIngestReceivedParts](docs/VideoStatusIngestReceivedParts.md)
 - [VideoThumbnailPickPayload](docs/VideoThumbnailPickPayload.md)
 - [VideoUpdatePayload](docs/VideoUpdatePayload.md)
 - [VideoWatermark](docs/VideoWatermark.md)
 - [VideosListResponse](docs/VideosListResponse.md)
 - [Watermark](docs/Watermark.md)
 - [WatermarksListResponse](docs/WatermarksListResponse.md)
 - [Webhook](docs/Webhook.md)
 - [WebhooksCreationPayload](docs/WebhooksCreationPayload.md)
 - [WebhooksListResponse](docs/WebhooksListResponse.md)


## Authorization

### API key

Most endpoints required to be authenticated using the API key mechanism described in our [documentation](https://docs.api.video/reference#authentication).
The access token generation mechanism is automatically handled by the client. All you have to do is provide an API key when instantiating the ApiVideoClient:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_KEY");
```

### Public endpoints

Some endpoints don't require authentication. These one can be called with an ApiVideoClient instantiated without API key:
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