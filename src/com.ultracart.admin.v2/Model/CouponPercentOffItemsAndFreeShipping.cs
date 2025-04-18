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
    /// CouponPercentOffItemsAndFreeShipping
    /// </summary>
    [DataContract]
    public partial class CouponPercentOffItemsAndFreeShipping :  IEquatable<CouponPercentOffItemsAndFreeShipping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponPercentOffItemsAndFreeShipping" /> class.
        /// </summary>
        /// <param name="discountPercent">The percentage of subtotal discount.</param>
        /// <param name="excludedItemTags">A list of item tags which cannot be discounted..</param>
        /// <param name="excludedItems">A list of items which cannot be discounted..</param>
        /// <param name="itemTags">An optional list of item tags which will receive a discount.  If blank, discount applies to all items except excluded items..</param>
        /// <param name="items">An optional list of items which will receive a discount.  If blank, discount applies to all items except excluded items..</param>
        public CouponPercentOffItemsAndFreeShipping(decimal discountPercent = default(decimal), List<string> excludedItemTags = default(List<string>), List<string> excludedItems = default(List<string>), List<string> itemTags = default(List<string>), List<string> items = default(List<string>))
        {
            this.DiscountPercent = discountPercent;
            this.ExcludedItemTags = excludedItemTags;
            this.ExcludedItems = excludedItems;
            this.ItemTags = itemTags;
            this.Items = items;
        }

        /// <summary>
        /// The percentage of subtotal discount
        /// </summary>
        /// <value>The percentage of subtotal discount</value>
        [DataMember(Name="discount_percent", EmitDefaultValue=false)]
        public decimal DiscountPercent { get; set; }

        /// <summary>
        /// A list of item tags which cannot be discounted.
        /// </summary>
        /// <value>A list of item tags which cannot be discounted.</value>
        [DataMember(Name="excluded_item_tags", EmitDefaultValue=false)]
        public List<string> ExcludedItemTags { get; set; }

        /// <summary>
        /// A list of items which cannot be discounted.
        /// </summary>
        /// <value>A list of items which cannot be discounted.</value>
        [DataMember(Name="excluded_items", EmitDefaultValue=false)]
        public List<string> ExcludedItems { get; set; }

        /// <summary>
        /// An optional list of item tags which will receive a discount.  If blank, discount applies to all items except excluded items.
        /// </summary>
        /// <value>An optional list of item tags which will receive a discount.  If blank, discount applies to all items except excluded items.</value>
        [DataMember(Name="item_tags", EmitDefaultValue=false)]
        public List<string> ItemTags { get; set; }

        /// <summary>
        /// An optional list of items which will receive a discount.  If blank, discount applies to all items except excluded items.
        /// </summary>
        /// <value>An optional list of items which will receive a discount.  If blank, discount applies to all items except excluded items.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponPercentOffItemsAndFreeShipping {\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  ExcludedItemTags: ").Append(ExcludedItemTags).Append("\n");
            sb.Append("  ExcludedItems: ").Append(ExcludedItems).Append("\n");
            sb.Append("  ItemTags: ").Append(ItemTags).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as CouponPercentOffItemsAndFreeShipping);
        }

        /// <summary>
        /// Returns true if CouponPercentOffItemsAndFreeShipping instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponPercentOffItemsAndFreeShipping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponPercentOffItemsAndFreeShipping input)
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
                    this.ExcludedItemTags == input.ExcludedItemTags ||
                    this.ExcludedItemTags != null &&
                    input.ExcludedItemTags != null &&
                    this.ExcludedItemTags.SequenceEqual(input.ExcludedItemTags)
                ) && 
                (
                    this.ExcludedItems == input.ExcludedItems ||
                    this.ExcludedItems != null &&
                    input.ExcludedItems != null &&
                    this.ExcludedItems.SequenceEqual(input.ExcludedItems)
                ) && 
                (
                    this.ItemTags == input.ItemTags ||
                    this.ItemTags != null &&
                    input.ItemTags != null &&
                    this.ItemTags.SequenceEqual(input.ItemTags)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.ExcludedItemTags != null)
                    hashCode = hashCode * 59 + this.ExcludedItemTags.GetHashCode();
                if (this.ExcludedItems != null)
                    hashCode = hashCode * 59 + this.ExcludedItems.GetHashCode();
                if (this.ItemTags != null)
                    hashCode = hashCode * 59 + this.ItemTags.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
