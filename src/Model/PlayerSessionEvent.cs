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
  public class PlayerSessionEvent {
    /// <summary>
    /// Possible values are: ready, play, pause, resume, seek.backward, seek.forward, end
    /// </summary>
    /// <value>Possible values are: ready, play, pause, resume, seek.backward, seek.forward, end</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string type { get; set; }
    /// <summary>
    /// When an event occurred, presented in ISO-8601 format.
    /// </summary>
    /// <value>When an event occurred, presented in ISO-8601 format.</value>
    [DataMember(Name="emittedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emittedAt")]
    public DateTime? emittedat { get; set; }
    /// <summary>
    /// Gets or Sets At
    /// </summary>
    [DataMember(Name="at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "at")]
    public int at { get; set; }
    /// <summary>
    /// Gets or Sets From
    /// </summary>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public int from { get; set; }
    /// <summary>
    /// Gets or Sets To
    /// </summary>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public int to { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PlayerSessionEvent {\n");
      sb.Append("  Type: ").Append(type).Append("\n");
      sb.Append("  EmittedAt: ").Append(emittedat).Append("\n");
      sb.Append("  At: ").Append(at).Append("\n");
      sb.Append("  From: ").Append(from).Append("\n");
      sb.Append("  To: ").Append(to).Append("\n");
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
