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
    /// OrderReplacementResponse
    /// </summary>
    [DataContract]
    public partial class OrderReplacementResponse :  IEquatable<OrderReplacementResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderReplacementResponse" /> class.
        /// </summary>
        /// <param name="ChargeSuccessful">ChargeSuccessful.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="Feedback">Feedback.</param>
        /// <param name="Free">Free.</param>
        /// <param name="OrderId">OrderId.</param>
        /// <param name="Successful">Successful.</param>
        public OrderReplacementResponse(bool? ChargeSuccessful = default(bool?), string ErrorMessage = default(string), string Feedback = default(string), bool? Free = default(bool?), string OrderId = default(string), bool? Successful = default(bool?))
        {
            this.ChargeSuccessful = ChargeSuccessful;
            this.ErrorMessage = ErrorMessage;
            this.Feedback = Feedback;
            this.Free = Free;
            this.OrderId = OrderId;
            this.Successful = Successful;
        }
        
        /// <summary>
        /// Gets or Sets ChargeSuccessful
        /// </summary>
        [DataMember(Name="chargeSuccessful", EmitDefaultValue=false)]
        public bool? ChargeSuccessful { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets Feedback
        /// </summary>
        [DataMember(Name="feedback", EmitDefaultValue=false)]
        public string Feedback { get; set; }

        /// <summary>
        /// Gets or Sets Free
        /// </summary>
        [DataMember(Name="free", EmitDefaultValue=false)]
        public bool? Free { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Successful
        /// </summary>
        [DataMember(Name="successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderReplacementResponse {\n");
            sb.Append("  ChargeSuccessful: ").Append(ChargeSuccessful).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Feedback: ").Append(Feedback).Append("\n");
            sb.Append("  Free: ").Append(Free).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
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
            return this.Equals(input as OrderReplacementResponse);
        }

        /// <summary>
        /// Returns true if OrderReplacementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderReplacementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderReplacementResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargeSuccessful == input.ChargeSuccessful ||
                    (this.ChargeSuccessful != null &&
                    this.ChargeSuccessful.Equals(input.ChargeSuccessful))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Feedback == input.Feedback ||
                    (this.Feedback != null &&
                    this.Feedback.Equals(input.Feedback))
                ) && 
                (
                    this.Free == input.Free ||
                    (this.Free != null &&
                    this.Free.Equals(input.Free))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
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
                if (this.ChargeSuccessful != null)
                    hashCode = hashCode * 59 + this.ChargeSuccessful.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.Feedback != null)
                    hashCode = hashCode * 59 + this.Feedback.GetHashCode();
                if (this.Free != null)
                    hashCode = hashCode * 59 + this.Free.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
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