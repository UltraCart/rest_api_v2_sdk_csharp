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
    /// OrderQuote
    /// </summary>
    [DataContract]
    public partial class OrderQuote :  IEquatable<OrderQuote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderQuote" /> class.
        /// </summary>
        /// <param name="quoteExpirationDts">Expiration of quote at date/time.</param>
        /// <param name="quotedBy">Quoted by user.</param>
        /// <param name="quotedDts">Quoted on date/time.</param>
        public OrderQuote(string quoteExpirationDts = default(string), string quotedBy = default(string), string quotedDts = default(string))
        {
            this.QuoteExpirationDts = quoteExpirationDts;
            this.QuotedBy = quotedBy;
            this.QuotedDts = quotedDts;
        }
        
        /// <summary>
        /// Expiration of quote at date/time
        /// </summary>
        /// <value>Expiration of quote at date/time</value>
        [DataMember(Name="quote_expiration_dts", EmitDefaultValue=false)]
        public string QuoteExpirationDts { get; set; }

        /// <summary>
        /// Quoted by user
        /// </summary>
        /// <value>Quoted by user</value>
        [DataMember(Name="quoted_by", EmitDefaultValue=false)]
        public string QuotedBy { get; set; }

        /// <summary>
        /// Quoted on date/time
        /// </summary>
        /// <value>Quoted on date/time</value>
        [DataMember(Name="quoted_dts", EmitDefaultValue=false)]
        public string QuotedDts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderQuote {\n");
            sb.Append("  QuoteExpirationDts: ").Append(QuoteExpirationDts).Append("\n");
            sb.Append("  QuotedBy: ").Append(QuotedBy).Append("\n");
            sb.Append("  QuotedDts: ").Append(QuotedDts).Append("\n");
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
            return this.Equals(input as OrderQuote);
        }

        /// <summary>
        /// Returns true if OrderQuote instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderQuote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderQuote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuoteExpirationDts == input.QuoteExpirationDts ||
                    (this.QuoteExpirationDts != null &&
                    this.QuoteExpirationDts.Equals(input.QuoteExpirationDts))
                ) && 
                (
                    this.QuotedBy == input.QuotedBy ||
                    (this.QuotedBy != null &&
                    this.QuotedBy.Equals(input.QuotedBy))
                ) && 
                (
                    this.QuotedDts == input.QuotedDts ||
                    (this.QuotedDts != null &&
                    this.QuotedDts.Equals(input.QuotedDts))
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
                if (this.QuoteExpirationDts != null)
                    hashCode = hashCode * 59 + this.QuoteExpirationDts.GetHashCode();
                if (this.QuotedBy != null)
                    hashCode = hashCode * 59 + this.QuotedBy.GetHashCode();
                if (this.QuotedDts != null)
                    hashCode = hashCode * 59 + this.QuotedDts.GetHashCode();
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
