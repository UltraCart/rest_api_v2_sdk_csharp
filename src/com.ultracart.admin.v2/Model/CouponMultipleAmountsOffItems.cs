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
    /// CouponMultipleAmountsOffItems
    /// </summary>
    [DataContract]
    public partial class CouponMultipleAmountsOffItems :  IEquatable<CouponMultipleAmountsOffItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponMultipleAmountsOffItems" /> class.
        /// </summary>
        /// <param name="discounts">A list of item discounts..</param>
        /// <param name="limit">The (optional) maximum quantity of items that may receive a discount..</param>
        public CouponMultipleAmountsOffItems(List<CouponTierItemDiscount> discounts = default(List<CouponTierItemDiscount>), int? limit = default(int?))
        {
            this.Discounts = discounts;
            this.Limit = limit;
        }
        
        /// <summary>
        /// A list of item discounts.
        /// </summary>
        /// <value>A list of item discounts.</value>
        [DataMember(Name="discounts", EmitDefaultValue=false)]
        public List<CouponTierItemDiscount> Discounts { get; set; }

        /// <summary>
        /// The (optional) maximum quantity of items that may receive a discount.
        /// </summary>
        /// <value>The (optional) maximum quantity of items that may receive a discount.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponMultipleAmountsOffItems {\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as CouponMultipleAmountsOffItems);
        }

        /// <summary>
        /// Returns true if CouponMultipleAmountsOffItems instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponMultipleAmountsOffItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponMultipleAmountsOffItems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Discounts == input.Discounts ||
                    this.Discounts != null &&
                    this.Discounts.SequenceEqual(input.Discounts)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.Discounts != null)
                    hashCode = hashCode * 59 + this.Discounts.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
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
