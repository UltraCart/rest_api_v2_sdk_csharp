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
    /// TaxProviderUltraCartState
    /// </summary>
    [DataContract]
    public partial class TaxProviderUltraCartState :  IEquatable<TaxProviderUltraCartState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxProviderUltraCartState" /> class.
        /// </summary>
        /// <param name="enabled">True if this state taxes are managed by UltraCart.</param>
        /// <param name="exemptDigitalItems">True if digital items are exempt from sales tax in this state..</param>
        /// <param name="exemptPhysicalItems">True if physical items are exempt from sales tax in this state..</param>
        /// <param name="exemptServiceItems">True if service items are exempt from sales tax in this state..</param>
        /// <param name="stateCode">State Code (2 digits).</param>
        /// <param name="stateName">Fully spelled out state name.</param>
        /// <param name="taxGiftCharge">True if gift charges should be taxed in this state..</param>
        /// <param name="taxGiftWrap">True if gift wrap should be taxed in this state..</param>
        /// <param name="taxRateFormatted">State tax rate formatted for display.</param>
        /// <param name="taxShipping">True if shipping should be taxed in this state..</param>
        public TaxProviderUltraCartState(bool enabled = default(bool), bool exemptDigitalItems = default(bool), bool exemptPhysicalItems = default(bool), bool exemptServiceItems = default(bool), string stateCode = default(string), string stateName = default(string), bool taxGiftCharge = default(bool), bool taxGiftWrap = default(bool), string taxRateFormatted = default(string), bool taxShipping = default(bool))
        {
            this.Enabled = enabled;
            this.ExemptDigitalItems = exemptDigitalItems;
            this.ExemptPhysicalItems = exemptPhysicalItems;
            this.ExemptServiceItems = exemptServiceItems;
            this.StateCode = stateCode;
            this.StateName = stateName;
            this.TaxGiftCharge = taxGiftCharge;
            this.TaxGiftWrap = taxGiftWrap;
            this.TaxRateFormatted = taxRateFormatted;
            this.TaxShipping = taxShipping;
        }

        /// <summary>
        /// True if this state taxes are managed by UltraCart
        /// </summary>
        /// <value>True if this state taxes are managed by UltraCart</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

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
        /// State Code (2 digits)
        /// </summary>
        /// <value>State Code (2 digits)</value>
        [DataMember(Name="state_code", EmitDefaultValue=false)]
        public string StateCode { get; set; }

        /// <summary>
        /// Fully spelled out state name
        /// </summary>
        /// <value>Fully spelled out state name</value>
        [DataMember(Name="state_name", EmitDefaultValue=false)]
        public string StateName { get; set; }

        /// <summary>
        /// True if gift charges should be taxed in this state.
        /// </summary>
        /// <value>True if gift charges should be taxed in this state.</value>
        [DataMember(Name="tax_gift_charge", EmitDefaultValue=false)]
        public bool TaxGiftCharge { get; set; }

        /// <summary>
        /// True if gift wrap should be taxed in this state.
        /// </summary>
        /// <value>True if gift wrap should be taxed in this state.</value>
        [DataMember(Name="tax_gift_wrap", EmitDefaultValue=false)]
        public bool TaxGiftWrap { get; set; }

        /// <summary>
        /// State tax rate formatted for display
        /// </summary>
        /// <value>State tax rate formatted for display</value>
        [DataMember(Name="tax_rate_formatted", EmitDefaultValue=false)]
        public string TaxRateFormatted { get; set; }

        /// <summary>
        /// True if shipping should be taxed in this state.
        /// </summary>
        /// <value>True if shipping should be taxed in this state.</value>
        [DataMember(Name="tax_shipping", EmitDefaultValue=false)]
        public bool TaxShipping { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxProviderUltraCartState {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ExemptDigitalItems: ").Append(ExemptDigitalItems).Append("\n");
            sb.Append("  ExemptPhysicalItems: ").Append(ExemptPhysicalItems).Append("\n");
            sb.Append("  ExemptServiceItems: ").Append(ExemptServiceItems).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  StateName: ").Append(StateName).Append("\n");
            sb.Append("  TaxGiftCharge: ").Append(TaxGiftCharge).Append("\n");
            sb.Append("  TaxGiftWrap: ").Append(TaxGiftWrap).Append("\n");
            sb.Append("  TaxRateFormatted: ").Append(TaxRateFormatted).Append("\n");
            sb.Append("  TaxShipping: ").Append(TaxShipping).Append("\n");
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
            return this.Equals(input as TaxProviderUltraCartState);
        }

        /// <summary>
        /// Returns true if TaxProviderUltraCartState instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxProviderUltraCartState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxProviderUltraCartState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                    this.StateName == input.StateName ||
                    (this.StateName != null &&
                    this.StateName.Equals(input.StateName))
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
                    this.TaxRateFormatted == input.TaxRateFormatted ||
                    (this.TaxRateFormatted != null &&
                    this.TaxRateFormatted.Equals(input.TaxRateFormatted))
                ) && 
                (
                    this.TaxShipping == input.TaxShipping ||
                    (this.TaxShipping != null &&
                    this.TaxShipping.Equals(input.TaxShipping))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.ExemptDigitalItems != null)
                    hashCode = hashCode * 59 + this.ExemptDigitalItems.GetHashCode();
                if (this.ExemptPhysicalItems != null)
                    hashCode = hashCode * 59 + this.ExemptPhysicalItems.GetHashCode();
                if (this.ExemptServiceItems != null)
                    hashCode = hashCode * 59 + this.ExemptServiceItems.GetHashCode();
                if (this.StateCode != null)
                    hashCode = hashCode * 59 + this.StateCode.GetHashCode();
                if (this.StateName != null)
                    hashCode = hashCode * 59 + this.StateName.GetHashCode();
                if (this.TaxGiftCharge != null)
                    hashCode = hashCode * 59 + this.TaxGiftCharge.GetHashCode();
                if (this.TaxGiftWrap != null)
                    hashCode = hashCode * 59 + this.TaxGiftWrap.GetHashCode();
                if (this.TaxRateFormatted != null)
                    hashCode = hashCode * 59 + this.TaxRateFormatted.GetHashCode();
                if (this.TaxShipping != null)
                    hashCode = hashCode * 59 + this.TaxShipping.GetHashCode();
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
