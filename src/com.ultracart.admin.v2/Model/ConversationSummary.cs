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
    /// ConversationSummary
    /// </summary>
    [DataContract]
    public partial class ConversationSummary :  IEquatable<ConversationSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummary" /> class.
        /// </summary>
        /// <param name="conversationArn">conversationArn.</param>
        /// <param name="conversationUuid">conversationUuid.</param>
        /// <param name="lastConversationMessageBody">lastConversationMessageBody.</param>
        /// <param name="lastConversationParticipantArn">lastConversationParticipantArn.</param>
        /// <param name="lastConversationParticipantName">lastConversationParticipantName.</param>
        /// <param name="lastMessageDts">Last message date/time.</param>
        /// <param name="merchantId">merchantId.</param>
        /// <param name="messageCount">messageCount.</param>
        /// <param name="unreadMessages">unreadMessages.</param>
        public ConversationSummary(string conversationArn = default(string), string conversationUuid = default(string), string lastConversationMessageBody = default(string), string lastConversationParticipantArn = default(string), string lastConversationParticipantName = default(string), string lastMessageDts = default(string), string merchantId = default(string), int? messageCount = default(int?), bool? unreadMessages = default(bool?))
        {
            this.ConversationArn = conversationArn;
            this.ConversationUuid = conversationUuid;
            this.LastConversationMessageBody = lastConversationMessageBody;
            this.LastConversationParticipantArn = lastConversationParticipantArn;
            this.LastConversationParticipantName = lastConversationParticipantName;
            this.LastMessageDts = lastMessageDts;
            this.MerchantId = merchantId;
            this.MessageCount = messageCount;
            this.UnreadMessages = unreadMessages;
        }
        
        /// <summary>
        /// Gets or Sets ConversationArn
        /// </summary>
        [DataMember(Name="conversation_arn", EmitDefaultValue=false)]
        public string ConversationArn { get; set; }

        /// <summary>
        /// Gets or Sets ConversationUuid
        /// </summary>
        [DataMember(Name="conversation_uuid", EmitDefaultValue=false)]
        public string ConversationUuid { get; set; }

        /// <summary>
        /// Gets or Sets LastConversationMessageBody
        /// </summary>
        [DataMember(Name="last_conversation_message_body", EmitDefaultValue=false)]
        public string LastConversationMessageBody { get; set; }

        /// <summary>
        /// Gets or Sets LastConversationParticipantArn
        /// </summary>
        [DataMember(Name="last_conversation_participant_arn", EmitDefaultValue=false)]
        public string LastConversationParticipantArn { get; set; }

        /// <summary>
        /// Gets or Sets LastConversationParticipantName
        /// </summary>
        [DataMember(Name="last_conversation_participant_name", EmitDefaultValue=false)]
        public string LastConversationParticipantName { get; set; }

        /// <summary>
        /// Last message date/time
        /// </summary>
        /// <value>Last message date/time</value>
        [DataMember(Name="last_message_dts", EmitDefaultValue=false)]
        public string LastMessageDts { get; set; }

        /// <summary>
        /// Gets or Sets MerchantId
        /// </summary>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets MessageCount
        /// </summary>
        [DataMember(Name="message_count", EmitDefaultValue=false)]
        public int? MessageCount { get; set; }

        /// <summary>
        /// Gets or Sets UnreadMessages
        /// </summary>
        [DataMember(Name="unread_messages", EmitDefaultValue=false)]
        public bool? UnreadMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSummary {\n");
            sb.Append("  ConversationArn: ").Append(ConversationArn).Append("\n");
            sb.Append("  ConversationUuid: ").Append(ConversationUuid).Append("\n");
            sb.Append("  LastConversationMessageBody: ").Append(LastConversationMessageBody).Append("\n");
            sb.Append("  LastConversationParticipantArn: ").Append(LastConversationParticipantArn).Append("\n");
            sb.Append("  LastConversationParticipantName: ").Append(LastConversationParticipantName).Append("\n");
            sb.Append("  LastMessageDts: ").Append(LastMessageDts).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
            sb.Append("  UnreadMessages: ").Append(UnreadMessages).Append("\n");
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
            return this.Equals(input as ConversationSummary);
        }

        /// <summary>
        /// Returns true if ConversationSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConversationArn == input.ConversationArn ||
                    (this.ConversationArn != null &&
                    this.ConversationArn.Equals(input.ConversationArn))
                ) && 
                (
                    this.ConversationUuid == input.ConversationUuid ||
                    (this.ConversationUuid != null &&
                    this.ConversationUuid.Equals(input.ConversationUuid))
                ) && 
                (
                    this.LastConversationMessageBody == input.LastConversationMessageBody ||
                    (this.LastConversationMessageBody != null &&
                    this.LastConversationMessageBody.Equals(input.LastConversationMessageBody))
                ) && 
                (
                    this.LastConversationParticipantArn == input.LastConversationParticipantArn ||
                    (this.LastConversationParticipantArn != null &&
                    this.LastConversationParticipantArn.Equals(input.LastConversationParticipantArn))
                ) && 
                (
                    this.LastConversationParticipantName == input.LastConversationParticipantName ||
                    (this.LastConversationParticipantName != null &&
                    this.LastConversationParticipantName.Equals(input.LastConversationParticipantName))
                ) && 
                (
                    this.LastMessageDts == input.LastMessageDts ||
                    (this.LastMessageDts != null &&
                    this.LastMessageDts.Equals(input.LastMessageDts))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.MessageCount == input.MessageCount ||
                    (this.MessageCount != null &&
                    this.MessageCount.Equals(input.MessageCount))
                ) && 
                (
                    this.UnreadMessages == input.UnreadMessages ||
                    (this.UnreadMessages != null &&
                    this.UnreadMessages.Equals(input.UnreadMessages))
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
                if (this.ConversationArn != null)
                    hashCode = hashCode * 59 + this.ConversationArn.GetHashCode();
                if (this.ConversationUuid != null)
                    hashCode = hashCode * 59 + this.ConversationUuid.GetHashCode();
                if (this.LastConversationMessageBody != null)
                    hashCode = hashCode * 59 + this.LastConversationMessageBody.GetHashCode();
                if (this.LastConversationParticipantArn != null)
                    hashCode = hashCode * 59 + this.LastConversationParticipantArn.GetHashCode();
                if (this.LastConversationParticipantName != null)
                    hashCode = hashCode * 59 + this.LastConversationParticipantName.GetHashCode();
                if (this.LastMessageDts != null)
                    hashCode = hashCode * 59 + this.LastMessageDts.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.MessageCount != null)
                    hashCode = hashCode * 59 + this.MessageCount.GetHashCode();
                if (this.UnreadMessages != null)
                    hashCode = hashCode * 59 + this.UnreadMessages.GetHashCode();
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
