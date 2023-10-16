using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// Use this object to create a smaller clip from a video you upload.  - You can only create video clips in the same request where you create the video container. - You cannot update the starting or ending timestamps of a video clip after you created the video container. - When you upload a video file into a container where you defined a starting and ending timestamp, the API trims the video according to those timestamps to create a clip.
  /// </summary>
  [DataContract]
  public class VideoClip {
    /// <summary>
    /// The timestamp that defines the beginning of the video clip you want to create. The value must follow the `HH:MM:SS` format.
    /// </summary>
    /// <value>The timestamp that defines the beginning of the video clip you want to create. The value must follow the `HH:MM:SS` format.</value>
    [DataMember(Name="startTimecode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startTimecode")]
    public string starttimecode { get; set; }
    /// <summary>
    /// The timestamp that defines the end of the video clip you want to create. The value must follow the `HH:MM:SS` format.
    /// </summary>
    /// <value>The timestamp that defines the end of the video clip you want to create. The value must follow the `HH:MM:SS` format.</value>
    [DataMember(Name="endTimecode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endTimecode")]
    public string endtimecode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoClip {\n");
      sb.Append("  StartTimecode: ").Append(starttimecode).Append("\n");
      sb.Append("  EndTimecode: ").Append(endtimecode).Append("\n");
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
