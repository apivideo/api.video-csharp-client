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
  public class ListTagsResponseData: DeepObject   {
    /// <summary>
    /// Returns the value of a video tag used in your project.
    /// </summary>
    /// <value>Returns the value of a video tag used in your project.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string value { get; set; }
    /// <summary>
    /// Returns the number of times a video tag is used.
    /// </summary>
    /// <value>Returns the number of times a video tag is used.</value>
    [DataMember(Name="videoCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "videoCount")]
    public int videocount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ListTagsResponseData {\n");
      sb.Append("  Value: ").Append(value).Append("\n");
      sb.Append("  VideoCount: ").Append(videocount).Append("\n");
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
