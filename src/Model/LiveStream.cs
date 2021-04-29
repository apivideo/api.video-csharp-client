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
  public class LiveStream {
    /// <summary>
    /// The unique identifier for the live stream. Live stream IDs begin with \"li.\"
    /// </summary>
    /// <value>The unique identifier for the live stream. Live stream IDs begin with \"li.\"</value>
    [DataMember(Name="liveStreamId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "liveStreamId")]
    public string livestreamid { get; set; }

    /// <summary>
    /// The name of your live stream.
    /// </summary>
    /// <value>The name of your live stream.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }

    /// <summary>
    /// The unique, private stream key that you use to begin streaming.
    /// </summary>
    /// <value>The unique, private stream key that you use to begin streaming.</value>
    [DataMember(Name="streamKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "streamKey")]
    public string streamkey { get; set; }

    /// <summary>
    /// Whether you are recording or not.
    /// </summary>
    /// <value>Whether you are recording or not.</value>
    [DataMember(Name="record", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "record")]
    public bool record { get; set; }

    /// <summary>
    /// BETA FEATURE Please limit all public = false (\"private\") livestreams to 3,000 users. Whether your video can be viewed by everyone, or requires authentication to see it. A setting of false will require a unique token for each view.
    /// </summary>
    /// <value>BETA FEATURE Please limit all public = false (\"private\") livestreams to 3,000 users. Whether your video can be viewed by everyone, or requires authentication to see it. A setting of false will require a unique token for each view.</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public bool _public { get; set; }

    /// <summary>
    /// Gets or Sets Assets
    /// </summary>
    [DataMember(Name="assets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assets")]
    public LiveStreamAssets assets { get; set; }

    /// <summary>
    /// The unique identifier for the player.
    /// </summary>
    /// <value>The unique identifier for the player.</value>
    [DataMember(Name="playerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playerId")]
    public string playerid { get; set; }

    /// <summary>
    /// Whether or not you are broadcasting the live video you recorded for others to see. True means you are broadcasting to viewers, false means you are not.
    /// </summary>
    /// <value>Whether or not you are broadcasting the live video you recorded for others to see. True means you are broadcasting to viewers, false means you are not.</value>
    [DataMember(Name="broadcasting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "broadcasting")]
    public bool broadcasting { get; set; }

    /// <summary>
    /// When the player was created, presented in ISO-8601 format.
    /// </summary>
    /// <value>When the player was created, presented in ISO-8601 format.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? createdat { get; set; }

    /// <summary>
    /// When the player was last updated, presented in ISO-8601 format.
    /// </summary>
    /// <value>When the player was last updated, presented in ISO-8601 format.</value>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public DateTime? updatedat { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LiveStream {\n");
      sb.Append("  LiveStreamId: ").Append(livestreamid).Append("\n");
      sb.Append("  Name: ").Append(name).Append("\n");
      sb.Append("  StreamKey: ").Append(streamkey).Append("\n");
      sb.Append("  Record: ").Append(record).Append("\n");
      sb.Append("  Public: ").Append(_public).Append("\n");
      sb.Append("  Assets: ").Append(assets).Append("\n");
      sb.Append("  PlayerId: ").Append(playerid).Append("\n");
      sb.Append("  Broadcasting: ").Append(broadcasting).Append("\n");
      sb.Append("  CreatedAt: ").Append(createdat).Append("\n");
      sb.Append("  UpdatedAt: ").Append(updatedat).Append("\n");
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
