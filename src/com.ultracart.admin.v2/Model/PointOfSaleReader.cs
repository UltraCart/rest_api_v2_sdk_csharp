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
    /// PointOfSaleReader
    /// </summary>
    [DataContract]
    public partial class PointOfSaleReader :  IEquatable<PointOfSaleReader>, IValidatableObject
    {
        /// <summary>
        /// The payment provider for the card reader.
        /// </summary>
        /// <value>The payment provider for the card reader.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentProviderEnum
        {
            /// <summary>
            /// Enum Stripe for value: stripe
            /// </summary>
            [EnumMember(Value = "stripe")]
            Stripe = 1

        }

        /// <summary>
        /// The payment provider for the card reader.
        /// </summary>
        /// <value>The payment provider for the card reader.</value>
        [DataMember(Name="payment_provider", EmitDefaultValue=false)]
        public PaymentProviderEnum? PaymentProvider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PointOfSaleReader" /> class.
        /// </summary>
        /// <param name="deviceType">The device type of the reader..</param>
        /// <param name="label">The label of the reader..</param>
        /// <param name="merchantId">The merchant id that owns this point of sale reader..</param>
        /// <param name="paymentProvider">The payment provider for the card reader..</param>
        /// <param name="posReaderId">Object identifier of the point of sale reader..</param>
        /// <param name="posRegisterOid">Object identifier of the point of sale register this reader is assigned to..</param>
        /// <param name="serialNumber">The serial number of the reader..</param>
        /// <param name="stripeAccountId">If the payment provider is Stripe, this is the Stripe account id.</param>
        /// <param name="stripeReaderId">If the payment provide is Stripe, this is the Stripe terminal reader id.</param>
        public PointOfSaleReader(string deviceType = default(string), string label = default(string), string merchantId = default(string), PaymentProviderEnum? paymentProvider = default(PaymentProviderEnum?), int posReaderId = default(int), int posRegisterOid = default(int), string serialNumber = default(string), string stripeAccountId = default(string), string stripeReaderId = default(string))
        {
            this.DeviceType = deviceType;
            this.Label = label;
            this.MerchantId = merchantId;
            this.PaymentProvider = paymentProvider;
            this.PosReaderId = posReaderId;
            this.PosRegisterOid = posRegisterOid;
            this.SerialNumber = serialNumber;
            this.StripeAccountId = stripeAccountId;
            this.StripeReaderId = stripeReaderId;
        }

        /// <summary>
        /// The device type of the reader.
        /// </summary>
        /// <value>The device type of the reader.</value>
        [DataMember(Name="device_type", EmitDefaultValue=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// The label of the reader.
        /// </summary>
        /// <value>The label of the reader.</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// The merchant id that owns this point of sale reader.
        /// </summary>
        /// <value>The merchant id that owns this point of sale reader.</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }


        /// <summary>
        /// Object identifier of the point of sale reader.
        /// </summary>
        /// <value>Object identifier of the point of sale reader.</value>
        [DataMember(Name="pos_reader_id", EmitDefaultValue=false)]
        public int PosReaderId { get; set; }

        /// <summary>
        /// Object identifier of the point of sale register this reader is assigned to.
        /// </summary>
        /// <value>Object identifier of the point of sale register this reader is assigned to.</value>
        [DataMember(Name="pos_register_oid", EmitDefaultValue=false)]
        public int PosRegisterOid { get; set; }

        /// <summary>
        /// The serial number of the reader.
        /// </summary>
        /// <value>The serial number of the reader.</value>
        [DataMember(Name="serial_number", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// If the payment provider is Stripe, this is the Stripe account id
        /// </summary>
        /// <value>If the payment provider is Stripe, this is the Stripe account id</value>
        [DataMember(Name="stripe_account_id", EmitDefaultValue=false)]
        public string StripeAccountId { get; set; }

        /// <summary>
        /// If the payment provide is Stripe, this is the Stripe terminal reader id
        /// </summary>
        /// <value>If the payment provide is Stripe, this is the Stripe terminal reader id</value>
        [DataMember(Name="stripe_reader_id", EmitDefaultValue=false)]
        public string StripeReaderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PointOfSaleReader {\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  PaymentProvider: ").Append(PaymentProvider).Append("\n");
            sb.Append("  PosReaderId: ").Append(PosReaderId).Append("\n");
            sb.Append("  PosRegisterOid: ").Append(PosRegisterOid).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  StripeAccountId: ").Append(StripeAccountId).Append("\n");
            sb.Append("  StripeReaderId: ").Append(StripeReaderId).Append("\n");
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
            return this.Equals(input as PointOfSaleReader);
        }

        /// <summary>
        /// Returns true if PointOfSaleReader instances are equal
        /// </summary>
        /// <param name="input">Instance of PointOfSaleReader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PointOfSaleReader input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.PaymentProvider == input.PaymentProvider ||
                    (this.PaymentProvider != null &&
                    this.PaymentProvider.Equals(input.PaymentProvider))
                ) && 
                (
                    this.PosReaderId == input.PosReaderId ||
                    (this.PosReaderId != null &&
                    this.PosReaderId.Equals(input.PosReaderId))
                ) && 
                (
                    this.PosRegisterOid == input.PosRegisterOid ||
                    (this.PosRegisterOid != null &&
                    this.PosRegisterOid.Equals(input.PosRegisterOid))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.StripeAccountId == input.StripeAccountId ||
                    (this.StripeAccountId != null &&
                    this.StripeAccountId.Equals(input.StripeAccountId))
                ) && 
                (
                    this.StripeReaderId == input.StripeReaderId ||
                    (this.StripeReaderId != null &&
                    this.StripeReaderId.Equals(input.StripeReaderId))
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
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.PaymentProvider != null)
                    hashCode = hashCode * 59 + this.PaymentProvider.GetHashCode();
                if (this.PosReaderId != null)
                    hashCode = hashCode * 59 + this.PosReaderId.GetHashCode();
                if (this.PosRegisterOid != null)
                    hashCode = hashCode * 59 + this.PosRegisterOid.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.StripeAccountId != null)
                    hashCode = hashCode * 59 + this.StripeAccountId.GetHashCode();
                if (this.StripeReaderId != null)
                    hashCode = hashCode * 59 + this.StripeReaderId.GetHashCode();
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
