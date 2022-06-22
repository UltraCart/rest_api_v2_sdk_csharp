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
    /// CouponDiscountItemWithItemPurchase
    /// </summary>
    [DataContract]
    public partial class CouponDiscountItemWithItemPurchase :  IEquatable<CouponDiscountItemWithItemPurchase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponDiscountItemWithItemPurchase" /> class.
        /// </summary>
        /// <param name="currencyCode">The ISO-4217 three letter currency code the customer is viewing prices in.</param>
        /// <param name="discountItem">The item that will be sold at the discount_price when required_purchase_item is purchased..</param>
        /// <param name="discountPrice">The price (unit cost) of the discounted item.</param>
        /// <param name="limit">The (optional) maximum quantity of discounted items..</param>
        /// <param name="requiredPurchaseItem">The item that must be purchased for the discount to be applied to the discount item..</param>
        public CouponDiscountItemWithItemPurchase(string currencyCode = default(string), string discountItem = default(string), decimal discountPrice = default(decimal), int limit = default(int), string requiredPurchaseItem = default(string))
        {
            this.CurrencyCode = currencyCode;
            this.DiscountItem = discountItem;
            this.DiscountPrice = discountPrice;
            this.Limit = limit;
            this.RequiredPurchaseItem = requiredPurchaseItem;
        }

        /// <summary>
        /// The ISO-4217 three letter currency code the customer is viewing prices in
        /// </summary>
        /// <value>The ISO-4217 three letter currency code the customer is viewing prices in</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The item that will be sold at the discount_price when required_purchase_item is purchased.
        /// </summary>
        /// <value>The item that will be sold at the discount_price when required_purchase_item is purchased.</value>
        [DataMember(Name="discount_item", EmitDefaultValue=false)]
        public string DiscountItem { get; set; }

        /// <summary>
        /// The price (unit cost) of the discounted item
        /// </summary>
        /// <value>The price (unit cost) of the discounted item</value>
        [DataMember(Name="discount_price", EmitDefaultValue=false)]
        public decimal DiscountPrice { get; set; }

        /// <summary>
        /// The (optional) maximum quantity of discounted items.
        /// </summary>
        /// <value>The (optional) maximum quantity of discounted items.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int Limit { get; set; }

        /// <summary>
        /// The item that must be purchased for the discount to be applied to the discount item.
        /// </summary>
        /// <value>The item that must be purchased for the discount to be applied to the discount item.</value>
        [DataMember(Name="required_purchase_item", EmitDefaultValue=false)]
        public string RequiredPurchaseItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponDiscountItemWithItemPurchase {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DiscountItem: ").Append(DiscountItem).Append("\n");
            sb.Append("  DiscountPrice: ").Append(DiscountPrice).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  RequiredPurchaseItem: ").Append(RequiredPurchaseItem).Append("\n");
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
            return this.Equals(input as CouponDiscountItemWithItemPurchase);
        }

        /// <summary>
        /// Returns true if CouponDiscountItemWithItemPurchase instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponDiscountItemWithItemPurchase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponDiscountItemWithItemPurchase input)
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
                    this.DiscountItem == input.DiscountItem ||
                    (this.DiscountItem != null &&
                    this.DiscountItem.Equals(input.DiscountItem))
                ) && 
                (
                    this.DiscountPrice == input.DiscountPrice ||
                    (this.DiscountPrice != null &&
                    this.DiscountPrice.Equals(input.DiscountPrice))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.RequiredPurchaseItem == input.RequiredPurchaseItem ||
                    (this.RequiredPurchaseItem != null &&
                    this.RequiredPurchaseItem.Equals(input.RequiredPurchaseItem))
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
                if (this.DiscountItem != null)
                    hashCode = hashCode * 59 + this.DiscountItem.GetHashCode();
                if (this.DiscountPrice != null)
                    hashCode = hashCode * 59 + this.DiscountPrice.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.RequiredPurchaseItem != null)
                    hashCode = hashCode * 59 + this.RequiredPurchaseItem.GetHashCode();
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
