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
  public class VideoThumbnailPickPayload {
    /// <summary>
    /// Frame in video to be used as a placeholder before the video plays.  Example: '\"00:01:00.000\" for 1 minute into the video.' Valid Patterns:  \"hh:mm:ss.ms\" \"hh:mm:ss:frameNumber\" \"124\" (integer value is reported as seconds)  If selection is out of range, \"00:00:00.00\" will be chosen.
    /// </summary>
    /// <value>Frame in video to be used as a placeholder before the video plays.  Example: '\"00:01:00.000\" for 1 minute into the video.' Valid Patterns:  \"hh:mm:ss.ms\" \"hh:mm:ss:frameNumber\" \"124\" (integer value is reported as seconds)  If selection is out of range, \"00:00:00.00\" will be chosen.</value>
    [DataMember(Name="timecode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timecode")]
    public string timecode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoThumbnailPickPayload {\n");
      sb.Append("  Timecode: ").Append(timecode).Append("\n");
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
