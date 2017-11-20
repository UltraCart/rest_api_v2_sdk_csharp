/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
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
    /// CouponFreeItemWithSubtotal
    /// </summary>
    [DataContract]
    public partial class CouponFreeItemWithSubtotal :  IEquatable<CouponFreeItemWithSubtotal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponFreeItemWithSubtotal" /> class.
        /// </summary>
        /// <param name="CurrencyCode">The ISO-4217 three letter currency code the customer is viewing prices in.</param>
        /// <param name="Items">A list of items that are eligible for this discount_price..</param>
        /// <param name="Limit">The limit of free items that may be received when purchasing multiple items.</param>
        /// <param name="SubtotalAmount">The amount of subtotal required to receive the discount percent.</param>
        public CouponFreeItemWithSubtotal(string CurrencyCode = default(string), List<string> Items = default(List<string>), int? Limit = default(int?), decimal? SubtotalAmount = default(decimal?))
        {
            this.CurrencyCode = CurrencyCode;
            this.Items = Items;
            this.Limit = Limit;
            this.SubtotalAmount = SubtotalAmount;
        }
        
        /// <summary>
        /// The ISO-4217 three letter currency code the customer is viewing prices in
        /// </summary>
        /// <value>The ISO-4217 three letter currency code the customer is viewing prices in</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// A list of items that are eligible for this discount_price.
        /// </summary>
        /// <value>A list of items that are eligible for this discount_price.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// The limit of free items that may be received when purchasing multiple items
        /// </summary>
        /// <value>The limit of free items that may be received when purchasing multiple items</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The amount of subtotal required to receive the discount percent
        /// </summary>
        /// <value>The amount of subtotal required to receive the discount percent</value>
        [DataMember(Name="subtotal_amount", EmitDefaultValue=false)]
        public decimal? SubtotalAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponFreeItemWithSubtotal {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  SubtotalAmount: ").Append(SubtotalAmount).Append("\n");
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
            return this.Equals(input as CouponFreeItemWithSubtotal);
        }

        /// <summary>
        /// Returns true if CouponFreeItemWithSubtotal instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponFreeItemWithSubtotal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponFreeItemWithSubtotal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.SubtotalAmount == input.SubtotalAmount ||
                    (this.SubtotalAmount != null &&
                    this.SubtotalAmount.Equals(input.SubtotalAmount))
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
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SubtotalAmount != null)
                    hashCode = hashCode * 59 + this.SubtotalAmount.GetHashCode();
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
            // CurrencyCode (string) maxLength
            if(this.CurrencyCode != null && this.CurrencyCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrencyCode, length must be less than 3.", new [] { "CurrencyCode" });
            }

            yield break;
        }
    }

}
