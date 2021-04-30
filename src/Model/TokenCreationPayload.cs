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
  public class TokenCreationPayload {
    /// <summary>
    /// Time in seconds that the token will be active. A value of 0 means that the token has no exipration date. The default is to have no expiration.
    /// </summary>
    /// <value>Time in seconds that the token will be active. A value of 0 means that the token has no exipration date. The default is to have no expiration.</value>
    [DataMember(Name="ttl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ttl")]
    public int ttl { get; set; }


    /// <summary>
    /// Constructor. Set default values.
    /// </summary>
    public TokenCreationPayload() {
        ttl = 0;
        
    }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokenCreationPayload {\n");
      sb.Append("  Ttl: ").Append(ttl).Append("\n");
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
