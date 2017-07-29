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
    /// OrderItemEdiLot
    /// </summary>
    [DataContract]
    public partial class OrderItemEdiLot :  IEquatable<OrderItemEdiLot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemEdiLot" /> class.
        /// </summary>
        /// <param name="LotExpiration">Log expiration.</param>
        /// <param name="LotNumber">Lot number.</param>
        /// <param name="LotQuantity">Lot quantity.</param>
        public OrderItemEdiLot(string LotExpiration = default(string), string LotNumber = default(string), int? LotQuantity = default(int?))
        {
            this.LotExpiration = LotExpiration;
            this.LotNumber = LotNumber;
            this.LotQuantity = LotQuantity;
        }
        
        /// <summary>
        /// Log expiration
        /// </summary>
        /// <value>Log expiration</value>
        [DataMember(Name="lot_expiration", EmitDefaultValue=false)]
        public string LotExpiration { get; set; }

        /// <summary>
        /// Lot number
        /// </summary>
        /// <value>Lot number</value>
        [DataMember(Name="lot_number", EmitDefaultValue=false)]
        public string LotNumber { get; set; }

        /// <summary>
        /// Lot quantity
        /// </summary>
        /// <value>Lot quantity</value>
        [DataMember(Name="lot_quantity", EmitDefaultValue=false)]
        public int? LotQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderItemEdiLot {\n");
            sb.Append("  LotExpiration: ").Append(LotExpiration).Append("\n");
            sb.Append("  LotNumber: ").Append(LotNumber).Append("\n");
            sb.Append("  LotQuantity: ").Append(LotQuantity).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrderItemEdiLot);
        }

        /// <summary>
        /// Returns true if OrderItemEdiLot instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderItemEdiLot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemEdiLot other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LotExpiration == other.LotExpiration ||
                    this.LotExpiration != null &&
                    this.LotExpiration.Equals(other.LotExpiration)
                ) && 
                (
                    this.LotNumber == other.LotNumber ||
                    this.LotNumber != null &&
                    this.LotNumber.Equals(other.LotNumber)
                ) && 
                (
                    this.LotQuantity == other.LotQuantity ||
                    this.LotQuantity != null &&
                    this.LotQuantity.Equals(other.LotQuantity)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.LotExpiration != null)
                    hash = hash * 59 + this.LotExpiration.GetHashCode();
                if (this.LotNumber != null)
                    hash = hash * 59 + this.LotNumber.GetHashCode();
                if (this.LotQuantity != null)
                    hash = hash * 59 + this.LotQuantity.GetHashCode();
                return hash;
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
