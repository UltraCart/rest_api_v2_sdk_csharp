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
    /// CouponsRequest
    /// </summary>
    [DataContract]
    public partial class CouponsRequest :  IEquatable<CouponsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponsRequest" /> class.
        /// </summary>
        /// <param name="coupons">coupons.</param>
        public CouponsRequest(List<Coupon> coupons = default(List<Coupon>))
        {
            this.Coupons = coupons;
        }
        
        /// <summary>
        /// coupons
        /// </summary>
        /// <value>coupons</value>
        [DataMember(Name="coupons", EmitDefaultValue=false)]
        public List<Coupon> Coupons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponsRequest {\n");
            sb.Append("  Coupons: ").Append(Coupons).Append("\n");
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
            return this.Equals(input as CouponsRequest);
        }

        /// <summary>
        /// Returns true if CouponsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Coupons == input.Coupons ||
                    this.Coupons != null &&
                    this.Coupons.SequenceEqual(input.Coupons)
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
                if (this.Coupons != null)
                    hashCode = hashCode * 59 + this.Coupons.GetHashCode();
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
