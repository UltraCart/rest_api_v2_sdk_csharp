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
    /// OrderPaymentCreditCard
    /// </summary>
    [DataContract]
    public partial class OrderPaymentCreditCard :  IEquatable<OrderPaymentCreditCard>, IValidatableObject
    {
        /// <summary>
        /// Card type
        /// </summary>
        /// <value>Card type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardTypeEnum
        {
            
            /// <summary>
            /// Enum AMEX for "AMEX"
            /// </summary>
            [EnumMember(Value = "AMEX")]
            AMEX,
            
            /// <summary>
            /// Enum DinersClub for "Diners Club"
            /// </summary>
            [EnumMember(Value = "Diners Club")]
            DinersClub,
            
            /// <summary>
            /// Enum Discover for "Discover"
            /// </summary>
            [EnumMember(Value = "Discover")]
            Discover,
            
            /// <summary>
            /// Enum JCB for "JCB"
            /// </summary>
            [EnumMember(Value = "JCB")]
            JCB,
            
            /// <summary>
            /// Enum MasterCard for "MasterCard"
            /// </summary>
            [EnumMember(Value = "MasterCard")]
            MasterCard,
            
            /// <summary>
            /// Enum VISA for "VISA"
            /// </summary>
            [EnumMember(Value = "VISA")]
            VISA
        }

        /// <summary>
        /// Card type
        /// </summary>
        /// <value>Card type</value>
        [DataMember(Name="card_type", EmitDefaultValue=false)]
        public CardTypeEnum? CardType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPaymentCreditCard" /> class.
        /// </summary>
        /// <param name="CardAuthTicket">Card authorization ticket.</param>
        /// <param name="CardAuthorizationAmount">Card authorization amount.</param>
        /// <param name="CardAuthorizationDts">Card authorization date/time.</param>
        /// <param name="CardAuthorizationReferenceNumber">Card authorization reference number.</param>
        /// <param name="CardExpirationMonth">Card expiration month (1-12).</param>
        /// <param name="CardExpirationYear">Card expiration year (Four digit year).</param>
        /// <param name="CardNumber">Card number (masked to last 4).</param>
        /// <param name="CardNumberToken">Card number token from hosted fields used to update the cart number.</param>
        /// <param name="CardNumberTruncated">True if the card has been truncated.</param>
        /// <param name="CardType">Card type.</param>
        public OrderPaymentCreditCard(string CardAuthTicket = default(string), decimal? CardAuthorizationAmount = default(decimal?), string CardAuthorizationDts = default(string), string CardAuthorizationReferenceNumber = default(string), int? CardExpirationMonth = default(int?), int? CardExpirationYear = default(int?), string CardNumber = default(string), string CardNumberToken = default(string), bool? CardNumberTruncated = default(bool?), CardTypeEnum? CardType = default(CardTypeEnum?))
        {
            this.CardAuthTicket = CardAuthTicket;
            this.CardAuthorizationAmount = CardAuthorizationAmount;
            this.CardAuthorizationDts = CardAuthorizationDts;
            this.CardAuthorizationReferenceNumber = CardAuthorizationReferenceNumber;
            this.CardExpirationMonth = CardExpirationMonth;
            this.CardExpirationYear = CardExpirationYear;
            this.CardNumber = CardNumber;
            this.CardNumberToken = CardNumberToken;
            this.CardNumberTruncated = CardNumberTruncated;
            this.CardType = CardType;
        }
        
        /// <summary>
        /// Card authorization ticket
        /// </summary>
        /// <value>Card authorization ticket</value>
        [DataMember(Name="card_auth_ticket", EmitDefaultValue=false)]
        public string CardAuthTicket { get; set; }

        /// <summary>
        /// Card authorization amount
        /// </summary>
        /// <value>Card authorization amount</value>
        [DataMember(Name="card_authorization_amount", EmitDefaultValue=false)]
        public decimal? CardAuthorizationAmount { get; set; }

        /// <summary>
        /// Card authorization date/time
        /// </summary>
        /// <value>Card authorization date/time</value>
        [DataMember(Name="card_authorization_dts", EmitDefaultValue=false)]
        public string CardAuthorizationDts { get; set; }

        /// <summary>
        /// Card authorization reference number
        /// </summary>
        /// <value>Card authorization reference number</value>
        [DataMember(Name="card_authorization_reference_number", EmitDefaultValue=false)]
        public string CardAuthorizationReferenceNumber { get; set; }

        /// <summary>
        /// Card expiration month (1-12)
        /// </summary>
        /// <value>Card expiration month (1-12)</value>
        [DataMember(Name="card_expiration_month", EmitDefaultValue=false)]
        public int? CardExpirationMonth { get; set; }

        /// <summary>
        /// Card expiration year (Four digit year)
        /// </summary>
        /// <value>Card expiration year (Four digit year)</value>
        [DataMember(Name="card_expiration_year", EmitDefaultValue=false)]
        public int? CardExpirationYear { get; set; }

        /// <summary>
        /// Card number (masked to last 4)
        /// </summary>
        /// <value>Card number (masked to last 4)</value>
        [DataMember(Name="card_number", EmitDefaultValue=false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Card number token from hosted fields used to update the cart number
        /// </summary>
        /// <value>Card number token from hosted fields used to update the cart number</value>
        [DataMember(Name="card_number_token", EmitDefaultValue=false)]
        public string CardNumberToken { get; set; }

        /// <summary>
        /// True if the card has been truncated
        /// </summary>
        /// <value>True if the card has been truncated</value>
        [DataMember(Name="card_number_truncated", EmitDefaultValue=false)]
        public bool? CardNumberTruncated { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderPaymentCreditCard {\n");
            sb.Append("  CardAuthTicket: ").Append(CardAuthTicket).Append("\n");
            sb.Append("  CardAuthorizationAmount: ").Append(CardAuthorizationAmount).Append("\n");
            sb.Append("  CardAuthorizationDts: ").Append(CardAuthorizationDts).Append("\n");
            sb.Append("  CardAuthorizationReferenceNumber: ").Append(CardAuthorizationReferenceNumber).Append("\n");
            sb.Append("  CardExpirationMonth: ").Append(CardExpirationMonth).Append("\n");
            sb.Append("  CardExpirationYear: ").Append(CardExpirationYear).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  CardNumberToken: ").Append(CardNumberToken).Append("\n");
            sb.Append("  CardNumberTruncated: ").Append(CardNumberTruncated).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
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
            return this.Equals(input as OrderPaymentCreditCard);
        }

        /// <summary>
        /// Returns true if OrderPaymentCreditCard instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderPaymentCreditCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderPaymentCreditCard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardAuthTicket == input.CardAuthTicket ||
                    (this.CardAuthTicket != null &&
                    this.CardAuthTicket.Equals(input.CardAuthTicket))
                ) && 
                (
                    this.CardAuthorizationAmount == input.CardAuthorizationAmount ||
                    (this.CardAuthorizationAmount != null &&
                    this.CardAuthorizationAmount.Equals(input.CardAuthorizationAmount))
                ) && 
                (
                    this.CardAuthorizationDts == input.CardAuthorizationDts ||
                    (this.CardAuthorizationDts != null &&
                    this.CardAuthorizationDts.Equals(input.CardAuthorizationDts))
                ) && 
                (
                    this.CardAuthorizationReferenceNumber == input.CardAuthorizationReferenceNumber ||
                    (this.CardAuthorizationReferenceNumber != null &&
                    this.CardAuthorizationReferenceNumber.Equals(input.CardAuthorizationReferenceNumber))
                ) && 
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
                    this.CardNumberTruncated == input.CardNumberTruncated ||
                    (this.CardNumberTruncated != null &&
                    this.CardNumberTruncated.Equals(input.CardNumberTruncated))
                ) && 
                (
                    this.CardType == input.CardType ||
                    (this.CardType != null &&
                    this.CardType.Equals(input.CardType))
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
                if (this.CardAuthTicket != null)
                    hashCode = hashCode * 59 + this.CardAuthTicket.GetHashCode();
                if (this.CardAuthorizationAmount != null)
                    hashCode = hashCode * 59 + this.CardAuthorizationAmount.GetHashCode();
                if (this.CardAuthorizationDts != null)
                    hashCode = hashCode * 59 + this.CardAuthorizationDts.GetHashCode();
                if (this.CardAuthorizationReferenceNumber != null)
                    hashCode = hashCode * 59 + this.CardAuthorizationReferenceNumber.GetHashCode();
                if (this.CardExpirationMonth != null)
                    hashCode = hashCode * 59 + this.CardExpirationMonth.GetHashCode();
                if (this.CardExpirationYear != null)
                    hashCode = hashCode * 59 + this.CardExpirationYear.GetHashCode();
                if (this.CardNumber != null)
                    hashCode = hashCode * 59 + this.CardNumber.GetHashCode();
                if (this.CardNumberToken != null)
                    hashCode = hashCode * 59 + this.CardNumberToken.GetHashCode();
                if (this.CardNumberTruncated != null)
                    hashCode = hashCode * 59 + this.CardNumberTruncated.GetHashCode();
                if (this.CardType != null)
                    hashCode = hashCode * 59 + this.CardType.GetHashCode();
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
