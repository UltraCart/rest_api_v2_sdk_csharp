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
    /// CouponAmountOffSubtotalWithPurchase
    /// </summary>
    [DataContract]
    public partial class CouponAmountOffSubtotalWithPurchase :  IEquatable<CouponAmountOffSubtotalWithPurchase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponAmountOffSubtotalWithPurchase" /> class.
        /// </summary>
        /// <param name="currencyCode">The ISO-4217 three letter currency code the customer is viewing prices in.</param>
        /// <param name="discountAmount">The amount of subtotal discount.</param>
        /// <param name="purchaseAmount">The purchase amount to qualify for subtotal discount and free shipping.</param>
        public CouponAmountOffSubtotalWithPurchase(string currencyCode = default(string), decimal? discountAmount = default(decimal?), decimal? purchaseAmount = default(decimal?))
        {
            this.CurrencyCode = currencyCode;
            this.DiscountAmount = discountAmount;
            this.PurchaseAmount = purchaseAmount;
        }
        
        /// <summary>
        /// The ISO-4217 three letter currency code the customer is viewing prices in
        /// </summary>
        /// <value>The ISO-4217 three letter currency code the customer is viewing prices in</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The amount of subtotal discount
        /// </summary>
        /// <value>The amount of subtotal discount</value>
        [DataMember(Name="discount_amount", EmitDefaultValue=false)]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// The purchase amount to qualify for subtotal discount and free shipping
        /// </summary>
        /// <value>The purchase amount to qualify for subtotal discount and free shipping</value>
        [DataMember(Name="purchase_amount", EmitDefaultValue=false)]
        public decimal? PurchaseAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponAmountOffSubtotalWithPurchase {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  PurchaseAmount: ").Append(PurchaseAmount).Append("\n");
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
            return this.Equals(input as CouponAmountOffSubtotalWithPurchase);
        }

        /// <summary>
        /// Returns true if CouponAmountOffSubtotalWithPurchase instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponAmountOffSubtotalWithPurchase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponAmountOffSubtotalWithPurchase input)
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
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && 
                (
                    this.PurchaseAmount == input.PurchaseAmount ||
                    (this.PurchaseAmount != null &&
                    this.PurchaseAmount.Equals(input.PurchaseAmount))
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
                if (this.DiscountAmount != null)
                    hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.PurchaseAmount != null)
                    hashCode = hashCode * 59 + this.PurchaseAmount.GetHashCode();
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
