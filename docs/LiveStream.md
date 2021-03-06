# ApiVideo.Model.LiveStream

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LiveStreamId** | **string** | The unique identifier for the live stream. Live stream IDs begin with \&quot;li.\&quot; | 
**Name** | **string** | The name of your live stream. | [optional] 
**StreamKey** | **string** | The unique, private stream key that you use to begin streaming. | [optional] 
**Record** | **bool** | Whether you are recording or not. | [optional] 
**Public** | **bool** | BETA FEATURE Please limit all public &#x3D; false (\&quot;private\&quot;) livestreams to 3,000 users. Whether your video can be viewed by everyone, or requires authentication to see it. A setting of false will require a unique token for each view. | [optional] 
**Assets** | [**LiveStreamAssets**](LiveStreamAssets.md) |  | [optional] 
**PlayerId** | **string** | The unique identifier for the player. | [optional] 
**Broadcasting** | **bool** | Whether or not you are broadcasting the live video you recorded for others to see. True means you are broadcasting to viewers, false means you are not. | [optional] 
**CreatedAt** | **DateTime** | When the player was created, presented in ISO-8601 format. | [optional] 
**UpdatedAt** | **DateTime** | When the player was last updated, presented in ISO-8601 format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

