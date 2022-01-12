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
  public class LiveStreamSession {
    /// <summary>
    /// Gets or Sets Session
    /// </summary>
    [DataMember(Name="session", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "session")]
    public LiveStreamSessionSession session { get; set; }
    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public LiveStreamSessionLocation location { get; set; }
    /// <summary>
    /// Gets or Sets Referrer
    /// </summary>
    [DataMember(Name="referrer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referrer")]
    public LiveStreamSessionReferrer referrer { get; set; }
    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    [DataMember(Name="device", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "device")]
    public LiveStreamSessionDevice device { get; set; }
    /// <summary>
    /// Gets or Sets Os
    /// </summary>
    [DataMember(Name="os", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "os")]
    public VideoSessionOs os { get; set; }
    /// <summary>
    /// Gets or Sets _Client
    /// </summary>
    [DataMember(Name="client", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client")]
    public LiveStreamSessionClient _client { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LiveStreamSession {\n");
      sb.Append("  Session: ").Append(session).Append("\n");
      sb.Append("  Location: ").Append(location).Append("\n");
      sb.Append("  Referrer: ").Append(referrer).Append("\n");
      sb.Append("  Device: ").Append(device).Append("\n");
      sb.Append("  Os: ").Append(os).Append("\n");
      sb.Append("  _Client: ").Append(_client).Append("\n");
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
