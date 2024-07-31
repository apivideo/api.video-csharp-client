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
  public class FilterBy1: DeepObject   {
    /// <summary>
    /// Returns analytics based on the unique identifiers of a video or a live stream.
    /// </summary>
    /// <value>Returns analytics based on the unique identifiers of a video or a live stream.</value>
    [DataMember(Name="mediaId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mediaId")]
    public List<string> mediaid { get; set; }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    [DataMember(Name="mediaType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mediaType")]
    public string mediatype { get; set; }
    /// <summary>
    /// Returns analytics based on the viewers' continent. The list of supported continents names are based on the [GeoNames public database](https://www.geonames.org/countries/). You must use the ISO-3166 alpha2 format, for example `EU`.
    /// </summary>
    /// <value>Returns analytics based on the viewers' continent. The list of supported continents names are based on the [GeoNames public database](https://www.geonames.org/countries/). You must use the ISO-3166 alpha2 format, for example `EU`.</value>
    [DataMember(Name="continent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "continent")]
    public List<string> continent { get; set; }
    /// <summary>
    /// Returns analytics based on the viewers' country. The list of supported country names are based on the [GeoNames public database](https://www.geonames.org/countries/). You must use the ISO-3166 alpha2 format, for example `FR`.
    /// </summary>
    /// <value>Returns analytics based on the viewers' country. The list of supported country names are based on the [GeoNames public database](https://www.geonames.org/countries/). You must use the ISO-3166 alpha2 format, for example `FR`.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public List<string> country { get; set; }
    /// <summary>
    /// Returns analytics based on the type of device used by the viewers. Response values can include: `computer`, `phone`, `tablet`, `tv`, `console`, `wearable`, `unknown`.
    /// </summary>
    /// <value>Returns analytics based on the type of device used by the viewers. Response values can include: `computer`, `phone`, `tablet`, `tv`, `console`, `wearable`, `unknown`.</value>
    [DataMember(Name="deviceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deviceType")]
    public List<string> devicetype { get; set; }
    /// <summary>
    /// Returns analytics based on the operating system used by the viewers. Response values can include `windows`, `mac osx`, `android`, `ios`, `linux`.
    /// </summary>
    /// <value>Returns analytics based on the operating system used by the viewers. Response values can include `windows`, `mac osx`, `android`, `ios`, `linux`.</value>
    [DataMember(Name="operatingSystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operatingSystem")]
    public List<string> operatingsystem { get; set; }
    /// <summary>
    /// Returns analytics based on the browser used by the viewers. Response values can include `chrome`, `firefox`, `edge`, `opera`.
    /// </summary>
    /// <value>Returns analytics based on the browser used by the viewers. Response values can include `chrome`, `firefox`, `edge`, `opera`.</value>
    [DataMember(Name="browser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "browser")]
    public List<string> browser { get; set; }
    /// <summary>
    /// Returns analytics for videos using this tag. This filter only accepts a single value and is case sensitive. Read more about tagging your videos [here](https://docs.api.video/vod/tags-metadata).
    /// </summary>
    /// <value>Returns analytics for videos using this tag. This filter only accepts a single value and is case sensitive. Read more about tagging your videos [here](https://docs.api.video/vod/tags-metadata).</value>
    [DataMember(Name="tag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag")]
    public string tag { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FilterBy1 {\n");
      sb.Append("  MediaId: ").Append(mediaid).Append("\n");
      sb.Append("  MediaType: ").Append(mediatype).Append("\n");
      sb.Append("  Continent: ").Append(continent).Append("\n");
      sb.Append("  Country: ").Append(country).Append("\n");
      sb.Append("  DeviceType: ").Append(devicetype).Append("\n");
      sb.Append("  OperatingSystem: ").Append(operatingsystem).Append("\n");
      sb.Append("  Browser: ").Append(browser).Append("\n");
      sb.Append("  Tag: ").Append(tag).Append("\n");
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
