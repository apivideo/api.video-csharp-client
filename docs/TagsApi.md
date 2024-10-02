# ApiVideo.Api.TagsApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**list**](TagsApi.md#listtags) | **GET** /tags | List all video tags


<a name="listtags"></a>
# **list**
> ListTagsResponse list (string value = null, string sortBy = null, string sortOrder = null, int? currentPage = null, int? pageSize = null)

List all video tags

This endpoint enables you to search for video tags in a project and see how many videos are tagged with them. If you do not define any query parameters, the endpoint lists all video tags and the numbers of times they are used in a project.

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

            var value = value_example;  // string | Use this parameter to search for specific video tags. The API filters results even on partial values, and ignores accents, uppercase, and lowercase.  (optional) 
            var sortBy = value;  // string | Use this parameter to choose which field the API will use to sort the response data. The default is `value`.  These are the available fields to sort by:  - `value`: Sorts the results based on tag values in alphabetic order. - `videoCount`: Sorts the results based on the number of times a video tag is used.  (optional) 
            var sortOrder = asc;  // string | Use this parameter to sort results. `asc` is ascending and sorts from A to Z. `desc` is descending and sorts from Z to A. (optional) 
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiTagsInstance = apiInstance.Tags();
            try
            {
                // List all video tags
                ListTagsResponse result = apiTagsInstance.list(value, sortBy, sortOrder, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.list: " + e.Message );
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
 **value** | **string**| Use this parameter to search for specific video tags. The API filters results even on partial values, and ignores accents, uppercase, and lowercase.  | [optional] 
 **sortBy** | **string**| Use this parameter to choose which field the API will use to sort the response data. The default is &#x60;value&#x60;.  These are the available fields to sort by:  - &#x60;value&#x60;: Sorts the results based on tag values in alphabetic order. - &#x60;videoCount&#x60;: Sorts the results based on the number of times a video tag is used.  | [optional] 
 **sortOrder** | **string**| Use this parameter to sort results. &#x60;asc&#x60; is ascending and sorts from A to Z. &#x60;desc&#x60; is descending and sorts from Z to A. | [optional] 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**ListTagsResponse**](ListTagsResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **429** | Too Many Requests |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

