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
  public class VideoWatermark {
    /// <summary>
    /// id of the watermark
    /// </summary>
    /// <value>id of the watermark</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string id { get; set; }
    /// <summary>
    /// Distance expressed in px or % between the top-border of the video and the watermark-image.
    /// </summary>
    /// <value>Distance expressed in px or % between the top-border of the video and the watermark-image.</value>
    [DataMember(Name="top", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "top")]
    public string top { get; set; }
    /// <summary>
    /// Distance expressed in px or % between the left-border of the video and the watermark-image.
    /// </summary>
    /// <value>Distance expressed in px or % between the left-border of the video and the watermark-image.</value>
    [DataMember(Name="left", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "left")]
    public string left { get; set; }
    /// <summary>
    /// Distance expressed in px or % between the bottom-border of the video and the watermark-image.
    /// </summary>
    /// <value>Distance expressed in px or % between the bottom-border of the video and the watermark-image.</value>
    [DataMember(Name="bottom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bottom")]
    public string bottom { get; set; }
    /// <summary>
    /// Distance expressed in px or % between the right-border of the video and the watermark-image.
    /// </summary>
    /// <value>Distance expressed in px or % between the right-border of the video and the watermark-image.</value>
    [DataMember(Name="right", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "right")]
    public string right { get; set; }
    /// <summary>
    /// Width of the watermark-image relative to the video if expressed in %. Otherwise a fixed width. NOTE: To keep intrinsic watermark-image width use `initial`.
    /// </summary>
    /// <value>Width of the watermark-image relative to the video if expressed in %. Otherwise a fixed width. NOTE: To keep intrinsic watermark-image width use `initial`.</value>
    [DataMember(Name="width", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "width")]
    public string width { get; set; }
    /// <summary>
    /// Height of the watermark-image relative to the video if expressed in %. Otherwise a fixed height. NOTE: To keep intrinsic watermark-image height use `initial`.
    /// </summary>
    /// <value>Height of the watermark-image relative to the video if expressed in %. Otherwise a fixed height. NOTE: To keep intrinsic watermark-image height use `initial`.</value>
    [DataMember(Name="height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "height")]
    public string height { get; set; }
    /// <summary>
    /// Opacity expressed in % only to specify the degree of the watermark-image transparency with the video.
    /// </summary>
    /// <value>Opacity expressed in % only to specify the degree of the watermark-image transparency with the video.</value>
    [DataMember(Name="opacity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opacity")]
    public string opacity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoWatermark {\n");
      sb.Append("  Id: ").Append(id).Append("\n");
      sb.Append("  Top: ").Append(top).Append("\n");
      sb.Append("  Left: ").Append(left).Append("\n");
      sb.Append("  Bottom: ").Append(bottom).Append("\n");
      sb.Append("  Right: ").Append(right).Append("\n");
      sb.Append("  Width: ").Append(width).Append("\n");
      sb.Append("  Height: ").Append(height).Append("\n");
      sb.Append("  Opacity: ").Append(opacity).Append("\n");
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
