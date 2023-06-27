# ApiVideo.Api.AnalyticsApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getLiveStreamsPlays**](AnalyticsApi.md#getanalyticslivestreamsplays) | **GET** /analytics/live-streams/plays | Get play events for live stream
[**getVideosPlays**](AnalyticsApi.md#getanalyticsvideosplays) | **GET** /analytics/videos/plays | Get play events for video


<a name="getanalyticslivestreamsplays"></a>
# **getLiveStreamsPlays**
> AnalyticsPlaysResponse getLiveStreamsPlays (DateTime from, string dimension, DateTime? to = null, string filter = null, int? currentPage = null, int? pageSize = null)

Get play events for live stream

Retrieve filtered analytics about the number of plays for your live streams in a project.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class getLiveStreamsPlaysExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var from = 2023-06-01;  // DateTime | Use this query parameter to set the start date for the time period that you want analytics for. - The API returns analytics data including the day you set in `from`. - The date you set must be **within the last 30 days**. - The value you provide must follow the `YYYY-MM-DD` format. 
            var dimension = browser;  // string | Use this query parameter to define the dimension that you want analytics for. - `liveStreamId`: Returns analytics based on the public live stream identifiers. - `emittedAt`: Returns analytics based on the times of the play events. The API returns data in specific interval groups. When the date period you set in `from` and `to` is less than or equals to 2 days, the response for this dimension is grouped in hourly intervals. Otherwise, it is grouped in daily intervals. - `country`: Returns analytics based on the viewers' country. The list of supported country names are based on the [GeoNames public database](https://www.geonames.org/countries/). - `deviceType`: Returns analytics based on the type of device used by the viewers during the play event. - `operatingSystem`: Returns analytics based on the operating system used by the viewers during the play event. - `browser`: Returns analytics based on the browser used by the viewers during the play event.
            var to = 2023-06-10;  // DateTime? | Use this optional query parameter to set the end date for the time period that you want analytics for. - If you do not specify a `to` date, the API returns analytics data starting from the `from` date up until today, and excluding today. - The date you set must be **within the last 30 days**. - The value you provide must follow the `YYYY-MM-DD` format.  (optional) 
            var filter = liveStreamId:li3q7HxhApxRF1c8F8r6VeaI;  // string | Use this query parameter to filter your results to a specific live stream in a project that you want analytics for. You must use the `liveStreamId:` prefix when specifying a live stream ID. (optional) 
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiAnalyticsInstance = apiInstance.Analytics();
            try
            {
                // Get play events for live stream
                AnalyticsPlaysResponse result = apiAnalyticsInstance.getLiveStreamsPlays(from, dimension, to, filter, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.getLiveStreamsPlays: " + e.Message );
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
 **from** | **DateTime**| Use this query parameter to set the start date for the time period that you want analytics for. - The API returns analytics data including the day you set in &#x60;from&#x60;. - The date you set must be **within the last 30 days**. - The value you provide must follow the &#x60;YYYY-MM-DD&#x60; format.  | 
 **dimension** | **string**| Use this query parameter to define the dimension that you want analytics for. - &#x60;liveStreamId&#x60;: Returns analytics based on the public live stream identifiers. - &#x60;emittedAt&#x60;: Returns analytics based on the times of the play events. The API returns data in specific interval groups. When the date period you set in &#x60;from&#x60; and &#x60;to&#x60; is less than or equals to 2 days, the response for this dimension is grouped in hourly intervals. Otherwise, it is grouped in daily intervals. - &#x60;country&#x60;: Returns analytics based on the viewers&#39; country. The list of supported country names are based on the [GeoNames public database](https://www.geonames.org/countries/). - &#x60;deviceType&#x60;: Returns analytics based on the type of device used by the viewers during the play event. - &#x60;operatingSystem&#x60;: Returns analytics based on the operating system used by the viewers during the play event. - &#x60;browser&#x60;: Returns analytics based on the browser used by the viewers during the play event. | 
 **to** | **DateTime?**| Use this optional query parameter to set the end date for the time period that you want analytics for. - If you do not specify a &#x60;to&#x60; date, the API returns analytics data starting from the &#x60;from&#x60; date up until today, and excluding today. - The date you set must be **within the last 30 days**. - The value you provide must follow the &#x60;YYYY-MM-DD&#x60; format.  | [optional] 
 **filter** | **string**| Use this query parameter to filter your results to a specific live stream in a project that you want analytics for. You must use the &#x60;liveStreamId:&#x60; prefix when specifying a live stream ID. | [optional] 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**AnalyticsPlaysResponse**](AnalyticsPlaysResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request error |  -  |
| **403** | Forbidden - Disabled Analytics |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getanalyticsvideosplays"></a>
# **getVideosPlays**
> AnalyticsPlaysResponse getVideosPlays (DateTime from, string dimension, DateTime? to = null, string filter = null, int? currentPage = null, int? pageSize = null)

Get play events for video

Retrieve filtered analytics about the number of plays for your videos in a project.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class getVideosPlaysExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var from = 2023-06-01;  // DateTime | Use this query parameter to set the start date for the time period that you want analytics for. - The API returns analytics data including the day you set in `from`. - The date you set must be **within the last 30 days**. - The value you provide must follow the `YYYY-MM-DD` format. 
            var dimension = browser;  // string | Use this query parameter to define the dimension that you want analytics for. - `videoId`: Returns analytics based on the public video identifiers. - `emittedAt`: Returns analytics based on the times of the play events. The API returns data in specific interval groups. When the date period you set in `from` and `to` is less than or equals to 2 days, the response for this dimension is grouped in hourly intervals. Otherwise, it is grouped in daily intervals. - `country`: Returns analytics based on the viewers' country. The list of supported country names are based on the [GeoNames public database](https://www.geonames.org/countries/). - `deviceType`: Returns analytics based on the type of device used by the viewers during the play event. - `operatingSystem`: Returns analytics based on the operating system used by the viewers during the play event. - `browser`: Returns analytics based on the browser used by the viewers during the play event.
            var to = 2023-06-10;  // DateTime? | Use this optional query parameter to set the end date for the time period that you want analytics for. - If you do not specify a `to` date, the API returns analytics data starting from the `from` date up until today, and excluding today. - The date you set must be **within the last 30 days**. - The value you provide must follow the `YYYY-MM-DD` format.  (optional) 
            var filter = videoId:vi3q7HxhApxRF1c8F8r6VeaI;  // string | Use this query parameter to filter your results to a specific video in a project that you want analytics for. You must use the `videoId:` prefix when specifying a video ID. (optional) 
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiAnalyticsInstance = apiInstance.Analytics();
            try
            {
                // Get play events for video
                AnalyticsPlaysResponse result = apiAnalyticsInstance.getVideosPlays(from, dimension, to, filter, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.getVideosPlays: " + e.Message );
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
 **from** | **DateTime**| Use this query parameter to set the start date for the time period that you want analytics for. - The API returns analytics data including the day you set in &#x60;from&#x60;. - The date you set must be **within the last 30 days**. - The value you provide must follow the &#x60;YYYY-MM-DD&#x60; format.  | 
 **dimension** | **string**| Use this query parameter to define the dimension that you want analytics for. - &#x60;videoId&#x60;: Returns analytics based on the public video identifiers. - &#x60;emittedAt&#x60;: Returns analytics based on the times of the play events. The API returns data in specific interval groups. When the date period you set in &#x60;from&#x60; and &#x60;to&#x60; is less than or equals to 2 days, the response for this dimension is grouped in hourly intervals. Otherwise, it is grouped in daily intervals. - &#x60;country&#x60;: Returns analytics based on the viewers&#39; country. The list of supported country names are based on the [GeoNames public database](https://www.geonames.org/countries/). - &#x60;deviceType&#x60;: Returns analytics based on the type of device used by the viewers during the play event. - &#x60;operatingSystem&#x60;: Returns analytics based on the operating system used by the viewers during the play event. - &#x60;browser&#x60;: Returns analytics based on the browser used by the viewers during the play event. | 
 **to** | **DateTime?**| Use this optional query parameter to set the end date for the time period that you want analytics for. - If you do not specify a &#x60;to&#x60; date, the API returns analytics data starting from the &#x60;from&#x60; date up until today, and excluding today. - The date you set must be **within the last 30 days**. - The value you provide must follow the &#x60;YYYY-MM-DD&#x60; format.  | [optional] 
 **filter** | **string**| Use this query parameter to filter your results to a specific video in a project that you want analytics for. You must use the &#x60;videoId:&#x60; prefix when specifying a video ID. | [optional] 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**AnalyticsPlaysResponse**](AnalyticsPlaysResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request error |  -  |
| **403** | Forbidden - Disabled Analytics |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

