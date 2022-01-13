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
  public class VideoCreationPayload {
    /// <summary>
    /// The title of your new video.
    /// </summary>
    /// <value>The title of your new video.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string title { get; set; }
    /// <summary>
    /// A brief description of your video.
    /// </summary>
    /// <value>A brief description of your video.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string description { get; set; }
    /// <summary>
    /// If you add a video already on the web, this is where you enter the url for the video.
    /// </summary>
    /// <value>If you add a video already on the web, this is where you enter the url for the video.</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string source { get; set; }
    /// <summary>
    /// Whether your video can be viewed by everyone, or requires authentication to see it. A setting of false will require a unique token for each view. Default is true. Tutorials on [private videos](https://api.video/blog/endpoints/private-videos).
    /// </summary>
    /// <value>Whether your video can be viewed by everyone, or requires authentication to see it. A setting of false will require a unique token for each view. Default is true. Tutorials on [private videos](https://api.video/blog/endpoints/private-videos).</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public Nullable<bool> _public { get; set; }
    /// <summary>
    /// Indicates if your video is a 360/immersive video.
    /// </summary>
    /// <value>Indicates if your video is a 360/immersive video.</value>
    [DataMember(Name="panoramic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "panoramic")]
    public Nullable<bool> panoramic { get; set; }
    /// <summary>
    /// Enables mp4 version in addition to streamed version.
    /// </summary>
    /// <value>Enables mp4 version in addition to streamed version.</value>
    [DataMember(Name="mp4Support", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mp4Support")]
    public Nullable<bool> mp4support { get; set; }
    /// <summary>
    /// The unique identification number for your video player.
    /// </summary>
    /// <value>The unique identification number for your video player.</value>
    [DataMember(Name="playerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playerId")]
    public string playerid { get; set; }
    /// <summary>
    /// A list of tags you want to use to describe your video.
    /// </summary>
    /// <value>A list of tags you want to use to describe your video.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> tags { get; set; }
    /// <summary>
    /// A list of key value pairs that you use to provide metadata for your video. These pairs can be made dynamic, allowing you to segment your audience. Read more on [dynamic metadata](https://api.video/blog/endpoints/dynamic-metadata).
    /// </summary>
    /// <value>A list of key value pairs that you use to provide metadata for your video. These pairs can be made dynamic, allowing you to segment your audience. Read more on [dynamic metadata](https://api.video/blog/endpoints/dynamic-metadata).</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public List<Metadata> metadata { get; set; }
    /// <summary>
    /// Gets or Sets Clip
    /// </summary>
    [DataMember(Name="clip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clip")]
    public VideoClip clip { get; set; }
    /// <summary>
    /// Gets or Sets Watermark
    /// </summary>
    [DataMember(Name="watermark", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "watermark")]
    public VideoWatermark watermark { get; set; }


    /// <summary>
    /// Constructor. Set default values.
    /// </summary>
    public VideoCreationPayload() {
        _public = true;
        panoramic = false;
        mp4support = true;
        
    }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoCreationPayload {\n");
      sb.Append("  Title: ").Append(title).Append("\n");
      sb.Append("  Description: ").Append(description).Append("\n");
      sb.Append("  Source: ").Append(source).Append("\n");
      sb.Append("  Public: ").Append(_public).Append("\n");
      sb.Append("  Panoramic: ").Append(panoramic).Append("\n");
      sb.Append("  Mp4Support: ").Append(mp4support).Append("\n");
      sb.Append("  PlayerId: ").Append(playerid).Append("\n");
      sb.Append("  Tags: ").Append(tags).Append("\n");
      sb.Append("  Metadata: ").Append(metadata).Append("\n");
      sb.Append("  Clip: ").Append(clip).Append("\n");
      sb.Append("  Watermark: ").Append(watermark).Append("\n");
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
