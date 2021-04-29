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
  public class Playerinput {
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Playerinput {\n");
      sb.Append("  Text: ").Append(text).Append("\n");
      sb.Append("  Link: ").Append(link).Append("\n");
      sb.Append("  LinkHover: ").Append(linkhover).Append("\n");
      sb.Append("  TrackPlayed: ").Append(trackplayed).Append("\n");
      sb.Append("  TrackUnplayed: ").Append(trackunplayed).Append("\n");
      sb.Append("  TrackBackground: ").Append(trackbackground).Append("\n");
      sb.Append("  BackgroundTop: ").Append(backgroundtop).Append("\n");
      sb.Append("  BackgroundBottom: ").Append(backgroundbottom).Append("\n");
      sb.Append("  BackgroundText: ").Append(backgroundtext).Append("\n");
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
