# VideoApiClient.Api.VideosApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete**](VideosApi.md#deletevideo) | **DELETE** /videos/{videoId} | Delete a video
[**get**](VideosApi.md#getvideo) | **GET** /videos/{videoId} | Show a video
[**getVideoStatus**](VideosApi.md#getvideostatus) | **GET** /videos/{videoId}/status | Show video status
[**list**](VideosApi.md#listvideos) | **GET** /videos | List all videos
[**update**](VideosApi.md#patchvideo) | **PATCH** /videos/{videoId} | Update a video
[**pickThumbnail**](VideosApi.md#patchvideosvideoidthumbnail) | **PATCH** /videos/{videoId}/thumbnail | Pick a thumbnail
[**create**](VideosApi.md#postvideo) | **POST** /videos | Create a video
[**upload**](VideosApi.md#postvideosvideoidsource) | **POST** /videos/{videoId}/source | Upload a video
[**uploadThumbnail**](VideosApi.md#postvideosvideoidthumbnail) | **POST** /videos/{videoId}/thumbnail | Upload a thumbnail


<a name="deletevideo"></a>
# **delete**
> void delete (string videoId)

Delete a video

If you do not need a video any longer, you can send a request to delete it. All you need is the videoId.

### Example
```csharp
using System.Diagnostics;
using VideoApiClient.Client;

namespace Example
{
    public class deleteExample
    {
        public static void Main()
        {
            var basePath = VideoApiClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | The video ID for the video you want to delete.
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // Delete a video
                apiVideosInstance.delete(videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.delete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **string**| The video ID for the video you want to delete. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideo"></a>
# **get**
> Video get (string videoId)

Show a video

This call provides the same JSON information provided on video creation. For private videos, it will generate a unique token url. Use this to retrieve any details you need about a video, or set up a private viewing URL.

### Example
```csharp
using System.Diagnostics;
using VideoApiClient.Client;

namespace Example
{
    public class getExample
    {
        public static void Main()
        {
            var basePath = VideoApiClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoId = videoId_example;  // string | The unique identifier for the video you want details about.
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // Show a video
                Video result = apiVideosInstance.get(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.get: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **string**| The unique identifier for the video you want details about. | 

### Return type

[**Video**](Video.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideostatus"></a>
# **getVideoStatus**
> Videostatus getVideoStatus (string videoId)

Show video status

This API provides upload status & encoding status to determine when the video is uploaded or ready to playback.  Once encoding is completed, the response also lists the available stream qualities.

### Example
```csharp
using System.Diagnostics;
using VideoApiClient.Client;

namespace Example
{
    public class getVideoStatusExample
    {
        public static void Main()
        {
            var basePath = VideoApiClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | The unique identifier for the video you want the status for.
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // Show video status
                Videostatus result = apiVideosInstance.getVideoStatus(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.getVideoStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **string**| The unique identifier for the video you want the status for. | 

### Return type

[**Videostatus**](Videostatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listvideos"></a>
# **list**
> VideosListResponse list (string title = null, List<string> tags = null, List<string> metadata = null, string description = null, string liveStreamId = null, string sortBy = null, string sortOrder = null, int? currentPage = null, int? pageSize = null)

List all videos

Requests to this endpoint return a list of your videos (with all their details). With no parameters added to this query, the API returns all videos. You can filter what videos the API returns using the parameters described below.

### Example
```csharp
using System.Diagnostics;
using VideoApiClient.Client;

namespace Example
{
    public class listExample
    {
        public static void Main()
        {
            var basePath = VideoApiClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var title = My Video.mp4;  // string | The title of a specific video you want to find. The search will match exactly to what term you provide and return any videos that contain the same term as part of their titles. (optional) 
            var tags = new List<string>(); // List<string> | A tag is a category you create and apply to videos. You can search for videos with particular tags by listing one or more here. Only videos that have all the tags you list will be returned. (optional) 
            var metadata = new List<string>(); // List<string> | Videos can be tagged with metadata tags in key:value pairs. You can search for videos with specific key value pairs using this parameter. (optional) 
            var description = New Zealand;  // string | If you described a video with a term or sentence, you can add it here to return videos containing this string. (optional) 
            var liveStreamId = li400mYKSgQ6xs7taUeSaEKr;  // string | If you know the ID for a live stream, you can retrieve the stream by adding the ID for it here. (optional) 
            var sortBy = publishedAt;  // string | Allowed: publishedAt, title. You can search by the time videos were published at, or by title. (optional) 
            var sortOrder = asc;  // string | Allowed: asc, desc. asc is ascending and sorts from A to Z. desc is descending and sorts from Z to A. (optional) 
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // List all videos
                VideosListResponse result = apiVideosInstance.list(title, tags, metadata, description, liveStreamId, sortBy, sortOrder, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.list: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **title** | **string**| The title of a specific video you want to find. The search will match exactly to what term you provide and return any videos that contain the same term as part of their titles. | [optional] 
 **tags** | [**List&lt;string&gt;**](string.md)| A tag is a category you create and apply to videos. You can search for videos with particular tags by listing one or more here. Only videos that have all the tags you list will be returned. | [optional] 
 **metadata** | [**List&lt;string&gt;**](string.md)| Videos can be tagged with metadata tags in key:value pairs. You can search for videos with specific key value pairs using this parameter. | [optional] 
 **description** | **string**| If you described a video with a term or sentence, you can add it here to return videos containing this string. | [optional] 
 **liveStreamId** | **string**| If you know the ID for a live stream, you can retrieve the stream by adding the ID for it here. | [optional] 
 **sortBy** | **string**| Allowed: publishedAt, title. You can search by the time videos were published at, or by title. | [optional] 
 **sortOrder** | **string**| Allowed: asc, desc. asc is ascending and sorts from A to Z. desc is descending and sorts from Z to A. | [optional] 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**VideosListResponse**](VideosListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchvideo"></a>
# **update**
> Video update (string videoId, VideoUpdatePayload videoUpdatePayload = null)

Update a video

Use this endpoint to update the parameters associated with your video. The video you are updating is determined by the video ID you provide in the path. For each parameter you want to update, include the update in the request body. NOTE: If you are updating an array, you must provide the entire array as what you provide here overwrites what is in the system rather than appending to it.

### Example
```csharp
using System.Diagnostics;
using VideoApiClient.Client;

namespace Example
{
    public class updateExample
    {
        public static void Main()
        {
            var basePath = VideoApiClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | The video ID for the video you want to delete.
            var videoUpdatePayload = new VideoUpdatePayload(); // VideoUpdatePayload |  (optional) 
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // Update a video
                Video result = apiVideosInstance.update(videoId, videoUpdatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.update: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **string**| The video ID for the video you want to delete. | 
 **videoUpdatePayload** | [**VideoUpdatePayload**](VideoUpdatePayload.md)|  | [optional] 

### Return type

[**Video**](Video.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchvideosvideoidthumbnail"></a>
# **pickThumbnail**
> Video pickThumbnail (string videoId, VideoThumbnailPickPayload videoThumbnailPickPayload = null)

Pick a thumbnail

Pick a thumbnail from the given time code. If you'd like to upload an image for your thumbnail, use the [Upload a Thumbnail](https://docs.api.video/reference#post_videos-videoid-thumbnail) endpoint. There may be a short delay for the thumbnail to update.

### Example
```csharp
using System.Diagnostics;
using VideoApiClient.Client;

namespace Example
{
    public class pickThumbnailExample
    {
        public static void Main()
        {
            var basePath = VideoApiClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | Unique identifier of the video you want to add a thumbnail to, where you use a section of your video as the thumbnail.
            var videoThumbnailPickPayload = new VideoThumbnailPickPayload(); // VideoThumbnailPickPayload |  (optional) 
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // Pick a thumbnail
                Video result = apiVideosInstance.pickThumbnail(videoId, videoThumbnailPickPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.pickThumbnail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **string**| Unique identifier of the video you want to add a thumbnail to, where you use a section of your video as the thumbnail. | 
 **videoThumbnailPickPayload** | [**VideoThumbnailPickPayload**](VideoThumbnailPickPayload.md)|  | [optional] 

### Return type

[**Video**](Video.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postvideo"></a>
# **create**
> Video create (VideoCreatePayload videoCreatePayload = null)

Create a video

To create a video, you create its metadata first, before adding the video file (exception - when using an existing HTTP source).  Videos are public by default. Mp4 encoded versions are created at the highest quality (max 1080p) by default.  ```shell $ curl https://ws.api.video/videos \\ -H 'Authorization: Bearer {access_token} \\ -d '{\"title\":\"My video\",       \"description\":\"so many details\",      \"mp4Support\":true }' ```  ### Creating a hosted video   You can also create a video directly from one hosted on a third-party server by giving its URI in `source` parameter:  ```shell $ curl https://ws.api.video/videos \\ -H 'Authorization: Bearer {access_token} \\ -d '{\"source\":\"http://uri/to/video.mp4\", \"title\":\"My video\"}' ```  In this case, the service will respond `202 Accepted` and download the video asynchronously.   We have tutorials on: * [Creating and uploading videos](https://api.video/blog/tutorials/video-upload-tutorial) * [Uploading large videos](https://api.video/blog/tutorials/video-upload-tutorial-large-videos) * [Using tags with videos](https://api.video/blog/tutorials/video-tagging-best-practices) * [Private videos](https://api.video/blog/tutorials/tutorial-private-videos) 

### Example
```csharp
using System.Diagnostics;
using VideoApiClient.Client;

namespace Example
{
    public class createExample
    {
        public static void Main()
        {
            var basePath = VideoApiClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoCreatePayload = new VideoCreatePayload(); // VideoCreatePayload | video to create (optional) 
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // Create a video
                Video result = apiVideosInstance.create(videoCreatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.create: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoCreatePayload** | [**VideoCreatePayload**](VideoCreatePayload.md)| video to create | [optional] 

### Return type

[**Video**](Video.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postvideosvideoidsource"></a>
# **upload**
> Video upload (string videoId, System.IO.Stream file)

Upload a video

To upload a video to the videoId you created. Replace {videoId} with the id you'd like to use, {access_token} with your token, and /path/to/video.mp4 with the path to the video you'd like to upload. You can only upload your video to the videoId once.  ```bash curl https://ws.api.video/videos/{videoId}/source \\   -H 'Authorization: Bearer {access_token}' \\   -F file=@/path/to/video.mp4   ```

### Example
```csharp
using System.Diagnostics;
using VideoApiClient.Client;

namespace Example
{
    public class uploadExample
    {
        public static void Main()
        {
            var basePath = VideoApiClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | Enter the videoId you want to use to upload your video.
            var file = BINARY_DATA_HERE;  // System.IO.Stream | The path to the video you would like to upload. The path must be local. If you want to use a video from an online source, you must use the \\\"/videos\\\" endpoint and add the \\\"source\\\" parameter when you create a new video.
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // Upload a video
                Video result = apiVideosInstance.upload(videoId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.upload: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **string**| Enter the videoId you want to use to upload your video. | 
 **file** | **System.IO.Stream****System.IO.Stream**| The path to the video you would like to upload. The path must be local. If you want to use a video from an online source, you must use the \\\&quot;/videos\\\&quot; endpoint and add the \\\&quot;source\\\&quot; parameter when you create a new video. | 

### Return type

[**Video**](Video.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postvideosvideoidthumbnail"></a>
# **uploadThumbnail**
> Video uploadThumbnail (string videoId, System.IO.Stream file)

Upload a thumbnail

In creating a thumbnail, you may either upload an image, or you can pick a time in the video to be used as thumbnail. This endpoint is for uploading an image. Use [Pick a Thumbnail](https://docs.api.video/reference#patch_videos-videoid-thumbnail) to pick a time in the video. There may be a short delay before the new thumbnail is delivered to our CDN.

### Example
```csharp
using System.Diagnostics;
using VideoApiClient.Client;

namespace Example
{
    public class uploadThumbnailExample
    {
        public static void Main()
        {
            var basePath = VideoApiClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoId = videoId_example;  // string | Unique identifier of the chosen video 
            var file = BINARY_DATA_HERE;  // System.IO.Stream | The image to be added as a thumbnail.
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // Upload a thumbnail
                Video result = apiVideosInstance.uploadThumbnail(videoId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.uploadThumbnail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **string**| Unique identifier of the chosen video  | 
 **file** | **System.IO.Stream****System.IO.Stream**| The image to be added as a thumbnail. | 

### Return type

[**Video**](Video.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
