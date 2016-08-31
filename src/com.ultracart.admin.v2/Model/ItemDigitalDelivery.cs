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
    /// ItemDigitalDelivery
    /// </summary>
    [DataContract]
    public partial class ItemDigitalDelivery :  IEquatable<ItemDigitalDelivery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDigitalDelivery" /> class.
        /// </summary>
        /// <param name="ActivationCodeDescription">ActivationCodeDescription.</param>
        /// <param name="ActivationCodeLowWarning">ActivationCodeLowWarning.</param>
        /// <param name="ActivationCodeRealtimeUrl">ActivationCodeRealtimeUrl.</param>
        /// <param name="ActivationCodeSharedSecret">ActivationCodeSharedSecret.</param>
        /// <param name="ActivationCodeType">ActivationCodeType.</param>
        /// <param name="DigitalItems">DigitalItems.</param>
        public ItemDigitalDelivery(string ActivationCodeDescription = null, int? ActivationCodeLowWarning = null, string ActivationCodeRealtimeUrl = null, string ActivationCodeSharedSecret = null, string ActivationCodeType = null, List<ItemDigitalItem> DigitalItems = null)
        {
            this.ActivationCodeDescription = ActivationCodeDescription;
            this.ActivationCodeLowWarning = ActivationCodeLowWarning;
            this.ActivationCodeRealtimeUrl = ActivationCodeRealtimeUrl;
            this.ActivationCodeSharedSecret = ActivationCodeSharedSecret;
            this.ActivationCodeType = ActivationCodeType;
            this.DigitalItems = DigitalItems;
        }
        
        /// <summary>
        /// Gets or Sets ActivationCodeDescription
        /// </summary>
        [DataMember(Name="activation_code_description", EmitDefaultValue=false)]
        public string ActivationCodeDescription { get; set; }
        /// <summary>
        /// Gets or Sets ActivationCodeLowWarning
        /// </summary>
        [DataMember(Name="activation_code_low_warning", EmitDefaultValue=false)]
        public int? ActivationCodeLowWarning { get; set; }
        /// <summary>
        /// Gets or Sets ActivationCodeRealtimeUrl
        /// </summary>
        [DataMember(Name="activation_code_realtime_url", EmitDefaultValue=false)]
        public string ActivationCodeRealtimeUrl { get; set; }
        /// <summary>
        /// Gets or Sets ActivationCodeSharedSecret
        /// </summary>
        [DataMember(Name="activation_code_shared_secret", EmitDefaultValue=false)]
        public string ActivationCodeSharedSecret { get; set; }
        /// <summary>
        /// Gets or Sets ActivationCodeType
        /// </summary>
        [DataMember(Name="activation_code_type", EmitDefaultValue=false)]
        public string ActivationCodeType { get; set; }
        /// <summary>
        /// Gets or Sets DigitalItems
        /// </summary>
        [DataMember(Name="digital_items", EmitDefaultValue=false)]
        public List<ItemDigitalItem> DigitalItems { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemDigitalDelivery {\n");
            sb.Append("  ActivationCodeDescription: ").Append(ActivationCodeDescription).Append("\n");
            sb.Append("  ActivationCodeLowWarning: ").Append(ActivationCodeLowWarning).Append("\n");
            sb.Append("  ActivationCodeRealtimeUrl: ").Append(ActivationCodeRealtimeUrl).Append("\n");
            sb.Append("  ActivationCodeSharedSecret: ").Append(ActivationCodeSharedSecret).Append("\n");
            sb.Append("  ActivationCodeType: ").Append(ActivationCodeType).Append("\n");
            sb.Append("  DigitalItems: ").Append(DigitalItems).Append("\n");
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
            return this.Equals(obj as ItemDigitalDelivery);
        }

        /// <summary>
        /// Returns true if ItemDigitalDelivery instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemDigitalDelivery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemDigitalDelivery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActivationCodeDescription == other.ActivationCodeDescription ||
                    this.ActivationCodeDescription != null &&
                    this.ActivationCodeDescription.Equals(other.ActivationCodeDescription)
                ) && 
                (
                    this.ActivationCodeLowWarning == other.ActivationCodeLowWarning ||
                    this.ActivationCodeLowWarning != null &&
                    this.ActivationCodeLowWarning.Equals(other.ActivationCodeLowWarning)
                ) && 
                (
                    this.ActivationCodeRealtimeUrl == other.ActivationCodeRealtimeUrl ||
                    this.ActivationCodeRealtimeUrl != null &&
                    this.ActivationCodeRealtimeUrl.Equals(other.ActivationCodeRealtimeUrl)
                ) && 
                (
                    this.ActivationCodeSharedSecret == other.ActivationCodeSharedSecret ||
                    this.ActivationCodeSharedSecret != null &&
                    this.ActivationCodeSharedSecret.Equals(other.ActivationCodeSharedSecret)
                ) && 
                (
                    this.ActivationCodeType == other.ActivationCodeType ||
                    this.ActivationCodeType != null &&
                    this.ActivationCodeType.Equals(other.ActivationCodeType)
                ) && 
                (
                    this.DigitalItems == other.DigitalItems ||
                    this.DigitalItems != null &&
                    this.DigitalItems.SequenceEqual(other.DigitalItems)
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
                if (this.ActivationCodeDescription != null)
                    hash = hash * 59 + this.ActivationCodeDescription.GetHashCode();
                if (this.ActivationCodeLowWarning != null)
                    hash = hash * 59 + this.ActivationCodeLowWarning.GetHashCode();
                if (this.ActivationCodeRealtimeUrl != null)
                    hash = hash * 59 + this.ActivationCodeRealtimeUrl.GetHashCode();
                if (this.ActivationCodeSharedSecret != null)
                    hash = hash * 59 + this.ActivationCodeSharedSecret.GetHashCode();
                if (this.ActivationCodeType != null)
                    hash = hash * 59 + this.ActivationCodeType.GetHashCode();
                if (this.DigitalItems != null)
                    hash = hash * 59 + this.DigitalItems.GetHashCode();
                return hash;
            }
        }
    }

}
