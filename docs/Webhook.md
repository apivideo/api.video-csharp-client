# ApiVideo.Model.Webhook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookId** | **string** | A unique identifier of the webhook you subscribed to. | [optional] 
**CreatedAt** | **DateTime** | The time and date when you created this webhook subscription, in ATOM UTC format. | [optional] 
**Events** | **List&lt;string&gt;** | A list of events that you subscribed to. When these events occur, the API triggers a webhook call to the URL you provided. | [optional] 
**Url** | **string** | The URL where the API sends the webhook. | [optional] 
**SignatureSecret** | **string** | A secret key for the webhook you subscribed to. You can use it to verify the origin of the webhook call that you receive. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

