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
    /// CouponPercentOffItemsAndFreeShipping
    /// </summary>
    [DataContract]
    public partial class CouponPercentOffItemsAndFreeShipping :  IEquatable<CouponPercentOffItemsAndFreeShipping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponPercentOffItemsAndFreeShipping" /> class.
        /// </summary>
        /// <param name="DiscountPercent">The percentage of subtotal discount.</param>
        /// <param name="ExcludedItems">A list of items which cannot be discounted..</param>
        /// <param name="Items">An optional list of items which will receive a discount.  If blank, discount applies to all items except excluded items..</param>
        public CouponPercentOffItemsAndFreeShipping(decimal? DiscountPercent = default(decimal?), List<string> ExcludedItems = default(List<string>), List<string> Items = default(List<string>))
        {
            this.DiscountPercent = DiscountPercent;
            this.ExcludedItems = ExcludedItems;
            this.Items = Items;
        }
        
        /// <summary>
        /// The percentage of subtotal discount
        /// </summary>
        /// <value>The percentage of subtotal discount</value>
        [DataMember(Name="discount_percent", EmitDefaultValue=false)]
        public decimal? DiscountPercent { get; set; }

        /// <summary>
        /// A list of items which cannot be discounted.
        /// </summary>
        /// <value>A list of items which cannot be discounted.</value>
        [DataMember(Name="excluded_items", EmitDefaultValue=false)]
        public List<string> ExcludedItems { get; set; }

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
            sb.Append("  ExcludedItems: ").Append(ExcludedItems).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
                    this.ExcludedItems == input.ExcludedItems ||
                    this.ExcludedItems != null &&
                    this.ExcludedItems.SequenceEqual(input.ExcludedItems)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
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
                if (this.ExcludedItems != null)
                    hashCode = hashCode * 59 + this.ExcludedItems.GetHashCode();
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