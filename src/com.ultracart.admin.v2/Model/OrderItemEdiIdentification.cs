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
    /// OrderItemEdiIdentification
    /// </summary>
    [DataContract]
    public partial class OrderItemEdiIdentification :  IEquatable<OrderItemEdiIdentification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemEdiIdentification" /> class.
        /// </summary>
        /// <param name="identification">Identification value.</param>
        /// <param name="quantity">Quantity associated with this identifier.</param>
        public OrderItemEdiIdentification(string identification = default(string), int quantity = default(int))
        {
            this.Identification = identification;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Identification value
        /// </summary>
        /// <value>Identification value</value>
        [DataMember(Name="identification", EmitDefaultValue=false)]
        public string Identification { get; set; }

        /// <summary>
        /// Quantity associated with this identifier
        /// </summary>
        /// <value>Quantity associated with this identifier</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderItemEdiIdentification {\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as OrderItemEdiIdentification);
        }

        /// <summary>
        /// Returns true if OrderItemEdiIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItemEdiIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemEdiIdentification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identification == input.Identification ||
                    (this.Identification != null &&
                    this.Identification.Equals(input.Identification))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.Identification != null)
                    hashCode = hashCode * 59 + this.Identification.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
