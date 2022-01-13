using ApiVideo.Api;
using RestSharp;

namespace ApiVideo.Client
{
    /// <summary>
    /// Class that allows you to call all the api routes
    /// </summary>
    public class ApiVideoClient {
        private readonly ApiClient apiClient;
        private readonly CaptionsApi captions;
        private readonly ChaptersApi chapters;
        private readonly LiveStreamsApi liveStreams;
        private readonly PlayerThemesApi playerThemes;
        private readonly RawStatisticsApi rawStatistics;
        private readonly UploadTokensApi uploadTokens;
        private readonly VideosApi videos;
        private readonly WatermarksApi watermarks;
        private readonly WebhooksApi webhooks;

        /// <summary>
        /// Build an instance that targets production environment without authentication
        /// </summary>
        public ApiVideoClient() : this(Environment.PRODUCTION) {
        }

        /// <summary>
        ///  Build an instance that targets the given environment without authentication
        /// </summary>
        /// <param name="environment">the target environment</param>
        public ApiVideoClient(Environment environment) : this(new ApiClient(environment.GetUrl())) {
        }

        /// <summary>
        /// Build an instance that targets the production environment with authentication
        /// </summary>
        /// <param name="apiKey">the api key to use to authenticate</param>
        public ApiVideoClient(string apiKey) : this(apiKey, Environment.PRODUCTION) { 
        }

        /// <summary>
        /// Build an instance that targets the given environment with authentication
        /// </summary>
        /// <param name="apiKey">the api key to use to authenticate</param>
        /// <param name="environment">environment the target environment</param>
        public ApiVideoClient(string apiKey, Environment environment) : this(new ApiClient(apiKey, environment.GetUrl())) { 
        }

        /// <summary>
        /// Build an instance that targets the given environment with authentication
        /// </summary>
        /// <param name="apiKey">the api key to use to authenticate</param>
        /// <param name="host">host the target host</param>
        public ApiVideoClient(string apiKey, string host) : this(new ApiClient(apiKey, host)) {
        }

        /// <summary>
        /// Build an instance that targets the production environment using a custom OkHttp client
        /// </summary>
        /// <param name="client">the RestClient instance to use</param>
        public ApiVideoClient(RestClient client) : this(new ApiClient(client))
        { 
        }

        private ApiVideoClient(ApiClient apiClient) {
            this.apiClient = apiClient;
            this.captions = new CaptionsApi(this.apiClient);
            this.chapters = new ChaptersApi(this.apiClient);
            this.liveStreams = new LiveStreamsApi(this.apiClient);
            this.playerThemes = new PlayerThemesApi(this.apiClient);
            this.rawStatistics = new RawStatisticsApi(this.apiClient);
            this.uploadTokens = new UploadTokensApi(this.apiClient);
            this.videos = new VideosApi(this.apiClient);
            this.watermarks = new WatermarksApi(this.apiClient);
            this.webhooks = new WebhooksApi(this.apiClient);
        }

    
        /// <summary>
        /// Get an CaptionsApi instance
        /// </summary>
        /// <returns>CaptionsApi</returns>
        public CaptionsApi Captions() {
            return this.captions;
        }
    
        /// <summary>
        /// Get an ChaptersApi instance
        /// </summary>
        /// <returns>ChaptersApi</returns>
        public ChaptersApi Chapters() {
            return this.chapters;
        }
    
        /// <summary>
        /// Get an LiveStreamsApi instance
        /// </summary>
        /// <returns>LiveStreamsApi</returns>
        public LiveStreamsApi LiveStreams() {
            return this.liveStreams;
        }
    
        /// <summary>
        /// Get an PlayerThemesApi instance
        /// </summary>
        /// <returns>PlayerThemesApi</returns>
        public PlayerThemesApi PlayerThemes() {
            return this.playerThemes;
        }
    
        /// <summary>
        /// Get an RawStatisticsApi instance
        /// </summary>
        /// <returns>RawStatisticsApi</returns>
        public RawStatisticsApi RawStatistics() {
            return this.rawStatistics;
        }
    
        /// <summary>
        /// Get an UploadTokensApi instance
        /// </summary>
        /// <returns>UploadTokensApi</returns>
        public UploadTokensApi UploadTokens() {
            return this.uploadTokens;
        }
    
        /// <summary>
        /// Get an VideosApi instance
        /// </summary>
        /// <returns>VideosApi</returns>
        public VideosApi Videos() {
            return this.videos;
        }
    
        /// <summary>
        /// Get an WatermarksApi instance
        /// </summary>
        /// <returns>WatermarksApi</returns>
        public WatermarksApi Watermarks() {
            return this.watermarks;
        }
    
        /// <summary>
        /// Get an WebhooksApi instance
        /// </summary>
        /// <returns>WebhooksApi</returns>
        public WebhooksApi Webhooks() {
            return this.webhooks;
        }
    

        /// <summary>
        /// Gets the http client
        /// </summary>
        /// <returns>Current Api http client</returns>
        public ApiClient GetHttpClient() {
            return this.apiClient;
        }

        /// <summary>
        /// Gets the upload chunk size
        /// </summary>
        /// <returns>The upload chunk size</returns>
        public int GetUploadChunkSize() {
            return this.apiClient.UploadChunkSize;
        }

        /// <summary>
        /// Updates the upload chunk size
        /// </summary>
        /// <param name="uploadChunkSize">the new chunk size</param>
        public void SetUploadChunkSize(int uploadChunkSize) {
            this.apiClient.UploadChunkSize = uploadChunkSize;
        }
        
        /// <summary>
        /// Gets the rest client timeout
        /// </summary>
        /// <returns>The rest client timeout</returns>
        public int GetTimeout()
        {
            return this.apiClient.RestClient.Timeout;
        }

        /// <summary>
        /// Updates the rest client timeout
        /// </summary>
        /// <param name="newTimeOut">the new timeout</param>
        public void SetTimeout(int newTimeOut)
        {
            this.apiClient.RestClient.Timeout = newTimeOut;
        }
    }

    /// <summary>
    /// Provides Stream helpers methods
    /// </summary>
    public static class ApiVideoExtensions
    {
        /// <summary>
        /// Returns the api URL of a given environment
        /// </summary>
        /// <param name="env">The environment to target</param>
        /// <returns>The environment url</returns>
        public static string GetUrl(this Environment env)
        {
            switch (env)
            {
                case Environment.PRODUCTION:
                    return "https://ws.api.video";
                case Environment.SANDBOX:
                    return "https://sandbox.api.video";
                default:
                    return "";
            }
        }
    }
    /// <summary>
    /// Environment to target
    /// </summary>
    public enum Environment
    {
        /// <summary>
        /// Production environment
        /// </summary>
        PRODUCTION,
        /// <summary>
        /// Sandbox environment
        /// </summary>
        SANDBOX
    }
}
