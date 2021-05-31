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
  public class Quality {
    /// <summary>
    /// The quality of the video you have, in pixels. Choices include 360p, 480p, 720p, 1080p, and 2160p.
    /// </summary>
    /// <value>The quality of the video you have, in pixels. Choices include 360p, 480p, 720p, 1080p, and 2160p.</value>
    [DataMember(Name="quality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quality")]
    public string _quality { get; set; }
    /// <summary>
    /// The status of your video. Statuses include waiting - the video is waiting to be encoded. encoding - the video is in the process of being encoded. encoded - the video was successfully encoded. failed - the video failed to be encoded.
    /// </summary>
    /// <value>The status of your video. Statuses include waiting - the video is waiting to be encoded. encoding - the video is in the process of being encoded. encoded - the video was successfully encoded. failed - the video failed to be encoded.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string status { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Quality {\n");
      sb.Append("  _Quality: ").Append(_quality).Append("\n");
      sb.Append("  Status: ").Append(status).Append("\n");
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
