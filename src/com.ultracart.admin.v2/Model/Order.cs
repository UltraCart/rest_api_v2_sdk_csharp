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
    /// Order
    /// </summary>
    [DataContract]
    public partial class Order :  IEquatable<Order>, IValidatableObject
    {
        /// <summary>
        /// Current stage that the order is in.
        /// </summary>
        /// <value>Current stage that the order is in.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrentStageEnum
        {
            /// <summary>
            /// Enum AccountsReceivable for value: Accounts Receivable
            /// </summary>
            [EnumMember(Value = "Accounts Receivable")]
            AccountsReceivable = 1,

            /// <summary>
            /// Enum PendingClearance for value: Pending Clearance
            /// </summary>
            [EnumMember(Value = "Pending Clearance")]
            PendingClearance = 2,

            /// <summary>
            /// Enum FraudReview for value: Fraud Review
            /// </summary>
            [EnumMember(Value = "Fraud Review")]
            FraudReview = 3,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected = 4,

            /// <summary>
            /// Enum ShippingDepartment for value: Shipping Department
            /// </summary>
            [EnumMember(Value = "Shipping Department")]
            ShippingDepartment = 5,

            /// <summary>
            /// Enum CompletedOrder for value: Completed Order
            /// </summary>
            [EnumMember(Value = "Completed Order")]
            CompletedOrder = 6,

            /// <summary>
            /// Enum QuoteRequest for value: Quote Request
            /// </summary>
            [EnumMember(Value = "Quote Request")]
            QuoteRequest = 7,

            /// <summary>
            /// Enum QuoteSent for value: Quote Sent
            /// </summary>
            [EnumMember(Value = "Quote Sent")]
            QuoteSent = 8,

            /// <summary>
            /// Enum LeastCostRouting for value: Least Cost Routing
            /// </summary>
            [EnumMember(Value = "Least Cost Routing")]
            LeastCostRouting = 9,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 10,

            /// <summary>
            /// Enum PreOrdered for value: Pre-ordered
            /// </summary>
            [EnumMember(Value = "Pre-ordered")]
            PreOrdered = 11,

            /// <summary>
            /// Enum AdvancedOrderRouting for value: Advanced Order Routing
            /// </summary>
            [EnumMember(Value = "Advanced Order Routing")]
            AdvancedOrderRouting = 12

        }

        /// <summary>
        /// Current stage that the order is in.
        /// </summary>
        /// <value>Current stage that the order is in.</value>
        [DataMember(Name="current_stage", EmitDefaultValue=false)]
        public CurrentStageEnum? CurrentStage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="affiliates">Affiliates if any were associated with the order.  The first one in the array sent the order and each subsequent affiliate is the recruiter that earns a downline commission..</param>
        /// <param name="autoOrder">autoOrder.</param>
        /// <param name="billing">billing.</param>
        /// <param name="buysafe">buysafe.</param>
        /// <param name="channelPartner">channelPartner.</param>
        /// <param name="checkout">checkout.</param>
        /// <param name="coupons">Coupons.</param>
        /// <param name="creationDts">Date/time that the order was created.</param>
        /// <param name="currencyCode">Currency code that the customer used if different than the merchant&#39;s base currency code.</param>
        /// <param name="currentStage">Current stage that the order is in..</param>
        /// <param name="customerProfile">customerProfile.</param>
        /// <param name="digitalOrder">digitalOrder.</param>
        /// <param name="edi">edi.</param>
        /// <param name="exchangeRate">Exchange rate at the time the order was placed if currency code is different than the base currency.</param>
        /// <param name="fraudScore">fraudScore.</param>
        /// <param name="gift">gift.</param>
        /// <param name="giftCertificate">giftCertificate.</param>
        /// <param name="_internal">_internal.</param>
        /// <param name="items">Items.</param>
        /// <param name="languageIsoCode">Three letter ISO-639 language code used by the customer during the checkout if different than the default language.</param>
        /// <param name="linkedShipment">linkedShipment.</param>
        /// <param name="marketing">marketing.</param>
        /// <param name="merchantId">UltraCart merchant ID owning this order.</param>
        /// <param name="orderId">Order ID.</param>
        /// <param name="payment">payment.</param>
        /// <param name="pointOfSale">pointOfSale.</param>
        /// <param name="properties">Properties, available only through update, not through insert due to the nature of how properties are handled internally.</param>
        /// <param name="quote">quote.</param>
        /// <param name="refundDts">If the order was refunded, the date/time that the last refund occurred.</param>
        /// <param name="rejectDts">If the order was rejected, the date/time that the rejection occurred.</param>
        /// <param name="salesforce">salesforce.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="summary">summary.</param>
        /// <param name="tags">tags, available only through update, not through insert due to the nature of how tags are handled internally.</param>
        /// <param name="taxes">taxes.</param>
        public Order(List<OrderAffiliate> affiliates = default(List<OrderAffiliate>), OrderAutoOrder autoOrder = default(OrderAutoOrder), OrderBilling billing = default(OrderBilling), OrderBuysafe buysafe = default(OrderBuysafe), OrderChannelPartner channelPartner = default(OrderChannelPartner), OrderCheckout checkout = default(OrderCheckout), List<OrderCoupon> coupons = default(List<OrderCoupon>), string creationDts = default(string), string currencyCode = default(string), CurrentStageEnum? currentStage = default(CurrentStageEnum?), Customer customerProfile = default(Customer), OrderDigitalOrder digitalOrder = default(OrderDigitalOrder), OrderEdi edi = default(OrderEdi), decimal exchangeRate = default(decimal), OrderFraudScore fraudScore = default(OrderFraudScore), OrderGift gift = default(OrderGift), OrderGiftCertificate giftCertificate = default(OrderGiftCertificate), OrderInternal _internal = default(OrderInternal), List<OrderItem> items = default(List<OrderItem>), string languageIsoCode = default(string), OrderLinkedShipment linkedShipment = default(OrderLinkedShipment), OrderMarketing marketing = default(OrderMarketing), string merchantId = default(string), string orderId = default(string), OrderPayment payment = default(OrderPayment), OrderPointOfSale pointOfSale = default(OrderPointOfSale), List<OrderProperty> properties = default(List<OrderProperty>), OrderQuote quote = default(OrderQuote), string refundDts = default(string), string rejectDts = default(string), OrderSalesforce salesforce = default(OrderSalesforce), OrderShipping shipping = default(OrderShipping), OrderSummary summary = default(OrderSummary), List<OrderTag> tags = default(List<OrderTag>), OrderTaxes taxes = default(OrderTaxes))
        {
            this.Affiliates = affiliates;
            this.AutoOrder = autoOrder;
            this.Billing = billing;
            this.Buysafe = buysafe;
            this.ChannelPartner = channelPartner;
            this.Checkout = checkout;
            this.Coupons = coupons;
            this.CreationDts = creationDts;
            this.CurrencyCode = currencyCode;
            this.CurrentStage = currentStage;
            this.CustomerProfile = customerProfile;
            this.DigitalOrder = digitalOrder;
            this.Edi = edi;
            this.ExchangeRate = exchangeRate;
            this.FraudScore = fraudScore;
            this.Gift = gift;
            this.GiftCertificate = giftCertificate;
            this.Internal = _internal;
            this.Items = items;
            this.LanguageIsoCode = languageIsoCode;
            this.LinkedShipment = linkedShipment;
            this.Marketing = marketing;
            this.MerchantId = merchantId;
            this.OrderId = orderId;
            this.Payment = payment;
            this.PointOfSale = pointOfSale;
            this.Properties = properties;
            this.Quote = quote;
            this.RefundDts = refundDts;
            this.RejectDts = rejectDts;
            this.Salesforce = salesforce;
            this.Shipping = shipping;
            this.Summary = summary;
            this.Tags = tags;
            this.Taxes = taxes;
        }

        /// <summary>
        /// Affiliates if any were associated with the order.  The first one in the array sent the order and each subsequent affiliate is the recruiter that earns a downline commission.
        /// </summary>
        /// <value>Affiliates if any were associated with the order.  The first one in the array sent the order and each subsequent affiliate is the recruiter that earns a downline commission.</value>
        [DataMember(Name="affiliates", EmitDefaultValue=false)]
        public List<OrderAffiliate> Affiliates { get; set; }

        /// <summary>
        /// Gets or Sets AutoOrder
        /// </summary>
        [DataMember(Name="auto_order", EmitDefaultValue=false)]
        public OrderAutoOrder AutoOrder { get; set; }

        /// <summary>
        /// Gets or Sets Billing
        /// </summary>
        [DataMember(Name="billing", EmitDefaultValue=false)]
        public OrderBilling Billing { get; set; }

        /// <summary>
        /// Gets or Sets Buysafe
        /// </summary>
        [DataMember(Name="buysafe", EmitDefaultValue=false)]
        public OrderBuysafe Buysafe { get; set; }

        /// <summary>
        /// Gets or Sets ChannelPartner
        /// </summary>
        [DataMember(Name="channel_partner", EmitDefaultValue=false)]
        public OrderChannelPartner ChannelPartner { get; set; }

        /// <summary>
        /// Gets or Sets Checkout
        /// </summary>
        [DataMember(Name="checkout", EmitDefaultValue=false)]
        public OrderCheckout Checkout { get; set; }

        /// <summary>
        /// Coupons
        /// </summary>
        /// <value>Coupons</value>
        [DataMember(Name="coupons", EmitDefaultValue=false)]
        public List<OrderCoupon> Coupons { get; set; }

        /// <summary>
        /// Date/time that the order was created
        /// </summary>
        /// <value>Date/time that the order was created</value>
        [DataMember(Name="creation_dts", EmitDefaultValue=false)]
        public string CreationDts { get; set; }

        /// <summary>
        /// Currency code that the customer used if different than the merchant&#39;s base currency code
        /// </summary>
        /// <value>Currency code that the customer used if different than the merchant&#39;s base currency code</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }


        /// <summary>
        /// Gets or Sets CustomerProfile
        /// </summary>
        [DataMember(Name="customer_profile", EmitDefaultValue=false)]
        public Customer CustomerProfile { get; set; }

        /// <summary>
        /// Gets or Sets DigitalOrder
        /// </summary>
        [DataMember(Name="digital_order", EmitDefaultValue=false)]
        public OrderDigitalOrder DigitalOrder { get; set; }

        /// <summary>
        /// Gets or Sets Edi
        /// </summary>
        [DataMember(Name="edi", EmitDefaultValue=false)]
        public OrderEdi Edi { get; set; }

        /// <summary>
        /// Exchange rate at the time the order was placed if currency code is different than the base currency
        /// </summary>
        /// <value>Exchange rate at the time the order was placed if currency code is different than the base currency</value>
        [DataMember(Name="exchange_rate", EmitDefaultValue=false)]
        public decimal ExchangeRate { get; set; }

        /// <summary>
        /// Gets or Sets FraudScore
        /// </summary>
        [DataMember(Name="fraud_score", EmitDefaultValue=false)]
        public OrderFraudScore FraudScore { get; set; }

        /// <summary>
        /// Gets or Sets Gift
        /// </summary>
        [DataMember(Name="gift", EmitDefaultValue=false)]
        public OrderGift Gift { get; set; }

        /// <summary>
        /// Gets or Sets GiftCertificate
        /// </summary>
        [DataMember(Name="gift_certificate", EmitDefaultValue=false)]
        public OrderGiftCertificate GiftCertificate { get; set; }

        /// <summary>
        /// Gets or Sets Internal
        /// </summary>
        [DataMember(Name="internal", EmitDefaultValue=false)]
        public OrderInternal Internal { get; set; }

        /// <summary>
        /// Items
        /// </summary>
        /// <value>Items</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<OrderItem> Items { get; set; }

        /// <summary>
        /// Three letter ISO-639 language code used by the customer during the checkout if different than the default language
        /// </summary>
        /// <value>Three letter ISO-639 language code used by the customer during the checkout if different than the default language</value>
        [DataMember(Name="language_iso_code", EmitDefaultValue=false)]
        public string LanguageIsoCode { get; set; }

        /// <summary>
        /// Gets or Sets LinkedShipment
        /// </summary>
        [DataMember(Name="linked_shipment", EmitDefaultValue=false)]
        public OrderLinkedShipment LinkedShipment { get; set; }

        /// <summary>
        /// Gets or Sets Marketing
        /// </summary>
        [DataMember(Name="marketing", EmitDefaultValue=false)]
        public OrderMarketing Marketing { get; set; }

        /// <summary>
        /// UltraCart merchant ID owning this order
        /// </summary>
        /// <value>UltraCart merchant ID owning this order</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Order ID
        /// </summary>
        /// <value>Order ID</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name="payment", EmitDefaultValue=false)]
        public OrderPayment Payment { get; set; }

        /// <summary>
        /// Gets or Sets PointOfSale
        /// </summary>
        [DataMember(Name="point_of_sale", EmitDefaultValue=false)]
        public OrderPointOfSale PointOfSale { get; set; }

        /// <summary>
        /// Properties, available only through update, not through insert due to the nature of how properties are handled internally
        /// </summary>
        /// <value>Properties, available only through update, not through insert due to the nature of how properties are handled internally</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<OrderProperty> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Quote
        /// </summary>
        [DataMember(Name="quote", EmitDefaultValue=false)]
        public OrderQuote Quote { get; set; }

        /// <summary>
        /// If the order was refunded, the date/time that the last refund occurred
        /// </summary>
        /// <value>If the order was refunded, the date/time that the last refund occurred</value>
        [DataMember(Name="refund_dts", EmitDefaultValue=false)]
        public string RefundDts { get; set; }

        /// <summary>
        /// If the order was rejected, the date/time that the rejection occurred
        /// </summary>
        /// <value>If the order was rejected, the date/time that the rejection occurred</value>
        [DataMember(Name="reject_dts", EmitDefaultValue=false)]
        public string RejectDts { get; set; }

        /// <summary>
        /// Gets or Sets Salesforce
        /// </summary>
        [DataMember(Name="salesforce", EmitDefaultValue=false)]
        public OrderSalesforce Salesforce { get; set; }

        /// <summary>
        /// Gets or Sets Shipping
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public OrderShipping Shipping { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public OrderSummary Summary { get; set; }

        /// <summary>
        /// tags, available only through update, not through insert due to the nature of how tags are handled internally
        /// </summary>
        /// <value>tags, available only through update, not through insert due to the nature of how tags are handled internally</value>
        [DataMember(Name="Tags", EmitDefaultValue=false)]
        public List<OrderTag> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Taxes
        /// </summary>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public OrderTaxes Taxes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Affiliates: ").Append(Affiliates).Append("\n");
            sb.Append("  AutoOrder: ").Append(AutoOrder).Append("\n");
            sb.Append("  Billing: ").Append(Billing).Append("\n");
            sb.Append("  Buysafe: ").Append(Buysafe).Append("\n");
            sb.Append("  ChannelPartner: ").Append(ChannelPartner).Append("\n");
            sb.Append("  Checkout: ").Append(Checkout).Append("\n");
            sb.Append("  Coupons: ").Append(Coupons).Append("\n");
            sb.Append("  CreationDts: ").Append(CreationDts).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrentStage: ").Append(CurrentStage).Append("\n");
            sb.Append("  CustomerProfile: ").Append(CustomerProfile).Append("\n");
            sb.Append("  DigitalOrder: ").Append(DigitalOrder).Append("\n");
            sb.Append("  Edi: ").Append(Edi).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  FraudScore: ").Append(FraudScore).Append("\n");
            sb.Append("  Gift: ").Append(Gift).Append("\n");
            sb.Append("  GiftCertificate: ").Append(GiftCertificate).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  LanguageIsoCode: ").Append(LanguageIsoCode).Append("\n");
            sb.Append("  LinkedShipment: ").Append(LinkedShipment).Append("\n");
            sb.Append("  Marketing: ").Append(Marketing).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  PointOfSale: ").Append(PointOfSale).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Quote: ").Append(Quote).Append("\n");
            sb.Append("  RefundDts: ").Append(RefundDts).Append("\n");
            sb.Append("  RejectDts: ").Append(RejectDts).Append("\n");
            sb.Append("  Salesforce: ").Append(Salesforce).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
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
            return this.Equals(input as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="input">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Affiliates == input.Affiliates ||
                    this.Affiliates != null &&
                    input.Affiliates != null &&
                    this.Affiliates.SequenceEqual(input.Affiliates)
                ) && 
                (
                    this.AutoOrder == input.AutoOrder ||
                    (this.AutoOrder != null &&
                    this.AutoOrder.Equals(input.AutoOrder))
                ) && 
                (
                    this.Billing == input.Billing ||
                    (this.Billing != null &&
                    this.Billing.Equals(input.Billing))
                ) && 
                (
                    this.Buysafe == input.Buysafe ||
                    (this.Buysafe != null &&
                    this.Buysafe.Equals(input.Buysafe))
                ) && 
                (
                    this.ChannelPartner == input.ChannelPartner ||
                    (this.ChannelPartner != null &&
                    this.ChannelPartner.Equals(input.ChannelPartner))
                ) && 
                (
                    this.Checkout == input.Checkout ||
                    (this.Checkout != null &&
                    this.Checkout.Equals(input.Checkout))
                ) && 
                (
                    this.Coupons == input.Coupons ||
                    this.Coupons != null &&
                    input.Coupons != null &&
                    this.Coupons.SequenceEqual(input.Coupons)
                ) && 
                (
                    this.CreationDts == input.CreationDts ||
                    (this.CreationDts != null &&
                    this.CreationDts.Equals(input.CreationDts))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.CurrentStage == input.CurrentStage ||
                    (this.CurrentStage != null &&
                    this.CurrentStage.Equals(input.CurrentStage))
                ) && 
                (
                    this.CustomerProfile == input.CustomerProfile ||
                    (this.CustomerProfile != null &&
                    this.CustomerProfile.Equals(input.CustomerProfile))
                ) && 
                (
                    this.DigitalOrder == input.DigitalOrder ||
                    (this.DigitalOrder != null &&
                    this.DigitalOrder.Equals(input.DigitalOrder))
                ) && 
                (
                    this.Edi == input.Edi ||
                    (this.Edi != null &&
                    this.Edi.Equals(input.Edi))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.FraudScore == input.FraudScore ||
                    (this.FraudScore != null &&
                    this.FraudScore.Equals(input.FraudScore))
                ) && 
                (
                    this.Gift == input.Gift ||
                    (this.Gift != null &&
                    this.Gift.Equals(input.Gift))
                ) && 
                (
                    this.GiftCertificate == input.GiftCertificate ||
                    (this.GiftCertificate != null &&
                    this.GiftCertificate.Equals(input.GiftCertificate))
                ) && 
                (
                    this.Internal == input.Internal ||
                    (this.Internal != null &&
                    this.Internal.Equals(input.Internal))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.LanguageIsoCode == input.LanguageIsoCode ||
                    (this.LanguageIsoCode != null &&
                    this.LanguageIsoCode.Equals(input.LanguageIsoCode))
                ) && 
                (
                    this.LinkedShipment == input.LinkedShipment ||
                    (this.LinkedShipment != null &&
                    this.LinkedShipment.Equals(input.LinkedShipment))
                ) && 
                (
                    this.Marketing == input.Marketing ||
                    (this.Marketing != null &&
                    this.Marketing.Equals(input.Marketing))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Payment == input.Payment ||
                    (this.Payment != null &&
                    this.Payment.Equals(input.Payment))
                ) && 
                (
                    this.PointOfSale == input.PointOfSale ||
                    (this.PointOfSale != null &&
                    this.PointOfSale.Equals(input.PointOfSale))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Quote == input.Quote ||
                    (this.Quote != null &&
                    this.Quote.Equals(input.Quote))
                ) && 
                (
                    this.RefundDts == input.RefundDts ||
                    (this.RefundDts != null &&
                    this.RefundDts.Equals(input.RefundDts))
                ) && 
                (
                    this.RejectDts == input.RejectDts ||
                    (this.RejectDts != null &&
                    this.RejectDts.Equals(input.RejectDts))
                ) && 
                (
                    this.Salesforce == input.Salesforce ||
                    (this.Salesforce != null &&
                    this.Salesforce.Equals(input.Salesforce))
                ) && 
                (
                    this.Shipping == input.Shipping ||
                    (this.Shipping != null &&
                    this.Shipping.Equals(input.Shipping))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    (this.Taxes != null &&
                    this.Taxes.Equals(input.Taxes))
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
                if (this.Affiliates != null)
                    hashCode = hashCode * 59 + this.Affiliates.GetHashCode();
                if (this.AutoOrder != null)
                    hashCode = hashCode * 59 + this.AutoOrder.GetHashCode();
                if (this.Billing != null)
                    hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.Buysafe != null)
                    hashCode = hashCode * 59 + this.Buysafe.GetHashCode();
                if (this.ChannelPartner != null)
                    hashCode = hashCode * 59 + this.ChannelPartner.GetHashCode();
                if (this.Checkout != null)
                    hashCode = hashCode * 59 + this.Checkout.GetHashCode();
                if (this.Coupons != null)
                    hashCode = hashCode * 59 + this.Coupons.GetHashCode();
                if (this.CreationDts != null)
                    hashCode = hashCode * 59 + this.CreationDts.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.CurrentStage != null)
                    hashCode = hashCode * 59 + this.CurrentStage.GetHashCode();
                if (this.CustomerProfile != null)
                    hashCode = hashCode * 59 + this.CustomerProfile.GetHashCode();
                if (this.DigitalOrder != null)
                    hashCode = hashCode * 59 + this.DigitalOrder.GetHashCode();
                if (this.Edi != null)
                    hashCode = hashCode * 59 + this.Edi.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.FraudScore != null)
                    hashCode = hashCode * 59 + this.FraudScore.GetHashCode();
                if (this.Gift != null)
                    hashCode = hashCode * 59 + this.Gift.GetHashCode();
                if (this.GiftCertificate != null)
                    hashCode = hashCode * 59 + this.GiftCertificate.GetHashCode();
                if (this.Internal != null)
                    hashCode = hashCode * 59 + this.Internal.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.LanguageIsoCode != null)
                    hashCode = hashCode * 59 + this.LanguageIsoCode.GetHashCode();
                if (this.LinkedShipment != null)
                    hashCode = hashCode * 59 + this.LinkedShipment.GetHashCode();
                if (this.Marketing != null)
                    hashCode = hashCode * 59 + this.Marketing.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Payment != null)
                    hashCode = hashCode * 59 + this.Payment.GetHashCode();
                if (this.PointOfSale != null)
                    hashCode = hashCode * 59 + this.PointOfSale.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Quote != null)
                    hashCode = hashCode * 59 + this.Quote.GetHashCode();
                if (this.RefundDts != null)
                    hashCode = hashCode * 59 + this.RefundDts.GetHashCode();
                if (this.RejectDts != null)
                    hashCode = hashCode * 59 + this.RejectDts.GetHashCode();
                if (this.Salesforce != null)
                    hashCode = hashCode * 59 + this.Salesforce.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Taxes != null)
                    hashCode = hashCode * 59 + this.Taxes.GetHashCode();
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
            // CurrencyCode (string) maxLength
            if(this.CurrencyCode != null && this.CurrencyCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrencyCode, length must be less than 3.", new [] { "CurrencyCode" });
            }


            // LanguageIsoCode (string) maxLength
            if(this.LanguageIsoCode != null && this.LanguageIsoCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LanguageIsoCode, length must be less than 3.", new [] { "LanguageIsoCode" });
            }


            yield break;
        }
    }

}
