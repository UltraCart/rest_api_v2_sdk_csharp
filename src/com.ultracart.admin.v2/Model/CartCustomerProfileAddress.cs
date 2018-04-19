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
    /// CartCustomerProfileAddress
    /// </summary>
    [DataContract]
    public partial class CartCustomerProfileAddress :  IEquatable<CartCustomerProfileAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartCustomerProfileAddress" /> class.
        /// </summary>
        /// <param name="Address1">Address 1.</param>
        /// <param name="Address2">Address 2.</param>
        /// <param name="City">City.</param>
        /// <param name="Company">Company.</param>
        /// <param name="CountryCode">ISO-3166 Country code.</param>
        /// <param name="DayPhone">Day phone.</param>
        /// <param name="EveningPhone">Evening phone.</param>
        /// <param name="FirstName">First name.</param>
        /// <param name="LastName">Last name.</param>
        /// <param name="Oid">Unique identifier for this address.</param>
        /// <param name="PostalCode">Postal code.</param>
        /// <param name="StateRegion">State for United States otherwise region or province for other countries.</param>
        /// <param name="TaxCounty">Tax county if a billing address.</param>
        /// <param name="Title">Title.</param>
        public CartCustomerProfileAddress(string Address1 = default(string), string Address2 = default(string), string City = default(string), string Company = default(string), string CountryCode = default(string), string DayPhone = default(string), string EveningPhone = default(string), string FirstName = default(string), string LastName = default(string), int? Oid = default(int?), string PostalCode = default(string), string StateRegion = default(string), string TaxCounty = default(string), string Title = default(string))
        {
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
            this.Company = Company;
            this.CountryCode = CountryCode;
            this.DayPhone = DayPhone;
            this.EveningPhone = EveningPhone;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Oid = Oid;
            this.PostalCode = PostalCode;
            this.StateRegion = StateRegion;
            this.TaxCounty = TaxCounty;
            this.Title = Title;
        }
        
        /// <summary>
        /// Address 1
        /// </summary>
        /// <value>Address 1</value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Address 2
        /// </summary>
        /// <value>Address 2</value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

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
        /// ISO-3166 Country code
        /// </summary>
        /// <value>ISO-3166 Country code</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Day phone
        /// </summary>
        /// <value>Day phone</value>
        [DataMember(Name="day_phone", EmitDefaultValue=false)]
        public string DayPhone { get; set; }

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
        /// Unique identifier for this address
        /// </summary>
        /// <value>Unique identifier for this address</value>
        [DataMember(Name="oid", EmitDefaultValue=false)]
        public int? Oid { get; set; }

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
        /// Tax county if a billing address
        /// </summary>
        /// <value>Tax county if a billing address</value>
        [DataMember(Name="tax_county", EmitDefaultValue=false)]
        public string TaxCounty { get; set; }

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
            sb.Append("class CartCustomerProfileAddress {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DayPhone: ").Append(DayPhone).Append("\n");
            sb.Append("  EveningPhone: ").Append(EveningPhone).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Oid: ").Append(Oid).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateRegion: ").Append(StateRegion).Append("\n");
            sb.Append("  TaxCounty: ").Append(TaxCounty).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as CartCustomerProfileAddress);
        }

        /// <summary>
        /// Returns true if CartCustomerProfileAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of CartCustomerProfileAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartCustomerProfileAddress input)
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
                    this.Oid == input.Oid ||
                    (this.Oid != null &&
                    this.Oid.Equals(input.Oid))
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
                    this.TaxCounty == input.TaxCounty ||
                    (this.TaxCounty != null &&
                    this.TaxCounty.Equals(input.TaxCounty))
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
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.DayPhone != null)
                    hashCode = hashCode * 59 + this.DayPhone.GetHashCode();
                if (this.EveningPhone != null)
                    hashCode = hashCode * 59 + this.EveningPhone.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Oid != null)
                    hashCode = hashCode * 59 + this.Oid.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.StateRegion != null)
                    hashCode = hashCode * 59 + this.StateRegion.GetHashCode();
                if (this.TaxCounty != null)
                    hashCode = hashCode * 59 + this.TaxCounty.GetHashCode();
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
            yield break;
        }
    }

}
