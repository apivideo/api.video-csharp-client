# VideoApiClient.Api.CaptionsApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete**](CaptionsApi.md#deletevideosvideoidcaptionslanguage) | **DELETE** /videos/{videoId}/captions/{language} | Delete a caption
[**list**](CaptionsApi.md#getvideosvideoidcaptions) | **GET** /videos/{videoId}/captions | List video captions
[**get**](CaptionsApi.md#getvideosvideoidcaptionslanguage) | **GET** /videos/{videoId}/captions/{language} | Show a caption
[**update**](CaptionsApi.md#patchvideosvideoidcaptionslanguage) | **PATCH** /videos/{videoId}/captions/{language} | Update caption
[**upload**](CaptionsApi.md#postvideosvideoidcaptionslanguage) | **POST** /videos/{videoId}/captions/{language} | Upload a caption


<a name="deletevideosvideoidcaptionslanguage"></a>
# **delete**
> void delete (string videoId, string language)

Delete a caption

Delete a caption in a specific language by providing the video ID for the video you want to delete the caption from and the language the caption is in.

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

            var videoId = vi4k0jvEUuaTdRAEjQ4Prklgc;  // string | The unique identifier for the video you want to delete a caption from.
            var language = en;  // string | A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation.
            var apiCaptionsInstance = apiInstance.Captions();
            try
            {
                // Delete a caption
                apiCaptionsInstance.delete(videoId, language);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptionsApi.delete: " + e.Message );
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
 **videoId** | **string**| The unique identifier for the video you want to delete a caption from. | 
 **language** | **string**| A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation. | 

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

<a name="getvideosvideoidcaptions"></a>
# **list**
> CaptionsListResponse list (string videoId, int? currentPage = null, int? pageSize = null)

List video captions

Retrieve a list of available captions for the videoId you provide.

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

            var videoId = vi4k0jvEUuaTdRAEjQ4Prklg;  // string | The unique identifier for the video you want to retrieve a list of captions for.
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiCaptionsInstance = apiInstance.Captions();
            try
            {
                // List video captions
                CaptionsListResponse result = apiCaptionsInstance.list(videoId, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptionsApi.list: " + e.Message );
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
 **videoId** | **string**| The unique identifier for the video you want to retrieve a list of captions for. | 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**CaptionsListResponse**](CaptionsListResponse.md)

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

<a name="getvideosvideoidcaptionslanguage"></a>
# **get**
> Subtitle get (string videoId, string language)

Show a caption

Display a caption for a video in a specific language. If the language is available, the caption is returned. Otherwise, you will get a response indicating the caption was not found.

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

            var videoId = vi4k0jvEUuaTdRAEjQ4Prklg;  // string | The unique identifier for the video you want captions for.
            var language = en;  // string | A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation
            var apiCaptionsInstance = apiInstance.Captions();
            try
            {
                // Show a caption
                Subtitle result = apiCaptionsInstance.get(videoId, language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptionsApi.get: " + e.Message );
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
 **videoId** | **string**| The unique identifier for the video you want captions for. | 
 **language** | **string**| A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation | 

### Return type

[**Subtitle**](Subtitle.md)

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

<a name="patchvideosvideoidcaptionslanguage"></a>
# **update**
> Subtitle update (string videoId, string language, CaptionsUpdatePayload captionsUpdatePayload = null)

Update caption

To have the captions on automatically, use this PATCH to set default: true.

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

            var videoId = vi4k0jvEUuaTdRAEjQ4Prklg;  // string | The unique identifier for the video you want to have automatic captions for. 
            var language = en;  // string | A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation.
            var captionsUpdatePayload = new CaptionsUpdatePayload(); // CaptionsUpdatePayload |  (optional) 
            var apiCaptionsInstance = apiInstance.Captions();
            try
            {
                // Update caption
                Subtitle result = apiCaptionsInstance.update(videoId, language, captionsUpdatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptionsApi.update: " + e.Message );
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
 **videoId** | **string**| The unique identifier for the video you want to have automatic captions for.  | 
 **language** | **string**| A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation. | 
 **captionsUpdatePayload** | [**CaptionsUpdatePayload**](CaptionsUpdatePayload.md)|  | [optional] 

### Return type

[**Subtitle**](Subtitle.md)

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

<a name="postvideosvideoidcaptionslanguage"></a>
# **upload**
> Subtitle upload (string videoId, string language, System.IO.Stream file)

Upload a caption

Upload a VTT file to add captions to your video.  Read our [captioning tutorial](https://api.video/blog/tutorials/adding-captions) for more details.

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

            var videoId = vi4k0jvEUuaTdRAEjQ4Prklg;  // string | The unique identifier for the video you want to add a caption to.
            var language = en;  // string | A valid BCP 47 language representation.
            var file = BINARY_DATA_HERE;  // System.IO.Stream | The video text track (VTT) you want to upload.
            var apiCaptionsInstance = apiInstance.Captions();
            try
            {
                // Upload a caption
                Subtitle result = apiCaptionsInstance.upload(videoId, language, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CaptionsApi.upload: " + e.Message );
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
 **videoId** | **string**| The unique identifier for the video you want to add a caption to. | 
 **language** | **string**| A valid BCP 47 language representation. | 
 **file** | **System.IO.Stream****System.IO.Stream**| The video text track (VTT) you want to upload. | 

### Return type

[**Subtitle**](Subtitle.md)

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
