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
  public class LiveStreamCreatePayload {
    /// <summary>
    /// Add a name for your live stream here.
    /// </summary>
    /// <value>Add a name for your live stream here.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }

    /// <summary>
    /// Whether you are recording or not. True for record, false for not record.
    /// </summary>
    /// <value>Whether you are recording or not. True for record, false for not record.</value>
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
    /// The unique identifier for the player.
    /// </summary>
    /// <value>The unique identifier for the player.</value>
    [DataMember(Name="playerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playerId")]
    public string playerid { get; set; }


    /// <summary>
    /// Constructor. Set default values.
    /// </summary>
    public LiveStreamCreatePayload() {
        record = false;
        
    }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LiveStreamCreatePayload {\n");
      sb.Append("  Name: ").Append(name).Append("\n");
      sb.Append("  Record: ").Append(record).Append("\n");
      sb.Append("  Public: ").Append(_public).Append("\n");
      sb.Append("  PlayerId: ").Append(playerid).Append("\n");
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
