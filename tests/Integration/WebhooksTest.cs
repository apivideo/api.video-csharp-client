using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoApiClient.Client;
using VideoApiClient.Model;

namespace VideoApiTests.Integration
{
    [TestClass]
    public class WebhooksTest
    {
        private ApiVideoClient apiClient;
        private Webhook webhook;

        [TestInitialize]
        public void init()
        {
            apiClient = new ApiVideoClient("r4qMAdUQBC7duPALUzEZtjKfQ0AlBqLfyCkgffLuNFH");
            apiClient.GetHttpClient().BasePath = "https://ws-staging.api.video";

        }

        [TestMethod]
        public void createAndListWebhook()
        {
            webhook = apiClient.Webhooks()
                    .create(new WebhooksCreatePayload() { url = "https://webhooks.test-java-api-client" });
            Console.WriteLine(webhook);

            Page<Webhook> list = apiClient.Webhooks().list().execute();

            //TODO
            this.apiClient.Webhooks().delete(this.webhook.webhookid);
        }


    }
}
