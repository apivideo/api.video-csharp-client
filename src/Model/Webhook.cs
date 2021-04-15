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
  public class Webhook {
    /// <summary>
    /// Unique identifier of the webhook
    /// </summary>
    /// <value>Unique identifier of the webhook</value>
    [DataMember(Name="webhookId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webhookId")]
    public string webhookid { get; set; }

    /// <summary>
    /// When an webhook was created, presented in ISO-8601 format.
    /// </summary>
    /// <value>When an webhook was created, presented in ISO-8601 format.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? createdat { get; set; }

    /// <summary>
    /// A list of events that will trigger the webhook.
    /// </summary>
    /// <value>A list of events that will trigger the webhook.</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<string> events { get; set; }

    /// <summary>
    /// URL of the webhook
    /// </summary>
    /// <value>URL of the webhook</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Webhook {\n");
      sb.Append("  WebhookId: ").Append(webhookid).Append("\n");
      sb.Append("  CreatedAt: ").Append(createdat).Append("\n");
      sb.Append("  Events: ").Append(events).Append("\n");
      sb.Append("  Url: ").Append(url).Append("\n");
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
