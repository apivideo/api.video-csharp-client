# VideoApiClient - the C# library for the api.video

api.video is an API that encodes on the go to facilitate immediate playback, enhancing viewer streaming experiences across multiple devices and platforms. You can stream live or on-demand online videos within minutes.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1
- SDK version: 1.0.0
- Build package: video.api.client.generator.Csharp

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using VideoApiClient.Api;
using VideoApiClient.Client;
using VideoApiClient.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out VideoApiClient.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.IO;
using VideoApiClient.Api;
using VideoApiClient.Client;
using VideoApiClient.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {
            var apiKey = "YOUR_API_KEY";

            var apiVideoClient = new ApiVideoClient(apiKey);
            // if you rather like to use the sandbox environment:
            // var apiVideoClient = new ApiVideoClient(apiKey, VideoApiClient.Client.Environment.SANDBOX);

            var videoPayload = new VideoCreatePayload()
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

## Documentation for API Endpoints

All URIs are relative to *https://ws.api.video*



### AccountApi


#### Retrieve an instance of AccountApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
AccountApi account = client.Account()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
**(deprecated)** [**get**](docs/AccountApi.md#get) | **GET** /account | Show account


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


### LiveApi


#### Retrieve an instance of LiveApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
LiveApi live = client.Live()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete**](docs/LiveApi.md#delete) | **DELETE** /live-streams/{liveStreamId} | Delete a live stream
[**deleteThumbnail**](docs/LiveApi.md#deleteThumbnail) | **DELETE** /live-streams/{liveStreamId}/thumbnail | Delete a thumbnail
[**list**](docs/LiveApi.md#list) | **GET** /live-streams | List all live streams
[**get**](docs/LiveApi.md#get) | **GET** /live-streams/{liveStreamId} | Show live stream
[**update**](docs/LiveApi.md#update) | **PATCH** /live-streams/{liveStreamId} | Update a live stream
[**create**](docs/LiveApi.md#create) | **POST** /live-streams | Create live stream
[**uploadThumbnail**](docs/LiveApi.md#uploadThumbnail) | **POST** /live-streams/{liveStreamId}/thumbnail | Upload a thumbnail


### PlayersApi


#### Retrieve an instance of PlayersApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
PlayersApi players = client.Players()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete**](docs/PlayersApi.md#delete) | **DELETE** /players/{playerId} | Delete a player
[**deleteLogo**](docs/PlayersApi.md#deleteLogo) | **DELETE** /players/{playerId}/logo | Delete logo
[**list**](docs/PlayersApi.md#list) | **GET** /players | List all players
[**get**](docs/PlayersApi.md#get) | **GET** /players/{playerId} | Show a player
[**update**](docs/PlayersApi.md#update) | **PATCH** /players/{playerId} | Update a player
[**create**](docs/PlayersApi.md#create) | **POST** /players | Create a player
[**uploadLogo**](docs/PlayersApi.md#uploadLogo) | **POST** /players/{playerId}/logo | Upload a logo


### RawStatisticsApi


#### Retrieve an instance of RawStatisticsApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
RawStatisticsApi rawStatistics = client.RawStatistics()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**getLiveStreamAnalytics**](docs/RawStatisticsApi.md#getLiveStreamAnalytics) | **GET** /analytics/live-streams/{liveStreamId} | List live stream player sessions
[**listPlayerSessionEvents**](docs/RawStatisticsApi.md#listPlayerSessionEvents) | **GET** /analytics/sessions/{sessionId}/events | List player session events
[**listSessions**](docs/RawStatisticsApi.md#listSessions) | **GET** /analytics/videos/{videoId} | List video player sessions


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
[**getVideoStatus**](docs/VideosApi.md#getVideoStatus) | **GET** /videos/{videoId}/status | Show video status
[**list**](docs/VideosApi.md#list) | **GET** /videos | List all videos
[**update**](docs/VideosApi.md#update) | **PATCH** /videos/{videoId} | Update a video
[**pickThumbnail**](docs/VideosApi.md#pickThumbnail) | **PATCH** /videos/{videoId}/thumbnail | Pick a thumbnail
[**create**](docs/VideosApi.md#create) | **POST** /videos | Create a video
[**upload**](docs/VideosApi.md#upload) | **POST** /videos/{videoId}/source | Upload a video
[**uploadThumbnail**](docs/VideosApi.md#uploadThumbnail) | **POST** /videos/{videoId}/thumbnail | Upload a thumbnail


### VideosDelegatedUploadApi


#### Retrieve an instance of VideosDelegatedUploadApi:
```java
ApiVideoClient apiVideoClient = new ApiVideoClient("YOUR_API_TOKEN");
VideosDelegatedUploadApi videosDelegatedUpload = client.VideosDelegatedUpload()
```

#### Endpoints

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteToken**](docs/VideosDelegatedUploadApi.md#deleteToken) | **DELETE** /upload-tokens/{uploadToken} | Delete an upload token
[**listTokens**](docs/VideosDelegatedUploadApi.md#listTokens) | **GET** /upload-tokens | List all active upload tokens.
[**getToken**](docs/VideosDelegatedUploadApi.md#getToken) | **GET** /upload-tokens/{uploadToken} | Show upload token
[**upload**](docs/VideosDelegatedUploadApi.md#upload) | **POST** /upload | Upload with an upload token
[**createToken**](docs/VideosDelegatedUploadApi.md#createToken) | **POST** /upload-tokens | Generate an upload token


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



## Documentation for Models

 - [AccessToken](docs/AccessToken.md)
 - [Account](docs/Account.md)
 - [AccountQuota](docs/AccountQuota.md)
 - [AuthenticatePayload](docs/AuthenticatePayload.md)
 - [BadRequest](docs/BadRequest.md)
 - [BytesRange](docs/BytesRange.md)
 - [CaptionsListResponse](docs/CaptionsListResponse.md)
 - [CaptionsUpdatePayload](docs/CaptionsUpdatePayload.md)
 - [Chapter](docs/Chapter.md)
 - [ChaptersListResponse](docs/ChaptersListResponse.md)
 - [Link](docs/Link.md)
 - [LiveStream](docs/LiveStream.md)
 - [LiveStreamAssets](docs/LiveStreamAssets.md)
 - [LiveStreamCreatePayload](docs/LiveStreamCreatePayload.md)
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
 - [Player](docs/Player.md)
 - [PlayerAllOf](docs/PlayerAllOf.md)
 - [PlayerAllOfAssets](docs/PlayerAllOfAssets.md)
 - [PlayerCreationPayload](docs/PlayerCreationPayload.md)
 - [PlayerSessionEvent](docs/PlayerSessionEvent.md)
 - [PlayerUpdatePayload](docs/PlayerUpdatePayload.md)
 - [Playerinput](docs/Playerinput.md)
 - [PlayersListResponse](docs/PlayersListResponse.md)
 - [Quality](docs/Quality.md)
 - [RawStatisticsListLiveStreamAnalyticsResponse](docs/RawStatisticsListLiveStreamAnalyticsResponse.md)
 - [RawStatisticsListPlayerSessionEventsResponse](docs/RawStatisticsListPlayerSessionEventsResponse.md)
 - [RawStatisticsListSessionsResponse](docs/RawStatisticsListSessionsResponse.md)
 - [RefreshTokenPayload](docs/RefreshTokenPayload.md)
 - [Subtitle](docs/Subtitle.md)
 - [TokenCreatePayload](docs/TokenCreatePayload.md)
 - [TokenListResponse](docs/TokenListResponse.md)
 - [UploadToken](docs/UploadToken.md)
 - [Video](docs/Video.md)
 - [VideoAssets](docs/VideoAssets.md)
 - [VideoCreatePayload](docs/VideoCreatePayload.md)
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
 - [VideoThumbnailPickPayload](docs/VideoThumbnailPickPayload.md)
 - [VideoUpdatePayload](docs/VideoUpdatePayload.md)
 - [VideosListResponse](docs/VideosListResponse.md)
 - [Videostatus](docs/Videostatus.md)
 - [VideostatusEncoding](docs/VideostatusEncoding.md)
 - [VideostatusEncodingMetadata](docs/VideostatusEncodingMetadata.md)
 - [VideostatusIngest](docs/VideostatusIngest.md)
 - [Webhook](docs/Webhook.md)
 - [WebhooksCreatePayload](docs/WebhooksCreatePayload.md)
 - [WebhooksListResponse](docs/WebhooksListResponse.md)


## Documentation for Authorization

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

## Author

