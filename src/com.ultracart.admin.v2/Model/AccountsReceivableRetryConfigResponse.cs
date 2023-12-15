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
    /// AccountsReceivableRetryConfigResponse
    /// </summary>
    [DataContract]
    public partial class AccountsReceivableRetryConfigResponse :  IEquatable<AccountsReceivableRetryConfigResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsReceivableRetryConfigResponse" /> class.
        /// </summary>
        /// <param name="config">config.</param>
        /// <param name="couponCodes">couponCodes.</param>
        /// <param name="emails">emails.</param>
        /// <param name="error">error.</param>
        /// <param name="hasLinkedAccounts">hasLinkedAccounts.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="success">Indicates if API call was successful.</param>
        /// <param name="warning">warning.</param>
        public AccountsReceivableRetryConfigResponse(AccountsReceivableRetryConfig config = default(AccountsReceivableRetryConfig), List<string> couponCodes = default(List<string>), List<string> emails = default(List<string>), Error error = default(Error), bool hasLinkedAccounts = default(bool), ResponseMetadata metadata = default(ResponseMetadata), bool success = default(bool), Warning warning = default(Warning))
        {
            this.Config = config;
            this.CouponCodes = couponCodes;
            this.Emails = emails;
            this.Error = error;
            this.HasLinkedAccounts = hasLinkedAccounts;
            this.Metadata = metadata;
            this.Success = success;
            this.Warning = warning;
        }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public AccountsReceivableRetryConfig Config { get; set; }

        /// <summary>
        /// Gets or Sets CouponCodes
        /// </summary>
        [DataMember(Name="coupon_codes", EmitDefaultValue=false)]
        public List<string> CouponCodes { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Gets or Sets HasLinkedAccounts
        /// </summary>
        [DataMember(Name="has_linked_accounts", EmitDefaultValue=false)]
        public bool HasLinkedAccounts { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Indicates if API call was successful
        /// </summary>
        /// <value>Indicates if API call was successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Warning
        /// </summary>
        [DataMember(Name="warning", EmitDefaultValue=false)]
        public Warning Warning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountsReceivableRetryConfigResponse {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  CouponCodes: ").Append(CouponCodes).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  HasLinkedAccounts: ").Append(HasLinkedAccounts).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Warning: ").Append(Warning).Append("\n");
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
            return this.Equals(input as AccountsReceivableRetryConfigResponse);
        }

        /// <summary>
        /// Returns true if AccountsReceivableRetryConfigResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountsReceivableRetryConfigResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountsReceivableRetryConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.CouponCodes == input.CouponCodes ||
                    this.CouponCodes != null &&
                    input.CouponCodes != null &&
                    this.CouponCodes.SequenceEqual(input.CouponCodes)
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.HasLinkedAccounts == input.HasLinkedAccounts ||
                    (this.HasLinkedAccounts != null &&
                    this.HasLinkedAccounts.Equals(input.HasLinkedAccounts))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Warning == input.Warning ||
                    (this.Warning != null &&
                    this.Warning.Equals(input.Warning))
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
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.CouponCodes != null)
                    hashCode = hashCode * 59 + this.CouponCodes.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.HasLinkedAccounts != null)
                    hashCode = hashCode * 59 + this.HasLinkedAccounts.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Warning != null)
                    hashCode = hashCode * 59 + this.Warning.GetHashCode();
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
