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
    /// CartSettingsGift
    /// </summary>
    [DataContract]
    public partial class CartSettingsGift :  IEquatable<CartSettingsGift>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartSettingsGift" /> class.
        /// </summary>
        /// <param name="allowGifts">True if this checkout supports gift giving.</param>
        /// <param name="giftCharge">giftCharge.</param>
        /// <param name="giftWraps">The gift wraps available for the customer to select from.</param>
        /// <param name="maxMessageLength">The maximum length of the gift message the giver can enter.</param>
        public CartSettingsGift(bool allowGifts = default(bool), Currency giftCharge = default(Currency), List<CartSettingsGiftWrap> giftWraps = default(List<CartSettingsGiftWrap>), int maxMessageLength = default(int))
        {
            this.AllowGifts = allowGifts;
            this.GiftCharge = giftCharge;
            this.GiftWraps = giftWraps;
            this.MaxMessageLength = maxMessageLength;
        }

        /// <summary>
        /// True if this checkout supports gift giving
        /// </summary>
        /// <value>True if this checkout supports gift giving</value>
        [DataMember(Name="allow_gifts", EmitDefaultValue=false)]
        public bool AllowGifts { get; set; }

        /// <summary>
        /// Gets or Sets GiftCharge
        /// </summary>
        [DataMember(Name="gift_charge", EmitDefaultValue=false)]
        public Currency GiftCharge { get; set; }

        /// <summary>
        /// The gift wraps available for the customer to select from
        /// </summary>
        /// <value>The gift wraps available for the customer to select from</value>
        [DataMember(Name="gift_wraps", EmitDefaultValue=false)]
        public List<CartSettingsGiftWrap> GiftWraps { get; set; }

        /// <summary>
        /// The maximum length of the gift message the giver can enter
        /// </summary>
        /// <value>The maximum length of the gift message the giver can enter</value>
        [DataMember(Name="max_message_length", EmitDefaultValue=false)]
        public int MaxMessageLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartSettingsGift {\n");
            sb.Append("  AllowGifts: ").Append(AllowGifts).Append("\n");
            sb.Append("  GiftCharge: ").Append(GiftCharge).Append("\n");
            sb.Append("  GiftWraps: ").Append(GiftWraps).Append("\n");
            sb.Append("  MaxMessageLength: ").Append(MaxMessageLength).Append("\n");
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
            return this.Equals(input as CartSettingsGift);
        }

        /// <summary>
        /// Returns true if CartSettingsGift instances are equal
        /// </summary>
        /// <param name="input">Instance of CartSettingsGift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartSettingsGift input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowGifts == input.AllowGifts ||
                    (this.AllowGifts != null &&
                    this.AllowGifts.Equals(input.AllowGifts))
                ) && 
                (
                    this.GiftCharge == input.GiftCharge ||
                    (this.GiftCharge != null &&
                    this.GiftCharge.Equals(input.GiftCharge))
                ) && 
                (
                    this.GiftWraps == input.GiftWraps ||
                    this.GiftWraps != null &&
                    input.GiftWraps != null &&
                    this.GiftWraps.SequenceEqual(input.GiftWraps)
                ) && 
                (
                    this.MaxMessageLength == input.MaxMessageLength ||
                    (this.MaxMessageLength != null &&
                    this.MaxMessageLength.Equals(input.MaxMessageLength))
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
                if (this.AllowGifts != null)
                    hashCode = hashCode * 59 + this.AllowGifts.GetHashCode();
                if (this.GiftCharge != null)
                    hashCode = hashCode * 59 + this.GiftCharge.GetHashCode();
                if (this.GiftWraps != null)
                    hashCode = hashCode * 59 + this.GiftWraps.GetHashCode();
                if (this.MaxMessageLength != null)
                    hashCode = hashCode * 59 + this.MaxMessageLength.GetHashCode();
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
