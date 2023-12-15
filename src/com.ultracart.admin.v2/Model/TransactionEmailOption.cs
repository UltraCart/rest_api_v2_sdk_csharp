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
    /// TransactionEmailOption
    /// </summary>
    [DataContract]
    public partial class TransactionEmailOption :  IEquatable<TransactionEmailOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionEmailOption" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="merchantEmailDeliveryOptionOid">merchantEmailDeliveryOptionOid.</param>
        /// <param name="merchantId">merchantId.</param>
        /// <param name="name">name.</param>
        /// <param name="selected">selected.</param>
        /// <param name="storeFrontOid">storeFrontOid.</param>
        /// <param name="templateDisplay">templateDisplay.</param>
        /// <param name="templateType">templateType.</param>
        public TransactionEmailOption(string description = default(string), int? merchantEmailDeliveryOptionOid = default(int?), string merchantId = default(string), string name = default(string), bool? selected = default(bool?), int? storeFrontOid = default(int?), string templateDisplay = default(string), string templateType = default(string))
        {
            this.Description = description;
            this.MerchantEmailDeliveryOptionOid = merchantEmailDeliveryOptionOid;
            this.MerchantId = merchantId;
            this.Name = name;
            this.Selected = selected;
            this.StoreFrontOid = storeFrontOid;
            this.TemplateDisplay = templateDisplay;
            this.TemplateType = templateType;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets MerchantEmailDeliveryOptionOid
        /// </summary>
        [DataMember(Name="merchantEmailDeliveryOptionOid", EmitDefaultValue=false)]
        public int? MerchantEmailDeliveryOptionOid { get; set; }

        /// <summary>
        /// Gets or Sets MerchantId
        /// </summary>
        [DataMember(Name="merchantId", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Selected
        /// </summary>
        [DataMember(Name="selected", EmitDefaultValue=false)]
        public bool? Selected { get; set; }

        /// <summary>
        /// Gets or Sets StoreFrontOid
        /// </summary>
        [DataMember(Name="storeFrontOid", EmitDefaultValue=false)]
        public int? StoreFrontOid { get; set; }

        /// <summary>
        /// Gets or Sets TemplateDisplay
        /// </summary>
        [DataMember(Name="templateDisplay", EmitDefaultValue=false)]
        public string TemplateDisplay { get; set; }

        /// <summary>
        /// Gets or Sets TemplateType
        /// </summary>
        [DataMember(Name="templateType", EmitDefaultValue=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionEmailOption {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MerchantEmailDeliveryOptionOid: ").Append(MerchantEmailDeliveryOptionOid).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  StoreFrontOid: ").Append(StoreFrontOid).Append("\n");
            sb.Append("  TemplateDisplay: ").Append(TemplateDisplay).Append("\n");
            sb.Append("  TemplateType: ").Append(TemplateType).Append("\n");
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
            return this.Equals(input as TransactionEmailOption);
        }

        /// <summary>
        /// Returns true if TransactionEmailOption instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionEmailOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionEmailOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MerchantEmailDeliveryOptionOid == input.MerchantEmailDeliveryOptionOid ||
                    (this.MerchantEmailDeliveryOptionOid != null &&
                    this.MerchantEmailDeliveryOptionOid.Equals(input.MerchantEmailDeliveryOptionOid))
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
                    this.Selected == input.Selected ||
                    (this.Selected != null &&
                    this.Selected.Equals(input.Selected))
                ) && 
                (
                    this.StoreFrontOid == input.StoreFrontOid ||
                    (this.StoreFrontOid != null &&
                    this.StoreFrontOid.Equals(input.StoreFrontOid))
                ) && 
                (
                    this.TemplateDisplay == input.TemplateDisplay ||
                    (this.TemplateDisplay != null &&
                    this.TemplateDisplay.Equals(input.TemplateDisplay))
                ) && 
                (
                    this.TemplateType == input.TemplateType ||
                    (this.TemplateType != null &&
                    this.TemplateType.Equals(input.TemplateType))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MerchantEmailDeliveryOptionOid != null)
                    hashCode = hashCode * 59 + this.MerchantEmailDeliveryOptionOid.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Selected != null)
                    hashCode = hashCode * 59 + this.Selected.GetHashCode();
                if (this.StoreFrontOid != null)
                    hashCode = hashCode * 59 + this.StoreFrontOid.GetHashCode();
                if (this.TemplateDisplay != null)
                    hashCode = hashCode * 59 + this.TemplateDisplay.GetHashCode();
                if (this.TemplateType != null)
                    hashCode = hashCode * 59 + this.TemplateType.GetHashCode();
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
