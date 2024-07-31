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
  public class AccessToken: DeepObject   {
    /// <summary>
    /// The access token containing security credentials allowing you to acccess the API. The token lasts for one hour.
    /// </summary>
    /// <value>The access token containing security credentials allowing you to acccess the API. The token lasts for one hour.</value>
    [DataMember(Name="access_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_token")]
    public string accesstoken { get; set; }
    /// <summary>
    /// The type of token you have.
    /// </summary>
    /// <value>The type of token you have.</value>
    [DataMember(Name="token_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token_type")]
    public string tokentype { get; set; }
    /// <summary>
    /// A token you can use to get the next access token when your current access token expires.
    /// </summary>
    /// <value>A token you can use to get the next access token when your current access token expires.</value>
    [DataMember(Name="refresh_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refresh_token")]
    public string refreshtoken { get; set; }
    /// <summary>
    /// Lists the time in seconds when your access token expires. It lasts for one hour.
    /// </summary>
    /// <value>Lists the time in seconds when your access token expires. It lasts for one hour.</value>
    [DataMember(Name="expires_in", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires_in")]
    public int expiresin { get; set; }


    /// <summary>
    /// Constructor. Set default values.
    /// </summary>
    public AccessToken() {
        tokentype = "bearer";
        
    }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessToken {\n");
      sb.Append("  AccessToken: ").Append(accesstoken).Append("\n");
      sb.Append("  TokenType: ").Append(tokentype).Append("\n");
      sb.Append("  RefreshToken: ").Append(refreshtoken).Append("\n");
      sb.Append("  ExpiresIn: ").Append(expiresin).Append("\n");
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
