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
  public class BadRequest: DeepObject   {
    /// <summary>
    /// A link to the error documentation.
    /// </summary>
    /// <value>A link to the error documentation.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string type { get; set; }
    /// <summary>
    /// A description of the error that occurred.
    /// </summary>
    /// <value>A description of the error that occurred.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string title { get; set; }
    /// <summary>
    /// The name of the parameter that caused the error.
    /// </summary>
    /// <value>The name of the parameter that caused the error.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }
    /// <summary>
    /// The HTTP status code.
    /// </summary>
    /// <value>The HTTP status code.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int status { get; set; }
    /// <summary>
    /// Returns any additional problems in the request in an array of objects.
    /// </summary>
    /// <value>Returns any additional problems in the request in an array of objects.</value>
    [DataMember(Name="problems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "problems")]
    public List<AdditionalBadRequestErrors> problems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BadRequest {\n");
      sb.Append("  Type: ").Append(type).Append("\n");
      sb.Append("  Title: ").Append(title).Append("\n");
      sb.Append("  Name: ").Append(name).Append("\n");
      sb.Append("  Status: ").Append(status).Append("\n");
      sb.Append("  Problems: ").Append(problems).Append("\n");
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
