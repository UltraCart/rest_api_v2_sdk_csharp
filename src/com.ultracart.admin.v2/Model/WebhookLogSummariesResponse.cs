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
    /// WebhookLogSummariesResponse
    /// </summary>
    [DataContract]
    public partial class WebhookLogSummariesResponse :  IEquatable<WebhookLogSummariesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLogSummariesResponse" /> class.
        /// </summary>
        /// <param name="Error">Error.</param>
        /// <param name="Metadata">Metadata.</param>
        /// <param name="Success">Indicates if API call was successful.</param>
        /// <param name="WebhookLogSummaries">Webhook log summaries.</param>
        public WebhookLogSummariesResponse(Error Error = default(Error), ResponseMetadata Metadata = default(ResponseMetadata), bool? Success = default(bool?), List<WebhookLogSummary> WebhookLogSummaries = default(List<WebhookLogSummary>))
        {
            this.Error = Error;
            this.Metadata = Metadata;
            this.Success = Success;
            this.WebhookLogSummaries = WebhookLogSummaries;
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
        /// Indicates if API call was successful
        /// </summary>
        /// <value>Indicates if API call was successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Webhook log summaries
        /// </summary>
        /// <value>Webhook log summaries</value>
        [DataMember(Name="webhook_log_summaries", EmitDefaultValue=false)]
        public List<WebhookLogSummary> WebhookLogSummaries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookLogSummariesResponse {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  WebhookLogSummaries: ").Append(WebhookLogSummaries).Append("\n");
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
            return this.Equals(input as WebhookLogSummariesResponse);
        }

        /// <summary>
        /// Returns true if WebhookLogSummariesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookLogSummariesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookLogSummariesResponse input)
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
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.WebhookLogSummaries == input.WebhookLogSummaries ||
                    this.WebhookLogSummaries != null &&
                    this.WebhookLogSummaries.SequenceEqual(input.WebhookLogSummaries)
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.WebhookLogSummaries != null)
                    hashCode = hashCode * 59 + this.WebhookLogSummaries.GetHashCode();
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
