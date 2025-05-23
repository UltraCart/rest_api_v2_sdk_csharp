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
    /// EmailCommseqPostcardSendTestRequest
    /// </summary>
    [DataContract]
    public partial class EmailCommseqPostcardSendTestRequest :  IEquatable<EmailCommseqPostcardSendTestRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCommseqPostcardSendTestRequest" /> class.
        /// </summary>
        /// <param name="address1">address1.</param>
        /// <param name="address2">address2.</param>
        /// <param name="cartId">cartId.</param>
        /// <param name="cartItemIds">cartItemIds.</param>
        /// <param name="city">city.</param>
        /// <param name="espCommseqPostcardUuid">espCommseqPostcardUuid.</param>
        /// <param name="espCommseqStepUuid">espCommseqStepUuid.</param>
        /// <param name="espCommseqUuid">espCommseqUuid.</param>
        /// <param name="mailCard">mailCard.</param>
        /// <param name="name">name.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="state">state.</param>
        public EmailCommseqPostcardSendTestRequest(string address1 = default(string), string address2 = default(string), string cartId = default(string), List<string> cartItemIds = default(List<string>), string city = default(string), string espCommseqPostcardUuid = default(string), string espCommseqStepUuid = default(string), string espCommseqUuid = default(string), bool mailCard = default(bool), string name = default(string), string orderId = default(string), string postalCode = default(string), string state = default(string))
        {
            this.Address1 = address1;
            this.Address2 = address2;
            this.CartId = cartId;
            this.CartItemIds = cartItemIds;
            this.City = city;
            this.EspCommseqPostcardUuid = espCommseqPostcardUuid;
            this.EspCommseqStepUuid = espCommseqStepUuid;
            this.EspCommseqUuid = espCommseqUuid;
            this.MailCard = mailCard;
            this.Name = name;
            this.OrderId = orderId;
            this.PostalCode = postalCode;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="address_1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="address_2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets CartId
        /// </summary>
        [DataMember(Name="cart_id", EmitDefaultValue=false)]
        public string CartId { get; set; }

        /// <summary>
        /// Gets or Sets CartItemIds
        /// </summary>
        [DataMember(Name="cart_item_ids", EmitDefaultValue=false)]
        public List<string> CartItemIds { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets EspCommseqPostcardUuid
        /// </summary>
        [DataMember(Name="esp_commseq_postcard_uuid", EmitDefaultValue=false)]
        public string EspCommseqPostcardUuid { get; set; }

        /// <summary>
        /// Gets or Sets EspCommseqStepUuid
        /// </summary>
        [DataMember(Name="esp_commseq_step_uuid", EmitDefaultValue=false)]
        public string EspCommseqStepUuid { get; set; }

        /// <summary>
        /// Gets or Sets EspCommseqUuid
        /// </summary>
        [DataMember(Name="esp_commseq_uuid", EmitDefaultValue=false)]
        public string EspCommseqUuid { get; set; }

        /// <summary>
        /// Gets or Sets MailCard
        /// </summary>
        [DataMember(Name="mail_card", EmitDefaultValue=false)]
        public bool MailCard { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailCommseqPostcardSendTestRequest {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  CartId: ").Append(CartId).Append("\n");
            sb.Append("  CartItemIds: ").Append(CartItemIds).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  EspCommseqPostcardUuid: ").Append(EspCommseqPostcardUuid).Append("\n");
            sb.Append("  EspCommseqStepUuid: ").Append(EspCommseqStepUuid).Append("\n");
            sb.Append("  EspCommseqUuid: ").Append(EspCommseqUuid).Append("\n");
            sb.Append("  MailCard: ").Append(MailCard).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as EmailCommseqPostcardSendTestRequest);
        }

        /// <summary>
        /// Returns true if EmailCommseqPostcardSendTestRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailCommseqPostcardSendTestRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailCommseqPostcardSendTestRequest input)
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
                    this.CartId == input.CartId ||
                    (this.CartId != null &&
                    this.CartId.Equals(input.CartId))
                ) && 
                (
                    this.CartItemIds == input.CartItemIds ||
                    this.CartItemIds != null &&
                    input.CartItemIds != null &&
                    this.CartItemIds.SequenceEqual(input.CartItemIds)
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.EspCommseqPostcardUuid == input.EspCommseqPostcardUuid ||
                    (this.EspCommseqPostcardUuid != null &&
                    this.EspCommseqPostcardUuid.Equals(input.EspCommseqPostcardUuid))
                ) && 
                (
                    this.EspCommseqStepUuid == input.EspCommseqStepUuid ||
                    (this.EspCommseqStepUuid != null &&
                    this.EspCommseqStepUuid.Equals(input.EspCommseqStepUuid))
                ) && 
                (
                    this.EspCommseqUuid == input.EspCommseqUuid ||
                    (this.EspCommseqUuid != null &&
                    this.EspCommseqUuid.Equals(input.EspCommseqUuid))
                ) && 
                (
                    this.MailCard == input.MailCard ||
                    (this.MailCard != null &&
                    this.MailCard.Equals(input.MailCard))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
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
                if (this.CartId != null)
                    hashCode = hashCode * 59 + this.CartId.GetHashCode();
                if (this.CartItemIds != null)
                    hashCode = hashCode * 59 + this.CartItemIds.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.EspCommseqPostcardUuid != null)
                    hashCode = hashCode * 59 + this.EspCommseqPostcardUuid.GetHashCode();
                if (this.EspCommseqStepUuid != null)
                    hashCode = hashCode * 59 + this.EspCommseqStepUuid.GetHashCode();
                if (this.EspCommseqUuid != null)
                    hashCode = hashCode * 59 + this.EspCommseqUuid.GetHashCode();
                if (this.MailCard != null)
                    hashCode = hashCode * 59 + this.MailCard.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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
