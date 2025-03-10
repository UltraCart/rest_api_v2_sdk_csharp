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
    /// CouponPercentOffSubtotalWithSubtotal
    /// </summary>
    [DataContract]
    public partial class CouponPercentOffSubtotalWithSubtotal :  IEquatable<CouponPercentOffSubtotalWithSubtotal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponPercentOffSubtotalWithSubtotal" /> class.
        /// </summary>
        /// <param name="currencyCode">The ISO-4217 three letter currency code the customer is viewing prices in.</param>
        /// <param name="discountPercent">The percentage of subtotal discount.</param>
        /// <param name="subtotalAmount">The amount of subtotal required to receive the discount percent.</param>
        public CouponPercentOffSubtotalWithSubtotal(string currencyCode = default(string), decimal discountPercent = default(decimal), decimal subtotalAmount = default(decimal))
        {
            this.CurrencyCode = currencyCode;
            this.DiscountPercent = discountPercent;
            this.SubtotalAmount = subtotalAmount;
        }

        /// <summary>
        /// The ISO-4217 three letter currency code the customer is viewing prices in
        /// </summary>
        /// <value>The ISO-4217 three letter currency code the customer is viewing prices in</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The percentage of subtotal discount
        /// </summary>
        /// <value>The percentage of subtotal discount</value>
        [DataMember(Name="discount_percent", EmitDefaultValue=false)]
        public decimal DiscountPercent { get; set; }

        /// <summary>
        /// The amount of subtotal required to receive the discount percent
        /// </summary>
        /// <value>The amount of subtotal required to receive the discount percent</value>
        [DataMember(Name="subtotal_amount", EmitDefaultValue=false)]
        public decimal SubtotalAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponPercentOffSubtotalWithSubtotal {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  SubtotalAmount: ").Append(SubtotalAmount).Append("\n");
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
            return this.Equals(input as CouponPercentOffSubtotalWithSubtotal);
        }

        /// <summary>
        /// Returns true if CouponPercentOffSubtotalWithSubtotal instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponPercentOffSubtotalWithSubtotal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponPercentOffSubtotalWithSubtotal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.DiscountPercent == input.DiscountPercent ||
                    (this.DiscountPercent != null &&
                    this.DiscountPercent.Equals(input.DiscountPercent))
                ) && 
                (
                    this.SubtotalAmount == input.SubtotalAmount ||
                    (this.SubtotalAmount != null &&
                    this.SubtotalAmount.Equals(input.SubtotalAmount))
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
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.DiscountPercent != null)
                    hashCode = hashCode * 59 + this.DiscountPercent.GetHashCode();
                if (this.SubtotalAmount != null)
                    hashCode = hashCode * 59 + this.SubtotalAmount.GetHashCode();
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
            // CurrencyCode (string) maxLength
            if(this.CurrencyCode != null && this.CurrencyCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrencyCode, length must be less than 3.", new [] { "CurrencyCode" });
            }


            yield break;
        }
    }

}
