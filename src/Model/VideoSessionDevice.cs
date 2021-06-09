using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// What type of device the user is on when in the video session.
  /// </summary>
  [DataContract]
  public class VideoSessionDevice {
    /// <summary>
    /// What the type is like desktop, laptop, mobile.
    /// </summary>
    /// <value>What the type is like desktop, laptop, mobile.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string type { get; set; }
    /// <summary>
    /// If known, what the brand of the device is, like Apple, Dell, etc.
    /// </summary>
    /// <value>If known, what the brand of the device is, like Apple, Dell, etc.</value>
    [DataMember(Name="vendor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor")]
    public string vendor { get; set; }
    /// <summary>
    /// The specific model of the device, if known.
    /// </summary>
    /// <value>The specific model of the device, if known.</value>
    [DataMember(Name="model", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "model")]
    public string model { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoSessionDevice {\n");
      sb.Append("  Type: ").Append(type).Append("\n");
      sb.Append("  Vendor: ").Append(vendor).Append("\n");
      sb.Append("  Model: ").Append(model).Append("\n");
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
