using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// The location of the viewer of the live stream.
  /// </summary>
  [DataContract]
  public class LiveStreamSessionLocation {
    /// <summary>
    /// The country of the viewer of the live stream.
    /// </summary>
    /// <value>The country of the viewer of the live stream.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string country { get; set; }

    /// <summary>
    /// The city of the viewer of the live stream.
    /// </summary>
    /// <value>The city of the viewer of the live stream.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string city { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LiveStreamSessionLocation {\n");
      sb.Append("  Country: ").Append(country).Append("\n");
      sb.Append("  City: ").Append(city).Append("\n");
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
