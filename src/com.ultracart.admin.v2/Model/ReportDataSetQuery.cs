/* 
 * UltraCart Rest API V2
 *
 * UltraCart REST API Version 2
 *
 * OpenAPI spec version: 2.0.0
 * Contact: support@ultracart.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = com.ultracart.admin.v2.Client.SwaggerDateConverter;

namespace com.ultracart.admin.v2.Model
{
    /// <summary>
    /// ReportDataSetQuery
    /// </summary>
    [DataContract]
    public partial class ReportDataSetQuery :  IEquatable<ReportDataSetQuery>, IValidatableObject
    {
        /// <summary>
        /// The type of object this data set is for
        /// </summary>
        /// <value>The type of object this data set is for</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ForObjectTypeEnum
        {
            
            /// <summary>
            /// Enum Schema for value: schema
            /// </summary>
            [EnumMember(Value = "schema")]
            Schema = 1,
            
            /// <summary>
            /// Enum Filter for value: filter
            /// </summary>
            [EnumMember(Value = "filter")]
            Filter = 2,
            
            /// <summary>
            /// Enum Visualization for value: visualization
            /// </summary>
            [EnumMember(Value = "visualization")]
            Visualization = 3
        }

        /// <summary>
        /// The type of object this data set is for
        /// </summary>
        /// <value>The type of object this data set is for</value>
        [DataMember(Name="for_object_type", EmitDefaultValue=false)]
        public ForObjectTypeEnum? ForObjectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDataSetQuery" /> class.
        /// </summary>
        /// <param name="comparisonResults">True if a date range filter is provided with comparison date ranges and two results should be returned for the query..</param>
        /// <param name="dataSetQueryUuid">A unique identifier assigned to the data set query that is returned..</param>
        /// <param name="dataSource">dataSource.</param>
        /// <param name="dimensions">dimensions.</param>
        /// <param name="filter">filter.</param>
        /// <param name="forObjectId">An identifier that can be used to help match up the returned data set.</param>
        /// <param name="forObjectType">The type of object this data set is for.</param>
        /// <param name="metrics">metrics.</param>
        /// <param name="pageSize">Result set page size.  The default value is 200 records.  Max is 10000..</param>
        /// <param name="selectedFilters">selectedFilters.</param>
        /// <param name="skipCache">True if the 15 minute cache should be skipped..</param>
        /// <param name="userData">Any other data that needs to be returned with the response to help the UI.</param>
        public ReportDataSetQuery(bool? comparisonResults = default(bool?), string dataSetQueryUuid = default(string), ReportDataSource dataSource = default(ReportDataSource), List<ReportPageVisualizationDimension> dimensions = default(List<ReportPageVisualizationDimension>), ReportFilter filter = default(ReportFilter), string forObjectId = default(string), ForObjectTypeEnum? forObjectType = default(ForObjectTypeEnum?), List<ReportPageVisualizationMetric> metrics = default(List<ReportPageVisualizationMetric>), int? pageSize = default(int?), List<ReportFilter> selectedFilters = default(List<ReportFilter>), bool? skipCache = default(bool?), string userData = default(string))
        {
            this.ComparisonResults = comparisonResults;
            this.DataSetQueryUuid = dataSetQueryUuid;
            this.DataSource = dataSource;
            this.Dimensions = dimensions;
            this.Filter = filter;
            this.ForObjectId = forObjectId;
            this.ForObjectType = forObjectType;
            this.Metrics = metrics;
            this.PageSize = pageSize;
            this.SelectedFilters = selectedFilters;
            this.SkipCache = skipCache;
            this.UserData = userData;
        }
        
        /// <summary>
        /// True if a date range filter is provided with comparison date ranges and two results should be returned for the query.
        /// </summary>
        /// <value>True if a date range filter is provided with comparison date ranges and two results should be returned for the query.</value>
        [DataMember(Name="comparison_results", EmitDefaultValue=false)]
        public bool? ComparisonResults { get; set; }

        /// <summary>
        /// A unique identifier assigned to the data set query that is returned.
        /// </summary>
        /// <value>A unique identifier assigned to the data set query that is returned.</value>
        [DataMember(Name="data_set_query_uuid", EmitDefaultValue=false)]
        public string DataSetQueryUuid { get; set; }

        /// <summary>
        /// Gets or Sets DataSource
        /// </summary>
        [DataMember(Name="data_source", EmitDefaultValue=false)]
        public ReportDataSource DataSource { get; set; }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name="dimensions", EmitDefaultValue=false)]
        public List<ReportPageVisualizationDimension> Dimensions { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public ReportFilter Filter { get; set; }

        /// <summary>
        /// An identifier that can be used to help match up the returned data set
        /// </summary>
        /// <value>An identifier that can be used to help match up the returned data set</value>
        [DataMember(Name="for_object_id", EmitDefaultValue=false)]
        public string ForObjectId { get; set; }


        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<ReportPageVisualizationMetric> Metrics { get; set; }

        /// <summary>
        /// Result set page size.  The default value is 200 records.  Max is 10000.
        /// </summary>
        /// <value>Result set page size.  The default value is 200 records.  Max is 10000.</value>
        [DataMember(Name="page_size", EmitDefaultValue=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or Sets SelectedFilters
        /// </summary>
        [DataMember(Name="selected_filters", EmitDefaultValue=false)]
        public List<ReportFilter> SelectedFilters { get; set; }

        /// <summary>
        /// True if the 15 minute cache should be skipped.
        /// </summary>
        /// <value>True if the 15 minute cache should be skipped.</value>
        [DataMember(Name="skip_cache", EmitDefaultValue=false)]
        public bool? SkipCache { get; set; }

        /// <summary>
        /// Any other data that needs to be returned with the response to help the UI
        /// </summary>
        /// <value>Any other data that needs to be returned with the response to help the UI</value>
        [DataMember(Name="user_data", EmitDefaultValue=false)]
        public string UserData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportDataSetQuery {\n");
            sb.Append("  ComparisonResults: ").Append(ComparisonResults).Append("\n");
            sb.Append("  DataSetQueryUuid: ").Append(DataSetQueryUuid).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  ForObjectId: ").Append(ForObjectId).Append("\n");
            sb.Append("  ForObjectType: ").Append(ForObjectType).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  SelectedFilters: ").Append(SelectedFilters).Append("\n");
            sb.Append("  SkipCache: ").Append(SkipCache).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReportDataSetQuery);
        }

        /// <summary>
        /// Returns true if ReportDataSetQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportDataSetQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportDataSetQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComparisonResults == input.ComparisonResults ||
                    (this.ComparisonResults != null &&
                    this.ComparisonResults.Equals(input.ComparisonResults))
                ) && 
                (
                    this.DataSetQueryUuid == input.DataSetQueryUuid ||
                    (this.DataSetQueryUuid != null &&
                    this.DataSetQueryUuid.Equals(input.DataSetQueryUuid))
                ) && 
                (
                    this.DataSource == input.DataSource ||
                    (this.DataSource != null &&
                    this.DataSource.Equals(input.DataSource))
                ) && 
                (
                    this.Dimensions == input.Dimensions ||
                    this.Dimensions != null &&
                    this.Dimensions.SequenceEqual(input.Dimensions)
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.ForObjectId == input.ForObjectId ||
                    (this.ForObjectId != null &&
                    this.ForObjectId.Equals(input.ForObjectId))
                ) && 
                (
                    this.ForObjectType == input.ForObjectType ||
                    (this.ForObjectType != null &&
                    this.ForObjectType.Equals(input.ForObjectType))
                ) && 
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.SelectedFilters == input.SelectedFilters ||
                    this.SelectedFilters != null &&
                    this.SelectedFilters.SequenceEqual(input.SelectedFilters)
                ) && 
                (
                    this.SkipCache == input.SkipCache ||
                    (this.SkipCache != null &&
                    this.SkipCache.Equals(input.SkipCache))
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ComparisonResults != null)
                    hashCode = hashCode * 59 + this.ComparisonResults.GetHashCode();
                if (this.DataSetQueryUuid != null)
                    hashCode = hashCode * 59 + this.DataSetQueryUuid.GetHashCode();
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.ForObjectId != null)
                    hashCode = hashCode * 59 + this.ForObjectId.GetHashCode();
                if (this.ForObjectType != null)
                    hashCode = hashCode * 59 + this.ForObjectType.GetHashCode();
                if (this.Metrics != null)
                    hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.SelectedFilters != null)
                    hashCode = hashCode * 59 + this.SelectedFilters.GetHashCode();
                if (this.SkipCache != null)
                    hashCode = hashCode * 59 + this.SkipCache.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}