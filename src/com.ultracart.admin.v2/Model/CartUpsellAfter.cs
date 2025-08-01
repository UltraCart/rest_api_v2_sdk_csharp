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
    /// CartUpsellAfter
    /// </summary>
    [DataContract]
    public partial class CartUpsellAfter :  IEquatable<CartUpsellAfter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartUpsellAfter" /> class.
        /// </summary>
        /// <param name="finalizeAfterDts">The date/time after which the cart will finalize into an order..</param>
        /// <param name="finalizeAfterMinutes">The amount of inactivity in minutes after which the cart should be finalized into an order.  This will calculate the finalize_after_dts field..</param>
        /// <param name="upsellPathCode">Upsell path code (this is for legacy upsells only).</param>
        /// <param name="upsellPathName">Upsell path name to start on (StoreFront Upsells).  Will only be respected on a handoff API call..</param>
        /// <param name="upsellPathVariation">Upsell path variation to start on (StoreFront Upsells).   Will only be respected on a handoff API call..</param>
        public CartUpsellAfter(string finalizeAfterDts = default(string), int finalizeAfterMinutes = default(int), string upsellPathCode = default(string), string upsellPathName = default(string), string upsellPathVariation = default(string))
        {
            this.FinalizeAfterDts = finalizeAfterDts;
            this.FinalizeAfterMinutes = finalizeAfterMinutes;
            this.UpsellPathCode = upsellPathCode;
            this.UpsellPathName = upsellPathName;
            this.UpsellPathVariation = upsellPathVariation;
        }

        /// <summary>
        /// The date/time after which the cart will finalize into an order.
        /// </summary>
        /// <value>The date/time after which the cart will finalize into an order.</value>
        [DataMember(Name="finalize_after_dts", EmitDefaultValue=false)]
        public string FinalizeAfterDts { get; set; }

        /// <summary>
        /// The amount of inactivity in minutes after which the cart should be finalized into an order.  This will calculate the finalize_after_dts field.
        /// </summary>
        /// <value>The amount of inactivity in minutes after which the cart should be finalized into an order.  This will calculate the finalize_after_dts field.</value>
        [DataMember(Name="finalize_after_minutes", EmitDefaultValue=false)]
        public int FinalizeAfterMinutes { get; set; }

        /// <summary>
        /// Upsell path code (this is for legacy upsells only)
        /// </summary>
        /// <value>Upsell path code (this is for legacy upsells only)</value>
        [DataMember(Name="upsell_path_code", EmitDefaultValue=false)]
        public string UpsellPathCode { get; set; }

        /// <summary>
        /// Upsell path name to start on (StoreFront Upsells).  Will only be respected on a handoff API call.
        /// </summary>
        /// <value>Upsell path name to start on (StoreFront Upsells).  Will only be respected on a handoff API call.</value>
        [DataMember(Name="upsell_path_name", EmitDefaultValue=false)]
        public string UpsellPathName { get; set; }

        /// <summary>
        /// Upsell path variation to start on (StoreFront Upsells).   Will only be respected on a handoff API call.
        /// </summary>
        /// <value>Upsell path variation to start on (StoreFront Upsells).   Will only be respected on a handoff API call.</value>
        [DataMember(Name="upsell_path_variation", EmitDefaultValue=false)]
        public string UpsellPathVariation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartUpsellAfter {\n");
            sb.Append("  FinalizeAfterDts: ").Append(FinalizeAfterDts).Append("\n");
            sb.Append("  FinalizeAfterMinutes: ").Append(FinalizeAfterMinutes).Append("\n");
            sb.Append("  UpsellPathCode: ").Append(UpsellPathCode).Append("\n");
            sb.Append("  UpsellPathName: ").Append(UpsellPathName).Append("\n");
            sb.Append("  UpsellPathVariation: ").Append(UpsellPathVariation).Append("\n");
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
            return this.Equals(input as CartUpsellAfter);
        }

        /// <summary>
        /// Returns true if CartUpsellAfter instances are equal
        /// </summary>
        /// <param name="input">Instance of CartUpsellAfter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartUpsellAfter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FinalizeAfterDts == input.FinalizeAfterDts ||
                    (this.FinalizeAfterDts != null &&
                    this.FinalizeAfterDts.Equals(input.FinalizeAfterDts))
                ) && 
                (
                    this.FinalizeAfterMinutes == input.FinalizeAfterMinutes ||
                    (this.FinalizeAfterMinutes != null &&
                    this.FinalizeAfterMinutes.Equals(input.FinalizeAfterMinutes))
                ) && 
                (
                    this.UpsellPathCode == input.UpsellPathCode ||
                    (this.UpsellPathCode != null &&
                    this.UpsellPathCode.Equals(input.UpsellPathCode))
                ) && 
                (
                    this.UpsellPathName == input.UpsellPathName ||
                    (this.UpsellPathName != null &&
                    this.UpsellPathName.Equals(input.UpsellPathName))
                ) && 
                (
                    this.UpsellPathVariation == input.UpsellPathVariation ||
                    (this.UpsellPathVariation != null &&
                    this.UpsellPathVariation.Equals(input.UpsellPathVariation))
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
                if (this.FinalizeAfterDts != null)
                    hashCode = hashCode * 59 + this.FinalizeAfterDts.GetHashCode();
                if (this.FinalizeAfterMinutes != null)
                    hashCode = hashCode * 59 + this.FinalizeAfterMinutes.GetHashCode();
                if (this.UpsellPathCode != null)
                    hashCode = hashCode * 59 + this.UpsellPathCode.GetHashCode();
                if (this.UpsellPathName != null)
                    hashCode = hashCode * 59 + this.UpsellPathName.GetHashCode();
                if (this.UpsellPathVariation != null)
                    hashCode = hashCode * 59 + this.UpsellPathVariation.GetHashCode();
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
            // UpsellPathCode (string) maxLength
            if(this.UpsellPathCode != null && this.UpsellPathCode.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UpsellPathCode, length must be less than 5.", new [] { "UpsellPathCode" });
            }


            yield break;
        }
    }

}
