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
  public class LiveStreamAssets {
    /// <summary>
    /// The http live streaming (HLS) link for your live video stream.
    /// </summary>
    /// <value>The http live streaming (HLS) link for your live video stream.</value>
    [DataMember(Name="hls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hls")]
    public string hls { get; set; }
    /// <summary>
    /// The embed code for the iframe containing your live video stream.
    /// </summary>
    /// <value>The embed code for the iframe containing your live video stream.</value>
    [DataMember(Name="iframe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iframe")]
    public string iframe { get; set; }
    /// <summary>
    /// A link to the video player that is playing your live stream.
    /// </summary>
    /// <value>A link to the video player that is playing your live stream.</value>
    [DataMember(Name="player", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "player")]
    public string player { get; set; }
    /// <summary>
    /// A link to the thumbnail for your video.
    /// </summary>
    /// <value>A link to the thumbnail for your video.</value>
    [DataMember(Name="thumbnail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnail")]
    public string thumbnail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LiveStreamAssets {\n");
      sb.Append("  Hls: ").Append(hls).Append("\n");
      sb.Append("  Iframe: ").Append(iframe).Append("\n");
      sb.Append("  Player: ").Append(player).Append("\n");
      sb.Append("  Thumbnail: ").Append(thumbnail).Append("\n");
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
