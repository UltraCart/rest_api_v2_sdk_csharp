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
    /// OrderValidationResponse
    /// </summary>
    [DataContract]
    public partial class OrderValidationResponse :  IEquatable<OrderValidationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderValidationResponse" /> class.
        /// </summary>
        /// <param name="errors">Errors to display to the merchant if they failed any of the validations checked.</param>
        /// <param name="messages">Informational messages.</param>
        /// <param name="orderWasUpdated">If true, this order was updated during the validation call.  This may happen during address standardization fixes..</param>
        public OrderValidationResponse(List<string> errors = default(List<string>), List<string> messages = default(List<string>), bool? orderWasUpdated = default(bool?))
        {
            this.Errors = errors;
            this.Messages = messages;
            this.OrderWasUpdated = orderWasUpdated;
        }
        
        /// <summary>
        /// Errors to display to the merchant if they failed any of the validations checked
        /// </summary>
        /// <value>Errors to display to the merchant if they failed any of the validations checked</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Informational messages
        /// </summary>
        /// <value>Informational messages</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<string> Messages { get; set; }

        /// <summary>
        /// If true, this order was updated during the validation call.  This may happen during address standardization fixes.
        /// </summary>
        /// <value>If true, this order was updated during the validation call.  This may happen during address standardization fixes.</value>
        [DataMember(Name="order_was_updated", EmitDefaultValue=false)]
        public bool? OrderWasUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderValidationResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  OrderWasUpdated: ").Append(OrderWasUpdated).Append("\n");
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
            return this.Equals(input as OrderValidationResponse);
        }

        /// <summary>
        /// Returns true if OrderValidationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderValidationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderValidationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.OrderWasUpdated == input.OrderWasUpdated ||
                    (this.OrderWasUpdated != null &&
                    this.OrderWasUpdated.Equals(input.OrderWasUpdated))
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.OrderWasUpdated != null)
                    hashCode = hashCode * 59 + this.OrderWasUpdated.GetHashCode();
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
