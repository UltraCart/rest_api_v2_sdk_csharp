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
    /// ConversationWebchatQueueStatusAgent
    /// </summary>
    [DataContract]
    public partial class ConversationWebchatQueueStatusAgent :  IEquatable<ConversationWebchatQueueStatusAgent>, IValidatableObject
    {
        /// <summary>
        /// Status of the agent
        /// </summary>
        /// <value>Status of the agent</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AgentStatusEnum
        {
            /// <summary>
            /// Enum Available for value: available
            /// </summary>
            [EnumMember(Value = "available")]
            Available = 1,

            /// <summary>
            /// Enum Busy for value: busy
            /// </summary>
            [EnumMember(Value = "busy")]
            Busy = 2,

            /// <summary>
            /// Enum Unavailable for value: unavailable
            /// </summary>
            [EnumMember(Value = "unavailable")]
            Unavailable = 3

        }

        /// <summary>
        /// Status of the agent
        /// </summary>
        /// <value>Status of the agent</value>
        [DataMember(Name="agent_status", EmitDefaultValue=false)]
        public AgentStatusEnum? AgentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationWebchatQueueStatusAgent" /> class.
        /// </summary>
        /// <param name="agentStatus">Status of the agent.</param>
        /// <param name="conversationParticipantArn">conversationParticipantArn.</param>
        /// <param name="conversationParticipantName">conversationParticipantName.</param>
        /// <param name="lastChatDts">Date/time that this agent took their last chat.</param>
        /// <param name="nextRoundRobin">nextRoundRobin.</param>
        /// <param name="profileImageUrl">Profile image URL.</param>
        public ConversationWebchatQueueStatusAgent(AgentStatusEnum? agentStatus = default(AgentStatusEnum?), string conversationParticipantArn = default(string), string conversationParticipantName = default(string), string lastChatDts = default(string), bool nextRoundRobin = default(bool), string profileImageUrl = default(string))
        {
            this.AgentStatus = agentStatus;
            this.ConversationParticipantArn = conversationParticipantArn;
            this.ConversationParticipantName = conversationParticipantName;
            this.LastChatDts = lastChatDts;
            this.NextRoundRobin = nextRoundRobin;
            this.ProfileImageUrl = profileImageUrl;
        }


        /// <summary>
        /// Gets or Sets ConversationParticipantArn
        /// </summary>
        [DataMember(Name="conversation_participant_arn", EmitDefaultValue=false)]
        public string ConversationParticipantArn { get; set; }

        /// <summary>
        /// Gets or Sets ConversationParticipantName
        /// </summary>
        [DataMember(Name="conversation_participant_name", EmitDefaultValue=false)]
        public string ConversationParticipantName { get; set; }

        /// <summary>
        /// Date/time that this agent took their last chat
        /// </summary>
        /// <value>Date/time that this agent took their last chat</value>
        [DataMember(Name="last_chat_dts", EmitDefaultValue=false)]
        public string LastChatDts { get; set; }

        /// <summary>
        /// Gets or Sets NextRoundRobin
        /// </summary>
        [DataMember(Name="next_round_robin", EmitDefaultValue=false)]
        public bool NextRoundRobin { get; set; }

        /// <summary>
        /// Profile image URL
        /// </summary>
        /// <value>Profile image URL</value>
        [DataMember(Name="profile_image_url", EmitDefaultValue=false)]
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationWebchatQueueStatusAgent {\n");
            sb.Append("  AgentStatus: ").Append(AgentStatus).Append("\n");
            sb.Append("  ConversationParticipantArn: ").Append(ConversationParticipantArn).Append("\n");
            sb.Append("  ConversationParticipantName: ").Append(ConversationParticipantName).Append("\n");
            sb.Append("  LastChatDts: ").Append(LastChatDts).Append("\n");
            sb.Append("  NextRoundRobin: ").Append(NextRoundRobin).Append("\n");
            sb.Append("  ProfileImageUrl: ").Append(ProfileImageUrl).Append("\n");
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
            return this.Equals(input as ConversationWebchatQueueStatusAgent);
        }

        /// <summary>
        /// Returns true if ConversationWebchatQueueStatusAgent instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationWebchatQueueStatusAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationWebchatQueueStatusAgent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentStatus == input.AgentStatus ||
                    (this.AgentStatus != null &&
                    this.AgentStatus.Equals(input.AgentStatus))
                ) && 
                (
                    this.ConversationParticipantArn == input.ConversationParticipantArn ||
                    (this.ConversationParticipantArn != null &&
                    this.ConversationParticipantArn.Equals(input.ConversationParticipantArn))
                ) && 
                (
                    this.ConversationParticipantName == input.ConversationParticipantName ||
                    (this.ConversationParticipantName != null &&
                    this.ConversationParticipantName.Equals(input.ConversationParticipantName))
                ) && 
                (
                    this.LastChatDts == input.LastChatDts ||
                    (this.LastChatDts != null &&
                    this.LastChatDts.Equals(input.LastChatDts))
                ) && 
                (
                    this.NextRoundRobin == input.NextRoundRobin ||
                    (this.NextRoundRobin != null &&
                    this.NextRoundRobin.Equals(input.NextRoundRobin))
                ) && 
                (
                    this.ProfileImageUrl == input.ProfileImageUrl ||
                    (this.ProfileImageUrl != null &&
                    this.ProfileImageUrl.Equals(input.ProfileImageUrl))
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
                if (this.AgentStatus != null)
                    hashCode = hashCode * 59 + this.AgentStatus.GetHashCode();
                if (this.ConversationParticipantArn != null)
                    hashCode = hashCode * 59 + this.ConversationParticipantArn.GetHashCode();
                if (this.ConversationParticipantName != null)
                    hashCode = hashCode * 59 + this.ConversationParticipantName.GetHashCode();
                if (this.LastChatDts != null)
                    hashCode = hashCode * 59 + this.LastChatDts.GetHashCode();
                if (this.NextRoundRobin != null)
                    hashCode = hashCode * 59 + this.NextRoundRobin.GetHashCode();
                if (this.ProfileImageUrl != null)
                    hashCode = hashCode * 59 + this.ProfileImageUrl.GetHashCode();
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
