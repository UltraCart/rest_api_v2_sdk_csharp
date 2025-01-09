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
    /// OrderCoupon
    /// </summary>
    [DataContract]
    public partial class OrderCoupon :  IEquatable<OrderCoupon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCoupon" /> class.
        /// </summary>
        /// <param name="accountingCode">QuickBooks accounting code for this coupon.</param>
        /// <param name="automaticallyApplied">Whether or not the coupon was automatically applied to the order.</param>
        /// <param name="baseCouponCode">Coupon code configured by the merchant.  Will differ if the customer used a one time coupon code generated off this base coupon.</param>
        /// <param name="couponCode">Coupon code entered by the customer.</param>
        /// <param name="hdieFromCustomer">True if this coupon is hidde from the customer.</param>
        public OrderCoupon(string accountingCode = default(string), bool automaticallyApplied = default(bool), string baseCouponCode = default(string), string couponCode = default(string), bool hdieFromCustomer = default(bool))
        {
            this.AccountingCode = accountingCode;
            this.AutomaticallyApplied = automaticallyApplied;
            this.BaseCouponCode = baseCouponCode;
            this.CouponCode = couponCode;
            this.HdieFromCustomer = hdieFromCustomer;
        }

        /// <summary>
        /// QuickBooks accounting code for this coupon
        /// </summary>
        /// <value>QuickBooks accounting code for this coupon</value>
        [DataMember(Name="accounting_code", EmitDefaultValue=false)]
        public string AccountingCode { get; set; }

        /// <summary>
        /// Whether or not the coupon was automatically applied to the order
        /// </summary>
        /// <value>Whether or not the coupon was automatically applied to the order</value>
        [DataMember(Name="automatically_applied", EmitDefaultValue=false)]
        public bool AutomaticallyApplied { get; set; }

        /// <summary>
        /// Coupon code configured by the merchant.  Will differ if the customer used a one time coupon code generated off this base coupon
        /// </summary>
        /// <value>Coupon code configured by the merchant.  Will differ if the customer used a one time coupon code generated off this base coupon</value>
        [DataMember(Name="base_coupon_code", EmitDefaultValue=false)]
        public string BaseCouponCode { get; set; }

        /// <summary>
        /// Coupon code entered by the customer
        /// </summary>
        /// <value>Coupon code entered by the customer</value>
        [DataMember(Name="coupon_code", EmitDefaultValue=false)]
        public string CouponCode { get; set; }

        /// <summary>
        /// True if this coupon is hidde from the customer
        /// </summary>
        /// <value>True if this coupon is hidde from the customer</value>
        [DataMember(Name="hdie_from_customer", EmitDefaultValue=false)]
        public bool HdieFromCustomer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderCoupon {\n");
            sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
            sb.Append("  AutomaticallyApplied: ").Append(AutomaticallyApplied).Append("\n");
            sb.Append("  BaseCouponCode: ").Append(BaseCouponCode).Append("\n");
            sb.Append("  CouponCode: ").Append(CouponCode).Append("\n");
            sb.Append("  HdieFromCustomer: ").Append(HdieFromCustomer).Append("\n");
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
            return this.Equals(input as OrderCoupon);
        }

        /// <summary>
        /// Returns true if OrderCoupon instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderCoupon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderCoupon input)
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
                    this.AutomaticallyApplied == input.AutomaticallyApplied ||
                    (this.AutomaticallyApplied != null &&
                    this.AutomaticallyApplied.Equals(input.AutomaticallyApplied))
                ) && 
                (
                    this.BaseCouponCode == input.BaseCouponCode ||
                    (this.BaseCouponCode != null &&
                    this.BaseCouponCode.Equals(input.BaseCouponCode))
                ) && 
                (
                    this.CouponCode == input.CouponCode ||
                    (this.CouponCode != null &&
                    this.CouponCode.Equals(input.CouponCode))
                ) && 
                (
                    this.HdieFromCustomer == input.HdieFromCustomer ||
                    (this.HdieFromCustomer != null &&
                    this.HdieFromCustomer.Equals(input.HdieFromCustomer))
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
                if (this.AutomaticallyApplied != null)
                    hashCode = hashCode * 59 + this.AutomaticallyApplied.GetHashCode();
                if (this.BaseCouponCode != null)
                    hashCode = hashCode * 59 + this.BaseCouponCode.GetHashCode();
                if (this.CouponCode != null)
                    hashCode = hashCode * 59 + this.CouponCode.GetHashCode();
                if (this.HdieFromCustomer != null)
                    hashCode = hashCode * 59 + this.HdieFromCustomer.GetHashCode();
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
            // BaseCouponCode (string) maxLength
            if(this.BaseCouponCode != null && this.BaseCouponCode.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BaseCouponCode, length must be less than 20.", new [] { "BaseCouponCode" });
            }


            // CouponCode (string) maxLength
            if(this.CouponCode != null && this.CouponCode.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CouponCode, length must be less than 20.", new [] { "CouponCode" });
            }


            yield break;
        }
    }

}
