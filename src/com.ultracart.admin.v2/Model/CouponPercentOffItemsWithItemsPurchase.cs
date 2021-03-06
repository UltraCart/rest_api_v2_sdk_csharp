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
    /// CouponPercentOffItemsWithItemsPurchase
    /// </summary>
    [DataContract]
    public partial class CouponPercentOffItemsWithItemsPurchase :  IEquatable<CouponPercentOffItemsWithItemsPurchase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponPercentOffItemsWithItemsPurchase" /> class.
        /// </summary>
        /// <param name="discountPercent">The percentage of subtotal discount.</param>
        /// <param name="items">A list of items which will receive a discount if one of the required purchase items is purchased..</param>
        /// <param name="limit">The (optional) maximum quantity of discounted items..</param>
        /// <param name="requiredPurchaseItems">Required items (at least one from the list) that must be purchased for coupon to be valid.</param>
        public CouponPercentOffItemsWithItemsPurchase(decimal? discountPercent = default(decimal?), List<string> items = default(List<string>), int? limit = default(int?), List<string> requiredPurchaseItems = default(List<string>))
        {
            this.DiscountPercent = discountPercent;
            this.Items = items;
            this.Limit = limit;
            this.RequiredPurchaseItems = requiredPurchaseItems;
        }
        
        /// <summary>
        /// The percentage of subtotal discount
        /// </summary>
        /// <value>The percentage of subtotal discount</value>
        [DataMember(Name="discount_percent", EmitDefaultValue=false)]
        public decimal? DiscountPercent { get; set; }

        /// <summary>
        /// A list of items which will receive a discount if one of the required purchase items is purchased.
        /// </summary>
        /// <value>A list of items which will receive a discount if one of the required purchase items is purchased.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// The (optional) maximum quantity of discounted items.
        /// </summary>
        /// <value>The (optional) maximum quantity of discounted items.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Required items (at least one from the list) that must be purchased for coupon to be valid
        /// </summary>
        /// <value>Required items (at least one from the list) that must be purchased for coupon to be valid</value>
        [DataMember(Name="required_purchase_items", EmitDefaultValue=false)]
        public List<string> RequiredPurchaseItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponPercentOffItemsWithItemsPurchase {\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  RequiredPurchaseItems: ").Append(RequiredPurchaseItems).Append("\n");
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
            return this.Equals(input as CouponPercentOffItemsWithItemsPurchase);
        }

        /// <summary>
        /// Returns true if CouponPercentOffItemsWithItemsPurchase instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponPercentOffItemsWithItemsPurchase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponPercentOffItemsWithItemsPurchase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiscountPercent == input.DiscountPercent ||
                    (this.DiscountPercent != null &&
                    this.DiscountPercent.Equals(input.DiscountPercent))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.RequiredPurchaseItems == input.RequiredPurchaseItems ||
                    this.RequiredPurchaseItems != null &&
                    this.RequiredPurchaseItems.SequenceEqual(input.RequiredPurchaseItems)
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
                if (this.DiscountPercent != null)
                    hashCode = hashCode * 59 + this.DiscountPercent.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.RequiredPurchaseItems != null)
                    hashCode = hashCode * 59 + this.RequiredPurchaseItems.GetHashCode();
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
