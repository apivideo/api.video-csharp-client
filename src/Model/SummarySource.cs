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
  public class SummarySource: DeepObject   {
    /// <summary>
    /// A video title, based on the contents of the video.
    /// </summary>
    /// <value>A video title, based on the contents of the video.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string title { get; set; }
    /// <summary>
    /// A short outline of the contents of the video. The length of an `abstract` depends on the amount of content in a video that can be transcribed. The API condenses the contents into minimum 20, maximum 300 words.
    /// </summary>
    /// <value>A short outline of the contents of the video. The length of an `abstract` depends on the amount of content in a video that can be transcribed. The API condenses the contents into minimum 20, maximum 300 words.</value>
    [DataMember(Name="abstract", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "abstract")]
    public string _abstract { get; set; }
    /// <summary>
    /// A list of 3 key points from the video, in chronological order.
    /// </summary>
    /// <value>A list of 3 key points from the video, in chronological order.</value>
    [DataMember(Name="takeaways", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "takeaways")]
    public List<string> takeaways { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SummarySource {\n");
      sb.Append("  Title: ").Append(title).Append("\n");
      sb.Append("  Abstract: ").Append(_abstract).Append("\n");
      sb.Append("  Takeaways: ").Append(takeaways).Append("\n");
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
