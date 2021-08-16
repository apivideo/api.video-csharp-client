# ApiVideo.Api.PlayerThemesApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete**](PlayerThemesApi.md#deleteplayersplayerid) | **DELETE** /players/{playerId} | Delete a player
[**deleteLogo**](PlayerThemesApi.md#deleteplayersplayeridlogo) | **DELETE** /players/{playerId}/logo | Delete logo
[**list**](PlayerThemesApi.md#getplayers) | **GET** /players | List all players
[**get**](PlayerThemesApi.md#getplayersplayerid) | **GET** /players/{playerId} | Show a player
[**update**](PlayerThemesApi.md#patchplayersplayerid) | **PATCH** /players/{playerId} | Update a player
[**create**](PlayerThemesApi.md#postplayers) | **POST** /players | Create a player
[**uploadLogo**](PlayerThemesApi.md#postplayersplayeridlogo) | **POST** /players/{playerId}/logo | Upload a logo


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

<a name="deleteplayersplayeridlogo"></a>
# **deleteLogo**
> void deleteLogo (string playerId)

Delete logo

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

<a name="getplayers"></a>
# **list**
> PlayerThemesListResponse list (string sortBy = null, string sortOrder = null, int? currentPage = null, int? pageSize = null)

List all players

Retrieve a list of all the players you created, as well as details about each one. Tutorials that use the [player endpoint](https://api.video/blog/endpoints/player).

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

            var sortBy = createdAt;  // string | createdAt is the time the player was created. updatedAt is the time the player was last updated. The time is presented in ISO-8601 format. (optional) 
            var sortOrder = asc;  // string | Allowed: asc, desc. Ascending for date and time means that earlier values precede later ones. Descending means that later values preced earlier ones. (optional) 
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiPlayerThemesInstance = apiInstance.PlayerThemes();
            try
            {
                // List all players
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
 **sortBy** | **string**| createdAt is the time the player was created. updatedAt is the time the player was last updated. The time is presented in ISO-8601 format. | [optional] 
 **sortOrder** | **string**| Allowed: asc, desc. Ascending for date and time means that earlier values precede later ones. Descending means that later values preced earlier ones. | [optional] 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**PlayerThemesListResponse**](PlayerThemesListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayersplayerid"></a>
# **get**
> PlayerTheme get (string playerId)

Show a player

Use a player ID to retrieve details about the player and display it for viewers.

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
                // Show a player
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

<a name="patchplayersplayerid"></a>
# **update**
> PlayerTheme update (string playerId, PlayerThemeUpdatePayload playerThemeUpdatePayload)

Update a player

Use a player ID to update specific details for a player. NOTE: It may take up to 10 min before the new player configuration is available from our CDN.

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

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postplayersplayeridlogo"></a>
# **uploadLogo**
> PlayerTheme uploadLogo (string playerId, System.IO.Stream file, string link = null)

Upload a logo

The uploaded image maximum size should be 200x100 and its weight should be 200KB. It will be scaled down to 30px height and converted to PNG to be displayed in the player.

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

### Authorization

[bearerAuth](../README.md#bearerAuth)

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

