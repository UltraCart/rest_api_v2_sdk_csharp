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
    /// ConversationWebchatQueueStatusQueueEntry
    /// </summary>
    [DataContract]
    public partial class ConversationWebchatQueueStatusQueueEntry :  IEquatable<ConversationWebchatQueueStatusQueueEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationWebchatQueueStatusQueueEntry" /> class.
        /// </summary>
        /// <param name="conversationParticipantArn">conversationParticipantArn.</param>
        /// <param name="conversationParticipantName">conversationParticipantName.</param>
        /// <param name="conversationWebchatQueueUuid">conversationWebchatQueueUuid.</param>
        /// <param name="email">email.</param>
        /// <param name="joinDts">Date/time the customer joined the queue.</param>
        /// <param name="question">question.</param>
        public ConversationWebchatQueueStatusQueueEntry(string conversationParticipantArn = default(string), string conversationParticipantName = default(string), string conversationWebchatQueueUuid = default(string), string email = default(string), string joinDts = default(string), string question = default(string))
        {
            this.ConversationParticipantArn = conversationParticipantArn;
            this.ConversationParticipantName = conversationParticipantName;
            this.ConversationWebchatQueueUuid = conversationWebchatQueueUuid;
            this.Email = email;
            this.JoinDts = joinDts;
            this.Question = question;
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
        /// Gets or Sets ConversationWebchatQueueUuid
        /// </summary>
        [DataMember(Name="conversation_webchat_queue_uuid", EmitDefaultValue=false)]
        public string ConversationWebchatQueueUuid { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Date/time the customer joined the queue
        /// </summary>
        /// <value>Date/time the customer joined the queue</value>
        [DataMember(Name="join_dts", EmitDefaultValue=false)]
        public string JoinDts { get; set; }

        /// <summary>
        /// Gets or Sets Question
        /// </summary>
        [DataMember(Name="question", EmitDefaultValue=false)]
        public string Question { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationWebchatQueueStatusQueueEntry {\n");
            sb.Append("  ConversationParticipantArn: ").Append(ConversationParticipantArn).Append("\n");
            sb.Append("  ConversationParticipantName: ").Append(ConversationParticipantName).Append("\n");
            sb.Append("  ConversationWebchatQueueUuid: ").Append(ConversationWebchatQueueUuid).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  JoinDts: ").Append(JoinDts).Append("\n");
            sb.Append("  Question: ").Append(Question).Append("\n");
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
            return this.Equals(input as ConversationWebchatQueueStatusQueueEntry);
        }

        /// <summary>
        /// Returns true if ConversationWebchatQueueStatusQueueEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationWebchatQueueStatusQueueEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationWebchatQueueStatusQueueEntry input)
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
                    this.ConversationWebchatQueueUuid == input.ConversationWebchatQueueUuid ||
                    (this.ConversationWebchatQueueUuid != null &&
                    this.ConversationWebchatQueueUuid.Equals(input.ConversationWebchatQueueUuid))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.JoinDts == input.JoinDts ||
                    (this.JoinDts != null &&
                    this.JoinDts.Equals(input.JoinDts))
                ) && 
                (
                    this.Question == input.Question ||
                    (this.Question != null &&
                    this.Question.Equals(input.Question))
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
                if (this.ConversationWebchatQueueUuid != null)
                    hashCode = hashCode * 59 + this.ConversationWebchatQueueUuid.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.JoinDts != null)
                    hashCode = hashCode * 59 + this.JoinDts.GetHashCode();
                if (this.Question != null)
                    hashCode = hashCode * 59 + this.Question.GetHashCode();
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
