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
    /// ConversationPbxPhoneNumber
    /// </summary>
    [DataContract]
    public partial class ConversationPbxPhoneNumber :  IEquatable<ConversationPbxPhoneNumber>, IValidatableObject
    {
        /// <summary>
        /// Action
        /// </summary>
        /// <value>Action</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum Timebased for value: time based
            /// </summary>
            [EnumMember(Value = "time based")]
            Timebased = 1,

            /// <summary>
            /// Enum Menu for value: menu
            /// </summary>
            [EnumMember(Value = "menu")]
            Menu = 2,

            /// <summary>
            /// Enum Queue for value: queue
            /// </summary>
            [EnumMember(Value = "queue")]
            Queue = 3,

            /// <summary>
            /// Enum Voicemail for value: voicemail
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail = 4,

            /// <summary>
            /// Enum Agent for value: agent
            /// </summary>
            [EnumMember(Value = "agent")]
            Agent = 5

        }

        /// <summary>
        /// Action
        /// </summary>
        /// <value>Action</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationPbxPhoneNumber" /> class.
        /// </summary>
        /// <param name="action">Action.</param>
        /// <param name="actionTarget">Action target.  This is the UUID associated with the configuration object of that particular type..</param>
        /// <param name="conversationPbxPhoneNumberUuid">Conversation Pbx Phone Number UUID.</param>
        /// <param name="merchantId">Merchant Id.</param>
        /// <param name="phoneNumber">Phone number.</param>
        public ConversationPbxPhoneNumber(ActionEnum? action = default(ActionEnum?), string actionTarget = default(string), string conversationPbxPhoneNumberUuid = default(string), string merchantId = default(string), string phoneNumber = default(string))
        {
            this.Action = action;
            this.ActionTarget = actionTarget;
            this.ConversationPbxPhoneNumberUuid = conversationPbxPhoneNumberUuid;
            this.MerchantId = merchantId;
            this.PhoneNumber = phoneNumber;
        }


        /// <summary>
        /// Action target.  This is the UUID associated with the configuration object of that particular type.
        /// </summary>
        /// <value>Action target.  This is the UUID associated with the configuration object of that particular type.</value>
        [DataMember(Name="action_target", EmitDefaultValue=false)]
        public string ActionTarget { get; set; }

        /// <summary>
        /// Conversation Pbx Phone Number UUID
        /// </summary>
        /// <value>Conversation Pbx Phone Number UUID</value>
        [DataMember(Name="conversation_pbx_phone_number_uuid", EmitDefaultValue=false)]
        public string ConversationPbxPhoneNumberUuid { get; set; }

        /// <summary>
        /// Merchant Id
        /// </summary>
        /// <value>Merchant Id</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        /// <value>Phone number</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationPbxPhoneNumber {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionTarget: ").Append(ActionTarget).Append("\n");
            sb.Append("  ConversationPbxPhoneNumberUuid: ").Append(ConversationPbxPhoneNumberUuid).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as ConversationPbxPhoneNumber);
        }

        /// <summary>
        /// Returns true if ConversationPbxPhoneNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationPbxPhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationPbxPhoneNumber input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.ActionTarget == input.ActionTarget ||
                    (this.ActionTarget != null &&
                    this.ActionTarget.Equals(input.ActionTarget))
                ) && 
                (
                    this.ConversationPbxPhoneNumberUuid == input.ConversationPbxPhoneNumberUuid ||
                    (this.ConversationPbxPhoneNumberUuid != null &&
                    this.ConversationPbxPhoneNumberUuid.Equals(input.ConversationPbxPhoneNumberUuid))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ActionTarget != null)
                    hashCode = hashCode * 59 + this.ActionTarget.GetHashCode();
                if (this.ConversationPbxPhoneNumberUuid != null)
                    hashCode = hashCode * 59 + this.ConversationPbxPhoneNumberUuid.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
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
            // Action (string) maxLength
            if(this.Action != null && this.Action.ToString().Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Action, length must be less than 30.", new [] { "Action" });
            }


            // ActionTarget (string) maxLength
            if(this.ActionTarget != null && this.ActionTarget.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ActionTarget, length must be less than 50.", new [] { "ActionTarget" });
            }


            // ConversationPbxPhoneNumberUuid (string) maxLength
            if(this.ConversationPbxPhoneNumberUuid != null && this.ConversationPbxPhoneNumberUuid.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConversationPbxPhoneNumberUuid, length must be less than 50.", new [] { "ConversationPbxPhoneNumberUuid" });
            }


            // MerchantId (string) maxLength
            if(this.MerchantId != null && this.MerchantId.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantId, length must be less than 5.", new [] { "MerchantId" });
            }


            // PhoneNumber (string) maxLength
            if(this.PhoneNumber != null && this.PhoneNumber.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumber, length must be less than 50.", new [] { "PhoneNumber" });
            }


            yield break;
        }
    }

}
