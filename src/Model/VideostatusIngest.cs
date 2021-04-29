using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// Details about the capturing, transferring, and storing of your video for use immediately or in the future.
  /// </summary>
  [DataContract]
  public class VideostatusIngest {
    /// <summary>
    /// There are three possible ingest statuses. missing - you are missing information required to ingest the video. uploading - the video is in the process of being uploaded. uploaded - the video is ready for use.
    /// </summary>
    /// <value>There are three possible ingest statuses. missing - you are missing information required to ingest the video. uploading - the video is in the process of being uploaded. uploaded - the video is ready for use.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string status { get; set; }

    /// <summary>
    /// The size of your file in bytes.
    /// </summary>
    /// <value>The size of your file in bytes.</value>
    [DataMember(Name="filesize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filesize")]
    public int filesize { get; set; }

    /// <summary>
    /// The total number of bytes received, listed for each chunk of the upload.
    /// </summary>
    /// <value>The total number of bytes received, listed for each chunk of the upload.</value>
    [DataMember(Name="receivedBytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "receivedBytes")]
    public List<BytesRange> receivedbytes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideostatusIngest {\n");
      sb.Append("  Status: ").Append(status).Append("\n");
      sb.Append("  Filesize: ").Append(filesize).Append("\n");
      sb.Append("  ReceivedBytes: ").Append(receivedbytes).Append("\n");
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
