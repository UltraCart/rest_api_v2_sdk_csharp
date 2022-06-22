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
    /// CouponTierItemDiscount
    /// </summary>
    [DataContract]
    public partial class CouponTierItemDiscount :  IEquatable<CouponTierItemDiscount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponTierItemDiscount" /> class.
        /// </summary>
        /// <param name="discountAmount">The amount of subtotal discount.</param>
        /// <param name="items">A list of items which will receive this discount..</param>
        public CouponTierItemDiscount(decimal discountAmount = default(decimal), List<string> items = default(List<string>))
        {
            this.DiscountAmount = discountAmount;
            this.Items = items;
        }

        /// <summary>
        /// The amount of subtotal discount
        /// </summary>
        /// <value>The amount of subtotal discount</value>
        [DataMember(Name="discount_amount", EmitDefaultValue=false)]
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// A list of items which will receive this discount.
        /// </summary>
        /// <value>A list of items which will receive this discount.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponTierItemDiscount {\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
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
            return this.Equals(input as CouponTierItemDiscount);
        }

        /// <summary>
        /// Returns true if CouponTierItemDiscount instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponTierItemDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponTierItemDiscount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
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
                if (this.DiscountAmount != null)
                    hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
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
