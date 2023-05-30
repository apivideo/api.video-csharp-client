# ApiVideo.Api.AdvancedAuthenticationApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**authenticate**](AdvancedAuthenticationApi.md#postauthapikey) | **POST** /auth/api-key | Get Bearer Token
[**refresh**](AdvancedAuthenticationApi.md#postauthrefresh) | **POST** /auth/refresh | Refresh Bearer Token


<a name="postauthapikey"></a>
# **authenticate**
> AccessToken authenticate (AuthenticatePayload authenticatePayload)

Get Bearer Token

Returns a bearer token that can be used to authenticate other endpoint.  You can find the tutorial on using the disposable bearer token [here](https://docs.api.video/reference/disposable-bearer-token-authentication).

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class authenticateExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var authenticatePayload = new AuthenticatePayload(); // AuthenticatePayload | 
            var apiAdvancedAuthenticationInstance = apiInstance.AdvancedAuthentication();
            try
            {
                // Get Bearer Token
                AccessToken result = apiAdvancedAuthenticationInstance.authenticate(authenticatePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdvancedAuthenticationApi.authenticate: " + e.Message );
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
 **authenticatePayload** | [**AuthenticatePayload**](AuthenticatePayload.md)|  | 

### Return type

[**AccessToken**](AccessToken.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthrefresh"></a>
# **refresh**
> AccessToken refresh (RefreshTokenPayload refreshTokenPayload)

Refresh Bearer Token

Accepts the old bearer token and returns a new bearer token that can be used to authenticate other endpoint.  You can find the tutorial on using the disposable bearer token [here](https://docs.api.video/reference/disposable-bearer-token-authentication).

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class refreshExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var refreshTokenPayload = new RefreshTokenPayload(); // RefreshTokenPayload | 
            var apiAdvancedAuthenticationInstance = apiInstance.AdvancedAuthentication();
            try
            {
                // Refresh Bearer Token
                AccessToken result = apiAdvancedAuthenticationInstance.refresh(refreshTokenPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdvancedAuthenticationApi.refresh: " + e.Message );
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
 **refreshTokenPayload** | [**RefreshTokenPayload**](RefreshTokenPayload.md)|  | 

### Return type

[**AccessToken**](AccessToken.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

