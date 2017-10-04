/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
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
    /// ItemRevguard
    /// </summary>
    [DataContract]
    public partial class ItemRevguard :  IEquatable<ItemRevguard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRevguard" /> class.
        /// </summary>
        /// <param name="RevguardCanceledCsrPromptGroup">Canceled CSR prompt group.</param>
        /// <param name="RevguardCanceledIvrPromptGroup">IVR prompt group.</param>
        /// <param name="RevguardCanceledWebPromptGroup">Canceled web prompt group.</param>
        /// <param name="RevguardClientBrand">Client brand.</param>
        /// <param name="RevguardCsrPromptGroup">CSR prompt group.</param>
        /// <param name="RevguardIvrPromptGroup">IVR prompt group.</param>
        /// <param name="RevguardWebPromptGroup">Web prompt group.</param>
        public ItemRevguard(long? RevguardCanceledCsrPromptGroup = default(long?), long? RevguardCanceledIvrPromptGroup = default(long?), long? RevguardCanceledWebPromptGroup = default(long?), long? RevguardClientBrand = default(long?), long? RevguardCsrPromptGroup = default(long?), long? RevguardIvrPromptGroup = default(long?), long? RevguardWebPromptGroup = default(long?))
        {
            this.RevguardCanceledCsrPromptGroup = RevguardCanceledCsrPromptGroup;
            this.RevguardCanceledIvrPromptGroup = RevguardCanceledIvrPromptGroup;
            this.RevguardCanceledWebPromptGroup = RevguardCanceledWebPromptGroup;
            this.RevguardClientBrand = RevguardClientBrand;
            this.RevguardCsrPromptGroup = RevguardCsrPromptGroup;
            this.RevguardIvrPromptGroup = RevguardIvrPromptGroup;
            this.RevguardWebPromptGroup = RevguardWebPromptGroup;
        }
        
        /// <summary>
        /// Canceled CSR prompt group
        /// </summary>
        /// <value>Canceled CSR prompt group</value>
        [DataMember(Name="revguard_canceled_csr_prompt_group", EmitDefaultValue=false)]
        public long? RevguardCanceledCsrPromptGroup { get; set; }

        /// <summary>
        /// IVR prompt group
        /// </summary>
        /// <value>IVR prompt group</value>
        [DataMember(Name="revguard_canceled_ivr_prompt_group", EmitDefaultValue=false)]
        public long? RevguardCanceledIvrPromptGroup { get; set; }

        /// <summary>
        /// Canceled web prompt group
        /// </summary>
        /// <value>Canceled web prompt group</value>
        [DataMember(Name="revguard_canceled_web_prompt_group", EmitDefaultValue=false)]
        public long? RevguardCanceledWebPromptGroup { get; set; }

        /// <summary>
        /// Client brand
        /// </summary>
        /// <value>Client brand</value>
        [DataMember(Name="revguard_client_brand", EmitDefaultValue=false)]
        public long? RevguardClientBrand { get; set; }

        /// <summary>
        /// CSR prompt group
        /// </summary>
        /// <value>CSR prompt group</value>
        [DataMember(Name="revguard_csr_prompt_group", EmitDefaultValue=false)]
        public long? RevguardCsrPromptGroup { get; set; }

        /// <summary>
        /// IVR prompt group
        /// </summary>
        /// <value>IVR prompt group</value>
        [DataMember(Name="revguard_ivr_prompt_group", EmitDefaultValue=false)]
        public long? RevguardIvrPromptGroup { get; set; }

        /// <summary>
        /// Web prompt group
        /// </summary>
        /// <value>Web prompt group</value>
        [DataMember(Name="revguard_web_prompt_group", EmitDefaultValue=false)]
        public long? RevguardWebPromptGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemRevguard {\n");
            sb.Append("  RevguardCanceledCsrPromptGroup: ").Append(RevguardCanceledCsrPromptGroup).Append("\n");
            sb.Append("  RevguardCanceledIvrPromptGroup: ").Append(RevguardCanceledIvrPromptGroup).Append("\n");
            sb.Append("  RevguardCanceledWebPromptGroup: ").Append(RevguardCanceledWebPromptGroup).Append("\n");
            sb.Append("  RevguardClientBrand: ").Append(RevguardClientBrand).Append("\n");
            sb.Append("  RevguardCsrPromptGroup: ").Append(RevguardCsrPromptGroup).Append("\n");
            sb.Append("  RevguardIvrPromptGroup: ").Append(RevguardIvrPromptGroup).Append("\n");
            sb.Append("  RevguardWebPromptGroup: ").Append(RevguardWebPromptGroup).Append("\n");
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
            return this.Equals(input as ItemRevguard);
        }

        /// <summary>
        /// Returns true if ItemRevguard instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemRevguard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemRevguard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RevguardCanceledCsrPromptGroup == input.RevguardCanceledCsrPromptGroup ||
                    (this.RevguardCanceledCsrPromptGroup != null &&
                    this.RevguardCanceledCsrPromptGroup.Equals(input.RevguardCanceledCsrPromptGroup))
                ) && 
                (
                    this.RevguardCanceledIvrPromptGroup == input.RevguardCanceledIvrPromptGroup ||
                    (this.RevguardCanceledIvrPromptGroup != null &&
                    this.RevguardCanceledIvrPromptGroup.Equals(input.RevguardCanceledIvrPromptGroup))
                ) && 
                (
                    this.RevguardCanceledWebPromptGroup == input.RevguardCanceledWebPromptGroup ||
                    (this.RevguardCanceledWebPromptGroup != null &&
                    this.RevguardCanceledWebPromptGroup.Equals(input.RevguardCanceledWebPromptGroup))
                ) && 
                (
                    this.RevguardClientBrand == input.RevguardClientBrand ||
                    (this.RevguardClientBrand != null &&
                    this.RevguardClientBrand.Equals(input.RevguardClientBrand))
                ) && 
                (
                    this.RevguardCsrPromptGroup == input.RevguardCsrPromptGroup ||
                    (this.RevguardCsrPromptGroup != null &&
                    this.RevguardCsrPromptGroup.Equals(input.RevguardCsrPromptGroup))
                ) && 
                (
                    this.RevguardIvrPromptGroup == input.RevguardIvrPromptGroup ||
                    (this.RevguardIvrPromptGroup != null &&
                    this.RevguardIvrPromptGroup.Equals(input.RevguardIvrPromptGroup))
                ) && 
                (
                    this.RevguardWebPromptGroup == input.RevguardWebPromptGroup ||
                    (this.RevguardWebPromptGroup != null &&
                    this.RevguardWebPromptGroup.Equals(input.RevguardWebPromptGroup))
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
                if (this.RevguardCanceledCsrPromptGroup != null)
                    hashCode = hashCode * 59 + this.RevguardCanceledCsrPromptGroup.GetHashCode();
                if (this.RevguardCanceledIvrPromptGroup != null)
                    hashCode = hashCode * 59 + this.RevguardCanceledIvrPromptGroup.GetHashCode();
                if (this.RevguardCanceledWebPromptGroup != null)
                    hashCode = hashCode * 59 + this.RevguardCanceledWebPromptGroup.GetHashCode();
                if (this.RevguardClientBrand != null)
                    hashCode = hashCode * 59 + this.RevguardClientBrand.GetHashCode();
                if (this.RevguardCsrPromptGroup != null)
                    hashCode = hashCode * 59 + this.RevguardCsrPromptGroup.GetHashCode();
                if (this.RevguardIvrPromptGroup != null)
                    hashCode = hashCode * 59 + this.RevguardIvrPromptGroup.GetHashCode();
                if (this.RevguardWebPromptGroup != null)
                    hashCode = hashCode * 59 + this.RevguardWebPromptGroup.GetHashCode();
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
