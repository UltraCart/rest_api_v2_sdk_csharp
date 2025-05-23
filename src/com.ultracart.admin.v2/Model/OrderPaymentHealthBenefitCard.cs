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
    /// OrderPaymentHealthBenefitCard
    /// </summary>
    [DataContract]
    public partial class OrderPaymentHealthBenefitCard :  IEquatable<OrderPaymentHealthBenefitCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPaymentHealthBenefitCard" /> class.
        /// </summary>
        /// <param name="healthBenefitCardExpirationMonth">Health benefit card expiration month (1-12).</param>
        /// <param name="healthBenefitCardExpirationYear">Health benefit card expiration year (Four digit year).</param>
        /// <param name="healthBenefitCardNumber">Health benefit card number (masked to last 4).</param>
        /// <param name="healthBenefitCardNumberToken">Health benefit card number token from hosted fields used to update the health benefit card number.</param>
        /// <param name="healthBenefitCardNumberTruncated">True if the health benefit card has been truncated.</param>
        /// <param name="healthBenefitCardVerificationNumberToken">Health benefit card verification number token from hosted fields, only for import/insert of new orders, completely ignored for updates, and always null/empty for queries.</param>
        public OrderPaymentHealthBenefitCard(int healthBenefitCardExpirationMonth = default(int), int healthBenefitCardExpirationYear = default(int), string healthBenefitCardNumber = default(string), string healthBenefitCardNumberToken = default(string), bool healthBenefitCardNumberTruncated = default(bool), string healthBenefitCardVerificationNumberToken = default(string))
        {
            this.HealthBenefitCardExpirationMonth = healthBenefitCardExpirationMonth;
            this.HealthBenefitCardExpirationYear = healthBenefitCardExpirationYear;
            this.HealthBenefitCardNumber = healthBenefitCardNumber;
            this.HealthBenefitCardNumberToken = healthBenefitCardNumberToken;
            this.HealthBenefitCardNumberTruncated = healthBenefitCardNumberTruncated;
            this.HealthBenefitCardVerificationNumberToken = healthBenefitCardVerificationNumberToken;
        }

        /// <summary>
        /// Health benefit card expiration month (1-12)
        /// </summary>
        /// <value>Health benefit card expiration month (1-12)</value>
        [DataMember(Name="health_benefit_card_expiration_month", EmitDefaultValue=false)]
        public int HealthBenefitCardExpirationMonth { get; set; }

        /// <summary>
        /// Health benefit card expiration year (Four digit year)
        /// </summary>
        /// <value>Health benefit card expiration year (Four digit year)</value>
        [DataMember(Name="health_benefit_card_expiration_year", EmitDefaultValue=false)]
        public int HealthBenefitCardExpirationYear { get; set; }

        /// <summary>
        /// Health benefit card number (masked to last 4)
        /// </summary>
        /// <value>Health benefit card number (masked to last 4)</value>
        [DataMember(Name="health_benefit_card_number", EmitDefaultValue=false)]
        public string HealthBenefitCardNumber { get; set; }

        /// <summary>
        /// Health benefit card number token from hosted fields used to update the health benefit card number
        /// </summary>
        /// <value>Health benefit card number token from hosted fields used to update the health benefit card number</value>
        [DataMember(Name="health_benefit_card_number_token", EmitDefaultValue=false)]
        public string HealthBenefitCardNumberToken { get; set; }

        /// <summary>
        /// True if the health benefit card has been truncated
        /// </summary>
        /// <value>True if the health benefit card has been truncated</value>
        [DataMember(Name="health_benefit_card_number_truncated", EmitDefaultValue=false)]
        public bool HealthBenefitCardNumberTruncated { get; set; }

        /// <summary>
        /// Health benefit card verification number token from hosted fields, only for import/insert of new orders, completely ignored for updates, and always null/empty for queries
        /// </summary>
        /// <value>Health benefit card verification number token from hosted fields, only for import/insert of new orders, completely ignored for updates, and always null/empty for queries</value>
        [DataMember(Name="health_benefit_card_verification_number_token", EmitDefaultValue=false)]
        public string HealthBenefitCardVerificationNumberToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderPaymentHealthBenefitCard {\n");
            sb.Append("  HealthBenefitCardExpirationMonth: ").Append(HealthBenefitCardExpirationMonth).Append("\n");
            sb.Append("  HealthBenefitCardExpirationYear: ").Append(HealthBenefitCardExpirationYear).Append("\n");
            sb.Append("  HealthBenefitCardNumber: ").Append(HealthBenefitCardNumber).Append("\n");
            sb.Append("  HealthBenefitCardNumberToken: ").Append(HealthBenefitCardNumberToken).Append("\n");
            sb.Append("  HealthBenefitCardNumberTruncated: ").Append(HealthBenefitCardNumberTruncated).Append("\n");
            sb.Append("  HealthBenefitCardVerificationNumberToken: ").Append(HealthBenefitCardVerificationNumberToken).Append("\n");
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
            return this.Equals(input as OrderPaymentHealthBenefitCard);
        }

        /// <summary>
        /// Returns true if OrderPaymentHealthBenefitCard instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderPaymentHealthBenefitCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderPaymentHealthBenefitCard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HealthBenefitCardExpirationMonth == input.HealthBenefitCardExpirationMonth ||
                    (this.HealthBenefitCardExpirationMonth != null &&
                    this.HealthBenefitCardExpirationMonth.Equals(input.HealthBenefitCardExpirationMonth))
                ) && 
                (
                    this.HealthBenefitCardExpirationYear == input.HealthBenefitCardExpirationYear ||
                    (this.HealthBenefitCardExpirationYear != null &&
                    this.HealthBenefitCardExpirationYear.Equals(input.HealthBenefitCardExpirationYear))
                ) && 
                (
                    this.HealthBenefitCardNumber == input.HealthBenefitCardNumber ||
                    (this.HealthBenefitCardNumber != null &&
                    this.HealthBenefitCardNumber.Equals(input.HealthBenefitCardNumber))
                ) && 
                (
                    this.HealthBenefitCardNumberToken == input.HealthBenefitCardNumberToken ||
                    (this.HealthBenefitCardNumberToken != null &&
                    this.HealthBenefitCardNumberToken.Equals(input.HealthBenefitCardNumberToken))
                ) && 
                (
                    this.HealthBenefitCardNumberTruncated == input.HealthBenefitCardNumberTruncated ||
                    (this.HealthBenefitCardNumberTruncated != null &&
                    this.HealthBenefitCardNumberTruncated.Equals(input.HealthBenefitCardNumberTruncated))
                ) && 
                (
                    this.HealthBenefitCardVerificationNumberToken == input.HealthBenefitCardVerificationNumberToken ||
                    (this.HealthBenefitCardVerificationNumberToken != null &&
                    this.HealthBenefitCardVerificationNumberToken.Equals(input.HealthBenefitCardVerificationNumberToken))
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
                if (this.HealthBenefitCardExpirationMonth != null)
                    hashCode = hashCode * 59 + this.HealthBenefitCardExpirationMonth.GetHashCode();
                if (this.HealthBenefitCardExpirationYear != null)
                    hashCode = hashCode * 59 + this.HealthBenefitCardExpirationYear.GetHashCode();
                if (this.HealthBenefitCardNumber != null)
                    hashCode = hashCode * 59 + this.HealthBenefitCardNumber.GetHashCode();
                if (this.HealthBenefitCardNumberToken != null)
                    hashCode = hashCode * 59 + this.HealthBenefitCardNumberToken.GetHashCode();
                if (this.HealthBenefitCardNumberTruncated != null)
                    hashCode = hashCode * 59 + this.HealthBenefitCardNumberTruncated.GetHashCode();
                if (this.HealthBenefitCardVerificationNumberToken != null)
                    hashCode = hashCode * 59 + this.HealthBenefitCardVerificationNumberToken.GetHashCode();
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
