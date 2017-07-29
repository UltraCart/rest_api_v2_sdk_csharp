/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
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
    /// OrderMarketing
    /// </summary>
    [DataContract]
    public partial class OrderMarketing :  IEquatable<OrderMarketing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderMarketing" /> class.
        /// </summary>
        /// <param name="AdvertisingSource">Advertising source.</param>
        /// <param name="MailingList">True if the customer has opted into mailing list subscription.</param>
        /// <param name="ReferralCode">Referral code.</param>
        public OrderMarketing(string AdvertisingSource = default(string), bool? MailingList = default(bool?), string ReferralCode = default(string))
        {
            this.AdvertisingSource = AdvertisingSource;
            this.MailingList = MailingList;
            this.ReferralCode = ReferralCode;
        }
        
        /// <summary>
        /// Advertising source
        /// </summary>
        /// <value>Advertising source</value>
        [DataMember(Name="advertising_source", EmitDefaultValue=false)]
        public string AdvertisingSource { get; set; }

        /// <summary>
        /// True if the customer has opted into mailing list subscription
        /// </summary>
        /// <value>True if the customer has opted into mailing list subscription</value>
        [DataMember(Name="mailing_list", EmitDefaultValue=false)]
        public bool? MailingList { get; set; }

        /// <summary>
        /// Referral code
        /// </summary>
        /// <value>Referral code</value>
        [DataMember(Name="referral_code", EmitDefaultValue=false)]
        public string ReferralCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderMarketing {\n");
            sb.Append("  AdvertisingSource: ").Append(AdvertisingSource).Append("\n");
            sb.Append("  MailingList: ").Append(MailingList).Append("\n");
            sb.Append("  ReferralCode: ").Append(ReferralCode).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrderMarketing);
        }

        /// <summary>
        /// Returns true if OrderMarketing instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderMarketing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderMarketing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdvertisingSource == other.AdvertisingSource ||
                    this.AdvertisingSource != null &&
                    this.AdvertisingSource.Equals(other.AdvertisingSource)
                ) && 
                (
                    this.MailingList == other.MailingList ||
                    this.MailingList != null &&
                    this.MailingList.Equals(other.MailingList)
                ) && 
                (
                    this.ReferralCode == other.ReferralCode ||
                    this.ReferralCode != null &&
                    this.ReferralCode.Equals(other.ReferralCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AdvertisingSource != null)
                    hash = hash * 59 + this.AdvertisingSource.GetHashCode();
                if (this.MailingList != null)
                    hash = hash * 59 + this.MailingList.GetHashCode();
                if (this.ReferralCode != null)
                    hash = hash * 59 + this.ReferralCode.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // AdvertisingSource (string) maxLength
            if(this.AdvertisingSource != null && this.AdvertisingSource.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdvertisingSource, length must be less than 50.", new [] { "AdvertisingSource" });
            }

            // ReferralCode (string) maxLength
            if(this.ReferralCode != null && this.ReferralCode.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferralCode, length must be less than 30.", new [] { "ReferralCode" });
            }

            yield break;
        }
    }

}
