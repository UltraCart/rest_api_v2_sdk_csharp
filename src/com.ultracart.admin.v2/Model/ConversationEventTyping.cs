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
    /// ConversationEventTyping
    /// </summary>
    [DataContract]
    public partial class ConversationEventTyping :  IEquatable<ConversationEventTyping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEventTyping" /> class.
        /// </summary>
        /// <param name="authorConversationParticipantArn">authorConversationParticipantArn.</param>
        /// <param name="authorConversationParticipantName">authorConversationParticipantName.</param>
        /// <param name="value">value.</param>
        public ConversationEventTyping(string authorConversationParticipantArn = default(string), string authorConversationParticipantName = default(string), string value = default(string))
        {
            this.AuthorConversationParticipantArn = authorConversationParticipantArn;
            this.AuthorConversationParticipantName = authorConversationParticipantName;
            this.Value = value;
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
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationEventTyping {\n");
            sb.Append("  AuthorConversationParticipantArn: ").Append(AuthorConversationParticipantArn).Append("\n");
            sb.Append("  AuthorConversationParticipantName: ").Append(AuthorConversationParticipantName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ConversationEventTyping);
        }

        /// <summary>
        /// Returns true if ConversationEventTyping instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationEventTyping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationEventTyping input)
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
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
