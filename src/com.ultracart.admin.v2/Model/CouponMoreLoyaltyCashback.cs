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
    /// CouponMoreLoyaltyCashback
    /// </summary>
    [DataContract]
    public partial class CouponMoreLoyaltyCashback :  IEquatable<CouponMoreLoyaltyCashback>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponMoreLoyaltyCashback" /> class.
        /// </summary>
        /// <param name="loyaltyCashback">The additional loyalty cashback.</param>
        public CouponMoreLoyaltyCashback(decimal loyaltyCashback = default(decimal))
        {
            this.LoyaltyCashback = loyaltyCashback;
        }

        /// <summary>
        /// The additional loyalty cashback
        /// </summary>
        /// <value>The additional loyalty cashback</value>
        [DataMember(Name="loyalty_cashback", EmitDefaultValue=false)]
        public decimal LoyaltyCashback { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponMoreLoyaltyCashback {\n");
            sb.Append("  LoyaltyCashback: ").Append(LoyaltyCashback).Append("\n");
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
            return this.Equals(input as CouponMoreLoyaltyCashback);
        }

        /// <summary>
        /// Returns true if CouponMoreLoyaltyCashback instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponMoreLoyaltyCashback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponMoreLoyaltyCashback input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoyaltyCashback == input.LoyaltyCashback ||
                    (this.LoyaltyCashback != null &&
                    this.LoyaltyCashback.Equals(input.LoyaltyCashback))
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
                if (this.LoyaltyCashback != null)
                    hashCode = hashCode * 59 + this.LoyaltyCashback.GetHashCode();
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
