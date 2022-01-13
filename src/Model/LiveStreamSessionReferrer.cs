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
  public class LiveStreamSessionReferrer {
    /// <summary>
    /// The website the viewer of the live stream was referred to in order to view the live stream.
    /// </summary>
    /// <value>The website the viewer of the live stream was referred to in order to view the live stream.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string url { get; set; }
    /// <summary>
    /// The type of search that brought the viewer to the live stream. Organic would be they found it on their own, paid would be they found it via an advertisement.
    /// </summary>
    /// <value>The type of search that brought the viewer to the live stream. Organic would be they found it on their own, paid would be they found it via an advertisement.</value>
    [DataMember(Name="medium", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "medium")]
    public string medium { get; set; }
    /// <summary>
    /// Where the viewer came from to see the live stream (usually where they searched from).
    /// </summary>
    /// <value>Where the viewer came from to see the live stream (usually where they searched from).</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string source { get; set; }
    /// <summary>
    /// What term they searched for that led them to the live stream.
    /// </summary>
    /// <value>What term they searched for that led them to the live stream.</value>
    [DataMember(Name="searchTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchTerm")]
    public string searchterm { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LiveStreamSessionReferrer {\n");
      sb.Append("  Url: ").Append(url).Append("\n");
      sb.Append("  Medium: ").Append(medium).Append("\n");
      sb.Append("  Source: ").Append(source).Append("\n");
      sb.Append("  SearchTerm: ").Append(searchterm).Append("\n");
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
