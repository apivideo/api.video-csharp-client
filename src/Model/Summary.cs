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
  public class Summary: DeepObject   {
    /// <summary>
    /// The unique identifier of the summary object.
    /// </summary>
    /// <value>The unique identifier of the summary object.</value>
    [DataMember(Name="summaryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "summaryId")]
    public string summaryid { get; set; }
    /// <summary>
    /// Returns the date and time when the summary was created in ATOM date-time format.
    /// </summary>
    /// <value>Returns the date and time when the summary was created in ATOM date-time format.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? createdat { get; set; }
    /// <summary>
    /// Returns the date and time when the summary was last updated in ATOM date-time format.
    /// </summary>
    /// <value>Returns the date and time when the summary was last updated in ATOM date-time format.</value>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public DateTime? updatedat { get; set; }
    /// <summary>
    /// The unique identifier of the video object.
    /// </summary>
    /// <value>The unique identifier of the video object.</value>
    [DataMember(Name="videoId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "videoId")]
    public string videoid { get; set; }
    /// <summary>
    /// Returns the origin of how the summary was created.  - `api` means that no summary was generated automatically. You can add summary manually using the `PATCH /summaries/{summaryId}/source` endpoint operation. Until this happens, `sourceStatus` returns `missing`. - `auto` means that the API generated the summary automatically.
    /// </summary>
    /// <value>Returns the origin of how the summary was created.  - `api` means that no summary was generated automatically. You can add summary manually using the `PATCH /summaries/{summaryId}/source` endpoint operation. Until this happens, `sourceStatus` returns `missing`. - `auto` means that the API generated the summary automatically.</value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string origin { get; set; }
    /// <summary>
    /// Returns the current status of summary generation.  `missing`: the input for a summary is not present. `waiting` : the input video is being processed and a summary will be generated. `failed`: a technical issue prevented summary generation. `completed`: the summary is generated. `unprocessable`: the API rules the source video to be unsuitable for summary generation. An example for this is an input video that has no audio.
    /// </summary>
    /// <value>Returns the current status of summary generation.  `missing`: the input for a summary is not present. `waiting` : the input video is being processed and a summary will be generated. `failed`: a technical issue prevented summary generation. `completed`: the summary is generated. `unprocessable`: the API rules the source video to be unsuitable for summary generation. An example for this is an input video that has no audio.</value>
    [DataMember(Name="sourceStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceStatus")]
    public string sourcestatus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Summary {\n");
      sb.Append("  SummaryId: ").Append(summaryid).Append("\n");
      sb.Append("  CreatedAt: ").Append(createdat).Append("\n");
      sb.Append("  UpdatedAt: ").Append(updatedat).Append("\n");
      sb.Append("  VideoId: ").Append(videoid).Append("\n");
      sb.Append("  Origin: ").Append(origin).Append("\n");
      sb.Append("  SourceStatus: ").Append(sourcestatus).Append("\n");
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
