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
    /// CartSummary
    /// </summary>
    [DataContract]
    public partial class CartSummary :  IEquatable<CartSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartSummary" /> class.
        /// </summary>
        /// <param name="arbitraryShippingHandlingTotal">arbitraryShippingHandlingTotal.</param>
        /// <param name="arbitraryTax">arbitraryTax.</param>
        /// <param name="arbitraryTaxRate">arbitraryTaxRate.</param>
        /// <param name="arbitraryTaxableSubtotal">arbitraryTaxableSubtotal.</param>
        /// <param name="healthBenefitCardAmount">healthBenefitCardAmount.</param>
        /// <param name="healthBenefitCardBalance">healthBenefitCardBalance.</param>
        /// <param name="healthBenefitCardRequirements">Health benefit card requirements.</param>
        /// <param name="internalGiftCertificateAmount">internalGiftCertificateAmount.</param>
        /// <param name="shippingHandling">shippingHandling.</param>
        /// <param name="shippingHandlingDiscount">shippingHandlingDiscount.</param>
        /// <param name="shippingHandlingWithDiscount">shippingHandlingWithDiscount.</param>
        /// <param name="subtotal">subtotal.</param>
        /// <param name="subtotalDiscount">subtotalDiscount.</param>
        /// <param name="subtotalWithDiscount">subtotalWithDiscount.</param>
        /// <param name="surcharge">surcharge.</param>
        /// <param name="tax">tax.</param>
        /// <param name="taxableSubtotal">taxableSubtotal.</param>
        /// <param name="taxableSubtotalDiscount">taxableSubtotalDiscount.</param>
        /// <param name="taxableSubtotalWithDiscount">taxableSubtotalWithDiscount.</param>
        /// <param name="total">total.</param>
        public CartSummary(Currency arbitraryShippingHandlingTotal = default(Currency), Currency arbitraryTax = default(Currency), Currency arbitraryTaxRate = default(Currency), Currency arbitraryTaxableSubtotal = default(Currency), Currency healthBenefitCardAmount = default(Currency), Currency healthBenefitCardBalance = default(Currency), string healthBenefitCardRequirements = default(string), Currency internalGiftCertificateAmount = default(Currency), Currency shippingHandling = default(Currency), Currency shippingHandlingDiscount = default(Currency), Currency shippingHandlingWithDiscount = default(Currency), Currency subtotal = default(Currency), Currency subtotalDiscount = default(Currency), Currency subtotalWithDiscount = default(Currency), Currency surcharge = default(Currency), Currency tax = default(Currency), Currency taxableSubtotal = default(Currency), Currency taxableSubtotalDiscount = default(Currency), Currency taxableSubtotalWithDiscount = default(Currency), Currency total = default(Currency))
        {
            this.ArbitraryShippingHandlingTotal = arbitraryShippingHandlingTotal;
            this.ArbitraryTax = arbitraryTax;
            this.ArbitraryTaxRate = arbitraryTaxRate;
            this.ArbitraryTaxableSubtotal = arbitraryTaxableSubtotal;
            this.HealthBenefitCardAmount = healthBenefitCardAmount;
            this.HealthBenefitCardBalance = healthBenefitCardBalance;
            this.HealthBenefitCardRequirements = healthBenefitCardRequirements;
            this.InternalGiftCertificateAmount = internalGiftCertificateAmount;
            this.ShippingHandling = shippingHandling;
            this.ShippingHandlingDiscount = shippingHandlingDiscount;
            this.ShippingHandlingWithDiscount = shippingHandlingWithDiscount;
            this.Subtotal = subtotal;
            this.SubtotalDiscount = subtotalDiscount;
            this.SubtotalWithDiscount = subtotalWithDiscount;
            this.Surcharge = surcharge;
            this.Tax = tax;
            this.TaxableSubtotal = taxableSubtotal;
            this.TaxableSubtotalDiscount = taxableSubtotalDiscount;
            this.TaxableSubtotalWithDiscount = taxableSubtotalWithDiscount;
            this.Total = total;
        }

        /// <summary>
        /// Gets or Sets ArbitraryShippingHandlingTotal
        /// </summary>
        [DataMember(Name="arbitrary_shipping_handling_total", EmitDefaultValue=false)]
        public Currency ArbitraryShippingHandlingTotal { get; set; }

        /// <summary>
        /// Gets or Sets ArbitraryTax
        /// </summary>
        [DataMember(Name="arbitrary_tax", EmitDefaultValue=false)]
        public Currency ArbitraryTax { get; set; }

        /// <summary>
        /// Gets or Sets ArbitraryTaxRate
        /// </summary>
        [DataMember(Name="arbitrary_tax_rate", EmitDefaultValue=false)]
        public Currency ArbitraryTaxRate { get; set; }

        /// <summary>
        /// Gets or Sets ArbitraryTaxableSubtotal
        /// </summary>
        [DataMember(Name="arbitrary_taxable_subtotal", EmitDefaultValue=false)]
        public Currency ArbitraryTaxableSubtotal { get; set; }

        /// <summary>
        /// Gets or Sets HealthBenefitCardAmount
        /// </summary>
        [DataMember(Name="health_benefit_card_amount", EmitDefaultValue=false)]
        public Currency HealthBenefitCardAmount { get; set; }

        /// <summary>
        /// Gets or Sets HealthBenefitCardBalance
        /// </summary>
        [DataMember(Name="health_benefit_card_balance", EmitDefaultValue=false)]
        public Currency HealthBenefitCardBalance { get; set; }

        /// <summary>
        /// Health benefit card requirements
        /// </summary>
        /// <value>Health benefit card requirements</value>
        [DataMember(Name="health_benefit_card_requirements", EmitDefaultValue=false)]
        public string HealthBenefitCardRequirements { get; set; }

        /// <summary>
        /// Gets or Sets InternalGiftCertificateAmount
        /// </summary>
        [DataMember(Name="internal_gift_certificate_amount", EmitDefaultValue=false)]
        public Currency InternalGiftCertificateAmount { get; set; }

        /// <summary>
        /// Gets or Sets ShippingHandling
        /// </summary>
        [DataMember(Name="shipping_handling", EmitDefaultValue=false)]
        public Currency ShippingHandling { get; set; }

        /// <summary>
        /// Gets or Sets ShippingHandlingDiscount
        /// </summary>
        [DataMember(Name="shipping_handling_discount", EmitDefaultValue=false)]
        public Currency ShippingHandlingDiscount { get; set; }

        /// <summary>
        /// Gets or Sets ShippingHandlingWithDiscount
        /// </summary>
        [DataMember(Name="shipping_handling_with_discount", EmitDefaultValue=false)]
        public Currency ShippingHandlingWithDiscount { get; set; }

        /// <summary>
        /// Gets or Sets Subtotal
        /// </summary>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public Currency Subtotal { get; set; }

        /// <summary>
        /// Gets or Sets SubtotalDiscount
        /// </summary>
        [DataMember(Name="subtotal_discount", EmitDefaultValue=false)]
        public Currency SubtotalDiscount { get; set; }

        /// <summary>
        /// Gets or Sets SubtotalWithDiscount
        /// </summary>
        [DataMember(Name="subtotal_with_discount", EmitDefaultValue=false)]
        public Currency SubtotalWithDiscount { get; set; }

        /// <summary>
        /// Gets or Sets Surcharge
        /// </summary>
        [DataMember(Name="surcharge", EmitDefaultValue=false)]
        public Currency Surcharge { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public Currency Tax { get; set; }

        /// <summary>
        /// Gets or Sets TaxableSubtotal
        /// </summary>
        [DataMember(Name="taxable_subtotal", EmitDefaultValue=false)]
        public Currency TaxableSubtotal { get; set; }

        /// <summary>
        /// Gets or Sets TaxableSubtotalDiscount
        /// </summary>
        [DataMember(Name="taxable_subtotal_discount", EmitDefaultValue=false)]
        public Currency TaxableSubtotalDiscount { get; set; }

        /// <summary>
        /// Gets or Sets TaxableSubtotalWithDiscount
        /// </summary>
        [DataMember(Name="taxable_subtotal_with_discount", EmitDefaultValue=false)]
        public Currency TaxableSubtotalWithDiscount { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public Currency Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartSummary {\n");
            sb.Append("  ArbitraryShippingHandlingTotal: ").Append(ArbitraryShippingHandlingTotal).Append("\n");
            sb.Append("  ArbitraryTax: ").Append(ArbitraryTax).Append("\n");
            sb.Append("  ArbitraryTaxRate: ").Append(ArbitraryTaxRate).Append("\n");
            sb.Append("  ArbitraryTaxableSubtotal: ").Append(ArbitraryTaxableSubtotal).Append("\n");
            sb.Append("  HealthBenefitCardAmount: ").Append(HealthBenefitCardAmount).Append("\n");
            sb.Append("  HealthBenefitCardBalance: ").Append(HealthBenefitCardBalance).Append("\n");
            sb.Append("  HealthBenefitCardRequirements: ").Append(HealthBenefitCardRequirements).Append("\n");
            sb.Append("  InternalGiftCertificateAmount: ").Append(InternalGiftCertificateAmount).Append("\n");
            sb.Append("  ShippingHandling: ").Append(ShippingHandling).Append("\n");
            sb.Append("  ShippingHandlingDiscount: ").Append(ShippingHandlingDiscount).Append("\n");
            sb.Append("  ShippingHandlingWithDiscount: ").Append(ShippingHandlingWithDiscount).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  SubtotalDiscount: ").Append(SubtotalDiscount).Append("\n");
            sb.Append("  SubtotalWithDiscount: ").Append(SubtotalWithDiscount).Append("\n");
            sb.Append("  Surcharge: ").Append(Surcharge).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  TaxableSubtotal: ").Append(TaxableSubtotal).Append("\n");
            sb.Append("  TaxableSubtotalDiscount: ").Append(TaxableSubtotalDiscount).Append("\n");
            sb.Append("  TaxableSubtotalWithDiscount: ").Append(TaxableSubtotalWithDiscount).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as CartSummary);
        }

        /// <summary>
        /// Returns true if CartSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of CartSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArbitraryShippingHandlingTotal == input.ArbitraryShippingHandlingTotal ||
                    (this.ArbitraryShippingHandlingTotal != null &&
                    this.ArbitraryShippingHandlingTotal.Equals(input.ArbitraryShippingHandlingTotal))
                ) && 
                (
                    this.ArbitraryTax == input.ArbitraryTax ||
                    (this.ArbitraryTax != null &&
                    this.ArbitraryTax.Equals(input.ArbitraryTax))
                ) && 
                (
                    this.ArbitraryTaxRate == input.ArbitraryTaxRate ||
                    (this.ArbitraryTaxRate != null &&
                    this.ArbitraryTaxRate.Equals(input.ArbitraryTaxRate))
                ) && 
                (
                    this.ArbitraryTaxableSubtotal == input.ArbitraryTaxableSubtotal ||
                    (this.ArbitraryTaxableSubtotal != null &&
                    this.ArbitraryTaxableSubtotal.Equals(input.ArbitraryTaxableSubtotal))
                ) && 
                (
                    this.HealthBenefitCardAmount == input.HealthBenefitCardAmount ||
                    (this.HealthBenefitCardAmount != null &&
                    this.HealthBenefitCardAmount.Equals(input.HealthBenefitCardAmount))
                ) && 
                (
                    this.HealthBenefitCardBalance == input.HealthBenefitCardBalance ||
                    (this.HealthBenefitCardBalance != null &&
                    this.HealthBenefitCardBalance.Equals(input.HealthBenefitCardBalance))
                ) && 
                (
                    this.HealthBenefitCardRequirements == input.HealthBenefitCardRequirements ||
                    (this.HealthBenefitCardRequirements != null &&
                    this.HealthBenefitCardRequirements.Equals(input.HealthBenefitCardRequirements))
                ) && 
                (
                    this.InternalGiftCertificateAmount == input.InternalGiftCertificateAmount ||
                    (this.InternalGiftCertificateAmount != null &&
                    this.InternalGiftCertificateAmount.Equals(input.InternalGiftCertificateAmount))
                ) && 
                (
                    this.ShippingHandling == input.ShippingHandling ||
                    (this.ShippingHandling != null &&
                    this.ShippingHandling.Equals(input.ShippingHandling))
                ) && 
                (
                    this.ShippingHandlingDiscount == input.ShippingHandlingDiscount ||
                    (this.ShippingHandlingDiscount != null &&
                    this.ShippingHandlingDiscount.Equals(input.ShippingHandlingDiscount))
                ) && 
                (
                    this.ShippingHandlingWithDiscount == input.ShippingHandlingWithDiscount ||
                    (this.ShippingHandlingWithDiscount != null &&
                    this.ShippingHandlingWithDiscount.Equals(input.ShippingHandlingWithDiscount))
                ) && 
                (
                    this.Subtotal == input.Subtotal ||
                    (this.Subtotal != null &&
                    this.Subtotal.Equals(input.Subtotal))
                ) && 
                (
                    this.SubtotalDiscount == input.SubtotalDiscount ||
                    (this.SubtotalDiscount != null &&
                    this.SubtotalDiscount.Equals(input.SubtotalDiscount))
                ) && 
                (
                    this.SubtotalWithDiscount == input.SubtotalWithDiscount ||
                    (this.SubtotalWithDiscount != null &&
                    this.SubtotalWithDiscount.Equals(input.SubtotalWithDiscount))
                ) && 
                (
                    this.Surcharge == input.Surcharge ||
                    (this.Surcharge != null &&
                    this.Surcharge.Equals(input.Surcharge))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.TaxableSubtotal == input.TaxableSubtotal ||
                    (this.TaxableSubtotal != null &&
                    this.TaxableSubtotal.Equals(input.TaxableSubtotal))
                ) && 
                (
                    this.TaxableSubtotalDiscount == input.TaxableSubtotalDiscount ||
                    (this.TaxableSubtotalDiscount != null &&
                    this.TaxableSubtotalDiscount.Equals(input.TaxableSubtotalDiscount))
                ) && 
                (
                    this.TaxableSubtotalWithDiscount == input.TaxableSubtotalWithDiscount ||
                    (this.TaxableSubtotalWithDiscount != null &&
                    this.TaxableSubtotalWithDiscount.Equals(input.TaxableSubtotalWithDiscount))
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
                if (this.ArbitraryShippingHandlingTotal != null)
                    hashCode = hashCode * 59 + this.ArbitraryShippingHandlingTotal.GetHashCode();
                if (this.ArbitraryTax != null)
                    hashCode = hashCode * 59 + this.ArbitraryTax.GetHashCode();
                if (this.ArbitraryTaxRate != null)
                    hashCode = hashCode * 59 + this.ArbitraryTaxRate.GetHashCode();
                if (this.ArbitraryTaxableSubtotal != null)
                    hashCode = hashCode * 59 + this.ArbitraryTaxableSubtotal.GetHashCode();
                if (this.HealthBenefitCardAmount != null)
                    hashCode = hashCode * 59 + this.HealthBenefitCardAmount.GetHashCode();
                if (this.HealthBenefitCardBalance != null)
                    hashCode = hashCode * 59 + this.HealthBenefitCardBalance.GetHashCode();
                if (this.HealthBenefitCardRequirements != null)
                    hashCode = hashCode * 59 + this.HealthBenefitCardRequirements.GetHashCode();
                if (this.InternalGiftCertificateAmount != null)
                    hashCode = hashCode * 59 + this.InternalGiftCertificateAmount.GetHashCode();
                if (this.ShippingHandling != null)
                    hashCode = hashCode * 59 + this.ShippingHandling.GetHashCode();
                if (this.ShippingHandlingDiscount != null)
                    hashCode = hashCode * 59 + this.ShippingHandlingDiscount.GetHashCode();
                if (this.ShippingHandlingWithDiscount != null)
                    hashCode = hashCode * 59 + this.ShippingHandlingWithDiscount.GetHashCode();
                if (this.Subtotal != null)
                    hashCode = hashCode * 59 + this.Subtotal.GetHashCode();
                if (this.SubtotalDiscount != null)
                    hashCode = hashCode * 59 + this.SubtotalDiscount.GetHashCode();
                if (this.SubtotalWithDiscount != null)
                    hashCode = hashCode * 59 + this.SubtotalWithDiscount.GetHashCode();
                if (this.Surcharge != null)
                    hashCode = hashCode * 59 + this.Surcharge.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.TaxableSubtotal != null)
                    hashCode = hashCode * 59 + this.TaxableSubtotal.GetHashCode();
                if (this.TaxableSubtotalDiscount != null)
                    hashCode = hashCode * 59 + this.TaxableSubtotalDiscount.GetHashCode();
                if (this.TaxableSubtotalWithDiscount != null)
                    hashCode = hashCode * 59 + this.TaxableSubtotalWithDiscount.GetHashCode();
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
