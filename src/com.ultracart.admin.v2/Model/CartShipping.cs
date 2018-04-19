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
    /// CartShipping
    /// </summary>
    [DataContract]
    public partial class CartShipping :  IEquatable<CartShipping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartShipping" /> class.
        /// </summary>
        /// <param name="Address1">Address line 1.</param>
        /// <param name="Address2">Address line 2.</param>
        /// <param name="City">City.</param>
        /// <param name="Company">Company.</param>
        /// <param name="CountryCode">ISO-3166 two letter country code.</param>
        /// <param name="DayPhone">Day time phone.</param>
        /// <param name="DeliveryDate">Date the customer is requesting delivery on. Typically used for perishable product delivery..</param>
        /// <param name="EveningPhone">Evening phone.</param>
        /// <param name="FirstName">First name.</param>
        /// <param name="LastName">Last name.</param>
        /// <param name="LiftGate">Lift gate requested (LTL shipping methods only).</param>
        /// <param name="PostalCode">Postal code.</param>
        /// <param name="ShipOnDate">Date the customer is requesting that the order ship on.  Typically used for perishable product delivery..</param>
        /// <param name="ShipToResidential">True if the shipping adress is residential.  Effects the methods that are available to the customer as well as the price of the shipping method..</param>
        /// <param name="Shipping3rdPartyAccountNumber">3rd party account number to ship against for UPS or FedEx.</param>
        /// <param name="ShippingMethod">Shipping method.</param>
        /// <param name="SpecialInstructions">Special instructions from the customer regarding shipping.</param>
        /// <param name="StateRegion">State/Region.</param>
        /// <param name="Title">Title.</param>
        public CartShipping(string Address1 = default(string), string Address2 = default(string), string City = default(string), string Company = default(string), string CountryCode = default(string), string DayPhone = default(string), string DeliveryDate = default(string), string EveningPhone = default(string), string FirstName = default(string), string LastName = default(string), bool? LiftGate = default(bool?), string PostalCode = default(string), string ShipOnDate = default(string), bool? ShipToResidential = default(bool?), string Shipping3rdPartyAccountNumber = default(string), string ShippingMethod = default(string), string SpecialInstructions = default(string), string StateRegion = default(string), string Title = default(string))
        {
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
            this.Company = Company;
            this.CountryCode = CountryCode;
            this.DayPhone = DayPhone;
            this.DeliveryDate = DeliveryDate;
            this.EveningPhone = EveningPhone;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.LiftGate = LiftGate;
            this.PostalCode = PostalCode;
            this.ShipOnDate = ShipOnDate;
            this.ShipToResidential = ShipToResidential;
            this.Shipping3rdPartyAccountNumber = Shipping3rdPartyAccountNumber;
            this.ShippingMethod = ShippingMethod;
            this.SpecialInstructions = SpecialInstructions;
            this.StateRegion = StateRegion;
            this.Title = Title;
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
        /// Day time phone
        /// </summary>
        /// <value>Day time phone</value>
        [DataMember(Name="day_phone", EmitDefaultValue=false)]
        public string DayPhone { get; set; }

        /// <summary>
        /// Date the customer is requesting delivery on. Typically used for perishable product delivery.
        /// </summary>
        /// <value>Date the customer is requesting delivery on. Typically used for perishable product delivery.</value>
        [DataMember(Name="delivery_date", EmitDefaultValue=false)]
        public string DeliveryDate { get; set; }

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
        /// Lift gate requested (LTL shipping methods only)
        /// </summary>
        /// <value>Lift gate requested (LTL shipping methods only)</value>
        [DataMember(Name="lift_gate", EmitDefaultValue=false)]
        public bool? LiftGate { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Date the customer is requesting that the order ship on.  Typically used for perishable product delivery.
        /// </summary>
        /// <value>Date the customer is requesting that the order ship on.  Typically used for perishable product delivery.</value>
        [DataMember(Name="ship_on_date", EmitDefaultValue=false)]
        public string ShipOnDate { get; set; }

        /// <summary>
        /// True if the shipping adress is residential.  Effects the methods that are available to the customer as well as the price of the shipping method.
        /// </summary>
        /// <value>True if the shipping adress is residential.  Effects the methods that are available to the customer as well as the price of the shipping method.</value>
        [DataMember(Name="ship_to_residential", EmitDefaultValue=false)]
        public bool? ShipToResidential { get; set; }

        /// <summary>
        /// 3rd party account number to ship against for UPS or FedEx
        /// </summary>
        /// <value>3rd party account number to ship against for UPS or FedEx</value>
        [DataMember(Name="shipping_3rd_party_account_number", EmitDefaultValue=false)]
        public string Shipping3rdPartyAccountNumber { get; set; }

        /// <summary>
        /// Shipping method
        /// </summary>
        /// <value>Shipping method</value>
        [DataMember(Name="shipping_method", EmitDefaultValue=false)]
        public string ShippingMethod { get; set; }

        /// <summary>
        /// Special instructions from the customer regarding shipping
        /// </summary>
        /// <value>Special instructions from the customer regarding shipping</value>
        [DataMember(Name="special_instructions", EmitDefaultValue=false)]
        public string SpecialInstructions { get; set; }

        /// <summary>
        /// State/Region
        /// </summary>
        /// <value>State/Region</value>
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
            sb.Append("class CartShipping {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DayPhone: ").Append(DayPhone).Append("\n");
            sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
            sb.Append("  EveningPhone: ").Append(EveningPhone).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  LiftGate: ").Append(LiftGate).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  ShipOnDate: ").Append(ShipOnDate).Append("\n");
            sb.Append("  ShipToResidential: ").Append(ShipToResidential).Append("\n");
            sb.Append("  Shipping3rdPartyAccountNumber: ").Append(Shipping3rdPartyAccountNumber).Append("\n");
            sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
            sb.Append("  SpecialInstructions: ").Append(SpecialInstructions).Append("\n");
            sb.Append("  StateRegion: ").Append(StateRegion).Append("\n");
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
            return this.Equals(input as CartShipping);
        }

        /// <summary>
        /// Returns true if CartShipping instances are equal
        /// </summary>
        /// <param name="input">Instance of CartShipping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartShipping input)
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
                    this.DeliveryDate == input.DeliveryDate ||
                    (this.DeliveryDate != null &&
                    this.DeliveryDate.Equals(input.DeliveryDate))
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
                    this.LiftGate == input.LiftGate ||
                    (this.LiftGate != null &&
                    this.LiftGate.Equals(input.LiftGate))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.ShipOnDate == input.ShipOnDate ||
                    (this.ShipOnDate != null &&
                    this.ShipOnDate.Equals(input.ShipOnDate))
                ) && 
                (
                    this.ShipToResidential == input.ShipToResidential ||
                    (this.ShipToResidential != null &&
                    this.ShipToResidential.Equals(input.ShipToResidential))
                ) && 
                (
                    this.Shipping3rdPartyAccountNumber == input.Shipping3rdPartyAccountNumber ||
                    (this.Shipping3rdPartyAccountNumber != null &&
                    this.Shipping3rdPartyAccountNumber.Equals(input.Shipping3rdPartyAccountNumber))
                ) && 
                (
                    this.ShippingMethod == input.ShippingMethod ||
                    (this.ShippingMethod != null &&
                    this.ShippingMethod.Equals(input.ShippingMethod))
                ) && 
                (
                    this.SpecialInstructions == input.SpecialInstructions ||
                    (this.SpecialInstructions != null &&
                    this.SpecialInstructions.Equals(input.SpecialInstructions))
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
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.DayPhone != null)
                    hashCode = hashCode * 59 + this.DayPhone.GetHashCode();
                if (this.DeliveryDate != null)
                    hashCode = hashCode * 59 + this.DeliveryDate.GetHashCode();
                if (this.EveningPhone != null)
                    hashCode = hashCode * 59 + this.EveningPhone.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.LiftGate != null)
                    hashCode = hashCode * 59 + this.LiftGate.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.ShipOnDate != null)
                    hashCode = hashCode * 59 + this.ShipOnDate.GetHashCode();
                if (this.ShipToResidential != null)
                    hashCode = hashCode * 59 + this.ShipToResidential.GetHashCode();
                if (this.Shipping3rdPartyAccountNumber != null)
                    hashCode = hashCode * 59 + this.Shipping3rdPartyAccountNumber.GetHashCode();
                if (this.ShippingMethod != null)
                    hashCode = hashCode * 59 + this.ShippingMethod.GetHashCode();
                if (this.SpecialInstructions != null)
                    hashCode = hashCode * 59 + this.SpecialInstructions.GetHashCode();
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
            if(this.PostalCode != null && this.PostalCode.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 25.", new [] { "PostalCode" });
            }

            // Shipping3rdPartyAccountNumber (string) maxLength
            if(this.Shipping3rdPartyAccountNumber != null && this.Shipping3rdPartyAccountNumber.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Shipping3rdPartyAccountNumber, length must be less than 20.", new [] { "Shipping3rdPartyAccountNumber" });
            }

            // ShippingMethod (string) maxLength
            if(this.ShippingMethod != null && this.ShippingMethod.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingMethod, length must be less than 40.", new [] { "ShippingMethod" });
            }

            // SpecialInstructions (string) maxLength
            if(this.SpecialInstructions != null && this.SpecialInstructions.Length > 10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SpecialInstructions, length must be less than 10000.", new [] { "SpecialInstructions" });
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
