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
  public class AnalyticsMetricsBreakdownResponseContext: DeepObject   {
    /// <summary>
    /// Returns the metric you selected.
    /// </summary>
    /// <value>Returns the metric you selected.</value>
    [DataMember(Name="metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metric")]
    public string metric { get; set; }
    /// <summary>
    /// Returns the dimension you selected.
    /// </summary>
    /// <value>Returns the dimension you selected.</value>
    [DataMember(Name="breakdown", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "breakdown")]
    public string breakdown { get; set; }
    /// <summary>
    /// Gets or Sets Timeframe
    /// </summary>
    [DataMember(Name="timeframe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeframe")]
    public AnalyticsAggregatedMetricsResponseContextTimeframe timeframe { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AnalyticsMetricsBreakdownResponseContext {\n");
      sb.Append("  Metric: ").Append(metric).Append("\n");
      sb.Append("  Breakdown: ").Append(breakdown).Append("\n");
      sb.Append("  Timeframe: ").Append(timeframe).Append("\n");
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
