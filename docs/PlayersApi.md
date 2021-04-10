# VideoApiClient.Api.PlayersApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete**](PlayersApi.md#deleteplayersplayerid) | **DELETE** /players/{playerId} | Delete a player
[**deleteLogo**](PlayersApi.md#deleteplayersplayeridlogo) | **DELETE** /players/{playerId}/logo | Delete logo
[**list**](PlayersApi.md#getplayers) | **GET** /players | List all players
[**get**](PlayersApi.md#getplayersplayerid) | **GET** /players/{playerId} | Show a player
[**update**](PlayersApi.md#patchplayersplayerid) | **PATCH** /players/{playerId} | Update a player
[**create**](PlayersApi.md#postplayers) | **POST** /players | Create a player
[**uploadLogo**](PlayersApi.md#postplayersplayeridlogo) | **POST** /players/{playerId}/logo | Upload a logo


<a name="deleteplayersplayerid"></a>
# **delete**
> void delete (string playerId)

Delete a player

Delete a player if you no longer need it. You can delete any player that you have the player ID for.

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

            var playerId = pl45d5vFFGrfdsdsd156dGhh;  // string | The unique identifier for the player you want to delete.
            var apiPlayersInstance = apiInstance.Players();
            try
            {
                // Delete a player
                apiPlayersInstance.delete(playerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayersApi.delete: " + e.Message );
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
> Object deleteLogo (string playerId)

Delete logo

### Example
```csharp
using System.Diagnostics;
using VideoApiClient.Client;

namespace Example
{
    public class deleteLogoExample
    {
        public static void Main()
        {
            var basePath = VideoApiClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var playerId = pl14Db6oMJRH6SRVoOwORacK;  // string | The unique identifier for the player.
            var apiPlayersInstance = apiInstance.Players();
            try
            {
                // Delete logo
                Object result = apiPlayersInstance.deleteLogo(playerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayersApi.deleteLogo: " + e.Message );
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

**Object**

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
> PlayersListResponse list (string sortBy = null, string sortOrder = null, int? currentPage = null, int? pageSize = null)

List all players

Retrieve a list of all the players you created, as well as details about each one.

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

            var sortBy = createdAt;  // string | createdAt is the time the player was created. updatedAt is the time the player was last updated. The time is presented in ISO-8601 format. (optional) 
            var sortOrder = asc;  // string | Allowed: asc, desc. Ascending for date and time means that earlier values precede later ones. Descending means that later values preced earlier ones. (optional) 
            var currentPage = 2;  // int? | Choose the number of search results to return per page. Minimum value: 1 (optional)  (default to 1)
            var pageSize = 30;  // int? | Results per page. Allowed values 1-100, default is 25. (optional)  (default to 25)
            var apiPlayersInstance = apiInstance.Players();
            try
            {
                // List all players
                PlayersListResponse result = apiPlayersInstance.list(sortBy, sortOrder, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayersApi.list: " + e.Message );
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

[**PlayersListResponse**](PlayersListResponse.md)

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
> Player get (string playerId)

Show a player

Use a player ID to retrieve details about the player and display it for viewers.

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

            var playerId = pl45d5vFFGrfdsdsd156dGhh;  // string | The unique identifier for the player you want to retrieve. 
            var apiPlayersInstance = apiInstance.Players();
            try
            {
                // Show a player
                Player result = apiPlayersInstance.get(playerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayersApi.get: " + e.Message );
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

[**Player**](Player.md)

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
> Player update (string playerId, PlayerUpdatePayload playerUpdatePayload)

Update a player

Use a player ID to update specific details for a player. NOTE: It may take up to 10 min before the new player configuration is available from our CDN.

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

            var playerId = pl45d5vFFGrfdsdsd156dGhh;  // string | The unique identifier for the player.
            var playerUpdatePayload = new PlayerUpdatePayload(); // PlayerUpdatePayload | 
            var apiPlayersInstance = apiInstance.Players();
            try
            {
                // Update a player
                Player result = apiPlayersInstance.update(playerId, playerUpdatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayersApi.update: " + e.Message );
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
 **playerUpdatePayload** | [**PlayerUpdatePayload**](PlayerUpdatePayload.md)|  | 

### Return type

[**Player**](Player.md)

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
> Player create (PlayerCreationPayload playerCreationPayload)

Create a player

Create a player for your video, and customise it.

### Example
```csharp
using System.Diagnostics;
using VideoApiClient.Client;

namespace Example
{
    public class createExample
    {
        public static void Main()
        {
            var basePath = VideoApiClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var playerCreationPayload = new PlayerCreationPayload(); // PlayerCreationPayload | 
            var apiPlayersInstance = apiInstance.Players();
            try
            {
                // Create a player
                Player result = apiPlayersInstance.create(playerCreationPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayersApi.create: " + e.Message );
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
 **playerCreationPayload** | [**PlayerCreationPayload**](PlayerCreationPayload.md)|  | 

### Return type

[**Player**](Player.md)

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
> Player uploadLogo (string playerId, System.IO.Stream file, string link)

Upload a logo

The uploaded image maximum size should be 200x100 and its weight should be 200KB.  It will be scaled down to 30px height and converted to PNG to be displayed in the player.

### Example
```csharp
using System.Diagnostics;
using VideoApiClient.Client;

namespace Example
{
    public class uploadLogoExample
    {
        public static void Main()
        {
            var basePath = VideoApiClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var playerId = pl14Db6oMJRH6SRVoOwORacK;  // string | The unique identifier for the player.
            var file = BINARY_DATA_HERE;  // System.IO.Stream | The name of the file you want to use for your logo.
            var link = link_example;  // string | The path to the file you want to upload and use as a logo.
            var apiPlayersInstance = apiInstance.Players();
            try
            {
                // Upload a logo
                Player result = apiPlayersInstance.uploadLogo(playerId, file, link);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayersApi.uploadLogo: " + e.Message );
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
 **link** | **string**| The path to the file you want to upload and use as a logo. | 

### Return type

[**Player**](Player.md)

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

