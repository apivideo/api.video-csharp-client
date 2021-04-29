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
  public class VideostatusEncodingMetadata {
    /// <summary>
    /// The width of the video in pixels.
    /// </summary>
    /// <value>The width of the video in pixels.</value>
    [DataMember(Name="width", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "width")]
    public int width { get; set; }

    /// <summary>
    /// The height of the video in pixels.
    /// </summary>
    /// <value>The height of the video in pixels.</value>
    [DataMember(Name="height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "height")]
    public int height { get; set; }

    /// <summary>
    /// The number of bits processed per second.
    /// </summary>
    /// <value>The number of bits processed per second.</value>
    [DataMember(Name="bitrate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bitrate")]
    public decimal bitrate { get; set; }

    /// <summary>
    /// The length of the video.
    /// </summary>
    /// <value>The length of the video.</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int duration { get; set; }

    /// <summary>
    /// The frequency with which consecutive images or frames appear on a display. Shown in this API as frames per second (fps).
    /// </summary>
    /// <value>The frequency with which consecutive images or frames appear on a display. Shown in this API as frames per second (fps).</value>
    [DataMember(Name="framerate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "framerate")]
    public int framerate { get; set; }

    /// <summary>
    /// How many samples per second a digital audio system uses to record an audio signal. The higher the rate, the higher the frequencies that can be recorded. They are presented in this API using hertz.
    /// </summary>
    /// <value>How many samples per second a digital audio system uses to record an audio signal. The higher the rate, the higher the frequencies that can be recorded. They are presented in this API using hertz.</value>
    [DataMember(Name="samplerate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "samplerate")]
    public int samplerate { get; set; }

    /// <summary>
    /// The method used to compress and decompress digital video. API Video supports all codecs in the libavcodec library. 
    /// </summary>
    /// <value>The method used to compress and decompress digital video. API Video supports all codecs in the libavcodec library. </value>
    [DataMember(Name="videoCodec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "videoCodec")]
    public string videocodec { get; set; }

    /// <summary>
    /// The method used to compress and decompress digital audio for your video.
    /// </summary>
    /// <value>The method used to compress and decompress digital audio for your video.</value>
    [DataMember(Name="audioCodec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "audioCodec")]
    public string audiocodec { get; set; }

    /// <summary>
    /// Gets or Sets AspectRatio
    /// </summary>
    [DataMember(Name="aspectRatio", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aspectRatio")]
    public string aspectratio { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideostatusEncodingMetadata {\n");
      sb.Append("  Width: ").Append(width).Append("\n");
      sb.Append("  Height: ").Append(height).Append("\n");
      sb.Append("  Bitrate: ").Append(bitrate).Append("\n");
      sb.Append("  Duration: ").Append(duration).Append("\n");
      sb.Append("  Framerate: ").Append(framerate).Append("\n");
      sb.Append("  Samplerate: ").Append(samplerate).Append("\n");
      sb.Append("  VideoCodec: ").Append(videocodec).Append("\n");
      sb.Append("  AudioCodec: ").Append(audiocodec).Append("\n");
      sb.Append("  AspectRatio: ").Append(aspectratio).Append("\n");
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
