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
    /// OrderQuote
    /// </summary>
    [DataContract]
    public partial class OrderQuote :  IEquatable<OrderQuote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderQuote" /> class.
        /// </summary>
        /// <param name="QuoteExpirationDts">Expiration of quote at date/time.</param>
        /// <param name="QuotedBy">Quoted by user.</param>
        /// <param name="QuotedDts">Quoted on date/time.</param>
        public OrderQuote(string QuoteExpirationDts = default(string), string QuotedBy = default(string), string QuotedDts = default(string))
        {
            this.QuoteExpirationDts = QuoteExpirationDts;
            this.QuotedBy = QuotedBy;
            this.QuotedDts = QuotedDts;
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
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrderQuote);
        }

        /// <summary>
        /// Returns true if OrderQuote instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderQuote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderQuote other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.QuoteExpirationDts == other.QuoteExpirationDts ||
                    this.QuoteExpirationDts != null &&
                    this.QuoteExpirationDts.Equals(other.QuoteExpirationDts)
                ) && 
                (
                    this.QuotedBy == other.QuotedBy ||
                    this.QuotedBy != null &&
                    this.QuotedBy.Equals(other.QuotedBy)
                ) && 
                (
                    this.QuotedDts == other.QuotedDts ||
                    this.QuotedDts != null &&
                    this.QuotedDts.Equals(other.QuotedDts)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.QuoteExpirationDts != null)
                    hash = hash * 59 + this.QuoteExpirationDts.GetHashCode();
                if (this.QuotedBy != null)
                    hash = hash * 59 + this.QuotedBy.GetHashCode();
                if (this.QuotedDts != null)
                    hash = hash * 59 + this.QuotedDts.GetHashCode();
                return hash;
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