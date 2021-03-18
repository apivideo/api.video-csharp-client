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
  public class VideoSessionReferrer {
    /// <summary>
    /// The link the viewer used to reach the video session.
    /// </summary>
    /// <value>The link the viewer used to reach the video session.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string url { get; set; }

    /// <summary>
    /// How they arrived at the site, for example organic or paid. Organic meaning they found it themselves and paid meaning they followed a link from an advertisement.
    /// </summary>
    /// <value>How they arrived at the site, for example organic or paid. Organic meaning they found it themselves and paid meaning they followed a link from an advertisement.</value>
    [DataMember(Name="medium", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "medium")]
    public string medium { get; set; }

    /// <summary>
    /// The source the referrer came from to the video session. For example if they searched through google to find the stream.
    /// </summary>
    /// <value>The source the referrer came from to the video session. For example if they searched through google to find the stream.</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string source { get; set; }

    /// <summary>
    /// The search term they typed to arrive at the video session.
    /// </summary>
    /// <value>The search term they typed to arrive at the video session.</value>
    [DataMember(Name="searchTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchTerm")]
    public string searchterm { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoSessionReferrer {\n");
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
