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
  public class PlayerUpdatePayloadAllOf {
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PlayerUpdatePayloadAllOf {\n");
      sb.Append("  EnableApi: ").Append(enableapi).Append("\n");
      sb.Append("  EnableControls: ").Append(enablecontrols).Append("\n");
      sb.Append("  ForceAutoplay: ").Append(forceautoplay).Append("\n");
      sb.Append("  HideTitle: ").Append(hidetitle).Append("\n");
      sb.Append("  ForceLoop: ").Append(forceloop).Append("\n");
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
