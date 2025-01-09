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
    /// EmailListSegmentFolder
    /// </summary>
    [DataContract]
    public partial class EmailListSegmentFolder :  IEquatable<EmailListSegmentFolder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailListSegmentFolder" /> class.
        /// </summary>
        /// <param name="espListSegmentFolderUuid">Email list segment folder UUID.</param>
        /// <param name="merchantId">Merchant ID.</param>
        /// <param name="name">Name of email campaign folder.</param>
        /// <param name="storefrontOid">Storefront oid.</param>
        /// <param name="systemGenerated">System generated folder.</param>
        public EmailListSegmentFolder(string espListSegmentFolderUuid = default(string), string merchantId = default(string), string name = default(string), int storefrontOid = default(int), bool systemGenerated = default(bool))
        {
            this.EspListSegmentFolderUuid = espListSegmentFolderUuid;
            this.MerchantId = merchantId;
            this.Name = name;
            this.StorefrontOid = storefrontOid;
            this.SystemGenerated = systemGenerated;
        }

        /// <summary>
        /// Email list segment folder UUID
        /// </summary>
        /// <value>Email list segment folder UUID</value>
        [DataMember(Name="esp_list_segment_folder_uuid", EmitDefaultValue=false)]
        public string EspListSegmentFolderUuid { get; set; }

        /// <summary>
        /// Merchant ID
        /// </summary>
        /// <value>Merchant ID</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Name of email campaign folder
        /// </summary>
        /// <value>Name of email campaign folder</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Storefront oid
        /// </summary>
        /// <value>Storefront oid</value>
        [DataMember(Name="storefront_oid", EmitDefaultValue=false)]
        public int StorefrontOid { get; set; }

        /// <summary>
        /// System generated folder
        /// </summary>
        /// <value>System generated folder</value>
        [DataMember(Name="system_generated", EmitDefaultValue=false)]
        public bool SystemGenerated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailListSegmentFolder {\n");
            sb.Append("  EspListSegmentFolderUuid: ").Append(EspListSegmentFolderUuid).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StorefrontOid: ").Append(StorefrontOid).Append("\n");
            sb.Append("  SystemGenerated: ").Append(SystemGenerated).Append("\n");
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
            return this.Equals(input as EmailListSegmentFolder);
        }

        /// <summary>
        /// Returns true if EmailListSegmentFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailListSegmentFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailListSegmentFolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EspListSegmentFolderUuid == input.EspListSegmentFolderUuid ||
                    (this.EspListSegmentFolderUuid != null &&
                    this.EspListSegmentFolderUuid.Equals(input.EspListSegmentFolderUuid))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StorefrontOid == input.StorefrontOid ||
                    (this.StorefrontOid != null &&
                    this.StorefrontOid.Equals(input.StorefrontOid))
                ) && 
                (
                    this.SystemGenerated == input.SystemGenerated ||
                    (this.SystemGenerated != null &&
                    this.SystemGenerated.Equals(input.SystemGenerated))
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
                if (this.EspListSegmentFolderUuid != null)
                    hashCode = hashCode * 59 + this.EspListSegmentFolderUuid.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StorefrontOid != null)
                    hashCode = hashCode * 59 + this.StorefrontOid.GetHashCode();
                if (this.SystemGenerated != null)
                    hashCode = hashCode * 59 + this.SystemGenerated.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 250.", new [] { "Name" });
            }


            yield break;
        }
    }

}
