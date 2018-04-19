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
    /// ItemDigitalDelivery
    /// </summary>
    [DataContract]
    public partial class ItemDigitalDelivery :  IEquatable<ItemDigitalDelivery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDigitalDelivery" /> class.
        /// </summary>
        /// <param name="ActivationCodeDescription">Description of the activation code.</param>
        /// <param name="ActivationCodeLowWarning">The number of activation codes whcih should generate a warning email.</param>
        /// <param name="ActivationCodeRealtimeUrl">The URL to retrieve activation codes from in real-time.</param>
        /// <param name="ActivationCodeSharedSecret">Shared secret used when communicating with the real-time URL.</param>
        /// <param name="ActivationCodeType">Type of activation code.</param>
        /// <param name="DigitalItems">Digital items that customer can download when this item is purchased.</param>
        public ItemDigitalDelivery(string ActivationCodeDescription = default(string), int? ActivationCodeLowWarning = default(int?), string ActivationCodeRealtimeUrl = default(string), string ActivationCodeSharedSecret = default(string), string ActivationCodeType = default(string), List<ItemDigitalItem> DigitalItems = default(List<ItemDigitalItem>))
        {
            this.ActivationCodeDescription = ActivationCodeDescription;
            this.ActivationCodeLowWarning = ActivationCodeLowWarning;
            this.ActivationCodeRealtimeUrl = ActivationCodeRealtimeUrl;
            this.ActivationCodeSharedSecret = ActivationCodeSharedSecret;
            this.ActivationCodeType = ActivationCodeType;
            this.DigitalItems = DigitalItems;
        }
        
        /// <summary>
        /// Description of the activation code
        /// </summary>
        /// <value>Description of the activation code</value>
        [DataMember(Name="activation_code_description", EmitDefaultValue=false)]
        public string ActivationCodeDescription { get; set; }

        /// <summary>
        /// The number of activation codes whcih should generate a warning email
        /// </summary>
        /// <value>The number of activation codes whcih should generate a warning email</value>
        [DataMember(Name="activation_code_low_warning", EmitDefaultValue=false)]
        public int? ActivationCodeLowWarning { get; set; }

        /// <summary>
        /// The URL to retrieve activation codes from in real-time
        /// </summary>
        /// <value>The URL to retrieve activation codes from in real-time</value>
        [DataMember(Name="activation_code_realtime_url", EmitDefaultValue=false)]
        public string ActivationCodeRealtimeUrl { get; set; }

        /// <summary>
        /// Shared secret used when communicating with the real-time URL
        /// </summary>
        /// <value>Shared secret used when communicating with the real-time URL</value>
        [DataMember(Name="activation_code_shared_secret", EmitDefaultValue=false)]
        public string ActivationCodeSharedSecret { get; set; }

        /// <summary>
        /// Type of activation code
        /// </summary>
        /// <value>Type of activation code</value>
        [DataMember(Name="activation_code_type", EmitDefaultValue=false)]
        public string ActivationCodeType { get; set; }

        /// <summary>
        /// Digital items that customer can download when this item is purchased
        /// </summary>
        /// <value>Digital items that customer can download when this item is purchased</value>
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemDigitalDelivery);
        }

        /// <summary>
        /// Returns true if ItemDigitalDelivery instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemDigitalDelivery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemDigitalDelivery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivationCodeDescription == input.ActivationCodeDescription ||
                    (this.ActivationCodeDescription != null &&
                    this.ActivationCodeDescription.Equals(input.ActivationCodeDescription))
                ) && 
                (
                    this.ActivationCodeLowWarning == input.ActivationCodeLowWarning ||
                    (this.ActivationCodeLowWarning != null &&
                    this.ActivationCodeLowWarning.Equals(input.ActivationCodeLowWarning))
                ) && 
                (
                    this.ActivationCodeRealtimeUrl == input.ActivationCodeRealtimeUrl ||
                    (this.ActivationCodeRealtimeUrl != null &&
                    this.ActivationCodeRealtimeUrl.Equals(input.ActivationCodeRealtimeUrl))
                ) && 
                (
                    this.ActivationCodeSharedSecret == input.ActivationCodeSharedSecret ||
                    (this.ActivationCodeSharedSecret != null &&
                    this.ActivationCodeSharedSecret.Equals(input.ActivationCodeSharedSecret))
                ) && 
                (
                    this.ActivationCodeType == input.ActivationCodeType ||
                    (this.ActivationCodeType != null &&
                    this.ActivationCodeType.Equals(input.ActivationCodeType))
                ) && 
                (
                    this.DigitalItems == input.DigitalItems ||
                    this.DigitalItems != null &&
                    this.DigitalItems.SequenceEqual(input.DigitalItems)
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
                if (this.ActivationCodeDescription != null)
                    hashCode = hashCode * 59 + this.ActivationCodeDescription.GetHashCode();
                if (this.ActivationCodeLowWarning != null)
                    hashCode = hashCode * 59 + this.ActivationCodeLowWarning.GetHashCode();
                if (this.ActivationCodeRealtimeUrl != null)
                    hashCode = hashCode * 59 + this.ActivationCodeRealtimeUrl.GetHashCode();
                if (this.ActivationCodeSharedSecret != null)
                    hashCode = hashCode * 59 + this.ActivationCodeSharedSecret.GetHashCode();
                if (this.ActivationCodeType != null)
                    hashCode = hashCode * 59 + this.ActivationCodeType.GetHashCode();
                if (this.DigitalItems != null)
                    hashCode = hashCode * 59 + this.DigitalItems.GetHashCode();
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
            // ActivationCodeDescription (string) maxLength
            if(this.ActivationCodeDescription != null && this.ActivationCodeDescription.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ActivationCodeDescription, length must be less than 50.", new [] { "ActivationCodeDescription" });
            }

            // ActivationCodeRealtimeUrl (string) maxLength
            if(this.ActivationCodeRealtimeUrl != null && this.ActivationCodeRealtimeUrl.Length > 350)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ActivationCodeRealtimeUrl, length must be less than 350.", new [] { "ActivationCodeRealtimeUrl" });
            }

            // ActivationCodeSharedSecret (string) maxLength
            if(this.ActivationCodeSharedSecret != null && this.ActivationCodeSharedSecret.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ActivationCodeSharedSecret, length must be less than 20.", new [] { "ActivationCodeSharedSecret" });
            }

            yield break;
        }
    }

}
