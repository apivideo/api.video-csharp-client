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
    /// You can either add a video already on the web, by entering the URL of the video, or you can also enter the `videoId` of one of the videos you already have on your api.video acccount, and this will generate a copy of your video. Creating a copy of a video can be especially useful if you want to keep your original video and trim or apply a watermark onto the copy you would create.
    /// </summary>
    /// <value>You can either add a video already on the web, by entering the URL of the video, or you can also enter the `videoId` of one of the videos you already have on your api.video acccount, and this will generate a copy of your video. Creating a copy of a video can be especially useful if you want to keep your original video and trim or apply a watermark onto the copy you would create.</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string source { get; set; }
    /// <summary>
    /// Default: True. If set to `false` the video will become private. More information on private videos can be found [here](https://docs.api.video/delivery-analytics/video-privacy-access-management)
    /// </summary>
    /// <value>Default: True. If set to `false` the video will become private. More information on private videos can be found [here](https://docs.api.video/delivery-analytics/video-privacy-access-management)</value>
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
    /// A list of key value pairs that you use to provide metadata for your video. These pairs can be made dynamic, allowing you to segment your audience. Read more on [dynamic metadata](https://api.video/blog/endpoints/dynamic-metadata/).
    /// </summary>
    /// <value>A list of key value pairs that you use to provide metadata for your video. These pairs can be made dynamic, allowing you to segment your audience. Read more on [dynamic metadata](https://api.video/blog/endpoints/dynamic-metadata/).</value>
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
