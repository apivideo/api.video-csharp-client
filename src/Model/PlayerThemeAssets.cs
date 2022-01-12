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
  public class PlayerThemeAssets {
    /// <summary>
    /// The name of the file containing the logo you want to use.
    /// </summary>
    /// <value>The name of the file containing the logo you want to use.</value>
    [DataMember(Name="logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logo")]
    public string logo { get; set; }
    /// <summary>
    /// The path to the file containing your logo.
    /// </summary>
    /// <value>The path to the file containing your logo.</value>
    [DataMember(Name="link", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "link")]
    public string link { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PlayerThemeAssets {\n");
      sb.Append("  Logo: ").Append(logo).Append("\n");
      sb.Append("  Link: ").Append(link).Append("\n");
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
