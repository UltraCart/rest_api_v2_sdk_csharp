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
    /// ItemVariationOption
    /// </summary>
    [DataContract]
    public partial class ItemVariationOption :  IEquatable<ItemVariationOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemVariationOption" /> class.
        /// </summary>
        /// <param name="DefaultOption">True if default option.</param>
        /// <param name="MerchantItemMultimediaOid">Multimedia object identifier.</param>
        /// <param name="TranslatedTextInstanceOid">Translated text instance id.</param>
        /// <param name="Value">Value.</param>
        public ItemVariationOption(bool? DefaultOption = default(bool?), int? MerchantItemMultimediaOid = default(int?), int? TranslatedTextInstanceOid = default(int?), string Value = default(string))
        {
            this.DefaultOption = DefaultOption;
            this.MerchantItemMultimediaOid = MerchantItemMultimediaOid;
            this.TranslatedTextInstanceOid = TranslatedTextInstanceOid;
            this.Value = Value;
        }
        
        /// <summary>
        /// True if default option
        /// </summary>
        /// <value>True if default option</value>
        [DataMember(Name="default_option", EmitDefaultValue=false)]
        public bool? DefaultOption { get; set; }

        /// <summary>
        /// Multimedia object identifier
        /// </summary>
        /// <value>Multimedia object identifier</value>
        [DataMember(Name="merchant_item_multimedia_oid", EmitDefaultValue=false)]
        public int? MerchantItemMultimediaOid { get; set; }

        /// <summary>
        /// Translated text instance id
        /// </summary>
        /// <value>Translated text instance id</value>
        [DataMember(Name="translated_text_instance_oid", EmitDefaultValue=false)]
        public int? TranslatedTextInstanceOid { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemVariationOption {\n");
            sb.Append("  DefaultOption: ").Append(DefaultOption).Append("\n");
            sb.Append("  MerchantItemMultimediaOid: ").Append(MerchantItemMultimediaOid).Append("\n");
            sb.Append("  TranslatedTextInstanceOid: ").Append(TranslatedTextInstanceOid).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ItemVariationOption);
        }

        /// <summary>
        /// Returns true if ItemVariationOption instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemVariationOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemVariationOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultOption == input.DefaultOption ||
                    (this.DefaultOption != null &&
                    this.DefaultOption.Equals(input.DefaultOption))
                ) && 
                (
                    this.MerchantItemMultimediaOid == input.MerchantItemMultimediaOid ||
                    (this.MerchantItemMultimediaOid != null &&
                    this.MerchantItemMultimediaOid.Equals(input.MerchantItemMultimediaOid))
                ) && 
                (
                    this.TranslatedTextInstanceOid == input.TranslatedTextInstanceOid ||
                    (this.TranslatedTextInstanceOid != null &&
                    this.TranslatedTextInstanceOid.Equals(input.TranslatedTextInstanceOid))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.DefaultOption != null)
                    hashCode = hashCode * 59 + this.DefaultOption.GetHashCode();
                if (this.MerchantItemMultimediaOid != null)
                    hashCode = hashCode * 59 + this.MerchantItemMultimediaOid.GetHashCode();
                if (this.TranslatedTextInstanceOid != null)
                    hashCode = hashCode * 59 + this.TranslatedTextInstanceOid.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
            // Value (string) maxLength
            if(this.Value != null && this.Value.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be less than 50.", new [] { "Value" });
            }

            yield break;
        }
    }

}
