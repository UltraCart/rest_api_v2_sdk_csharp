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
    /// OrderPaymentECheck
    /// </summary>
    [DataContract]
    public partial class OrderPaymentECheck :  IEquatable<OrderPaymentECheck>, IValidatableObject
    {
        /// <summary>
        /// Bank account type
        /// </summary>
        /// <value>Bank account type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BankAccountTypeEnum
        {
            
            /// <summary>
            /// Enum Checking for "Checking"
            /// </summary>
            [EnumMember(Value = "Checking")]
            Checking,
            
            /// <summary>
            /// Enum Savings for "Savings"
            /// </summary>
            [EnumMember(Value = "Savings")]
            Savings
        }

        /// <summary>
        /// Bank owner type
        /// </summary>
        /// <value>Bank owner type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BankOwnerTypeEnum
        {
            
            /// <summary>
            /// Enum Personal for "Personal"
            /// </summary>
            [EnumMember(Value = "Personal")]
            Personal,
            
            /// <summary>
            /// Enum Business for "Business"
            /// </summary>
            [EnumMember(Value = "Business")]
            Business
        }

        /// <summary>
        /// Bank account type
        /// </summary>
        /// <value>Bank account type</value>
        [DataMember(Name="bank_account_type", EmitDefaultValue=false)]
        public BankAccountTypeEnum? BankAccountType { get; set; }
        /// <summary>
        /// Bank owner type
        /// </summary>
        /// <value>Bank owner type</value>
        [DataMember(Name="bank_owner_type", EmitDefaultValue=false)]
        public BankOwnerTypeEnum? BankOwnerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPaymentECheck" /> class.
        /// </summary>
        /// <param name="BankAbaCode">Bank routing code.</param>
        /// <param name="BankAccountName">Bank account name.</param>
        /// <param name="BankAccountNumber">Bank account number (masked to last 4).</param>
        /// <param name="BankAccountType">Bank account type.</param>
        /// <param name="BankName">Bank name.</param>
        /// <param name="BankOwnerType">Bank owner type.</param>
        /// <param name="CustomerTaxId">Customer tax id (masked to last 4).</param>
        /// <param name="DriversLicenseDob">Driver license date of birth.</param>
        /// <param name="DriversLicenseNumber">Driver license number (masked to last 4).</param>
        /// <param name="DriversLicenseState">Driver license state.</param>
        public OrderPaymentECheck(string BankAbaCode = default(string), string BankAccountName = default(string), string BankAccountNumber = default(string), BankAccountTypeEnum? BankAccountType = default(BankAccountTypeEnum?), string BankName = default(string), BankOwnerTypeEnum? BankOwnerType = default(BankOwnerTypeEnum?), string CustomerTaxId = default(string), string DriversLicenseDob = default(string), string DriversLicenseNumber = default(string), string DriversLicenseState = default(string))
        {
            this.BankAbaCode = BankAbaCode;
            this.BankAccountName = BankAccountName;
            this.BankAccountNumber = BankAccountNumber;
            this.BankAccountType = BankAccountType;
            this.BankName = BankName;
            this.BankOwnerType = BankOwnerType;
            this.CustomerTaxId = CustomerTaxId;
            this.DriversLicenseDob = DriversLicenseDob;
            this.DriversLicenseNumber = DriversLicenseNumber;
            this.DriversLicenseState = DriversLicenseState;
        }
        
        /// <summary>
        /// Bank routing code
        /// </summary>
        /// <value>Bank routing code</value>
        [DataMember(Name="bank_aba_code", EmitDefaultValue=false)]
        public string BankAbaCode { get; set; }

        /// <summary>
        /// Bank account name
        /// </summary>
        /// <value>Bank account name</value>
        [DataMember(Name="bank_account_name", EmitDefaultValue=false)]
        public string BankAccountName { get; set; }

        /// <summary>
        /// Bank account number (masked to last 4)
        /// </summary>
        /// <value>Bank account number (masked to last 4)</value>
        [DataMember(Name="bank_account_number", EmitDefaultValue=false)]
        public string BankAccountNumber { get; set; }


        /// <summary>
        /// Bank name
        /// </summary>
        /// <value>Bank name</value>
        [DataMember(Name="bank_name", EmitDefaultValue=false)]
        public string BankName { get; set; }


        /// <summary>
        /// Customer tax id (masked to last 4)
        /// </summary>
        /// <value>Customer tax id (masked to last 4)</value>
        [DataMember(Name="customer_tax_id", EmitDefaultValue=false)]
        public string CustomerTaxId { get; set; }

        /// <summary>
        /// Driver license date of birth
        /// </summary>
        /// <value>Driver license date of birth</value>
        [DataMember(Name="drivers_license_dob", EmitDefaultValue=false)]
        public string DriversLicenseDob { get; set; }

        /// <summary>
        /// Driver license number (masked to last 4)
        /// </summary>
        /// <value>Driver license number (masked to last 4)</value>
        [DataMember(Name="drivers_license_number", EmitDefaultValue=false)]
        public string DriversLicenseNumber { get; set; }

        /// <summary>
        /// Driver license state
        /// </summary>
        /// <value>Driver license state</value>
        [DataMember(Name="drivers_license_state", EmitDefaultValue=false)]
        public string DriversLicenseState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderPaymentECheck {\n");
            sb.Append("  BankAbaCode: ").Append(BankAbaCode).Append("\n");
            sb.Append("  BankAccountName: ").Append(BankAccountName).Append("\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  BankAccountType: ").Append(BankAccountType).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BankOwnerType: ").Append(BankOwnerType).Append("\n");
            sb.Append("  CustomerTaxId: ").Append(CustomerTaxId).Append("\n");
            sb.Append("  DriversLicenseDob: ").Append(DriversLicenseDob).Append("\n");
            sb.Append("  DriversLicenseNumber: ").Append(DriversLicenseNumber).Append("\n");
            sb.Append("  DriversLicenseState: ").Append(DriversLicenseState).Append("\n");
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
            return this.Equals(obj as OrderPaymentECheck);
        }

        /// <summary>
        /// Returns true if OrderPaymentECheck instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderPaymentECheck to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderPaymentECheck other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BankAbaCode == other.BankAbaCode ||
                    this.BankAbaCode != null &&
                    this.BankAbaCode.Equals(other.BankAbaCode)
                ) && 
                (
                    this.BankAccountName == other.BankAccountName ||
                    this.BankAccountName != null &&
                    this.BankAccountName.Equals(other.BankAccountName)
                ) && 
                (
                    this.BankAccountNumber == other.BankAccountNumber ||
                    this.BankAccountNumber != null &&
                    this.BankAccountNumber.Equals(other.BankAccountNumber)
                ) && 
                (
                    this.BankAccountType == other.BankAccountType ||
                    this.BankAccountType != null &&
                    this.BankAccountType.Equals(other.BankAccountType)
                ) && 
                (
                    this.BankName == other.BankName ||
                    this.BankName != null &&
                    this.BankName.Equals(other.BankName)
                ) && 
                (
                    this.BankOwnerType == other.BankOwnerType ||
                    this.BankOwnerType != null &&
                    this.BankOwnerType.Equals(other.BankOwnerType)
                ) && 
                (
                    this.CustomerTaxId == other.CustomerTaxId ||
                    this.CustomerTaxId != null &&
                    this.CustomerTaxId.Equals(other.CustomerTaxId)
                ) && 
                (
                    this.DriversLicenseDob == other.DriversLicenseDob ||
                    this.DriversLicenseDob != null &&
                    this.DriversLicenseDob.Equals(other.DriversLicenseDob)
                ) && 
                (
                    this.DriversLicenseNumber == other.DriversLicenseNumber ||
                    this.DriversLicenseNumber != null &&
                    this.DriversLicenseNumber.Equals(other.DriversLicenseNumber)
                ) && 
                (
                    this.DriversLicenseState == other.DriversLicenseState ||
                    this.DriversLicenseState != null &&
                    this.DriversLicenseState.Equals(other.DriversLicenseState)
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
                if (this.BankAbaCode != null)
                    hash = hash * 59 + this.BankAbaCode.GetHashCode();
                if (this.BankAccountName != null)
                    hash = hash * 59 + this.BankAccountName.GetHashCode();
                if (this.BankAccountNumber != null)
                    hash = hash * 59 + this.BankAccountNumber.GetHashCode();
                if (this.BankAccountType != null)
                    hash = hash * 59 + this.BankAccountType.GetHashCode();
                if (this.BankName != null)
                    hash = hash * 59 + this.BankName.GetHashCode();
                if (this.BankOwnerType != null)
                    hash = hash * 59 + this.BankOwnerType.GetHashCode();
                if (this.CustomerTaxId != null)
                    hash = hash * 59 + this.CustomerTaxId.GetHashCode();
                if (this.DriversLicenseDob != null)
                    hash = hash * 59 + this.DriversLicenseDob.GetHashCode();
                if (this.DriversLicenseNumber != null)
                    hash = hash * 59 + this.DriversLicenseNumber.GetHashCode();
                if (this.DriversLicenseState != null)
                    hash = hash * 59 + this.DriversLicenseState.GetHashCode();
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
            // BankAbaCode (string) maxLength
            if(this.BankAbaCode != null && this.BankAbaCode.Length > 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankAbaCode, length must be less than 9.", new [] { "BankAbaCode" });
            }

            // BankAccountName (string) maxLength
            if(this.BankAccountName != null && this.BankAccountName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankAccountName, length must be less than 50.", new [] { "BankAccountName" });
            }

            // BankAccountNumber (string) maxLength
            if(this.BankAccountNumber != null && this.BankAccountNumber.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankAccountNumber, length must be less than 50.", new [] { "BankAccountNumber" });
            }

            // BankAccountType (string) maxLength
            if(this.BankAccountType != null && this.BankAccountType.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankAccountType, length must be less than 8.", new [] { "BankAccountType" });
            }

            // BankName (string) maxLength
            if(this.BankName != null && this.BankName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankName, length must be less than 50.", new [] { "BankName" });
            }

            // BankOwnerType (string) maxLength
            if(this.BankOwnerType != null && this.BankOwnerType.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankOwnerType, length must be less than 8.", new [] { "BankOwnerType" });
            }

            // CustomerTaxId (string) maxLength
            if(this.CustomerTaxId != null && this.CustomerTaxId.Length > 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerTaxId, length must be less than 9.", new [] { "CustomerTaxId" });
            }

            // DriversLicenseDob (string) maxLength
            if(this.DriversLicenseDob != null && this.DriversLicenseDob.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DriversLicenseDob, length must be less than 10.", new [] { "DriversLicenseDob" });
            }

            // DriversLicenseNumber (string) maxLength
            if(this.DriversLicenseNumber != null && this.DriversLicenseNumber.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DriversLicenseNumber, length must be less than 50.", new [] { "DriversLicenseNumber" });
            }

            // DriversLicenseState (string) maxLength
            if(this.DriversLicenseState != null && this.DriversLicenseState.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DriversLicenseState, length must be less than 2.", new [] { "DriversLicenseState" });
            }

            yield break;
        }
    }

}
