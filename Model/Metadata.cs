using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace VideoApiClient.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Metadata {
    /// <summary>
    /// The constant that defines the data set.
    /// </summary>
    /// <value>The constant that defines the data set.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string key { get; set; }

    /// <summary>
    /// A variable which belongs to the data set.
    /// </summary>
    /// <value>A variable which belongs to the data set.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Metadata {\n");
      sb.Append("  Key: ").Append(key).Append("\n");
      sb.Append("  Value: ").Append(value).Append("\n");
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
