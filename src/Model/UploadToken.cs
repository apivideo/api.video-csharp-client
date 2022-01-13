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
  public class UploadToken {
    /// <summary>
    /// The unique identifier for the token you will use to authenticate an upload.
    /// </summary>
    /// <value>The unique identifier for the token you will use to authenticate an upload.</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string token { get; set; }
    /// <summary>
    /// Time-to-live - how long the upload token is valid for.
    /// </summary>
    /// <value>Time-to-live - how long the upload token is valid for.</value>
    [DataMember(Name="ttl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ttl")]
    public int ttl { get; set; }
    /// <summary>
    /// When the token was created, displayed in ISO-8601 format.
    /// </summary>
    /// <value>When the token was created, displayed in ISO-8601 format.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? createdat { get; set; }
    /// <summary>
    /// When the token expires, displayed in ISO-8601 format.
    /// </summary>
    /// <value>When the token expires, displayed in ISO-8601 format.</value>
    [DataMember(Name="expiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresAt")]
    public DateTime? expiresat { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UploadToken {\n");
      sb.Append("  Token: ").Append(token).Append("\n");
      sb.Append("  Ttl: ").Append(ttl).Append("\n");
      sb.Append("  CreatedAt: ").Append(createdat).Append("\n");
      sb.Append("  ExpiresAt: ").Append(expiresat).Append("\n");
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
