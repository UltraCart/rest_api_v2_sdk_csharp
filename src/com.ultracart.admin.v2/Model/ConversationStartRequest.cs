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
    /// ConversationStartRequest
    /// </summary>
    [DataContract]
    public partial class ConversationStartRequest :  IEquatable<ConversationStartRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationStartRequest" /> class.
        /// </summary>
        /// <param name="addConversationParticipantArns">addConversationParticipantArns.</param>
        /// <param name="conversationArn">conversationArn.</param>
        /// <param name="conversationWebchatQueueUuid">conversationWebchatQueueUuid.</param>
        public ConversationStartRequest(List<string> addConversationParticipantArns = default(List<string>), string conversationArn = default(string), string conversationWebchatQueueUuid = default(string))
        {
            this.AddConversationParticipantArns = addConversationParticipantArns;
            this.ConversationArn = conversationArn;
            this.ConversationWebchatQueueUuid = conversationWebchatQueueUuid;
        }
        
        /// <summary>
        /// Gets or Sets AddConversationParticipantArns
        /// </summary>
        [DataMember(Name="add_conversation_participant_arns", EmitDefaultValue=false)]
        public List<string> AddConversationParticipantArns { get; set; }

        /// <summary>
        /// Gets or Sets ConversationArn
        /// </summary>
        [DataMember(Name="conversation_arn", EmitDefaultValue=false)]
        public string ConversationArn { get; set; }

        /// <summary>
        /// Gets or Sets ConversationWebchatQueueUuid
        /// </summary>
        [DataMember(Name="conversation_webchat_queue_uuid", EmitDefaultValue=false)]
        public string ConversationWebchatQueueUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationStartRequest {\n");
            sb.Append("  AddConversationParticipantArns: ").Append(AddConversationParticipantArns).Append("\n");
            sb.Append("  ConversationArn: ").Append(ConversationArn).Append("\n");
            sb.Append("  ConversationWebchatQueueUuid: ").Append(ConversationWebchatQueueUuid).Append("\n");
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
            return this.Equals(input as ConversationStartRequest);
        }

        /// <summary>
        /// Returns true if ConversationStartRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationStartRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationStartRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddConversationParticipantArns == input.AddConversationParticipantArns ||
                    this.AddConversationParticipantArns != null &&
                    this.AddConversationParticipantArns.SequenceEqual(input.AddConversationParticipantArns)
                ) && 
                (
                    this.ConversationArn == input.ConversationArn ||
                    (this.ConversationArn != null &&
                    this.ConversationArn.Equals(input.ConversationArn))
                ) && 
                (
                    this.ConversationWebchatQueueUuid == input.ConversationWebchatQueueUuid ||
                    (this.ConversationWebchatQueueUuid != null &&
                    this.ConversationWebchatQueueUuid.Equals(input.ConversationWebchatQueueUuid))
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
                if (this.AddConversationParticipantArns != null)
                    hashCode = hashCode * 59 + this.AddConversationParticipantArns.GetHashCode();
                if (this.ConversationArn != null)
                    hashCode = hashCode * 59 + this.ConversationArn.GetHashCode();
                if (this.ConversationWebchatQueueUuid != null)
                    hashCode = hashCode * 59 + this.ConversationWebchatQueueUuid.GetHashCode();
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
