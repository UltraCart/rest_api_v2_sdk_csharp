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
    /// PaymentsWepayEnroll
    /// </summary>
    [DataContract]
    public partial class PaymentsWepayEnroll :  IEquatable<PaymentsWepayEnroll>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsWepayEnroll" /> class.
        /// </summary>
        /// <param name="address1">address1.</param>
        /// <param name="address2">address2.</param>
        /// <param name="canadaAcceptDebitCards">canadaAcceptDebitCards.</param>
        /// <param name="city">city.</param>
        /// <param name="company">company.</param>
        /// <param name="companyDescription">companyDescription.</param>
        /// <param name="country">country.</param>
        /// <param name="expectedRevenue">expectedRevenue.</param>
        /// <param name="industry">industry.</param>
        /// <param name="ownerEmail">ownerEmail.</param>
        /// <param name="ownerName">ownerName.</param>
        /// <param name="ownerPhone">ownerPhone.</param>
        /// <param name="state">state.</param>
        /// <param name="webisteUrl">webisteUrl.</param>
        /// <param name="zip">zip.</param>
        public PaymentsWepayEnroll(string address1 = default(string), string address2 = default(string), bool? canadaAcceptDebitCards = default(bool?), string city = default(string), string company = default(string), string companyDescription = default(string), string country = default(string), string expectedRevenue = default(string), string industry = default(string), string ownerEmail = default(string), string ownerName = default(string), string ownerPhone = default(string), string state = default(string), string webisteUrl = default(string), string zip = default(string))
        {
            this.Address1 = address1;
            this.Address2 = address2;
            this.CanadaAcceptDebitCards = canadaAcceptDebitCards;
            this.City = city;
            this.Company = company;
            this.CompanyDescription = companyDescription;
            this.Country = country;
            this.ExpectedRevenue = expectedRevenue;
            this.Industry = industry;
            this.OwnerEmail = ownerEmail;
            this.OwnerName = ownerName;
            this.OwnerPhone = ownerPhone;
            this.State = state;
            this.WebisteUrl = webisteUrl;
            this.Zip = zip;
        }
        
        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets CanadaAcceptDebitCards
        /// </summary>
        [DataMember(Name="canada_accept_debit_cards", EmitDefaultValue=false)]
        public bool? CanadaAcceptDebitCards { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or Sets CompanyDescription
        /// </summary>
        [DataMember(Name="company_description", EmitDefaultValue=false)]
        public string CompanyDescription { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedRevenue
        /// </summary>
        [DataMember(Name="expected_revenue", EmitDefaultValue=false)]
        public string ExpectedRevenue { get; set; }

        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name="industry", EmitDefaultValue=false)]
        public string Industry { get; set; }

        /// <summary>
        /// Gets or Sets OwnerEmail
        /// </summary>
        [DataMember(Name="owner_email", EmitDefaultValue=false)]
        public string OwnerEmail { get; set; }

        /// <summary>
        /// Gets or Sets OwnerName
        /// </summary>
        [DataMember(Name="owner_name", EmitDefaultValue=false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or Sets OwnerPhone
        /// </summary>
        [DataMember(Name="owner_phone", EmitDefaultValue=false)]
        public string OwnerPhone { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets WebisteUrl
        /// </summary>
        [DataMember(Name="webiste_url", EmitDefaultValue=false)]
        public string WebisteUrl { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsWepayEnroll {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  CanadaAcceptDebitCards: ").Append(CanadaAcceptDebitCards).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CompanyDescription: ").Append(CompanyDescription).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ExpectedRevenue: ").Append(ExpectedRevenue).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  OwnerEmail: ").Append(OwnerEmail).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  OwnerPhone: ").Append(OwnerPhone).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  WebisteUrl: ").Append(WebisteUrl).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
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
            return this.Equals(input as PaymentsWepayEnroll);
        }

        /// <summary>
        /// Returns true if PaymentsWepayEnroll instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentsWepayEnroll to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsWepayEnroll input)
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
                    this.CanadaAcceptDebitCards == input.CanadaAcceptDebitCards ||
                    (this.CanadaAcceptDebitCards != null &&
                    this.CanadaAcceptDebitCards.Equals(input.CanadaAcceptDebitCards))
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
                    this.CompanyDescription == input.CompanyDescription ||
                    (this.CompanyDescription != null &&
                    this.CompanyDescription.Equals(input.CompanyDescription))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.ExpectedRevenue == input.ExpectedRevenue ||
                    (this.ExpectedRevenue != null &&
                    this.ExpectedRevenue.Equals(input.ExpectedRevenue))
                ) && 
                (
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.OwnerEmail == input.OwnerEmail ||
                    (this.OwnerEmail != null &&
                    this.OwnerEmail.Equals(input.OwnerEmail))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.OwnerPhone == input.OwnerPhone ||
                    (this.OwnerPhone != null &&
                    this.OwnerPhone.Equals(input.OwnerPhone))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.WebisteUrl == input.WebisteUrl ||
                    (this.WebisteUrl != null &&
                    this.WebisteUrl.Equals(input.WebisteUrl))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
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
                if (this.CanadaAcceptDebitCards != null)
                    hashCode = hashCode * 59 + this.CanadaAcceptDebitCards.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.CompanyDescription != null)
                    hashCode = hashCode * 59 + this.CompanyDescription.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.ExpectedRevenue != null)
                    hashCode = hashCode * 59 + this.ExpectedRevenue.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.OwnerEmail != null)
                    hashCode = hashCode * 59 + this.OwnerEmail.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.OwnerPhone != null)
                    hashCode = hashCode * 59 + this.OwnerPhone.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.WebisteUrl != null)
                    hashCode = hashCode * 59 + this.WebisteUrl.GetHashCode();
                if (this.Zip != null)
                    hashCode = hashCode * 59 + this.Zip.GetHashCode();
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