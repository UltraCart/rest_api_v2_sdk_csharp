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
    /// ConversationEventReadMessage
    /// </summary>
    [DataContract]
    public partial class ConversationEventReadMessage :  IEquatable<ConversationEventReadMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEventReadMessage" /> class.
        /// </summary>
        /// <param name="conversationMessageUuid">conversationMessageUuid.</param>
        /// <param name="messageDts">Message date/time.</param>
        /// <param name="messageEpoch">messageEpoch.</param>
        public ConversationEventReadMessage(string conversationMessageUuid = default(string), string messageDts = default(string), long messageEpoch = default(long))
        {
            this.ConversationMessageUuid = conversationMessageUuid;
            this.MessageDts = messageDts;
            this.MessageEpoch = messageEpoch;
        }

        /// <summary>
        /// Gets or Sets ConversationMessageUuid
        /// </summary>
        [DataMember(Name="conversation_message_uuid", EmitDefaultValue=false)]
        public string ConversationMessageUuid { get; set; }

        /// <summary>
        /// Message date/time
        /// </summary>
        /// <value>Message date/time</value>
        [DataMember(Name="message_dts", EmitDefaultValue=false)]
        public string MessageDts { get; set; }

        /// <summary>
        /// Gets or Sets MessageEpoch
        /// </summary>
        [DataMember(Name="message_epoch", EmitDefaultValue=false)]
        public long MessageEpoch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationEventReadMessage {\n");
            sb.Append("  ConversationMessageUuid: ").Append(ConversationMessageUuid).Append("\n");
            sb.Append("  MessageDts: ").Append(MessageDts).Append("\n");
            sb.Append("  MessageEpoch: ").Append(MessageEpoch).Append("\n");
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
            return this.Equals(input as ConversationEventReadMessage);
        }

        /// <summary>
        /// Returns true if ConversationEventReadMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationEventReadMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationEventReadMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConversationMessageUuid == input.ConversationMessageUuid ||
                    (this.ConversationMessageUuid != null &&
                    this.ConversationMessageUuid.Equals(input.ConversationMessageUuid))
                ) && 
                (
                    this.MessageDts == input.MessageDts ||
                    (this.MessageDts != null &&
                    this.MessageDts.Equals(input.MessageDts))
                ) && 
                (
                    this.MessageEpoch == input.MessageEpoch ||
                    (this.MessageEpoch != null &&
                    this.MessageEpoch.Equals(input.MessageEpoch))
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
                if (this.ConversationMessageUuid != null)
                    hashCode = hashCode * 59 + this.ConversationMessageUuid.GetHashCode();
                if (this.MessageDts != null)
                    hashCode = hashCode * 59 + this.MessageDts.GetHashCode();
                if (this.MessageEpoch != null)
                    hashCode = hashCode * 59 + this.MessageEpoch.GetHashCode();
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
