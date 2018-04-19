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
    /// ItemRestriction
    /// </summary>
    [DataContract]
    public partial class ItemRestriction :  IEquatable<ItemRestriction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRestriction" /> class.
        /// </summary>
        /// <param name="ExcludeCoupon">Exclude coupons.</param>
        /// <param name="ExcludeFromFreePromotion">Exclude from free promotion.</param>
        /// <param name="Items">Items.</param>
        /// <param name="MaximumQuantity">Maximum quantity.</param>
        /// <param name="MinimumQuantity">Minimum quantity (defaults to 1).</param>
        /// <param name="MultipleQuantity">Multiple of quantity.</param>
        /// <param name="OnePerCustomer">One per customer.</param>
        /// <param name="PurchaseSeparately">Purchase separately.</param>
        public ItemRestriction(bool? ExcludeCoupon = default(bool?), bool? ExcludeFromFreePromotion = default(bool?), List<ItemRestrictionItem> Items = default(List<ItemRestrictionItem>), int? MaximumQuantity = default(int?), int? MinimumQuantity = default(int?), int? MultipleQuantity = default(int?), bool? OnePerCustomer = default(bool?), bool? PurchaseSeparately = default(bool?))
        {
            this.ExcludeCoupon = ExcludeCoupon;
            this.ExcludeFromFreePromotion = ExcludeFromFreePromotion;
            this.Items = Items;
            this.MaximumQuantity = MaximumQuantity;
            this.MinimumQuantity = MinimumQuantity;
            this.MultipleQuantity = MultipleQuantity;
            this.OnePerCustomer = OnePerCustomer;
            this.PurchaseSeparately = PurchaseSeparately;
        }
        
        /// <summary>
        /// Exclude coupons
        /// </summary>
        /// <value>Exclude coupons</value>
        [DataMember(Name="exclude_coupon", EmitDefaultValue=false)]
        public bool? ExcludeCoupon { get; set; }

        /// <summary>
        /// Exclude from free promotion
        /// </summary>
        /// <value>Exclude from free promotion</value>
        [DataMember(Name="exclude_from_free_promotion", EmitDefaultValue=false)]
        public bool? ExcludeFromFreePromotion { get; set; }

        /// <summary>
        /// Items
        /// </summary>
        /// <value>Items</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ItemRestrictionItem> Items { get; set; }

        /// <summary>
        /// Maximum quantity
        /// </summary>
        /// <value>Maximum quantity</value>
        [DataMember(Name="maximum_quantity", EmitDefaultValue=false)]
        public int? MaximumQuantity { get; set; }

        /// <summary>
        /// Minimum quantity (defaults to 1)
        /// </summary>
        /// <value>Minimum quantity (defaults to 1)</value>
        [DataMember(Name="minimum_quantity", EmitDefaultValue=false)]
        public int? MinimumQuantity { get; set; }

        /// <summary>
        /// Multiple of quantity
        /// </summary>
        /// <value>Multiple of quantity</value>
        [DataMember(Name="multiple_quantity", EmitDefaultValue=false)]
        public int? MultipleQuantity { get; set; }

        /// <summary>
        /// One per customer
        /// </summary>
        /// <value>One per customer</value>
        [DataMember(Name="one_per_customer", EmitDefaultValue=false)]
        public bool? OnePerCustomer { get; set; }

        /// <summary>
        /// Purchase separately
        /// </summary>
        /// <value>Purchase separately</value>
        [DataMember(Name="purchase_separately", EmitDefaultValue=false)]
        public bool? PurchaseSeparately { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemRestriction {\n");
            sb.Append("  ExcludeCoupon: ").Append(ExcludeCoupon).Append("\n");
            sb.Append("  ExcludeFromFreePromotion: ").Append(ExcludeFromFreePromotion).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  MaximumQuantity: ").Append(MaximumQuantity).Append("\n");
            sb.Append("  MinimumQuantity: ").Append(MinimumQuantity).Append("\n");
            sb.Append("  MultipleQuantity: ").Append(MultipleQuantity).Append("\n");
            sb.Append("  OnePerCustomer: ").Append(OnePerCustomer).Append("\n");
            sb.Append("  PurchaseSeparately: ").Append(PurchaseSeparately).Append("\n");
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
            return this.Equals(input as ItemRestriction);
        }

        /// <summary>
        /// Returns true if ItemRestriction instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemRestriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemRestriction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludeCoupon == input.ExcludeCoupon ||
                    (this.ExcludeCoupon != null &&
                    this.ExcludeCoupon.Equals(input.ExcludeCoupon))
                ) && 
                (
                    this.ExcludeFromFreePromotion == input.ExcludeFromFreePromotion ||
                    (this.ExcludeFromFreePromotion != null &&
                    this.ExcludeFromFreePromotion.Equals(input.ExcludeFromFreePromotion))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.MaximumQuantity == input.MaximumQuantity ||
                    (this.MaximumQuantity != null &&
                    this.MaximumQuantity.Equals(input.MaximumQuantity))
                ) && 
                (
                    this.MinimumQuantity == input.MinimumQuantity ||
                    (this.MinimumQuantity != null &&
                    this.MinimumQuantity.Equals(input.MinimumQuantity))
                ) && 
                (
                    this.MultipleQuantity == input.MultipleQuantity ||
                    (this.MultipleQuantity != null &&
                    this.MultipleQuantity.Equals(input.MultipleQuantity))
                ) && 
                (
                    this.OnePerCustomer == input.OnePerCustomer ||
                    (this.OnePerCustomer != null &&
                    this.OnePerCustomer.Equals(input.OnePerCustomer))
                ) && 
                (
                    this.PurchaseSeparately == input.PurchaseSeparately ||
                    (this.PurchaseSeparately != null &&
                    this.PurchaseSeparately.Equals(input.PurchaseSeparately))
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
                if (this.ExcludeCoupon != null)
                    hashCode = hashCode * 59 + this.ExcludeCoupon.GetHashCode();
                if (this.ExcludeFromFreePromotion != null)
                    hashCode = hashCode * 59 + this.ExcludeFromFreePromotion.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.MaximumQuantity != null)
                    hashCode = hashCode * 59 + this.MaximumQuantity.GetHashCode();
                if (this.MinimumQuantity != null)
                    hashCode = hashCode * 59 + this.MinimumQuantity.GetHashCode();
                if (this.MultipleQuantity != null)
                    hashCode = hashCode * 59 + this.MultipleQuantity.GetHashCode();
                if (this.OnePerCustomer != null)
                    hashCode = hashCode * 59 + this.OnePerCustomer.GetHashCode();
                if (this.PurchaseSeparately != null)
                    hashCode = hashCode * 59 + this.PurchaseSeparately.GetHashCode();
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
