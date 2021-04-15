using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace VideoApiClient.Model {

  /// <summary>
  /// Source information about the video.
  /// </summary>
  [DataContract]
  public class VideoSource {
    /// <summary>
    /// The URL where the video is stored.
    /// </summary>
    /// <value>The URL where the video is stored.</value>
    [DataMember(Name="uri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uri")]
    public string uri { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string type { get; set; }

    /// <summary>
    /// Gets or Sets LiveStream
    /// </summary>
    [DataMember(Name="liveStream", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "liveStream")]
    public VideoSourceLiveStream livestream { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoSource {\n");
      sb.Append("  Uri: ").Append(uri).Append("\n");
      sb.Append("  Type: ").Append(type).Append("\n");
      sb.Append("  LiveStream: ").Append(livestream).Append("\n");
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
