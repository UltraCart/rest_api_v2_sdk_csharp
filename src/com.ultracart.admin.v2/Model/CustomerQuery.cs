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
    /// CustomerQuery
    /// </summary>
    [DataContract]
    public partial class CustomerQuery :  IEquatable<CustomerQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerQuery" /> class.
        /// </summary>
        /// <param name="BillingCity">Billing city.</param>
        /// <param name="BillingCompany">Billing company.</param>
        /// <param name="BillingCountryCode">Billing country code.</param>
        /// <param name="BillingDayPhone">Billing day phone.</param>
        /// <param name="BillingEveningPhone">Billing evening phone.</param>
        /// <param name="BillingFirstName">Billing first name.</param>
        /// <param name="BillingLastName">Billing last name.</param>
        /// <param name="BillingPostalCode">Billing postal code.</param>
        /// <param name="BillingState">Billing state.</param>
        /// <param name="Email">Email address of this customer profile.</param>
        /// <param name="LastModifiedDtsEnd">Last modified date end.</param>
        /// <param name="LastModifiedDtsStart">Last modified date start.</param>
        /// <param name="PricingTierName">Pricing tier name.</param>
        /// <param name="PricingTierOid">Pricing tier oid.</param>
        /// <param name="QbClass">QuickBooks class to import this customer as.</param>
        /// <param name="QuickbooksCode">QuickBooks name to import this customer as.</param>
        /// <param name="ShippingCity">Billing city.</param>
        /// <param name="ShippingCompany">Billing company.</param>
        /// <param name="ShippingCountryCode">Billing country code.</param>
        /// <param name="ShippingDayPhone">Billing day phone.</param>
        /// <param name="ShippingEveningPhone">Billing evening phone.</param>
        /// <param name="ShippingFirstName">Billing first name.</param>
        /// <param name="ShippingLastName">Billing last name.</param>
        /// <param name="ShippingPostalCode">Billing postal code.</param>
        /// <param name="ShippingState">Billing state.</param>
        /// <param name="SignupDtsEnd">Signup date end.</param>
        /// <param name="SignupDtsStart">Signup date start.</param>
        public CustomerQuery(string BillingCity = default(string), string BillingCompany = default(string), string BillingCountryCode = default(string), string BillingDayPhone = default(string), string BillingEveningPhone = default(string), string BillingFirstName = default(string), string BillingLastName = default(string), string BillingPostalCode = default(string), string BillingState = default(string), string Email = default(string), string LastModifiedDtsEnd = default(string), string LastModifiedDtsStart = default(string), string PricingTierName = default(string), int? PricingTierOid = default(int?), string QbClass = default(string), string QuickbooksCode = default(string), string ShippingCity = default(string), string ShippingCompany = default(string), string ShippingCountryCode = default(string), string ShippingDayPhone = default(string), string ShippingEveningPhone = default(string), string ShippingFirstName = default(string), string ShippingLastName = default(string), string ShippingPostalCode = default(string), string ShippingState = default(string), string SignupDtsEnd = default(string), string SignupDtsStart = default(string))
        {
            this.BillingCity = BillingCity;
            this.BillingCompany = BillingCompany;
            this.BillingCountryCode = BillingCountryCode;
            this.BillingDayPhone = BillingDayPhone;
            this.BillingEveningPhone = BillingEveningPhone;
            this.BillingFirstName = BillingFirstName;
            this.BillingLastName = BillingLastName;
            this.BillingPostalCode = BillingPostalCode;
            this.BillingState = BillingState;
            this.Email = Email;
            this.LastModifiedDtsEnd = LastModifiedDtsEnd;
            this.LastModifiedDtsStart = LastModifiedDtsStart;
            this.PricingTierName = PricingTierName;
            this.PricingTierOid = PricingTierOid;
            this.QbClass = QbClass;
            this.QuickbooksCode = QuickbooksCode;
            this.ShippingCity = ShippingCity;
            this.ShippingCompany = ShippingCompany;
            this.ShippingCountryCode = ShippingCountryCode;
            this.ShippingDayPhone = ShippingDayPhone;
            this.ShippingEveningPhone = ShippingEveningPhone;
            this.ShippingFirstName = ShippingFirstName;
            this.ShippingLastName = ShippingLastName;
            this.ShippingPostalCode = ShippingPostalCode;
            this.ShippingState = ShippingState;
            this.SignupDtsEnd = SignupDtsEnd;
            this.SignupDtsStart = SignupDtsStart;
        }
        
        /// <summary>
        /// Billing city
        /// </summary>
        /// <value>Billing city</value>
        [DataMember(Name="billing_city", EmitDefaultValue=false)]
        public string BillingCity { get; set; }

        /// <summary>
        /// Billing company
        /// </summary>
        /// <value>Billing company</value>
        [DataMember(Name="billing_company", EmitDefaultValue=false)]
        public string BillingCompany { get; set; }

        /// <summary>
        /// Billing country code
        /// </summary>
        /// <value>Billing country code</value>
        [DataMember(Name="billing_country_code", EmitDefaultValue=false)]
        public string BillingCountryCode { get; set; }

        /// <summary>
        /// Billing day phone
        /// </summary>
        /// <value>Billing day phone</value>
        [DataMember(Name="billing_day_phone", EmitDefaultValue=false)]
        public string BillingDayPhone { get; set; }

        /// <summary>
        /// Billing evening phone
        /// </summary>
        /// <value>Billing evening phone</value>
        [DataMember(Name="billing_evening_phone", EmitDefaultValue=false)]
        public string BillingEveningPhone { get; set; }

        /// <summary>
        /// Billing first name
        /// </summary>
        /// <value>Billing first name</value>
        [DataMember(Name="billing_first_name", EmitDefaultValue=false)]
        public string BillingFirstName { get; set; }

        /// <summary>
        /// Billing last name
        /// </summary>
        /// <value>Billing last name</value>
        [DataMember(Name="billing_last_name", EmitDefaultValue=false)]
        public string BillingLastName { get; set; }

        /// <summary>
        /// Billing postal code
        /// </summary>
        /// <value>Billing postal code</value>
        [DataMember(Name="billing_postal_code", EmitDefaultValue=false)]
        public string BillingPostalCode { get; set; }

        /// <summary>
        /// Billing state
        /// </summary>
        /// <value>Billing state</value>
        [DataMember(Name="billing_state", EmitDefaultValue=false)]
        public string BillingState { get; set; }

        /// <summary>
        /// Email address of this customer profile
        /// </summary>
        /// <value>Email address of this customer profile</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Last modified date end
        /// </summary>
        /// <value>Last modified date end</value>
        [DataMember(Name="last_modified_dts_end", EmitDefaultValue=false)]
        public string LastModifiedDtsEnd { get; set; }

        /// <summary>
        /// Last modified date start
        /// </summary>
        /// <value>Last modified date start</value>
        [DataMember(Name="last_modified_dts_start", EmitDefaultValue=false)]
        public string LastModifiedDtsStart { get; set; }

        /// <summary>
        /// Pricing tier name
        /// </summary>
        /// <value>Pricing tier name</value>
        [DataMember(Name="pricing_tier_name", EmitDefaultValue=false)]
        public string PricingTierName { get; set; }

        /// <summary>
        /// Pricing tier oid
        /// </summary>
        /// <value>Pricing tier oid</value>
        [DataMember(Name="pricing_tier_oid", EmitDefaultValue=false)]
        public int? PricingTierOid { get; set; }

        /// <summary>
        /// QuickBooks class to import this customer as
        /// </summary>
        /// <value>QuickBooks class to import this customer as</value>
        [DataMember(Name="qb_class", EmitDefaultValue=false)]
        public string QbClass { get; set; }

        /// <summary>
        /// QuickBooks name to import this customer as
        /// </summary>
        /// <value>QuickBooks name to import this customer as</value>
        [DataMember(Name="quickbooks_code", EmitDefaultValue=false)]
        public string QuickbooksCode { get; set; }

        /// <summary>
        /// Billing city
        /// </summary>
        /// <value>Billing city</value>
        [DataMember(Name="shipping_city", EmitDefaultValue=false)]
        public string ShippingCity { get; set; }

        /// <summary>
        /// Billing company
        /// </summary>
        /// <value>Billing company</value>
        [DataMember(Name="shipping_company", EmitDefaultValue=false)]
        public string ShippingCompany { get; set; }

        /// <summary>
        /// Billing country code
        /// </summary>
        /// <value>Billing country code</value>
        [DataMember(Name="shipping_country_code", EmitDefaultValue=false)]
        public string ShippingCountryCode { get; set; }

        /// <summary>
        /// Billing day phone
        /// </summary>
        /// <value>Billing day phone</value>
        [DataMember(Name="shipping_day_phone", EmitDefaultValue=false)]
        public string ShippingDayPhone { get; set; }

        /// <summary>
        /// Billing evening phone
        /// </summary>
        /// <value>Billing evening phone</value>
        [DataMember(Name="shipping_evening_phone", EmitDefaultValue=false)]
        public string ShippingEveningPhone { get; set; }

        /// <summary>
        /// Billing first name
        /// </summary>
        /// <value>Billing first name</value>
        [DataMember(Name="shipping_first_name", EmitDefaultValue=false)]
        public string ShippingFirstName { get; set; }

        /// <summary>
        /// Billing last name
        /// </summary>
        /// <value>Billing last name</value>
        [DataMember(Name="shipping_last_name", EmitDefaultValue=false)]
        public string ShippingLastName { get; set; }

        /// <summary>
        /// Billing postal code
        /// </summary>
        /// <value>Billing postal code</value>
        [DataMember(Name="shipping_postal_code", EmitDefaultValue=false)]
        public string ShippingPostalCode { get; set; }

        /// <summary>
        /// Billing state
        /// </summary>
        /// <value>Billing state</value>
        [DataMember(Name="shipping_state", EmitDefaultValue=false)]
        public string ShippingState { get; set; }

        /// <summary>
        /// Signup date end
        /// </summary>
        /// <value>Signup date end</value>
        [DataMember(Name="signup_dts_end", EmitDefaultValue=false)]
        public string SignupDtsEnd { get; set; }

        /// <summary>
        /// Signup date start
        /// </summary>
        /// <value>Signup date start</value>
        [DataMember(Name="signup_dts_start", EmitDefaultValue=false)]
        public string SignupDtsStart { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerQuery {\n");
            sb.Append("  BillingCity: ").Append(BillingCity).Append("\n");
            sb.Append("  BillingCompany: ").Append(BillingCompany).Append("\n");
            sb.Append("  BillingCountryCode: ").Append(BillingCountryCode).Append("\n");
            sb.Append("  BillingDayPhone: ").Append(BillingDayPhone).Append("\n");
            sb.Append("  BillingEveningPhone: ").Append(BillingEveningPhone).Append("\n");
            sb.Append("  BillingFirstName: ").Append(BillingFirstName).Append("\n");
            sb.Append("  BillingLastName: ").Append(BillingLastName).Append("\n");
            sb.Append("  BillingPostalCode: ").Append(BillingPostalCode).Append("\n");
            sb.Append("  BillingState: ").Append(BillingState).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  LastModifiedDtsEnd: ").Append(LastModifiedDtsEnd).Append("\n");
            sb.Append("  LastModifiedDtsStart: ").Append(LastModifiedDtsStart).Append("\n");
            sb.Append("  PricingTierName: ").Append(PricingTierName).Append("\n");
            sb.Append("  PricingTierOid: ").Append(PricingTierOid).Append("\n");
            sb.Append("  QbClass: ").Append(QbClass).Append("\n");
            sb.Append("  QuickbooksCode: ").Append(QuickbooksCode).Append("\n");
            sb.Append("  ShippingCity: ").Append(ShippingCity).Append("\n");
            sb.Append("  ShippingCompany: ").Append(ShippingCompany).Append("\n");
            sb.Append("  ShippingCountryCode: ").Append(ShippingCountryCode).Append("\n");
            sb.Append("  ShippingDayPhone: ").Append(ShippingDayPhone).Append("\n");
            sb.Append("  ShippingEveningPhone: ").Append(ShippingEveningPhone).Append("\n");
            sb.Append("  ShippingFirstName: ").Append(ShippingFirstName).Append("\n");
            sb.Append("  ShippingLastName: ").Append(ShippingLastName).Append("\n");
            sb.Append("  ShippingPostalCode: ").Append(ShippingPostalCode).Append("\n");
            sb.Append("  ShippingState: ").Append(ShippingState).Append("\n");
            sb.Append("  SignupDtsEnd: ").Append(SignupDtsEnd).Append("\n");
            sb.Append("  SignupDtsStart: ").Append(SignupDtsStart).Append("\n");
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
            return this.Equals(input as CustomerQuery);
        }

        /// <summary>
        /// Returns true if CustomerQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingCity == input.BillingCity ||
                    (this.BillingCity != null &&
                    this.BillingCity.Equals(input.BillingCity))
                ) && 
                (
                    this.BillingCompany == input.BillingCompany ||
                    (this.BillingCompany != null &&
                    this.BillingCompany.Equals(input.BillingCompany))
                ) && 
                (
                    this.BillingCountryCode == input.BillingCountryCode ||
                    (this.BillingCountryCode != null &&
                    this.BillingCountryCode.Equals(input.BillingCountryCode))
                ) && 
                (
                    this.BillingDayPhone == input.BillingDayPhone ||
                    (this.BillingDayPhone != null &&
                    this.BillingDayPhone.Equals(input.BillingDayPhone))
                ) && 
                (
                    this.BillingEveningPhone == input.BillingEveningPhone ||
                    (this.BillingEveningPhone != null &&
                    this.BillingEveningPhone.Equals(input.BillingEveningPhone))
                ) && 
                (
                    this.BillingFirstName == input.BillingFirstName ||
                    (this.BillingFirstName != null &&
                    this.BillingFirstName.Equals(input.BillingFirstName))
                ) && 
                (
                    this.BillingLastName == input.BillingLastName ||
                    (this.BillingLastName != null &&
                    this.BillingLastName.Equals(input.BillingLastName))
                ) && 
                (
                    this.BillingPostalCode == input.BillingPostalCode ||
                    (this.BillingPostalCode != null &&
                    this.BillingPostalCode.Equals(input.BillingPostalCode))
                ) && 
                (
                    this.BillingState == input.BillingState ||
                    (this.BillingState != null &&
                    this.BillingState.Equals(input.BillingState))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.LastModifiedDtsEnd == input.LastModifiedDtsEnd ||
                    (this.LastModifiedDtsEnd != null &&
                    this.LastModifiedDtsEnd.Equals(input.LastModifiedDtsEnd))
                ) && 
                (
                    this.LastModifiedDtsStart == input.LastModifiedDtsStart ||
                    (this.LastModifiedDtsStart != null &&
                    this.LastModifiedDtsStart.Equals(input.LastModifiedDtsStart))
                ) && 
                (
                    this.PricingTierName == input.PricingTierName ||
                    (this.PricingTierName != null &&
                    this.PricingTierName.Equals(input.PricingTierName))
                ) && 
                (
                    this.PricingTierOid == input.PricingTierOid ||
                    (this.PricingTierOid != null &&
                    this.PricingTierOid.Equals(input.PricingTierOid))
                ) && 
                (
                    this.QbClass == input.QbClass ||
                    (this.QbClass != null &&
                    this.QbClass.Equals(input.QbClass))
                ) && 
                (
                    this.QuickbooksCode == input.QuickbooksCode ||
                    (this.QuickbooksCode != null &&
                    this.QuickbooksCode.Equals(input.QuickbooksCode))
                ) && 
                (
                    this.ShippingCity == input.ShippingCity ||
                    (this.ShippingCity != null &&
                    this.ShippingCity.Equals(input.ShippingCity))
                ) && 
                (
                    this.ShippingCompany == input.ShippingCompany ||
                    (this.ShippingCompany != null &&
                    this.ShippingCompany.Equals(input.ShippingCompany))
                ) && 
                (
                    this.ShippingCountryCode == input.ShippingCountryCode ||
                    (this.ShippingCountryCode != null &&
                    this.ShippingCountryCode.Equals(input.ShippingCountryCode))
                ) && 
                (
                    this.ShippingDayPhone == input.ShippingDayPhone ||
                    (this.ShippingDayPhone != null &&
                    this.ShippingDayPhone.Equals(input.ShippingDayPhone))
                ) && 
                (
                    this.ShippingEveningPhone == input.ShippingEveningPhone ||
                    (this.ShippingEveningPhone != null &&
                    this.ShippingEveningPhone.Equals(input.ShippingEveningPhone))
                ) && 
                (
                    this.ShippingFirstName == input.ShippingFirstName ||
                    (this.ShippingFirstName != null &&
                    this.ShippingFirstName.Equals(input.ShippingFirstName))
                ) && 
                (
                    this.ShippingLastName == input.ShippingLastName ||
                    (this.ShippingLastName != null &&
                    this.ShippingLastName.Equals(input.ShippingLastName))
                ) && 
                (
                    this.ShippingPostalCode == input.ShippingPostalCode ||
                    (this.ShippingPostalCode != null &&
                    this.ShippingPostalCode.Equals(input.ShippingPostalCode))
                ) && 
                (
                    this.ShippingState == input.ShippingState ||
                    (this.ShippingState != null &&
                    this.ShippingState.Equals(input.ShippingState))
                ) && 
                (
                    this.SignupDtsEnd == input.SignupDtsEnd ||
                    (this.SignupDtsEnd != null &&
                    this.SignupDtsEnd.Equals(input.SignupDtsEnd))
                ) && 
                (
                    this.SignupDtsStart == input.SignupDtsStart ||
                    (this.SignupDtsStart != null &&
                    this.SignupDtsStart.Equals(input.SignupDtsStart))
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
                if (this.BillingCity != null)
                    hashCode = hashCode * 59 + this.BillingCity.GetHashCode();
                if (this.BillingCompany != null)
                    hashCode = hashCode * 59 + this.BillingCompany.GetHashCode();
                if (this.BillingCountryCode != null)
                    hashCode = hashCode * 59 + this.BillingCountryCode.GetHashCode();
                if (this.BillingDayPhone != null)
                    hashCode = hashCode * 59 + this.BillingDayPhone.GetHashCode();
                if (this.BillingEveningPhone != null)
                    hashCode = hashCode * 59 + this.BillingEveningPhone.GetHashCode();
                if (this.BillingFirstName != null)
                    hashCode = hashCode * 59 + this.BillingFirstName.GetHashCode();
                if (this.BillingLastName != null)
                    hashCode = hashCode * 59 + this.BillingLastName.GetHashCode();
                if (this.BillingPostalCode != null)
                    hashCode = hashCode * 59 + this.BillingPostalCode.GetHashCode();
                if (this.BillingState != null)
                    hashCode = hashCode * 59 + this.BillingState.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.LastModifiedDtsEnd != null)
                    hashCode = hashCode * 59 + this.LastModifiedDtsEnd.GetHashCode();
                if (this.LastModifiedDtsStart != null)
                    hashCode = hashCode * 59 + this.LastModifiedDtsStart.GetHashCode();
                if (this.PricingTierName != null)
                    hashCode = hashCode * 59 + this.PricingTierName.GetHashCode();
                if (this.PricingTierOid != null)
                    hashCode = hashCode * 59 + this.PricingTierOid.GetHashCode();
                if (this.QbClass != null)
                    hashCode = hashCode * 59 + this.QbClass.GetHashCode();
                if (this.QuickbooksCode != null)
                    hashCode = hashCode * 59 + this.QuickbooksCode.GetHashCode();
                if (this.ShippingCity != null)
                    hashCode = hashCode * 59 + this.ShippingCity.GetHashCode();
                if (this.ShippingCompany != null)
                    hashCode = hashCode * 59 + this.ShippingCompany.GetHashCode();
                if (this.ShippingCountryCode != null)
                    hashCode = hashCode * 59 + this.ShippingCountryCode.GetHashCode();
                if (this.ShippingDayPhone != null)
                    hashCode = hashCode * 59 + this.ShippingDayPhone.GetHashCode();
                if (this.ShippingEveningPhone != null)
                    hashCode = hashCode * 59 + this.ShippingEveningPhone.GetHashCode();
                if (this.ShippingFirstName != null)
                    hashCode = hashCode * 59 + this.ShippingFirstName.GetHashCode();
                if (this.ShippingLastName != null)
                    hashCode = hashCode * 59 + this.ShippingLastName.GetHashCode();
                if (this.ShippingPostalCode != null)
                    hashCode = hashCode * 59 + this.ShippingPostalCode.GetHashCode();
                if (this.ShippingState != null)
                    hashCode = hashCode * 59 + this.ShippingState.GetHashCode();
                if (this.SignupDtsEnd != null)
                    hashCode = hashCode * 59 + this.SignupDtsEnd.GetHashCode();
                if (this.SignupDtsStart != null)
                    hashCode = hashCode * 59 + this.SignupDtsStart.GetHashCode();
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
            // BillingCity (string) maxLength
            if(this.BillingCity != null && this.BillingCity.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BillingCity, length must be less than 32.", new [] { "BillingCity" });
            }

            // BillingCompany (string) maxLength
            if(this.BillingCompany != null && this.BillingCompany.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BillingCompany, length must be less than 50.", new [] { "BillingCompany" });
            }

            // BillingCountryCode (string) maxLength
            if(this.BillingCountryCode != null && this.BillingCountryCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BillingCountryCode, length must be less than 2.", new [] { "BillingCountryCode" });
            }

            // BillingDayPhone (string) maxLength
            if(this.BillingDayPhone != null && this.BillingDayPhone.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BillingDayPhone, length must be less than 25.", new [] { "BillingDayPhone" });
            }

            // BillingEveningPhone (string) maxLength
            if(this.BillingEveningPhone != null && this.BillingEveningPhone.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BillingEveningPhone, length must be less than 25.", new [] { "BillingEveningPhone" });
            }

            // BillingFirstName (string) maxLength
            if(this.BillingFirstName != null && this.BillingFirstName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BillingFirstName, length must be less than 30.", new [] { "BillingFirstName" });
            }

            // BillingLastName (string) maxLength
            if(this.BillingLastName != null && this.BillingLastName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BillingLastName, length must be less than 30.", new [] { "BillingLastName" });
            }

            // BillingPostalCode (string) maxLength
            if(this.BillingPostalCode != null && this.BillingPostalCode.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BillingPostalCode, length must be less than 20.", new [] { "BillingPostalCode" });
            }

            // BillingState (string) maxLength
            if(this.BillingState != null && this.BillingState.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BillingState, length must be less than 32.", new [] { "BillingState" });
            }

            // PricingTierName (string) maxLength
            if(this.PricingTierName != null && this.PricingTierName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PricingTierName, length must be less than 50.", new [] { "PricingTierName" });
            }

            // ShippingCity (string) maxLength
            if(this.ShippingCity != null && this.ShippingCity.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingCity, length must be less than 32.", new [] { "ShippingCity" });
            }

            // ShippingCompany (string) maxLength
            if(this.ShippingCompany != null && this.ShippingCompany.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingCompany, length must be less than 50.", new [] { "ShippingCompany" });
            }

            // ShippingCountryCode (string) maxLength
            if(this.ShippingCountryCode != null && this.ShippingCountryCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingCountryCode, length must be less than 2.", new [] { "ShippingCountryCode" });
            }

            // ShippingDayPhone (string) maxLength
            if(this.ShippingDayPhone != null && this.ShippingDayPhone.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingDayPhone, length must be less than 25.", new [] { "ShippingDayPhone" });
            }

            // ShippingEveningPhone (string) maxLength
            if(this.ShippingEveningPhone != null && this.ShippingEveningPhone.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingEveningPhone, length must be less than 25.", new [] { "ShippingEveningPhone" });
            }

            // ShippingFirstName (string) maxLength
            if(this.ShippingFirstName != null && this.ShippingFirstName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingFirstName, length must be less than 30.", new [] { "ShippingFirstName" });
            }

            // ShippingLastName (string) maxLength
            if(this.ShippingLastName != null && this.ShippingLastName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingLastName, length must be less than 30.", new [] { "ShippingLastName" });
            }

            // ShippingPostalCode (string) maxLength
            if(this.ShippingPostalCode != null && this.ShippingPostalCode.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingPostalCode, length must be less than 20.", new [] { "ShippingPostalCode" });
            }

            // ShippingState (string) maxLength
            if(this.ShippingState != null && this.ShippingState.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingState, length must be less than 32.", new [] { "ShippingState" });
            }

            yield break;
        }
    }

}