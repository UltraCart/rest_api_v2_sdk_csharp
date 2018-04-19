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
    /// OrderGift
    /// </summary>
    [DataContract]
    public partial class OrderGift :  IEquatable<OrderGift>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderGift" /> class.
        /// </summary>
        /// <param name="Gift">True if the order is a gift.</param>
        /// <param name="GiftCharge">GiftCharge.</param>
        /// <param name="GiftChargeAccountingCode">QuickBooks code for the gift charge.</param>
        /// <param name="GiftChargeRefunded">GiftChargeRefunded.</param>
        /// <param name="GiftEmail">Email address of the gift recipient.</param>
        /// <param name="GiftMessage">Message to the gift recipient.</param>
        /// <param name="GiftWrapAccountingCode">QuickBooks code for the gift wrap charge.</param>
        /// <param name="GiftWrapCost">GiftWrapCost.</param>
        /// <param name="GiftWrapRefunded">GiftWrapRefunded.</param>
        /// <param name="GiftWrapTitle">Title of the gift wrap that the customer wants used.</param>
        public OrderGift(bool? Gift = default(bool?), Currency GiftCharge = default(Currency), string GiftChargeAccountingCode = default(string), Currency GiftChargeRefunded = default(Currency), string GiftEmail = default(string), string GiftMessage = default(string), string GiftWrapAccountingCode = default(string), Currency GiftWrapCost = default(Currency), Currency GiftWrapRefunded = default(Currency), string GiftWrapTitle = default(string))
        {
            this.Gift = Gift;
            this.GiftCharge = GiftCharge;
            this.GiftChargeAccountingCode = GiftChargeAccountingCode;
            this.GiftChargeRefunded = GiftChargeRefunded;
            this.GiftEmail = GiftEmail;
            this.GiftMessage = GiftMessage;
            this.GiftWrapAccountingCode = GiftWrapAccountingCode;
            this.GiftWrapCost = GiftWrapCost;
            this.GiftWrapRefunded = GiftWrapRefunded;
            this.GiftWrapTitle = GiftWrapTitle;
        }
        
        /// <summary>
        /// True if the order is a gift
        /// </summary>
        /// <value>True if the order is a gift</value>
        [DataMember(Name="gift", EmitDefaultValue=false)]
        public bool? Gift { get; set; }

        /// <summary>
        /// Gets or Sets GiftCharge
        /// </summary>
        [DataMember(Name="gift_charge", EmitDefaultValue=false)]
        public Currency GiftCharge { get; set; }

        /// <summary>
        /// QuickBooks code for the gift charge
        /// </summary>
        /// <value>QuickBooks code for the gift charge</value>
        [DataMember(Name="gift_charge_accounting_code", EmitDefaultValue=false)]
        public string GiftChargeAccountingCode { get; set; }

        /// <summary>
        /// Gets or Sets GiftChargeRefunded
        /// </summary>
        [DataMember(Name="gift_charge_refunded", EmitDefaultValue=false)]
        public Currency GiftChargeRefunded { get; set; }

        /// <summary>
        /// Email address of the gift recipient
        /// </summary>
        /// <value>Email address of the gift recipient</value>
        [DataMember(Name="gift_email", EmitDefaultValue=false)]
        public string GiftEmail { get; set; }

        /// <summary>
        /// Message to the gift recipient
        /// </summary>
        /// <value>Message to the gift recipient</value>
        [DataMember(Name="gift_message", EmitDefaultValue=false)]
        public string GiftMessage { get; set; }

        /// <summary>
        /// QuickBooks code for the gift wrap charge
        /// </summary>
        /// <value>QuickBooks code for the gift wrap charge</value>
        [DataMember(Name="gift_wrap_accounting_code", EmitDefaultValue=false)]
        public string GiftWrapAccountingCode { get; set; }

        /// <summary>
        /// Gets or Sets GiftWrapCost
        /// </summary>
        [DataMember(Name="gift_wrap_cost", EmitDefaultValue=false)]
        public Currency GiftWrapCost { get; set; }

        /// <summary>
        /// Gets or Sets GiftWrapRefunded
        /// </summary>
        [DataMember(Name="gift_wrap_refunded", EmitDefaultValue=false)]
        public Currency GiftWrapRefunded { get; set; }

        /// <summary>
        /// Title of the gift wrap that the customer wants used
        /// </summary>
        /// <value>Title of the gift wrap that the customer wants used</value>
        [DataMember(Name="gift_wrap_title", EmitDefaultValue=false)]
        public string GiftWrapTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderGift {\n");
            sb.Append("  Gift: ").Append(Gift).Append("\n");
            sb.Append("  GiftCharge: ").Append(GiftCharge).Append("\n");
            sb.Append("  GiftChargeAccountingCode: ").Append(GiftChargeAccountingCode).Append("\n");
            sb.Append("  GiftChargeRefunded: ").Append(GiftChargeRefunded).Append("\n");
            sb.Append("  GiftEmail: ").Append(GiftEmail).Append("\n");
            sb.Append("  GiftMessage: ").Append(GiftMessage).Append("\n");
            sb.Append("  GiftWrapAccountingCode: ").Append(GiftWrapAccountingCode).Append("\n");
            sb.Append("  GiftWrapCost: ").Append(GiftWrapCost).Append("\n");
            sb.Append("  GiftWrapRefunded: ").Append(GiftWrapRefunded).Append("\n");
            sb.Append("  GiftWrapTitle: ").Append(GiftWrapTitle).Append("\n");
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
            return this.Equals(input as OrderGift);
        }

        /// <summary>
        /// Returns true if OrderGift instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderGift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderGift input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gift == input.Gift ||
                    (this.Gift != null &&
                    this.Gift.Equals(input.Gift))
                ) && 
                (
                    this.GiftCharge == input.GiftCharge ||
                    (this.GiftCharge != null &&
                    this.GiftCharge.Equals(input.GiftCharge))
                ) && 
                (
                    this.GiftChargeAccountingCode == input.GiftChargeAccountingCode ||
                    (this.GiftChargeAccountingCode != null &&
                    this.GiftChargeAccountingCode.Equals(input.GiftChargeAccountingCode))
                ) && 
                (
                    this.GiftChargeRefunded == input.GiftChargeRefunded ||
                    (this.GiftChargeRefunded != null &&
                    this.GiftChargeRefunded.Equals(input.GiftChargeRefunded))
                ) && 
                (
                    this.GiftEmail == input.GiftEmail ||
                    (this.GiftEmail != null &&
                    this.GiftEmail.Equals(input.GiftEmail))
                ) && 
                (
                    this.GiftMessage == input.GiftMessage ||
                    (this.GiftMessage != null &&
                    this.GiftMessage.Equals(input.GiftMessage))
                ) && 
                (
                    this.GiftWrapAccountingCode == input.GiftWrapAccountingCode ||
                    (this.GiftWrapAccountingCode != null &&
                    this.GiftWrapAccountingCode.Equals(input.GiftWrapAccountingCode))
                ) && 
                (
                    this.GiftWrapCost == input.GiftWrapCost ||
                    (this.GiftWrapCost != null &&
                    this.GiftWrapCost.Equals(input.GiftWrapCost))
                ) && 
                (
                    this.GiftWrapRefunded == input.GiftWrapRefunded ||
                    (this.GiftWrapRefunded != null &&
                    this.GiftWrapRefunded.Equals(input.GiftWrapRefunded))
                ) && 
                (
                    this.GiftWrapTitle == input.GiftWrapTitle ||
                    (this.GiftWrapTitle != null &&
                    this.GiftWrapTitle.Equals(input.GiftWrapTitle))
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
                if (this.Gift != null)
                    hashCode = hashCode * 59 + this.Gift.GetHashCode();
                if (this.GiftCharge != null)
                    hashCode = hashCode * 59 + this.GiftCharge.GetHashCode();
                if (this.GiftChargeAccountingCode != null)
                    hashCode = hashCode * 59 + this.GiftChargeAccountingCode.GetHashCode();
                if (this.GiftChargeRefunded != null)
                    hashCode = hashCode * 59 + this.GiftChargeRefunded.GetHashCode();
                if (this.GiftEmail != null)
                    hashCode = hashCode * 59 + this.GiftEmail.GetHashCode();
                if (this.GiftMessage != null)
                    hashCode = hashCode * 59 + this.GiftMessage.GetHashCode();
                if (this.GiftWrapAccountingCode != null)
                    hashCode = hashCode * 59 + this.GiftWrapAccountingCode.GetHashCode();
                if (this.GiftWrapCost != null)
                    hashCode = hashCode * 59 + this.GiftWrapCost.GetHashCode();
                if (this.GiftWrapRefunded != null)
                    hashCode = hashCode * 59 + this.GiftWrapRefunded.GetHashCode();
                if (this.GiftWrapTitle != null)
                    hashCode = hashCode * 59 + this.GiftWrapTitle.GetHashCode();
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
            // GiftEmail (string) maxLength
            if(this.GiftEmail != null && this.GiftEmail.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GiftEmail, length must be less than 100.", new [] { "GiftEmail" });
            }

            // GiftMessage (string) maxLength
            if(this.GiftMessage != null && this.GiftMessage.Length > 10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GiftMessage, length must be less than 10000.", new [] { "GiftMessage" });
            }

            // GiftWrapTitle (string) maxLength
            if(this.GiftWrapTitle != null && this.GiftWrapTitle.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GiftWrapTitle, length must be less than 30.", new [] { "GiftWrapTitle" });
            }

            yield break;
        }
    }

}
