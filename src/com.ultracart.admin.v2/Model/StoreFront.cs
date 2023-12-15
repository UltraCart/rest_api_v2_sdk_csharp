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
    /// StoreFront
    /// </summary>
    [DataContract]
    public partial class StoreFront :  IEquatable<StoreFront>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFront" /> class.
        /// </summary>
        /// <param name="hostAlias1">hostAlias1.</param>
        /// <param name="hostAlias2">hostAlias2.</param>
        /// <param name="hostAlias3">hostAlias3.</param>
        /// <param name="hostAlias4">hostAlias4.</param>
        /// <param name="hostAlias5">hostAlias5.</param>
        /// <param name="hostName">hostName.</param>
        /// <param name="locked">locked.</param>
        /// <param name="merchantId">merchantId.</param>
        /// <param name="redirectAliases">redirectAliases.</param>
        /// <param name="storefrontOid">storefrontOid.</param>
        /// <param name="unlockPassword">unlockPassword.</param>
        public StoreFront(string hostAlias1 = default(string), string hostAlias2 = default(string), string hostAlias3 = default(string), string hostAlias4 = default(string), string hostAlias5 = default(string), string hostName = default(string), bool? locked = default(bool?), string merchantId = default(string), bool? redirectAliases = default(bool?), int? storefrontOid = default(int?), string unlockPassword = default(string))
        {
            this.HostAlias1 = hostAlias1;
            this.HostAlias2 = hostAlias2;
            this.HostAlias3 = hostAlias3;
            this.HostAlias4 = hostAlias4;
            this.HostAlias5 = hostAlias5;
            this.HostName = hostName;
            this.Locked = locked;
            this.MerchantId = merchantId;
            this.RedirectAliases = redirectAliases;
            this.StorefrontOid = storefrontOid;
            this.UnlockPassword = unlockPassword;
        }
        
        /// <summary>
        /// Gets or Sets HostAlias1
        /// </summary>
        [DataMember(Name="host_alias1", EmitDefaultValue=false)]
        public string HostAlias1 { get; set; }

        /// <summary>
        /// Gets or Sets HostAlias2
        /// </summary>
        [DataMember(Name="host_alias2", EmitDefaultValue=false)]
        public string HostAlias2 { get; set; }

        /// <summary>
        /// Gets or Sets HostAlias3
        /// </summary>
        [DataMember(Name="host_alias3", EmitDefaultValue=false)]
        public string HostAlias3 { get; set; }

        /// <summary>
        /// Gets or Sets HostAlias4
        /// </summary>
        [DataMember(Name="host_alias4", EmitDefaultValue=false)]
        public string HostAlias4 { get; set; }

        /// <summary>
        /// Gets or Sets HostAlias5
        /// </summary>
        [DataMember(Name="host_alias5", EmitDefaultValue=false)]
        public string HostAlias5 { get; set; }

        /// <summary>
        /// Gets or Sets HostName
        /// </summary>
        [DataMember(Name="host_name", EmitDefaultValue=false)]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Gets or Sets MerchantId
        /// </summary>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets RedirectAliases
        /// </summary>
        [DataMember(Name="redirect_aliases", EmitDefaultValue=false)]
        public bool? RedirectAliases { get; set; }

        /// <summary>
        /// Gets or Sets StorefrontOid
        /// </summary>
        [DataMember(Name="storefront_oid", EmitDefaultValue=false)]
        public int? StorefrontOid { get; set; }

        /// <summary>
        /// Gets or Sets UnlockPassword
        /// </summary>
        [DataMember(Name="unlock_password", EmitDefaultValue=false)]
        public string UnlockPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreFront {\n");
            sb.Append("  HostAlias1: ").Append(HostAlias1).Append("\n");
            sb.Append("  HostAlias2: ").Append(HostAlias2).Append("\n");
            sb.Append("  HostAlias3: ").Append(HostAlias3).Append("\n");
            sb.Append("  HostAlias4: ").Append(HostAlias4).Append("\n");
            sb.Append("  HostAlias5: ").Append(HostAlias5).Append("\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  RedirectAliases: ").Append(RedirectAliases).Append("\n");
            sb.Append("  StorefrontOid: ").Append(StorefrontOid).Append("\n");
            sb.Append("  UnlockPassword: ").Append(UnlockPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as StoreFront);
        }

        /// <summary>
        /// Returns true if StoreFront instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreFront to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreFront input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HostAlias1 == input.HostAlias1 ||
                    (this.HostAlias1 != null &&
                    this.HostAlias1.Equals(input.HostAlias1))
                ) && 
                (
                    this.HostAlias2 == input.HostAlias2 ||
                    (this.HostAlias2 != null &&
                    this.HostAlias2.Equals(input.HostAlias2))
                ) && 
                (
                    this.HostAlias3 == input.HostAlias3 ||
                    (this.HostAlias3 != null &&
                    this.HostAlias3.Equals(input.HostAlias3))
                ) && 
                (
                    this.HostAlias4 == input.HostAlias4 ||
                    (this.HostAlias4 != null &&
                    this.HostAlias4.Equals(input.HostAlias4))
                ) && 
                (
                    this.HostAlias5 == input.HostAlias5 ||
                    (this.HostAlias5 != null &&
                    this.HostAlias5.Equals(input.HostAlias5))
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.RedirectAliases == input.RedirectAliases ||
                    (this.RedirectAliases != null &&
                    this.RedirectAliases.Equals(input.RedirectAliases))
                ) && 
                (
                    this.StorefrontOid == input.StorefrontOid ||
                    (this.StorefrontOid != null &&
                    this.StorefrontOid.Equals(input.StorefrontOid))
                ) && 
                (
                    this.UnlockPassword == input.UnlockPassword ||
                    (this.UnlockPassword != null &&
                    this.UnlockPassword.Equals(input.UnlockPassword))
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
                if (this.HostAlias1 != null)
                    hashCode = hashCode * 59 + this.HostAlias1.GetHashCode();
                if (this.HostAlias2 != null)
                    hashCode = hashCode * 59 + this.HostAlias2.GetHashCode();
                if (this.HostAlias3 != null)
                    hashCode = hashCode * 59 + this.HostAlias3.GetHashCode();
                if (this.HostAlias4 != null)
                    hashCode = hashCode * 59 + this.HostAlias4.GetHashCode();
                if (this.HostAlias5 != null)
                    hashCode = hashCode * 59 + this.HostAlias5.GetHashCode();
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.RedirectAliases != null)
                    hashCode = hashCode * 59 + this.RedirectAliases.GetHashCode();
                if (this.StorefrontOid != null)
                    hashCode = hashCode * 59 + this.StorefrontOid.GetHashCode();
                if (this.UnlockPassword != null)
                    hashCode = hashCode * 59 + this.UnlockPassword.GetHashCode();
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
