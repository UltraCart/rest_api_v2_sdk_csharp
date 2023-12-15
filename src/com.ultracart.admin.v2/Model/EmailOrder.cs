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
    /// EmailOrder
    /// </summary>
    [DataContract]
    public partial class EmailOrder :  IEquatable<EmailOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailOrder" /> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="orderDts">order_dts.</param>
        /// <param name="orderId">order_id.</param>
        /// <param name="total">total.</param>
        public EmailOrder(string email = default(string), string orderDts = default(string), string orderId = default(string), Currency total = default(Currency))
        {
            this.Email = email;
            this.OrderDts = orderDts;
            this.OrderId = orderId;
            this.Total = total;
        }

        /// <summary>
        /// email
        /// </summary>
        /// <value>email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// order_dts
        /// </summary>
        /// <value>order_dts</value>
        [DataMember(Name="order_dts", EmitDefaultValue=false)]
        public string OrderDts { get; set; }

        /// <summary>
        /// order_id
        /// </summary>
        /// <value>order_id</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public Currency Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailOrder {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  OrderDts: ").Append(OrderDts).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as EmailOrder);
        }

        /// <summary>
        /// Returns true if EmailOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.OrderDts == input.OrderDts ||
                    (this.OrderDts != null &&
                    this.OrderDts.Equals(input.OrderDts))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.OrderDts != null)
                    hashCode = hashCode * 59 + this.OrderDts.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
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
