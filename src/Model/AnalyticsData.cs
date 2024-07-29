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
  public class AnalyticsData: DeepObject   {
    /// <summary>
    /// Shows a value for the property you have specified for `dimension` in your request. For example, if you requested `dimension=videoId`, each `value` field in the response returns a different videoId.
    /// </summary>
    /// <value>Shows a value for the property you have specified for `dimension` in your request. For example, if you requested `dimension=videoId`, each `value` field in the response returns a different videoId.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string value { get; set; }
    /// <summary>
    /// Shows the number of play events for one specific `value`.
    /// </summary>
    /// <value>Shows the number of play events for one specific `value`.</value>
    [DataMember(Name="plays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plays")]
    public int plays { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AnalyticsData {\n");
      sb.Append("  Value: ").Append(value).Append("\n");
      sb.Append("  Plays: ").Append(plays).Append("\n");
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
