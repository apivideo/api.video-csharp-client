using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// This appears if the video is from a Live Record.
  /// </summary>
  [DataContract]
  public class VideoSourceLiveStream {
    /// <summary>
    /// The unique identifier for the live stream.
    /// </summary>
    /// <value>The unique identifier for the live stream.</value>
    [DataMember(Name="liveStreamId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "liveStreamId")]
    public string livestreamid { get; set; }
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public List<VideoSourceLiveStreamLink> links { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoSourceLiveStream {\n");
      sb.Append("  LiveStreamId: ").Append(livestreamid).Append("\n");
      sb.Append("  Links: ").Append(links).Append("\n");
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
