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
    /// CustomerLoyaltyRedemption
    /// </summary>
    [DataContract]
    public partial class CustomerLoyaltyRedemption :  IEquatable<CustomerLoyaltyRedemption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerLoyaltyRedemption" /> class.
        /// </summary>
        /// <param name="couponCode">Coupon code.</param>
        /// <param name="couponCodeOid">Coupon code OID.</param>
        /// <param name="couponUsed">Coupon used.</param>
        /// <param name="descriptionForCustomer">Description for customer.</param>
        /// <param name="expirationDts">Expiration date.</param>
        /// <param name="giftCertificateCode">Gift certificate code.</param>
        /// <param name="giftCertificateOid">Gift certificate oid.</param>
        /// <param name="loyaltyLedgerOid">Loyalty ledger OID.</param>
        /// <param name="loyaltyPoints">Loyalty points.</param>
        /// <param name="loyaltyRedemptionOid">Loyalty redemption OID.</param>
        /// <param name="orderId">Order id.</param>
        /// <param name="redemptionDts">Redemption date.</param>
        /// <param name="remainingBalance">Remaining balance.</param>
        public CustomerLoyaltyRedemption(string couponCode = default(string), int couponCodeOid = default(int), bool couponUsed = default(bool), string descriptionForCustomer = default(string), string expirationDts = default(string), string giftCertificateCode = default(string), int giftCertificateOid = default(int), int loyaltyLedgerOid = default(int), int loyaltyPoints = default(int), int loyaltyRedemptionOid = default(int), string orderId = default(string), string redemptionDts = default(string), decimal remainingBalance = default(decimal))
        {
            this.CouponCode = couponCode;
            this.CouponCodeOid = couponCodeOid;
            this.CouponUsed = couponUsed;
            this.DescriptionForCustomer = descriptionForCustomer;
            this.ExpirationDts = expirationDts;
            this.GiftCertificateCode = giftCertificateCode;
            this.GiftCertificateOid = giftCertificateOid;
            this.LoyaltyLedgerOid = loyaltyLedgerOid;
            this.LoyaltyPoints = loyaltyPoints;
            this.LoyaltyRedemptionOid = loyaltyRedemptionOid;
            this.OrderId = orderId;
            this.RedemptionDts = redemptionDts;
            this.RemainingBalance = remainingBalance;
        }

        /// <summary>
        /// Coupon code
        /// </summary>
        /// <value>Coupon code</value>
        [DataMember(Name="coupon_code", EmitDefaultValue=false)]
        public string CouponCode { get; set; }

        /// <summary>
        /// Coupon code OID
        /// </summary>
        /// <value>Coupon code OID</value>
        [DataMember(Name="coupon_code_oid", EmitDefaultValue=false)]
        public int CouponCodeOid { get; set; }

        /// <summary>
        /// Coupon used
        /// </summary>
        /// <value>Coupon used</value>
        [DataMember(Name="coupon_used", EmitDefaultValue=false)]
        public bool CouponUsed { get; set; }

        /// <summary>
        /// Description for customer
        /// </summary>
        /// <value>Description for customer</value>
        [DataMember(Name="description_for_customer", EmitDefaultValue=false)]
        public string DescriptionForCustomer { get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        /// <value>Expiration date</value>
        [DataMember(Name="expiration_dts", EmitDefaultValue=false)]
        public string ExpirationDts { get; set; }

        /// <summary>
        /// Gift certificate code
        /// </summary>
        /// <value>Gift certificate code</value>
        [DataMember(Name="gift_certificate_code", EmitDefaultValue=false)]
        public string GiftCertificateCode { get; set; }

        /// <summary>
        /// Gift certificate oid
        /// </summary>
        /// <value>Gift certificate oid</value>
        [DataMember(Name="gift_certificate_oid", EmitDefaultValue=false)]
        public int GiftCertificateOid { get; set; }

        /// <summary>
        /// Loyalty ledger OID
        /// </summary>
        /// <value>Loyalty ledger OID</value>
        [DataMember(Name="loyalty_ledger_oid", EmitDefaultValue=false)]
        public int LoyaltyLedgerOid { get; set; }

        /// <summary>
        /// Loyalty points
        /// </summary>
        /// <value>Loyalty points</value>
        [DataMember(Name="loyalty_points", EmitDefaultValue=false)]
        public int LoyaltyPoints { get; set; }

        /// <summary>
        /// Loyalty redemption OID
        /// </summary>
        /// <value>Loyalty redemption OID</value>
        [DataMember(Name="loyalty_redemption_oid", EmitDefaultValue=false)]
        public int LoyaltyRedemptionOid { get; set; }

        /// <summary>
        /// Order id
        /// </summary>
        /// <value>Order id</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Redemption date
        /// </summary>
        /// <value>Redemption date</value>
        [DataMember(Name="redemption_dts", EmitDefaultValue=false)]
        public string RedemptionDts { get; set; }

        /// <summary>
        /// Remaining balance
        /// </summary>
        /// <value>Remaining balance</value>
        [DataMember(Name="remaining_balance", EmitDefaultValue=false)]
        public decimal RemainingBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerLoyaltyRedemption {\n");
            sb.Append("  CouponCode: ").Append(CouponCode).Append("\n");
            sb.Append("  CouponCodeOid: ").Append(CouponCodeOid).Append("\n");
            sb.Append("  CouponUsed: ").Append(CouponUsed).Append("\n");
            sb.Append("  DescriptionForCustomer: ").Append(DescriptionForCustomer).Append("\n");
            sb.Append("  ExpirationDts: ").Append(ExpirationDts).Append("\n");
            sb.Append("  GiftCertificateCode: ").Append(GiftCertificateCode).Append("\n");
            sb.Append("  GiftCertificateOid: ").Append(GiftCertificateOid).Append("\n");
            sb.Append("  LoyaltyLedgerOid: ").Append(LoyaltyLedgerOid).Append("\n");
            sb.Append("  LoyaltyPoints: ").Append(LoyaltyPoints).Append("\n");
            sb.Append("  LoyaltyRedemptionOid: ").Append(LoyaltyRedemptionOid).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  RedemptionDts: ").Append(RedemptionDts).Append("\n");
            sb.Append("  RemainingBalance: ").Append(RemainingBalance).Append("\n");
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
            return this.Equals(input as CustomerLoyaltyRedemption);
        }

        /// <summary>
        /// Returns true if CustomerLoyaltyRedemption instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerLoyaltyRedemption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerLoyaltyRedemption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CouponCode == input.CouponCode ||
                    (this.CouponCode != null &&
                    this.CouponCode.Equals(input.CouponCode))
                ) && 
                (
                    this.CouponCodeOid == input.CouponCodeOid ||
                    (this.CouponCodeOid != null &&
                    this.CouponCodeOid.Equals(input.CouponCodeOid))
                ) && 
                (
                    this.CouponUsed == input.CouponUsed ||
                    (this.CouponUsed != null &&
                    this.CouponUsed.Equals(input.CouponUsed))
                ) && 
                (
                    this.DescriptionForCustomer == input.DescriptionForCustomer ||
                    (this.DescriptionForCustomer != null &&
                    this.DescriptionForCustomer.Equals(input.DescriptionForCustomer))
                ) && 
                (
                    this.ExpirationDts == input.ExpirationDts ||
                    (this.ExpirationDts != null &&
                    this.ExpirationDts.Equals(input.ExpirationDts))
                ) && 
                (
                    this.GiftCertificateCode == input.GiftCertificateCode ||
                    (this.GiftCertificateCode != null &&
                    this.GiftCertificateCode.Equals(input.GiftCertificateCode))
                ) && 
                (
                    this.GiftCertificateOid == input.GiftCertificateOid ||
                    (this.GiftCertificateOid != null &&
                    this.GiftCertificateOid.Equals(input.GiftCertificateOid))
                ) && 
                (
                    this.LoyaltyLedgerOid == input.LoyaltyLedgerOid ||
                    (this.LoyaltyLedgerOid != null &&
                    this.LoyaltyLedgerOid.Equals(input.LoyaltyLedgerOid))
                ) && 
                (
                    this.LoyaltyPoints == input.LoyaltyPoints ||
                    (this.LoyaltyPoints != null &&
                    this.LoyaltyPoints.Equals(input.LoyaltyPoints))
                ) && 
                (
                    this.LoyaltyRedemptionOid == input.LoyaltyRedemptionOid ||
                    (this.LoyaltyRedemptionOid != null &&
                    this.LoyaltyRedemptionOid.Equals(input.LoyaltyRedemptionOid))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.RedemptionDts == input.RedemptionDts ||
                    (this.RedemptionDts != null &&
                    this.RedemptionDts.Equals(input.RedemptionDts))
                ) && 
                (
                    this.RemainingBalance == input.RemainingBalance ||
                    (this.RemainingBalance != null &&
                    this.RemainingBalance.Equals(input.RemainingBalance))
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
                if (this.CouponCode != null)
                    hashCode = hashCode * 59 + this.CouponCode.GetHashCode();
                if (this.CouponCodeOid != null)
                    hashCode = hashCode * 59 + this.CouponCodeOid.GetHashCode();
                if (this.CouponUsed != null)
                    hashCode = hashCode * 59 + this.CouponUsed.GetHashCode();
                if (this.DescriptionForCustomer != null)
                    hashCode = hashCode * 59 + this.DescriptionForCustomer.GetHashCode();
                if (this.ExpirationDts != null)
                    hashCode = hashCode * 59 + this.ExpirationDts.GetHashCode();
                if (this.GiftCertificateCode != null)
                    hashCode = hashCode * 59 + this.GiftCertificateCode.GetHashCode();
                if (this.GiftCertificateOid != null)
                    hashCode = hashCode * 59 + this.GiftCertificateOid.GetHashCode();
                if (this.LoyaltyLedgerOid != null)
                    hashCode = hashCode * 59 + this.LoyaltyLedgerOid.GetHashCode();
                if (this.LoyaltyPoints != null)
                    hashCode = hashCode * 59 + this.LoyaltyPoints.GetHashCode();
                if (this.LoyaltyRedemptionOid != null)
                    hashCode = hashCode * 59 + this.LoyaltyRedemptionOid.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.RedemptionDts != null)
                    hashCode = hashCode * 59 + this.RedemptionDts.GetHashCode();
                if (this.RemainingBalance != null)
                    hashCode = hashCode * 59 + this.RemainingBalance.GetHashCode();
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
