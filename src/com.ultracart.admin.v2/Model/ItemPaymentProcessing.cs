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
    /// ItemPaymentProcessing
    /// </summary>
    [DataContract]
    public partial class ItemPaymentProcessing :  IEquatable<ItemPaymentProcessing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPaymentProcessing" /> class.
        /// </summary>
        /// <param name="blockPrepaid">True if prepaid cards should be blocked from buying this item.</param>
        /// <param name="creditCardTransactionType">Credit card transaction type.</param>
        /// <param name="noRealtimeCharge">True if no real-time charge should be performed on this item..</param>
        /// <param name="paymentMethodValidity">Payment method validity.</param>
        /// <param name="rotatingTransactionGatewayCodes">Rotating transaction gateway codes.</param>
        public ItemPaymentProcessing(bool blockPrepaid = default(bool), string creditCardTransactionType = default(string), bool noRealtimeCharge = default(bool), List<string> paymentMethodValidity = default(List<string>), List<string> rotatingTransactionGatewayCodes = default(List<string>))
        {
            this.BlockPrepaid = blockPrepaid;
            this.CreditCardTransactionType = creditCardTransactionType;
            this.NoRealtimeCharge = noRealtimeCharge;
            this.PaymentMethodValidity = paymentMethodValidity;
            this.RotatingTransactionGatewayCodes = rotatingTransactionGatewayCodes;
        }

        /// <summary>
        /// True if prepaid cards should be blocked from buying this item
        /// </summary>
        /// <value>True if prepaid cards should be blocked from buying this item</value>
        [DataMember(Name="block_prepaid", EmitDefaultValue=false)]
        public bool BlockPrepaid { get; set; }

        /// <summary>
        /// Credit card transaction type
        /// </summary>
        /// <value>Credit card transaction type</value>
        [DataMember(Name="credit_card_transaction_type", EmitDefaultValue=false)]
        public string CreditCardTransactionType { get; set; }

        /// <summary>
        /// True if no real-time charge should be performed on this item.
        /// </summary>
        /// <value>True if no real-time charge should be performed on this item.</value>
        [DataMember(Name="no_realtime_charge", EmitDefaultValue=false)]
        public bool NoRealtimeCharge { get; set; }

        /// <summary>
        /// Payment method validity
        /// </summary>
        /// <value>Payment method validity</value>
        [DataMember(Name="payment_method_validity", EmitDefaultValue=false)]
        public List<string> PaymentMethodValidity { get; set; }

        /// <summary>
        /// Rotating transaction gateway codes
        /// </summary>
        /// <value>Rotating transaction gateway codes</value>
        [DataMember(Name="rotating_transaction_gateway_codes", EmitDefaultValue=false)]
        public List<string> RotatingTransactionGatewayCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemPaymentProcessing {\n");
            sb.Append("  BlockPrepaid: ").Append(BlockPrepaid).Append("\n");
            sb.Append("  CreditCardTransactionType: ").Append(CreditCardTransactionType).Append("\n");
            sb.Append("  NoRealtimeCharge: ").Append(NoRealtimeCharge).Append("\n");
            sb.Append("  PaymentMethodValidity: ").Append(PaymentMethodValidity).Append("\n");
            sb.Append("  RotatingTransactionGatewayCodes: ").Append(RotatingTransactionGatewayCodes).Append("\n");
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
            return this.Equals(input as ItemPaymentProcessing);
        }

        /// <summary>
        /// Returns true if ItemPaymentProcessing instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemPaymentProcessing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemPaymentProcessing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlockPrepaid == input.BlockPrepaid ||
                    (this.BlockPrepaid != null &&
                    this.BlockPrepaid.Equals(input.BlockPrepaid))
                ) && 
                (
                    this.CreditCardTransactionType == input.CreditCardTransactionType ||
                    (this.CreditCardTransactionType != null &&
                    this.CreditCardTransactionType.Equals(input.CreditCardTransactionType))
                ) && 
                (
                    this.NoRealtimeCharge == input.NoRealtimeCharge ||
                    (this.NoRealtimeCharge != null &&
                    this.NoRealtimeCharge.Equals(input.NoRealtimeCharge))
                ) && 
                (
                    this.PaymentMethodValidity == input.PaymentMethodValidity ||
                    this.PaymentMethodValidity != null &&
                    input.PaymentMethodValidity != null &&
                    this.PaymentMethodValidity.SequenceEqual(input.PaymentMethodValidity)
                ) && 
                (
                    this.RotatingTransactionGatewayCodes == input.RotatingTransactionGatewayCodes ||
                    this.RotatingTransactionGatewayCodes != null &&
                    input.RotatingTransactionGatewayCodes != null &&
                    this.RotatingTransactionGatewayCodes.SequenceEqual(input.RotatingTransactionGatewayCodes)
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
                if (this.BlockPrepaid != null)
                    hashCode = hashCode * 59 + this.BlockPrepaid.GetHashCode();
                if (this.CreditCardTransactionType != null)
                    hashCode = hashCode * 59 + this.CreditCardTransactionType.GetHashCode();
                if (this.NoRealtimeCharge != null)
                    hashCode = hashCode * 59 + this.NoRealtimeCharge.GetHashCode();
                if (this.PaymentMethodValidity != null)
                    hashCode = hashCode * 59 + this.PaymentMethodValidity.GetHashCode();
                if (this.RotatingTransactionGatewayCodes != null)
                    hashCode = hashCode * 59 + this.RotatingTransactionGatewayCodes.GetHashCode();
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
