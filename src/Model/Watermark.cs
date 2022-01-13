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
  public class Watermark {
    /// <summary>
    /// The unique identifier of the watermark.
    /// </summary>
    /// <value>The unique identifier of the watermark.</value>
    [DataMember(Name="watermarkId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "watermarkId")]
    public string watermarkid { get; set; }
    /// <summary>
    /// When the watermark was created, presented in ISO-8601 format.
    /// </summary>
    /// <value>When the watermark was created, presented in ISO-8601 format.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? createdat { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Watermark {\n");
      sb.Append("  WatermarkId: ").Append(watermarkid).Append("\n");
      sb.Append("  CreatedAt: ").Append(createdat).Append("\n");
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
