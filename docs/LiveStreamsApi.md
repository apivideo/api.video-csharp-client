# ApiVideo.Api.LiveStreamsApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**create**](LiveStreamsApi.md#postlivestreams) | **POST** /live-streams | Create live stream
[**get**](LiveStreamsApi.md#getlivestreamslivestreamid) | **GET** /live-streams/{liveStreamId} | Retrieve live stream
[**update**](LiveStreamsApi.md#patchlivestreamslivestreamid) | **PATCH** /live-streams/{liveStreamId} | Update a live stream
[**delete**](LiveStreamsApi.md#deletelivestreamslivestreamid) | **DELETE** /live-streams/{liveStreamId} | Delete a live stream
[**list**](LiveStreamsApi.md#getlivestreams) | **GET** /live-streams | List all live streams
[**uploadThumbnail**](LiveStreamsApi.md#postlivestreamslivestreamidthumbnail) | **POST** /live-streams/{liveStreamId}/thumbnail | Upload a thumbnail
[**deleteThumbnail**](LiveStreamsApi.md#deletelivestreamslivestreamidthumbnail) | **DELETE** /live-streams/{liveStreamId}/thumbnail | Delete a thumbnail


<a name="postlivestreams"></a>
# **create**
> LiveStream create (LiveStreamCreationPayload liveStreamCreationPayload)

Create live stream

A live stream will give you the 'connection point' to RTMP your video stream to api.video.  It will also give you the details for viewers to watch the same livestream.   The public=false 'private livestream' is available as a BETA feature, and should be limited to livestreams of 3,000 viewers or fewer.  See our [Live Stream Tutorial](https://api.video/blog/tutorials/live-stream-tutorial) for a walkthrough of this API with OBS.  Your RTMP endpoint for the livestream is rtmp://broadcast.api.video/s/{streamKey} Tutorials that [create live streams](https://api.video/blog/endpoints/live-create).

### Example
```csharp
var apiVideoClient = new ApiVideoClient("YOUR_API_KEY");

var liveStreamCreationPayload = new LiveStreamCreationPayload()
{
    record = false,
    name = "My Live Stream Video",
    _public = true,
    playerid = "pl4f4ferf5erfr5zed4fsdd",
};

try
{
    var liveStream = apiVideoClient.LiveStreams().create(liveStreamCreationPayload);
}
catch (ApiException e)
{
    // Manage create error here
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **liveStreamCreationPayload** | [**LiveStreamCreationPayload**](LiveStreamCreationPayload.md)|  | 

### Return type

[**LiveStream**](LiveStream.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlivestreamslivestreamid"></a>
# **get**
> LiveStream get (string liveStreamId)

Retrieve live stream

Supply a liveStreamId, and you'll get all the details for streaming into, and watching the livestream. Tutorials that use the [show livestream endpoint](https://api.video/blog/endpoints/live-stream-status).

### Example
```csharp
import video.api.client.ApiVideoClient;
import video.api.client.api.ApiException;
import video.api.client.api.models.*;
import video.api.client.api.clients.LiveStreamsApi;
import java.util.*;

public class Example {
  public static void main(String[] args) {
    ApiVideoClient client = new ApiVideoClient("YOUR_API_KEY");
    // if you rather like to use the sandbox environment:
    // ApiVideoClient client = new ApiVideoClient("YOUR_SANDBOX_API_KEY", ApiVideoClient.Environment.SANDBOX);

    LiveStreamsApi apiInstance = client.liveStreams();
    
    String liveStreamId = "li400mYKSgQ6xs7taUeSaEKr"; // The unique ID for the live stream you want to watch.

    try {
      LiveStream result = apiInstance.get(liveStreamId);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling LiveStreamsApi#get");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getMessage());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **liveStreamId** | **string**| The unique ID for the live stream you want to watch. | 

### Return type

[**LiveStream**](LiveStream.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchlivestreamslivestreamid"></a>
# **update**
> LiveStream update (string liveStreamId, LiveStreamUpdatePayload liveStreamUpdatePayload)

Update a live stream

Use this endpoint to update the player, or to turn recording on/off (saving a copy of the livestream).  NOTE: If the livestream is actively streaming, changing the recording status will only affect the NEXT stream.     The public=false \"private livestream\" is available as a BETA feature, and should be limited to livestreams of 3,000 viewers or fewer.

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

            var liveStreamId = li400mYKSgQ6xs7taUeSaEKr;  // string | The unique ID for the live stream that you want to update information for such as player details, or whether you want the recording on or off.
            var liveStreamUpdatePayload = new LiveStreamUpdatePayload(); // LiveStreamUpdatePayload | 
            var apiLiveStreamsInstance = apiInstance.LiveStreams();
            try
            {
                // Update a live stream
                LiveStream result = apiLiveStreamsInstance.update(liveStreamId, liveStreamUpdatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.update: " + e.Message );
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
 **liveStreamId** | **string**| The unique ID for the live stream that you want to update information for such as player details, or whether you want the recording on or off. | 
 **liveStreamUpdatePayload** | [**LiveStreamUpdatePayload**](LiveStreamUpdatePayload.md)|  | 

### Return type

[**LiveStream**](LiveStream.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelivestreamslivestreamid"></a>
# **delete**
> void delete (string liveStreamId)

Delete a live stream

If you do not need a live stream any longer, you can send a request to delete it. All you need is the liveStreamId.

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

            var liveStreamId = li400mYKSgQ6xs7taUeSaEKr;  // string | The unique ID for the live stream that you want to remove.
            var apiLiveStreamsInstance = apiInstance.LiveStreams();
            try
            {
                // Delete a live stream
                apiLiveStreamsInstance.delete(liveStreamId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.delete: " + e.Message );
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
 **liveStreamId** | **string**| The unique ID for the live stream that you want to remove. | 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlivestreams"></a>
# **list**
> LiveStreamListResponse list (string streamKey = null, string name = null, string sortBy = null, string sortOrder = null, int? currentPage = null, int? pageSize = null)

List all live streams

With no parameters added to the url, this will return all livestreams. Query by name or key to limit the list.

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

            var liveStreamId = li400mYKSgQ6xs7taUeSaEKr;  // string | The unique ID for the live stream you want to watch.
            var apiLiveStreamsInstance = apiInstance.LiveStreams();
            try
            {
                // Show live stream
                LiveStream result = apiLiveStreamsInstance.get(liveStreamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.get: " + e.Message );
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
 **streamKey** | **string**| The unique stream key that allows you to stream videos. | [optional] 
 **name** | **string**| You can filter live streams by their name or a part of their name. | [optional] 
 **sortBy** | **string**| Allowed: createdAt, publishedAt, name. createdAt - the time a livestream was created using the specified streamKey. publishedAt - the time a livestream was published using the specified streamKey. name - the name of the livestream. If you choose one of the time based options, the time is presented in ISO-8601 format. | [optional] 
 **sortOrder** | **string**| Allowed: asc, desc. Ascending for date and time means that earlier values precede later ones. Descending means that later values preced earlier ones. For title, it is 0-9 and A-Z ascending and Z-A, 9-0 descending. | [optional] 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**LiveStreamListResponse**](LiveStreamListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlivestreamslivestreamidthumbnail"></a>
# **uploadThumbnail**
> LiveStream uploadThumbnail (string liveStreamId, System.IO.Stream file)

Upload a thumbnail

Upload an image to use as a backdrop for your livestream. Tutorials that [update live stream thumbnails](https://api.video/blog/endpoints/live-upload-a-thumbnail).

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

            var liveStreamId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | The unique ID for the live stream you want to upload.
            var file = BINARY_DATA_HERE;  // System.IO.Stream | The image to be added as a thumbnail.
            var apiLiveStreamsInstance = apiInstance.LiveStreams();
            try
            {
                // Upload a thumbnail
                LiveStream result = apiLiveStreamsInstance.uploadThumbnail(liveStreamId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.uploadThumbnail: " + e.Message );
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
 **liveStreamId** | **string**| The unique ID for the live stream you want to upload. | 
 **file** | **System.IO.Stream****System.IO.Stream**| The image to be added as a thumbnail. The mime type should be image/jpeg, image/png or image/webp. The max allowed size is 8 MiB. | 

### Return type

[**LiveStream**](LiveStream.md)

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

<a name="deletelivestreamslivestreamidthumbnail"></a>
# **deleteThumbnail**
> LiveStream deleteThumbnail (string liveStreamId)

Delete a thumbnail

Send the unique identifier for a live stream to delete its thumbnail.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class deleteThumbnailExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var liveStreamId = li400mYKSgQ6xs7taUeSaEKr;  // string | The unique identifier for the live stream you want to delete. 
            var apiLiveStreamsInstance = apiInstance.LiveStreams();
            try
            {
                // Delete a thumbnail
                LiveStream result = apiLiveStreamsInstance.deleteThumbnail(liveStreamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiveStreamsApi.deleteThumbnail: " + e.Message );
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
 **liveStreamId** | **string**| The unique identifier of the live stream whose thumbnail you want to delete. | 

### Return type

[**LiveStream**](LiveStream.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

