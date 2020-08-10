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
    /// OrderMarketing
    /// </summary>
    [DataContract]
    public partial class OrderMarketing :  IEquatable<OrderMarketing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderMarketing" /> class.
        /// </summary>
        /// <param name="advertisingSource">Advertising source.</param>
        /// <param name="mailingList">True if the customer has opted into mailing list subscription.</param>
        /// <param name="referralCode">Referral code.</param>
        public OrderMarketing(string advertisingSource = default(string), bool? mailingList = default(bool?), string referralCode = default(string))
        {
            this.AdvertisingSource = advertisingSource;
            this.MailingList = mailingList;
            this.ReferralCode = referralCode;
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
            return this.Equals(input as OrderMarketing);
        }

        /// <summary>
        /// Returns true if OrderMarketing instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderMarketing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderMarketing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdvertisingSource == input.AdvertisingSource ||
                    (this.AdvertisingSource != null &&
                    this.AdvertisingSource.Equals(input.AdvertisingSource))
                ) && 
                (
                    this.MailingList == input.MailingList ||
                    (this.MailingList != null &&
                    this.MailingList.Equals(input.MailingList))
                ) && 
                (
                    this.ReferralCode == input.ReferralCode ||
                    (this.ReferralCode != null &&
                    this.ReferralCode.Equals(input.ReferralCode))
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
                if (this.AdvertisingSource != null)
                    hashCode = hashCode * 59 + this.AdvertisingSource.GetHashCode();
                if (this.MailingList != null)
                    hashCode = hashCode * 59 + this.MailingList.GetHashCode();
                if (this.ReferralCode != null)
                    hashCode = hashCode * 59 + this.ReferralCode.GetHashCode();
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
