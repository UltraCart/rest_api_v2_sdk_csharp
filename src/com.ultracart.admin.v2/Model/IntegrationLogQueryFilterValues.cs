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
    /// IntegrationLogQueryFilterValues
    /// </summary>
    [DataContract]
    public partial class IntegrationLogQueryFilterValues :  IEquatable<IntegrationLogQueryFilterValues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationLogQueryFilterValues" /> class.
        /// </summary>
        /// <param name="actions">actions.</param>
        /// <param name="directions">directions.</param>
        /// <param name="emails">emails.</param>
        /// <param name="fileNames">fileNames.</param>
        /// <param name="itemIds">itemIds.</param>
        /// <param name="itemIpnOids">itemIpnOids.</param>
        /// <param name="logDtsMax">Maximum date/time log date/time.</param>
        /// <param name="logDtsMin">Minimum date/time log date/time.</param>
        /// <param name="logTypes">logTypes.</param>
        /// <param name="loggerNames">loggerNames.</param>
        /// <param name="orderIds">orderIds.</param>
        /// <param name="statuses">statuses.</param>
        public IntegrationLogQueryFilterValues(List<string> actions = default(List<string>), List<string> directions = default(List<string>), List<string> emails = default(List<string>), List<string> fileNames = default(List<string>), List<string> itemIds = default(List<string>), List<int> itemIpnOids = default(List<int>), string logDtsMax = default(string), string logDtsMin = default(string), List<string> logTypes = default(List<string>), List<string> loggerNames = default(List<string>), List<string> orderIds = default(List<string>), List<string> statuses = default(List<string>))
        {
            this.Actions = actions;
            this.Directions = directions;
            this.Emails = emails;
            this.FileNames = fileNames;
            this.ItemIds = itemIds;
            this.ItemIpnOids = itemIpnOids;
            this.LogDtsMax = logDtsMax;
            this.LogDtsMin = logDtsMin;
            this.LogTypes = logTypes;
            this.LoggerNames = loggerNames;
            this.OrderIds = orderIds;
            this.Statuses = statuses;
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// Gets or Sets Directions
        /// </summary>
        [DataMember(Name="directions", EmitDefaultValue=false)]
        public List<string> Directions { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Gets or Sets FileNames
        /// </summary>
        [DataMember(Name="file_names", EmitDefaultValue=false)]
        public List<string> FileNames { get; set; }

        /// <summary>
        /// Gets or Sets ItemIds
        /// </summary>
        [DataMember(Name="item_ids", EmitDefaultValue=false)]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// Gets or Sets ItemIpnOids
        /// </summary>
        [DataMember(Name="item_ipn_oids", EmitDefaultValue=false)]
        public List<int> ItemIpnOids { get; set; }

        /// <summary>
        /// Maximum date/time log date/time
        /// </summary>
        /// <value>Maximum date/time log date/time</value>
        [DataMember(Name="log_dts_max", EmitDefaultValue=false)]
        public string LogDtsMax { get; set; }

        /// <summary>
        /// Minimum date/time log date/time
        /// </summary>
        /// <value>Minimum date/time log date/time</value>
        [DataMember(Name="log_dts_min", EmitDefaultValue=false)]
        public string LogDtsMin { get; set; }

        /// <summary>
        /// Gets or Sets LogTypes
        /// </summary>
        [DataMember(Name="log_types", EmitDefaultValue=false)]
        public List<string> LogTypes { get; set; }

        /// <summary>
        /// Gets or Sets LoggerNames
        /// </summary>
        [DataMember(Name="logger_names", EmitDefaultValue=false)]
        public List<string> LoggerNames { get; set; }

        /// <summary>
        /// Gets or Sets OrderIds
        /// </summary>
        [DataMember(Name="order_ids", EmitDefaultValue=false)]
        public List<string> OrderIds { get; set; }

        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [DataMember(Name="statuses", EmitDefaultValue=false)]
        public List<string> Statuses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationLogQueryFilterValues {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Directions: ").Append(Directions).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  FileNames: ").Append(FileNames).Append("\n");
            sb.Append("  ItemIds: ").Append(ItemIds).Append("\n");
            sb.Append("  ItemIpnOids: ").Append(ItemIpnOids).Append("\n");
            sb.Append("  LogDtsMax: ").Append(LogDtsMax).Append("\n");
            sb.Append("  LogDtsMin: ").Append(LogDtsMin).Append("\n");
            sb.Append("  LogTypes: ").Append(LogTypes).Append("\n");
            sb.Append("  LoggerNames: ").Append(LoggerNames).Append("\n");
            sb.Append("  OrderIds: ").Append(OrderIds).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
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
            return this.Equals(input as IntegrationLogQueryFilterValues);
        }

        /// <summary>
        /// Returns true if IntegrationLogQueryFilterValues instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegrationLogQueryFilterValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationLogQueryFilterValues input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.Directions == input.Directions ||
                    this.Directions != null &&
                    input.Directions != null &&
                    this.Directions.SequenceEqual(input.Directions)
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.FileNames == input.FileNames ||
                    this.FileNames != null &&
                    input.FileNames != null &&
                    this.FileNames.SequenceEqual(input.FileNames)
                ) && 
                (
                    this.ItemIds == input.ItemIds ||
                    this.ItemIds != null &&
                    input.ItemIds != null &&
                    this.ItemIds.SequenceEqual(input.ItemIds)
                ) && 
                (
                    this.ItemIpnOids == input.ItemIpnOids ||
                    this.ItemIpnOids != null &&
                    input.ItemIpnOids != null &&
                    this.ItemIpnOids.SequenceEqual(input.ItemIpnOids)
                ) && 
                (
                    this.LogDtsMax == input.LogDtsMax ||
                    (this.LogDtsMax != null &&
                    this.LogDtsMax.Equals(input.LogDtsMax))
                ) && 
                (
                    this.LogDtsMin == input.LogDtsMin ||
                    (this.LogDtsMin != null &&
                    this.LogDtsMin.Equals(input.LogDtsMin))
                ) && 
                (
                    this.LogTypes == input.LogTypes ||
                    this.LogTypes != null &&
                    input.LogTypes != null &&
                    this.LogTypes.SequenceEqual(input.LogTypes)
                ) && 
                (
                    this.LoggerNames == input.LoggerNames ||
                    this.LoggerNames != null &&
                    input.LoggerNames != null &&
                    this.LoggerNames.SequenceEqual(input.LoggerNames)
                ) && 
                (
                    this.OrderIds == input.OrderIds ||
                    this.OrderIds != null &&
                    input.OrderIds != null &&
                    this.OrderIds.SequenceEqual(input.OrderIds)
                ) && 
                (
                    this.Statuses == input.Statuses ||
                    this.Statuses != null &&
                    input.Statuses != null &&
                    this.Statuses.SequenceEqual(input.Statuses)
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
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.Directions != null)
                    hashCode = hashCode * 59 + this.Directions.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.FileNames != null)
                    hashCode = hashCode * 59 + this.FileNames.GetHashCode();
                if (this.ItemIds != null)
                    hashCode = hashCode * 59 + this.ItemIds.GetHashCode();
                if (this.ItemIpnOids != null)
                    hashCode = hashCode * 59 + this.ItemIpnOids.GetHashCode();
                if (this.LogDtsMax != null)
                    hashCode = hashCode * 59 + this.LogDtsMax.GetHashCode();
                if (this.LogDtsMin != null)
                    hashCode = hashCode * 59 + this.LogDtsMin.GetHashCode();
                if (this.LogTypes != null)
                    hashCode = hashCode * 59 + this.LogTypes.GetHashCode();
                if (this.LoggerNames != null)
                    hashCode = hashCode * 59 + this.LoggerNames.GetHashCode();
                if (this.OrderIds != null)
                    hashCode = hashCode * 59 + this.OrderIds.GetHashCode();
                if (this.Statuses != null)
                    hashCode = hashCode * 59 + this.Statuses.GetHashCode();
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
