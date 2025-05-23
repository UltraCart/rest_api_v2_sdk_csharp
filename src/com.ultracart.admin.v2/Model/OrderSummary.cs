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
    /// OrderSummary
    /// </summary>
    [DataContract]
    public partial class OrderSummary :  IEquatable<OrderSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSummary" /> class.
        /// </summary>
        /// <param name="actualFulfillment">actualFulfillment.</param>
        /// <param name="actualOtherCost">actualOtherCost.</param>
        /// <param name="actualPaymentProcessing">actualPaymentProcessing.</param>
        /// <param name="actualProfit">actualProfit.</param>
        /// <param name="actualProfitAnalyzed">Actual profit has been analyzed.</param>
        /// <param name="actualProfitReview">Actual profit needs review.</param>
        /// <param name="actualShipping">actualShipping.</param>
        /// <param name="arbitraryShippingHandlingTotal">arbitraryShippingHandlingTotal.</param>
        /// <param name="healthBenefitCardAmount">healthBenefitCardAmount.</param>
        /// <param name="healthBenefitCardRefunded">healthBenefitCardRefunded.</param>
        /// <param name="internalGiftCertificateAmount">internalGiftCertificateAmount.</param>
        /// <param name="internalGiftCertificateRefunded">internalGiftCertificateRefunded.</param>
        /// <param name="otherRefunded">otherRefunded.</param>
        /// <param name="shippingHandlingRefunded">shippingHandlingRefunded.</param>
        /// <param name="shippingHandlingTotal">shippingHandlingTotal.</param>
        /// <param name="shippingHandlingTotalDiscount">shippingHandlingTotalDiscount.</param>
        /// <param name="subtotal">subtotal.</param>
        /// <param name="subtotalDiscount">subtotalDiscount.</param>
        /// <param name="subtotalDiscountRefunded">subtotalDiscountRefunded.</param>
        /// <param name="subtotalRefunded">subtotalRefunded.</param>
        /// <param name="tax">tax.</param>
        /// <param name="taxRefunded">taxRefunded.</param>
        /// <param name="taxableSubtotal">taxableSubtotal.</param>
        /// <param name="taxableSubtotalDiscount">taxableSubtotalDiscount.</param>
        /// <param name="total">total.</param>
        /// <param name="totalRefunded">totalRefunded.</param>
        public OrderSummary(Currency actualFulfillment = default(Currency), Currency actualOtherCost = default(Currency), Currency actualPaymentProcessing = default(Currency), Currency actualProfit = default(Currency), bool actualProfitAnalyzed = default(bool), bool actualProfitReview = default(bool), Currency actualShipping = default(Currency), Currency arbitraryShippingHandlingTotal = default(Currency), Currency healthBenefitCardAmount = default(Currency), Currency healthBenefitCardRefunded = default(Currency), Currency internalGiftCertificateAmount = default(Currency), Currency internalGiftCertificateRefunded = default(Currency), Currency otherRefunded = default(Currency), Currency shippingHandlingRefunded = default(Currency), Currency shippingHandlingTotal = default(Currency), Currency shippingHandlingTotalDiscount = default(Currency), Currency subtotal = default(Currency), Currency subtotalDiscount = default(Currency), Currency subtotalDiscountRefunded = default(Currency), Currency subtotalRefunded = default(Currency), Currency tax = default(Currency), Currency taxRefunded = default(Currency), Currency taxableSubtotal = default(Currency), Currency taxableSubtotalDiscount = default(Currency), Currency total = default(Currency), Currency totalRefunded = default(Currency))
        {
            this.ActualFulfillment = actualFulfillment;
            this.ActualOtherCost = actualOtherCost;
            this.ActualPaymentProcessing = actualPaymentProcessing;
            this.ActualProfit = actualProfit;
            this.ActualProfitAnalyzed = actualProfitAnalyzed;
            this.ActualProfitReview = actualProfitReview;
            this.ActualShipping = actualShipping;
            this.ArbitraryShippingHandlingTotal = arbitraryShippingHandlingTotal;
            this.HealthBenefitCardAmount = healthBenefitCardAmount;
            this.HealthBenefitCardRefunded = healthBenefitCardRefunded;
            this.InternalGiftCertificateAmount = internalGiftCertificateAmount;
            this.InternalGiftCertificateRefunded = internalGiftCertificateRefunded;
            this.OtherRefunded = otherRefunded;
            this.ShippingHandlingRefunded = shippingHandlingRefunded;
            this.ShippingHandlingTotal = shippingHandlingTotal;
            this.ShippingHandlingTotalDiscount = shippingHandlingTotalDiscount;
            this.Subtotal = subtotal;
            this.SubtotalDiscount = subtotalDiscount;
            this.SubtotalDiscountRefunded = subtotalDiscountRefunded;
            this.SubtotalRefunded = subtotalRefunded;
            this.Tax = tax;
            this.TaxRefunded = taxRefunded;
            this.TaxableSubtotal = taxableSubtotal;
            this.TaxableSubtotalDiscount = taxableSubtotalDiscount;
            this.Total = total;
            this.TotalRefunded = totalRefunded;
        }

        /// <summary>
        /// Gets or Sets ActualFulfillment
        /// </summary>
        [DataMember(Name="actual_fulfillment", EmitDefaultValue=false)]
        public Currency ActualFulfillment { get; set; }

        /// <summary>
        /// Gets or Sets ActualOtherCost
        /// </summary>
        [DataMember(Name="actual_other_cost", EmitDefaultValue=false)]
        public Currency ActualOtherCost { get; set; }

        /// <summary>
        /// Gets or Sets ActualPaymentProcessing
        /// </summary>
        [DataMember(Name="actual_payment_processing", EmitDefaultValue=false)]
        public Currency ActualPaymentProcessing { get; set; }

        /// <summary>
        /// Gets or Sets ActualProfit
        /// </summary>
        [DataMember(Name="actual_profit", EmitDefaultValue=false)]
        public Currency ActualProfit { get; set; }

        /// <summary>
        /// Actual profit has been analyzed
        /// </summary>
        /// <value>Actual profit has been analyzed</value>
        [DataMember(Name="actual_profit_analyzed", EmitDefaultValue=false)]
        public bool ActualProfitAnalyzed { get; set; }

        /// <summary>
        /// Actual profit needs review
        /// </summary>
        /// <value>Actual profit needs review</value>
        [DataMember(Name="actual_profit_review", EmitDefaultValue=false)]
        public bool ActualProfitReview { get; set; }

        /// <summary>
        /// Gets or Sets ActualShipping
        /// </summary>
        [DataMember(Name="actual_shipping", EmitDefaultValue=false)]
        public Currency ActualShipping { get; set; }

        /// <summary>
        /// Gets or Sets ArbitraryShippingHandlingTotal
        /// </summary>
        [DataMember(Name="arbitrary_shipping_handling_total", EmitDefaultValue=false)]
        public Currency ArbitraryShippingHandlingTotal { get; set; }

        /// <summary>
        /// Gets or Sets HealthBenefitCardAmount
        /// </summary>
        [DataMember(Name="health_benefit_card_amount", EmitDefaultValue=false)]
        public Currency HealthBenefitCardAmount { get; set; }

        /// <summary>
        /// Gets or Sets HealthBenefitCardRefunded
        /// </summary>
        [DataMember(Name="health_benefit_card_refunded", EmitDefaultValue=false)]
        public Currency HealthBenefitCardRefunded { get; set; }

        /// <summary>
        /// Gets or Sets InternalGiftCertificateAmount
        /// </summary>
        [DataMember(Name="internal_gift_certificate_amount", EmitDefaultValue=false)]
        public Currency InternalGiftCertificateAmount { get; set; }

        /// <summary>
        /// Gets or Sets InternalGiftCertificateRefunded
        /// </summary>
        [DataMember(Name="internal_gift_certificate_refunded", EmitDefaultValue=false)]
        public Currency InternalGiftCertificateRefunded { get; set; }

        /// <summary>
        /// Gets or Sets OtherRefunded
        /// </summary>
        [DataMember(Name="other_refunded", EmitDefaultValue=false)]
        public Currency OtherRefunded { get; set; }

        /// <summary>
        /// Gets or Sets ShippingHandlingRefunded
        /// </summary>
        [DataMember(Name="shipping_handling_refunded", EmitDefaultValue=false)]
        public Currency ShippingHandlingRefunded { get; set; }

        /// <summary>
        /// Gets or Sets ShippingHandlingTotal
        /// </summary>
        [DataMember(Name="shipping_handling_total", EmitDefaultValue=false)]
        public Currency ShippingHandlingTotal { get; set; }

        /// <summary>
        /// Gets or Sets ShippingHandlingTotalDiscount
        /// </summary>
        [DataMember(Name="shipping_handling_total_discount", EmitDefaultValue=false)]
        public Currency ShippingHandlingTotalDiscount { get; set; }

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
        /// Gets or Sets SubtotalDiscountRefunded
        /// </summary>
        [DataMember(Name="subtotal_discount_refunded", EmitDefaultValue=false)]
        public Currency SubtotalDiscountRefunded { get; set; }

        /// <summary>
        /// Gets or Sets SubtotalRefunded
        /// </summary>
        [DataMember(Name="subtotal_refunded", EmitDefaultValue=false)]
        public Currency SubtotalRefunded { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public Currency Tax { get; set; }

        /// <summary>
        /// Gets or Sets TaxRefunded
        /// </summary>
        [DataMember(Name="tax_refunded", EmitDefaultValue=false)]
        public Currency TaxRefunded { get; set; }

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
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public Currency Total { get; set; }

        /// <summary>
        /// Gets or Sets TotalRefunded
        /// </summary>
        [DataMember(Name="total_refunded", EmitDefaultValue=false)]
        public Currency TotalRefunded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderSummary {\n");
            sb.Append("  ActualFulfillment: ").Append(ActualFulfillment).Append("\n");
            sb.Append("  ActualOtherCost: ").Append(ActualOtherCost).Append("\n");
            sb.Append("  ActualPaymentProcessing: ").Append(ActualPaymentProcessing).Append("\n");
            sb.Append("  ActualProfit: ").Append(ActualProfit).Append("\n");
            sb.Append("  ActualProfitAnalyzed: ").Append(ActualProfitAnalyzed).Append("\n");
            sb.Append("  ActualProfitReview: ").Append(ActualProfitReview).Append("\n");
            sb.Append("  ActualShipping: ").Append(ActualShipping).Append("\n");
            sb.Append("  ArbitraryShippingHandlingTotal: ").Append(ArbitraryShippingHandlingTotal).Append("\n");
            sb.Append("  HealthBenefitCardAmount: ").Append(HealthBenefitCardAmount).Append("\n");
            sb.Append("  HealthBenefitCardRefunded: ").Append(HealthBenefitCardRefunded).Append("\n");
            sb.Append("  InternalGiftCertificateAmount: ").Append(InternalGiftCertificateAmount).Append("\n");
            sb.Append("  InternalGiftCertificateRefunded: ").Append(InternalGiftCertificateRefunded).Append("\n");
            sb.Append("  OtherRefunded: ").Append(OtherRefunded).Append("\n");
            sb.Append("  ShippingHandlingRefunded: ").Append(ShippingHandlingRefunded).Append("\n");
            sb.Append("  ShippingHandlingTotal: ").Append(ShippingHandlingTotal).Append("\n");
            sb.Append("  ShippingHandlingTotalDiscount: ").Append(ShippingHandlingTotalDiscount).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  SubtotalDiscount: ").Append(SubtotalDiscount).Append("\n");
            sb.Append("  SubtotalDiscountRefunded: ").Append(SubtotalDiscountRefunded).Append("\n");
            sb.Append("  SubtotalRefunded: ").Append(SubtotalRefunded).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  TaxRefunded: ").Append(TaxRefunded).Append("\n");
            sb.Append("  TaxableSubtotal: ").Append(TaxableSubtotal).Append("\n");
            sb.Append("  TaxableSubtotalDiscount: ").Append(TaxableSubtotalDiscount).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  TotalRefunded: ").Append(TotalRefunded).Append("\n");
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
            return this.Equals(input as OrderSummary);
        }

        /// <summary>
        /// Returns true if OrderSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActualFulfillment == input.ActualFulfillment ||
                    (this.ActualFulfillment != null &&
                    this.ActualFulfillment.Equals(input.ActualFulfillment))
                ) && 
                (
                    this.ActualOtherCost == input.ActualOtherCost ||
                    (this.ActualOtherCost != null &&
                    this.ActualOtherCost.Equals(input.ActualOtherCost))
                ) && 
                (
                    this.ActualPaymentProcessing == input.ActualPaymentProcessing ||
                    (this.ActualPaymentProcessing != null &&
                    this.ActualPaymentProcessing.Equals(input.ActualPaymentProcessing))
                ) && 
                (
                    this.ActualProfit == input.ActualProfit ||
                    (this.ActualProfit != null &&
                    this.ActualProfit.Equals(input.ActualProfit))
                ) && 
                (
                    this.ActualProfitAnalyzed == input.ActualProfitAnalyzed ||
                    (this.ActualProfitAnalyzed != null &&
                    this.ActualProfitAnalyzed.Equals(input.ActualProfitAnalyzed))
                ) && 
                (
                    this.ActualProfitReview == input.ActualProfitReview ||
                    (this.ActualProfitReview != null &&
                    this.ActualProfitReview.Equals(input.ActualProfitReview))
                ) && 
                (
                    this.ActualShipping == input.ActualShipping ||
                    (this.ActualShipping != null &&
                    this.ActualShipping.Equals(input.ActualShipping))
                ) && 
                (
                    this.ArbitraryShippingHandlingTotal == input.ArbitraryShippingHandlingTotal ||
                    (this.ArbitraryShippingHandlingTotal != null &&
                    this.ArbitraryShippingHandlingTotal.Equals(input.ArbitraryShippingHandlingTotal))
                ) && 
                (
                    this.HealthBenefitCardAmount == input.HealthBenefitCardAmount ||
                    (this.HealthBenefitCardAmount != null &&
                    this.HealthBenefitCardAmount.Equals(input.HealthBenefitCardAmount))
                ) && 
                (
                    this.HealthBenefitCardRefunded == input.HealthBenefitCardRefunded ||
                    (this.HealthBenefitCardRefunded != null &&
                    this.HealthBenefitCardRefunded.Equals(input.HealthBenefitCardRefunded))
                ) && 
                (
                    this.InternalGiftCertificateAmount == input.InternalGiftCertificateAmount ||
                    (this.InternalGiftCertificateAmount != null &&
                    this.InternalGiftCertificateAmount.Equals(input.InternalGiftCertificateAmount))
                ) && 
                (
                    this.InternalGiftCertificateRefunded == input.InternalGiftCertificateRefunded ||
                    (this.InternalGiftCertificateRefunded != null &&
                    this.InternalGiftCertificateRefunded.Equals(input.InternalGiftCertificateRefunded))
                ) && 
                (
                    this.OtherRefunded == input.OtherRefunded ||
                    (this.OtherRefunded != null &&
                    this.OtherRefunded.Equals(input.OtherRefunded))
                ) && 
                (
                    this.ShippingHandlingRefunded == input.ShippingHandlingRefunded ||
                    (this.ShippingHandlingRefunded != null &&
                    this.ShippingHandlingRefunded.Equals(input.ShippingHandlingRefunded))
                ) && 
                (
                    this.ShippingHandlingTotal == input.ShippingHandlingTotal ||
                    (this.ShippingHandlingTotal != null &&
                    this.ShippingHandlingTotal.Equals(input.ShippingHandlingTotal))
                ) && 
                (
                    this.ShippingHandlingTotalDiscount == input.ShippingHandlingTotalDiscount ||
                    (this.ShippingHandlingTotalDiscount != null &&
                    this.ShippingHandlingTotalDiscount.Equals(input.ShippingHandlingTotalDiscount))
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
                    this.SubtotalDiscountRefunded == input.SubtotalDiscountRefunded ||
                    (this.SubtotalDiscountRefunded != null &&
                    this.SubtotalDiscountRefunded.Equals(input.SubtotalDiscountRefunded))
                ) && 
                (
                    this.SubtotalRefunded == input.SubtotalRefunded ||
                    (this.SubtotalRefunded != null &&
                    this.SubtotalRefunded.Equals(input.SubtotalRefunded))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.TaxRefunded == input.TaxRefunded ||
                    (this.TaxRefunded != null &&
                    this.TaxRefunded.Equals(input.TaxRefunded))
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
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.TotalRefunded == input.TotalRefunded ||
                    (this.TotalRefunded != null &&
                    this.TotalRefunded.Equals(input.TotalRefunded))
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
                if (this.ActualFulfillment != null)
                    hashCode = hashCode * 59 + this.ActualFulfillment.GetHashCode();
                if (this.ActualOtherCost != null)
                    hashCode = hashCode * 59 + this.ActualOtherCost.GetHashCode();
                if (this.ActualPaymentProcessing != null)
                    hashCode = hashCode * 59 + this.ActualPaymentProcessing.GetHashCode();
                if (this.ActualProfit != null)
                    hashCode = hashCode * 59 + this.ActualProfit.GetHashCode();
                if (this.ActualProfitAnalyzed != null)
                    hashCode = hashCode * 59 + this.ActualProfitAnalyzed.GetHashCode();
                if (this.ActualProfitReview != null)
                    hashCode = hashCode * 59 + this.ActualProfitReview.GetHashCode();
                if (this.ActualShipping != null)
                    hashCode = hashCode * 59 + this.ActualShipping.GetHashCode();
                if (this.ArbitraryShippingHandlingTotal != null)
                    hashCode = hashCode * 59 + this.ArbitraryShippingHandlingTotal.GetHashCode();
                if (this.HealthBenefitCardAmount != null)
                    hashCode = hashCode * 59 + this.HealthBenefitCardAmount.GetHashCode();
                if (this.HealthBenefitCardRefunded != null)
                    hashCode = hashCode * 59 + this.HealthBenefitCardRefunded.GetHashCode();
                if (this.InternalGiftCertificateAmount != null)
                    hashCode = hashCode * 59 + this.InternalGiftCertificateAmount.GetHashCode();
                if (this.InternalGiftCertificateRefunded != null)
                    hashCode = hashCode * 59 + this.InternalGiftCertificateRefunded.GetHashCode();
                if (this.OtherRefunded != null)
                    hashCode = hashCode * 59 + this.OtherRefunded.GetHashCode();
                if (this.ShippingHandlingRefunded != null)
                    hashCode = hashCode * 59 + this.ShippingHandlingRefunded.GetHashCode();
                if (this.ShippingHandlingTotal != null)
                    hashCode = hashCode * 59 + this.ShippingHandlingTotal.GetHashCode();
                if (this.ShippingHandlingTotalDiscount != null)
                    hashCode = hashCode * 59 + this.ShippingHandlingTotalDiscount.GetHashCode();
                if (this.Subtotal != null)
                    hashCode = hashCode * 59 + this.Subtotal.GetHashCode();
                if (this.SubtotalDiscount != null)
                    hashCode = hashCode * 59 + this.SubtotalDiscount.GetHashCode();
                if (this.SubtotalDiscountRefunded != null)
                    hashCode = hashCode * 59 + this.SubtotalDiscountRefunded.GetHashCode();
                if (this.SubtotalRefunded != null)
                    hashCode = hashCode * 59 + this.SubtotalRefunded.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.TaxRefunded != null)
                    hashCode = hashCode * 59 + this.TaxRefunded.GetHashCode();
                if (this.TaxableSubtotal != null)
                    hashCode = hashCode * 59 + this.TaxableSubtotal.GetHashCode();
                if (this.TaxableSubtotalDiscount != null)
                    hashCode = hashCode * 59 + this.TaxableSubtotalDiscount.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.TotalRefunded != null)
                    hashCode = hashCode * 59 + this.TotalRefunded.GetHashCode();
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
