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
    /// CustomerTaxCodes
    /// </summary>
    [DataContract]
    public partial class CustomerTaxCodes :  IEquatable<CustomerTaxCodes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerTaxCodes" /> class.
        /// </summary>
        /// <param name="avalaraCustomerCode">Avalara customer code.</param>
        /// <param name="avalaraEntityUseCode">Avalara entity use code.</param>
        /// <param name="sovosCustomerCode">Sovos customer code.</param>
        /// <param name="taxjarCustomerId">TaxJar customer id.</param>
        /// <param name="taxjarExemptionType">TaxJar exemption type.</param>
        public CustomerTaxCodes(string avalaraCustomerCode = default(string), string avalaraEntityUseCode = default(string), string sovosCustomerCode = default(string), string taxjarCustomerId = default(string), string taxjarExemptionType = default(string))
        {
            this.AvalaraCustomerCode = avalaraCustomerCode;
            this.AvalaraEntityUseCode = avalaraEntityUseCode;
            this.SovosCustomerCode = sovosCustomerCode;
            this.TaxjarCustomerId = taxjarCustomerId;
            this.TaxjarExemptionType = taxjarExemptionType;
        }

        /// <summary>
        /// Avalara customer code
        /// </summary>
        /// <value>Avalara customer code</value>
        [DataMember(Name="avalara_customer_code", EmitDefaultValue=false)]
        public string AvalaraCustomerCode { get; set; }

        /// <summary>
        /// Avalara entity use code
        /// </summary>
        /// <value>Avalara entity use code</value>
        [DataMember(Name="avalara_entity_use_code", EmitDefaultValue=false)]
        public string AvalaraEntityUseCode { get; set; }

        /// <summary>
        /// Sovos customer code
        /// </summary>
        /// <value>Sovos customer code</value>
        [DataMember(Name="sovos_customer_code", EmitDefaultValue=false)]
        public string SovosCustomerCode { get; set; }

        /// <summary>
        /// TaxJar customer id
        /// </summary>
        /// <value>TaxJar customer id</value>
        [DataMember(Name="taxjar_customer_id", EmitDefaultValue=false)]
        public string TaxjarCustomerId { get; set; }

        /// <summary>
        /// TaxJar exemption type
        /// </summary>
        /// <value>TaxJar exemption type</value>
        [DataMember(Name="taxjar_exemption_type", EmitDefaultValue=false)]
        public string TaxjarExemptionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerTaxCodes {\n");
            sb.Append("  AvalaraCustomerCode: ").Append(AvalaraCustomerCode).Append("\n");
            sb.Append("  AvalaraEntityUseCode: ").Append(AvalaraEntityUseCode).Append("\n");
            sb.Append("  SovosCustomerCode: ").Append(SovosCustomerCode).Append("\n");
            sb.Append("  TaxjarCustomerId: ").Append(TaxjarCustomerId).Append("\n");
            sb.Append("  TaxjarExemptionType: ").Append(TaxjarExemptionType).Append("\n");
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
            return this.Equals(input as CustomerTaxCodes);
        }

        /// <summary>
        /// Returns true if CustomerTaxCodes instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerTaxCodes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerTaxCodes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvalaraCustomerCode == input.AvalaraCustomerCode ||
                    (this.AvalaraCustomerCode != null &&
                    this.AvalaraCustomerCode.Equals(input.AvalaraCustomerCode))
                ) && 
                (
                    this.AvalaraEntityUseCode == input.AvalaraEntityUseCode ||
                    (this.AvalaraEntityUseCode != null &&
                    this.AvalaraEntityUseCode.Equals(input.AvalaraEntityUseCode))
                ) && 
                (
                    this.SovosCustomerCode == input.SovosCustomerCode ||
                    (this.SovosCustomerCode != null &&
                    this.SovosCustomerCode.Equals(input.SovosCustomerCode))
                ) && 
                (
                    this.TaxjarCustomerId == input.TaxjarCustomerId ||
                    (this.TaxjarCustomerId != null &&
                    this.TaxjarCustomerId.Equals(input.TaxjarCustomerId))
                ) && 
                (
                    this.TaxjarExemptionType == input.TaxjarExemptionType ||
                    (this.TaxjarExemptionType != null &&
                    this.TaxjarExemptionType.Equals(input.TaxjarExemptionType))
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
                if (this.AvalaraCustomerCode != null)
                    hashCode = hashCode * 59 + this.AvalaraCustomerCode.GetHashCode();
                if (this.AvalaraEntityUseCode != null)
                    hashCode = hashCode * 59 + this.AvalaraEntityUseCode.GetHashCode();
                if (this.SovosCustomerCode != null)
                    hashCode = hashCode * 59 + this.SovosCustomerCode.GetHashCode();
                if (this.TaxjarCustomerId != null)
                    hashCode = hashCode * 59 + this.TaxjarCustomerId.GetHashCode();
                if (this.TaxjarExemptionType != null)
                    hashCode = hashCode * 59 + this.TaxjarExemptionType.GetHashCode();
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
