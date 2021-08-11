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
    /// EmailCommseqWebhookSendTestRequest
    /// </summary>
    [DataContract]
    public partial class EmailCommseqWebhookSendTestRequest :  IEquatable<EmailCommseqWebhookSendTestRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCommseqWebhookSendTestRequest" /> class.
        /// </summary>
        /// <param name="cartId">cartId.</param>
        /// <param name="cartItemIds">cartItemIds.</param>
        /// <param name="email">email.</param>
        /// <param name="espCommseqStepUuid">espCommseqStepUuid.</param>
        /// <param name="espCommseqUuid">espCommseqUuid.</param>
        /// <param name="name">name.</param>
        /// <param name="orderId">orderId.</param>
        public EmailCommseqWebhookSendTestRequest(string cartId = default(string), List<string> cartItemIds = default(List<string>), string email = default(string), string espCommseqStepUuid = default(string), string espCommseqUuid = default(string), string name = default(string), string orderId = default(string))
        {
            this.CartId = cartId;
            this.CartItemIds = cartItemIds;
            this.Email = email;
            this.EspCommseqStepUuid = espCommseqStepUuid;
            this.EspCommseqUuid = espCommseqUuid;
            this.Name = name;
            this.OrderId = orderId;
        }
        
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
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailCommseqWebhookSendTestRequest {\n");
            sb.Append("  CartId: ").Append(CartId).Append("\n");
            sb.Append("  CartItemIds: ").Append(CartItemIds).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EspCommseqStepUuid: ").Append(EspCommseqStepUuid).Append("\n");
            sb.Append("  EspCommseqUuid: ").Append(EspCommseqUuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
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
            return this.Equals(input as EmailCommseqWebhookSendTestRequest);
        }

        /// <summary>
        /// Returns true if EmailCommseqWebhookSendTestRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailCommseqWebhookSendTestRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailCommseqWebhookSendTestRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CartId == input.CartId ||
                    (this.CartId != null &&
                    this.CartId.Equals(input.CartId))
                ) && 
                (
                    this.CartItemIds == input.CartItemIds ||
                    this.CartItemIds != null &&
                    this.CartItemIds.SequenceEqual(input.CartItemIds)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
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
                if (this.CartId != null)
                    hashCode = hashCode * 59 + this.CartId.GetHashCode();
                if (this.CartItemIds != null)
                    hashCode = hashCode * 59 + this.CartItemIds.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.EspCommseqStepUuid != null)
                    hashCode = hashCode * 59 + this.EspCommseqStepUuid.GetHashCode();
                if (this.EspCommseqUuid != null)
                    hashCode = hashCode * 59 + this.EspCommseqUuid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
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
