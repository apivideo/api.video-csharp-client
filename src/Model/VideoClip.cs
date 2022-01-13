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
  public class VideoClip {
    /// <summary>
    /// Gets or Sets StartTimecode
    /// </summary>
    [DataMember(Name="startTimecode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startTimecode")]
    public string starttimecode { get; set; }
    /// <summary>
    /// Gets or Sets EndTimecode
    /// </summary>
    [DataMember(Name="endTimecode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endTimecode")]
    public string endtimecode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoClip {\n");
      sb.Append("  StartTimecode: ").Append(starttimecode).Append("\n");
      sb.Append("  EndTimecode: ").Append(endtimecode).Append("\n");
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
