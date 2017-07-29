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
    /// OrderEdi
    /// </summary>
    [DataContract]
    public partial class OrderEdi :  IEquatable<OrderEdi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderEdi" /> class.
        /// </summary>
        /// <param name="BillToEdiCode">Billing address identification code from the EDI order.  Typically DUNS or DUNS+4.</param>
        /// <param name="EdiDepartment">Department number associated with this EDI order.</param>
        /// <param name="EdiInternalVendorNumber">Internal vendor number associated with this EDI order.</param>
        /// <param name="ShipToEdiCode">Shipping address identification code from the EDI order.  Typically DUNS or DUNS+4.</param>
        public OrderEdi(string BillToEdiCode = default(string), string EdiDepartment = default(string), string EdiInternalVendorNumber = default(string), string ShipToEdiCode = default(string))
        {
            this.BillToEdiCode = BillToEdiCode;
            this.EdiDepartment = EdiDepartment;
            this.EdiInternalVendorNumber = EdiInternalVendorNumber;
            this.ShipToEdiCode = ShipToEdiCode;
        }
        
        /// <summary>
        /// Billing address identification code from the EDI order.  Typically DUNS or DUNS+4
        /// </summary>
        /// <value>Billing address identification code from the EDI order.  Typically DUNS or DUNS+4</value>
        [DataMember(Name="bill_to_edi_code", EmitDefaultValue=false)]
        public string BillToEdiCode { get; set; }

        /// <summary>
        /// Department number associated with this EDI order
        /// </summary>
        /// <value>Department number associated with this EDI order</value>
        [DataMember(Name="edi_department", EmitDefaultValue=false)]
        public string EdiDepartment { get; set; }

        /// <summary>
        /// Internal vendor number associated with this EDI order
        /// </summary>
        /// <value>Internal vendor number associated with this EDI order</value>
        [DataMember(Name="edi_internal_vendor_number", EmitDefaultValue=false)]
        public string EdiInternalVendorNumber { get; set; }

        /// <summary>
        /// Shipping address identification code from the EDI order.  Typically DUNS or DUNS+4
        /// </summary>
        /// <value>Shipping address identification code from the EDI order.  Typically DUNS or DUNS+4</value>
        [DataMember(Name="ship_to_edi_code", EmitDefaultValue=false)]
        public string ShipToEdiCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderEdi {\n");
            sb.Append("  BillToEdiCode: ").Append(BillToEdiCode).Append("\n");
            sb.Append("  EdiDepartment: ").Append(EdiDepartment).Append("\n");
            sb.Append("  EdiInternalVendorNumber: ").Append(EdiInternalVendorNumber).Append("\n");
            sb.Append("  ShipToEdiCode: ").Append(ShipToEdiCode).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrderEdi);
        }

        /// <summary>
        /// Returns true if OrderEdi instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderEdi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderEdi other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BillToEdiCode == other.BillToEdiCode ||
                    this.BillToEdiCode != null &&
                    this.BillToEdiCode.Equals(other.BillToEdiCode)
                ) && 
                (
                    this.EdiDepartment == other.EdiDepartment ||
                    this.EdiDepartment != null &&
                    this.EdiDepartment.Equals(other.EdiDepartment)
                ) && 
                (
                    this.EdiInternalVendorNumber == other.EdiInternalVendorNumber ||
                    this.EdiInternalVendorNumber != null &&
                    this.EdiInternalVendorNumber.Equals(other.EdiInternalVendorNumber)
                ) && 
                (
                    this.ShipToEdiCode == other.ShipToEdiCode ||
                    this.ShipToEdiCode != null &&
                    this.ShipToEdiCode.Equals(other.ShipToEdiCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.BillToEdiCode != null)
                    hash = hash * 59 + this.BillToEdiCode.GetHashCode();
                if (this.EdiDepartment != null)
                    hash = hash * 59 + this.EdiDepartment.GetHashCode();
                if (this.EdiInternalVendorNumber != null)
                    hash = hash * 59 + this.EdiInternalVendorNumber.GetHashCode();
                if (this.ShipToEdiCode != null)
                    hash = hash * 59 + this.ShipToEdiCode.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // EdiInternalVendorNumber (string) maxLength
            if(this.EdiInternalVendorNumber != null && this.EdiInternalVendorNumber.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EdiInternalVendorNumber, length must be less than 50.", new [] { "EdiInternalVendorNumber" });
            }

            yield break;
        }
    }

}
