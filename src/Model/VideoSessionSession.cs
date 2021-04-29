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
  public class VideoSessionSession {
    /// <summary>
    /// The unique identifier for the session that you can use to track what happens during it.
    /// </summary>
    /// <value>The unique identifier for the session that you can use to track what happens during it.</value>
    [DataMember(Name="sessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sessionId")]
    public string sessionid { get; set; }

    /// <summary>
    /// When the video session started, presented in ISO-8601 format.
    /// </summary>
    /// <value>When the video session started, presented in ISO-8601 format.</value>
    [DataMember(Name="loadedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadedAt")]
    public DateTime? loadedat { get; set; }

    /// <summary>
    /// When the video session ended, presented in ISO-8601 format.
    /// </summary>
    /// <value>When the video session ended, presented in ISO-8601 format.</value>
    [DataMember(Name="endedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endedAt")]
    public DateTime? endedat { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoSessionSession {\n");
      sb.Append("  SessionId: ").Append(sessionid).Append("\n");
      sb.Append("  LoadedAt: ").Append(loadedat).Append("\n");
      sb.Append("  EndedAt: ").Append(endedat).Append("\n");
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
