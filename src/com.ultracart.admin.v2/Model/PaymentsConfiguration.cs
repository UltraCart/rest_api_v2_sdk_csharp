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
    /// PaymentsConfiguration
    /// </summary>
    [DataContract]
    public partial class PaymentsConfiguration :  IEquatable<PaymentsConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsConfiguration" /> class.
        /// </summary>
        /// <param name="affirm">affirm.</param>
        /// <param name="amazon">amazon.</param>
        /// <param name="cash">cash.</param>
        /// <param name="check">check.</param>
        /// <param name="cod">cod.</param>
        /// <param name="creditCard">creditCard.</param>
        /// <param name="eCheck">eCheck.</param>
        /// <param name="loanHero">loanHero.</param>
        /// <param name="moneyOrder">moneyOrder.</param>
        /// <param name="payPal">payPal.</param>
        /// <param name="purchaseOrder">purchaseOrder.</param>
        /// <param name="quoteRequest">quoteRequest.</param>
        /// <param name="sezzle">sezzle.</param>
        /// <param name="showAccountingCode">showAccountingCode.</param>
        /// <param name="switchToSubTab">switchToSubTab.</param>
        /// <param name="switchToTab">switchToTab.</param>
        /// <param name="wePay">wePay.</param>
        /// <param name="wireTransfer">wireTransfer.</param>
        public PaymentsConfiguration(PaymentsConfigurationAffirm affirm = default(PaymentsConfigurationAffirm), PaymentsConfigurationAmazon amazon = default(PaymentsConfigurationAmazon), PaymentsConfigurationCash cash = default(PaymentsConfigurationCash), PaymentsConfigurationCheck check = default(PaymentsConfigurationCheck), PaymentsConfigurationCOD cod = default(PaymentsConfigurationCOD), PaymentsConfigurationCreditCard creditCard = default(PaymentsConfigurationCreditCard), PaymentsConfigurationEcheck eCheck = default(PaymentsConfigurationEcheck), PaymentsConfigurationLoanHero loanHero = default(PaymentsConfigurationLoanHero), PaymentsConfigurationMoneyOrder moneyOrder = default(PaymentsConfigurationMoneyOrder), PaymentsConfigurationPayPal payPal = default(PaymentsConfigurationPayPal), PaymentsConfigurationPurchaseOrder purchaseOrder = default(PaymentsConfigurationPurchaseOrder), PaymentsConfigurationQuoteRequest quoteRequest = default(PaymentsConfigurationQuoteRequest), PaymentsConfigurationSezzle sezzle = default(PaymentsConfigurationSezzle), bool? showAccountingCode = default(bool?), string switchToSubTab = default(string), string switchToTab = default(string), PaymentsConfigurationWePay wePay = default(PaymentsConfigurationWePay), PaymentsConfigurationWireTransfer wireTransfer = default(PaymentsConfigurationWireTransfer))
        {
            this.Affirm = affirm;
            this.Amazon = amazon;
            this.Cash = cash;
            this.Check = check;
            this.Cod = cod;
            this.CreditCard = creditCard;
            this.ECheck = eCheck;
            this.LoanHero = loanHero;
            this.MoneyOrder = moneyOrder;
            this.PayPal = payPal;
            this.PurchaseOrder = purchaseOrder;
            this.QuoteRequest = quoteRequest;
            this.Sezzle = sezzle;
            this.ShowAccountingCode = showAccountingCode;
            this.SwitchToSubTab = switchToSubTab;
            this.SwitchToTab = switchToTab;
            this.WePay = wePay;
            this.WireTransfer = wireTransfer;
        }
        
        /// <summary>
        /// Gets or Sets Affirm
        /// </summary>
        [DataMember(Name="affirm", EmitDefaultValue=false)]
        public PaymentsConfigurationAffirm Affirm { get; set; }

        /// <summary>
        /// Gets or Sets Amazon
        /// </summary>
        [DataMember(Name="amazon", EmitDefaultValue=false)]
        public PaymentsConfigurationAmazon Amazon { get; set; }

        /// <summary>
        /// Gets or Sets Cash
        /// </summary>
        [DataMember(Name="cash", EmitDefaultValue=false)]
        public PaymentsConfigurationCash Cash { get; set; }

        /// <summary>
        /// Gets or Sets Check
        /// </summary>
        [DataMember(Name="check", EmitDefaultValue=false)]
        public PaymentsConfigurationCheck Check { get; set; }

        /// <summary>
        /// Gets or Sets Cod
        /// </summary>
        [DataMember(Name="cod", EmitDefaultValue=false)]
        public PaymentsConfigurationCOD Cod { get; set; }

        /// <summary>
        /// Gets or Sets CreditCard
        /// </summary>
        [DataMember(Name="creditCard", EmitDefaultValue=false)]
        public PaymentsConfigurationCreditCard CreditCard { get; set; }

        /// <summary>
        /// Gets or Sets ECheck
        /// </summary>
        [DataMember(Name="eCheck", EmitDefaultValue=false)]
        public PaymentsConfigurationEcheck ECheck { get; set; }

        /// <summary>
        /// Gets or Sets LoanHero
        /// </summary>
        [DataMember(Name="loanHero", EmitDefaultValue=false)]
        public PaymentsConfigurationLoanHero LoanHero { get; set; }

        /// <summary>
        /// Gets or Sets MoneyOrder
        /// </summary>
        [DataMember(Name="moneyOrder", EmitDefaultValue=false)]
        public PaymentsConfigurationMoneyOrder MoneyOrder { get; set; }

        /// <summary>
        /// Gets or Sets PayPal
        /// </summary>
        [DataMember(Name="payPal", EmitDefaultValue=false)]
        public PaymentsConfigurationPayPal PayPal { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrder
        /// </summary>
        [DataMember(Name="purchaseOrder", EmitDefaultValue=false)]
        public PaymentsConfigurationPurchaseOrder PurchaseOrder { get; set; }

        /// <summary>
        /// Gets or Sets QuoteRequest
        /// </summary>
        [DataMember(Name="quoteRequest", EmitDefaultValue=false)]
        public PaymentsConfigurationQuoteRequest QuoteRequest { get; set; }

        /// <summary>
        /// Gets or Sets Sezzle
        /// </summary>
        [DataMember(Name="sezzle", EmitDefaultValue=false)]
        public PaymentsConfigurationSezzle Sezzle { get; set; }

        /// <summary>
        /// Gets or Sets ShowAccountingCode
        /// </summary>
        [DataMember(Name="showAccountingCode", EmitDefaultValue=false)]
        public bool? ShowAccountingCode { get; set; }

        /// <summary>
        /// Gets or Sets SwitchToSubTab
        /// </summary>
        [DataMember(Name="switchToSubTab", EmitDefaultValue=false)]
        public string SwitchToSubTab { get; set; }

        /// <summary>
        /// Gets or Sets SwitchToTab
        /// </summary>
        [DataMember(Name="switchToTab", EmitDefaultValue=false)]
        public string SwitchToTab { get; set; }

        /// <summary>
        /// Gets or Sets WePay
        /// </summary>
        [DataMember(Name="wePay", EmitDefaultValue=false)]
        public PaymentsConfigurationWePay WePay { get; set; }

        /// <summary>
        /// Gets or Sets WireTransfer
        /// </summary>
        [DataMember(Name="wireTransfer", EmitDefaultValue=false)]
        public PaymentsConfigurationWireTransfer WireTransfer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsConfiguration {\n");
            sb.Append("  Affirm: ").Append(Affirm).Append("\n");
            sb.Append("  Amazon: ").Append(Amazon).Append("\n");
            sb.Append("  Cash: ").Append(Cash).Append("\n");
            sb.Append("  Check: ").Append(Check).Append("\n");
            sb.Append("  Cod: ").Append(Cod).Append("\n");
            sb.Append("  CreditCard: ").Append(CreditCard).Append("\n");
            sb.Append("  ECheck: ").Append(ECheck).Append("\n");
            sb.Append("  LoanHero: ").Append(LoanHero).Append("\n");
            sb.Append("  MoneyOrder: ").Append(MoneyOrder).Append("\n");
            sb.Append("  PayPal: ").Append(PayPal).Append("\n");
            sb.Append("  PurchaseOrder: ").Append(PurchaseOrder).Append("\n");
            sb.Append("  QuoteRequest: ").Append(QuoteRequest).Append("\n");
            sb.Append("  Sezzle: ").Append(Sezzle).Append("\n");
            sb.Append("  ShowAccountingCode: ").Append(ShowAccountingCode).Append("\n");
            sb.Append("  SwitchToSubTab: ").Append(SwitchToSubTab).Append("\n");
            sb.Append("  SwitchToTab: ").Append(SwitchToTab).Append("\n");
            sb.Append("  WePay: ").Append(WePay).Append("\n");
            sb.Append("  WireTransfer: ").Append(WireTransfer).Append("\n");
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
            return this.Equals(input as PaymentsConfiguration);
        }

        /// <summary>
        /// Returns true if PaymentsConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentsConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Affirm == input.Affirm ||
                    (this.Affirm != null &&
                    this.Affirm.Equals(input.Affirm))
                ) && 
                (
                    this.Amazon == input.Amazon ||
                    (this.Amazon != null &&
                    this.Amazon.Equals(input.Amazon))
                ) && 
                (
                    this.Cash == input.Cash ||
                    (this.Cash != null &&
                    this.Cash.Equals(input.Cash))
                ) && 
                (
                    this.Check == input.Check ||
                    (this.Check != null &&
                    this.Check.Equals(input.Check))
                ) && 
                (
                    this.Cod == input.Cod ||
                    (this.Cod != null &&
                    this.Cod.Equals(input.Cod))
                ) && 
                (
                    this.CreditCard == input.CreditCard ||
                    (this.CreditCard != null &&
                    this.CreditCard.Equals(input.CreditCard))
                ) && 
                (
                    this.ECheck == input.ECheck ||
                    (this.ECheck != null &&
                    this.ECheck.Equals(input.ECheck))
                ) && 
                (
                    this.LoanHero == input.LoanHero ||
                    (this.LoanHero != null &&
                    this.LoanHero.Equals(input.LoanHero))
                ) && 
                (
                    this.MoneyOrder == input.MoneyOrder ||
                    (this.MoneyOrder != null &&
                    this.MoneyOrder.Equals(input.MoneyOrder))
                ) && 
                (
                    this.PayPal == input.PayPal ||
                    (this.PayPal != null &&
                    this.PayPal.Equals(input.PayPal))
                ) && 
                (
                    this.PurchaseOrder == input.PurchaseOrder ||
                    (this.PurchaseOrder != null &&
                    this.PurchaseOrder.Equals(input.PurchaseOrder))
                ) && 
                (
                    this.QuoteRequest == input.QuoteRequest ||
                    (this.QuoteRequest != null &&
                    this.QuoteRequest.Equals(input.QuoteRequest))
                ) && 
                (
                    this.Sezzle == input.Sezzle ||
                    (this.Sezzle != null &&
                    this.Sezzle.Equals(input.Sezzle))
                ) && 
                (
                    this.ShowAccountingCode == input.ShowAccountingCode ||
                    (this.ShowAccountingCode != null &&
                    this.ShowAccountingCode.Equals(input.ShowAccountingCode))
                ) && 
                (
                    this.SwitchToSubTab == input.SwitchToSubTab ||
                    (this.SwitchToSubTab != null &&
                    this.SwitchToSubTab.Equals(input.SwitchToSubTab))
                ) && 
                (
                    this.SwitchToTab == input.SwitchToTab ||
                    (this.SwitchToTab != null &&
                    this.SwitchToTab.Equals(input.SwitchToTab))
                ) && 
                (
                    this.WePay == input.WePay ||
                    (this.WePay != null &&
                    this.WePay.Equals(input.WePay))
                ) && 
                (
                    this.WireTransfer == input.WireTransfer ||
                    (this.WireTransfer != null &&
                    this.WireTransfer.Equals(input.WireTransfer))
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
                if (this.Affirm != null)
                    hashCode = hashCode * 59 + this.Affirm.GetHashCode();
                if (this.Amazon != null)
                    hashCode = hashCode * 59 + this.Amazon.GetHashCode();
                if (this.Cash != null)
                    hashCode = hashCode * 59 + this.Cash.GetHashCode();
                if (this.Check != null)
                    hashCode = hashCode * 59 + this.Check.GetHashCode();
                if (this.Cod != null)
                    hashCode = hashCode * 59 + this.Cod.GetHashCode();
                if (this.CreditCard != null)
                    hashCode = hashCode * 59 + this.CreditCard.GetHashCode();
                if (this.ECheck != null)
                    hashCode = hashCode * 59 + this.ECheck.GetHashCode();
                if (this.LoanHero != null)
                    hashCode = hashCode * 59 + this.LoanHero.GetHashCode();
                if (this.MoneyOrder != null)
                    hashCode = hashCode * 59 + this.MoneyOrder.GetHashCode();
                if (this.PayPal != null)
                    hashCode = hashCode * 59 + this.PayPal.GetHashCode();
                if (this.PurchaseOrder != null)
                    hashCode = hashCode * 59 + this.PurchaseOrder.GetHashCode();
                if (this.QuoteRequest != null)
                    hashCode = hashCode * 59 + this.QuoteRequest.GetHashCode();
                if (this.Sezzle != null)
                    hashCode = hashCode * 59 + this.Sezzle.GetHashCode();
                if (this.ShowAccountingCode != null)
                    hashCode = hashCode * 59 + this.ShowAccountingCode.GetHashCode();
                if (this.SwitchToSubTab != null)
                    hashCode = hashCode * 59 + this.SwitchToSubTab.GetHashCode();
                if (this.SwitchToTab != null)
                    hashCode = hashCode * 59 + this.SwitchToTab.GetHashCode();
                if (this.WePay != null)
                    hashCode = hashCode * 59 + this.WePay.GetHashCode();
                if (this.WireTransfer != null)
                    hashCode = hashCode * 59 + this.WireTransfer.GetHashCode();
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
