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
  public class DiscardedVideoUpdatePayload: DeepObject   {
    /// <summary>
    /// Use this parameter to restore a discarded video when you have the Video Restore feature enabled. This parameter only accepts `false` as a value!
    /// </summary>
    /// <value>Use this parameter to restore a discarded video when you have the Video Restore feature enabled. This parameter only accepts `false` as a value!</value>
    [DataMember(Name="discarded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discarded")]
    public Nullable<bool> discarded { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiscardedVideoUpdatePayload {\n");
      sb.Append("  Discarded: ").Append(discarded).Append("\n");
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
