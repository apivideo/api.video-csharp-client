# ApiVideo.Api.SummariesApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**create**](SummariesApi.md#postsummaries) | **POST** /summaries | Generate video summary
[**update**](SummariesApi.md#patchsummariessummaryidsource) | **PATCH** /summaries/{summaryId}/source | Update summary details
[**delete**](SummariesApi.md#deletesummariessummaryid) | **DELETE** /summaries/{summaryId} | Delete video summary
[**list**](SummariesApi.md#getsummaries) | **GET** /summaries | List summaries
[**getSummarySource**](SummariesApi.md#getsummariessummaryidsource) | **GET** /summaries/{summaryId}/source | Get summary details


<a name="postsummaries"></a>
# **create**
> Summary create (SummaryCreationPayload summaryCreationPayload)

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

            var summaryCreationPayload = new SummaryCreationPayload(); // SummaryCreationPayload | 
            var apiSummariesInstance = apiInstance.Summaries();
            try
            {
                // Generate video summary
                Summary result = apiSummariesInstance.create(summaryCreationPayload);
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
 **summaryCreationPayload** | [**SummaryCreationPayload**](SummaryCreationPayload.md)|  | 

### Return type

[**Summary**](Summary.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **409** | Conflict |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchsummariessummaryidsource"></a>
# **update**
> SummarySource update (string summaryId, SummaryUpdatePayload summaryUpdatePayload)

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
            var summaryUpdatePayload = new SummaryUpdatePayload(); // SummaryUpdatePayload | 
            var apiSummariesInstance = apiInstance.Summaries();
            try
            {
                // Update summary details
                SummarySource result = apiSummariesInstance.update(summaryId, summaryUpdatePayload);
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
 **summaryUpdatePayload** | [**SummaryUpdatePayload**](SummaryUpdatePayload.md)|  | 

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
> SummariesListResponse list (string videoId = null, string origin = null, string sourceStatus = null, string sortBy = null, string sortOrder = null, int? currentPage = null, int? pageSize = null)

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

            var videoId = vilkR8K3N7yrRcxcMt91234;  // string | Use this parameter to filter for a summary that belongs to a specific video. (optional) 
            var origin = auto;  // string | Use this parameter to filter for summaries based on the way they were created: automatically or manually via the API. (optional) 
            var sourceStatus = auto;  // string | Use this parameter to filter for summaries based on the current status of the summary source.  These are the available statuses:  `missing`: the input for a summary is not present. `waiting` : the input video is being processed and a summary will be generated. `failed`: a technical issue prevented summary generation. `completed`: the summary is generated. `unprocessable`: the API rules the source video to be unsuitable for summary generation. An example for this is an input video that has no audio.  (optional) 
            var sortBy = createdAt;  // string | Use this parameter to choose which field the API will use to sort the response data. The default is `value`.  These are the available fields to sort by:  - `createdAt`: Sorts the results based on date and timestamps when summaries were created. - `updatedAt`: Sorts the results based on date and timestamps when summaries were last updated. - `videoId`: Sorts the results based on video IDs.  (optional) 
            var sortOrder = asc;  // string | Use this parameter to sort results. `asc` is ascending and sorts from A to Z. `desc` is descending and sorts from Z to A. (optional) 
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiSummariesInstance = apiInstance.Summaries();
            try
            {
                // List summaries
                SummariesListResponse result = apiSummariesInstance.list(videoId, origin, sourceStatus, sortBy, sortOrder, currentPage, pageSize);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **string**| Use this parameter to filter for a summary that belongs to a specific video. | [optional] 
 **origin** | **string**| Use this parameter to filter for summaries based on the way they were created: automatically or manually via the API. | [optional] 
 **sourceStatus** | **string**| Use this parameter to filter for summaries based on the current status of the summary source.  These are the available statuses:  &#x60;missing&#x60;: the input for a summary is not present. &#x60;waiting&#x60; : the input video is being processed and a summary will be generated. &#x60;failed&#x60;: a technical issue prevented summary generation. &#x60;completed&#x60;: the summary is generated. &#x60;unprocessable&#x60;: the API rules the source video to be unsuitable for summary generation. An example for this is an input video that has no audio.  | [optional] 
 **sortBy** | **string**| Use this parameter to choose which field the API will use to sort the response data. The default is &#x60;value&#x60;.  These are the available fields to sort by:  - &#x60;createdAt&#x60;: Sorts the results based on date and timestamps when summaries were created. - &#x60;updatedAt&#x60;: Sorts the results based on date and timestamps when summaries were last updated. - &#x60;videoId&#x60;: Sorts the results based on video IDs.  | [optional] 
 **sortOrder** | **string**| Use this parameter to sort results. &#x60;asc&#x60; is ascending and sorts from A to Z. &#x60;desc&#x60; is descending and sorts from Z to A. | [optional] 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**SummariesListResponse**](SummariesListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsummariessummaryidsource"></a>
# **getSummarySource**
> SummarySource getSummarySource (string summaryId)

Get summary details

Get all details for a summary.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class getSummarySourceExample
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
                SummarySource result = apiSummariesInstance.getSummarySource(summaryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummariesApi.getSummarySource: " + e.Message );
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

