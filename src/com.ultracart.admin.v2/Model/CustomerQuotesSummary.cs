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
    /// CustomerQuotesSummary
    /// </summary>
    [DataContract]
    public partial class CustomerQuotesSummary :  IEquatable<CustomerQuotesSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerQuotesSummary" /> class.
        /// </summary>
        /// <param name="FirstQuoteDts">First quote date.</param>
        /// <param name="LastQuoteDts">Last quote date.</param>
        /// <param name="QuoteCount">Total number of quote.</param>
        /// <param name="Total">Total amount associated with the quotes.</param>
        public CustomerQuotesSummary(string FirstQuoteDts = default(string), string LastQuoteDts = default(string), int? QuoteCount = default(int?), decimal? Total = default(decimal?))
        {
            this.FirstQuoteDts = FirstQuoteDts;
            this.LastQuoteDts = LastQuoteDts;
            this.QuoteCount = QuoteCount;
            this.Total = Total;
        }
        
        /// <summary>
        /// First quote date
        /// </summary>
        /// <value>First quote date</value>
        [DataMember(Name="first_quote_dts", EmitDefaultValue=false)]
        public string FirstQuoteDts { get; set; }

        /// <summary>
        /// Last quote date
        /// </summary>
        /// <value>Last quote date</value>
        [DataMember(Name="last_quote_dts", EmitDefaultValue=false)]
        public string LastQuoteDts { get; set; }

        /// <summary>
        /// Total number of quote
        /// </summary>
        /// <value>Total number of quote</value>
        [DataMember(Name="quote_count", EmitDefaultValue=false)]
        public int? QuoteCount { get; set; }

        /// <summary>
        /// Total amount associated with the quotes
        /// </summary>
        /// <value>Total amount associated with the quotes</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerQuotesSummary {\n");
            sb.Append("  FirstQuoteDts: ").Append(FirstQuoteDts).Append("\n");
            sb.Append("  LastQuoteDts: ").Append(LastQuoteDts).Append("\n");
            sb.Append("  QuoteCount: ").Append(QuoteCount).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as CustomerQuotesSummary);
        }

        /// <summary>
        /// Returns true if CustomerQuotesSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerQuotesSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerQuotesSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstQuoteDts == input.FirstQuoteDts ||
                    (this.FirstQuoteDts != null &&
                    this.FirstQuoteDts.Equals(input.FirstQuoteDts))
                ) && 
                (
                    this.LastQuoteDts == input.LastQuoteDts ||
                    (this.LastQuoteDts != null &&
                    this.LastQuoteDts.Equals(input.LastQuoteDts))
                ) && 
                (
                    this.QuoteCount == input.QuoteCount ||
                    (this.QuoteCount != null &&
                    this.QuoteCount.Equals(input.QuoteCount))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.FirstQuoteDts != null)
                    hashCode = hashCode * 59 + this.FirstQuoteDts.GetHashCode();
                if (this.LastQuoteDts != null)
                    hashCode = hashCode * 59 + this.LastQuoteDts.GetHashCode();
                if (this.QuoteCount != null)
                    hashCode = hashCode * 59 + this.QuoteCount.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
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
