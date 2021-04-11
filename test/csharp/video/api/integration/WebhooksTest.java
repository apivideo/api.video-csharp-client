package video.api.integration;

import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.EnabledIfEnvironmentVariable;
import video.api.client.ApiVideoClient;
import video.api.client.api.ApiException;
import video.api.client.api.models.Metadata;
import video.api.client.api.models.Page;
import video.api.client.api.models.Webhook;
import video.api.client.api.models.WebhooksCreatePayload;

import java.util.Collections;

import static org.assertj.core.api.Assertions.assertThat;

@DisplayName("Integration tests of api.webhooks() methods")
@TestInstance(TestInstance.Lifecycle.PER_CLASS)
@TestMethodOrder(MethodOrderer.OrderAnnotation.class)
@EnabledIfEnvironmentVariable(named = "INTEGRATION_TESTS_API_TOKEN", matches = ".+")
public class WebhooksTest {

    private ApiVideoClient apiClient;
    private Webhook webhook;

    public WebhooksTest() {
        this.apiClient = new ApiVideoClient(System.getenv().get("INTEGRATION_TESTS_API_TOKEN"));
        apiClient.getHttpClient().setBasePath("https://ws-staging.api.video");
    }

    @Test
    @Order(1)
    @DisplayName("create a webhook")
    public void createWebhook() throws ApiException {
        this.webhook = apiClient.webhooks()
                .create(new WebhooksCreatePayload().url("https://webhooks.test-java-api-client"));
        System.out.println(webhook);
        assertThat(webhook.getWebhookId()).isNotNull();
    }

    @Test
    @Order(2)
    @DisplayName("create a webhook")
    public void listWebhooks() throws ApiException {
        Page<Webhook> list = apiClient.webhooks().list().execute();

        Collections.<Metadata> emptySet();
        // TODO
    }

    @AfterAll
    public void deleteWebhook() throws ApiException {
        apiClient.webhooks().delete(this.webhook.getWebhookId());
    }

}
