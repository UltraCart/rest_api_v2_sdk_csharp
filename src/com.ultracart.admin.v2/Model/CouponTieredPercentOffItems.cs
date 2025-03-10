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
    /// CouponTieredPercentOffItems
    /// </summary>
    [DataContract]
    public partial class CouponTieredPercentOffItems :  IEquatable<CouponTieredPercentOffItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponTieredPercentOffItems" /> class.
        /// </summary>
        /// <param name="itemTags">An optional list of item tags which will receive a discount.  If blank, discount applies to all items except excluded items..</param>
        /// <param name="items">A list of items of which at least one must be purchased for coupon to be valid..</param>
        /// <param name="limit">The (optional) maximum quantity of discounted items..</param>
        /// <param name="tiers">A list of discount tiers..</param>
        public CouponTieredPercentOffItems(List<string> itemTags = default(List<string>), List<string> items = default(List<string>), decimal limit = default(decimal), List<CouponTierQuantityPercent> tiers = default(List<CouponTierQuantityPercent>))
        {
            this.ItemTags = itemTags;
            this.Items = items;
            this.Limit = limit;
            this.Tiers = tiers;
        }

        /// <summary>
        /// An optional list of item tags which will receive a discount.  If blank, discount applies to all items except excluded items.
        /// </summary>
        /// <value>An optional list of item tags which will receive a discount.  If blank, discount applies to all items except excluded items.</value>
        [DataMember(Name="item_tags", EmitDefaultValue=false)]
        public List<string> ItemTags { get; set; }

        /// <summary>
        /// A list of items of which at least one must be purchased for coupon to be valid.
        /// </summary>
        /// <value>A list of items of which at least one must be purchased for coupon to be valid.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// The (optional) maximum quantity of discounted items.
        /// </summary>
        /// <value>The (optional) maximum quantity of discounted items.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public decimal Limit { get; set; }

        /// <summary>
        /// A list of discount tiers.
        /// </summary>
        /// <value>A list of discount tiers.</value>
        [DataMember(Name="tiers", EmitDefaultValue=false)]
        public List<CouponTierQuantityPercent> Tiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponTieredPercentOffItems {\n");
            sb.Append("  ItemTags: ").Append(ItemTags).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Tiers: ").Append(Tiers).Append("\n");
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
            return this.Equals(input as CouponTieredPercentOffItems);
        }

        /// <summary>
        /// Returns true if CouponTieredPercentOffItems instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponTieredPercentOffItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponTieredPercentOffItems input)
        {
            if (input == null)
                return false;

            return 
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
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Tiers == input.Tiers ||
                    this.Tiers != null &&
                    input.Tiers != null &&
                    this.Tiers.SequenceEqual(input.Tiers)
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
                if (this.ItemTags != null)
                    hashCode = hashCode * 59 + this.ItemTags.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Tiers != null)
                    hashCode = hashCode * 59 + this.Tiers.GetHashCode();
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
