/* 
 * api.video
 *
 * api.video is an API that encodes on the go to facilitate immediate playback, enhancing viewer streaming experiences across multiple devices and platforms. You can stream live or on-demand online videos within minutes.
 *
 * The version of the OpenAPI document: 1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.IO;
using VideoApiClient.Upload;
using RestSharp;
using VideoApiClient.Client;
using VideoApiClient.Model;

namespace VideoApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UploadTokensApi
    {
        /// <summary>
        /// Api Client Instance
        /// </summary>
        public ApiClient ApiClient {get; set;}

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadTokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UploadTokensApi(ApiClient apiClient)
        {
            this.ApiClient = apiClient;
        }

        /// <summary>
        /// Delete an upload token Delete an existing upload token. This is especially useful for tokens you may have created that do not expire.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadToken">The unique identifier for the upload token you want to delete. Deleting a token will make it so the token can no longer be used for authentication.</param>
        
        /// <returns></returns>
		public void deleteToken(string uploadToken)
        {
             deleteTokenWithHttpInfo(uploadToken);
        }

        /// <summary>
        /// Delete an upload token Delete an existing upload token. This is especially useful for tokens you may have created that do not expire.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadToken">The unique identifier for the upload token you want to delete. Deleting a token will make it so the token can no longer be used for authentication.</param>
        
        /// <returns>ApiResponse of Object(void)</returns>
		public ApiResponse<Object> deleteTokenWithHttpInfo(string uploadToken)
        {

            // verify the required parameter 'uploadToken' is set
            if (uploadToken == null)
                throw new ApiException(400, "Missing required parameter 'uploadToken' when calling UploadTokensApi->deleteToken");
            

            var localVarPath = "/upload-tokens/{uploadToken}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>();
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarContentTypes = new string[] {
            };
            string localVarContentType = ApiClient.SelectHeaderContentType(localVarContentTypes);
            localVarHeaderParams.Add("Content-Type", localVarContentType);
            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (uploadToken != null) localVarPathParams.Add("uploadToken", this.ApiClient.ParameterToString(uploadToken)); // path parameter


            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
            
        }

        
        /// <summary>
        /// List all active upload tokens. A delegated token is used to allow secure uploads without exposing your API key. Use this endpoint to retrieve a list of all currently active delegated tokens.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Allowed: createdAt, ttl. You can use these to sort by when a token was created, or how much longer the token will be active (ttl - time to live). Date and time is presented in ISO-8601 format. (optional)</param>
/// <param name="sortOrder">Allowed: asc, desc. Ascending is 0-9 or A-Z. Descending is 9-0 or Z-A. (optional)</param>
/// <param name="currentPage">Choose the number of search results to return per page. Minimum value: 1 (optional, default to 1)</param>
/// <param name="pageSize">Results per page. Allowed values 1-100, default is 25. (optional, default to 25)</param>
        
        /// <returns>TokenListResponse</returns>
		public TokenListResponse list(string sortBy = default, string sortOrder = default, int? currentPage = default, int? pageSize = default)
        {
             ApiResponse<TokenListResponse> localVarResponse = listWithHttpInfo(sortBy, sortOrder, currentPage, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List all active upload tokens. A delegated token is used to allow secure uploads without exposing your API key. Use this endpoint to retrieve a list of all currently active delegated tokens.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sortBy">Allowed: createdAt, ttl. You can use these to sort by when a token was created, or how much longer the token will be active (ttl - time to live). Date and time is presented in ISO-8601 format. (optional)</param>
/// <param name="sortOrder">Allowed: asc, desc. Ascending is 0-9 or A-Z. Descending is 9-0 or Z-A. (optional)</param>
/// <param name="currentPage">Choose the number of search results to return per page. Minimum value: 1 (optional, default to 1)</param>
/// <param name="pageSize">Results per page. Allowed values 1-100, default is 25. (optional, default to 25)</param>
        
        /// <returns>ApiResponse of TokenListResponse</returns>
		public ApiResponse<TokenListResponse> listWithHttpInfo(string sortBy = default, string sortOrder = default, int? currentPage = default, int? pageSize = default)
        {




            

            var localVarPath = "/upload-tokens";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>();
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarContentTypes = new string[] {
            };
            string localVarContentType = ApiClient.SelectHeaderContentType(localVarContentTypes);
            localVarHeaderParams.Add("Content-Type", localVarContentType);
            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (sortBy != null) localVarQueryParams.AddRange(this.ApiClient.ParameterToKeyValuePairs("", "sortBy", sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.AddRange(this.ApiClient.ParameterToKeyValuePairs("", "sortOrder", sortOrder)); // query parameter
            if (currentPage != null) localVarQueryParams.AddRange(this.ApiClient.ParameterToKeyValuePairs("", "currentPage", currentPage)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(this.ApiClient.ParameterToKeyValuePairs("", "pageSize", pageSize)); // query parameter


            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
            return new ApiResponse<TokenListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TokenListResponse) this.ApiClient.Deserialize(localVarResponse, typeof(TokenListResponse)));
            
        }

        
        /// <summary>
        /// A delegated token is used to allow secure uploads without exposing your API key. Use this endpoint to retrieve a list of all currently active delegated tokens.
        /// </summary>
        /// <returns>APIlistRequest</returns>
        public APIlistRequest list() {
            return new APIlistRequest(this);
        }

        /// <summary>
        /// Request list class to get paginated list of items
        /// </summary>
        public class APIlistRequest {
            private string sortBy;
            private string sortOrder;
            private int? currentPage;
            private int? pageSize;

            private UploadTokensApi currentApiInstance;

            /// <summary>
            /// Class constructor with api instance
            /// </summary>
            /// <param name="instance">Instance of the current api</param>
            public APIlistRequest(UploadTokensApi instance) {
                this.currentApiInstance = instance;
            }

            /// <summary>
            /// Set sortBy
            /// </summary>
            /// <param name="sortBy">Allowed: createdAt, ttl. You can use these to sort by when a token was created, or how much longer the token will be active (ttl - time to live). Date and time is presented in ISO-8601 format. (optional)</param>
            /// <returns>APIlistRequest</returns>
            public APIlistRequest SortBy(string sortBy) {
                this.sortBy = sortBy;
                return this;
            }

            /// <summary>
            /// Set sortOrder
            /// </summary>
            /// <param name="sortOrder">Allowed: asc, desc. Ascending is 0-9 or A-Z. Descending is 9-0 or Z-A. (optional)</param>
            /// <returns>APIlistRequest</returns>
            public APIlistRequest SortOrder(string sortOrder) {
                this.sortOrder = sortOrder;
                return this;
            }

            /// <summary>
            /// Set currentPage
            /// </summary>
            /// <param name="currentPage">Choose the number of search results to return per page. Minimum value: 1 (optional, default to 1)</param>
            /// <returns>APIlistRequest</returns>
            public APIlistRequest CurrentPage(int? currentPage) {
                this.currentPage = currentPage;
                return this;
            }

            /// <summary>
            /// Set pageSize
            /// </summary>
            /// <param name="pageSize">Results per page. Allowed values 1-100, default is 25. (optional, default to 25)</param>
            /// <returns>APIlistRequest</returns>
            public APIlistRequest PageSize(int? pageSize) {
                this.pageSize = pageSize;
                return this;
            }

            

            /// <summary>
            /// Execute list request
            /// </summary>
            /// <returns>TokenListResponse </returns>
            public Page<UploadToken> execute(){
                ApiResponse<TokenListResponse> localVarResp = this.currentApiInstance.listWithHttpInfo(sortBy, sortOrder, currentPage, pageSize);
                return new Page<UploadToken>(localVarResp.Data.data, localVarResp.Data.pagination, () => {
                    try {
                        return copy().CurrentPage((currentPage == null ? 1 : currentPage) + 1).execute();
                    } catch (ApiException e) {
                        throw new Exception(e.Message);
                    }
                }); 
            }

            private APIlistRequest copy() {
                APIlistRequest copy = new APIlistRequest( this.currentApiInstance);
                copy.SortBy(sortBy);
                copy.SortOrder(sortOrder);
                copy.CurrentPage(currentPage);
                copy.PageSize(pageSize);
                return copy;
            }
        }
        /// <summary>
        /// Show upload token You can retrieve details about a specific upload token if you have the unique identifier for the upload token. Add it in the path of the endpoint. Details include time-to-live (ttl), when the token was created, and when it will expire.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadToken">The unique identifier for the token you want information about.</param>
        
        /// <returns>UploadToken</returns>
		public UploadToken getToken(string uploadToken)
        {
             ApiResponse<UploadToken> localVarResponse = getTokenWithHttpInfo(uploadToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show upload token You can retrieve details about a specific upload token if you have the unique identifier for the upload token. Add it in the path of the endpoint. Details include time-to-live (ttl), when the token was created, and when it will expire.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadToken">The unique identifier for the token you want information about.</param>
        
        /// <returns>ApiResponse of UploadToken</returns>
		public ApiResponse<UploadToken> getTokenWithHttpInfo(string uploadToken)
        {

            // verify the required parameter 'uploadToken' is set
            if (uploadToken == null)
                throw new ApiException(400, "Missing required parameter 'uploadToken' when calling UploadTokensApi->getToken");
            

            var localVarPath = "/upload-tokens/{uploadToken}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>();
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarContentTypes = new string[] {
            };
            string localVarContentType = ApiClient.SelectHeaderContentType(localVarContentTypes);
            localVarHeaderParams.Add("Content-Type", localVarContentType);
            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (uploadToken != null) localVarPathParams.Add("uploadToken", this.ApiClient.ParameterToString(uploadToken)); // path parameter


            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
            return new ApiResponse<UploadToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UploadToken) this.ApiClient.Deserialize(localVarResponse, typeof(UploadToken)));
            
        }

        
        /// <summary>
        /// Generate an upload token Use this endpoint to generate an upload token. You can use this token to authenticate video uploads while keeping your API key safe.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenCreatePayload"></param>
        
        /// <returns>UploadToken</returns>
		public UploadToken createToken(TokenCreatePayload tokenCreatePayload)
        {
             ApiResponse<UploadToken> localVarResponse = createTokenWithHttpInfo(tokenCreatePayload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate an upload token Use this endpoint to generate an upload token. You can use this token to authenticate video uploads while keeping your API key safe.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenCreatePayload"></param>
        
        /// <returns>ApiResponse of UploadToken</returns>
		public ApiResponse<UploadToken> createTokenWithHttpInfo(TokenCreatePayload tokenCreatePayload)
        {
            if (tokenCreatePayload == null) 
                throw new ApiException(400,"Missing required parameter 'tokenCreatePayload' when calling UploadTokensApi->createToken");
            
            
            // verify the required parameter 'tokenCreatePayload' is set
            if (tokenCreatePayload == null)
                throw new ApiException(400, "Missing required parameter 'tokenCreatePayload' when calling UploadTokensApi->createToken");
            

            var localVarPath = "/upload-tokens";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>();
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarContentTypes = new string[] {
                "application/json"
            };
            string localVarContentType = ApiClient.SelectHeaderContentType(localVarContentTypes);
            localVarHeaderParams.Add("Content-Type", localVarContentType);
            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tokenCreatePayload != null && tokenCreatePayload.GetType() != typeof(byte[]) && tokenCreatePayload.GetType() != typeof(string))
            {
                localVarPostBody = this.ApiClient.Serialize(tokenCreatePayload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tokenCreatePayload; // byte array
            }


            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
            return new ApiResponse<UploadToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UploadToken) this.ApiClient.Deserialize(localVarResponse, typeof(UploadToken)));
            
        }

        

    }

}