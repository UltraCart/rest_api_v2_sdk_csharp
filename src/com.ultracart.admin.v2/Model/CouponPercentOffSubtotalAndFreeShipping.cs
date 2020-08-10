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
    /// CouponPercentOffSubtotalAndFreeShipping
    /// </summary>
    [DataContract]
    public partial class CouponPercentOffSubtotalAndFreeShipping :  IEquatable<CouponPercentOffSubtotalAndFreeShipping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponPercentOffSubtotalAndFreeShipping" /> class.
        /// </summary>
        /// <param name="discountPercent">The percentage of subtotal discount.</param>
        /// <param name="shippingMethods">One or more shipping methods that may be free.</param>
        public CouponPercentOffSubtotalAndFreeShipping(decimal? discountPercent = default(decimal?), List<string> shippingMethods = default(List<string>))
        {
            this.DiscountPercent = discountPercent;
            this.ShippingMethods = shippingMethods;
        }
        
        /// <summary>
        /// The percentage of subtotal discount
        /// </summary>
        /// <value>The percentage of subtotal discount</value>
        [DataMember(Name="discount_percent", EmitDefaultValue=false)]
        public decimal? DiscountPercent { get; set; }

        /// <summary>
        /// One or more shipping methods that may be free
        /// </summary>
        /// <value>One or more shipping methods that may be free</value>
        [DataMember(Name="shipping_methods", EmitDefaultValue=false)]
        public List<string> ShippingMethods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponPercentOffSubtotalAndFreeShipping {\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  ShippingMethods: ").Append(ShippingMethods).Append("\n");
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
            return this.Equals(input as CouponPercentOffSubtotalAndFreeShipping);
        }

        /// <summary>
        /// Returns true if CouponPercentOffSubtotalAndFreeShipping instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponPercentOffSubtotalAndFreeShipping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponPercentOffSubtotalAndFreeShipping input)
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
                    this.ShippingMethods == input.ShippingMethods ||
                    this.ShippingMethods != null &&
                    this.ShippingMethods.SequenceEqual(input.ShippingMethods)
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
                if (this.ShippingMethods != null)
                    hashCode = hashCode * 59 + this.ShippingMethods.GetHashCode();
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
