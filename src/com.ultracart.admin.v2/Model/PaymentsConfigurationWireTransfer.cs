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
    /// PaymentsConfigurationWireTransfer
    /// </summary>
    [DataContract]
    public partial class PaymentsConfigurationWireTransfer :  IEquatable<PaymentsConfigurationWireTransfer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsConfigurationWireTransfer" /> class.
        /// </summary>
        /// <param name="acceptWireTransfer">acceptWireTransfer.</param>
        /// <param name="restrictions">restrictions.</param>
        /// <param name="wireTransferAccountingCode">wireTransferAccountingCode.</param>
        /// <param name="wireTransferAccountNumber">wireTransferAccountNumber.</param>
        /// <param name="wireTransferBankAddress">wireTransferBankAddress.</param>
        /// <param name="wireTransferDepositToAccount">wireTransferDepositToAccount.</param>
        /// <param name="wireTransferIntermediateRoutingNumber">wireTransferIntermediateRoutingNumber.</param>
        /// <param name="wireTransferRoutingNumber">wireTransferRoutingNumber.</param>
        /// <param name="wireTransferSurchargeAccountingCode">wireTransferSurchargeAccountingCode.</param>
        /// <param name="wireTransferSurchargeFee">wireTransferSurchargeFee.</param>
        /// <param name="wireTransferSurchargePerc">wireTransferSurchargePerc.</param>
        public PaymentsConfigurationWireTransfer(bool? acceptWireTransfer = default(bool?), PaymentsConfigurationRestrictions restrictions = default(PaymentsConfigurationRestrictions), string wireTransferAccountingCode = default(string), string wireTransferAccountNumber = default(string), string wireTransferBankAddress = default(string), string wireTransferDepositToAccount = default(string), string wireTransferIntermediateRoutingNumber = default(string), string wireTransferRoutingNumber = default(string), string wireTransferSurchargeAccountingCode = default(string), string wireTransferSurchargeFee = default(string), string wireTransferSurchargePerc = default(string))
        {
            this.AcceptWireTransfer = acceptWireTransfer;
            this.Restrictions = restrictions;
            this.WireTransferAccountingCode = wireTransferAccountingCode;
            this.WireTransferAccountNumber = wireTransferAccountNumber;
            this.WireTransferBankAddress = wireTransferBankAddress;
            this.WireTransferDepositToAccount = wireTransferDepositToAccount;
            this.WireTransferIntermediateRoutingNumber = wireTransferIntermediateRoutingNumber;
            this.WireTransferRoutingNumber = wireTransferRoutingNumber;
            this.WireTransferSurchargeAccountingCode = wireTransferSurchargeAccountingCode;
            this.WireTransferSurchargeFee = wireTransferSurchargeFee;
            this.WireTransferSurchargePerc = wireTransferSurchargePerc;
        }
        
        /// <summary>
        /// Gets or Sets AcceptWireTransfer
        /// </summary>
        [DataMember(Name="acceptWireTransfer", EmitDefaultValue=false)]
        public bool? AcceptWireTransfer { get; set; }

        /// <summary>
        /// Gets or Sets Restrictions
        /// </summary>
        [DataMember(Name="restrictions", EmitDefaultValue=false)]
        public PaymentsConfigurationRestrictions Restrictions { get; set; }

        /// <summary>
        /// Gets or Sets WireTransferAccountingCode
        /// </summary>
        [DataMember(Name="wireTransferAccountingCode", EmitDefaultValue=false)]
        public string WireTransferAccountingCode { get; set; }

        /// <summary>
        /// Gets or Sets WireTransferAccountNumber
        /// </summary>
        [DataMember(Name="wireTransferAccountNumber", EmitDefaultValue=false)]
        public string WireTransferAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets WireTransferBankAddress
        /// </summary>
        [DataMember(Name="wireTransferBankAddress", EmitDefaultValue=false)]
        public string WireTransferBankAddress { get; set; }

        /// <summary>
        /// Gets or Sets WireTransferDepositToAccount
        /// </summary>
        [DataMember(Name="wireTransferDepositToAccount", EmitDefaultValue=false)]
        public string WireTransferDepositToAccount { get; set; }

        /// <summary>
        /// Gets or Sets WireTransferIntermediateRoutingNumber
        /// </summary>
        [DataMember(Name="wireTransferIntermediateRoutingNumber", EmitDefaultValue=false)]
        public string WireTransferIntermediateRoutingNumber { get; set; }

        /// <summary>
        /// Gets or Sets WireTransferRoutingNumber
        /// </summary>
        [DataMember(Name="wireTransferRoutingNumber", EmitDefaultValue=false)]
        public string WireTransferRoutingNumber { get; set; }

        /// <summary>
        /// Gets or Sets WireTransferSurchargeAccountingCode
        /// </summary>
        [DataMember(Name="wireTransferSurchargeAccountingCode", EmitDefaultValue=false)]
        public string WireTransferSurchargeAccountingCode { get; set; }

        /// <summary>
        /// Gets or Sets WireTransferSurchargeFee
        /// </summary>
        [DataMember(Name="wireTransferSurchargeFee", EmitDefaultValue=false)]
        public string WireTransferSurchargeFee { get; set; }

        /// <summary>
        /// Gets or Sets WireTransferSurchargePerc
        /// </summary>
        [DataMember(Name="wireTransferSurchargePerc", EmitDefaultValue=false)]
        public string WireTransferSurchargePerc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsConfigurationWireTransfer {\n");
            sb.Append("  AcceptWireTransfer: ").Append(AcceptWireTransfer).Append("\n");
            sb.Append("  Restrictions: ").Append(Restrictions).Append("\n");
            sb.Append("  WireTransferAccountingCode: ").Append(WireTransferAccountingCode).Append("\n");
            sb.Append("  WireTransferAccountNumber: ").Append(WireTransferAccountNumber).Append("\n");
            sb.Append("  WireTransferBankAddress: ").Append(WireTransferBankAddress).Append("\n");
            sb.Append("  WireTransferDepositToAccount: ").Append(WireTransferDepositToAccount).Append("\n");
            sb.Append("  WireTransferIntermediateRoutingNumber: ").Append(WireTransferIntermediateRoutingNumber).Append("\n");
            sb.Append("  WireTransferRoutingNumber: ").Append(WireTransferRoutingNumber).Append("\n");
            sb.Append("  WireTransferSurchargeAccountingCode: ").Append(WireTransferSurchargeAccountingCode).Append("\n");
            sb.Append("  WireTransferSurchargeFee: ").Append(WireTransferSurchargeFee).Append("\n");
            sb.Append("  WireTransferSurchargePerc: ").Append(WireTransferSurchargePerc).Append("\n");
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
            return this.Equals(input as PaymentsConfigurationWireTransfer);
        }

        /// <summary>
        /// Returns true if PaymentsConfigurationWireTransfer instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentsConfigurationWireTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsConfigurationWireTransfer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcceptWireTransfer == input.AcceptWireTransfer ||
                    (this.AcceptWireTransfer != null &&
                    this.AcceptWireTransfer.Equals(input.AcceptWireTransfer))
                ) && 
                (
                    this.Restrictions == input.Restrictions ||
                    (this.Restrictions != null &&
                    this.Restrictions.Equals(input.Restrictions))
                ) && 
                (
                    this.WireTransferAccountingCode == input.WireTransferAccountingCode ||
                    (this.WireTransferAccountingCode != null &&
                    this.WireTransferAccountingCode.Equals(input.WireTransferAccountingCode))
                ) && 
                (
                    this.WireTransferAccountNumber == input.WireTransferAccountNumber ||
                    (this.WireTransferAccountNumber != null &&
                    this.WireTransferAccountNumber.Equals(input.WireTransferAccountNumber))
                ) && 
                (
                    this.WireTransferBankAddress == input.WireTransferBankAddress ||
                    (this.WireTransferBankAddress != null &&
                    this.WireTransferBankAddress.Equals(input.WireTransferBankAddress))
                ) && 
                (
                    this.WireTransferDepositToAccount == input.WireTransferDepositToAccount ||
                    (this.WireTransferDepositToAccount != null &&
                    this.WireTransferDepositToAccount.Equals(input.WireTransferDepositToAccount))
                ) && 
                (
                    this.WireTransferIntermediateRoutingNumber == input.WireTransferIntermediateRoutingNumber ||
                    (this.WireTransferIntermediateRoutingNumber != null &&
                    this.WireTransferIntermediateRoutingNumber.Equals(input.WireTransferIntermediateRoutingNumber))
                ) && 
                (
                    this.WireTransferRoutingNumber == input.WireTransferRoutingNumber ||
                    (this.WireTransferRoutingNumber != null &&
                    this.WireTransferRoutingNumber.Equals(input.WireTransferRoutingNumber))
                ) && 
                (
                    this.WireTransferSurchargeAccountingCode == input.WireTransferSurchargeAccountingCode ||
                    (this.WireTransferSurchargeAccountingCode != null &&
                    this.WireTransferSurchargeAccountingCode.Equals(input.WireTransferSurchargeAccountingCode))
                ) && 
                (
                    this.WireTransferSurchargeFee == input.WireTransferSurchargeFee ||
                    (this.WireTransferSurchargeFee != null &&
                    this.WireTransferSurchargeFee.Equals(input.WireTransferSurchargeFee))
                ) && 
                (
                    this.WireTransferSurchargePerc == input.WireTransferSurchargePerc ||
                    (this.WireTransferSurchargePerc != null &&
                    this.WireTransferSurchargePerc.Equals(input.WireTransferSurchargePerc))
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
                if (this.AcceptWireTransfer != null)
                    hashCode = hashCode * 59 + this.AcceptWireTransfer.GetHashCode();
                if (this.Restrictions != null)
                    hashCode = hashCode * 59 + this.Restrictions.GetHashCode();
                if (this.WireTransferAccountingCode != null)
                    hashCode = hashCode * 59 + this.WireTransferAccountingCode.GetHashCode();
                if (this.WireTransferAccountNumber != null)
                    hashCode = hashCode * 59 + this.WireTransferAccountNumber.GetHashCode();
                if (this.WireTransferBankAddress != null)
                    hashCode = hashCode * 59 + this.WireTransferBankAddress.GetHashCode();
                if (this.WireTransferDepositToAccount != null)
                    hashCode = hashCode * 59 + this.WireTransferDepositToAccount.GetHashCode();
                if (this.WireTransferIntermediateRoutingNumber != null)
                    hashCode = hashCode * 59 + this.WireTransferIntermediateRoutingNumber.GetHashCode();
                if (this.WireTransferRoutingNumber != null)
                    hashCode = hashCode * 59 + this.WireTransferRoutingNumber.GetHashCode();
                if (this.WireTransferSurchargeAccountingCode != null)
                    hashCode = hashCode * 59 + this.WireTransferSurchargeAccountingCode.GetHashCode();
                if (this.WireTransferSurchargeFee != null)
                    hashCode = hashCode * 59 + this.WireTransferSurchargeFee.GetHashCode();
                if (this.WireTransferSurchargePerc != null)
                    hashCode = hashCode * 59 + this.WireTransferSurchargePerc.GetHashCode();
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
