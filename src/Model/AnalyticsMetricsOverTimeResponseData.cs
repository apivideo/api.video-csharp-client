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
  public class AnalyticsMetricsOverTimeResponseData: DeepObject   {
    /// <summary>
    /// Returns the timestamp of the event that belongs to a specific metric in ATOM date-time format. For example, if you set `play` with an `hour` interval in your request, then `emittedAt` returns the hourly timestamps of every play event within the timeframe you defined.
    /// </summary>
    /// <value>Returns the timestamp of the event that belongs to a specific metric in ATOM date-time format. For example, if you set `play` with an `hour` interval in your request, then `emittedAt` returns the hourly timestamps of every play event within the timeframe you defined.</value>
    [DataMember(Name="emittedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emittedAt")]
    public string emittedat { get; set; }
    /// <summary>
    /// Returns the data for a specific metric value.
    /// </summary>
    /// <value>Returns the data for a specific metric value.</value>
    [DataMember(Name="metricValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metricValue")]
    public float metricvalue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AnalyticsMetricsOverTimeResponseData {\n");
      sb.Append("  EmittedAt: ").Append(emittedat).Append("\n");
      sb.Append("  MetricValue: ").Append(metricvalue).Append("\n");
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
