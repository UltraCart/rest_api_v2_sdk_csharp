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
    /// ChannelPartnerShipToPreference
    /// </summary>
    [DataContract]
    public partial class ChannelPartnerShipToPreference :  IEquatable<ChannelPartnerShipToPreference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelPartnerShipToPreference" /> class.
        /// </summary>
        /// <param name="additionalKitComponentItemIds">Additional item ids to add as kit components to the order with a zero price..</param>
        /// <param name="channelPartnerOid">The channel partner object identifier this preference is associated with.</param>
        /// <param name="channelPartnerShipToPreferenceOid">Object identifier for the ship to preference.</param>
        /// <param name="description">A description that is meaningful to the merchant..</param>
        /// <param name="merchantId">The merchant id that owns the channel partner.</param>
        /// <param name="returnPolicy">Alternate return policy to print on the packing slip..</param>
        /// <param name="shipToEdiCode">The ship to EDI code that the preferences are for.</param>
        public ChannelPartnerShipToPreference(List<string> additionalKitComponentItemIds = default(List<string>), int channelPartnerOid = default(int), int channelPartnerShipToPreferenceOid = default(int), string description = default(string), string merchantId = default(string), string returnPolicy = default(string), string shipToEdiCode = default(string))
        {
            this.AdditionalKitComponentItemIds = additionalKitComponentItemIds;
            this.ChannelPartnerOid = channelPartnerOid;
            this.ChannelPartnerShipToPreferenceOid = channelPartnerShipToPreferenceOid;
            this.Description = description;
            this.MerchantId = merchantId;
            this.ReturnPolicy = returnPolicy;
            this.ShipToEdiCode = shipToEdiCode;
        }

        /// <summary>
        /// Additional item ids to add as kit components to the order with a zero price.
        /// </summary>
        /// <value>Additional item ids to add as kit components to the order with a zero price.</value>
        [DataMember(Name="additional_kit_component_item_ids", EmitDefaultValue=false)]
        public List<string> AdditionalKitComponentItemIds { get; set; }

        /// <summary>
        /// The channel partner object identifier this preference is associated with
        /// </summary>
        /// <value>The channel partner object identifier this preference is associated with</value>
        [DataMember(Name="channel_partner_oid", EmitDefaultValue=false)]
        public int ChannelPartnerOid { get; set; }

        /// <summary>
        /// Object identifier for the ship to preference
        /// </summary>
        /// <value>Object identifier for the ship to preference</value>
        [DataMember(Name="channel_partner_ship_to_preference_oid", EmitDefaultValue=false)]
        public int ChannelPartnerShipToPreferenceOid { get; set; }

        /// <summary>
        /// A description that is meaningful to the merchant.
        /// </summary>
        /// <value>A description that is meaningful to the merchant.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The merchant id that owns the channel partner
        /// </summary>
        /// <value>The merchant id that owns the channel partner</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Alternate return policy to print on the packing slip.
        /// </summary>
        /// <value>Alternate return policy to print on the packing slip.</value>
        [DataMember(Name="return_policy", EmitDefaultValue=false)]
        public string ReturnPolicy { get; set; }

        /// <summary>
        /// The ship to EDI code that the preferences are for
        /// </summary>
        /// <value>The ship to EDI code that the preferences are for</value>
        [DataMember(Name="ship_to_edi_code", EmitDefaultValue=false)]
        public string ShipToEdiCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelPartnerShipToPreference {\n");
            sb.Append("  AdditionalKitComponentItemIds: ").Append(AdditionalKitComponentItemIds).Append("\n");
            sb.Append("  ChannelPartnerOid: ").Append(ChannelPartnerOid).Append("\n");
            sb.Append("  ChannelPartnerShipToPreferenceOid: ").Append(ChannelPartnerShipToPreferenceOid).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  ReturnPolicy: ").Append(ReturnPolicy).Append("\n");
            sb.Append("  ShipToEdiCode: ").Append(ShipToEdiCode).Append("\n");
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
            return this.Equals(input as ChannelPartnerShipToPreference);
        }

        /// <summary>
        /// Returns true if ChannelPartnerShipToPreference instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelPartnerShipToPreference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelPartnerShipToPreference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalKitComponentItemIds == input.AdditionalKitComponentItemIds ||
                    this.AdditionalKitComponentItemIds != null &&
                    input.AdditionalKitComponentItemIds != null &&
                    this.AdditionalKitComponentItemIds.SequenceEqual(input.AdditionalKitComponentItemIds)
                ) && 
                (
                    this.ChannelPartnerOid == input.ChannelPartnerOid ||
                    (this.ChannelPartnerOid != null &&
                    this.ChannelPartnerOid.Equals(input.ChannelPartnerOid))
                ) && 
                (
                    this.ChannelPartnerShipToPreferenceOid == input.ChannelPartnerShipToPreferenceOid ||
                    (this.ChannelPartnerShipToPreferenceOid != null &&
                    this.ChannelPartnerShipToPreferenceOid.Equals(input.ChannelPartnerShipToPreferenceOid))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.ReturnPolicy == input.ReturnPolicy ||
                    (this.ReturnPolicy != null &&
                    this.ReturnPolicy.Equals(input.ReturnPolicy))
                ) && 
                (
                    this.ShipToEdiCode == input.ShipToEdiCode ||
                    (this.ShipToEdiCode != null &&
                    this.ShipToEdiCode.Equals(input.ShipToEdiCode))
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
                if (this.AdditionalKitComponentItemIds != null)
                    hashCode = hashCode * 59 + this.AdditionalKitComponentItemIds.GetHashCode();
                if (this.ChannelPartnerOid != null)
                    hashCode = hashCode * 59 + this.ChannelPartnerOid.GetHashCode();
                if (this.ChannelPartnerShipToPreferenceOid != null)
                    hashCode = hashCode * 59 + this.ChannelPartnerShipToPreferenceOid.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.ReturnPolicy != null)
                    hashCode = hashCode * 59 + this.ReturnPolicy.GetHashCode();
                if (this.ShipToEdiCode != null)
                    hashCode = hashCode * 59 + this.ShipToEdiCode.GetHashCode();
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
            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 100.", new [] { "Description" });
            }


            yield break;
        }
    }

}
