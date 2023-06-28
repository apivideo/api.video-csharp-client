using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// Adding restream destinations is optional. However, if you set a restream destination, you must provide all attributes for each destination.
  /// </summary>
  [DataContract]
  public class RestreamsRequestObject {
    /// <summary>
    /// Use this parameter to define a name for the restream destination.
    /// </summary>
    /// <value>Use this parameter to define a name for the restream destination.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }
    /// <summary>
    /// Use this parameter to set the RTMP URL of the restream destination.
    /// </summary>
    /// <value>Use this parameter to set the RTMP URL of the restream destination.</value>
    [DataMember(Name="serverUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serverUrl")]
    public string serverurl { get; set; }
    /// <summary>
    /// Use this parameter to provide the unique key of the live stream that you want to restream.
    /// </summary>
    /// <value>Use this parameter to provide the unique key of the live stream that you want to restream.</value>
    [DataMember(Name="streamKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "streamKey")]
    public string streamkey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RestreamsRequestObject {\n");
      sb.Append("  Name: ").Append(name).Append("\n");
      sb.Append("  ServerUrl: ").Append(serverurl).Append("\n");
      sb.Append("  StreamKey: ").Append(streamkey).Append("\n");
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
