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
  public class Webhook: DeepObject   {
    /// <summary>
    /// A unique identifier of the webhook you subscribed to.
    /// </summary>
    /// <value>A unique identifier of the webhook you subscribed to.</value>
    [DataMember(Name="webhookId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webhookId")]
    public string webhookid { get; set; }
    /// <summary>
    /// The time and date when you created this webhook subscription, in ATOM UTC format.
    /// </summary>
    /// <value>The time and date when you created this webhook subscription, in ATOM UTC format.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? createdat { get; set; }
    /// <summary>
    /// A list of events that you subscribed to. When these events occur, the API triggers a webhook call to the URL you provided.
    /// </summary>
    /// <value>A list of events that you subscribed to. When these events occur, the API triggers a webhook call to the URL you provided.</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<string> events { get; set; }
    /// <summary>
    /// The URL where the API sends the webhook.
    /// </summary>
    /// <value>The URL where the API sends the webhook.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string url { get; set; }
    /// <summary>
    /// A secret key for the webhook you subscribed to. You can use it to verify the origin of the webhook call that you receive.
    /// </summary>
    /// <value>A secret key for the webhook you subscribed to. You can use it to verify the origin of the webhook call that you receive.</value>
    [DataMember(Name="signatureSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signatureSecret")]
    public string signaturesecret { get; set; }


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
      sb.Append("  SignatureSecret: ").Append(signaturesecret).Append("\n");
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
