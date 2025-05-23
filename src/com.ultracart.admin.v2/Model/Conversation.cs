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
    /// Conversation
    /// </summary>
    [DataContract]
    public partial class Conversation :  IEquatable<Conversation>, IValidatableObject
    {
        /// <summary>
        /// The communication medium of the customer.
        /// </summary>
        /// <value>The communication medium of the customer.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MediumEnum
        {
            /// <summary>
            /// Enum Sms for value: sms
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms = 1,

            /// <summary>
            /// Enum Websocket for value: websocket
            /// </summary>
            [EnumMember(Value = "websocket")]
            Websocket = 2

        }

        /// <summary>
        /// The communication medium of the customer.
        /// </summary>
        /// <value>The communication medium of the customer.</value>
        [DataMember(Name="medium", EmitDefaultValue=false)]
        public MediumEnum? Medium { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" /> class.
        /// </summary>
        /// <param name="baseLanguageIsoCode">The base language iso code for the StoreFront that everything is translated into.</param>
        /// <param name="closed">closed.</param>
        /// <param name="conversationArn">conversationArn.</param>
        /// <param name="conversationUuid">conversationUuid.</param>
        /// <param name="customerFirstMessageUnrespondedToDts">Date/time of the first customer message that is unresponded to..</param>
        /// <param name="lastConversationMessageBody">lastConversationMessageBody.</param>
        /// <param name="lastConversationParticipantArn">lastConversationParticipantArn.</param>
        /// <param name="lastConversationParticipantName">lastConversationParticipantName.</param>
        /// <param name="lastInteractiveMessageDts">Last interactive message date/time.</param>
        /// <param name="lastMessageDts">Last message date/time.</param>
        /// <param name="medium">The communication medium of the customer..</param>
        /// <param name="merchantId">merchantId.</param>
        /// <param name="messageCount">messageCount.</param>
        /// <param name="messages">messages.</param>
        /// <param name="participants">participants.</param>
        /// <param name="sentiment">sentiment.</param>
        /// <param name="startDts">Start of the conversation date/time.</param>
        /// <param name="unreadMessages">unreadMessages.</param>
        /// <param name="virtualAgent">True if a virtual agent answered the conversation.</param>
        /// <param name="virtualAgentCost">The cost of this conversation performed by the virtual agent.</param>
        /// <param name="visible">visible.</param>
        public Conversation(string baseLanguageIsoCode = default(string), bool closed = default(bool), string conversationArn = default(string), string conversationUuid = default(string), string customerFirstMessageUnrespondedToDts = default(string), string lastConversationMessageBody = default(string), string lastConversationParticipantArn = default(string), string lastConversationParticipantName = default(string), string lastInteractiveMessageDts = default(string), string lastMessageDts = default(string), MediumEnum? medium = default(MediumEnum?), string merchantId = default(string), int messageCount = default(int), List<ConversationMessage> messages = default(List<ConversationMessage>), List<ConversationParticipant> participants = default(List<ConversationParticipant>), ConversationSentiment sentiment = default(ConversationSentiment), string startDts = default(string), bool unreadMessages = default(bool), bool virtualAgent = default(bool), decimal virtualAgentCost = default(decimal), bool visible = default(bool))
        {
            this.BaseLanguageIsoCode = baseLanguageIsoCode;
            this.Closed = closed;
            this.ConversationArn = conversationArn;
            this.ConversationUuid = conversationUuid;
            this.CustomerFirstMessageUnrespondedToDts = customerFirstMessageUnrespondedToDts;
            this.LastConversationMessageBody = lastConversationMessageBody;
            this.LastConversationParticipantArn = lastConversationParticipantArn;
            this.LastConversationParticipantName = lastConversationParticipantName;
            this.LastInteractiveMessageDts = lastInteractiveMessageDts;
            this.LastMessageDts = lastMessageDts;
            this.Medium = medium;
            this.MerchantId = merchantId;
            this.MessageCount = messageCount;
            this.Messages = messages;
            this.Participants = participants;
            this.Sentiment = sentiment;
            this.StartDts = startDts;
            this.UnreadMessages = unreadMessages;
            this.VirtualAgent = virtualAgent;
            this.VirtualAgentCost = virtualAgentCost;
            this.Visible = visible;
        }

        /// <summary>
        /// The base language iso code for the StoreFront that everything is translated into
        /// </summary>
        /// <value>The base language iso code for the StoreFront that everything is translated into</value>
        [DataMember(Name="base_language_iso_code", EmitDefaultValue=false)]
        public string BaseLanguageIsoCode { get; set; }

        /// <summary>
        /// Gets or Sets Closed
        /// </summary>
        [DataMember(Name="closed", EmitDefaultValue=false)]
        public bool Closed { get; set; }

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
        /// Date/time of the first customer message that is unresponded to.
        /// </summary>
        /// <value>Date/time of the first customer message that is unresponded to.</value>
        [DataMember(Name="customer_first_message_unresponded_to_dts", EmitDefaultValue=false)]
        public string CustomerFirstMessageUnrespondedToDts { get; set; }

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
        /// Last interactive message date/time
        /// </summary>
        /// <value>Last interactive message date/time</value>
        [DataMember(Name="last_interactive_message_dts", EmitDefaultValue=false)]
        public string LastInteractiveMessageDts { get; set; }

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
        public int MessageCount { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<ConversationMessage> Messages { get; set; }

        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<ConversationParticipant> Participants { get; set; }

        /// <summary>
        /// Gets or Sets Sentiment
        /// </summary>
        [DataMember(Name="sentiment", EmitDefaultValue=false)]
        public ConversationSentiment Sentiment { get; set; }

        /// <summary>
        /// Start of the conversation date/time
        /// </summary>
        /// <value>Start of the conversation date/time</value>
        [DataMember(Name="start_dts", EmitDefaultValue=false)]
        public string StartDts { get; set; }

        /// <summary>
        /// Gets or Sets UnreadMessages
        /// </summary>
        [DataMember(Name="unread_messages", EmitDefaultValue=false)]
        public bool UnreadMessages { get; set; }

        /// <summary>
        /// True if a virtual agent answered the conversation
        /// </summary>
        /// <value>True if a virtual agent answered the conversation</value>
        [DataMember(Name="virtual_agent", EmitDefaultValue=false)]
        public bool VirtualAgent { get; set; }

        /// <summary>
        /// The cost of this conversation performed by the virtual agent
        /// </summary>
        /// <value>The cost of this conversation performed by the virtual agent</value>
        [DataMember(Name="virtual_agent_cost", EmitDefaultValue=false)]
        public decimal VirtualAgentCost { get; set; }

        /// <summary>
        /// Gets or Sets Visible
        /// </summary>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool Visible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Conversation {\n");
            sb.Append("  BaseLanguageIsoCode: ").Append(BaseLanguageIsoCode).Append("\n");
            sb.Append("  Closed: ").Append(Closed).Append("\n");
            sb.Append("  ConversationArn: ").Append(ConversationArn).Append("\n");
            sb.Append("  ConversationUuid: ").Append(ConversationUuid).Append("\n");
            sb.Append("  CustomerFirstMessageUnrespondedToDts: ").Append(CustomerFirstMessageUnrespondedToDts).Append("\n");
            sb.Append("  LastConversationMessageBody: ").Append(LastConversationMessageBody).Append("\n");
            sb.Append("  LastConversationParticipantArn: ").Append(LastConversationParticipantArn).Append("\n");
            sb.Append("  LastConversationParticipantName: ").Append(LastConversationParticipantName).Append("\n");
            sb.Append("  LastInteractiveMessageDts: ").Append(LastInteractiveMessageDts).Append("\n");
            sb.Append("  LastMessageDts: ").Append(LastMessageDts).Append("\n");
            sb.Append("  Medium: ").Append(Medium).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  Sentiment: ").Append(Sentiment).Append("\n");
            sb.Append("  StartDts: ").Append(StartDts).Append("\n");
            sb.Append("  UnreadMessages: ").Append(UnreadMessages).Append("\n");
            sb.Append("  VirtualAgent: ").Append(VirtualAgent).Append("\n");
            sb.Append("  VirtualAgentCost: ").Append(VirtualAgentCost).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
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
            return this.Equals(input as Conversation);
        }

        /// <summary>
        /// Returns true if Conversation instances are equal
        /// </summary>
        /// <param name="input">Instance of Conversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Conversation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseLanguageIsoCode == input.BaseLanguageIsoCode ||
                    (this.BaseLanguageIsoCode != null &&
                    this.BaseLanguageIsoCode.Equals(input.BaseLanguageIsoCode))
                ) && 
                (
                    this.Closed == input.Closed ||
                    (this.Closed != null &&
                    this.Closed.Equals(input.Closed))
                ) && 
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
                    this.CustomerFirstMessageUnrespondedToDts == input.CustomerFirstMessageUnrespondedToDts ||
                    (this.CustomerFirstMessageUnrespondedToDts != null &&
                    this.CustomerFirstMessageUnrespondedToDts.Equals(input.CustomerFirstMessageUnrespondedToDts))
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
                    this.LastInteractiveMessageDts == input.LastInteractiveMessageDts ||
                    (this.LastInteractiveMessageDts != null &&
                    this.LastInteractiveMessageDts.Equals(input.LastInteractiveMessageDts))
                ) && 
                (
                    this.LastMessageDts == input.LastMessageDts ||
                    (this.LastMessageDts != null &&
                    this.LastMessageDts.Equals(input.LastMessageDts))
                ) && 
                (
                    this.Medium == input.Medium ||
                    (this.Medium != null &&
                    this.Medium.Equals(input.Medium))
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
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    input.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.Participants == input.Participants ||
                    this.Participants != null &&
                    input.Participants != null &&
                    this.Participants.SequenceEqual(input.Participants)
                ) && 
                (
                    this.Sentiment == input.Sentiment ||
                    (this.Sentiment != null &&
                    this.Sentiment.Equals(input.Sentiment))
                ) && 
                (
                    this.StartDts == input.StartDts ||
                    (this.StartDts != null &&
                    this.StartDts.Equals(input.StartDts))
                ) && 
                (
                    this.UnreadMessages == input.UnreadMessages ||
                    (this.UnreadMessages != null &&
                    this.UnreadMessages.Equals(input.UnreadMessages))
                ) && 
                (
                    this.VirtualAgent == input.VirtualAgent ||
                    (this.VirtualAgent != null &&
                    this.VirtualAgent.Equals(input.VirtualAgent))
                ) && 
                (
                    this.VirtualAgentCost == input.VirtualAgentCost ||
                    (this.VirtualAgentCost != null &&
                    this.VirtualAgentCost.Equals(input.VirtualAgentCost))
                ) && 
                (
                    this.Visible == input.Visible ||
                    (this.Visible != null &&
                    this.Visible.Equals(input.Visible))
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
                if (this.BaseLanguageIsoCode != null)
                    hashCode = hashCode * 59 + this.BaseLanguageIsoCode.GetHashCode();
                if (this.Closed != null)
                    hashCode = hashCode * 59 + this.Closed.GetHashCode();
                if (this.ConversationArn != null)
                    hashCode = hashCode * 59 + this.ConversationArn.GetHashCode();
                if (this.ConversationUuid != null)
                    hashCode = hashCode * 59 + this.ConversationUuid.GetHashCode();
                if (this.CustomerFirstMessageUnrespondedToDts != null)
                    hashCode = hashCode * 59 + this.CustomerFirstMessageUnrespondedToDts.GetHashCode();
                if (this.LastConversationMessageBody != null)
                    hashCode = hashCode * 59 + this.LastConversationMessageBody.GetHashCode();
                if (this.LastConversationParticipantArn != null)
                    hashCode = hashCode * 59 + this.LastConversationParticipantArn.GetHashCode();
                if (this.LastConversationParticipantName != null)
                    hashCode = hashCode * 59 + this.LastConversationParticipantName.GetHashCode();
                if (this.LastInteractiveMessageDts != null)
                    hashCode = hashCode * 59 + this.LastInteractiveMessageDts.GetHashCode();
                if (this.LastMessageDts != null)
                    hashCode = hashCode * 59 + this.LastMessageDts.GetHashCode();
                if (this.Medium != null)
                    hashCode = hashCode * 59 + this.Medium.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.MessageCount != null)
                    hashCode = hashCode * 59 + this.MessageCount.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Participants != null)
                    hashCode = hashCode * 59 + this.Participants.GetHashCode();
                if (this.Sentiment != null)
                    hashCode = hashCode * 59 + this.Sentiment.GetHashCode();
                if (this.StartDts != null)
                    hashCode = hashCode * 59 + this.StartDts.GetHashCode();
                if (this.UnreadMessages != null)
                    hashCode = hashCode * 59 + this.UnreadMessages.GetHashCode();
                if (this.VirtualAgent != null)
                    hashCode = hashCode * 59 + this.VirtualAgent.GetHashCode();
                if (this.VirtualAgentCost != null)
                    hashCode = hashCode * 59 + this.VirtualAgentCost.GetHashCode();
                if (this.Visible != null)
                    hashCode = hashCode * 59 + this.Visible.GetHashCode();
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
