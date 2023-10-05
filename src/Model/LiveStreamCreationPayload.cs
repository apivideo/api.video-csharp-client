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
  public class LiveStreamCreationPayload {
    /// <summary>
    /// Add a name for your live stream here.
    /// </summary>
    /// <value>Add a name for your live stream here.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }
    /// <summary>
    /// Whether your video can be viewed by everyone, or requires authentication to see it. A setting of false will require a unique token for each view. Learn more about the Private Video feature [here](https://docs.api.video/delivery-analytics/video-privacy-access-management).
    /// </summary>
    /// <value>Whether your video can be viewed by everyone, or requires authentication to see it. A setting of false will require a unique token for each view. Learn more about the Private Video feature [here](https://docs.api.video/delivery-analytics/video-privacy-access-management).</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public Nullable<bool> _public { get; set; }
    /// <summary>
    /// The unique identifier for the player.
    /// </summary>
    /// <value>The unique identifier for the player.</value>
    [DataMember(Name="playerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playerId")]
    public string playerid { get; set; }
    /// <summary>
    /// Use this parameter to add, edit, or remove RTMP services where you want to restream a live stream. The list can only contain up to 5 destinations.
    /// </summary>
    /// <value>Use this parameter to add, edit, or remove RTMP services where you want to restream a live stream. The list can only contain up to 5 destinations.</value>
    [DataMember(Name="restreams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restreams")]
    public List<RestreamsRequestObject> restreams { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LiveStreamCreationPayload {\n");
      sb.Append("  Name: ").Append(name).Append("\n");
      sb.Append("  Public: ").Append(_public).Append("\n");
      sb.Append("  PlayerId: ").Append(playerid).Append("\n");
      sb.Append("  Restreams: ").Append(restreams).Append("\n");
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
