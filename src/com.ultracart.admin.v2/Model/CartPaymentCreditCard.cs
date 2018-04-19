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
    /// CartPaymentCreditCard
    /// </summary>
    [DataContract]
    public partial class CartPaymentCreditCard :  IEquatable<CartPaymentCreditCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartPaymentCreditCard" /> class.
        /// </summary>
        /// <param name="CardExpirationMonth">Card expiration month (1-12).</param>
        /// <param name="CardExpirationYear">Card expiration year (four digit year).</param>
        /// <param name="CardNumber">Card number (masked to the last 4).</param>
        /// <param name="CardNumberToken">Hosted field token for the card number.</param>
        /// <param name="CardType">Card type.</param>
        /// <param name="CardVerificationNumber">Card verification number (masked).</param>
        /// <param name="CardVerificationNumberToken">Hosted field token for the card verification number.</param>
        /// <param name="CustomerProfileCreditCardId">ID of the stored credit card to use.</param>
        /// <param name="StoreCreditCard">True if the customer wants to store the card on their profile for future re-use.</param>
        public CartPaymentCreditCard(int? CardExpirationMonth = default(int?), int? CardExpirationYear = default(int?), string CardNumber = default(string), string CardNumberToken = default(string), string CardType = default(string), string CardVerificationNumber = default(string), string CardVerificationNumberToken = default(string), int? CustomerProfileCreditCardId = default(int?), bool? StoreCreditCard = default(bool?))
        {
            this.CardExpirationMonth = CardExpirationMonth;
            this.CardExpirationYear = CardExpirationYear;
            this.CardNumber = CardNumber;
            this.CardNumberToken = CardNumberToken;
            this.CardType = CardType;
            this.CardVerificationNumber = CardVerificationNumber;
            this.CardVerificationNumberToken = CardVerificationNumberToken;
            this.CustomerProfileCreditCardId = CustomerProfileCreditCardId;
            this.StoreCreditCard = StoreCreditCard;
        }
        
        /// <summary>
        /// Card expiration month (1-12)
        /// </summary>
        /// <value>Card expiration month (1-12)</value>
        [DataMember(Name="card_expiration_month", EmitDefaultValue=false)]
        public int? CardExpirationMonth { get; set; }

        /// <summary>
        /// Card expiration year (four digit year)
        /// </summary>
        /// <value>Card expiration year (four digit year)</value>
        [DataMember(Name="card_expiration_year", EmitDefaultValue=false)]
        public int? CardExpirationYear { get; set; }

        /// <summary>
        /// Card number (masked to the last 4)
        /// </summary>
        /// <value>Card number (masked to the last 4)</value>
        [DataMember(Name="card_number", EmitDefaultValue=false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Hosted field token for the card number
        /// </summary>
        /// <value>Hosted field token for the card number</value>
        [DataMember(Name="card_number_token", EmitDefaultValue=false)]
        public string CardNumberToken { get; set; }

        /// <summary>
        /// Card type
        /// </summary>
        /// <value>Card type</value>
        [DataMember(Name="card_type", EmitDefaultValue=false)]
        public string CardType { get; set; }

        /// <summary>
        /// Card verification number (masked)
        /// </summary>
        /// <value>Card verification number (masked)</value>
        [DataMember(Name="card_verification_number", EmitDefaultValue=false)]
        public string CardVerificationNumber { get; set; }

        /// <summary>
        /// Hosted field token for the card verification number
        /// </summary>
        /// <value>Hosted field token for the card verification number</value>
        [DataMember(Name="card_verification_number_token", EmitDefaultValue=false)]
        public string CardVerificationNumberToken { get; set; }

        /// <summary>
        /// ID of the stored credit card to use
        /// </summary>
        /// <value>ID of the stored credit card to use</value>
        [DataMember(Name="customer_profile_credit_card_id", EmitDefaultValue=false)]
        public int? CustomerProfileCreditCardId { get; set; }

        /// <summary>
        /// True if the customer wants to store the card on their profile for future re-use
        /// </summary>
        /// <value>True if the customer wants to store the card on their profile for future re-use</value>
        [DataMember(Name="store_credit_card", EmitDefaultValue=false)]
        public bool? StoreCreditCard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartPaymentCreditCard {\n");
            sb.Append("  CardExpirationMonth: ").Append(CardExpirationMonth).Append("\n");
            sb.Append("  CardExpirationYear: ").Append(CardExpirationYear).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  CardNumberToken: ").Append(CardNumberToken).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  CardVerificationNumber: ").Append(CardVerificationNumber).Append("\n");
            sb.Append("  CardVerificationNumberToken: ").Append(CardVerificationNumberToken).Append("\n");
            sb.Append("  CustomerProfileCreditCardId: ").Append(CustomerProfileCreditCardId).Append("\n");
            sb.Append("  StoreCreditCard: ").Append(StoreCreditCard).Append("\n");
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
            return this.Equals(input as CartPaymentCreditCard);
        }

        /// <summary>
        /// Returns true if CartPaymentCreditCard instances are equal
        /// </summary>
        /// <param name="input">Instance of CartPaymentCreditCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartPaymentCreditCard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardExpirationMonth == input.CardExpirationMonth ||
                    (this.CardExpirationMonth != null &&
                    this.CardExpirationMonth.Equals(input.CardExpirationMonth))
                ) && 
                (
                    this.CardExpirationYear == input.CardExpirationYear ||
                    (this.CardExpirationYear != null &&
                    this.CardExpirationYear.Equals(input.CardExpirationYear))
                ) && 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
                ) && 
                (
                    this.CardNumberToken == input.CardNumberToken ||
                    (this.CardNumberToken != null &&
                    this.CardNumberToken.Equals(input.CardNumberToken))
                ) && 
                (
                    this.CardType == input.CardType ||
                    (this.CardType != null &&
                    this.CardType.Equals(input.CardType))
                ) && 
                (
                    this.CardVerificationNumber == input.CardVerificationNumber ||
                    (this.CardVerificationNumber != null &&
                    this.CardVerificationNumber.Equals(input.CardVerificationNumber))
                ) && 
                (
                    this.CardVerificationNumberToken == input.CardVerificationNumberToken ||
                    (this.CardVerificationNumberToken != null &&
                    this.CardVerificationNumberToken.Equals(input.CardVerificationNumberToken))
                ) && 
                (
                    this.CustomerProfileCreditCardId == input.CustomerProfileCreditCardId ||
                    (this.CustomerProfileCreditCardId != null &&
                    this.CustomerProfileCreditCardId.Equals(input.CustomerProfileCreditCardId))
                ) && 
                (
                    this.StoreCreditCard == input.StoreCreditCard ||
                    (this.StoreCreditCard != null &&
                    this.StoreCreditCard.Equals(input.StoreCreditCard))
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
                if (this.CardExpirationMonth != null)
                    hashCode = hashCode * 59 + this.CardExpirationMonth.GetHashCode();
                if (this.CardExpirationYear != null)
                    hashCode = hashCode * 59 + this.CardExpirationYear.GetHashCode();
                if (this.CardNumber != null)
                    hashCode = hashCode * 59 + this.CardNumber.GetHashCode();
                if (this.CardNumberToken != null)
                    hashCode = hashCode * 59 + this.CardNumberToken.GetHashCode();
                if (this.CardType != null)
                    hashCode = hashCode * 59 + this.CardType.GetHashCode();
                if (this.CardVerificationNumber != null)
                    hashCode = hashCode * 59 + this.CardVerificationNumber.GetHashCode();
                if (this.CardVerificationNumberToken != null)
                    hashCode = hashCode * 59 + this.CardVerificationNumberToken.GetHashCode();
                if (this.CustomerProfileCreditCardId != null)
                    hashCode = hashCode * 59 + this.CustomerProfileCreditCardId.GetHashCode();
                if (this.StoreCreditCard != null)
                    hashCode = hashCode * 59 + this.StoreCreditCard.GetHashCode();
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
