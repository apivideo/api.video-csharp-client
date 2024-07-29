using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// Returns the starting and ending date-times of the period you want analytics for.
  /// </summary>
  [DataContract]
  public class AnalyticsAggregatedMetricsResponseContextTimeframe: DeepObject   {
    /// <summary>
    /// Returns the starting date-time of the period you want analytics for in ATOM date-time format.
    /// </summary>
    /// <value>Returns the starting date-time of the period you want analytics for in ATOM date-time format.</value>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public DateTime? from { get; set; }
    /// <summary>
    /// Returns the starting date-time of the period you want analytics for in ATOM date-time format.
    /// </summary>
    /// <value>Returns the starting date-time of the period you want analytics for in ATOM date-time format.</value>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public DateTime? to { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AnalyticsAggregatedMetricsResponseContextTimeframe {\n");
      sb.Append("  From: ").Append(from).Append("\n");
      sb.Append("  To: ").Append(to).Append("\n");
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
