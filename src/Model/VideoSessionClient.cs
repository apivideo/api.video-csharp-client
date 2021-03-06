using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// What kind of browser the viewer is using for the video session.
  /// </summary>
  [DataContract]
  public class VideoSessionClient {
    /// <summary>
    /// The name of the browser used to view the video session.
    /// </summary>
    /// <value>The name of the browser used to view the video session.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }
    /// <summary>
    /// The version of the browser used to view the video session.
    /// </summary>
    /// <value>The version of the browser used to view the video session.</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string version { get; set; }
    /// <summary>
    /// The type of client used to view the video session.
    /// </summary>
    /// <value>The type of client used to view the video session.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoSessionClient {\n");
      sb.Append("  Name: ").Append(name).Append("\n");
      sb.Append("  Version: ").Append(version).Append("\n");
      sb.Append("  Type: ").Append(type).Append("\n");
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
