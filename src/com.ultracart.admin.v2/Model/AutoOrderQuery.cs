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
    /// AutoOrderQuery
    /// </summary>
    [DataContract]
    public partial class AutoOrderQuery :  IEquatable<AutoOrderQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoOrderQuery" /> class.
        /// </summary>
        /// <param name="autoOrderCode">Auto order code.</param>
        /// <param name="cardType">Card type.</param>
        /// <param name="city">City.</param>
        /// <param name="company">Company.</param>
        /// <param name="countryCode">ISO-3166 two letter country code.</param>
        /// <param name="customerProfileOid">Customer profile object identifier.</param>
        /// <param name="email">Email.</param>
        /// <param name="firstName">First name.</param>
        /// <param name="itemId">Item ID.  Deprecated query field.  This incorrectly meant the original order contained this item id..</param>
        /// <param name="lastName">Last name.</param>
        /// <param name="nextItemId">Next Item ID that is supposed to ship.  This is calculated based upon the schedule associated with the original item id..</param>
        /// <param name="nextShipmentDateBegin">Next shipment date begin.</param>
        /// <param name="nextShipmentDateEnd">Next shipment date end.</param>
        /// <param name="originalItemId">Original Item ID purchased on auto order..</param>
        /// <param name="originalOrderDateBegin">Original order date begin.</param>
        /// <param name="originalOrderDateEnd">Original order date end.</param>
        /// <param name="originalOrderId">Original order ID.</param>
        /// <param name="phone">Phone.</param>
        /// <param name="postalCode">Postal code.</param>
        /// <param name="state">State.</param>
        /// <param name="status">Status.</param>
        public AutoOrderQuery(string autoOrderCode = default(string), string cardType = default(string), string city = default(string), string company = default(string), string countryCode = default(string), int customerProfileOid = default(int), string email = default(string), string firstName = default(string), string itemId = default(string), string lastName = default(string), string nextItemId = default(string), string nextShipmentDateBegin = default(string), string nextShipmentDateEnd = default(string), string originalItemId = default(string), string originalOrderDateBegin = default(string), string originalOrderDateEnd = default(string), string originalOrderId = default(string), string phone = default(string), string postalCode = default(string), string state = default(string), string status = default(string))
        {
            this.AutoOrderCode = autoOrderCode;
            this.CardType = cardType;
            this.City = city;
            this.Company = company;
            this.CountryCode = countryCode;
            this.CustomerProfileOid = customerProfileOid;
            this.Email = email;
            this.FirstName = firstName;
            this.ItemId = itemId;
            this.LastName = lastName;
            this.NextItemId = nextItemId;
            this.NextShipmentDateBegin = nextShipmentDateBegin;
            this.NextShipmentDateEnd = nextShipmentDateEnd;
            this.OriginalItemId = originalItemId;
            this.OriginalOrderDateBegin = originalOrderDateBegin;
            this.OriginalOrderDateEnd = originalOrderDateEnd;
            this.OriginalOrderId = originalOrderId;
            this.Phone = phone;
            this.PostalCode = postalCode;
            this.State = state;
            this.Status = status;
        }

        /// <summary>
        /// Auto order code
        /// </summary>
        /// <value>Auto order code</value>
        [DataMember(Name="auto_order_code", EmitDefaultValue=false)]
        public string AutoOrderCode { get; set; }

        /// <summary>
        /// Card type
        /// </summary>
        /// <value>Card type</value>
        [DataMember(Name="card_type", EmitDefaultValue=false)]
        public string CardType { get; set; }

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
        /// Customer profile object identifier
        /// </summary>
        /// <value>Customer profile object identifier</value>
        [DataMember(Name="customer_profile_oid", EmitDefaultValue=false)]
        public int CustomerProfileOid { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        /// <value>First name</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Item ID.  Deprecated query field.  This incorrectly meant the original order contained this item id.
        /// </summary>
        /// <value>Item ID.  Deprecated query field.  This incorrectly meant the original order contained this item id.</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        /// <value>Last name</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Next Item ID that is supposed to ship.  This is calculated based upon the schedule associated with the original item id.
        /// </summary>
        /// <value>Next Item ID that is supposed to ship.  This is calculated based upon the schedule associated with the original item id.</value>
        [DataMember(Name="next_item_id", EmitDefaultValue=false)]
        public string NextItemId { get; set; }

        /// <summary>
        /// Next shipment date begin
        /// </summary>
        /// <value>Next shipment date begin</value>
        [DataMember(Name="next_shipment_date_begin", EmitDefaultValue=false)]
        public string NextShipmentDateBegin { get; set; }

        /// <summary>
        /// Next shipment date end
        /// </summary>
        /// <value>Next shipment date end</value>
        [DataMember(Name="next_shipment_date_end", EmitDefaultValue=false)]
        public string NextShipmentDateEnd { get; set; }

        /// <summary>
        /// Original Item ID purchased on auto order.
        /// </summary>
        /// <value>Original Item ID purchased on auto order.</value>
        [DataMember(Name="original_item_id", EmitDefaultValue=false)]
        public string OriginalItemId { get; set; }

        /// <summary>
        /// Original order date begin
        /// </summary>
        /// <value>Original order date begin</value>
        [DataMember(Name="original_order_date_begin", EmitDefaultValue=false)]
        public string OriginalOrderDateBegin { get; set; }

        /// <summary>
        /// Original order date end
        /// </summary>
        /// <value>Original order date end</value>
        [DataMember(Name="original_order_date_end", EmitDefaultValue=false)]
        public string OriginalOrderDateEnd { get; set; }

        /// <summary>
        /// Original order ID
        /// </summary>
        /// <value>Original order ID</value>
        [DataMember(Name="original_order_id", EmitDefaultValue=false)]
        public string OriginalOrderId { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        /// <value>Phone</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoOrderQuery {\n");
            sb.Append("  AutoOrderCode: ").Append(AutoOrderCode).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CustomerProfileOid: ").Append(CustomerProfileOid).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  NextItemId: ").Append(NextItemId).Append("\n");
            sb.Append("  NextShipmentDateBegin: ").Append(NextShipmentDateBegin).Append("\n");
            sb.Append("  NextShipmentDateEnd: ").Append(NextShipmentDateEnd).Append("\n");
            sb.Append("  OriginalItemId: ").Append(OriginalItemId).Append("\n");
            sb.Append("  OriginalOrderDateBegin: ").Append(OriginalOrderDateBegin).Append("\n");
            sb.Append("  OriginalOrderDateEnd: ").Append(OriginalOrderDateEnd).Append("\n");
            sb.Append("  OriginalOrderId: ").Append(OriginalOrderId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AutoOrderQuery);
        }

        /// <summary>
        /// Returns true if AutoOrderQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoOrderQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoOrderQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoOrderCode == input.AutoOrderCode ||
                    (this.AutoOrderCode != null &&
                    this.AutoOrderCode.Equals(input.AutoOrderCode))
                ) && 
                (
                    this.CardType == input.CardType ||
                    (this.CardType != null &&
                    this.CardType.Equals(input.CardType))
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
                    this.CustomerProfileOid == input.CustomerProfileOid ||
                    (this.CustomerProfileOid != null &&
                    this.CustomerProfileOid.Equals(input.CustomerProfileOid))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.NextItemId == input.NextItemId ||
                    (this.NextItemId != null &&
                    this.NextItemId.Equals(input.NextItemId))
                ) && 
                (
                    this.NextShipmentDateBegin == input.NextShipmentDateBegin ||
                    (this.NextShipmentDateBegin != null &&
                    this.NextShipmentDateBegin.Equals(input.NextShipmentDateBegin))
                ) && 
                (
                    this.NextShipmentDateEnd == input.NextShipmentDateEnd ||
                    (this.NextShipmentDateEnd != null &&
                    this.NextShipmentDateEnd.Equals(input.NextShipmentDateEnd))
                ) && 
                (
                    this.OriginalItemId == input.OriginalItemId ||
                    (this.OriginalItemId != null &&
                    this.OriginalItemId.Equals(input.OriginalItemId))
                ) && 
                (
                    this.OriginalOrderDateBegin == input.OriginalOrderDateBegin ||
                    (this.OriginalOrderDateBegin != null &&
                    this.OriginalOrderDateBegin.Equals(input.OriginalOrderDateBegin))
                ) && 
                (
                    this.OriginalOrderDateEnd == input.OriginalOrderDateEnd ||
                    (this.OriginalOrderDateEnd != null &&
                    this.OriginalOrderDateEnd.Equals(input.OriginalOrderDateEnd))
                ) && 
                (
                    this.OriginalOrderId == input.OriginalOrderId ||
                    (this.OriginalOrderId != null &&
                    this.OriginalOrderId.Equals(input.OriginalOrderId))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AutoOrderCode != null)
                    hashCode = hashCode * 59 + this.AutoOrderCode.GetHashCode();
                if (this.CardType != null)
                    hashCode = hashCode * 59 + this.CardType.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CustomerProfileOid != null)
                    hashCode = hashCode * 59 + this.CustomerProfileOid.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.NextItemId != null)
                    hashCode = hashCode * 59 + this.NextItemId.GetHashCode();
                if (this.NextShipmentDateBegin != null)
                    hashCode = hashCode * 59 + this.NextShipmentDateBegin.GetHashCode();
                if (this.NextShipmentDateEnd != null)
                    hashCode = hashCode * 59 + this.NextShipmentDateEnd.GetHashCode();
                if (this.OriginalItemId != null)
                    hashCode = hashCode * 59 + this.OriginalItemId.GetHashCode();
                if (this.OriginalOrderDateBegin != null)
                    hashCode = hashCode * 59 + this.OriginalOrderDateBegin.GetHashCode();
                if (this.OriginalOrderDateEnd != null)
                    hashCode = hashCode * 59 + this.OriginalOrderDateEnd.GetHashCode();
                if (this.OriginalOrderId != null)
                    hashCode = hashCode * 59 + this.OriginalOrderId.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
            // CardType (string) maxLength
            if(this.CardType != null && this.CardType.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardType, length must be less than 100.", new [] { "CardType" });
            }


            // CountryCode (string) maxLength
            if(this.CountryCode != null && this.CountryCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 2.", new [] { "CountryCode" });
            }


            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 100.", new [] { "Email" });
            }


            // Phone (string) maxLength
            if(this.Phone != null && this.Phone.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Phone, length must be less than 25.", new [] { "Phone" });
            }


            yield break;
        }
    }

}
