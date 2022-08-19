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
    /// ConversationParticipant
    /// </summary>
    [DataContract]
    public partial class ConversationParticipant :  IEquatable<ConversationParticipant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationParticipant" /> class.
        /// </summary>
        /// <param name="conversationParticipantArn">conversationParticipantArn.</param>
        /// <param name="conversationParticipantName">conversationParticipantName.</param>
        /// <param name="conversationParticipantUuid">conversationParticipantUuid.</param>
        /// <param name="joinedDts">Joined conversation date/time.</param>
        /// <param name="lastMessageDts">Last message date/time.</param>
        /// <param name="leftDts">Left conversation date/time.</param>
        /// <param name="profileImageUrl">profileImageUrl.</param>
        /// <param name="status">status.</param>
        /// <param name="unreadMessages">unreadMessages.</param>
        public ConversationParticipant(string conversationParticipantArn = default(string), string conversationParticipantName = default(string), string conversationParticipantUuid = default(string), string joinedDts = default(string), string lastMessageDts = default(string), string leftDts = default(string), string profileImageUrl = default(string), string status = default(string), int unreadMessages = default(int))
        {
            this.ConversationParticipantArn = conversationParticipantArn;
            this.ConversationParticipantName = conversationParticipantName;
            this.ConversationParticipantUuid = conversationParticipantUuid;
            this.JoinedDts = joinedDts;
            this.LastMessageDts = lastMessageDts;
            this.LeftDts = leftDts;
            this.ProfileImageUrl = profileImageUrl;
            this.Status = status;
            this.UnreadMessages = unreadMessages;
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
        /// Gets or Sets ConversationParticipantUuid
        /// </summary>
        [DataMember(Name="conversation_participant_uuid", EmitDefaultValue=false)]
        public string ConversationParticipantUuid { get; set; }

        /// <summary>
        /// Joined conversation date/time
        /// </summary>
        /// <value>Joined conversation date/time</value>
        [DataMember(Name="joined_dts", EmitDefaultValue=false)]
        public string JoinedDts { get; set; }

        /// <summary>
        /// Last message date/time
        /// </summary>
        /// <value>Last message date/time</value>
        [DataMember(Name="last_message_dts", EmitDefaultValue=false)]
        public string LastMessageDts { get; set; }

        /// <summary>
        /// Left conversation date/time
        /// </summary>
        /// <value>Left conversation date/time</value>
        [DataMember(Name="left_dts", EmitDefaultValue=false)]
        public string LeftDts { get; set; }

        /// <summary>
        /// Gets or Sets ProfileImageUrl
        /// </summary>
        [DataMember(Name="profile_image_url", EmitDefaultValue=false)]
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets UnreadMessages
        /// </summary>
        [DataMember(Name="unread_messages", EmitDefaultValue=false)]
        public int UnreadMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationParticipant {\n");
            sb.Append("  ConversationParticipantArn: ").Append(ConversationParticipantArn).Append("\n");
            sb.Append("  ConversationParticipantName: ").Append(ConversationParticipantName).Append("\n");
            sb.Append("  ConversationParticipantUuid: ").Append(ConversationParticipantUuid).Append("\n");
            sb.Append("  JoinedDts: ").Append(JoinedDts).Append("\n");
            sb.Append("  LastMessageDts: ").Append(LastMessageDts).Append("\n");
            sb.Append("  LeftDts: ").Append(LeftDts).Append("\n");
            sb.Append("  ProfileImageUrl: ").Append(ProfileImageUrl).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConversationParticipant);
        }

        /// <summary>
        /// Returns true if ConversationParticipant instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationParticipant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationParticipant input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ConversationParticipantUuid == input.ConversationParticipantUuid ||
                    (this.ConversationParticipantUuid != null &&
                    this.ConversationParticipantUuid.Equals(input.ConversationParticipantUuid))
                ) && 
                (
                    this.JoinedDts == input.JoinedDts ||
                    (this.JoinedDts != null &&
                    this.JoinedDts.Equals(input.JoinedDts))
                ) && 
                (
                    this.LastMessageDts == input.LastMessageDts ||
                    (this.LastMessageDts != null &&
                    this.LastMessageDts.Equals(input.LastMessageDts))
                ) && 
                (
                    this.LeftDts == input.LeftDts ||
                    (this.LeftDts != null &&
                    this.LeftDts.Equals(input.LeftDts))
                ) && 
                (
                    this.ProfileImageUrl == input.ProfileImageUrl ||
                    (this.ProfileImageUrl != null &&
                    this.ProfileImageUrl.Equals(input.ProfileImageUrl))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ConversationParticipantArn != null)
                    hashCode = hashCode * 59 + this.ConversationParticipantArn.GetHashCode();
                if (this.ConversationParticipantName != null)
                    hashCode = hashCode * 59 + this.ConversationParticipantName.GetHashCode();
                if (this.ConversationParticipantUuid != null)
                    hashCode = hashCode * 59 + this.ConversationParticipantUuid.GetHashCode();
                if (this.JoinedDts != null)
                    hashCode = hashCode * 59 + this.JoinedDts.GetHashCode();
                if (this.LastMessageDts != null)
                    hashCode = hashCode * 59 + this.LastMessageDts.GetHashCode();
                if (this.LeftDts != null)
                    hashCode = hashCode * 59 + this.LeftDts.GetHashCode();
                if (this.ProfileImageUrl != null)
                    hashCode = hashCode * 59 + this.ProfileImageUrl.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
