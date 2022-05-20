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
    /// ChannelPartnerEstimateShippingResponse
    /// </summary>
    [DataContract]
    public partial class ChannelPartnerEstimateShippingResponse :  IEquatable<ChannelPartnerEstimateShippingResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelPartnerEstimateShippingResponse" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="estimates">An array of shipping methods and their costs.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="success">Indicates if API call was successful.</param>
        /// <param name="warning">warning.</param>
        public ChannelPartnerEstimateShippingResponse(Error error = default(Error), List<ChannelPartnerShippingEstimate> estimates = default(List<ChannelPartnerShippingEstimate>), ResponseMetadata metadata = default(ResponseMetadata), bool? success = default(bool?), Warning warning = default(Warning))
        {
            this.Error = error;
            this.Estimates = estimates;
            this.Metadata = metadata;
            this.Success = success;
            this.Warning = warning;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// An array of shipping methods and their costs
        /// </summary>
        /// <value>An array of shipping methods and their costs</value>
        [DataMember(Name="estimates", EmitDefaultValue=false)]
        public List<ChannelPartnerShippingEstimate> Estimates { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Indicates if API call was successful
        /// </summary>
        /// <value>Indicates if API call was successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

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
            sb.Append("class ChannelPartnerEstimateShippingResponse {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Estimates: ").Append(Estimates).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChannelPartnerEstimateShippingResponse);
        }

        /// <summary>
        /// Returns true if ChannelPartnerEstimateShippingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelPartnerEstimateShippingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelPartnerEstimateShippingResponse input)
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
                    this.Estimates == input.Estimates ||
                    this.Estimates != null &&
                    this.Estimates.SequenceEqual(input.Estimates)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.Estimates != null)
                    hashCode = hashCode * 59 + this.Estimates.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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