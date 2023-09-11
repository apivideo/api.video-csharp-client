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
  public class LiveStreamUpdatePayload {
    /// <summary>
    /// The name you want to use for your live stream.
    /// </summary>
    /// <value>The name you want to use for your live stream.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }
    /// <summary>
    /// Whether your video can be viewed by everyone, or requires authentication to see it. A setting of false will require a unique token for each view. Learn more about the Private Video feature [here](https://docs.api.video/docs/private-videos).
    /// </summary>
    /// <value>Whether your video can be viewed by everyone, or requires authentication to see it. A setting of false will require a unique token for each view. Learn more about the Private Video feature [here](https://docs.api.video/docs/private-videos).</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public Nullable<bool> _public { get; set; }
    /// <summary>
    /// The unique ID for the player associated with a live stream that you want to update.
    /// </summary>
    /// <value>The unique ID for the player associated with a live stream that you want to update.</value>
    [DataMember(Name="playerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playerId")]
    public string playerid { get; set; }
    /// <summary>
    /// Use this parameter to add, edit, or remove RTMP services where you want to restream a live stream. The list can only contain up to 5 destinations. This operation updates all restream destinations in the same request. If you do not want to modify an existing restream destination, you need to include it in your request, otherwise it is removed.
    /// </summary>
    /// <value>Use this parameter to add, edit, or remove RTMP services where you want to restream a live stream. The list can only contain up to 5 destinations. This operation updates all restream destinations in the same request. If you do not want to modify an existing restream destination, you need to include it in your request, otherwise it is removed.</value>
    [DataMember(Name="restreams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restreams")]
    public List<RestreamsRequestObject> restreams { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LiveStreamUpdatePayload {\n");
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
