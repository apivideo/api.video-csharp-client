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
  public class PlayerAllOf {
    /// <summary>
    /// enable/disable player SDK access. Default: true
    /// </summary>
    /// <value>enable/disable player SDK access. Default: true</value>
    [DataMember(Name="enableApi", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enableApi")]
    public bool enableapi { get; set; }

    /// <summary>
    /// enable/disable player controls. Default: true
    /// </summary>
    /// <value>enable/disable player controls. Default: true</value>
    [DataMember(Name="enableControls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enableControls")]
    public bool enablecontrols { get; set; }

    /// <summary>
    /// enable/disable player autoplay. Default: false
    /// </summary>
    /// <value>enable/disable player autoplay. Default: false</value>
    [DataMember(Name="forceAutoplay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forceAutoplay")]
    public bool forceautoplay { get; set; }

    /// <summary>
    /// enable/disable title. Default: false
    /// </summary>
    /// <value>enable/disable title. Default: false</value>
    [DataMember(Name="hideTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hideTitle")]
    public bool hidetitle { get; set; }

    /// <summary>
    /// enable/disable looping. Default: false
    /// </summary>
    /// <value>enable/disable looping. Default: false</value>
    [DataMember(Name="forceLoop", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forceLoop")]
    public bool forceloop { get; set; }

    /// <summary>
    /// Gets or Sets PlayerId
    /// </summary>
    [DataMember(Name="playerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playerId")]
    public string playerid { get; set; }

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
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [DataMember(Name="shapeMargin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shapeMargin")]
    public int shapemargin { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [DataMember(Name="shapeRadius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shapeRadius")]
    public int shaperadius { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [DataMember(Name="shapeAspect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shapeAspect")]
    public string shapeaspect { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [DataMember(Name="shapeBackgroundTop", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shapeBackgroundTop")]
    public string shapebackgroundtop { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [DataMember(Name="shapeBackgroundBottom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shapeBackgroundBottom")]
    public string shapebackgroundbottom { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [DataMember(Name="linkActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkActive")]
    public string linkactive { get; set; }

    /// <summary>
    /// Gets or Sets Assets
    /// </summary>
    [DataMember(Name="assets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assets")]
    public PlayerAllOfAssets assets { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PlayerAllOf {\n");
      sb.Append("  EnableApi: ").Append(enableapi).Append("\n");
      sb.Append("  EnableControls: ").Append(enablecontrols).Append("\n");
      sb.Append("  ForceAutoplay: ").Append(forceautoplay).Append("\n");
      sb.Append("  HideTitle: ").Append(hidetitle).Append("\n");
      sb.Append("  ForceLoop: ").Append(forceloop).Append("\n");
      sb.Append("  PlayerId: ").Append(playerid).Append("\n");
      sb.Append("  CreatedAt: ").Append(createdat).Append("\n");
      sb.Append("  UpdatedAt: ").Append(updatedat).Append("\n");
      sb.Append("  ShapeMargin: ").Append(shapemargin).Append("\n");
      sb.Append("  ShapeRadius: ").Append(shaperadius).Append("\n");
      sb.Append("  ShapeAspect: ").Append(shapeaspect).Append("\n");
      sb.Append("  ShapeBackgroundTop: ").Append(shapebackgroundtop).Append("\n");
      sb.Append("  ShapeBackgroundBottom: ").Append(shapebackgroundbottom).Append("\n");
      sb.Append("  LinkActive: ").Append(linkactive).Append("\n");
      sb.Append("  Assets: ").Append(assets).Append("\n");
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
