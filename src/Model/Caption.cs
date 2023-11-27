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
  public class Caption {
    /// <summary>
    /// The unique resource identifier of the uploaded caption.
    /// </summary>
    /// <value>The unique resource identifier of the uploaded caption.</value>
    [DataMember(Name="uri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uri")]
    public string uri { get; set; }
    /// <summary>
    /// A direct URL to the uploaded caption file.
    /// </summary>
    /// <value>A direct URL to the uploaded caption file.</value>
    [DataMember(Name="src", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "src")]
    public string src { get; set; }
    /// <summary>
    /// Indicates the language of the uploaded caption file using IETF language tags.
    /// </summary>
    /// <value>Indicates the language of the uploaded caption file using IETF language tags.</value>
    [DataMember(Name="srclang", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "srclang")]
    public string srclang { get; set; }
    /// <summary>
    /// Returns the native name of the caption language in UTF-8 encoding.
    /// </summary>
    /// <value>Returns the native name of the caption language in UTF-8 encoding.</value>
    [DataMember(Name="languageName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "languageName")]
    public string languagename { get; set; }
    /// <summary>
    /// Whether you will have subtitles or not. True for yes you will have subtitles, false for no you will not have subtitles.
    /// </summary>
    /// <value>Whether you will have subtitles or not. True for yes you will have subtitles, false for no you will not have subtitles.</value>
    [DataMember(Name="default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default")]
    public Nullable<bool> _default { get; set; }


    /// <summary>
    /// Constructor. Set default values.
    /// </summary>
    public Caption() {
        _default = false;
        
    }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Caption {\n");
      sb.Append("  Uri: ").Append(uri).Append("\n");
      sb.Append("  Src: ").Append(src).Append("\n");
      sb.Append("  Srclang: ").Append(srclang).Append("\n");
      sb.Append("  LanguageName: ").Append(languagename).Append("\n");
      sb.Append("  Default: ").Append(_default).Append("\n");
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
