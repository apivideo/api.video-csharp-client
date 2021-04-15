using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace VideoApiClient.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Pagination {
    /// <summary>
    /// Total number of items that exist.
    /// </summary>
    /// <value>Total number of items that exist.</value>
    [DataMember(Name="itemsTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemsTotal")]
    public int itemstotal { get; set; }

    /// <summary>
    /// Number of items listed in the current page.
    /// </summary>
    /// <value>Number of items listed in the current page.</value>
    [DataMember(Name="pagesTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pagesTotal")]
    public int pagestotal { get; set; }

    /// <summary>
    /// Maximum number of item per page.
    /// </summary>
    /// <value>Maximum number of item per page.</value>
    [DataMember(Name="pageSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageSize")]
    public int pagesize { get; set; }

    /// <summary>
    /// The current page index.
    /// </summary>
    /// <value>The current page index.</value>
    [DataMember(Name="currentPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentPage")]
    public int currentpage { get; set; }

    /// <summary>
    /// The number of items on the current page.
    /// </summary>
    /// <value>The number of items on the current page.</value>
    [DataMember(Name="currentPageItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentPageItems")]
    public int currentpageitems { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public List<PaginationLink> links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Pagination {\n");
      sb.Append("  ItemsTotal: ").Append(itemstotal).Append("\n");
      sb.Append("  PagesTotal: ").Append(pagestotal).Append("\n");
      sb.Append("  PageSize: ").Append(pagesize).Append("\n");
      sb.Append("  CurrentPage: ").Append(currentpage).Append("\n");
      sb.Append("  CurrentPageItems: ").Append(currentpageitems).Append("\n");
      sb.Append("  Links: ").Append(links).Append("\n");
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
