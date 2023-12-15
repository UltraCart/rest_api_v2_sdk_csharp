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
    /// CouponTieredPercentOffSubtotalBasedOnMSRP
    /// </summary>
    [DataContract]
    public partial class CouponTieredPercentOffSubtotalBasedOnMSRP :  IEquatable<CouponTieredPercentOffSubtotalBasedOnMSRP>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponTieredPercentOffSubtotalBasedOnMSRP" /> class.
        /// </summary>
        /// <param name="items">An optional list of items of which a quantity of one or many must be purchased for coupon to be valid.  If empty, all items apply toward subtotal amount..</param>
        /// <param name="tiers">A list of discount tiers..</param>
        public CouponTieredPercentOffSubtotalBasedOnMSRP(List<string> items = default(List<string>), List<CouponTierPercent> tiers = default(List<CouponTierPercent>))
        {
            this.Items = items;
            this.Tiers = tiers;
        }
        
        /// <summary>
        /// An optional list of items of which a quantity of one or many must be purchased for coupon to be valid.  If empty, all items apply toward subtotal amount.
        /// </summary>
        /// <value>An optional list of items of which a quantity of one or many must be purchased for coupon to be valid.  If empty, all items apply toward subtotal amount.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// A list of discount tiers.
        /// </summary>
        /// <value>A list of discount tiers.</value>
        [DataMember(Name="tiers", EmitDefaultValue=false)]
        public List<CouponTierPercent> Tiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponTieredPercentOffSubtotalBasedOnMSRP {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CouponTieredPercentOffSubtotalBasedOnMSRP);
        }

        /// <summary>
        /// Returns true if CouponTieredPercentOffSubtotalBasedOnMSRP instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponTieredPercentOffSubtotalBasedOnMSRP to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponTieredPercentOffSubtotalBasedOnMSRP input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Tiers == input.Tiers ||
                    this.Tiers != null &&
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
