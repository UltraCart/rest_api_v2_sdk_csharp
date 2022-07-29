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
    /// ConversationMessage
    /// </summary>
    [DataContract]
    public partial class ConversationMessage :  IEquatable<ConversationMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMessage" /> class.
        /// </summary>
        /// <param name="authorConversationParticipantArn">authorConversationParticipantArn.</param>
        /// <param name="authorConversationParticipantName">authorConversationParticipantName.</param>
        /// <param name="body">body.</param>
        /// <param name="clientMessageId">clientMessageId.</param>
        /// <param name="mediaUrls">mediaUrls.</param>
        /// <param name="messageDts">Message date/time.</param>
        /// <param name="transportStatuses">transportStatuses.</param>
        /// <param name="uploadKeys">uploadKeys.</param>
        public ConversationMessage(string authorConversationParticipantArn = default(string), string authorConversationParticipantName = default(string), string body = default(string), string clientMessageId = default(string), List<string> mediaUrls = default(List<string>), string messageDts = default(string), List<ConversationMessageTransportStatus> transportStatuses = default(List<ConversationMessageTransportStatus>), List<string> uploadKeys = default(List<string>))
        {
            this.AuthorConversationParticipantArn = authorConversationParticipantArn;
            this.AuthorConversationParticipantName = authorConversationParticipantName;
            this.Body = body;
            this.ClientMessageId = clientMessageId;
            this.MediaUrls = mediaUrls;
            this.MessageDts = messageDts;
            this.TransportStatuses = transportStatuses;
            this.UploadKeys = uploadKeys;
        }
        
        /// <summary>
        /// Gets or Sets AuthorConversationParticipantArn
        /// </summary>
        [DataMember(Name="author_conversation_participant_arn", EmitDefaultValue=false)]
        public string AuthorConversationParticipantArn { get; set; }

        /// <summary>
        /// Gets or Sets AuthorConversationParticipantName
        /// </summary>
        [DataMember(Name="author_conversation_participant_name", EmitDefaultValue=false)]
        public string AuthorConversationParticipantName { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets ClientMessageId
        /// </summary>
        [DataMember(Name="client_message_id", EmitDefaultValue=false)]
        public string ClientMessageId { get; set; }

        /// <summary>
        /// Gets or Sets MediaUrls
        /// </summary>
        [DataMember(Name="media_urls", EmitDefaultValue=false)]
        public List<string> MediaUrls { get; set; }

        /// <summary>
        /// Message date/time
        /// </summary>
        /// <value>Message date/time</value>
        [DataMember(Name="message_dts", EmitDefaultValue=false)]
        public string MessageDts { get; set; }

        /// <summary>
        /// Gets or Sets TransportStatuses
        /// </summary>
        [DataMember(Name="transport_statuses", EmitDefaultValue=false)]
        public List<ConversationMessageTransportStatus> TransportStatuses { get; set; }

        /// <summary>
        /// Gets or Sets UploadKeys
        /// </summary>
        [DataMember(Name="upload_keys", EmitDefaultValue=false)]
        public List<string> UploadKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationMessage {\n");
            sb.Append("  AuthorConversationParticipantArn: ").Append(AuthorConversationParticipantArn).Append("\n");
            sb.Append("  AuthorConversationParticipantName: ").Append(AuthorConversationParticipantName).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  ClientMessageId: ").Append(ClientMessageId).Append("\n");
            sb.Append("  MediaUrls: ").Append(MediaUrls).Append("\n");
            sb.Append("  MessageDts: ").Append(MessageDts).Append("\n");
            sb.Append("  TransportStatuses: ").Append(TransportStatuses).Append("\n");
            sb.Append("  UploadKeys: ").Append(UploadKeys).Append("\n");
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
            return this.Equals(input as ConversationMessage);
        }

        /// <summary>
        /// Returns true if ConversationMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthorConversationParticipantArn == input.AuthorConversationParticipantArn ||
                    (this.AuthorConversationParticipantArn != null &&
                    this.AuthorConversationParticipantArn.Equals(input.AuthorConversationParticipantArn))
                ) && 
                (
                    this.AuthorConversationParticipantName == input.AuthorConversationParticipantName ||
                    (this.AuthorConversationParticipantName != null &&
                    this.AuthorConversationParticipantName.Equals(input.AuthorConversationParticipantName))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.ClientMessageId == input.ClientMessageId ||
                    (this.ClientMessageId != null &&
                    this.ClientMessageId.Equals(input.ClientMessageId))
                ) && 
                (
                    this.MediaUrls == input.MediaUrls ||
                    this.MediaUrls != null &&
                    this.MediaUrls.SequenceEqual(input.MediaUrls)
                ) && 
                (
                    this.MessageDts == input.MessageDts ||
                    (this.MessageDts != null &&
                    this.MessageDts.Equals(input.MessageDts))
                ) && 
                (
                    this.TransportStatuses == input.TransportStatuses ||
                    this.TransportStatuses != null &&
                    this.TransportStatuses.SequenceEqual(input.TransportStatuses)
                ) && 
                (
                    this.UploadKeys == input.UploadKeys ||
                    this.UploadKeys != null &&
                    this.UploadKeys.SequenceEqual(input.UploadKeys)
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
                if (this.AuthorConversationParticipantArn != null)
                    hashCode = hashCode * 59 + this.AuthorConversationParticipantArn.GetHashCode();
                if (this.AuthorConversationParticipantName != null)
                    hashCode = hashCode * 59 + this.AuthorConversationParticipantName.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.ClientMessageId != null)
                    hashCode = hashCode * 59 + this.ClientMessageId.GetHashCode();
                if (this.MediaUrls != null)
                    hashCode = hashCode * 59 + this.MediaUrls.GetHashCode();
                if (this.MessageDts != null)
                    hashCode = hashCode * 59 + this.MessageDts.GetHashCode();
                if (this.TransportStatuses != null)
                    hashCode = hashCode * 59 + this.TransportStatuses.GetHashCode();
                if (this.UploadKeys != null)
                    hashCode = hashCode * 59 + this.UploadKeys.GetHashCode();
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
