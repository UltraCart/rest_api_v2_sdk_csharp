/*
 * UltraCart Rest API V2
 *
 * UltraCart REST API Version 2
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: support@ultracart.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = com.ultracart.admin.v2.Client.OpenAPIDateConverter;

namespace com.ultracart.admin.v2.Model
{
    /// <summary>
    /// Report
    /// </summary>
    [DataContract]
    public partial class Report :  IEquatable<Report>, IValidatableObject
    {
        /// <summary>
        /// Security level to execute report under
        /// </summary>
        /// <value>Security level to execute report under</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SecurityLevelEnum
        {
            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 1,

            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 2,

            /// <summary>
            /// Enum Medium for value: medium
            /// </summary>
            [EnumMember(Value = "medium")]
            Medium = 3,

            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 4

        }

        /// <summary>
        /// Security level to execute report under
        /// </summary>
        /// <value>Security level to execute report under</value>
        [DataMember(Name="security_level", EmitDefaultValue=false)]
        public SecurityLevelEnum? SecurityLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Report" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="dataSources">dataSources.</param>
        /// <param name="defaultDatasetId">defaultDatasetId.</param>
        /// <param name="defaultProjectId">defaultProjectId.</param>
        /// <param name="merchantId">merchantId.</param>
        /// <param name="name">name.</param>
        /// <param name="pages">pages.</param>
        /// <param name="reportOid">Object identifier for this report..</param>
        /// <param name="securityLevel">Security level to execute report under.</param>
        public Report(bool active = default(bool), List<ReportDataSource> dataSources = default(List<ReportDataSource>), string defaultDatasetId = default(string), string defaultProjectId = default(string), string merchantId = default(string), string name = default(string), List<ReportPage> pages = default(List<ReportPage>), int reportOid = default(int), SecurityLevelEnum? securityLevel = default(SecurityLevelEnum?))
        {
            this.Active = active;
            this.DataSources = dataSources;
            this.DefaultDatasetId = defaultDatasetId;
            this.DefaultProjectId = defaultProjectId;
            this.MerchantId = merchantId;
            this.Name = name;
            this.Pages = pages;
            this.ReportOid = reportOid;
            this.SecurityLevel = securityLevel;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets DataSources
        /// </summary>
        [DataMember(Name="data_sources", EmitDefaultValue=false)]
        public List<ReportDataSource> DataSources { get; set; }

        /// <summary>
        /// Gets or Sets DefaultDatasetId
        /// </summary>
        [DataMember(Name="default_dataset_id", EmitDefaultValue=false)]
        public string DefaultDatasetId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultProjectId
        /// </summary>
        [DataMember(Name="default_project_id", EmitDefaultValue=false)]
        public string DefaultProjectId { get; set; }

        /// <summary>
        /// Gets or Sets MerchantId
        /// </summary>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Pages
        /// </summary>
        [DataMember(Name="pages", EmitDefaultValue=false)]
        public List<ReportPage> Pages { get; set; }

        /// <summary>
        /// Object identifier for this report.
        /// </summary>
        /// <value>Object identifier for this report.</value>
        [DataMember(Name="report_oid", EmitDefaultValue=false)]
        public int ReportOid { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Report {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  DataSources: ").Append(DataSources).Append("\n");
            sb.Append("  DefaultDatasetId: ").Append(DefaultDatasetId).Append("\n");
            sb.Append("  DefaultProjectId: ").Append(DefaultProjectId).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  ReportOid: ").Append(ReportOid).Append("\n");
            sb.Append("  SecurityLevel: ").Append(SecurityLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Report);
        }

        /// <summary>
        /// Returns true if Report instances are equal
        /// </summary>
        /// <param name="input">Instance of Report to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Report input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.DataSources == input.DataSources ||
                    this.DataSources != null &&
                    input.DataSources != null &&
                    this.DataSources.SequenceEqual(input.DataSources)
                ) && 
                (
                    this.DefaultDatasetId == input.DefaultDatasetId ||
                    (this.DefaultDatasetId != null &&
                    this.DefaultDatasetId.Equals(input.DefaultDatasetId))
                ) && 
                (
                    this.DefaultProjectId == input.DefaultProjectId ||
                    (this.DefaultProjectId != null &&
                    this.DefaultProjectId.Equals(input.DefaultProjectId))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Pages == input.Pages ||
                    this.Pages != null &&
                    input.Pages != null &&
                    this.Pages.SequenceEqual(input.Pages)
                ) && 
                (
                    this.ReportOid == input.ReportOid ||
                    (this.ReportOid != null &&
                    this.ReportOid.Equals(input.ReportOid))
                ) && 
                (
                    this.SecurityLevel == input.SecurityLevel ||
                    (this.SecurityLevel != null &&
                    this.SecurityLevel.Equals(input.SecurityLevel))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.DataSources != null)
                    hashCode = hashCode * 59 + this.DataSources.GetHashCode();
                if (this.DefaultDatasetId != null)
                    hashCode = hashCode * 59 + this.DefaultDatasetId.GetHashCode();
                if (this.DefaultProjectId != null)
                    hashCode = hashCode * 59 + this.DefaultProjectId.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Pages != null)
                    hashCode = hashCode * 59 + this.Pages.GetHashCode();
                if (this.ReportOid != null)
                    hashCode = hashCode * 59 + this.ReportOid.GetHashCode();
                if (this.SecurityLevel != null)
                    hashCode = hashCode * 59 + this.SecurityLevel.GetHashCode();
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
