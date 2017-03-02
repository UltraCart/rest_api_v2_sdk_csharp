/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
 *
 * OpenAPI spec version: 2.0.0
 * Contact: support@ultracart.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace com.ultracart.admin.v2.Model
{
    /// <summary>
    /// CartSettingsGift
    /// </summary>
    [DataContract]
    public partial class CartSettingsGift :  IEquatable<CartSettingsGift>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartSettingsGift" /> class.
        /// </summary>
        /// <param name="AllowGifts">True if this checkout supports gift giving.</param>
        /// <param name="GiftCharge">GiftCharge.</param>
        /// <param name="GiftWraps">The gift wraps available for the customer to select from.</param>
        /// <param name="MaxMessageLength">The maximum length of the gift message the giver can enter.</param>
        public CartSettingsGift(bool? AllowGifts = null, Currency GiftCharge = null, List<CartSettingsGiftWrap> GiftWraps = null, int? MaxMessageLength = null)
        {
            this.AllowGifts = AllowGifts;
            this.GiftCharge = GiftCharge;
            this.GiftWraps = GiftWraps;
            this.MaxMessageLength = MaxMessageLength;
        }
        
        /// <summary>
        /// True if this checkout supports gift giving
        /// </summary>
        /// <value>True if this checkout supports gift giving</value>
        [DataMember(Name="allow_gifts", EmitDefaultValue=false)]
        public bool? AllowGifts { get; set; }
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
        public int? MaxMessageLength { get; set; }
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
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CartSettingsGift);
        }

        /// <summary>
        /// Returns true if CartSettingsGift instances are equal
        /// </summary>
        /// <param name="other">Instance of CartSettingsGift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartSettingsGift other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowGifts == other.AllowGifts ||
                    this.AllowGifts != null &&
                    this.AllowGifts.Equals(other.AllowGifts)
                ) && 
                (
                    this.GiftCharge == other.GiftCharge ||
                    this.GiftCharge != null &&
                    this.GiftCharge.Equals(other.GiftCharge)
                ) && 
                (
                    this.GiftWraps == other.GiftWraps ||
                    this.GiftWraps != null &&
                    this.GiftWraps.SequenceEqual(other.GiftWraps)
                ) && 
                (
                    this.MaxMessageLength == other.MaxMessageLength ||
                    this.MaxMessageLength != null &&
                    this.MaxMessageLength.Equals(other.MaxMessageLength)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AllowGifts != null)
                    hash = hash * 59 + this.AllowGifts.GetHashCode();
                if (this.GiftCharge != null)
                    hash = hash * 59 + this.GiftCharge.GetHashCode();
                if (this.GiftWraps != null)
                    hash = hash * 59 + this.GiftWraps.GetHashCode();
                if (this.MaxMessageLength != null)
                    hash = hash * 59 + this.MaxMessageLength.GetHashCode();
                return hash;
            }
        }
    }

}
