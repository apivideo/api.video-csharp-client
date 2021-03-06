# ApiVideo.Api.UploadTokensApi

All URIs are relative to *https://ws.api.video*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createToken**](UploadTokensApi.md#postuploadtokens) | **POST** /upload-tokens | Generate an upload token
[**getToken**](UploadTokensApi.md#getuploadtokensuploadtoken) | **GET** /upload-tokens/{uploadToken} | Retrieve upload token
[**deleteToken**](UploadTokensApi.md#deleteuploadtokensuploadtoken) | **DELETE** /upload-tokens/{uploadToken} | Delete an upload token
[**list**](UploadTokensApi.md#getuploadtokens) | **GET** /upload-tokens | List all active upload tokens.


<a name="postuploadtokens"></a>
# **createToken**
> UploadToken createToken (TokenCreationPayload tokenCreationPayload)

Generate an upload token

Use this endpoint to generate an upload token. You can use this token to authenticate video uploads while keeping your API key safe. Tutorials using [delegated upload](https://api.video/blog/endpoints/delegated-upload).

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class createTokenExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var tokenCreationPayload = new TokenCreationPayload(); // TokenCreationPayload | 
            var apiUploadTokensInstance = apiInstance.UploadTokens();
            try
            {
                // Generate an upload token
                UploadToken result = apiUploadTokensInstance.createToken(tokenCreationPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UploadTokensApi.createToken: " + e.Message );
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
 **tokenCreationPayload** | [**TokenCreationPayload**](TokenCreationPayload.md)|  | 

### Return type

[**UploadToken**](UploadToken.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuploadtokensuploadtoken"></a>
# **getToken**
> UploadToken getToken (string uploadToken)

Retrieve upload token

You can retrieve details about a specific upload token if you have the unique identifier for the upload token. Add it in the path of the endpoint. Details include time-to-live (ttl), when the token was created, and when it will expire.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class getTokenExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var uploadToken = to1tcmSFHeYY5KzyhOqVKMKb;  // string | The unique identifier for the token you want information about.
            var apiUploadTokensInstance = apiInstance.UploadTokens();
            try
            {
                // Show upload token
                UploadToken result = apiUploadTokensInstance.getToken(uploadToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UploadTokensApi.getToken: " + e.Message );
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
 **uploadToken** | **string**| The unique identifier for the token you want information about. | 

### Return type

[**UploadToken**](UploadToken.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuploadtokensuploadtoken"></a>
# **deleteToken**
> void deleteToken (string uploadToken)

Delete an upload token

Delete an existing upload token. This is especially useful for tokens you may have created that do not expire.

### Example
```csharp
using System.Diagnostics;
using ApiVideo.Client;

namespace Example
{
    public class deleteTokenExample
    {
        public static void Main()
        {
            var basePath = ApiVideoClient.Client.Environment.SANDBOX;
            var apiKey = "YOUR_API_KEY";

            var apiInstance = new ApiVideoClient(apiKey,basePath);

            var uploadToken = to1tcmSFHeYY5KzyhOqVKMKb;  // string | The unique identifier for the upload token you want to delete. Deleting a token will make it so the token can no longer be used for authentication.
            var apiUploadTokensInstance = apiInstance.UploadTokens();
            try
            {
                // Delete an upload token
                apiUploadTokensInstance.deleteToken(uploadToken);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UploadTokensApi.deleteToken: " + e.Message );
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
 **uploadToken** | **string**| The unique identifier for the upload token you want to delete. Deleting a token will make it so the token can no longer be used for authentication. | 

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

<a name="getuploadtokens"></a>
# **list**
> TokenListResponse list (string sortBy = null, string sortOrder = null, int? currentPage = null, int? pageSize = null)

List all active upload tokens.

A delegated token is used to allow secure uploads without exposing your API key. Use this endpoint to retrieve a list of all currently active delegated tokens. Tutorials using [delegated upload](https://api.video/blog/endpoints/delegated-upload).

### Example
```csharp
import video.api.client.ApiVideoClient;
import video.api.client.api.ApiException;
import video.api.client.api.models.*;
import video.api.client.api.clients.UploadTokensApi;
import java.util.*;

public class Example {
  public static void main(String[] args) {
    ApiVideoClient client = new ApiVideoClient("YOUR_API_KEY");
    // if you rather like to use the sandbox environment:
    // ApiVideoClient client = new ApiVideoClient("YOUR_SANDBOX_API_KEY", ApiVideoClient.Environment.SANDBOX);

    UploadTokensApi apiInstance = client.uploadTokens();
    
    String uploadToken = "to1tcmSFHeYY5KzyhOqVKMKb"; // The unique identifier for the token you want information about.

    try {
      UploadToken result = apiInstance.getToken(uploadToken);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling UploadTokensApi#getToken");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getMessage());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sortBy** | **string**| Allowed: createdAt, ttl. You can use these to sort by when a token was created, or how much longer the token will be active (ttl - time to live). Date and time is presented in ISO-8601 format. | [optional] 
 **sortOrder** | **string**| Allowed: asc, desc. Ascending is 0-9 or A-Z. Descending is 9-0 or Z-A. | [optional] 
 **currentPage** | **int?**| Choose the number of search results to return per page. Minimum value: 1 | [optional] [default to 1]
 **pageSize** | **int?**| Results per page. Allowed values 1-100, default is 25. | [optional] [default to 25]

### Return type

[**TokenListResponse**](TokenListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

