using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace VideoApiClient.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Chapter {
    /// <summary>
    /// Gets or Sets Uri
    /// </summary>
    [DataMember(Name="uri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uri")]
    public string uri { get; set; }

    /// <summary>
    /// The link to your VTT file, which contains your chapters information for the video.
    /// </summary>
    /// <value>The link to your VTT file, which contains your chapters information for the video.</value>
    [DataMember(Name="src", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "src")]
    public string src { get; set; }

    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string language { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Chapter {\n");
      sb.Append("  Uri: ").Append(uri).Append("\n");
      sb.Append("  Src: ").Append(src).Append("\n");
      sb.Append("  Language: ").Append(language).Append("\n");
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
