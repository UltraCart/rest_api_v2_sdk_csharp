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
    /// CartBilling
    /// </summary>
    [DataContract]
    public partial class CartBilling :  IEquatable<CartBilling>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartBilling" /> class.
        /// </summary>
        /// <param name="address1">Address line 1.</param>
        /// <param name="address2">Address line 2.</param>
        /// <param name="ccEmails">CC emails.  Multiple allowed, but total length of all emails can not exceed 100 characters..</param>
        /// <param name="city">City.</param>
        /// <param name="company">Company.</param>
        /// <param name="countryCode">ISO-3166 two letter country code.</param>
        /// <param name="dayPhone">Day phone.</param>
        /// <param name="email">Email.</param>
        /// <param name="emailConfirm">Email entered for confirmation.</param>
        /// <param name="eveningPhone">Evening phone.</param>
        /// <param name="firstName">First name.</param>
        /// <param name="lastName">Last name.</param>
        /// <param name="postalCode">Postal code.</param>
        /// <param name="stateRegion">State for United States otherwise region or province for other countries.</param>
        /// <param name="title">Title.</param>
        public CartBilling(string address1 = default(string), string address2 = default(string), List<string> ccEmails = default(List<string>), string city = default(string), string company = default(string), string countryCode = default(string), string dayPhone = default(string), string email = default(string), string emailConfirm = default(string), string eveningPhone = default(string), string firstName = default(string), string lastName = default(string), string postalCode = default(string), string stateRegion = default(string), string title = default(string))
        {
            this.Address1 = address1;
            this.Address2 = address2;
            this.CcEmails = ccEmails;
            this.City = city;
            this.Company = company;
            this.CountryCode = countryCode;
            this.DayPhone = dayPhone;
            this.Email = email;
            this.EmailConfirm = emailConfirm;
            this.EveningPhone = eveningPhone;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PostalCode = postalCode;
            this.StateRegion = stateRegion;
            this.Title = title;
        }
        
        /// <summary>
        /// Address line 1
        /// </summary>
        /// <value>Address line 1</value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        /// <value>Address line 2</value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// CC emails.  Multiple allowed, but total length of all emails can not exceed 100 characters.
        /// </summary>
        /// <value>CC emails.  Multiple allowed, but total length of all emails can not exceed 100 characters.</value>
        [DataMember(Name="cc_emails", EmitDefaultValue=false)]
        public List<string> CcEmails { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Company
        /// </summary>
        /// <value>Company</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// ISO-3166 two letter country code
        /// </summary>
        /// <value>ISO-3166 two letter country code</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Day phone
        /// </summary>
        /// <value>Day phone</value>
        [DataMember(Name="day_phone", EmitDefaultValue=false)]
        public string DayPhone { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Email entered for confirmation
        /// </summary>
        /// <value>Email entered for confirmation</value>
        [DataMember(Name="email_confirm", EmitDefaultValue=false)]
        public string EmailConfirm { get; set; }

        /// <summary>
        /// Evening phone
        /// </summary>
        /// <value>Evening phone</value>
        [DataMember(Name="evening_phone", EmitDefaultValue=false)]
        public string EveningPhone { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        /// <value>First name</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        /// <value>Last name</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// State for United States otherwise region or province for other countries
        /// </summary>
        /// <value>State for United States otherwise region or province for other countries</value>
        [DataMember(Name="state_region", EmitDefaultValue=false)]
        public string StateRegion { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        /// <value>Title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartBilling {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  CcEmails: ").Append(CcEmails).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DayPhone: ").Append(DayPhone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailConfirm: ").Append(EmailConfirm).Append("\n");
            sb.Append("  EveningPhone: ").Append(EveningPhone).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateRegion: ").Append(StateRegion).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as CartBilling);
        }

        /// <summary>
        /// Returns true if CartBilling instances are equal
        /// </summary>
        /// <param name="input">Instance of CartBilling to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartBilling input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.CcEmails == input.CcEmails ||
                    this.CcEmails != null &&
                    this.CcEmails.SequenceEqual(input.CcEmails)
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.DayPhone == input.DayPhone ||
                    (this.DayPhone != null &&
                    this.DayPhone.Equals(input.DayPhone))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.EmailConfirm == input.EmailConfirm ||
                    (this.EmailConfirm != null &&
                    this.EmailConfirm.Equals(input.EmailConfirm))
                ) && 
                (
                    this.EveningPhone == input.EveningPhone ||
                    (this.EveningPhone != null &&
                    this.EveningPhone.Equals(input.EveningPhone))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.StateRegion == input.StateRegion ||
                    (this.StateRegion != null &&
                    this.StateRegion.Equals(input.StateRegion))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.CcEmails != null)
                    hashCode = hashCode * 59 + this.CcEmails.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.DayPhone != null)
                    hashCode = hashCode * 59 + this.DayPhone.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.EmailConfirm != null)
                    hashCode = hashCode * 59 + this.EmailConfirm.GetHashCode();
                if (this.EveningPhone != null)
                    hashCode = hashCode * 59 + this.EveningPhone.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.StateRegion != null)
                    hashCode = hashCode * 59 + this.StateRegion.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
            // Address1 (string) maxLength
            if(this.Address1 != null && this.Address1.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address1, length must be less than 50.", new [] { "Address1" });
            }

            // Address2 (string) maxLength
            if(this.Address2 != null && this.Address2.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address2, length must be less than 50.", new [] { "Address2" });
            }

            // City (string) maxLength
            if(this.City != null && this.City.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 32.", new [] { "City" });
            }

            // Company (string) maxLength
            if(this.Company != null && this.Company.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Company, length must be less than 50.", new [] { "Company" });
            }

            // CountryCode (string) maxLength
            if(this.CountryCode != null && this.CountryCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 2.", new [] { "CountryCode" });
            }

            // DayPhone (string) maxLength
            if(this.DayPhone != null && this.DayPhone.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DayPhone, length must be less than 25.", new [] { "DayPhone" });
            }

            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 100.", new [] { "Email" });
            }

            // EmailConfirm (string) maxLength
            if(this.EmailConfirm != null && this.EmailConfirm.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailConfirm, length must be less than 100.", new [] { "EmailConfirm" });
            }

            // EveningPhone (string) maxLength
            if(this.EveningPhone != null && this.EveningPhone.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EveningPhone, length must be less than 25.", new [] { "EveningPhone" });
            }

            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 30.", new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 30.", new [] { "LastName" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 20.", new [] { "PostalCode" });
            }

            // StateRegion (string) maxLength
            if(this.StateRegion != null && this.StateRegion.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StateRegion, length must be less than 32.", new [] { "StateRegion" });
            }

            // Title (string) maxLength
            if(this.Title != null && this.Title.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 50.", new [] { "Title" });
            }

            yield break;
        }
    }

}
