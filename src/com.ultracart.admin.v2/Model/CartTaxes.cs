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
    /// CartTaxes
    /// </summary>
    [DataContract]
    public partial class CartTaxes :  IEquatable<CartTaxes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartTaxes" /> class.
        /// </summary>
        /// <param name="County">Tax county if the state requires it..</param>
        /// <param name="Exempt">True if tax exempt.</param>
        /// <param name="Rate">Tax rate.</param>
        public CartTaxes(string County = default(string), bool? Exempt = default(bool?), decimal? Rate = default(decimal?))
        {
            this.County = County;
            this.Exempt = Exempt;
            this.Rate = Rate;
        }
        
        /// <summary>
        /// Tax county if the state requires it.
        /// </summary>
        /// <value>Tax county if the state requires it.</value>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// True if tax exempt
        /// </summary>
        /// <value>True if tax exempt</value>
        [DataMember(Name="exempt", EmitDefaultValue=false)]
        public bool? Exempt { get; set; }

        /// <summary>
        /// Tax rate
        /// </summary>
        /// <value>Tax rate</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public decimal? Rate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartTaxes {\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  Exempt: ").Append(Exempt).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
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
            return this.Equals(input as CartTaxes);
        }

        /// <summary>
        /// Returns true if CartTaxes instances are equal
        /// </summary>
        /// <param name="input">Instance of CartTaxes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartTaxes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.Exempt == input.Exempt ||
                    (this.Exempt != null &&
                    this.Exempt.Equals(input.Exempt))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
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
                if (this.County != null)
                    hashCode = hashCode * 59 + this.County.GetHashCode();
                if (this.Exempt != null)
                    hashCode = hashCode * 59 + this.Exempt.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
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
            // County (string) maxLength
            if(this.County != null && this.County.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for County, length must be less than 32.", new [] { "County" });
            }

            yield break;
        }
    }

}
