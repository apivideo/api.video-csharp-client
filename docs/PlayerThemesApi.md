# ApiVideo.Api.PlayerThemesApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**create**](PlayerThemesApi.md#postplayers) | **POST** /players | Create a player
[**get**](PlayerThemesApi.md#getplayersplayerid) | **GET** /players/{playerId} | Retrieve a player
[**update**](PlayerThemesApi.md#patchplayersplayerid) | **PATCH** /players/{playerId} | Update a player
[**delete**](PlayerThemesApi.md#deleteplayersplayerid) | **DELETE** /players/{playerId} | Delete a player
[**list**](PlayerThemesApi.md#getplayers) | **GET** /players | List all player themes
[**uploadLogo**](PlayerThemesApi.md#postplayersplayeridlogo) | **POST** /players/{playerId}/logo | Upload a logo
[**deleteLogo**](PlayerThemesApi.md#deleteplayersplayeridlogo) | **DELETE** /players/{playerId}/logo | Delete logo


<a name="postplayers"></a>
# **create**
> PlayerTheme create (PlayerThemeCreationPayload playerThemeCreationPayload)

Create a player

Create a player for your video, and customise it.

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

            var playerThemeCreationPayload = new PlayerThemeCreationPayload(); // PlayerThemeCreationPayload | 
            var apiPlayerThemesInstance = apiInstance.PlayerThemes();
            try
            {
                // Create a player
                PlayerTheme result = apiPlayerThemesInstance.create(playerThemeCreationPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerThemesApi.create: " + e.Message );
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
 **playerThemeCreationPayload** | [**PlayerThemeCreationPayload**](PlayerThemeCreationPayload.md)|  | 

### Return type

[**PlayerTheme**](PlayerTheme.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **429** | Too Many Requests |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayersplayerid"></a>
# **get**
> PlayerTheme get (string playerId)

Retrieve a player

Retreive a player theme by player id.

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

            var playerId = pl45d5vFFGrfdsdsd156dGhh;  // string | The unique identifier for the player you want to retrieve. 
            var apiPlayerThemesInstance = apiInstance.PlayerThemes();
            try
            {
                // Retrieve a player
                PlayerTheme result = apiPlayerThemesInstance.get(playerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerThemesApi.get: " + e.Message );
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
 **playerId** | **string**| The unique identifier for the player you want to retrieve.  | 

### Return type

[**PlayerTheme**](PlayerTheme.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **404** | Not Found |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **429** | Too Many Requests |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchplayersplayerid"></a>
# **update**
> PlayerTheme update (string playerId, PlayerThemeUpdatePayload playerThemeUpdatePayload)

Update a player

Use a player ID to update specific details for a player.  NOTE: It may take up to 10 min before the new player configuration is available from our CDN.

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

            var playerId = pl45d5vFFGrfdsdsd156dGhh;  // string | The unique identifier for the player.
            var playerThemeUpdatePayload = new PlayerThemeUpdatePayload(); // PlayerThemeUpdatePayload | 
            var apiPlayerThemesInstance = apiInstance.PlayerThemes();
            try
            {
                // Update a player
                PlayerTheme result = apiPlayerThemesInstance.update(playerId, playerThemeUpdatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerThemesApi.update: " + e.Message );
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
 **playerId** | **string**| The unique identifier for the player. | 
 **playerThemeUpdatePayload** | [**PlayerThemeUpdatePayload**](PlayerThemeUpdatePayload.md)|  | 

### Return type

[**PlayerTheme**](PlayerTheme.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **404** | Not Found |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **429** | Too Many Requests |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteplayersplayerid"></a>
# **delete**
> void delete (string playerId)

Delete a player

Delete a player if you no longer need it. You can delete any player that you have the player ID for.

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

            var playerId = pl45d5vFFGrfdsdsd156dGhh;  // string | The unique identifier for the player you want to delete.
            var apiPlayerThemesInstance = apiInstance.PlayerThemes();
            try
            {
                // Delete a player
                apiPlayerThemesInstance.delete(playerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerThemesApi.delete: " + e.Message );
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
 **playerId** | **string**| The unique identifier for the player you want to delete. | 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **404** | Not Found |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **429** | Too Many Requests |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayers"></a>
# **list**
> PlayerThemesListResponse list (string sortBy = null, string sortOrder = null, int? currentPage = null, int? pageSize = null)

List all player themes

Retrieve a list of all the player themes you created, as well as details about each one.

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

            var sortBy = createdAt;  // string | createdAt is the time the player was created. updatedAt is the time the player was last updated. The time is presented in ATOM UTC format. (optional) 
            var sortOrder = asc;  // string | Allowed: asc, desc. Ascending for date and time means that earlier values precede later ones. Descending means that later values preced earlier ones. (optional) 
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiPlayerThemesInstance = apiInstance.PlayerThemes();
            try
            {
                // List all player themes
                PlayerThemesListResponse result = apiPlayerThemesInstance.list(sortBy, sortOrder, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerThemesApi.list: " + e.Message );
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
 **sortBy** | **string**| createdAt is the time the player was created. updatedAt is the time the player was last updated. The time is presented in ATOM UTC format. | [optional] 
 **sortOrder** | **string**| Allowed: asc, desc. Ascending for date and time means that earlier values precede later ones. Descending means that later values preced earlier ones. | [optional] 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**PlayerThemesListResponse**](PlayerThemesListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **400** | Bad Request |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **429** | Too Many Requests |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postplayersplayeridlogo"></a>
# **uploadLogo**
> PlayerTheme uploadLogo (string playerId, System.IO.Stream file, string link = null)

Upload a logo

Upload an image file as a logo for your player. The image should fit within these constraints: - The image mime type must be `image/jpeg` or `image/png`. api.video recommends using `png` images with transparent background. - The image size should be a maximum of 200px width x 100px. - The file size should be a maximum of 100 KiB. 

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class uploadLogoExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var playerId = pl14Db6oMJRH6SRVoOwORacK;  // string | The unique identifier for the player.
            var file = BINARY_DATA_HERE;  // System.IO.Stream | The name of the file you want to use for your logo.
            var link = link_example;  // string | A public link that you want to advertise in your player. For example, you could add a link to your company. When a viewer clicks on your logo, they will be taken to this address. (optional) 
            var apiPlayerThemesInstance = apiInstance.PlayerThemes();
            try
            {
                // Upload a logo
                PlayerTheme result = apiPlayerThemesInstance.uploadLogo(playerId, file, link);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerThemesApi.uploadLogo: " + e.Message );
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
 **playerId** | **string**| The unique identifier for the player. | 
 **file** | **System.IO.Stream****System.IO.Stream**| The name of the file you want to use for your logo. | 
 **link** | **string**| A public link that you want to advertise in your player. For example, you could add a link to your company. When a viewer clicks on your logo, they will be taken to this address. | [optional] 

### Return type

[**PlayerTheme**](PlayerTheme.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **400** | Bad Request |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **404** | Not Found |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **429** | Too Many Requests |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteplayersplayeridlogo"></a>
# **deleteLogo**
> void deleteLogo (string playerId)

Delete logo

Delete the logo associated to a player.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class deleteLogoExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var playerId = pl14Db6oMJRH6SRVoOwORacK;  // string | The unique identifier for the player.
            var apiPlayerThemesInstance = apiInstance.PlayerThemes();
            try
            {
                // Delete logo
                apiPlayerThemesInstance.deleteLogo(playerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerThemesApi.deleteLogo: " + e.Message );
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
 **playerId** | **string**| The unique identifier for the player. | 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **404** | Not Found |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |
| **429** | Too Many Requests |  * X-RateLimit-Limit - The request limit per minute. <br>  * X-RateLimit-Remaining - The number of available requests left for the current time window. <br>  * X-RateLimit-Retry-After - The number of seconds left until the current rate limit window resets. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

