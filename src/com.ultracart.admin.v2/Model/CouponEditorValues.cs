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
    /// CouponEditorValues
    /// </summary>
    [DataContract]
    public partial class CouponEditorValues :  IEquatable<CouponEditorValues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponEditorValues" /> class.
        /// </summary>
        /// <param name="affiliates">affiliates.</param>
        /// <param name="couponTypes">coupon_types.</param>
        /// <param name="couponTypesForDisplay">coupon_types_for_display.</param>
        /// <param name="currencyCodes">currency_codes.</param>
        /// <param name="deprecatedThemes">deprecated_themes.</param>
        /// <param name="itemTags">Item tags.</param>
        /// <param name="mixAndMatchNames">mix_and_match_names.</param>
        /// <param name="shippingMethods">shipping_methods.</param>
        /// <param name="storefronts">storefronts.</param>
        /// <param name="usableBy">usable_by.</param>
        /// <param name="validWithOtherCoupons">valid_with_other_coupons.</param>
        public CouponEditorValues(List<SimpleValue> affiliates = default(List<SimpleValue>), List<string> couponTypes = default(List<string>), List<CouponType> couponTypesForDisplay = default(List<CouponType>), List<string> currencyCodes = default(List<string>), List<SimpleValue> deprecatedThemes = default(List<SimpleValue>), List<string> itemTags = default(List<string>), List<string> mixAndMatchNames = default(List<string>), List<string> shippingMethods = default(List<string>), List<SimpleValue> storefronts = default(List<SimpleValue>), List<SimpleValue> usableBy = default(List<SimpleValue>), List<string> validWithOtherCoupons = default(List<string>))
        {
            this.Affiliates = affiliates;
            this.CouponTypes = couponTypes;
            this.CouponTypesForDisplay = couponTypesForDisplay;
            this.CurrencyCodes = currencyCodes;
            this.DeprecatedThemes = deprecatedThemes;
            this.ItemTags = itemTags;
            this.MixAndMatchNames = mixAndMatchNames;
            this.ShippingMethods = shippingMethods;
            this.Storefronts = storefronts;
            this.UsableBy = usableBy;
            this.ValidWithOtherCoupons = validWithOtherCoupons;
        }

        /// <summary>
        /// affiliates
        /// </summary>
        /// <value>affiliates</value>
        [DataMember(Name="affiliates", EmitDefaultValue=false)]
        public List<SimpleValue> Affiliates { get; set; }

        /// <summary>
        /// coupon_types
        /// </summary>
        /// <value>coupon_types</value>
        [DataMember(Name="coupon_types", EmitDefaultValue=false)]
        public List<string> CouponTypes { get; set; }

        /// <summary>
        /// coupon_types_for_display
        /// </summary>
        /// <value>coupon_types_for_display</value>
        [DataMember(Name="coupon_types_for_display", EmitDefaultValue=false)]
        public List<CouponType> CouponTypesForDisplay { get; set; }

        /// <summary>
        /// currency_codes
        /// </summary>
        /// <value>currency_codes</value>
        [DataMember(Name="currency_codes", EmitDefaultValue=false)]
        public List<string> CurrencyCodes { get; set; }

        /// <summary>
        /// deprecated_themes
        /// </summary>
        /// <value>deprecated_themes</value>
        [DataMember(Name="deprecated_themes", EmitDefaultValue=false)]
        public List<SimpleValue> DeprecatedThemes { get; set; }

        /// <summary>
        /// Item tags
        /// </summary>
        /// <value>Item tags</value>
        [DataMember(Name="item_tags", EmitDefaultValue=false)]
        public List<string> ItemTags { get; set; }

        /// <summary>
        /// mix_and_match_names
        /// </summary>
        /// <value>mix_and_match_names</value>
        [DataMember(Name="mix_and_match_names", EmitDefaultValue=false)]
        public List<string> MixAndMatchNames { get; set; }

        /// <summary>
        /// shipping_methods
        /// </summary>
        /// <value>shipping_methods</value>
        [DataMember(Name="shipping_methods", EmitDefaultValue=false)]
        public List<string> ShippingMethods { get; set; }

        /// <summary>
        /// storefronts
        /// </summary>
        /// <value>storefronts</value>
        [DataMember(Name="storefronts", EmitDefaultValue=false)]
        public List<SimpleValue> Storefronts { get; set; }

        /// <summary>
        /// usable_by
        /// </summary>
        /// <value>usable_by</value>
        [DataMember(Name="usable_by", EmitDefaultValue=false)]
        public List<SimpleValue> UsableBy { get; set; }

        /// <summary>
        /// valid_with_other_coupons
        /// </summary>
        /// <value>valid_with_other_coupons</value>
        [DataMember(Name="valid_with_other_coupons", EmitDefaultValue=false)]
        public List<string> ValidWithOtherCoupons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponEditorValues {\n");
            sb.Append("  Affiliates: ").Append(Affiliates).Append("\n");
            sb.Append("  CouponTypes: ").Append(CouponTypes).Append("\n");
            sb.Append("  CouponTypesForDisplay: ").Append(CouponTypesForDisplay).Append("\n");
            sb.Append("  CurrencyCodes: ").Append(CurrencyCodes).Append("\n");
            sb.Append("  DeprecatedThemes: ").Append(DeprecatedThemes).Append("\n");
            sb.Append("  ItemTags: ").Append(ItemTags).Append("\n");
            sb.Append("  MixAndMatchNames: ").Append(MixAndMatchNames).Append("\n");
            sb.Append("  ShippingMethods: ").Append(ShippingMethods).Append("\n");
            sb.Append("  Storefronts: ").Append(Storefronts).Append("\n");
            sb.Append("  UsableBy: ").Append(UsableBy).Append("\n");
            sb.Append("  ValidWithOtherCoupons: ").Append(ValidWithOtherCoupons).Append("\n");
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
            return this.Equals(input as CouponEditorValues);
        }

        /// <summary>
        /// Returns true if CouponEditorValues instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponEditorValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponEditorValues input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Affiliates == input.Affiliates ||
                    this.Affiliates != null &&
                    input.Affiliates != null &&
                    this.Affiliates.SequenceEqual(input.Affiliates)
                ) && 
                (
                    this.CouponTypes == input.CouponTypes ||
                    this.CouponTypes != null &&
                    input.CouponTypes != null &&
                    this.CouponTypes.SequenceEqual(input.CouponTypes)
                ) && 
                (
                    this.CouponTypesForDisplay == input.CouponTypesForDisplay ||
                    this.CouponTypesForDisplay != null &&
                    input.CouponTypesForDisplay != null &&
                    this.CouponTypesForDisplay.SequenceEqual(input.CouponTypesForDisplay)
                ) && 
                (
                    this.CurrencyCodes == input.CurrencyCodes ||
                    this.CurrencyCodes != null &&
                    input.CurrencyCodes != null &&
                    this.CurrencyCodes.SequenceEqual(input.CurrencyCodes)
                ) && 
                (
                    this.DeprecatedThemes == input.DeprecatedThemes ||
                    this.DeprecatedThemes != null &&
                    input.DeprecatedThemes != null &&
                    this.DeprecatedThemes.SequenceEqual(input.DeprecatedThemes)
                ) && 
                (
                    this.ItemTags == input.ItemTags ||
                    this.ItemTags != null &&
                    input.ItemTags != null &&
                    this.ItemTags.SequenceEqual(input.ItemTags)
                ) && 
                (
                    this.MixAndMatchNames == input.MixAndMatchNames ||
                    this.MixAndMatchNames != null &&
                    input.MixAndMatchNames != null &&
                    this.MixAndMatchNames.SequenceEqual(input.MixAndMatchNames)
                ) && 
                (
                    this.ShippingMethods == input.ShippingMethods ||
                    this.ShippingMethods != null &&
                    input.ShippingMethods != null &&
                    this.ShippingMethods.SequenceEqual(input.ShippingMethods)
                ) && 
                (
                    this.Storefronts == input.Storefronts ||
                    this.Storefronts != null &&
                    input.Storefronts != null &&
                    this.Storefronts.SequenceEqual(input.Storefronts)
                ) && 
                (
                    this.UsableBy == input.UsableBy ||
                    this.UsableBy != null &&
                    input.UsableBy != null &&
                    this.UsableBy.SequenceEqual(input.UsableBy)
                ) && 
                (
                    this.ValidWithOtherCoupons == input.ValidWithOtherCoupons ||
                    this.ValidWithOtherCoupons != null &&
                    input.ValidWithOtherCoupons != null &&
                    this.ValidWithOtherCoupons.SequenceEqual(input.ValidWithOtherCoupons)
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
                if (this.Affiliates != null)
                    hashCode = hashCode * 59 + this.Affiliates.GetHashCode();
                if (this.CouponTypes != null)
                    hashCode = hashCode * 59 + this.CouponTypes.GetHashCode();
                if (this.CouponTypesForDisplay != null)
                    hashCode = hashCode * 59 + this.CouponTypesForDisplay.GetHashCode();
                if (this.CurrencyCodes != null)
                    hashCode = hashCode * 59 + this.CurrencyCodes.GetHashCode();
                if (this.DeprecatedThemes != null)
                    hashCode = hashCode * 59 + this.DeprecatedThemes.GetHashCode();
                if (this.ItemTags != null)
                    hashCode = hashCode * 59 + this.ItemTags.GetHashCode();
                if (this.MixAndMatchNames != null)
                    hashCode = hashCode * 59 + this.MixAndMatchNames.GetHashCode();
                if (this.ShippingMethods != null)
                    hashCode = hashCode * 59 + this.ShippingMethods.GetHashCode();
                if (this.Storefronts != null)
                    hashCode = hashCode * 59 + this.Storefronts.GetHashCode();
                if (this.UsableBy != null)
                    hashCode = hashCode * 59 + this.UsableBy.GetHashCode();
                if (this.ValidWithOtherCoupons != null)
                    hashCode = hashCode * 59 + this.ValidWithOtherCoupons.GetHashCode();
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
