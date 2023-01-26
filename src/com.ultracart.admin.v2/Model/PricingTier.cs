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
    /// PricingTier
    /// </summary>
    [DataContract]
    public partial class PricingTier :  IEquatable<PricingTier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingTier" /> class.
        /// </summary>
        /// <param name="allow3rdPartyBilling">Allow 3rd party billing.</param>
        /// <param name="allowCod">Allow COD.</param>
        /// <param name="allowPurchaseOrder">Allow purchase order.</param>
        /// <param name="allowQuoteRequest">Allow quote request.</param>
        /// <param name="approvalNotification">approvalNotification.</param>
        /// <param name="autoApproveCod">Auto approve COD.</param>
        /// <param name="autoApprovePurchaseOrder">Auto approve purchase order.</param>
        /// <param name="defaultOnWholesaleSignup">Default on wholesale signup.</param>
        /// <param name="defaultPercentageDiscount">Default percentage discount.</param>
        /// <param name="defaultShippingMethodOid">Default shipping method oid.</param>
        /// <param name="defaultTier">Default tier.</param>
        /// <param name="displayOnWholesaleSignup">Display on wholesale signup.</param>
        /// <param name="excludeFromFreePromotion">Exclude from free promotion.</param>
        /// <param name="exemptLoyaltyRewards">Exempt from Loyalty Rewards.</param>
        /// <param name="exemptShippingHandlingCharge">Exempt shipping handling charge.</param>
        /// <param name="freeShipping">Free shipping.</param>
        /// <param name="freeShippingMinimum">Free shipping minimum.</param>
        /// <param name="maximumItemCount">Maximum item count.</param>
        /// <param name="minimumItemCount">Minimum item count.</param>
        /// <param name="minimumSubtotal">Minimum subtotal.</param>
        /// <param name="name">Name.</param>
        /// <param name="noCoupons">No coupons.</param>
        /// <param name="noFreeShipping">No free shipping.</param>
        /// <param name="noRealtimeCharge">No realtime charge.</param>
        /// <param name="notValidWhenCouponPresent">Not valid when coupon present.</param>
        /// <param name="pricingTierOid">Pricing Tier Oid.</param>
        /// <param name="realtimePercentageDiscount">Realtime percentage discount.</param>
        /// <param name="signupNotification">signupNotification.</param>
        /// <param name="suppressBuysafe">Suppress buySAFE (deprecated).</param>
        /// <param name="suppressMailingList">Suppress mailing list.</param>
        /// <param name="taxExempt">Tax Exempt.</param>
        /// <param name="trackSeparately">Track separately.</param>
        public PricingTier(bool? allow3rdPartyBilling = default(bool?), bool? allowCod = default(bool?), bool? allowPurchaseOrder = default(bool?), bool? allowQuoteRequest = default(bool?), PricingTierNotification approvalNotification = default(PricingTierNotification), bool? autoApproveCod = default(bool?), bool? autoApprovePurchaseOrder = default(bool?), bool? defaultOnWholesaleSignup = default(bool?), decimal? defaultPercentageDiscount = default(decimal?), int? defaultShippingMethodOid = default(int?), bool? defaultTier = default(bool?), bool? displayOnWholesaleSignup = default(bool?), bool? excludeFromFreePromotion = default(bool?), bool? exemptLoyaltyRewards = default(bool?), bool? exemptShippingHandlingCharge = default(bool?), bool? freeShipping = default(bool?), decimal? freeShippingMinimum = default(decimal?), int? maximumItemCount = default(int?), int? minimumItemCount = default(int?), decimal? minimumSubtotal = default(decimal?), string name = default(string), bool? noCoupons = default(bool?), bool? noFreeShipping = default(bool?), bool? noRealtimeCharge = default(bool?), bool? notValidWhenCouponPresent = default(bool?), int? pricingTierOid = default(int?), decimal? realtimePercentageDiscount = default(decimal?), PricingTierNotification signupNotification = default(PricingTierNotification), bool? suppressBuysafe = default(bool?), bool? suppressMailingList = default(bool?), bool? taxExempt = default(bool?), bool? trackSeparately = default(bool?))
        {
            this.Allow3rdPartyBilling = allow3rdPartyBilling;
            this.AllowCod = allowCod;
            this.AllowPurchaseOrder = allowPurchaseOrder;
            this.AllowQuoteRequest = allowQuoteRequest;
            this.ApprovalNotification = approvalNotification;
            this.AutoApproveCod = autoApproveCod;
            this.AutoApprovePurchaseOrder = autoApprovePurchaseOrder;
            this.DefaultOnWholesaleSignup = defaultOnWholesaleSignup;
            this.DefaultPercentageDiscount = defaultPercentageDiscount;
            this.DefaultShippingMethodOid = defaultShippingMethodOid;
            this.DefaultTier = defaultTier;
            this.DisplayOnWholesaleSignup = displayOnWholesaleSignup;
            this.ExcludeFromFreePromotion = excludeFromFreePromotion;
            this.ExemptLoyaltyRewards = exemptLoyaltyRewards;
            this.ExemptShippingHandlingCharge = exemptShippingHandlingCharge;
            this.FreeShipping = freeShipping;
            this.FreeShippingMinimum = freeShippingMinimum;
            this.MaximumItemCount = maximumItemCount;
            this.MinimumItemCount = minimumItemCount;
            this.MinimumSubtotal = minimumSubtotal;
            this.Name = name;
            this.NoCoupons = noCoupons;
            this.NoFreeShipping = noFreeShipping;
            this.NoRealtimeCharge = noRealtimeCharge;
            this.NotValidWhenCouponPresent = notValidWhenCouponPresent;
            this.PricingTierOid = pricingTierOid;
            this.RealtimePercentageDiscount = realtimePercentageDiscount;
            this.SignupNotification = signupNotification;
            this.SuppressBuysafe = suppressBuysafe;
            this.SuppressMailingList = suppressMailingList;
            this.TaxExempt = taxExempt;
            this.TrackSeparately = trackSeparately;
        }
        
        /// <summary>
        /// Allow 3rd party billing
        /// </summary>
        /// <value>Allow 3rd party billing</value>
        [DataMember(Name="allow_3rd_party_billing", EmitDefaultValue=false)]
        public bool? Allow3rdPartyBilling { get; set; }

        /// <summary>
        /// Allow COD
        /// </summary>
        /// <value>Allow COD</value>
        [DataMember(Name="allow_cod", EmitDefaultValue=false)]
        public bool? AllowCod { get; set; }

        /// <summary>
        /// Allow purchase order
        /// </summary>
        /// <value>Allow purchase order</value>
        [DataMember(Name="allow_purchase_order", EmitDefaultValue=false)]
        public bool? AllowPurchaseOrder { get; set; }

        /// <summary>
        /// Allow quote request
        /// </summary>
        /// <value>Allow quote request</value>
        [DataMember(Name="allow_quote_request", EmitDefaultValue=false)]
        public bool? AllowQuoteRequest { get; set; }

        /// <summary>
        /// Gets or Sets ApprovalNotification
        /// </summary>
        [DataMember(Name="approval_notification", EmitDefaultValue=false)]
        public PricingTierNotification ApprovalNotification { get; set; }

        /// <summary>
        /// Auto approve COD
        /// </summary>
        /// <value>Auto approve COD</value>
        [DataMember(Name="auto_approve_cod", EmitDefaultValue=false)]
        public bool? AutoApproveCod { get; set; }

        /// <summary>
        /// Auto approve purchase order
        /// </summary>
        /// <value>Auto approve purchase order</value>
        [DataMember(Name="auto_approve_purchase_order", EmitDefaultValue=false)]
        public bool? AutoApprovePurchaseOrder { get; set; }

        /// <summary>
        /// Default on wholesale signup
        /// </summary>
        /// <value>Default on wholesale signup</value>
        [DataMember(Name="default_on_wholesale_signup", EmitDefaultValue=false)]
        public bool? DefaultOnWholesaleSignup { get; set; }

        /// <summary>
        /// Default percentage discount
        /// </summary>
        /// <value>Default percentage discount</value>
        [DataMember(Name="default_percentage_discount", EmitDefaultValue=false)]
        public decimal? DefaultPercentageDiscount { get; set; }

        /// <summary>
        /// Default shipping method oid
        /// </summary>
        /// <value>Default shipping method oid</value>
        [DataMember(Name="default_shipping_method_oid", EmitDefaultValue=false)]
        public int? DefaultShippingMethodOid { get; set; }

        /// <summary>
        /// Default tier
        /// </summary>
        /// <value>Default tier</value>
        [DataMember(Name="default_tier", EmitDefaultValue=false)]
        public bool? DefaultTier { get; set; }

        /// <summary>
        /// Display on wholesale signup
        /// </summary>
        /// <value>Display on wholesale signup</value>
        [DataMember(Name="display_on_wholesale_signup", EmitDefaultValue=false)]
        public bool? DisplayOnWholesaleSignup { get; set; }

        /// <summary>
        /// Exclude from free promotion
        /// </summary>
        /// <value>Exclude from free promotion</value>
        [DataMember(Name="exclude_from_free_promotion", EmitDefaultValue=false)]
        public bool? ExcludeFromFreePromotion { get; set; }

        /// <summary>
        /// Exempt from Loyalty Rewards
        /// </summary>
        /// <value>Exempt from Loyalty Rewards</value>
        [DataMember(Name="exempt_loyalty_rewards", EmitDefaultValue=false)]
        public bool? ExemptLoyaltyRewards { get; set; }

        /// <summary>
        /// Exempt shipping handling charge
        /// </summary>
        /// <value>Exempt shipping handling charge</value>
        [DataMember(Name="exempt_shipping_handling_charge", EmitDefaultValue=false)]
        public bool? ExemptShippingHandlingCharge { get; set; }

        /// <summary>
        /// Free shipping
        /// </summary>
        /// <value>Free shipping</value>
        [DataMember(Name="free_shipping", EmitDefaultValue=false)]
        public bool? FreeShipping { get; set; }

        /// <summary>
        /// Free shipping minimum
        /// </summary>
        /// <value>Free shipping minimum</value>
        [DataMember(Name="free_shipping_minimum", EmitDefaultValue=false)]
        public decimal? FreeShippingMinimum { get; set; }

        /// <summary>
        /// Maximum item count
        /// </summary>
        /// <value>Maximum item count</value>
        [DataMember(Name="maximum_item_count", EmitDefaultValue=false)]
        public int? MaximumItemCount { get; set; }

        /// <summary>
        /// Minimum item count
        /// </summary>
        /// <value>Minimum item count</value>
        [DataMember(Name="minimum_item_count", EmitDefaultValue=false)]
        public int? MinimumItemCount { get; set; }

        /// <summary>
        /// Minimum subtotal
        /// </summary>
        /// <value>Minimum subtotal</value>
        [DataMember(Name="minimum_subtotal", EmitDefaultValue=false)]
        public decimal? MinimumSubtotal { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// No coupons
        /// </summary>
        /// <value>No coupons</value>
        [DataMember(Name="no_coupons", EmitDefaultValue=false)]
        public bool? NoCoupons { get; set; }

        /// <summary>
        /// No free shipping
        /// </summary>
        /// <value>No free shipping</value>
        [DataMember(Name="no_free_shipping", EmitDefaultValue=false)]
        public bool? NoFreeShipping { get; set; }

        /// <summary>
        /// No realtime charge
        /// </summary>
        /// <value>No realtime charge</value>
        [DataMember(Name="no_realtime_charge", EmitDefaultValue=false)]
        public bool? NoRealtimeCharge { get; set; }

        /// <summary>
        /// Not valid when coupon present
        /// </summary>
        /// <value>Not valid when coupon present</value>
        [DataMember(Name="not_valid_when_coupon_present", EmitDefaultValue=false)]
        public bool? NotValidWhenCouponPresent { get; set; }

        /// <summary>
        /// Pricing Tier Oid
        /// </summary>
        /// <value>Pricing Tier Oid</value>
        [DataMember(Name="pricing_tier_oid", EmitDefaultValue=false)]
        public int? PricingTierOid { get; set; }

        /// <summary>
        /// Realtime percentage discount
        /// </summary>
        /// <value>Realtime percentage discount</value>
        [DataMember(Name="realtime_percentage_discount", EmitDefaultValue=false)]
        public decimal? RealtimePercentageDiscount { get; set; }

        /// <summary>
        /// Gets or Sets SignupNotification
        /// </summary>
        [DataMember(Name="signup_notification", EmitDefaultValue=false)]
        public PricingTierNotification SignupNotification { get; set; }

        /// <summary>
        /// Suppress buySAFE (deprecated)
        /// </summary>
        /// <value>Suppress buySAFE (deprecated)</value>
        [DataMember(Name="suppress_buysafe", EmitDefaultValue=false)]
        public bool? SuppressBuysafe { get; set; }

        /// <summary>
        /// Suppress mailing list
        /// </summary>
        /// <value>Suppress mailing list</value>
        [DataMember(Name="suppress_mailing_list", EmitDefaultValue=false)]
        public bool? SuppressMailingList { get; set; }

        /// <summary>
        /// Tax Exempt
        /// </summary>
        /// <value>Tax Exempt</value>
        [DataMember(Name="tax_exempt", EmitDefaultValue=false)]
        public bool? TaxExempt { get; set; }

        /// <summary>
        /// Track separately
        /// </summary>
        /// <value>Track separately</value>
        [DataMember(Name="track_separately", EmitDefaultValue=false)]
        public bool? TrackSeparately { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PricingTier {\n");
            sb.Append("  Allow3rdPartyBilling: ").Append(Allow3rdPartyBilling).Append("\n");
            sb.Append("  AllowCod: ").Append(AllowCod).Append("\n");
            sb.Append("  AllowPurchaseOrder: ").Append(AllowPurchaseOrder).Append("\n");
            sb.Append("  AllowQuoteRequest: ").Append(AllowQuoteRequest).Append("\n");
            sb.Append("  ApprovalNotification: ").Append(ApprovalNotification).Append("\n");
            sb.Append("  AutoApproveCod: ").Append(AutoApproveCod).Append("\n");
            sb.Append("  AutoApprovePurchaseOrder: ").Append(AutoApprovePurchaseOrder).Append("\n");
            sb.Append("  DefaultOnWholesaleSignup: ").Append(DefaultOnWholesaleSignup).Append("\n");
            sb.Append("  DefaultPercentageDiscount: ").Append(DefaultPercentageDiscount).Append("\n");
            sb.Append("  DefaultShippingMethodOid: ").Append(DefaultShippingMethodOid).Append("\n");
            sb.Append("  DefaultTier: ").Append(DefaultTier).Append("\n");
            sb.Append("  DisplayOnWholesaleSignup: ").Append(DisplayOnWholesaleSignup).Append("\n");
            sb.Append("  ExcludeFromFreePromotion: ").Append(ExcludeFromFreePromotion).Append("\n");
            sb.Append("  ExemptLoyaltyRewards: ").Append(ExemptLoyaltyRewards).Append("\n");
            sb.Append("  ExemptShippingHandlingCharge: ").Append(ExemptShippingHandlingCharge).Append("\n");
            sb.Append("  FreeShipping: ").Append(FreeShipping).Append("\n");
            sb.Append("  FreeShippingMinimum: ").Append(FreeShippingMinimum).Append("\n");
            sb.Append("  MaximumItemCount: ").Append(MaximumItemCount).Append("\n");
            sb.Append("  MinimumItemCount: ").Append(MinimumItemCount).Append("\n");
            sb.Append("  MinimumSubtotal: ").Append(MinimumSubtotal).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NoCoupons: ").Append(NoCoupons).Append("\n");
            sb.Append("  NoFreeShipping: ").Append(NoFreeShipping).Append("\n");
            sb.Append("  NoRealtimeCharge: ").Append(NoRealtimeCharge).Append("\n");
            sb.Append("  NotValidWhenCouponPresent: ").Append(NotValidWhenCouponPresent).Append("\n");
            sb.Append("  PricingTierOid: ").Append(PricingTierOid).Append("\n");
            sb.Append("  RealtimePercentageDiscount: ").Append(RealtimePercentageDiscount).Append("\n");
            sb.Append("  SignupNotification: ").Append(SignupNotification).Append("\n");
            sb.Append("  SuppressBuysafe: ").Append(SuppressBuysafe).Append("\n");
            sb.Append("  SuppressMailingList: ").Append(SuppressMailingList).Append("\n");
            sb.Append("  TaxExempt: ").Append(TaxExempt).Append("\n");
            sb.Append("  TrackSeparately: ").Append(TrackSeparately).Append("\n");
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
            return this.Equals(input as PricingTier);
        }

        /// <summary>
        /// Returns true if PricingTier instances are equal
        /// </summary>
        /// <param name="input">Instance of PricingTier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PricingTier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Allow3rdPartyBilling == input.Allow3rdPartyBilling ||
                    (this.Allow3rdPartyBilling != null &&
                    this.Allow3rdPartyBilling.Equals(input.Allow3rdPartyBilling))
                ) && 
                (
                    this.AllowCod == input.AllowCod ||
                    (this.AllowCod != null &&
                    this.AllowCod.Equals(input.AllowCod))
                ) && 
                (
                    this.AllowPurchaseOrder == input.AllowPurchaseOrder ||
                    (this.AllowPurchaseOrder != null &&
                    this.AllowPurchaseOrder.Equals(input.AllowPurchaseOrder))
                ) && 
                (
                    this.AllowQuoteRequest == input.AllowQuoteRequest ||
                    (this.AllowQuoteRequest != null &&
                    this.AllowQuoteRequest.Equals(input.AllowQuoteRequest))
                ) && 
                (
                    this.ApprovalNotification == input.ApprovalNotification ||
                    (this.ApprovalNotification != null &&
                    this.ApprovalNotification.Equals(input.ApprovalNotification))
                ) && 
                (
                    this.AutoApproveCod == input.AutoApproveCod ||
                    (this.AutoApproveCod != null &&
                    this.AutoApproveCod.Equals(input.AutoApproveCod))
                ) && 
                (
                    this.AutoApprovePurchaseOrder == input.AutoApprovePurchaseOrder ||
                    (this.AutoApprovePurchaseOrder != null &&
                    this.AutoApprovePurchaseOrder.Equals(input.AutoApprovePurchaseOrder))
                ) && 
                (
                    this.DefaultOnWholesaleSignup == input.DefaultOnWholesaleSignup ||
                    (this.DefaultOnWholesaleSignup != null &&
                    this.DefaultOnWholesaleSignup.Equals(input.DefaultOnWholesaleSignup))
                ) && 
                (
                    this.DefaultPercentageDiscount == input.DefaultPercentageDiscount ||
                    (this.DefaultPercentageDiscount != null &&
                    this.DefaultPercentageDiscount.Equals(input.DefaultPercentageDiscount))
                ) && 
                (
                    this.DefaultShippingMethodOid == input.DefaultShippingMethodOid ||
                    (this.DefaultShippingMethodOid != null &&
                    this.DefaultShippingMethodOid.Equals(input.DefaultShippingMethodOid))
                ) && 
                (
                    this.DefaultTier == input.DefaultTier ||
                    (this.DefaultTier != null &&
                    this.DefaultTier.Equals(input.DefaultTier))
                ) && 
                (
                    this.DisplayOnWholesaleSignup == input.DisplayOnWholesaleSignup ||
                    (this.DisplayOnWholesaleSignup != null &&
                    this.DisplayOnWholesaleSignup.Equals(input.DisplayOnWholesaleSignup))
                ) && 
                (
                    this.ExcludeFromFreePromotion == input.ExcludeFromFreePromotion ||
                    (this.ExcludeFromFreePromotion != null &&
                    this.ExcludeFromFreePromotion.Equals(input.ExcludeFromFreePromotion))
                ) && 
                (
                    this.ExemptLoyaltyRewards == input.ExemptLoyaltyRewards ||
                    (this.ExemptLoyaltyRewards != null &&
                    this.ExemptLoyaltyRewards.Equals(input.ExemptLoyaltyRewards))
                ) && 
                (
                    this.ExemptShippingHandlingCharge == input.ExemptShippingHandlingCharge ||
                    (this.ExemptShippingHandlingCharge != null &&
                    this.ExemptShippingHandlingCharge.Equals(input.ExemptShippingHandlingCharge))
                ) && 
                (
                    this.FreeShipping == input.FreeShipping ||
                    (this.FreeShipping != null &&
                    this.FreeShipping.Equals(input.FreeShipping))
                ) && 
                (
                    this.FreeShippingMinimum == input.FreeShippingMinimum ||
                    (this.FreeShippingMinimum != null &&
                    this.FreeShippingMinimum.Equals(input.FreeShippingMinimum))
                ) && 
                (
                    this.MaximumItemCount == input.MaximumItemCount ||
                    (this.MaximumItemCount != null &&
                    this.MaximumItemCount.Equals(input.MaximumItemCount))
                ) && 
                (
                    this.MinimumItemCount == input.MinimumItemCount ||
                    (this.MinimumItemCount != null &&
                    this.MinimumItemCount.Equals(input.MinimumItemCount))
                ) && 
                (
                    this.MinimumSubtotal == input.MinimumSubtotal ||
                    (this.MinimumSubtotal != null &&
                    this.MinimumSubtotal.Equals(input.MinimumSubtotal))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NoCoupons == input.NoCoupons ||
                    (this.NoCoupons != null &&
                    this.NoCoupons.Equals(input.NoCoupons))
                ) && 
                (
                    this.NoFreeShipping == input.NoFreeShipping ||
                    (this.NoFreeShipping != null &&
                    this.NoFreeShipping.Equals(input.NoFreeShipping))
                ) && 
                (
                    this.NoRealtimeCharge == input.NoRealtimeCharge ||
                    (this.NoRealtimeCharge != null &&
                    this.NoRealtimeCharge.Equals(input.NoRealtimeCharge))
                ) && 
                (
                    this.NotValidWhenCouponPresent == input.NotValidWhenCouponPresent ||
                    (this.NotValidWhenCouponPresent != null &&
                    this.NotValidWhenCouponPresent.Equals(input.NotValidWhenCouponPresent))
                ) && 
                (
                    this.PricingTierOid == input.PricingTierOid ||
                    (this.PricingTierOid != null &&
                    this.PricingTierOid.Equals(input.PricingTierOid))
                ) && 
                (
                    this.RealtimePercentageDiscount == input.RealtimePercentageDiscount ||
                    (this.RealtimePercentageDiscount != null &&
                    this.RealtimePercentageDiscount.Equals(input.RealtimePercentageDiscount))
                ) && 
                (
                    this.SignupNotification == input.SignupNotification ||
                    (this.SignupNotification != null &&
                    this.SignupNotification.Equals(input.SignupNotification))
                ) && 
                (
                    this.SuppressBuysafe == input.SuppressBuysafe ||
                    (this.SuppressBuysafe != null &&
                    this.SuppressBuysafe.Equals(input.SuppressBuysafe))
                ) && 
                (
                    this.SuppressMailingList == input.SuppressMailingList ||
                    (this.SuppressMailingList != null &&
                    this.SuppressMailingList.Equals(input.SuppressMailingList))
                ) && 
                (
                    this.TaxExempt == input.TaxExempt ||
                    (this.TaxExempt != null &&
                    this.TaxExempt.Equals(input.TaxExempt))
                ) && 
                (
                    this.TrackSeparately == input.TrackSeparately ||
                    (this.TrackSeparately != null &&
                    this.TrackSeparately.Equals(input.TrackSeparately))
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
                if (this.Allow3rdPartyBilling != null)
                    hashCode = hashCode * 59 + this.Allow3rdPartyBilling.GetHashCode();
                if (this.AllowCod != null)
                    hashCode = hashCode * 59 + this.AllowCod.GetHashCode();
                if (this.AllowPurchaseOrder != null)
                    hashCode = hashCode * 59 + this.AllowPurchaseOrder.GetHashCode();
                if (this.AllowQuoteRequest != null)
                    hashCode = hashCode * 59 + this.AllowQuoteRequest.GetHashCode();
                if (this.ApprovalNotification != null)
                    hashCode = hashCode * 59 + this.ApprovalNotification.GetHashCode();
                if (this.AutoApproveCod != null)
                    hashCode = hashCode * 59 + this.AutoApproveCod.GetHashCode();
                if (this.AutoApprovePurchaseOrder != null)
                    hashCode = hashCode * 59 + this.AutoApprovePurchaseOrder.GetHashCode();
                if (this.DefaultOnWholesaleSignup != null)
                    hashCode = hashCode * 59 + this.DefaultOnWholesaleSignup.GetHashCode();
                if (this.DefaultPercentageDiscount != null)
                    hashCode = hashCode * 59 + this.DefaultPercentageDiscount.GetHashCode();
                if (this.DefaultShippingMethodOid != null)
                    hashCode = hashCode * 59 + this.DefaultShippingMethodOid.GetHashCode();
                if (this.DefaultTier != null)
                    hashCode = hashCode * 59 + this.DefaultTier.GetHashCode();
                if (this.DisplayOnWholesaleSignup != null)
                    hashCode = hashCode * 59 + this.DisplayOnWholesaleSignup.GetHashCode();
                if (this.ExcludeFromFreePromotion != null)
                    hashCode = hashCode * 59 + this.ExcludeFromFreePromotion.GetHashCode();
                if (this.ExemptLoyaltyRewards != null)
                    hashCode = hashCode * 59 + this.ExemptLoyaltyRewards.GetHashCode();
                if (this.ExemptShippingHandlingCharge != null)
                    hashCode = hashCode * 59 + this.ExemptShippingHandlingCharge.GetHashCode();
                if (this.FreeShipping != null)
                    hashCode = hashCode * 59 + this.FreeShipping.GetHashCode();
                if (this.FreeShippingMinimum != null)
                    hashCode = hashCode * 59 + this.FreeShippingMinimum.GetHashCode();
                if (this.MaximumItemCount != null)
                    hashCode = hashCode * 59 + this.MaximumItemCount.GetHashCode();
                if (this.MinimumItemCount != null)
                    hashCode = hashCode * 59 + this.MinimumItemCount.GetHashCode();
                if (this.MinimumSubtotal != null)
                    hashCode = hashCode * 59 + this.MinimumSubtotal.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NoCoupons != null)
                    hashCode = hashCode * 59 + this.NoCoupons.GetHashCode();
                if (this.NoFreeShipping != null)
                    hashCode = hashCode * 59 + this.NoFreeShipping.GetHashCode();
                if (this.NoRealtimeCharge != null)
                    hashCode = hashCode * 59 + this.NoRealtimeCharge.GetHashCode();
                if (this.NotValidWhenCouponPresent != null)
                    hashCode = hashCode * 59 + this.NotValidWhenCouponPresent.GetHashCode();
                if (this.PricingTierOid != null)
                    hashCode = hashCode * 59 + this.PricingTierOid.GetHashCode();
                if (this.RealtimePercentageDiscount != null)
                    hashCode = hashCode * 59 + this.RealtimePercentageDiscount.GetHashCode();
                if (this.SignupNotification != null)
                    hashCode = hashCode * 59 + this.SignupNotification.GetHashCode();
                if (this.SuppressBuysafe != null)
                    hashCode = hashCode * 59 + this.SuppressBuysafe.GetHashCode();
                if (this.SuppressMailingList != null)
                    hashCode = hashCode * 59 + this.SuppressMailingList.GetHashCode();
                if (this.TaxExempt != null)
                    hashCode = hashCode * 59 + this.TaxExempt.GetHashCode();
                if (this.TrackSeparately != null)
                    hashCode = hashCode * 59 + this.TrackSeparately.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 50.", new [] { "Name" });
            }

            yield break;
        }
    }

}
