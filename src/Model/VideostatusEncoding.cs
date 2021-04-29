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
  public class VideostatusEncoding {
    /// <summary>
    /// Whether the video is playable or not.
    /// </summary>
    /// <value>Whether the video is playable or not.</value>
    [DataMember(Name="playable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playable")]
    public bool playable { get; set; }

    /// <summary>
    /// Available qualities the video can be viewed in.
    /// </summary>
    /// <value>Available qualities the video can be viewed in.</value>
    [DataMember(Name="qualities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qualities")]
    public List<Quality> qualities { get; set; }

    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public VideostatusEncodingMetadata metadata { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideostatusEncoding {\n");
      sb.Append("  Playable: ").Append(playable).Append("\n");
      sb.Append("  Qualities: ").Append(qualities).Append("\n");
      sb.Append("  Metadata: ").Append(metadata).Append("\n");
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
