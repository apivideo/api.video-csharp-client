using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// Collection of details about the video object that you can use to work with the video object.
  /// </summary>
  [DataContract]
  public class VideoAssets {
    /// <summary>
    /// This is the manifest URL. For HTTP Live Streaming (HLS), when a HLS video stream is initiated, the first file to download is the manifest. This file has the extension M3U8, and provides the video player with information about the various bitrates available for streaming.
    /// </summary>
    /// <value>This is the manifest URL. For HTTP Live Streaming (HLS), when a HLS video stream is initiated, the first file to download is the manifest. This file has the extension M3U8, and provides the video player with information about the various bitrates available for streaming.</value>
    [DataMember(Name="hls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hls")]
    public string hls { get; set; }

    /// <summary>
    /// Code to use video from a third party website
    /// </summary>
    /// <value>Code to use video from a third party website</value>
    [DataMember(Name="iframe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iframe")]
    public string iframe { get; set; }

    /// <summary>
    /// Raw url of the player.
    /// </summary>
    /// <value>Raw url of the player.</value>
    [DataMember(Name="player", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "player")]
    public string player { get; set; }

    /// <summary>
    /// Poster of the video.
    /// </summary>
    /// <value>Poster of the video.</value>
    [DataMember(Name="thumbnail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnail")]
    public string thumbnail { get; set; }

    /// <summary>
    /// Available only if mp4Support is enabled. Raw mp4 url.
    /// </summary>
    /// <value>Available only if mp4Support is enabled. Raw mp4 url.</value>
    [DataMember(Name="mp4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mp4")]
    public string mp4 { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoAssets {\n");
      sb.Append("  Hls: ").Append(hls).Append("\n");
      sb.Append("  Iframe: ").Append(iframe).Append("\n");
      sb.Append("  Player: ").Append(player).Append("\n");
      sb.Append("  Thumbnail: ").Append(thumbnail).Append("\n");
      sb.Append("  Mp4: ").Append(mp4).Append("\n");
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
