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
    /// CartGiftCertificate
    /// </summary>
    [DataContract]
    public partial class CartGiftCertificate :  IEquatable<CartGiftCertificate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartGiftCertificate" /> class.
        /// </summary>
        /// <param name="GiftCertificateAmount">GiftCertificateAmount.</param>
        /// <param name="GiftCertificateCode">Gift certificate code.</param>
        /// <param name="GiftCertificateRemainingBalanceAfterOrder">GiftCertificateRemainingBalanceAfterOrder.</param>
        public CartGiftCertificate(Currency GiftCertificateAmount = default(Currency), string GiftCertificateCode = default(string), Currency GiftCertificateRemainingBalanceAfterOrder = default(Currency))
        {
            this.GiftCertificateAmount = GiftCertificateAmount;
            this.GiftCertificateCode = GiftCertificateCode;
            this.GiftCertificateRemainingBalanceAfterOrder = GiftCertificateRemainingBalanceAfterOrder;
        }
        
        /// <summary>
        /// Gets or Sets GiftCertificateAmount
        /// </summary>
        [DataMember(Name="gift_certificate_amount", EmitDefaultValue=false)]
        public Currency GiftCertificateAmount { get; set; }

        /// <summary>
        /// Gift certificate code
        /// </summary>
        /// <value>Gift certificate code</value>
        [DataMember(Name="gift_certificate_code", EmitDefaultValue=false)]
        public string GiftCertificateCode { get; set; }

        /// <summary>
        /// Gets or Sets GiftCertificateRemainingBalanceAfterOrder
        /// </summary>
        [DataMember(Name="gift_certificate_remaining_balance_after_order", EmitDefaultValue=false)]
        public Currency GiftCertificateRemainingBalanceAfterOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartGiftCertificate {\n");
            sb.Append("  GiftCertificateAmount: ").Append(GiftCertificateAmount).Append("\n");
            sb.Append("  GiftCertificateCode: ").Append(GiftCertificateCode).Append("\n");
            sb.Append("  GiftCertificateRemainingBalanceAfterOrder: ").Append(GiftCertificateRemainingBalanceAfterOrder).Append("\n");
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
            return this.Equals(input as CartGiftCertificate);
        }

        /// <summary>
        /// Returns true if CartGiftCertificate instances are equal
        /// </summary>
        /// <param name="input">Instance of CartGiftCertificate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartGiftCertificate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GiftCertificateAmount == input.GiftCertificateAmount ||
                    (this.GiftCertificateAmount != null &&
                    this.GiftCertificateAmount.Equals(input.GiftCertificateAmount))
                ) && 
                (
                    this.GiftCertificateCode == input.GiftCertificateCode ||
                    (this.GiftCertificateCode != null &&
                    this.GiftCertificateCode.Equals(input.GiftCertificateCode))
                ) && 
                (
                    this.GiftCertificateRemainingBalanceAfterOrder == input.GiftCertificateRemainingBalanceAfterOrder ||
                    (this.GiftCertificateRemainingBalanceAfterOrder != null &&
                    this.GiftCertificateRemainingBalanceAfterOrder.Equals(input.GiftCertificateRemainingBalanceAfterOrder))
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
                if (this.GiftCertificateAmount != null)
                    hashCode = hashCode * 59 + this.GiftCertificateAmount.GetHashCode();
                if (this.GiftCertificateCode != null)
                    hashCode = hashCode * 59 + this.GiftCertificateCode.GetHashCode();
                if (this.GiftCertificateRemainingBalanceAfterOrder != null)
                    hashCode = hashCode * 59 + this.GiftCertificateRemainingBalanceAfterOrder.GetHashCode();
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
