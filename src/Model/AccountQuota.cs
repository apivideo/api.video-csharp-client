using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// Deprecated
  /// </summary>
  [DataContract]
  public class AccountQuota {
    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [DataMember(Name="quotaUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quotaUsed")]
    public decimal quotaused { get; set; }
    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [DataMember(Name="quotaRemaining", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quotaRemaining")]
    public decimal quotaremaining { get; set; }
    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [DataMember(Name="quotaTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quotaTotal")]
    public decimal quotatotal { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountQuota {\n");
      sb.Append("  QuotaUsed: ").Append(quotaused).Append("\n");
      sb.Append("  QuotaRemaining: ").Append(quotaremaining).Append("\n");
      sb.Append("  QuotaTotal: ").Append(quotatotal).Append("\n");
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
