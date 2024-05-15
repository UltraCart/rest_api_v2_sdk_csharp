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
    /// ConversationPbxVoicemailMailbox
    /// </summary>
    [DataContract]
    public partial class ConversationPbxVoicemailMailbox :  IEquatable<ConversationPbxVoicemailMailbox>, IValidatableObject
    {
        /// <summary>
        /// Voicemail mailbox type
        /// </summary>
        /// <value>Voicemail mailbox type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VoicemailMailboxTypeEnum
        {
            /// <summary>
            /// Enum Agent for value: agent
            /// </summary>
            [EnumMember(Value = "agent")]
            Agent = 1,

            /// <summary>
            /// Enum Shared for value: shared
            /// </summary>
            [EnumMember(Value = "shared")]
            Shared = 2

        }

        /// <summary>
        /// Voicemail mailbox type
        /// </summary>
        /// <value>Voicemail mailbox type</value>
        [DataMember(Name="voicemail_mailbox_type", EmitDefaultValue=false)]
        public VoicemailMailboxTypeEnum? VoicemailMailboxType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationPbxVoicemailMailbox" /> class.
        /// </summary>
        /// <param name="conversationPbxVoicemailMailboxUuid">Conversation Pbx Voicemail Mailbox UUID.</param>
        /// <param name="merchantId">Merchant Id.</param>
        /// <param name="sendNoticesToEmail">Send notices to email.</param>
        /// <param name="userId">User Id.</param>
        /// <param name="voicemailFollowupPlayAudioUuid">Voicemail follow play audio UUID.</param>
        /// <param name="voicemailFollowupSay">Voicemail followup say.</param>
        /// <param name="voicemailFollowupSayVoice">Voicemail followup say voice.</param>
        /// <param name="voicemailMailboxId">Voicemail mailbox id.</param>
        /// <param name="voicemailMailboxType">Voicemail mailbox type.</param>
        /// <param name="voicemailPromptPlayAudioUuid">Voicemail prompt play audio UUID.</param>
        /// <param name="voicemailPromptSay">Voicemail prompt say.</param>
        /// <param name="voicemailPromptSayVoice">Voicemail prompt say voice.</param>
        public ConversationPbxVoicemailMailbox(string conversationPbxVoicemailMailboxUuid = default(string), string merchantId = default(string), string sendNoticesToEmail = default(string), int userId = default(int), string voicemailFollowupPlayAudioUuid = default(string), string voicemailFollowupSay = default(string), string voicemailFollowupSayVoice = default(string), string voicemailMailboxId = default(string), VoicemailMailboxTypeEnum? voicemailMailboxType = default(VoicemailMailboxTypeEnum?), string voicemailPromptPlayAudioUuid = default(string), string voicemailPromptSay = default(string), string voicemailPromptSayVoice = default(string))
        {
            this.ConversationPbxVoicemailMailboxUuid = conversationPbxVoicemailMailboxUuid;
            this.MerchantId = merchantId;
            this.SendNoticesToEmail = sendNoticesToEmail;
            this.UserId = userId;
            this.VoicemailFollowupPlayAudioUuid = voicemailFollowupPlayAudioUuid;
            this.VoicemailFollowupSay = voicemailFollowupSay;
            this.VoicemailFollowupSayVoice = voicemailFollowupSayVoice;
            this.VoicemailMailboxId = voicemailMailboxId;
            this.VoicemailMailboxType = voicemailMailboxType;
            this.VoicemailPromptPlayAudioUuid = voicemailPromptPlayAudioUuid;
            this.VoicemailPromptSay = voicemailPromptSay;
            this.VoicemailPromptSayVoice = voicemailPromptSayVoice;
        }

        /// <summary>
        /// Conversation Pbx Voicemail Mailbox UUID
        /// </summary>
        /// <value>Conversation Pbx Voicemail Mailbox UUID</value>
        [DataMember(Name="conversation_pbx_voicemail_mailbox_uuid", EmitDefaultValue=false)]
        public string ConversationPbxVoicemailMailboxUuid { get; set; }

        /// <summary>
        /// Merchant Id
        /// </summary>
        /// <value>Merchant Id</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Send notices to email
        /// </summary>
        /// <value>Send notices to email</value>
        [DataMember(Name="send_notices_to_email", EmitDefaultValue=false)]
        public string SendNoticesToEmail { get; set; }

        /// <summary>
        /// User Id
        /// </summary>
        /// <value>User Id</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int UserId { get; set; }

        /// <summary>
        /// Voicemail follow play audio UUID
        /// </summary>
        /// <value>Voicemail follow play audio UUID</value>
        [DataMember(Name="voicemail_followup_play_audio_uuid", EmitDefaultValue=false)]
        public string VoicemailFollowupPlayAudioUuid { get; set; }

        /// <summary>
        /// Voicemail followup say
        /// </summary>
        /// <value>Voicemail followup say</value>
        [DataMember(Name="voicemail_followup_say", EmitDefaultValue=false)]
        public string VoicemailFollowupSay { get; set; }

        /// <summary>
        /// Voicemail followup say voice
        /// </summary>
        /// <value>Voicemail followup say voice</value>
        [DataMember(Name="voicemail_followup_say_voice", EmitDefaultValue=false)]
        public string VoicemailFollowupSayVoice { get; set; }

        /// <summary>
        /// Voicemail mailbox id
        /// </summary>
        /// <value>Voicemail mailbox id</value>
        [DataMember(Name="voicemail_mailbox_id", EmitDefaultValue=false)]
        public string VoicemailMailboxId { get; set; }


        /// <summary>
        /// Voicemail prompt play audio UUID
        /// </summary>
        /// <value>Voicemail prompt play audio UUID</value>
        [DataMember(Name="voicemail_prompt_play_audio_uuid", EmitDefaultValue=false)]
        public string VoicemailPromptPlayAudioUuid { get; set; }

        /// <summary>
        /// Voicemail prompt say
        /// </summary>
        /// <value>Voicemail prompt say</value>
        [DataMember(Name="voicemail_prompt_say", EmitDefaultValue=false)]
        public string VoicemailPromptSay { get; set; }

        /// <summary>
        /// Voicemail prompt say voice
        /// </summary>
        /// <value>Voicemail prompt say voice</value>
        [DataMember(Name="voicemail_prompt_say_voice", EmitDefaultValue=false)]
        public string VoicemailPromptSayVoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationPbxVoicemailMailbox {\n");
            sb.Append("  ConversationPbxVoicemailMailboxUuid: ").Append(ConversationPbxVoicemailMailboxUuid).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  SendNoticesToEmail: ").Append(SendNoticesToEmail).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  VoicemailFollowupPlayAudioUuid: ").Append(VoicemailFollowupPlayAudioUuid).Append("\n");
            sb.Append("  VoicemailFollowupSay: ").Append(VoicemailFollowupSay).Append("\n");
            sb.Append("  VoicemailFollowupSayVoice: ").Append(VoicemailFollowupSayVoice).Append("\n");
            sb.Append("  VoicemailMailboxId: ").Append(VoicemailMailboxId).Append("\n");
            sb.Append("  VoicemailMailboxType: ").Append(VoicemailMailboxType).Append("\n");
            sb.Append("  VoicemailPromptPlayAudioUuid: ").Append(VoicemailPromptPlayAudioUuid).Append("\n");
            sb.Append("  VoicemailPromptSay: ").Append(VoicemailPromptSay).Append("\n");
            sb.Append("  VoicemailPromptSayVoice: ").Append(VoicemailPromptSayVoice).Append("\n");
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
            return this.Equals(input as ConversationPbxVoicemailMailbox);
        }

        /// <summary>
        /// Returns true if ConversationPbxVoicemailMailbox instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationPbxVoicemailMailbox to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationPbxVoicemailMailbox input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConversationPbxVoicemailMailboxUuid == input.ConversationPbxVoicemailMailboxUuid ||
                    (this.ConversationPbxVoicemailMailboxUuid != null &&
                    this.ConversationPbxVoicemailMailboxUuid.Equals(input.ConversationPbxVoicemailMailboxUuid))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.SendNoticesToEmail == input.SendNoticesToEmail ||
                    (this.SendNoticesToEmail != null &&
                    this.SendNoticesToEmail.Equals(input.SendNoticesToEmail))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.VoicemailFollowupPlayAudioUuid == input.VoicemailFollowupPlayAudioUuid ||
                    (this.VoicemailFollowupPlayAudioUuid != null &&
                    this.VoicemailFollowupPlayAudioUuid.Equals(input.VoicemailFollowupPlayAudioUuid))
                ) && 
                (
                    this.VoicemailFollowupSay == input.VoicemailFollowupSay ||
                    (this.VoicemailFollowupSay != null &&
                    this.VoicemailFollowupSay.Equals(input.VoicemailFollowupSay))
                ) && 
                (
                    this.VoicemailFollowupSayVoice == input.VoicemailFollowupSayVoice ||
                    (this.VoicemailFollowupSayVoice != null &&
                    this.VoicemailFollowupSayVoice.Equals(input.VoicemailFollowupSayVoice))
                ) && 
                (
                    this.VoicemailMailboxId == input.VoicemailMailboxId ||
                    (this.VoicemailMailboxId != null &&
                    this.VoicemailMailboxId.Equals(input.VoicemailMailboxId))
                ) && 
                (
                    this.VoicemailMailboxType == input.VoicemailMailboxType ||
                    (this.VoicemailMailboxType != null &&
                    this.VoicemailMailboxType.Equals(input.VoicemailMailboxType))
                ) && 
                (
                    this.VoicemailPromptPlayAudioUuid == input.VoicemailPromptPlayAudioUuid ||
                    (this.VoicemailPromptPlayAudioUuid != null &&
                    this.VoicemailPromptPlayAudioUuid.Equals(input.VoicemailPromptPlayAudioUuid))
                ) && 
                (
                    this.VoicemailPromptSay == input.VoicemailPromptSay ||
                    (this.VoicemailPromptSay != null &&
                    this.VoicemailPromptSay.Equals(input.VoicemailPromptSay))
                ) && 
                (
                    this.VoicemailPromptSayVoice == input.VoicemailPromptSayVoice ||
                    (this.VoicemailPromptSayVoice != null &&
                    this.VoicemailPromptSayVoice.Equals(input.VoicemailPromptSayVoice))
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
                if (this.ConversationPbxVoicemailMailboxUuid != null)
                    hashCode = hashCode * 59 + this.ConversationPbxVoicemailMailboxUuid.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.SendNoticesToEmail != null)
                    hashCode = hashCode * 59 + this.SendNoticesToEmail.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.VoicemailFollowupPlayAudioUuid != null)
                    hashCode = hashCode * 59 + this.VoicemailFollowupPlayAudioUuid.GetHashCode();
                if (this.VoicemailFollowupSay != null)
                    hashCode = hashCode * 59 + this.VoicemailFollowupSay.GetHashCode();
                if (this.VoicemailFollowupSayVoice != null)
                    hashCode = hashCode * 59 + this.VoicemailFollowupSayVoice.GetHashCode();
                if (this.VoicemailMailboxId != null)
                    hashCode = hashCode * 59 + this.VoicemailMailboxId.GetHashCode();
                if (this.VoicemailMailboxType != null)
                    hashCode = hashCode * 59 + this.VoicemailMailboxType.GetHashCode();
                if (this.VoicemailPromptPlayAudioUuid != null)
                    hashCode = hashCode * 59 + this.VoicemailPromptPlayAudioUuid.GetHashCode();
                if (this.VoicemailPromptSay != null)
                    hashCode = hashCode * 59 + this.VoicemailPromptSay.GetHashCode();
                if (this.VoicemailPromptSayVoice != null)
                    hashCode = hashCode * 59 + this.VoicemailPromptSayVoice.GetHashCode();
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
            // ConversationPbxVoicemailMailboxUuid (string) maxLength
            if(this.ConversationPbxVoicemailMailboxUuid != null && this.ConversationPbxVoicemailMailboxUuid.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConversationPbxVoicemailMailboxUuid, length must be less than 50.", new [] { "ConversationPbxVoicemailMailboxUuid" });
            }


            // MerchantId (string) maxLength
            if(this.MerchantId != null && this.MerchantId.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantId, length must be less than 5.", new [] { "MerchantId" });
            }


            // SendNoticesToEmail (string) maxLength
            if(this.SendNoticesToEmail != null && this.SendNoticesToEmail.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SendNoticesToEmail, length must be less than 250.", new [] { "SendNoticesToEmail" });
            }


            // VoicemailFollowupPlayAudioUuid (string) maxLength
            if(this.VoicemailFollowupPlayAudioUuid != null && this.VoicemailFollowupPlayAudioUuid.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VoicemailFollowupPlayAudioUuid, length must be less than 50.", new [] { "VoicemailFollowupPlayAudioUuid" });
            }


            // VoicemailFollowupSayVoice (string) maxLength
            if(this.VoicemailFollowupSayVoice != null && this.VoicemailFollowupSayVoice.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VoicemailFollowupSayVoice, length must be less than 50.", new [] { "VoicemailFollowupSayVoice" });
            }


            // VoicemailMailboxId (string) maxLength
            if(this.VoicemailMailboxId != null && this.VoicemailMailboxId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VoicemailMailboxId, length must be less than 50.", new [] { "VoicemailMailboxId" });
            }


            // VoicemailMailboxType (string) maxLength
            if(this.VoicemailMailboxType != null && this.VoicemailMailboxType.ToString().Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VoicemailMailboxType, length must be less than 50.", new [] { "VoicemailMailboxType" });
            }


            // VoicemailPromptPlayAudioUuid (string) maxLength
            if(this.VoicemailPromptPlayAudioUuid != null && this.VoicemailPromptPlayAudioUuid.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VoicemailPromptPlayAudioUuid, length must be less than 50.", new [] { "VoicemailPromptPlayAudioUuid" });
            }


            // VoicemailPromptSayVoice (string) maxLength
            if(this.VoicemailPromptSayVoice != null && this.VoicemailPromptSayVoice.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VoicemailPromptSayVoice, length must be less than 50.", new [] { "VoicemailPromptSayVoice" });
            }


            yield break;
        }
    }

}
