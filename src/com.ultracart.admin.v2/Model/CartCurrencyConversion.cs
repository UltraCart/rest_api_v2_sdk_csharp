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
    /// CartCurrencyConversion
    /// </summary>
    [DataContract]
    public partial class CartCurrencyConversion :  IEquatable<CartCurrencyConversion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartCurrencyConversion" /> class.
        /// </summary>
        /// <param name="baseCurrencyCode">Base currency code for this merchant.</param>
        /// <param name="currencies">Conversion information for 1 unit of base currency to target currencies.</param>
        public CartCurrencyConversion(string baseCurrencyCode = default(string), List<Currency> currencies = default(List<Currency>))
        {
            this.BaseCurrencyCode = baseCurrencyCode;
            this.Currencies = currencies;
        }
        
        /// <summary>
        /// Base currency code for this merchant
        /// </summary>
        /// <value>Base currency code for this merchant</value>
        [DataMember(Name="base_currency_Code", EmitDefaultValue=false)]
        public string BaseCurrencyCode { get; set; }

        /// <summary>
        /// Conversion information for 1 unit of base currency to target currencies
        /// </summary>
        /// <value>Conversion information for 1 unit of base currency to target currencies</value>
        [DataMember(Name="currencies", EmitDefaultValue=false)]
        public List<Currency> Currencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartCurrencyConversion {\n");
            sb.Append("  BaseCurrencyCode: ").Append(BaseCurrencyCode).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
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
            return this.Equals(input as CartCurrencyConversion);
        }

        /// <summary>
        /// Returns true if CartCurrencyConversion instances are equal
        /// </summary>
        /// <param name="input">Instance of CartCurrencyConversion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartCurrencyConversion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseCurrencyCode == input.BaseCurrencyCode ||
                    (this.BaseCurrencyCode != null &&
                    this.BaseCurrencyCode.Equals(input.BaseCurrencyCode))
                ) && 
                (
                    this.Currencies == input.Currencies ||
                    this.Currencies != null &&
                    this.Currencies.SequenceEqual(input.Currencies)
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
                if (this.BaseCurrencyCode != null)
                    hashCode = hashCode * 59 + this.BaseCurrencyCode.GetHashCode();
                if (this.Currencies != null)
                    hashCode = hashCode * 59 + this.Currencies.GetHashCode();
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
