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
  public class Player {
    /// <summary>
    /// RGBA color for timer text. Default: rgba(255, 255, 255, 1)
    /// </summary>
    /// <value>RGBA color for timer text. Default: rgba(255, 255, 255, 1)</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string text { get; set; }

    /// <summary>
    /// RGBA color for all controls. Default: rgba(255, 255, 255, 1)
    /// </summary>
    /// <value>RGBA color for all controls. Default: rgba(255, 255, 255, 1)</value>
    [DataMember(Name="link", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "link")]
    public string link { get; set; }

    /// <summary>
    /// RGBA color for all controls when hovered. Default: rgba(255, 255, 255, 1)
    /// </summary>
    /// <value>RGBA color for all controls when hovered. Default: rgba(255, 255, 255, 1)</value>
    [DataMember(Name="linkHover", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkHover")]
    public string linkhover { get; set; }

    /// <summary>
    /// RGBA color playback bar: played content. Default: rgba(88, 131, 255, .95)
    /// </summary>
    /// <value>RGBA color playback bar: played content. Default: rgba(88, 131, 255, .95)</value>
    [DataMember(Name="trackPlayed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackPlayed")]
    public string trackplayed { get; set; }

    /// <summary>
    /// RGBA color playback bar: downloaded but unplayed (buffered) content. Default: rgba(255, 255, 255, .35)
    /// </summary>
    /// <value>RGBA color playback bar: downloaded but unplayed (buffered) content. Default: rgba(255, 255, 255, .35)</value>
    [DataMember(Name="trackUnplayed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackUnplayed")]
    public string trackunplayed { get; set; }

    /// <summary>
    /// RGBA color playback bar: background. Default: rgba(255, 255, 255, .2)
    /// </summary>
    /// <value>RGBA color playback bar: background. Default: rgba(255, 255, 255, .2)</value>
    [DataMember(Name="trackBackground", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackBackground")]
    public string trackbackground { get; set; }

    /// <summary>
    /// RGBA color: top 50% of background. Default: rgba(0, 0, 0, .7)
    /// </summary>
    /// <value>RGBA color: top 50% of background. Default: rgba(0, 0, 0, .7)</value>
    [DataMember(Name="backgroundTop", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "backgroundTop")]
    public string backgroundtop { get; set; }

    /// <summary>
    /// RGBA color: bottom 50% of background. Default: rgba(0, 0, 0, .7)
    /// </summary>
    /// <value>RGBA color: bottom 50% of background. Default: rgba(0, 0, 0, .7)</value>
    [DataMember(Name="backgroundBottom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "backgroundBottom")]
    public string backgroundbottom { get; set; }

    /// <summary>
    /// RGBA color for title text. Default: rgba(255, 255, 255, 1)
    /// </summary>
    /// <value>RGBA color for title text. Default: rgba(255, 255, 255, 1)</value>
    [DataMember(Name="backgroundText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "backgroundText")]
    public string backgroundtext { get; set; }

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
      sb.Append("class Player {\n");
      sb.Append("  Text: ").Append(text).Append("\n");
      sb.Append("  Link: ").Append(link).Append("\n");
      sb.Append("  LinkHover: ").Append(linkhover).Append("\n");
      sb.Append("  TrackPlayed: ").Append(trackplayed).Append("\n");
      sb.Append("  TrackUnplayed: ").Append(trackunplayed).Append("\n");
      sb.Append("  TrackBackground: ").Append(trackbackground).Append("\n");
      sb.Append("  BackgroundTop: ").Append(backgroundtop).Append("\n");
      sb.Append("  BackgroundBottom: ").Append(backgroundbottom).Append("\n");
      sb.Append("  BackgroundText: ").Append(backgroundtext).Append("\n");
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