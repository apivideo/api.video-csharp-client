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
  public class AuthenticatePayload: DeepObject   {
    /// <summary>
    /// Your account API key. You can use your sandbox API key, or you can use your production API key.
    /// </summary>
    /// <value>Your account API key. You can use your sandbox API key, or you can use your production API key.</value>
    [DataMember(Name="apiKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiKey")]
    public string apikey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticatePayload {\n");
      sb.Append("  ApiKey: ").Append(apikey).Append("\n");
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
