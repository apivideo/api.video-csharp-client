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
  public class BytesRange {
    /// <summary>
    /// The starting point for the range of bytes for a chunk of a video.
    /// </summary>
    /// <value>The starting point for the range of bytes for a chunk of a video.</value>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public int from { get; set; }
    /// <summary>
    /// The ending point for the range of bytes for a chunk of a video.
    /// </summary>
    /// <value>The ending point for the range of bytes for a chunk of a video.</value>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public int to { get; set; }
    /// <summary>
    /// The total number of expected bytes.
    /// </summary>
    /// <value>The total number of expected bytes.</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int total { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BytesRange {\n");
      sb.Append("  From: ").Append(from).Append("\n");
      sb.Append("  To: ").Append(to).Append("\n");
      sb.Append("  Total: ").Append(total).Append("\n");
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
