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
    /// CouponFreeItemWithItemPurchaseAndFreeShipping
    /// </summary>
    [DataContract]
    public partial class CouponFreeItemWithItemPurchaseAndFreeShipping :  IEquatable<CouponFreeItemWithItemPurchaseAndFreeShipping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponFreeItemWithItemPurchaseAndFreeShipping" /> class.
        /// </summary>
        /// <param name="items">A list of free items which will receive a discount if one of the required purchase items is purchased..</param>
        /// <param name="limit">The (optional) maximum quantity of discounted items.  Free shipping will apply to all units of the free item ids though..</param>
        /// <param name="matchRequiredPurchaseItemToFreeItem">If true then the free item is matched 1:1 with the free item in the list..</param>
        /// <param name="requiredPurchaseItems">Required items (at least one from the list) that must be purchased for coupon to be valid.</param>
        public CouponFreeItemWithItemPurchaseAndFreeShipping(List<string> items = default(List<string>), int limit = default(int), bool matchRequiredPurchaseItemToFreeItem = default(bool), List<string> requiredPurchaseItems = default(List<string>))
        {
            this.Items = items;
            this.Limit = limit;
            this.MatchRequiredPurchaseItemToFreeItem = matchRequiredPurchaseItemToFreeItem;
            this.RequiredPurchaseItems = requiredPurchaseItems;
        }

        /// <summary>
        /// A list of free items which will receive a discount if one of the required purchase items is purchased.
        /// </summary>
        /// <value>A list of free items which will receive a discount if one of the required purchase items is purchased.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// The (optional) maximum quantity of discounted items.  Free shipping will apply to all units of the free item ids though.
        /// </summary>
        /// <value>The (optional) maximum quantity of discounted items.  Free shipping will apply to all units of the free item ids though.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int Limit { get; set; }

        /// <summary>
        /// If true then the free item is matched 1:1 with the free item in the list.
        /// </summary>
        /// <value>If true then the free item is matched 1:1 with the free item in the list.</value>
        [DataMember(Name="match_required_purchase_item_to_free_item", EmitDefaultValue=false)]
        public bool MatchRequiredPurchaseItemToFreeItem { get; set; }

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
            sb.Append("class CouponFreeItemWithItemPurchaseAndFreeShipping {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  MatchRequiredPurchaseItemToFreeItem: ").Append(MatchRequiredPurchaseItemToFreeItem).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CouponFreeItemWithItemPurchaseAndFreeShipping);
        }

        /// <summary>
        /// Returns true if CouponFreeItemWithItemPurchaseAndFreeShipping instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponFreeItemWithItemPurchaseAndFreeShipping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponFreeItemWithItemPurchaseAndFreeShipping input)
        {
            if (input == null)
                return false;

            return 
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
                    this.MatchRequiredPurchaseItemToFreeItem == input.MatchRequiredPurchaseItemToFreeItem ||
                    (this.MatchRequiredPurchaseItemToFreeItem != null &&
                    this.MatchRequiredPurchaseItemToFreeItem.Equals(input.MatchRequiredPurchaseItemToFreeItem))
                ) && 
                (
                    this.RequiredPurchaseItems == input.RequiredPurchaseItems ||
                    this.RequiredPurchaseItems != null &&
                    input.RequiredPurchaseItems != null &&
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.MatchRequiredPurchaseItemToFreeItem != null)
                    hashCode = hashCode * 59 + this.MatchRequiredPurchaseItemToFreeItem.GetHashCode();
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
