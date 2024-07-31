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
  public class AnalyticsMetricsBreakdownResponseData: DeepObject   {
    /// <summary>
    /// Returns a specific value for the dimension you selected, based on the data. For example if you select `continent` as a dimension, then `dimensionValue` returns values like `EU` or \"AZ\".
    /// </summary>
    /// <value>Returns a specific value for the dimension you selected, based on the data. For example if you select `continent` as a dimension, then `dimensionValue` returns values like `EU` or \"AZ\".</value>
    [DataMember(Name="dimensionValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dimensionValue")]
    public string dimensionvalue { get; set; }
    /// <summary>
    /// Returns the data for a specific dimension value.
    /// </summary>
    /// <value>Returns the data for a specific dimension value.</value>
    [DataMember(Name="metricValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metricValue")]
    public float metricvalue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AnalyticsMetricsBreakdownResponseData {\n");
      sb.Append("  DimensionValue: ").Append(dimensionvalue).Append("\n");
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
