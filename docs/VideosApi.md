# ApiVideo.Api.VideosApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**create**](VideosApi.md#postvideo) | **POST** /videos | Create a video object
[**upload**](VideosApi.md#postvideosvideoidsource) | **POST** /videos/{videoId}/source | Upload a video
[**uploadWithUploadToken**](VideosApi.md#postupload) | **POST** /upload | Upload with an delegated upload token
[**get**](VideosApi.md#getvideo) | **GET** /videos/{videoId} | Retrieve a video object
[**update**](VideosApi.md#patchvideo) | **PATCH** /videos/{videoId} | Update a video object
[**delete**](VideosApi.md#deletevideo) | **DELETE** /videos/{videoId} | Delete a video object
[**list**](VideosApi.md#listvideos) | **GET** /videos | List all video objects
[**uploadThumbnail**](VideosApi.md#postvideosvideoidthumbnail) | **POST** /videos/{videoId}/thumbnail | Upload a thumbnail
[**pickThumbnail**](VideosApi.md#patchvideosvideoidthumbnail) | **PATCH** /videos/{videoId}/thumbnail | Set a thumbnail
[**getStatus**](VideosApi.md#getvideostatus) | **GET** /videos/{videoId}/status | Retrieve video status and details


<a name="postvideo"></a>
# **create**
> Video create (VideoCreationPayload videoCreationPayload)

Create a video object

Creates a video object. More information on video objects can be found [here](https://docs.api.video/reference/videos-1). 

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class createExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoCreationPayload = new VideoCreationPayload(); // VideoCreationPayload | video to create
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // Create a video
                Video result = apiVideosInstance.create(videoCreationPayload);
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
 **videoCreationPayload** | [**VideoCreationPayload**](VideoCreationPayload.md)| video to create | 

### Return type

[**Video**](Video.md)

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

To upload a video to the videoId you created. You can only upload your video to the videoId once.



We offer 2 types of upload: 

* Regular upload 

* Progressive upload

The latter allows you to split a video source into X chunks and send those chunks independently (concurrently or sequentially). The 2 main goals for our users are to

  * allow the upload of video sources > 200 MiB (200 MiB = the max. allowed file size for regular upload)

  * allow to send a video source "progressively", i.e., before before knowing the total size of the video.

  Once all chunks have been sent, they are reaggregated to one source file. The video source is considered as "completely sent" when the "last" chunk is sent (i.e., the chunk that "completes" the upload).



### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class uploadExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | Enter the videoId you want to use to upload your video.
            var file = BINARY_DATA_HERE;  // System.IO.Stream | The path to the video you would like to upload. The path must be local. If you want to use a video from an online source, you must use the "/videos" endpoint and add the "source" parameter when you create a new video.
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

<a name="postupload"></a>
# **uploadWithUploadToken**
> Video uploadWithUploadToken (string token, System.IO.Stream file)

Upload with an delegated upload token

This method allows you to send a video using an upload token. Upload tokens are especially useful when the upload is done from the client side. If you want to upload a video from your server-side application, you'd better use the [standard upload method](#upload).

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class uploadWithUploadTokenExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var token = to1tcmSFHeYY5KzyhOqVKMKb;  // string | The unique identifier for the token you want to use to upload a video.
            var file = BINARY_DATA_HERE;  // System.IO.Stream | The path to the video you want to upload.
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // Upload with an delegated upload token
                Video result = apiVideosInstance.uploadWithUploadToken(token, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.uploadWithUploadToken: " + e.Message );
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
 **token** | **string**| The unique identifier for the token you want to use to upload a video. | 
 **file** | **System.IO.Stream****System.IO.Stream**| The path to the video you want to upload. | 

### Return type

[**Video**](Video.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideo"></a>
# **get**
> Video get (string videoId)

Retrieve a video object

This call provides the same information provided on video creation. For private videos, it will generate a unique token url. Use this to retrieve any details you need about a video, or set up a private viewing URL.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class getExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
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

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchvideo"></a>
# **update**
> Video update (string videoId, VideoUpdatePayload videoUpdatePayload)

Update a video object

Updates the parameters associated with a video ID. The video object you are updating is determined by the video ID you provide. 



NOTE: If you are updating an array, you must provide the entire array as what you provide here overwrites what is in the system rather than appending to it.



### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class updateExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | The video ID for the video you want to delete.
            var videoUpdatePayload = new VideoUpdatePayload(); // VideoUpdatePayload | 
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
 **videoId** | **string**| The video ID for the video you want to update. | 
 **videoUpdatePayload** | [**VideoUpdatePayload**](VideoUpdatePayload.md)|  | 

### Return type

[**Video**](Video.md)

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

<a name="deletevideo"></a>
# **delete**
> void delete (string videoId)

Delete a video object

If you do not need a video any longer, you can send a request to delete it. All you need is the videoId.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class deleteExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
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

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listvideos"></a>
# **list**
> VideosListResponse list (string title = null, List<string> tags = null, Dictionary<string, string> metadata = null, string description = null, string liveStreamId = null, string sortBy = null, string sortOrder = null, int? currentPage = null, int? pageSize = null)

List all video objects

This method returns a list of your videos (with all their details). With no parameters added, the API returns the first page of all videos. You can filter videos using the parameters described below.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class listExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var title = My Video.mp4;  // string | The title of a specific video you want to find. The search will match exactly to what term you provide and return any videos that contain the same term as part of their titles. (optional) 
            var tags = new List<string>(); // List<string> | A tag is a category you create and apply to videos. You can search for videos with particular tags by listing one or more here. Only videos that have all the tags you list will be returned. (optional) 
            var metadata = new Dictionary<string, string>(); // Dictionary<string, string> | Videos can be tagged with metadata tags in key:value pairs. You can search for videos with specific key value pairs using this parameter. [Dynamic Metadata](https://api.video/blog/endpoints/dynamic-metadata) allows you to define a key that allows any value pair. (optional) 
            var description = New Zealand;  // string | Retrieve video objects by `description`. (optional) 
            var liveStreamId = li400mYKSgQ6xs7taUeSaEKr;  // string | Retrieve video objects that were recorded from a live stream by `liveStreamId`. (optional) 
            var sortBy = publishedAt;  // string | Use this parameter to sort videos by the their created time, published time, updated time, or by title. (optional) 
            var sortOrder = asc;  // string | Use this parameter to sort results. `asc` is ascending and sorts from A to Z. `desc` is descending and sorts from Z to A. (optional) 
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // List all video objects
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
 **metadata** | [**Dictionary&lt;string, string&gt;**](string.md)| Videos can be tagged with metadata tags in key:value pairs. You can search for videos with specific key value pairs using this parameter. [Dynamic Metadata](https://api.video/blog/endpoints/dynamic-metadata) allows you to define a key that allows any value pair. | [optional] 
 **description** | **string**| Retrieve video objects by &#x60;description&#x60;. | [optional] 
 **liveStreamId** | **string**| Retrieve video objects that were recorded from a live stream by &#x60;liveStreamId&#x60;. | [optional] 
 **sortBy** | **string**| Use this parameter to sort videos by the their created time, published time, updated time, or by title. | [optional] 
 **sortOrder** | **string**| Use this parameter to sort results. &#x60;asc&#x60; is ascending and sorts from A to Z. &#x60;desc&#x60; is descending and sorts from Z to A. | [optional] 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**VideosListResponse**](VideosListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postvideosvideoidthumbnail"></a>
# **uploadThumbnail**
> Video uploadThumbnail (string videoId, System.IO.Stream file)

Upload a thumbnail

The thumbnail is the poster that appears in the player window before video playback begins.



This endpoint allows you to upload an image for the thumbnail.



To select a still frame from the video using a time stamp, use the [dedicated method](#pickThumbnail) to pick a time in the video.



Note: There may be a short delay before the new thumbnail is delivered to our CDN.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class uploadThumbnailExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
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
 **file** | **System.IO.Stream****System.IO.Stream**| The image to be added as a thumbnail. The mime type should be image/jpeg, image/png or image/webp. The max allowed size is 8 MiB. | 

### Return type

[**Video**](Video.md)

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

<a name="patchvideosvideoidthumbnail"></a>
# **pickThumbnail**
> Video pickThumbnail (string videoId, VideoThumbnailPickPayload videoThumbnailPickPayload)

Set a thumbnail

Pick a thumbnail from the given time code. 



If you'd like to upload an image for your thumbnail, use the dedicated [method](#uploadThumbnail). 



There may be a short delay for the thumbnail to update.



### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class pickThumbnailExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | Unique identifier of the video you want to add a thumbnail to, where you use a section of your video as the thumbnail.
            var videoThumbnailPickPayload = new VideoThumbnailPickPayload(); // VideoThumbnailPickPayload | 
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
 **videoThumbnailPickPayload** | [**VideoThumbnailPickPayload**](VideoThumbnailPickPayload.md)|  | 

### Return type

[**Video**](Video.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideostatus"></a>
# **getStatus**
> VideoStatus getStatus (string videoId)

Retrieve video status and details

This method provides upload status & encoding status to determine when the video is uploaded or ready to playback. Once encoding is completed, the response also lists the available stream qualities.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class getStatusExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | The unique identifier for the video you want the status for.
            var apiVideosInstance = apiInstance.Videos();
            try
            {
                // Show video status
                VideoStatus result = apiVideosInstance.getStatus(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.getStatus: " + e.Message );
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

[**VideoStatus**](VideoStatus.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

