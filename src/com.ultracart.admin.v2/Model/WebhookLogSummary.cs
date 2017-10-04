/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
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
    /// WebhookLogSummary
    /// </summary>
    [DataContract]
    public partial class WebhookLogSummary :  IEquatable<WebhookLogSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLogSummary" /> class.
        /// </summary>
        /// <param name="DeliveryDts">Date/time of the delivery.</param>
        /// <param name="RequestId">Request id.</param>
        /// <param name="Success">True if the notification was successful.</param>
        public WebhookLogSummary(string DeliveryDts = default(string), string RequestId = default(string), bool? Success = default(bool?))
        {
            this.DeliveryDts = DeliveryDts;
            this.RequestId = RequestId;
            this.Success = Success;
        }
        
        /// <summary>
        /// Date/time of the delivery
        /// </summary>
        /// <value>Date/time of the delivery</value>
        [DataMember(Name="delivery_dts", EmitDefaultValue=false)]
        public string DeliveryDts { get; set; }

        /// <summary>
        /// Request id
        /// </summary>
        /// <value>Request id</value>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// True if the notification was successful
        /// </summary>
        /// <value>True if the notification was successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookLogSummary {\n");
            sb.Append("  DeliveryDts: ").Append(DeliveryDts).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return this.Equals(input as WebhookLogSummary);
        }

        /// <summary>
        /// Returns true if WebhookLogSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookLogSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookLogSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeliveryDts == input.DeliveryDts ||
                    (this.DeliveryDts != null &&
                    this.DeliveryDts.Equals(input.DeliveryDts))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.DeliveryDts != null)
                    hashCode = hashCode * 59 + this.DeliveryDts.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
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
