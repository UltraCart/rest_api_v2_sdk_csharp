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
    /// TaxState
    /// </summary>
    [DataContract]
    public partial class TaxState :  IEquatable<TaxState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxState" /> class.
        /// </summary>
        /// <param name="accountingCode">Accounting code for programs such as QuickBooks.</param>
        /// <param name="counties">Counties within this state.</param>
        /// <param name="countryOid">Tax record object identifier used internally by database.</param>
        /// <param name="dontCollectCity">Flag instructing engine to not collect city tax for this state.</param>
        /// <param name="dontCollectCounty">Flag instructing engine to not collect county tax for this state.</param>
        /// <param name="dontCollectPostalCode">Flag instructing engine to not collect postal code tax for this state.</param>
        /// <param name="dontCollectState">Flag instructing engine to not collect state tax for this state.</param>
        /// <param name="exemptDigitalItems">True if digital items are exempt from sales tax in this state..</param>
        /// <param name="exemptPhysicalItems">True if physical items are exempt from sales tax in this state..</param>
        /// <param name="exemptServiceItems">True if service items are exempt from sales tax in this state..</param>
        /// <param name="stateCode">State code.</param>
        /// <param name="stateOid">Tax record object identifier used internally by database.</param>
        /// <param name="taxGiftCharge">True if taxation within this jurisdiction should charge tax on gift charge.</param>
        /// <param name="taxGiftWrap">True if taxation within this jurisdiction should charge tax on gift wrap.</param>
        /// <param name="taxRate">Tax Rate.</param>
        /// <param name="taxRateFormatted">Tax rate formatted.</param>
        /// <param name="taxShipping">True if taxation within this jurisdiction should charge tax on shipping.</param>
        /// <param name="useUltracartManagedRates">If true, use UltraCart managed rates for this state.</param>
        public TaxState(string accountingCode = default(string), List<TaxCounty> counties = default(List<TaxCounty>), int countryOid = default(int), bool dontCollectCity = default(bool), bool dontCollectCounty = default(bool), bool dontCollectPostalCode = default(bool), bool dontCollectState = default(bool), bool exemptDigitalItems = default(bool), bool exemptPhysicalItems = default(bool), bool exemptServiceItems = default(bool), string stateCode = default(string), int stateOid = default(int), bool taxGiftCharge = default(bool), bool taxGiftWrap = default(bool), decimal taxRate = default(decimal), string taxRateFormatted = default(string), bool taxShipping = default(bool), bool useUltracartManagedRates = default(bool))
        {
            this.AccountingCode = accountingCode;
            this.Counties = counties;
            this.CountryOid = countryOid;
            this.DontCollectCity = dontCollectCity;
            this.DontCollectCounty = dontCollectCounty;
            this.DontCollectPostalCode = dontCollectPostalCode;
            this.DontCollectState = dontCollectState;
            this.ExemptDigitalItems = exemptDigitalItems;
            this.ExemptPhysicalItems = exemptPhysicalItems;
            this.ExemptServiceItems = exemptServiceItems;
            this.StateCode = stateCode;
            this.StateOid = stateOid;
            this.TaxGiftCharge = taxGiftCharge;
            this.TaxGiftWrap = taxGiftWrap;
            this.TaxRate = taxRate;
            this.TaxRateFormatted = taxRateFormatted;
            this.TaxShipping = taxShipping;
            this.UseUltracartManagedRates = useUltracartManagedRates;
        }

        /// <summary>
        /// Accounting code for programs such as QuickBooks
        /// </summary>
        /// <value>Accounting code for programs such as QuickBooks</value>
        [DataMember(Name="accounting_code", EmitDefaultValue=false)]
        public string AccountingCode { get; set; }

        /// <summary>
        /// Counties within this state
        /// </summary>
        /// <value>Counties within this state</value>
        [DataMember(Name="counties", EmitDefaultValue=false)]
        public List<TaxCounty> Counties { get; set; }

        /// <summary>
        /// Tax record object identifier used internally by database
        /// </summary>
        /// <value>Tax record object identifier used internally by database</value>
        [DataMember(Name="country_oid", EmitDefaultValue=false)]
        public int CountryOid { get; set; }

        /// <summary>
        /// Flag instructing engine to not collect city tax for this state
        /// </summary>
        /// <value>Flag instructing engine to not collect city tax for this state</value>
        [DataMember(Name="dont_collect_city", EmitDefaultValue=false)]
        public bool DontCollectCity { get; set; }

        /// <summary>
        /// Flag instructing engine to not collect county tax for this state
        /// </summary>
        /// <value>Flag instructing engine to not collect county tax for this state</value>
        [DataMember(Name="dont_collect_county", EmitDefaultValue=false)]
        public bool DontCollectCounty { get; set; }

        /// <summary>
        /// Flag instructing engine to not collect postal code tax for this state
        /// </summary>
        /// <value>Flag instructing engine to not collect postal code tax for this state</value>
        [DataMember(Name="dont_collect_postal_code", EmitDefaultValue=false)]
        public bool DontCollectPostalCode { get; set; }

        /// <summary>
        /// Flag instructing engine to not collect state tax for this state
        /// </summary>
        /// <value>Flag instructing engine to not collect state tax for this state</value>
        [DataMember(Name="dont_collect_state", EmitDefaultValue=false)]
        public bool DontCollectState { get; set; }

        /// <summary>
        /// True if digital items are exempt from sales tax in this state.
        /// </summary>
        /// <value>True if digital items are exempt from sales tax in this state.</value>
        [DataMember(Name="exempt_digital_items", EmitDefaultValue=false)]
        public bool ExemptDigitalItems { get; set; }

        /// <summary>
        /// True if physical items are exempt from sales tax in this state.
        /// </summary>
        /// <value>True if physical items are exempt from sales tax in this state.</value>
        [DataMember(Name="exempt_physical_items", EmitDefaultValue=false)]
        public bool ExemptPhysicalItems { get; set; }

        /// <summary>
        /// True if service items are exempt from sales tax in this state.
        /// </summary>
        /// <value>True if service items are exempt from sales tax in this state.</value>
        [DataMember(Name="exempt_service_items", EmitDefaultValue=false)]
        public bool ExemptServiceItems { get; set; }

        /// <summary>
        /// State code
        /// </summary>
        /// <value>State code</value>
        [DataMember(Name="state_code", EmitDefaultValue=false)]
        public string StateCode { get; set; }

        /// <summary>
        /// Tax record object identifier used internally by database
        /// </summary>
        /// <value>Tax record object identifier used internally by database</value>
        [DataMember(Name="state_oid", EmitDefaultValue=false)]
        public int StateOid { get; set; }

        /// <summary>
        /// True if taxation within this jurisdiction should charge tax on gift charge
        /// </summary>
        /// <value>True if taxation within this jurisdiction should charge tax on gift charge</value>
        [DataMember(Name="tax_gift_charge", EmitDefaultValue=false)]
        public bool TaxGiftCharge { get; set; }

        /// <summary>
        /// True if taxation within this jurisdiction should charge tax on gift wrap
        /// </summary>
        /// <value>True if taxation within this jurisdiction should charge tax on gift wrap</value>
        [DataMember(Name="tax_gift_wrap", EmitDefaultValue=false)]
        public bool TaxGiftWrap { get; set; }

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
        /// True if taxation within this jurisdiction should charge tax on shipping
        /// </summary>
        /// <value>True if taxation within this jurisdiction should charge tax on shipping</value>
        [DataMember(Name="tax_shipping", EmitDefaultValue=false)]
        public bool TaxShipping { get; set; }

        /// <summary>
        /// If true, use UltraCart managed rates for this state
        /// </summary>
        /// <value>If true, use UltraCart managed rates for this state</value>
        [DataMember(Name="use_ultracart_managed_rates", EmitDefaultValue=false)]
        public bool UseUltracartManagedRates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxState {\n");
            sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
            sb.Append("  Counties: ").Append(Counties).Append("\n");
            sb.Append("  CountryOid: ").Append(CountryOid).Append("\n");
            sb.Append("  DontCollectCity: ").Append(DontCollectCity).Append("\n");
            sb.Append("  DontCollectCounty: ").Append(DontCollectCounty).Append("\n");
            sb.Append("  DontCollectPostalCode: ").Append(DontCollectPostalCode).Append("\n");
            sb.Append("  DontCollectState: ").Append(DontCollectState).Append("\n");
            sb.Append("  ExemptDigitalItems: ").Append(ExemptDigitalItems).Append("\n");
            sb.Append("  ExemptPhysicalItems: ").Append(ExemptPhysicalItems).Append("\n");
            sb.Append("  ExemptServiceItems: ").Append(ExemptServiceItems).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  StateOid: ").Append(StateOid).Append("\n");
            sb.Append("  TaxGiftCharge: ").Append(TaxGiftCharge).Append("\n");
            sb.Append("  TaxGiftWrap: ").Append(TaxGiftWrap).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxRateFormatted: ").Append(TaxRateFormatted).Append("\n");
            sb.Append("  TaxShipping: ").Append(TaxShipping).Append("\n");
            sb.Append("  UseUltracartManagedRates: ").Append(UseUltracartManagedRates).Append("\n");
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
            return this.Equals(input as TaxState);
        }

        /// <summary>
        /// Returns true if TaxState instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxState input)
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
                    this.Counties == input.Counties ||
                    this.Counties != null &&
                    input.Counties != null &&
                    this.Counties.SequenceEqual(input.Counties)
                ) && 
                (
                    this.CountryOid == input.CountryOid ||
                    (this.CountryOid != null &&
                    this.CountryOid.Equals(input.CountryOid))
                ) && 
                (
                    this.DontCollectCity == input.DontCollectCity ||
                    (this.DontCollectCity != null &&
                    this.DontCollectCity.Equals(input.DontCollectCity))
                ) && 
                (
                    this.DontCollectCounty == input.DontCollectCounty ||
                    (this.DontCollectCounty != null &&
                    this.DontCollectCounty.Equals(input.DontCollectCounty))
                ) && 
                (
                    this.DontCollectPostalCode == input.DontCollectPostalCode ||
                    (this.DontCollectPostalCode != null &&
                    this.DontCollectPostalCode.Equals(input.DontCollectPostalCode))
                ) && 
                (
                    this.DontCollectState == input.DontCollectState ||
                    (this.DontCollectState != null &&
                    this.DontCollectState.Equals(input.DontCollectState))
                ) && 
                (
                    this.ExemptDigitalItems == input.ExemptDigitalItems ||
                    (this.ExemptDigitalItems != null &&
                    this.ExemptDigitalItems.Equals(input.ExemptDigitalItems))
                ) && 
                (
                    this.ExemptPhysicalItems == input.ExemptPhysicalItems ||
                    (this.ExemptPhysicalItems != null &&
                    this.ExemptPhysicalItems.Equals(input.ExemptPhysicalItems))
                ) && 
                (
                    this.ExemptServiceItems == input.ExemptServiceItems ||
                    (this.ExemptServiceItems != null &&
                    this.ExemptServiceItems.Equals(input.ExemptServiceItems))
                ) && 
                (
                    this.StateCode == input.StateCode ||
                    (this.StateCode != null &&
                    this.StateCode.Equals(input.StateCode))
                ) && 
                (
                    this.StateOid == input.StateOid ||
                    (this.StateOid != null &&
                    this.StateOid.Equals(input.StateOid))
                ) && 
                (
                    this.TaxGiftCharge == input.TaxGiftCharge ||
                    (this.TaxGiftCharge != null &&
                    this.TaxGiftCharge.Equals(input.TaxGiftCharge))
                ) && 
                (
                    this.TaxGiftWrap == input.TaxGiftWrap ||
                    (this.TaxGiftWrap != null &&
                    this.TaxGiftWrap.Equals(input.TaxGiftWrap))
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
                ) && 
                (
                    this.TaxShipping == input.TaxShipping ||
                    (this.TaxShipping != null &&
                    this.TaxShipping.Equals(input.TaxShipping))
                ) && 
                (
                    this.UseUltracartManagedRates == input.UseUltracartManagedRates ||
                    (this.UseUltracartManagedRates != null &&
                    this.UseUltracartManagedRates.Equals(input.UseUltracartManagedRates))
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
                if (this.Counties != null)
                    hashCode = hashCode * 59 + this.Counties.GetHashCode();
                if (this.CountryOid != null)
                    hashCode = hashCode * 59 + this.CountryOid.GetHashCode();
                if (this.DontCollectCity != null)
                    hashCode = hashCode * 59 + this.DontCollectCity.GetHashCode();
                if (this.DontCollectCounty != null)
                    hashCode = hashCode * 59 + this.DontCollectCounty.GetHashCode();
                if (this.DontCollectPostalCode != null)
                    hashCode = hashCode * 59 + this.DontCollectPostalCode.GetHashCode();
                if (this.DontCollectState != null)
                    hashCode = hashCode * 59 + this.DontCollectState.GetHashCode();
                if (this.ExemptDigitalItems != null)
                    hashCode = hashCode * 59 + this.ExemptDigitalItems.GetHashCode();
                if (this.ExemptPhysicalItems != null)
                    hashCode = hashCode * 59 + this.ExemptPhysicalItems.GetHashCode();
                if (this.ExemptServiceItems != null)
                    hashCode = hashCode * 59 + this.ExemptServiceItems.GetHashCode();
                if (this.StateCode != null)
                    hashCode = hashCode * 59 + this.StateCode.GetHashCode();
                if (this.StateOid != null)
                    hashCode = hashCode * 59 + this.StateOid.GetHashCode();
                if (this.TaxGiftCharge != null)
                    hashCode = hashCode * 59 + this.TaxGiftCharge.GetHashCode();
                if (this.TaxGiftWrap != null)
                    hashCode = hashCode * 59 + this.TaxGiftWrap.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.TaxRateFormatted != null)
                    hashCode = hashCode * 59 + this.TaxRateFormatted.GetHashCode();
                if (this.TaxShipping != null)
                    hashCode = hashCode * 59 + this.TaxShipping.GetHashCode();
                if (this.UseUltracartManagedRates != null)
                    hashCode = hashCode * 59 + this.UseUltracartManagedRates.GetHashCode();
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
