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
    /// EmailSegmentDownloadPrepareResponse
    /// </summary>
    [DataContract]
    public partial class EmailSegmentDownloadPrepareResponse :  IEquatable<EmailSegmentDownloadPrepareResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSegmentDownloadPrepareResponse" /> class.
        /// </summary>
        /// <param name="EmailSegmentRebuildUuid">EmailSegmentRebuildUuid.</param>
        /// <param name="EmailSegmentUuid">EmailSegmentUuid.</param>
        /// <param name="Error">Error.</param>
        /// <param name="Metadata">Metadata.</param>
        /// <param name="PercentageComplete">PercentageComplete.</param>
        /// <param name="Proceed">Proceed.</param>
        /// <param name="Success">Indicates if API call was successful.</param>
        public EmailSegmentDownloadPrepareResponse(string EmailSegmentRebuildUuid = default(string), string EmailSegmentUuid = default(string), Error Error = default(Error), ResponseMetadata Metadata = default(ResponseMetadata), decimal? PercentageComplete = default(decimal?), bool? Proceed = default(bool?), bool? Success = default(bool?))
        {
            this.EmailSegmentRebuildUuid = EmailSegmentRebuildUuid;
            this.EmailSegmentUuid = EmailSegmentUuid;
            this.Error = Error;
            this.Metadata = Metadata;
            this.PercentageComplete = PercentageComplete;
            this.Proceed = Proceed;
            this.Success = Success;
        }
        
        /// <summary>
        /// Gets or Sets EmailSegmentRebuildUuid
        /// </summary>
        [DataMember(Name="email_segment_rebuild_uuid", EmitDefaultValue=false)]
        public string EmailSegmentRebuildUuid { get; set; }

        /// <summary>
        /// Gets or Sets EmailSegmentUuid
        /// </summary>
        [DataMember(Name="email_segment_uuid", EmitDefaultValue=false)]
        public string EmailSegmentUuid { get; set; }

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
        /// Gets or Sets PercentageComplete
        /// </summary>
        [DataMember(Name="percentage_complete", EmitDefaultValue=false)]
        public decimal? PercentageComplete { get; set; }

        /// <summary>
        /// Gets or Sets Proceed
        /// </summary>
        [DataMember(Name="proceed", EmitDefaultValue=false)]
        public bool? Proceed { get; set; }

        /// <summary>
        /// Indicates if API call was successful
        /// </summary>
        /// <value>Indicates if API call was successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailSegmentDownloadPrepareResponse {\n");
            sb.Append("  EmailSegmentRebuildUuid: ").Append(EmailSegmentRebuildUuid).Append("\n");
            sb.Append("  EmailSegmentUuid: ").Append(EmailSegmentUuid).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PercentageComplete: ").Append(PercentageComplete).Append("\n");
            sb.Append("  Proceed: ").Append(Proceed).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as EmailSegmentDownloadPrepareResponse);
        }

        /// <summary>
        /// Returns true if EmailSegmentDownloadPrepareResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailSegmentDownloadPrepareResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailSegmentDownloadPrepareResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailSegmentRebuildUuid == input.EmailSegmentRebuildUuid ||
                    (this.EmailSegmentRebuildUuid != null &&
                    this.EmailSegmentRebuildUuid.Equals(input.EmailSegmentRebuildUuid))
                ) && 
                (
                    this.EmailSegmentUuid == input.EmailSegmentUuid ||
                    (this.EmailSegmentUuid != null &&
                    this.EmailSegmentUuid.Equals(input.EmailSegmentUuid))
                ) && 
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
                    this.PercentageComplete == input.PercentageComplete ||
                    (this.PercentageComplete != null &&
                    this.PercentageComplete.Equals(input.PercentageComplete))
                ) && 
                (
                    this.Proceed == input.Proceed ||
                    (this.Proceed != null &&
                    this.Proceed.Equals(input.Proceed))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
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
                if (this.EmailSegmentRebuildUuid != null)
                    hashCode = hashCode * 59 + this.EmailSegmentRebuildUuid.GetHashCode();
                if (this.EmailSegmentUuid != null)
                    hashCode = hashCode * 59 + this.EmailSegmentUuid.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.PercentageComplete != null)
                    hashCode = hashCode * 59 + this.PercentageComplete.GetHashCode();
                if (this.Proceed != null)
                    hashCode = hashCode * 59 + this.Proceed.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
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