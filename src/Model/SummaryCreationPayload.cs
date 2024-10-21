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
  public class SummaryCreationPayload: DeepObject   {
    /// <summary>
    /// Create a summary of a video using the video ID.
    /// </summary>
    /// <value>Create a summary of a video using the video ID.</value>
    [DataMember(Name="videoId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "videoId")]
    public string videoid { get; set; }
    /// <summary>
    /// Use this parameter to define how the API generates the summary. The only allowed value is `auto`, which means that the API generates a summary automatically.  If you do not set this parameter, **the API will not generate a summary automatically**.  In this case, `sourceStatus` will return `missing`, and you have to manually add a summary using the `PATCH /summaries/{summaryId}/source` endpoint operation.
    /// </summary>
    /// <value>Use this parameter to define how the API generates the summary. The only allowed value is `auto`, which means that the API generates a summary automatically.  If you do not set this parameter, **the API will not generate a summary automatically**.  In this case, `sourceStatus` will return `missing`, and you have to manually add a summary using the `PATCH /summaries/{summaryId}/source` endpoint operation.</value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string origin { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SummaryCreationPayload {\n");
      sb.Append("  VideoId: ").Append(videoid).Append("\n");
      sb.Append("  Origin: ").Append(origin).Append("\n");
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
