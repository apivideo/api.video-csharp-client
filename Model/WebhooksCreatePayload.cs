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
  public class WebhooksCreatePayload {
    /// <summary>
    /// A list of the webhooks that you are subscribing to. Currently \"video.encoding.quality.completed\" is the only option. video.encoding.quality.completed - a video encoding quality is ready for the video (for example the 720p quality hls encoding video is ready.)
    /// </summary>
    /// <value>A list of the webhooks that you are subscribing to. Currently \"video.encoding.quality.completed\" is the only option. video.encoding.quality.completed - a video encoding quality is ready for the video (for example the 720p quality hls encoding video is ready.)</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<string> events { get; set; }

    /// <summary>
    /// The the url to which HTTP notifications are sent. It could be any http or https URL.
    /// </summary>
    /// <value>The the url to which HTTP notifications are sent. It could be any http or https URL.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebhooksCreatePayload {\n");
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
