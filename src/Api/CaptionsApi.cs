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
    public class CaptionsApi
    {
        /// <summary>
        /// Api Client Instance
        /// </summary>
        public ApiClient ApiClient {get; set;}

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CaptionsApi(ApiClient apiClient)
        {
            this.ApiClient = apiClient;
        }

        /// <summary>
        /// Delete a caption Delete a caption in a specific language by providing the video ID for the video you want to delete the caption from and the language the caption is in.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The unique identifier for the video you want to delete a caption from.</param>
/// <param name="language">A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation.</param>
        
        /// <returns></returns>
		public void delete(string videoId, string language)
        {
             deleteWithHttpInfo(videoId, language);
        }

        /// <summary>
        /// Delete a caption Delete a caption in a specific language by providing the video ID for the video you want to delete the caption from and the language the caption is in.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The unique identifier for the video you want to delete a caption from.</param>
/// <param name="language">A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation.</param>
        
        /// <returns>ApiResponse of Object(void)</returns>
		public ApiResponse<Object> deleteWithHttpInfo(string videoId, string language)
        {


            // verify the required parameter 'videoId' is set
            if (videoId == null)
                throw new ApiException(400, "Missing required parameter 'videoId' when calling CaptionsApi->delete");
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling CaptionsApi->delete");
            

            var localVarPath = "/videos/{videoId}/captions/{language}";
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

            if (videoId != null) localVarPathParams.Add("videoId", this.ApiClient.ParameterToString(videoId)); // path parameter
            if (language != null) localVarPathParams.Add("language", this.ApiClient.ParameterToString(language)); // path parameter


            

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
        /// List video captions Retrieve a list of available captions for the videoId you provide.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The unique identifier for the video you want to retrieve a list of captions for.</param>
/// <param name="currentPage">Choose the number of search results to return per page. Minimum value: 1 (optional, default to 1)</param>
/// <param name="pageSize">Results per page. Allowed values 1-100, default is 25. (optional, default to 25)</param>
        
        /// <returns>CaptionsListResponse</returns>
		public CaptionsListResponse list(string videoId, int? currentPage = default, int? pageSize = default)
        {
             ApiResponse<CaptionsListResponse> localVarResponse = listWithHttpInfo(videoId, currentPage, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List video captions Retrieve a list of available captions for the videoId you provide.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The unique identifier for the video you want to retrieve a list of captions for.</param>
/// <param name="currentPage">Choose the number of search results to return per page. Minimum value: 1 (optional, default to 1)</param>
/// <param name="pageSize">Results per page. Allowed values 1-100, default is 25. (optional, default to 25)</param>
        
        /// <returns>ApiResponse of CaptionsListResponse</returns>
		public ApiResponse<CaptionsListResponse> listWithHttpInfo(string videoId, int? currentPage = default, int? pageSize = default)
        {



            // verify the required parameter 'videoId' is set
            if (videoId == null)
                throw new ApiException(400, "Missing required parameter 'videoId' when calling CaptionsApi->list");
            

            var localVarPath = "/videos/{videoId}/captions";
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

            if (videoId != null) localVarPathParams.Add("videoId", this.ApiClient.ParameterToString(videoId)); // path parameter
            if (currentPage != null) localVarQueryParams.AddRange(this.ApiClient.ParameterToKeyValuePairs("", "currentPage", currentPage)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(this.ApiClient.ParameterToKeyValuePairs("", "pageSize", pageSize)); // query parameter


            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
            return new ApiResponse<CaptionsListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaptionsListResponse) this.ApiClient.Deserialize(localVarResponse, typeof(CaptionsListResponse)));
            
        }

        
        /// <summary>
        /// Retrieve a list of available captions for the videoId you provide.
        /// </summary>
        /// <param name="videoId">The unique identifier for the video you want to retrieve a list of captions for. (required)</param>
        /// <returns>APIlistRequest</returns>
        public APIlistRequest list(string videoId) {
            return new APIlistRequest(this,videoId);
        }

        /// <summary>
        /// Request list class to get paginated list of items
        /// </summary>
        public class APIlistRequest {
            private string videoId;
            private int? currentPage;
            private int? pageSize;

            private CaptionsApi currentApiInstance;

            /// <summary>
            /// Class constructor with api instance
            /// </summary>
            /// <param name="instance">Instance of the current api</param>
            /// <param name="videoId">The unique identifier for the video you want to retrieve a list of captions for. (required)</param>
            public APIlistRequest(CaptionsApi instance, string videoId) {
                this.videoId = videoId;
                this.currentApiInstance = instance;
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
            /// <returns>CaptionsListResponse </returns>
            public Page<Subtitle> execute(){
                ApiResponse<CaptionsListResponse> localVarResp = this.currentApiInstance.listWithHttpInfo(videoId, currentPage, pageSize);
                return new Page<Subtitle>(localVarResp.Data.data, localVarResp.Data.pagination, () => {
                    try {
                        return copy().CurrentPage((currentPage == null ? 1 : currentPage) + 1).execute();
                    } catch (ApiException e) {
                        throw new Exception(e.Message);
                    }
                }); 
            }

            private APIlistRequest copy() {
                APIlistRequest copy = new APIlistRequest( this.currentApiInstance, videoId);
                copy.CurrentPage(currentPage);
                copy.PageSize(pageSize);
                return copy;
            }
        }
        /// <summary>
        /// Show a caption Display a caption for a video in a specific language. If the language is available, the caption is returned. Otherwise, you will get a response indicating the caption was not found.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The unique identifier for the video you want captions for.</param>
/// <param name="language">A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation</param>
        
        /// <returns>Subtitle</returns>
		public Subtitle get(string videoId, string language)
        {
             ApiResponse<Subtitle> localVarResponse = getWithHttpInfo(videoId, language);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show a caption Display a caption for a video in a specific language. If the language is available, the caption is returned. Otherwise, you will get a response indicating the caption was not found.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The unique identifier for the video you want captions for.</param>
/// <param name="language">A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation</param>
        
        /// <returns>ApiResponse of Subtitle</returns>
		public ApiResponse<Subtitle> getWithHttpInfo(string videoId, string language)
        {


            // verify the required parameter 'videoId' is set
            if (videoId == null)
                throw new ApiException(400, "Missing required parameter 'videoId' when calling CaptionsApi->get");
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling CaptionsApi->get");
            

            var localVarPath = "/videos/{videoId}/captions/{language}";
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

            if (videoId != null) localVarPathParams.Add("videoId", this.ApiClient.ParameterToString(videoId)); // path parameter
            if (language != null) localVarPathParams.Add("language", this.ApiClient.ParameterToString(language)); // path parameter


            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
            return new ApiResponse<Subtitle>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Subtitle) this.ApiClient.Deserialize(localVarResponse, typeof(Subtitle)));
            
        }

        
        /// <summary>
        /// Update caption To have the captions on automatically, use this PATCH to set default: true.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The unique identifier for the video you want to have automatic captions for. </param>
/// <param name="language">A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation.</param>
/// <param name="captionsUpdatePayload"> (optional)</param>
        
        /// <returns>Subtitle</returns>
		public Subtitle update(string videoId, string language, CaptionsUpdatePayload captionsUpdatePayload = default)
        {
             ApiResponse<Subtitle> localVarResponse = updateWithHttpInfo(videoId, language, captionsUpdatePayload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update caption To have the captions on automatically, use this PATCH to set default: true.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The unique identifier for the video you want to have automatic captions for. </param>
/// <param name="language">A valid [BCP 47](https://github.com/libyal/libfwnt/wiki/Language-Code-identifiers) language representation.</param>
/// <param name="captionsUpdatePayload"> (optional)</param>
        
        /// <returns>ApiResponse of Subtitle</returns>
		public ApiResponse<Subtitle> updateWithHttpInfo(string videoId, string language, CaptionsUpdatePayload captionsUpdatePayload = default)
        {
            if (captionsUpdatePayload == null) 
                throw new ApiException(400,"Missing required parameter 'captionsUpdatePayload' when calling CaptionsApi->update");
            
            
            if (captionsUpdatePayload == null) 
                throw new ApiException(400,"Missing required parameter 'captionsUpdatePayload' when calling CaptionsApi->update");
            
            
            if (captionsUpdatePayload == null) 
                throw new ApiException(400,"Missing required parameter 'captionsUpdatePayload' when calling CaptionsApi->update");
            
            
            // verify the required parameter 'videoId' is set
            if (videoId == null)
                throw new ApiException(400, "Missing required parameter 'videoId' when calling CaptionsApi->update");
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling CaptionsApi->update");
            

            var localVarPath = "/videos/{videoId}/captions/{language}";
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

            if (videoId != null) localVarPathParams.Add("videoId", this.ApiClient.ParameterToString(videoId)); // path parameter
            if (language != null) localVarPathParams.Add("language", this.ApiClient.ParameterToString(language)); // path parameter
            if (captionsUpdatePayload != null && captionsUpdatePayload.GetType() != typeof(byte[]) && captionsUpdatePayload.GetType() != typeof(string))
            {
                localVarPostBody = this.ApiClient.Serialize(captionsUpdatePayload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = captionsUpdatePayload; // byte array
            }


            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
            return new ApiResponse<Subtitle>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Subtitle) this.ApiClient.Deserialize(localVarResponse, typeof(Subtitle)));
            
        }

        
        /// <summary>
        /// Upload a caption Upload a VTT file to add captions to your video.  Read our [captioning tutorial](https://api.video/blog/tutorials/adding-captions) for more details.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The unique identifier for the video you want to add a caption to.</param>
/// <param name="language">A valid BCP 47 language representation.</param>
/// <param name="file">The video text track (VTT) you want to upload.</param>
        
        /// <returns>Subtitle</returns>
		public Subtitle upload(string videoId, string language, System.IO.Stream file)
        {
             ApiResponse<Subtitle> localVarResponse = uploadWithHttpInfo(videoId, language, file);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a caption Upload a VTT file to add captions to your video.  Read our [captioning tutorial](https://api.video/blog/tutorials/adding-captions) for more details.
        /// </summary>
        /// <exception cref="VideoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The unique identifier for the video you want to add a caption to.</param>
/// <param name="language">A valid BCP 47 language representation.</param>
/// <param name="file">The video text track (VTT) you want to upload.</param>
        
        /// <returns>ApiResponse of Subtitle</returns>
		public ApiResponse<Subtitle> uploadWithHttpInfo(string videoId, string language, System.IO.Stream file)
        {



            // verify the required parameter 'videoId' is set
            if (videoId == null)
                throw new ApiException(400, "Missing required parameter 'videoId' when calling CaptionsApi->upload");
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling CaptionsApi->upload");
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling CaptionsApi->upload");
            

            var localVarPath = "/videos/{videoId}/captions/{language}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>();
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarContentTypes = new string[] {
                "multipart/form-data"
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

            if (videoId != null) localVarPathParams.Add("videoId", this.ApiClient.ParameterToString(videoId)); // path parameter
            if (language != null) localVarPathParams.Add("language", this.ApiClient.ParameterToString(language)); // path parameter
            


            
            if (file != null) 
                localVarFileParams.Add("file", this.ApiClient.ParameterToFile("file", file));


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
            return new ApiResponse<Subtitle>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Subtitle) this.ApiClient.Deserialize(localVarResponse, typeof(Subtitle)));
            
        }

        

    }

}