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
  public class VideoStatusIngestReceivedParts {
    /// <summary>
    /// The parts that are have been uploaded, ordered. For example, if part 2 was sent before part 1, and both have been uploaded, the output will be [1, 2].
    /// </summary>
    /// <value>The parts that are have been uploaded, ordered. For example, if part 2 was sent before part 1, and both have been uploaded, the output will be [1, 2].</value>
    [DataMember(Name="parts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parts")]
    public List<int> parts { get; set; }
    /// <summary>
    /// Contains the number of expected parts. The total will be listed as \"null\" until the total number of parts is known.
    /// </summary>
    /// <value>Contains the number of expected parts. The total will be listed as \"null\" until the total number of parts is known.</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? total { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoStatusIngestReceivedParts {\n");
      sb.Append("  Parts: ").Append(parts).Append("\n");
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
