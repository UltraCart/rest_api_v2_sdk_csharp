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
    /// CouponAutoApplyConditions
    /// </summary>
    [DataContract]
    public partial class CouponAutoApplyConditions :  IEquatable<CouponAutoApplyConditions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponAutoApplyConditions" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="requiredItems">requiredItems.</param>
        /// <param name="subtotalLevels">subtotalLevels.</param>
        /// <param name="success">Indicates if API call was successful.</param>
        /// <param name="warning">warning.</param>
        public CouponAutoApplyConditions(Error error = default(Error), ResponseMetadata metadata = default(ResponseMetadata), List<CouponAutoApplyCondition> requiredItems = default(List<CouponAutoApplyCondition>), List<CouponAutoApplyCondition> subtotalLevels = default(List<CouponAutoApplyCondition>), bool success = default(bool), Warning warning = default(Warning))
        {
            this.Error = error;
            this.Metadata = metadata;
            this.RequiredItems = requiredItems;
            this.SubtotalLevels = subtotalLevels;
            this.Success = success;
            this.Warning = warning;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or Sets RequiredItems
        /// </summary>
        [DataMember(Name="required_items", EmitDefaultValue=false)]
        public List<CouponAutoApplyCondition> RequiredItems { get; set; }

        /// <summary>
        /// Gets or Sets SubtotalLevels
        /// </summary>
        [DataMember(Name="subtotal_levels", EmitDefaultValue=false)]
        public List<CouponAutoApplyCondition> SubtotalLevels { get; set; }

        /// <summary>
        /// Indicates if API call was successful
        /// </summary>
        /// <value>Indicates if API call was successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Warning
        /// </summary>
        [DataMember(Name="warning", EmitDefaultValue=false)]
        public Warning Warning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponAutoApplyConditions {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  RequiredItems: ").Append(RequiredItems).Append("\n");
            sb.Append("  SubtotalLevels: ").Append(SubtotalLevels).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Warning: ").Append(Warning).Append("\n");
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
            return this.Equals(input as CouponAutoApplyConditions);
        }

        /// <summary>
        /// Returns true if CouponAutoApplyConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponAutoApplyConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponAutoApplyConditions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.RequiredItems == input.RequiredItems ||
                    this.RequiredItems != null &&
                    input.RequiredItems != null &&
                    this.RequiredItems.SequenceEqual(input.RequiredItems)
                ) && 
                (
                    this.SubtotalLevels == input.SubtotalLevels ||
                    this.SubtotalLevels != null &&
                    input.SubtotalLevels != null &&
                    this.SubtotalLevels.SequenceEqual(input.SubtotalLevels)
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Warning == input.Warning ||
                    (this.Warning != null &&
                    this.Warning.Equals(input.Warning))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.RequiredItems != null)
                    hashCode = hashCode * 59 + this.RequiredItems.GetHashCode();
                if (this.SubtotalLevels != null)
                    hashCode = hashCode * 59 + this.SubtotalLevels.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Warning != null)
                    hashCode = hashCode * 59 + this.Warning.GetHashCode();
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
