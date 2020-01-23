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
    /// CustomerEmail
    /// </summary>
    [DataContract]
    public partial class CustomerEmail :  IEquatable<CustomerEmail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerEmail" /> class.
        /// </summary>
        /// <param name="CustomerProfileEmailOid">ID of the email.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Label">Label.</param>
        /// <param name="ReceiptNotification">CC this email on receipt notifications.</param>
        /// <param name="RefundNotification">CC this email on refund notifications.</param>
        /// <param name="ShipmentNotification">CC this email on shipment notifications.</param>
        public CustomerEmail(int? CustomerProfileEmailOid = default(int?), string Email = default(string), string Label = default(string), bool? ReceiptNotification = default(bool?), bool? RefundNotification = default(bool?), bool? ShipmentNotification = default(bool?))
        {
            this.CustomerProfileEmailOid = CustomerProfileEmailOid;
            this.Email = Email;
            this.Label = Label;
            this.ReceiptNotification = ReceiptNotification;
            this.RefundNotification = RefundNotification;
            this.ShipmentNotification = ShipmentNotification;
        }
        
        /// <summary>
        /// ID of the email
        /// </summary>
        /// <value>ID of the email</value>
        [DataMember(Name="customer_profile_email_oid", EmitDefaultValue=false)]
        public int? CustomerProfileEmailOid { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// CC this email on receipt notifications
        /// </summary>
        /// <value>CC this email on receipt notifications</value>
        [DataMember(Name="receipt_notification", EmitDefaultValue=false)]
        public bool? ReceiptNotification { get; set; }

        /// <summary>
        /// CC this email on refund notifications
        /// </summary>
        /// <value>CC this email on refund notifications</value>
        [DataMember(Name="refund_notification", EmitDefaultValue=false)]
        public bool? RefundNotification { get; set; }

        /// <summary>
        /// CC this email on shipment notifications
        /// </summary>
        /// <value>CC this email on shipment notifications</value>
        [DataMember(Name="shipment_notification", EmitDefaultValue=false)]
        public bool? ShipmentNotification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerEmail {\n");
            sb.Append("  CustomerProfileEmailOid: ").Append(CustomerProfileEmailOid).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  ReceiptNotification: ").Append(ReceiptNotification).Append("\n");
            sb.Append("  RefundNotification: ").Append(RefundNotification).Append("\n");
            sb.Append("  ShipmentNotification: ").Append(ShipmentNotification).Append("\n");
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
            return this.Equals(input as CustomerEmail);
        }

        /// <summary>
        /// Returns true if CustomerEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerEmail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerProfileEmailOid == input.CustomerProfileEmailOid ||
                    (this.CustomerProfileEmailOid != null &&
                    this.CustomerProfileEmailOid.Equals(input.CustomerProfileEmailOid))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.ReceiptNotification == input.ReceiptNotification ||
                    (this.ReceiptNotification != null &&
                    this.ReceiptNotification.Equals(input.ReceiptNotification))
                ) && 
                (
                    this.RefundNotification == input.RefundNotification ||
                    (this.RefundNotification != null &&
                    this.RefundNotification.Equals(input.RefundNotification))
                ) && 
                (
                    this.ShipmentNotification == input.ShipmentNotification ||
                    (this.ShipmentNotification != null &&
                    this.ShipmentNotification.Equals(input.ShipmentNotification))
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
                if (this.CustomerProfileEmailOid != null)
                    hashCode = hashCode * 59 + this.CustomerProfileEmailOid.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.ReceiptNotification != null)
                    hashCode = hashCode * 59 + this.ReceiptNotification.GetHashCode();
                if (this.RefundNotification != null)
                    hashCode = hashCode * 59 + this.RefundNotification.GetHashCode();
                if (this.ShipmentNotification != null)
                    hashCode = hashCode * 59 + this.ShipmentNotification.GetHashCode();
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
            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 100.", new [] { "Email" });
            }

            // Label (string) maxLength
            if(this.Label != null && this.Label.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Label, length must be less than 100.", new [] { "Label" });
            }

            yield break;
        }
    }

}
