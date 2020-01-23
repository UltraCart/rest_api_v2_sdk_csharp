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
    /// TaxCity
    /// </summary>
    [DataContract]
    public partial class TaxCity :  IEquatable<TaxCity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCity" /> class.
        /// </summary>
        /// <param name="AccountingCode">Accounting code for programs such as QuickBooks.</param>
        /// <param name="City">City.</param>
        /// <param name="CityOid">Tax record object identifier used internally by database.</param>
        /// <param name="CountyOid">Tax record object identifier used internally by database.</param>
        /// <param name="DontCollectCity">Flag instructing engine to not collect city tax for this city.</param>
        /// <param name="DontCollectPostalCode">Flag instructing engine to not collect postal code tax for this city.</param>
        /// <param name="PostalCodes">Postal Codes within this city.</param>
        /// <param name="TaxRate">Tax Rate.</param>
        /// <param name="TaxRateFormatted">Tax rate formatted.</param>
        public TaxCity(string AccountingCode = default(string), string City = default(string), int? CityOid = default(int?), int? CountyOid = default(int?), bool? DontCollectCity = default(bool?), bool? DontCollectPostalCode = default(bool?), List<TaxPostalCode> PostalCodes = default(List<TaxPostalCode>), decimal? TaxRate = default(decimal?), string TaxRateFormatted = default(string))
        {
            this.AccountingCode = AccountingCode;
            this.City = City;
            this.CityOid = CityOid;
            this.CountyOid = CountyOid;
            this.DontCollectCity = DontCollectCity;
            this.DontCollectPostalCode = DontCollectPostalCode;
            this.PostalCodes = PostalCodes;
            this.TaxRate = TaxRate;
            this.TaxRateFormatted = TaxRateFormatted;
        }
        
        /// <summary>
        /// Accounting code for programs such as QuickBooks
        /// </summary>
        /// <value>Accounting code for programs such as QuickBooks</value>
        [DataMember(Name="accounting_code", EmitDefaultValue=false)]
        public string AccountingCode { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Tax record object identifier used internally by database
        /// </summary>
        /// <value>Tax record object identifier used internally by database</value>
        [DataMember(Name="city_oid", EmitDefaultValue=false)]
        public int? CityOid { get; set; }

        /// <summary>
        /// Tax record object identifier used internally by database
        /// </summary>
        /// <value>Tax record object identifier used internally by database</value>
        [DataMember(Name="county_oid", EmitDefaultValue=false)]
        public int? CountyOid { get; set; }

        /// <summary>
        /// Flag instructing engine to not collect city tax for this city
        /// </summary>
        /// <value>Flag instructing engine to not collect city tax for this city</value>
        [DataMember(Name="dont_collect_city", EmitDefaultValue=false)]
        public bool? DontCollectCity { get; set; }

        /// <summary>
        /// Flag instructing engine to not collect postal code tax for this city
        /// </summary>
        /// <value>Flag instructing engine to not collect postal code tax for this city</value>
        [DataMember(Name="dont_collect_postal_code", EmitDefaultValue=false)]
        public bool? DontCollectPostalCode { get; set; }

        /// <summary>
        /// Postal Codes within this city
        /// </summary>
        /// <value>Postal Codes within this city</value>
        [DataMember(Name="postal_codes", EmitDefaultValue=false)]
        public List<TaxPostalCode> PostalCodes { get; set; }

        /// <summary>
        /// Tax Rate
        /// </summary>
        /// <value>Tax Rate</value>
        [DataMember(Name="tax_rate", EmitDefaultValue=false)]
        public decimal? TaxRate { get; set; }

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
            sb.Append("class TaxCity {\n");
            sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CityOid: ").Append(CityOid).Append("\n");
            sb.Append("  CountyOid: ").Append(CountyOid).Append("\n");
            sb.Append("  DontCollectCity: ").Append(DontCollectCity).Append("\n");
            sb.Append("  DontCollectPostalCode: ").Append(DontCollectPostalCode).Append("\n");
            sb.Append("  PostalCodes: ").Append(PostalCodes).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxRateFormatted: ").Append(TaxRateFormatted).Append("\n");
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
            return this.Equals(input as TaxCity);
        }

        /// <summary>
        /// Returns true if TaxCity instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxCity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxCity input)
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
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CityOid == input.CityOid ||
                    (this.CityOid != null &&
                    this.CityOid.Equals(input.CityOid))
                ) && 
                (
                    this.CountyOid == input.CountyOid ||
                    (this.CountyOid != null &&
                    this.CountyOid.Equals(input.CountyOid))
                ) && 
                (
                    this.DontCollectCity == input.DontCollectCity ||
                    (this.DontCollectCity != null &&
                    this.DontCollectCity.Equals(input.DontCollectCity))
                ) && 
                (
                    this.DontCollectPostalCode == input.DontCollectPostalCode ||
                    (this.DontCollectPostalCode != null &&
                    this.DontCollectPostalCode.Equals(input.DontCollectPostalCode))
                ) && 
                (
                    this.PostalCodes == input.PostalCodes ||
                    this.PostalCodes != null &&
                    this.PostalCodes.SequenceEqual(input.PostalCodes)
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
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.CityOid != null)
                    hashCode = hashCode * 59 + this.CityOid.GetHashCode();
                if (this.CountyOid != null)
                    hashCode = hashCode * 59 + this.CountyOid.GetHashCode();
                if (this.DontCollectCity != null)
                    hashCode = hashCode * 59 + this.DontCollectCity.GetHashCode();
                if (this.DontCollectPostalCode != null)
                    hashCode = hashCode * 59 + this.DontCollectPostalCode.GetHashCode();
                if (this.PostalCodes != null)
                    hashCode = hashCode * 59 + this.PostalCodes.GetHashCode();
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
