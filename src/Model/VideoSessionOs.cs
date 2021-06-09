using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// The operating system the viewer is on.
  /// </summary>
  [DataContract]
  public class VideoSessionOs {
    /// <summary>
    /// The name of the operating system.
    /// </summary>
    /// <value>The name of the operating system.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }
    /// <summary>
    /// The nickname for the operating system, often representing the version.
    /// </summary>
    /// <value>The nickname for the operating system, often representing the version.</value>
    [DataMember(Name="shortname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortname")]
    public string shortname { get; set; }
    /// <summary>
    /// The version of the operating system.
    /// </summary>
    /// <value>The version of the operating system.</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string version { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoSessionOs {\n");
      sb.Append("  Name: ").Append(name).Append("\n");
      sb.Append("  Shortname: ").Append(shortname).Append("\n");
      sb.Append("  Version: ").Append(version).Append("\n");
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
