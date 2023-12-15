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
    /// GiftCertificateCreateRequest
    /// </summary>
    [DataContract]
    public partial class GiftCertificateCreateRequest :  IEquatable<GiftCertificateCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GiftCertificateCreateRequest" /> class.
        /// </summary>
        /// <param name="amount">Initial amount of this gift certificate..</param>
        /// <param name="email">The email address (customer/owner) associated with this gift certificate..</param>
        /// <param name="expirationDts">Expiration date time..</param>
        /// <param name="initialLedgerDescription">A brief description of how and/or why this gift certificate was created..</param>
        /// <param name="merchantNote">Any internal details you wish to record about this gift certificate..</param>
        public GiftCertificateCreateRequest(decimal? amount = default(decimal?), string email = default(string), string expirationDts = default(string), string initialLedgerDescription = default(string), string merchantNote = default(string))
        {
            this.Amount = amount;
            this.Email = email;
            this.ExpirationDts = expirationDts;
            this.InitialLedgerDescription = initialLedgerDescription;
            this.MerchantNote = merchantNote;
        }
        
        /// <summary>
        /// Initial amount of this gift certificate.
        /// </summary>
        /// <value>Initial amount of this gift certificate.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The email address (customer/owner) associated with this gift certificate.
        /// </summary>
        /// <value>The email address (customer/owner) associated with this gift certificate.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Expiration date time.
        /// </summary>
        /// <value>Expiration date time.</value>
        [DataMember(Name="expiration_dts", EmitDefaultValue=false)]
        public string ExpirationDts { get; set; }

        /// <summary>
        /// A brief description of how and/or why this gift certificate was created.
        /// </summary>
        /// <value>A brief description of how and/or why this gift certificate was created.</value>
        [DataMember(Name="initial_ledger_description", EmitDefaultValue=false)]
        public string InitialLedgerDescription { get; set; }

        /// <summary>
        /// Any internal details you wish to record about this gift certificate.
        /// </summary>
        /// <value>Any internal details you wish to record about this gift certificate.</value>
        [DataMember(Name="merchant_note", EmitDefaultValue=false)]
        public string MerchantNote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GiftCertificateCreateRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExpirationDts: ").Append(ExpirationDts).Append("\n");
            sb.Append("  InitialLedgerDescription: ").Append(InitialLedgerDescription).Append("\n");
            sb.Append("  MerchantNote: ").Append(MerchantNote).Append("\n");
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
            return this.Equals(input as GiftCertificateCreateRequest);
        }

        /// <summary>
        /// Returns true if GiftCertificateCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GiftCertificateCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GiftCertificateCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.ExpirationDts == input.ExpirationDts ||
                    (this.ExpirationDts != null &&
                    this.ExpirationDts.Equals(input.ExpirationDts))
                ) && 
                (
                    this.InitialLedgerDescription == input.InitialLedgerDescription ||
                    (this.InitialLedgerDescription != null &&
                    this.InitialLedgerDescription.Equals(input.InitialLedgerDescription))
                ) && 
                (
                    this.MerchantNote == input.MerchantNote ||
                    (this.MerchantNote != null &&
                    this.MerchantNote.Equals(input.MerchantNote))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.ExpirationDts != null)
                    hashCode = hashCode * 59 + this.ExpirationDts.GetHashCode();
                if (this.InitialLedgerDescription != null)
                    hashCode = hashCode * 59 + this.InitialLedgerDescription.GetHashCode();
                if (this.MerchantNote != null)
                    hashCode = hashCode * 59 + this.MerchantNote.GetHashCode();
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
