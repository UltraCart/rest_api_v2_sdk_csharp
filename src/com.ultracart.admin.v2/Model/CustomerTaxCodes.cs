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
    /// CustomerTaxCodes
    /// </summary>
    [DataContract]
    public partial class CustomerTaxCodes :  IEquatable<CustomerTaxCodes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerTaxCodes" /> class.
        /// </summary>
        /// <param name="AvalaraCustomerCode">Avalara customer code.</param>
        /// <param name="AvalaraEntityUseCode">Avalara entity use code.</param>
        /// <param name="TaxjarCustomerId">TaxJar customer id.</param>
        public CustomerTaxCodes(string AvalaraCustomerCode = default(string), string AvalaraEntityUseCode = default(string), string TaxjarCustomerId = default(string))
        {
            this.AvalaraCustomerCode = AvalaraCustomerCode;
            this.AvalaraEntityUseCode = AvalaraEntityUseCode;
            this.TaxjarCustomerId = TaxjarCustomerId;
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
        /// TaxJar customer id
        /// </summary>
        /// <value>TaxJar customer id</value>
        [DataMember(Name="taxjar_customer_id", EmitDefaultValue=false)]
        public string TaxjarCustomerId { get; set; }

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
            sb.Append("  TaxjarCustomerId: ").Append(TaxjarCustomerId).Append("\n");
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
                    this.TaxjarCustomerId == input.TaxjarCustomerId ||
                    (this.TaxjarCustomerId != null &&
                    this.TaxjarCustomerId.Equals(input.TaxjarCustomerId))
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
                if (this.TaxjarCustomerId != null)
                    hashCode = hashCode * 59 + this.TaxjarCustomerId.GetHashCode();
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