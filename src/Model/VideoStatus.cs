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
  public class VideoStatus {
    /// <summary>
    /// Gets or Sets Ingest
    /// </summary>
    [DataMember(Name="ingest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ingest")]
    public VideoStatusIngest ingest { get; set; }
    /// <summary>
    /// Gets or Sets Encoding
    /// </summary>
    [DataMember(Name="encoding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "encoding")]
    public VideoStatusEncoding encoding { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoStatus {\n");
      sb.Append("  Ingest: ").Append(ingest).Append("\n");
      sb.Append("  Encoding: ").Append(encoding).Append("\n");
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
