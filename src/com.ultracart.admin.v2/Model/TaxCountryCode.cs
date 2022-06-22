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
    /// TaxCountryCode
    /// </summary>
    [DataContract]
    public partial class TaxCountryCode :  IEquatable<TaxCountryCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCountryCode" /> class.
        /// </summary>
        /// <param name="accountingCode">Accounting code for programs such as QuickBooks.</param>
        /// <param name="countryCode">Country code (2 characters.</param>
        /// <param name="countryName">Country name.</param>
        /// <param name="taxRate">Tax Rate.</param>
        /// <param name="taxRateFormatted">Tax rate formatted.</param>
        public TaxCountryCode(string accountingCode = default(string), string countryCode = default(string), string countryName = default(string), decimal taxRate = default(decimal), string taxRateFormatted = default(string))
        {
            this.AccountingCode = accountingCode;
            this.CountryCode = countryCode;
            this.CountryName = countryName;
            this.TaxRate = taxRate;
            this.TaxRateFormatted = taxRateFormatted;
        }

        /// <summary>
        /// Accounting code for programs such as QuickBooks
        /// </summary>
        /// <value>Accounting code for programs such as QuickBooks</value>
        [DataMember(Name="accounting_code", EmitDefaultValue=false)]
        public string AccountingCode { get; set; }

        /// <summary>
        /// Country code (2 characters
        /// </summary>
        /// <value>Country code (2 characters</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        /// <value>Country name</value>
        [DataMember(Name="country_name", EmitDefaultValue=false)]
        public string CountryName { get; set; }

        /// <summary>
        /// Tax Rate
        /// </summary>
        /// <value>Tax Rate</value>
        [DataMember(Name="tax_rate", EmitDefaultValue=false)]
        public decimal TaxRate { get; set; }

        /// <summary>
        /// Tax rate formatted
        /// </summary>
        /// <value>Tax rate formatted</value>
        [DataMember(Name="tax_rate_formatted", EmitDefaultValue=false)]
        public string TaxRateFormatted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxCountryCode {\n");
            sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxRateFormatted: ").Append(TaxRateFormatted).Append("\n");
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
            return this.Equals(input as TaxCountryCode);
        }

        /// <summary>
        /// Returns true if TaxCountryCode instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxCountryCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxCountryCode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountingCode == input.AccountingCode ||
                    (this.AccountingCode != null &&
                    this.AccountingCode.Equals(input.AccountingCode))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.CountryName == input.CountryName ||
                    (this.CountryName != null &&
                    this.CountryName.Equals(input.CountryName))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.TaxRateFormatted == input.TaxRateFormatted ||
                    (this.TaxRateFormatted != null &&
                    this.TaxRateFormatted.Equals(input.TaxRateFormatted))
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
                if (this.AccountingCode != null)
                    hashCode = hashCode * 59 + this.AccountingCode.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CountryName != null)
                    hashCode = hashCode * 59 + this.CountryName.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.TaxRateFormatted != null)
                    hashCode = hashCode * 59 + this.TaxRateFormatted.GetHashCode();
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
