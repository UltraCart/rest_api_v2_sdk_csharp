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
    /// CouponTieredPercentOffShipping
    /// </summary>
    [DataContract]
    public partial class CouponTieredPercentOffShipping :  IEquatable<CouponTieredPercentOffShipping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponTieredPercentOffShipping" /> class.
        /// </summary>
        /// <param name="ShippingMethods">One or more shipping methods that may receive this discount.</param>
        /// <param name="Tiers">A list of discount tiers..</param>
        public CouponTieredPercentOffShipping(List<string> ShippingMethods = default(List<string>), List<CouponTierPercent> Tiers = default(List<CouponTierPercent>))
        {
            this.ShippingMethods = ShippingMethods;
            this.Tiers = Tiers;
        }
        
        /// <summary>
        /// One or more shipping methods that may receive this discount
        /// </summary>
        /// <value>One or more shipping methods that may receive this discount</value>
        [DataMember(Name="shipping_methods", EmitDefaultValue=false)]
        public List<string> ShippingMethods { get; set; }

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
            sb.Append("class CouponTieredPercentOffShipping {\n");
            sb.Append("  ShippingMethods: ").Append(ShippingMethods).Append("\n");
            sb.Append("  Tiers: ").Append(Tiers).Append("\n");
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
            return this.Equals(input as CouponTieredPercentOffShipping);
        }

        /// <summary>
        /// Returns true if CouponTieredPercentOffShipping instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponTieredPercentOffShipping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponTieredPercentOffShipping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShippingMethods == input.ShippingMethods ||
                    this.ShippingMethods != null &&
                    this.ShippingMethods.SequenceEqual(input.ShippingMethods)
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
                if (this.ShippingMethods != null)
                    hashCode = hashCode * 59 + this.ShippingMethods.GetHashCode();
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
