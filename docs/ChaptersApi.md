# ApiVideo.Api.ChaptersApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**upload**](ChaptersApi.md#postvideosvideoidchapterslanguage) | **POST** /videos/{videoId}/chapters/{language} | Upload a chapter
[**get**](ChaptersApi.md#getvideosvideoidchapterslanguage) | **GET** /videos/{videoId}/chapters/{language} | Retrieve a chapter
[**delete**](ChaptersApi.md#deletevideosvideoidchapterslanguage) | **DELETE** /videos/{videoId}/chapters/{language} | Delete a chapter
[**list**](ChaptersApi.md#getvideosvideoidchapters) | **GET** /videos/{videoId}/chapters | List video chapters


<a name="postvideosvideoidchapterslanguage"></a>
# **upload**
> Chapter upload (string videoId, string language, System.IO.Stream file)

Upload a chapter

Upload a VTT file to add chapters to your video. Chapters help break the video into sections. Read our [tutorial](https://api.video/blog/tutorials/adding-chapters-to-your-videos) for more details.

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

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | The unique identifier for the video you want to upload a chapter for.
            var language = en;  // string | A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation.
            var file = BINARY_DATA_HERE;  // System.IO.Stream | The VTT file describing the chapters you want to upload.
            var apiChaptersInstance = apiInstance.Chapters();
            try
            {
                // Upload a chapter
                Chapter result = apiChaptersInstance.upload(videoId, language, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChaptersApi.upload: " + e.Message );
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
 **videoId** | **string**| The unique identifier for the video you want to upload a chapter for. | 
 **language** | **string**| A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation. | 
 **file** | **System.IO.Stream****System.IO.Stream**| The VTT file describing the chapters you want to upload. | 

### Return type

[**Chapter**](Chapter.md)

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

<a name="getvideosvideoidchapterslanguage"></a>
# **get**
> Chapter get (string videoId, string language)

Retrieve a chapter

Retrieve a chapter for a video in a specific language.  Chapters help your viewers find the sections of the video they are most interested in viewing. Tutorials that use the [chapters endpoint](https://api.video/blog/endpoints/chapters).

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

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | The unique identifier for the video you want to show a chapter for.
            var language = en;  // string | A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation.
            var apiChaptersInstance = apiInstance.Chapters();
            try
            {
                // Show a chapter
                Chapter result = apiChaptersInstance.get(videoId, language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChaptersApi.get: " + e.Message );
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
 **videoId** | **string**| The unique identifier for the video you want to show a chapter for. | 
 **language** | **string**| A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation. | 

### Return type

[**Chapter**](Chapter.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideosvideoidchapterslanguage"></a>
# **delete**
> void delete (string videoId, string language)

Delete a chapter

Delete a chapter in a specific language by providing the video ID for the video you want to delete the chapter from and the language the chapter is in.

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

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | The unique identifier for the video you want to delete a chapter from.
            var language = en;  // string | A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation.
            var apiChaptersInstance = apiInstance.Chapters();
            try
            {
                // Delete a chapter
                apiChaptersInstance.delete(videoId, language);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChaptersApi.delete: " + e.Message );
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
 **videoId** | **string**| The unique identifier for the video you want to delete a chapter from. | 
 **language** | **string**| A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation. | 

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

<a name="getvideosvideoidchapters"></a>
# **list**
> ChaptersListResponse list (string videoId, int? currentPage = null, int? pageSize = null)

List video chapters

Retrieve a list of all chapters for a specified video.

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

            var videoId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | The unique identifier for the video you want to show a chapter for.
            var language = en;  // string | A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation.
            var apiChaptersInstance = apiInstance.Chapters();
            try
            {
                // Show a chapter
                Chapter result = apiChaptersInstance.get(videoId, language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChaptersApi.get: " + e.Message );
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
 **videoId** | **string**| The unique identifier for the video you want to retrieve a list of chapters for. | 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**ChaptersListResponse**](ChaptersListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

