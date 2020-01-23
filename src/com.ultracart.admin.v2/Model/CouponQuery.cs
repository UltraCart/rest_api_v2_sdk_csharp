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
    /// CouponQuery
    /// </summary>
    [DataContract]
    public partial class CouponQuery :  IEquatable<CouponQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponQuery" /> class.
        /// </summary>
        /// <param name="AffiliateOid">Affiliate oid.</param>
        /// <param name="CouponType">The type of coupon..</param>
        /// <param name="Description">Description of this coupon.</param>
        /// <param name="ExcludeExpired">Exclude expired coupons if true.</param>
        /// <param name="ExpirationDtsBegin">Expiration date begin.</param>
        /// <param name="ExpirationDtsEnd">Expiration date begin.</param>
        /// <param name="MerchantCode">Merchant code is a unique character string for this coupon..</param>
        /// <param name="StartDtsBegin">Start date begin.</param>
        /// <param name="StartDtsEnd">Start date end.</param>
        public CouponQuery(int? AffiliateOid = default(int?), string CouponType = default(string), string Description = default(string), bool? ExcludeExpired = default(bool?), string ExpirationDtsBegin = default(string), string ExpirationDtsEnd = default(string), string MerchantCode = default(string), string StartDtsBegin = default(string), string StartDtsEnd = default(string))
        {
            this.AffiliateOid = AffiliateOid;
            this.CouponType = CouponType;
            this.Description = Description;
            this.ExcludeExpired = ExcludeExpired;
            this.ExpirationDtsBegin = ExpirationDtsBegin;
            this.ExpirationDtsEnd = ExpirationDtsEnd;
            this.MerchantCode = MerchantCode;
            this.StartDtsBegin = StartDtsBegin;
            this.StartDtsEnd = StartDtsEnd;
        }
        
        /// <summary>
        /// Affiliate oid
        /// </summary>
        /// <value>Affiliate oid</value>
        [DataMember(Name="affiliate_oid", EmitDefaultValue=false)]
        public int? AffiliateOid { get; set; }

        /// <summary>
        /// The type of coupon.
        /// </summary>
        /// <value>The type of coupon.</value>
        [DataMember(Name="coupon_type", EmitDefaultValue=false)]
        public string CouponType { get; set; }

        /// <summary>
        /// Description of this coupon
        /// </summary>
        /// <value>Description of this coupon</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Exclude expired coupons if true
        /// </summary>
        /// <value>Exclude expired coupons if true</value>
        [DataMember(Name="exclude_expired", EmitDefaultValue=false)]
        public bool? ExcludeExpired { get; set; }

        /// <summary>
        /// Expiration date begin
        /// </summary>
        /// <value>Expiration date begin</value>
        [DataMember(Name="expiration_dts_begin", EmitDefaultValue=false)]
        public string ExpirationDtsBegin { get; set; }

        /// <summary>
        /// Expiration date begin
        /// </summary>
        /// <value>Expiration date begin</value>
        [DataMember(Name="expiration_dts_end", EmitDefaultValue=false)]
        public string ExpirationDtsEnd { get; set; }

        /// <summary>
        /// Merchant code is a unique character string for this coupon.
        /// </summary>
        /// <value>Merchant code is a unique character string for this coupon.</value>
        [DataMember(Name="merchant_code", EmitDefaultValue=false)]
        public string MerchantCode { get; set; }

        /// <summary>
        /// Start date begin
        /// </summary>
        /// <value>Start date begin</value>
        [DataMember(Name="start_dts_begin", EmitDefaultValue=false)]
        public string StartDtsBegin { get; set; }

        /// <summary>
        /// Start date end
        /// </summary>
        /// <value>Start date end</value>
        [DataMember(Name="start_dts_end", EmitDefaultValue=false)]
        public string StartDtsEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponQuery {\n");
            sb.Append("  AffiliateOid: ").Append(AffiliateOid).Append("\n");
            sb.Append("  CouponType: ").Append(CouponType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExcludeExpired: ").Append(ExcludeExpired).Append("\n");
            sb.Append("  ExpirationDtsBegin: ").Append(ExpirationDtsBegin).Append("\n");
            sb.Append("  ExpirationDtsEnd: ").Append(ExpirationDtsEnd).Append("\n");
            sb.Append("  MerchantCode: ").Append(MerchantCode).Append("\n");
            sb.Append("  StartDtsBegin: ").Append(StartDtsBegin).Append("\n");
            sb.Append("  StartDtsEnd: ").Append(StartDtsEnd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as CouponQuery);
        }

        /// <summary>
        /// Returns true if CouponQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AffiliateOid == input.AffiliateOid ||
                    (this.AffiliateOid != null &&
                    this.AffiliateOid.Equals(input.AffiliateOid))
                ) && 
                (
                    this.CouponType == input.CouponType ||
                    (this.CouponType != null &&
                    this.CouponType.Equals(input.CouponType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExcludeExpired == input.ExcludeExpired ||
                    (this.ExcludeExpired != null &&
                    this.ExcludeExpired.Equals(input.ExcludeExpired))
                ) && 
                (
                    this.ExpirationDtsBegin == input.ExpirationDtsBegin ||
                    (this.ExpirationDtsBegin != null &&
                    this.ExpirationDtsBegin.Equals(input.ExpirationDtsBegin))
                ) && 
                (
                    this.ExpirationDtsEnd == input.ExpirationDtsEnd ||
                    (this.ExpirationDtsEnd != null &&
                    this.ExpirationDtsEnd.Equals(input.ExpirationDtsEnd))
                ) && 
                (
                    this.MerchantCode == input.MerchantCode ||
                    (this.MerchantCode != null &&
                    this.MerchantCode.Equals(input.MerchantCode))
                ) && 
                (
                    this.StartDtsBegin == input.StartDtsBegin ||
                    (this.StartDtsBegin != null &&
                    this.StartDtsBegin.Equals(input.StartDtsBegin))
                ) && 
                (
                    this.StartDtsEnd == input.StartDtsEnd ||
                    (this.StartDtsEnd != null &&
                    this.StartDtsEnd.Equals(input.StartDtsEnd))
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
                if (this.AffiliateOid != null)
                    hashCode = hashCode * 59 + this.AffiliateOid.GetHashCode();
                if (this.CouponType != null)
                    hashCode = hashCode * 59 + this.CouponType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExcludeExpired != null)
                    hashCode = hashCode * 59 + this.ExcludeExpired.GetHashCode();
                if (this.ExpirationDtsBegin != null)
                    hashCode = hashCode * 59 + this.ExpirationDtsBegin.GetHashCode();
                if (this.ExpirationDtsEnd != null)
                    hashCode = hashCode * 59 + this.ExpirationDtsEnd.GetHashCode();
                if (this.MerchantCode != null)
                    hashCode = hashCode * 59 + this.MerchantCode.GetHashCode();
                if (this.StartDtsBegin != null)
                    hashCode = hashCode * 59 + this.StartDtsBegin.GetHashCode();
                if (this.StartDtsEnd != null)
                    hashCode = hashCode * 59 + this.StartDtsEnd.GetHashCode();
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