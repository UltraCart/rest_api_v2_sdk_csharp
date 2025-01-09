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
    /// CouponFreeItemsWithMixMatchPurchase
    /// </summary>
    [DataContract]
    public partial class CouponFreeItemsWithMixMatchPurchase :  IEquatable<CouponFreeItemsWithMixMatchPurchase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponFreeItemsWithMixMatchPurchase" /> class.
        /// </summary>
        /// <param name="freeItem">The item id of the free item that will be received when the required mix and match group quantity is purchased..</param>
        /// <param name="freeQuantity">The quantity of free item that will be received..</param>
        /// <param name="limit">The limit of free items that may be received when purchasing multiple mix and match group items.</param>
        /// <param name="requiredPurchaseMixAndMatchGroup">Required mix and match group that must be purchased for coupon to be valid.</param>
        /// <param name="requiredPurchaseQuantity">Required quantity of mix and match group items that must be purchased for coupon to be valid.</param>
        public CouponFreeItemsWithMixMatchPurchase(string freeItem = default(string), int freeQuantity = default(int), int limit = default(int), string requiredPurchaseMixAndMatchGroup = default(string), int requiredPurchaseQuantity = default(int))
        {
            this.FreeItem = freeItem;
            this.FreeQuantity = freeQuantity;
            this.Limit = limit;
            this.RequiredPurchaseMixAndMatchGroup = requiredPurchaseMixAndMatchGroup;
            this.RequiredPurchaseQuantity = requiredPurchaseQuantity;
        }

        /// <summary>
        /// The item id of the free item that will be received when the required mix and match group quantity is purchased.
        /// </summary>
        /// <value>The item id of the free item that will be received when the required mix and match group quantity is purchased.</value>
        [DataMember(Name="free_item", EmitDefaultValue=false)]
        public string FreeItem { get; set; }

        /// <summary>
        /// The quantity of free item that will be received.
        /// </summary>
        /// <value>The quantity of free item that will be received.</value>
        [DataMember(Name="free_quantity", EmitDefaultValue=false)]
        public int FreeQuantity { get; set; }

        /// <summary>
        /// The limit of free items that may be received when purchasing multiple mix and match group items
        /// </summary>
        /// <value>The limit of free items that may be received when purchasing multiple mix and match group items</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int Limit { get; set; }

        /// <summary>
        /// Required mix and match group that must be purchased for coupon to be valid
        /// </summary>
        /// <value>Required mix and match group that must be purchased for coupon to be valid</value>
        [DataMember(Name="required_purchase_mix_and_match_group", EmitDefaultValue=false)]
        public string RequiredPurchaseMixAndMatchGroup { get; set; }

        /// <summary>
        /// Required quantity of mix and match group items that must be purchased for coupon to be valid
        /// </summary>
        /// <value>Required quantity of mix and match group items that must be purchased for coupon to be valid</value>
        [DataMember(Name="required_purchase_quantity", EmitDefaultValue=false)]
        public int RequiredPurchaseQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponFreeItemsWithMixMatchPurchase {\n");
            sb.Append("  FreeItem: ").Append(FreeItem).Append("\n");
            sb.Append("  FreeQuantity: ").Append(FreeQuantity).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  RequiredPurchaseMixAndMatchGroup: ").Append(RequiredPurchaseMixAndMatchGroup).Append("\n");
            sb.Append("  RequiredPurchaseQuantity: ").Append(RequiredPurchaseQuantity).Append("\n");
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
            return this.Equals(input as CouponFreeItemsWithMixMatchPurchase);
        }

        /// <summary>
        /// Returns true if CouponFreeItemsWithMixMatchPurchase instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponFreeItemsWithMixMatchPurchase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponFreeItemsWithMixMatchPurchase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FreeItem == input.FreeItem ||
                    (this.FreeItem != null &&
                    this.FreeItem.Equals(input.FreeItem))
                ) && 
                (
                    this.FreeQuantity == input.FreeQuantity ||
                    (this.FreeQuantity != null &&
                    this.FreeQuantity.Equals(input.FreeQuantity))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.RequiredPurchaseMixAndMatchGroup == input.RequiredPurchaseMixAndMatchGroup ||
                    (this.RequiredPurchaseMixAndMatchGroup != null &&
                    this.RequiredPurchaseMixAndMatchGroup.Equals(input.RequiredPurchaseMixAndMatchGroup))
                ) && 
                (
                    this.RequiredPurchaseQuantity == input.RequiredPurchaseQuantity ||
                    (this.RequiredPurchaseQuantity != null &&
                    this.RequiredPurchaseQuantity.Equals(input.RequiredPurchaseQuantity))
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
                if (this.FreeItem != null)
                    hashCode = hashCode * 59 + this.FreeItem.GetHashCode();
                if (this.FreeQuantity != null)
                    hashCode = hashCode * 59 + this.FreeQuantity.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.RequiredPurchaseMixAndMatchGroup != null)
                    hashCode = hashCode * 59 + this.RequiredPurchaseMixAndMatchGroup.GetHashCode();
                if (this.RequiredPurchaseQuantity != null)
                    hashCode = hashCode * 59 + this.RequiredPurchaseQuantity.GetHashCode();
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
