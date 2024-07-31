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
  public class RestreamsResponseObject: DeepObject   {
    /// <summary>
    /// Returns the name of a restream destination.
    /// </summary>
    /// <value>Returns the name of a restream destination.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }
    /// <summary>
    /// Returns the server URL of a restream destination.
    /// </summary>
    /// <value>Returns the server URL of a restream destination.</value>
    [DataMember(Name="serverUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serverUrl")]
    public string serverurl { get; set; }
    /// <summary>
    /// Returns the unique key of the live stream that is set up for restreaming.
    /// </summary>
    /// <value>Returns the unique key of the live stream that is set up for restreaming.</value>
    [DataMember(Name="streamKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "streamKey")]
    public string streamkey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RestreamsResponseObject {\n");
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
