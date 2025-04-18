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
    /// Cart
    /// </summary>
    [DataContract]
    public partial class Cart :  IEquatable<Cart>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cart" /> class.
        /// </summary>
        /// <param name="affiliate">affiliate.</param>
        /// <param name="affiliateNetworkPixelOid">The affiliate network pixel identifier associated with the cart.</param>
        /// <param name="baseCurrencyCode">The ISO-4217 three letter base currency code of the account.</param>
        /// <param name="billing">billing.</param>
        /// <param name="buysafe">buysafe.</param>
        /// <param name="cartId">Unique identifier for this cart.</param>
        /// <param name="checkout">checkout.</param>
        /// <param name="coupons">Coupons.</param>
        /// <param name="currencyCode">The ISO-4217 three letter currency code the customer is viewing prices in.</param>
        /// <param name="currencyConversion">currencyConversion.</param>
        /// <param name="customerProfile">customerProfile.</param>
        /// <param name="exchangeRate">The exchange rate if the customer is viewing a different currency than the base.</param>
        /// <param name="gift">gift.</param>
        /// <param name="giftCertificate">giftCertificate.</param>
        /// <param name="items">Items.</param>
        /// <param name="languageIsoCode">The ISO-631 three letter code the customer would like to checkout with.</param>
        /// <param name="loggedIn">True if the customer is logged into their profile.</param>
        /// <param name="marketing">marketing.</param>
        /// <param name="merchantId">Merchant ID this cart is associated with.</param>
        /// <param name="payment">payment.</param>
        /// <param name="properties">Properties associated with the cart.</param>
        /// <param name="settings">settings.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="summary">summary.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="upsellAfter">upsellAfter.</param>
        public Cart(CartAffiliate affiliate = default(CartAffiliate), int affiliateNetworkPixelOid = default(int), string baseCurrencyCode = default(string), CartBilling billing = default(CartBilling), CartBuysafe buysafe = default(CartBuysafe), string cartId = default(string), CartCheckout checkout = default(CartCheckout), List<CartCoupon> coupons = default(List<CartCoupon>), string currencyCode = default(string), CartCurrencyConversion currencyConversion = default(CartCurrencyConversion), CartCustomerProfile customerProfile = default(CartCustomerProfile), decimal exchangeRate = default(decimal), CartGift gift = default(CartGift), CartGiftCertificate giftCertificate = default(CartGiftCertificate), List<CartItem> items = default(List<CartItem>), string languageIsoCode = default(string), bool loggedIn = default(bool), CartMarketing marketing = default(CartMarketing), string merchantId = default(string), CartPayment payment = default(CartPayment), List<CartProperty> properties = default(List<CartProperty>), CartSettings settings = default(CartSettings), CartShipping shipping = default(CartShipping), CartSummary summary = default(CartSummary), CartTaxes taxes = default(CartTaxes), CartUpsellAfter upsellAfter = default(CartUpsellAfter))
        {
            this.Affiliate = affiliate;
            this.AffiliateNetworkPixelOid = affiliateNetworkPixelOid;
            this.BaseCurrencyCode = baseCurrencyCode;
            this.Billing = billing;
            this.Buysafe = buysafe;
            this.CartId = cartId;
            this.Checkout = checkout;
            this.Coupons = coupons;
            this.CurrencyCode = currencyCode;
            this.CurrencyConversion = currencyConversion;
            this.CustomerProfile = customerProfile;
            this.ExchangeRate = exchangeRate;
            this.Gift = gift;
            this.GiftCertificate = giftCertificate;
            this.Items = items;
            this.LanguageIsoCode = languageIsoCode;
            this.LoggedIn = loggedIn;
            this.Marketing = marketing;
            this.MerchantId = merchantId;
            this.Payment = payment;
            this.Properties = properties;
            this.Settings = settings;
            this.Shipping = shipping;
            this.Summary = summary;
            this.Taxes = taxes;
            this.UpsellAfter = upsellAfter;
        }

        /// <summary>
        /// Gets or Sets Affiliate
        /// </summary>
        [DataMember(Name="affiliate", EmitDefaultValue=false)]
        public CartAffiliate Affiliate { get; set; }

        /// <summary>
        /// The affiliate network pixel identifier associated with the cart
        /// </summary>
        /// <value>The affiliate network pixel identifier associated with the cart</value>
        [DataMember(Name="affiliate_network_pixel_oid", EmitDefaultValue=false)]
        public int AffiliateNetworkPixelOid { get; set; }

        /// <summary>
        /// The ISO-4217 three letter base currency code of the account
        /// </summary>
        /// <value>The ISO-4217 three letter base currency code of the account</value>
        [DataMember(Name="base_currency_code", EmitDefaultValue=false)]
        public string BaseCurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Billing
        /// </summary>
        [DataMember(Name="billing", EmitDefaultValue=false)]
        public CartBilling Billing { get; set; }

        /// <summary>
        /// Gets or Sets Buysafe
        /// </summary>
        [DataMember(Name="buysafe", EmitDefaultValue=false)]
        public CartBuysafe Buysafe { get; set; }

        /// <summary>
        /// Unique identifier for this cart
        /// </summary>
        /// <value>Unique identifier for this cart</value>
        [DataMember(Name="cart_id", EmitDefaultValue=false)]
        public string CartId { get; set; }

        /// <summary>
        /// Gets or Sets Checkout
        /// </summary>
        [DataMember(Name="checkout", EmitDefaultValue=false)]
        public CartCheckout Checkout { get; set; }

        /// <summary>
        /// Coupons
        /// </summary>
        /// <value>Coupons</value>
        [DataMember(Name="coupons", EmitDefaultValue=false)]
        public List<CartCoupon> Coupons { get; set; }

        /// <summary>
        /// The ISO-4217 three letter currency code the customer is viewing prices in
        /// </summary>
        /// <value>The ISO-4217 three letter currency code the customer is viewing prices in</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyConversion
        /// </summary>
        [DataMember(Name="currency_conversion", EmitDefaultValue=false)]
        public CartCurrencyConversion CurrencyConversion { get; set; }

        /// <summary>
        /// Gets or Sets CustomerProfile
        /// </summary>
        [DataMember(Name="customer_profile", EmitDefaultValue=false)]
        public CartCustomerProfile CustomerProfile { get; set; }

        /// <summary>
        /// The exchange rate if the customer is viewing a different currency than the base
        /// </summary>
        /// <value>The exchange rate if the customer is viewing a different currency than the base</value>
        [DataMember(Name="exchange_rate", EmitDefaultValue=false)]
        public decimal ExchangeRate { get; set; }

        /// <summary>
        /// Gets or Sets Gift
        /// </summary>
        [DataMember(Name="gift", EmitDefaultValue=false)]
        public CartGift Gift { get; set; }

        /// <summary>
        /// Gets or Sets GiftCertificate
        /// </summary>
        [DataMember(Name="gift_certificate", EmitDefaultValue=false)]
        public CartGiftCertificate GiftCertificate { get; set; }

        /// <summary>
        /// Items
        /// </summary>
        /// <value>Items</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<CartItem> Items { get; set; }

        /// <summary>
        /// The ISO-631 three letter code the customer would like to checkout with
        /// </summary>
        /// <value>The ISO-631 three letter code the customer would like to checkout with</value>
        [DataMember(Name="language_iso_code", EmitDefaultValue=false)]
        public string LanguageIsoCode { get; set; }

        /// <summary>
        /// True if the customer is logged into their profile
        /// </summary>
        /// <value>True if the customer is logged into their profile</value>
        [DataMember(Name="logged_in", EmitDefaultValue=false)]
        public bool LoggedIn { get; set; }

        /// <summary>
        /// Gets or Sets Marketing
        /// </summary>
        [DataMember(Name="marketing", EmitDefaultValue=false)]
        public CartMarketing Marketing { get; set; }

        /// <summary>
        /// Merchant ID this cart is associated with
        /// </summary>
        /// <value>Merchant ID this cart is associated with</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name="payment", EmitDefaultValue=false)]
        public CartPayment Payment { get; set; }

        /// <summary>
        /// Properties associated with the cart
        /// </summary>
        /// <value>Properties associated with the cart</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<CartProperty> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public CartSettings Settings { get; set; }

        /// <summary>
        /// Gets or Sets Shipping
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public CartShipping Shipping { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public CartSummary Summary { get; set; }

        /// <summary>
        /// Gets or Sets Taxes
        /// </summary>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public CartTaxes Taxes { get; set; }

        /// <summary>
        /// Gets or Sets UpsellAfter
        /// </summary>
        [DataMember(Name="upsell_after", EmitDefaultValue=false)]
        public CartUpsellAfter UpsellAfter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cart {\n");
            sb.Append("  Affiliate: ").Append(Affiliate).Append("\n");
            sb.Append("  AffiliateNetworkPixelOid: ").Append(AffiliateNetworkPixelOid).Append("\n");
            sb.Append("  BaseCurrencyCode: ").Append(BaseCurrencyCode).Append("\n");
            sb.Append("  Billing: ").Append(Billing).Append("\n");
            sb.Append("  Buysafe: ").Append(Buysafe).Append("\n");
            sb.Append("  CartId: ").Append(CartId).Append("\n");
            sb.Append("  Checkout: ").Append(Checkout).Append("\n");
            sb.Append("  Coupons: ").Append(Coupons).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencyConversion: ").Append(CurrencyConversion).Append("\n");
            sb.Append("  CustomerProfile: ").Append(CustomerProfile).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  Gift: ").Append(Gift).Append("\n");
            sb.Append("  GiftCertificate: ").Append(GiftCertificate).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  LanguageIsoCode: ").Append(LanguageIsoCode).Append("\n");
            sb.Append("  LoggedIn: ").Append(LoggedIn).Append("\n");
            sb.Append("  Marketing: ").Append(Marketing).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  UpsellAfter: ").Append(UpsellAfter).Append("\n");
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
            return this.Equals(input as Cart);
        }

        /// <summary>
        /// Returns true if Cart instances are equal
        /// </summary>
        /// <param name="input">Instance of Cart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cart input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Affiliate == input.Affiliate ||
                    (this.Affiliate != null &&
                    this.Affiliate.Equals(input.Affiliate))
                ) && 
                (
                    this.AffiliateNetworkPixelOid == input.AffiliateNetworkPixelOid ||
                    (this.AffiliateNetworkPixelOid != null &&
                    this.AffiliateNetworkPixelOid.Equals(input.AffiliateNetworkPixelOid))
                ) && 
                (
                    this.BaseCurrencyCode == input.BaseCurrencyCode ||
                    (this.BaseCurrencyCode != null &&
                    this.BaseCurrencyCode.Equals(input.BaseCurrencyCode))
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
                    this.CartId == input.CartId ||
                    (this.CartId != null &&
                    this.CartId.Equals(input.CartId))
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
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.CurrencyConversion == input.CurrencyConversion ||
                    (this.CurrencyConversion != null &&
                    this.CurrencyConversion.Equals(input.CurrencyConversion))
                ) && 
                (
                    this.CustomerProfile == input.CustomerProfile ||
                    (this.CustomerProfile != null &&
                    this.CustomerProfile.Equals(input.CustomerProfile))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
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
                    this.LoggedIn == input.LoggedIn ||
                    (this.LoggedIn != null &&
                    this.LoggedIn.Equals(input.LoggedIn))
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
                    this.Payment == input.Payment ||
                    (this.Payment != null &&
                    this.Payment.Equals(input.Payment))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
                    this.Taxes == input.Taxes ||
                    (this.Taxes != null &&
                    this.Taxes.Equals(input.Taxes))
                ) && 
                (
                    this.UpsellAfter == input.UpsellAfter ||
                    (this.UpsellAfter != null &&
                    this.UpsellAfter.Equals(input.UpsellAfter))
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
                if (this.Affiliate != null)
                    hashCode = hashCode * 59 + this.Affiliate.GetHashCode();
                if (this.AffiliateNetworkPixelOid != null)
                    hashCode = hashCode * 59 + this.AffiliateNetworkPixelOid.GetHashCode();
                if (this.BaseCurrencyCode != null)
                    hashCode = hashCode * 59 + this.BaseCurrencyCode.GetHashCode();
                if (this.Billing != null)
                    hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.Buysafe != null)
                    hashCode = hashCode * 59 + this.Buysafe.GetHashCode();
                if (this.CartId != null)
                    hashCode = hashCode * 59 + this.CartId.GetHashCode();
                if (this.Checkout != null)
                    hashCode = hashCode * 59 + this.Checkout.GetHashCode();
                if (this.Coupons != null)
                    hashCode = hashCode * 59 + this.Coupons.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.CurrencyConversion != null)
                    hashCode = hashCode * 59 + this.CurrencyConversion.GetHashCode();
                if (this.CustomerProfile != null)
                    hashCode = hashCode * 59 + this.CustomerProfile.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.Gift != null)
                    hashCode = hashCode * 59 + this.Gift.GetHashCode();
                if (this.GiftCertificate != null)
                    hashCode = hashCode * 59 + this.GiftCertificate.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.LanguageIsoCode != null)
                    hashCode = hashCode * 59 + this.LanguageIsoCode.GetHashCode();
                if (this.LoggedIn != null)
                    hashCode = hashCode * 59 + this.LoggedIn.GetHashCode();
                if (this.Marketing != null)
                    hashCode = hashCode * 59 + this.Marketing.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Payment != null)
                    hashCode = hashCode * 59 + this.Payment.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Taxes != null)
                    hashCode = hashCode * 59 + this.Taxes.GetHashCode();
                if (this.UpsellAfter != null)
                    hashCode = hashCode * 59 + this.UpsellAfter.GetHashCode();
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
            // BaseCurrencyCode (string) maxLength
            if(this.BaseCurrencyCode != null && this.BaseCurrencyCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BaseCurrencyCode, length must be less than 3.", new [] { "BaseCurrencyCode" });
            }


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
