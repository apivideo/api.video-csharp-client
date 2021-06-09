# ApiVideo.Api.RawStatisticsApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**listLiveStreamSessions**](RawStatisticsApi.md#getanalyticslivestreamslivestreamid) | **GET** /analytics/live-streams/{liveStreamId} | List live stream player sessions
[**listSessionEvents**](RawStatisticsApi.md#getanalyticssessionssessionidevents) | **GET** /analytics/sessions/{sessionId}/events | List player session events
[**listVideoSessions**](RawStatisticsApi.md#getanalyticsvideosvideoid) | **GET** /analytics/videos/{videoId} | List video player sessions


<a name="getanalyticslivestreamslivestreamid"></a>
# **listLiveStreamSessions**
> RawStatisticsListLiveStreamAnalyticsResponse listLiveStreamSessions (string liveStreamId, string period = null, int? currentPage = null, int? pageSize = null)

List live stream player sessions

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class listLiveStreamSessionsExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var liveStreamId = vi4k0jvEUuaTdRAEjQ4Jfrgz;  // string | The unique identifier for the live stream you want to retrieve analytics for.
            var period = 2019-01-01;  // string | Period must have one of the following formats:  - For a day : \"2018-01-01\", - For a week: \"2018-W01\", - For a month: \"2018-01\" - For a year: \"2018\"  For a range period: -  Date range: \"2018-01-01/2018-01-15\"  (optional) 
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiRawStatisticsInstance = apiInstance.RawStatistics();
            try
            {
                // List live stream player sessions
                RawStatisticsListLiveStreamAnalyticsResponse result = apiRawStatisticsInstance.listLiveStreamSessions(liveStreamId, period, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RawStatisticsApi.listLiveStreamSessions: " + e.Message );
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
 **liveStreamId** | **string**| The unique identifier for the live stream you want to retrieve analytics for. | 
 **period** | **string**| Period must have one of the following formats:  - For a day : \&quot;2018-01-01\&quot;, - For a week: \&quot;2018-W01\&quot;, - For a month: \&quot;2018-01\&quot; - For a year: \&quot;2018\&quot;  For a range period: -  Date range: \&quot;2018-01-01/2018-01-15\&quot;  | [optional] 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**RawStatisticsListLiveStreamAnalyticsResponse**](RawStatisticsListLiveStreamAnalyticsResponse.md)

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

<a name="getanalyticssessionssessionidevents"></a>
# **listSessionEvents**
> RawStatisticsListPlayerSessionEventsResponse listSessionEvents (string sessionId, int? currentPage = null, int? pageSize = null)

List player session events

Useful to track and measure video's engagement.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class listSessionEventsExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var sessionId = psEmFwGQUAXR2lFHj5nDOpy;  // string | A unique identifier you can use to reference and track a session with.
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiRawStatisticsInstance = apiInstance.RawStatistics();
            try
            {
                // List player session events
                RawStatisticsListPlayerSessionEventsResponse result = apiRawStatisticsInstance.listSessionEvents(sessionId, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RawStatisticsApi.listSessionEvents: " + e.Message );
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
 **sessionId** | **string**| A unique identifier you can use to reference and track a session with. | 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**RawStatisticsListPlayerSessionEventsResponse**](RawStatisticsListPlayerSessionEventsResponse.md)

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

<a name="getanalyticsvideosvideoid"></a>
# **listVideoSessions**
> RawStatisticsListSessionsResponse listVideoSessions (string videoId, string period = null, Dictionary<string, string> metadata = null, int? currentPage = null, int? pageSize = null)

List video player sessions

Retrieve all available user sessions for a specific video.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class listVideoSessionsExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var videoId = vi4k0jvEUuaTdRAEjQ4Prklg;  // string | The unique identifier for the video you want to retrieve session information for.
            var period = period_example;  // string | Period must have one of the following formats:  - For a day : 2018-01-01, - For a week: 2018-W01, - For a month: 2018-01 - For a year: 2018  For a range period: -  Date range: 2018-01-01/2018-01-15  (optional) 
            var metadata = new Dictionary<string, string>(); // Dictionary<string, string> | Metadata and Dynamic Metadata filter. Send an array of key value pairs you want to filter sessios with. (optional) 
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiRawStatisticsInstance = apiInstance.RawStatistics();
            try
            {
                // List video player sessions
                RawStatisticsListSessionsResponse result = apiRawStatisticsInstance.listVideoSessions(videoId, period, metadata, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RawStatisticsApi.listVideoSessions: " + e.Message );
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
 **videoId** | **string**| The unique identifier for the video you want to retrieve session information for. | 
 **period** | **string**| Period must have one of the following formats:  - For a day : 2018-01-01, - For a week: 2018-W01, - For a month: 2018-01 - For a year: 2018  For a range period: -  Date range: 2018-01-01/2018-01-15  | [optional] 
 **metadata** | [**Dictionary&lt;string, string&gt;**](string.md)| Metadata and Dynamic Metadata filter. Send an array of key value pairs you want to filter sessios with. | [optional] 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**RawStatisticsListSessionsResponse**](RawStatisticsListSessionsResponse.md)

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

