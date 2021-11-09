using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Video {
    /// <summary>
    /// The unique identifier of the video object.
    /// </summary>
    /// <value>The unique identifier of the video object.</value>
    [DataMember(Name="videoId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "videoId")]
    public string videoid { get; set; }
    /// <summary>
    /// When a video was created, presented in ISO-8601 format.
    /// </summary>
    /// <value>When a video was created, presented in ISO-8601 format.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? createdat { get; set; }
    /// <summary>
    /// The title of the video content. 
    /// </summary>
    /// <value>The title of the video content. </value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string title { get; set; }
    /// <summary>
    /// A description for the video content. 
    /// </summary>
    /// <value>A description for the video content. </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string description { get; set; }
    /// <summary>
    /// The date and time the API created the video. Date and time are provided using ISO-8601 UTC format.
    /// </summary>
    /// <value>The date and time the API created the video. Date and time are provided using ISO-8601 UTC format.</value>
    [DataMember(Name="publishedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publishedAt")]
    public string publishedat { get; set; }
    /// <summary>
    /// The date and time the video was updated. Date and time are provided using ISO-8601 UTC format.
    /// </summary>
    /// <value>The date and time the video was updated. Date and time are provided using ISO-8601 UTC format.</value>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public DateTime? updatedat { get; set; }
    /// <summary>
    /// One array of tags (each tag is a string) in order to categorize a video. Tags may include spaces.  
    /// </summary>
    /// <value>One array of tags (each tag is a string) in order to categorize a video. Tags may include spaces.  </value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> tags { get; set; }
    /// <summary>
    /// Metadata you can use to categorise and filter videos. Metadata is a list of dictionaries, where each dictionary represents a key value pair for categorising a video. [Dynamic Metadata](https://api.video/blog/endpoints/dynamic-metadata) allows you to define a key that allows any value pair. 
    /// </summary>
    /// <value>Metadata you can use to categorise and filter videos. Metadata is a list of dictionaries, where each dictionary represents a key value pair for categorising a video. [Dynamic Metadata](https://api.video/blog/endpoints/dynamic-metadata) allows you to define a key that allows any value pair. </value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public List<Metadata> metadata { get; set; }
    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public VideoSource source { get; set; }
    /// <summary>
    /// Gets or Sets Assets
    /// </summary>
    [DataMember(Name="assets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assets")]
    public VideoAssets assets { get; set; }
    /// <summary>
    /// The id of the player that will be applied on the video. 
    /// </summary>
    /// <value>The id of the player that will be applied on the video. </value>
    [DataMember(Name="playerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playerId")]
    public string playerid { get; set; }
    /// <summary>
    /// Defines if the content is publicly reachable or if a unique token is needed for each play session. Default is true. Tutorials on [private videos](https://api.video/blog/endpoints/private-videos). 
    /// </summary>
    /// <value>Defines if the content is publicly reachable or if a unique token is needed for each play session. Default is true. Tutorials on [private videos](https://api.video/blog/endpoints/private-videos). </value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public bool _public { get; set; }
    /// <summary>
    /// Defines if video is panoramic. 
    /// </summary>
    /// <value>Defines if video is panoramic. </value>
    [DataMember(Name="panoramic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "panoramic")]
    public bool panoramic { get; set; }
    /// <summary>
    /// This lets you know whether mp4 is supported. If enabled, an mp4 URL will be provided in the response for the video. 
    /// </summary>
    /// <value>This lets you know whether mp4 is supported. If enabled, an mp4 URL will be provided in the response for the video. </value>
    [DataMember(Name="mp4Support", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mp4Support")]
    public bool mp4support { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Video {\n");
      sb.Append("  VideoId: ").Append(videoid).Append("\n");
      sb.Append("  CreatedAt: ").Append(createdat).Append("\n");
      sb.Append("  Title: ").Append(title).Append("\n");
      sb.Append("  Description: ").Append(description).Append("\n");
      sb.Append("  PublishedAt: ").Append(publishedat).Append("\n");
      sb.Append("  UpdatedAt: ").Append(updatedat).Append("\n");
      sb.Append("  Tags: ").Append(tags).Append("\n");
      sb.Append("  Metadata: ").Append(metadata).Append("\n");
      sb.Append("  Source: ").Append(source).Append("\n");
      sb.Append("  Assets: ").Append(assets).Append("\n");
      sb.Append("  PlayerId: ").Append(playerid).Append("\n");
      sb.Append("  Public: ").Append(_public).Append("\n");
      sb.Append("  Panoramic: ").Append(panoramic).Append("\n");
      sb.Append("  Mp4Support: ").Append(mp4support).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

}
}
