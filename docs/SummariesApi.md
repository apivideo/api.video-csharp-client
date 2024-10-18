# ApiVideo.Api.SummariesApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**create**](SummariesApi.md#postsummaries) | **POST** /summaries | Generate video summary
[**get**](SummariesApi.md#getsummariessummaryidsource) | **GET** /summaries/{summaryId}/source | Get summary details
[**update**](SummariesApi.md#patchsummariessummaryidsource) | **PATCH** /summaries/{summaryId}/source | Update summary details
[**delete**](SummariesApi.md#deletesummariessummaryid) | **DELETE** /summaries/{summaryId} | Delete video summary
[**list**](SummariesApi.md#getsummaries) | **GET** /summaries | List summaries


<a name="postsummaries"></a>
# **create**
> SummaryObject create (InlineObject inlineObject)

Generate video summary

Generate a title, abstract, and key takeaways for a video.

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

            var inlineObject = new InlineObject(); // InlineObject | 
            var apiSummariesInstance = apiInstance.Summaries();
            try
            {
                // Generate video summary
                SummaryObject result = apiSummariesInstance.create(inlineObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummariesApi.create: " + e.Message );
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
 **inlineObject** | [**InlineObject**](InlineObject.md)|  | 

### Return type

[**SummaryObject**](SummaryObject.md)

### HTTP request headers

 - **Content-Type**: applictaion/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **409** | Conflict |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsummariessummaryidsource"></a>
# **get**
> SummarySource get (string summaryId)

Get summary details

Get all details for a summary.

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

            var summaryId = summary_1CGHWuXjhxmeH4WiZ51234;  // string | The unique identifier of the summary source you want to retrieve.
            var apiSummariesInstance = apiInstance.Summaries();
            try
            {
                // Get summary details
                SummarySource result = apiSummariesInstance.get(summaryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummariesApi.get: " + e.Message );
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
 **summaryId** | **string**| The unique identifier of the summary source you want to retrieve. | 

### Return type

[**SummarySource**](SummarySource.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **404** | Not Found |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchsummariessummaryidsource"></a>
# **update**
> SummarySource update (string summaryId, UpdateSummaryRequest updateSummaryRequest)

Update summary details

Update details for a summary. Note that this operation is only allowed for summary objects where `sourceStatus` is `missing`.

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

            var summaryId = summary_1CGHWuXjhxmeH4WiZ51234;  // string | The unique identifier of the summary source you want to update.
            var updateSummaryRequest = new UpdateSummaryRequest(); // UpdateSummaryRequest | 
            var apiSummariesInstance = apiInstance.Summaries();
            try
            {
                // Update summary details
                SummarySource result = apiSummariesInstance.update(summaryId, updateSummaryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummariesApi.update: " + e.Message );
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
 **summaryId** | **string**| The unique identifier of the summary source you want to update. | 
 **updateSummaryRequest** | [**UpdateSummaryRequest**](UpdateSummaryRequest.md)|  | 

### Return type

[**SummarySource**](SummarySource.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **409** | Conflict |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesummariessummaryid"></a>
# **delete**
> void delete (string summaryId)

Delete video summary

Delete a summary tied to a video.

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

            var summaryId = summary_1CGHWuXjhxmeH4WiZ51234;  // string | The unique identifier of the summary you want to delete.
            var apiSummariesInstance = apiInstance.Summaries();
            try
            {
                // Delete video summary
                apiSummariesInstance.delete(summaryId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummariesApi.delete: " + e.Message );
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
 **summaryId** | **string**| The unique identifier of the summary you want to delete. | 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsummaries"></a>
# **list**
> GetSummaries list ()

List summaries

List all summarries for your videos in a project.

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

            var apiSummariesInstance = apiInstance.Summaries();
            try
            {
                // List summaries
                GetSummaries result = apiSummariesInstance.list();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummariesApi.list: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetSummaries**](GetSummaries.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

