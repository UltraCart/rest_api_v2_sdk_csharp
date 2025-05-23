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
    /// CartSettingsPaymentAmazon
    /// </summary>
    [DataContract]
    public partial class CartSettingsPaymentAmazon :  IEquatable<CartSettingsPaymentAmazon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartSettingsPaymentAmazon" /> class.
        /// </summary>
        /// <param name="amazonButtonUrl">Amazon button URL.</param>
        /// <param name="amazonMerchantId">Amazon merchant ID.</param>
        /// <param name="amazonWidgetUrl">Amazon widget URL.</param>
        public CartSettingsPaymentAmazon(string amazonButtonUrl = default(string), string amazonMerchantId = default(string), string amazonWidgetUrl = default(string))
        {
            this.AmazonButtonUrl = amazonButtonUrl;
            this.AmazonMerchantId = amazonMerchantId;
            this.AmazonWidgetUrl = amazonWidgetUrl;
        }

        /// <summary>
        /// Amazon button URL
        /// </summary>
        /// <value>Amazon button URL</value>
        [DataMember(Name="amazon_button_url", EmitDefaultValue=false)]
        public string AmazonButtonUrl { get; set; }

        /// <summary>
        /// Amazon merchant ID
        /// </summary>
        /// <value>Amazon merchant ID</value>
        [DataMember(Name="amazon_merchant_id", EmitDefaultValue=false)]
        public string AmazonMerchantId { get; set; }

        /// <summary>
        /// Amazon widget URL
        /// </summary>
        /// <value>Amazon widget URL</value>
        [DataMember(Name="amazon_widget_url", EmitDefaultValue=false)]
        public string AmazonWidgetUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartSettingsPaymentAmazon {\n");
            sb.Append("  AmazonButtonUrl: ").Append(AmazonButtonUrl).Append("\n");
            sb.Append("  AmazonMerchantId: ").Append(AmazonMerchantId).Append("\n");
            sb.Append("  AmazonWidgetUrl: ").Append(AmazonWidgetUrl).Append("\n");
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
            return this.Equals(input as CartSettingsPaymentAmazon);
        }

        /// <summary>
        /// Returns true if CartSettingsPaymentAmazon instances are equal
        /// </summary>
        /// <param name="input">Instance of CartSettingsPaymentAmazon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartSettingsPaymentAmazon input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmazonButtonUrl == input.AmazonButtonUrl ||
                    (this.AmazonButtonUrl != null &&
                    this.AmazonButtonUrl.Equals(input.AmazonButtonUrl))
                ) && 
                (
                    this.AmazonMerchantId == input.AmazonMerchantId ||
                    (this.AmazonMerchantId != null &&
                    this.AmazonMerchantId.Equals(input.AmazonMerchantId))
                ) && 
                (
                    this.AmazonWidgetUrl == input.AmazonWidgetUrl ||
                    (this.AmazonWidgetUrl != null &&
                    this.AmazonWidgetUrl.Equals(input.AmazonWidgetUrl))
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
                if (this.AmazonButtonUrl != null)
                    hashCode = hashCode * 59 + this.AmazonButtonUrl.GetHashCode();
                if (this.AmazonMerchantId != null)
                    hashCode = hashCode * 59 + this.AmazonMerchantId.GetHashCode();
                if (this.AmazonWidgetUrl != null)
                    hashCode = hashCode * 59 + this.AmazonWidgetUrl.GetHashCode();
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
