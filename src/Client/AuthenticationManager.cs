using ApiVideo.Api;
using ApiVideo.Model;
using RestSharp;
using System;
namespace ApiVideo.Client
{
    /// <summary>
    /// Handle the client authentication methods
    /// </summary>
    public class AuthenticationManager {

        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Gets or sets the api key.
        /// </summary>
        /// <value>The base path</value>
        private string ApiKey { get; set; }
        private string CachedAccessToken { get; set; }
        private long? TokenExpirationMs { get; set; }
        private readonly AdvancedAuthenticationApi authentication;


        /// <summary>
        /// Build an instance of authentication manager
        /// </summary>
        /// <param name="apiKey">the api key that will allow us to get the access token</param>
        /// <param name="apiClient">instance of the apiClient</param>
        public AuthenticationManager(string apiKey, ApiClient apiClient) {
            this.authentication = new AdvancedAuthenticationApi(apiClient);
            this.ApiKey = apiKey;

        }
        /// <summary>
        /// Adds the authorization token to a request
        /// </summary>
        /// <param name="request">The request to update</param>
        /// <returns>The request updated</returns>
        public RestRequest Intercept(RestRequest request){

            if(request.Resource.Equals("/auth/api-key")) {
                return request;
            }
            return request.AddHeader("authorization", "Bearer " + this.GetAccessToken());
            
        }

        private string GetAccessToken() {
            if(!this.IsTokenValid()) {
                this.RetrieveAccessToken();
            }
            return this.CachedAccessToken;
        }

        private void RetrieveAccessToken() {
            AccessToken accessToken = this.authentication.authenticate(new AuthenticatePayload() { apikey = this.ApiKey });

            int expires = accessToken.expiresin;
            this.TokenExpirationMs = this.CurrentTimeMillis() + (expires - 60) * 1000;
            this.CachedAccessToken = accessToken.accesstoken;

        }

        private bool IsTokenValid() {
            return TokenExpirationMs.HasValue && TokenExpirationMs.Value > this.CurrentTimeMillis();
        }
        private long CurrentTimeMillis()
        {
            return (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }

    }
}
