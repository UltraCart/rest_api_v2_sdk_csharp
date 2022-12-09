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
    /// ConversationCannedMessage
    /// </summary>
    [DataContract]
    public partial class ConversationCannedMessage :  IEquatable<ConversationCannedMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationCannedMessage" /> class.
        /// </summary>
        /// <param name="cannedMessage">cannedMessage.</param>
        /// <param name="conversationCannedMessageOid">conversationCannedMessageOid.</param>
        /// <param name="conversationDepartmentOids">conversationDepartmentOids.</param>
        /// <param name="shortCode">shortCode.</param>
        public ConversationCannedMessage(string cannedMessage = default(string), int? conversationCannedMessageOid = default(int?), List<string> conversationDepartmentOids = default(List<string>), string shortCode = default(string))
        {
            this.CannedMessage = cannedMessage;
            this.ConversationCannedMessageOid = conversationCannedMessageOid;
            this.ConversationDepartmentOids = conversationDepartmentOids;
            this.ShortCode = shortCode;
        }
        
        /// <summary>
        /// Gets or Sets CannedMessage
        /// </summary>
        [DataMember(Name="canned_message", EmitDefaultValue=false)]
        public string CannedMessage { get; set; }

        /// <summary>
        /// Gets or Sets ConversationCannedMessageOid
        /// </summary>
        [DataMember(Name="conversation_canned_message_oid", EmitDefaultValue=false)]
        public int? ConversationCannedMessageOid { get; set; }

        /// <summary>
        /// Gets or Sets ConversationDepartmentOids
        /// </summary>
        [DataMember(Name="conversation_department_oids", EmitDefaultValue=false)]
        public List<string> ConversationDepartmentOids { get; set; }

        /// <summary>
        /// Gets or Sets ShortCode
        /// </summary>
        [DataMember(Name="short_code", EmitDefaultValue=false)]
        public string ShortCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationCannedMessage {\n");
            sb.Append("  CannedMessage: ").Append(CannedMessage).Append("\n");
            sb.Append("  ConversationCannedMessageOid: ").Append(ConversationCannedMessageOid).Append("\n");
            sb.Append("  ConversationDepartmentOids: ").Append(ConversationDepartmentOids).Append("\n");
            sb.Append("  ShortCode: ").Append(ShortCode).Append("\n");
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
            return this.Equals(input as ConversationCannedMessage);
        }

        /// <summary>
        /// Returns true if ConversationCannedMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationCannedMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationCannedMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CannedMessage == input.CannedMessage ||
                    (this.CannedMessage != null &&
                    this.CannedMessage.Equals(input.CannedMessage))
                ) && 
                (
                    this.ConversationCannedMessageOid == input.ConversationCannedMessageOid ||
                    (this.ConversationCannedMessageOid != null &&
                    this.ConversationCannedMessageOid.Equals(input.ConversationCannedMessageOid))
                ) && 
                (
                    this.ConversationDepartmentOids == input.ConversationDepartmentOids ||
                    this.ConversationDepartmentOids != null &&
                    this.ConversationDepartmentOids.SequenceEqual(input.ConversationDepartmentOids)
                ) && 
                (
                    this.ShortCode == input.ShortCode ||
                    (this.ShortCode != null &&
                    this.ShortCode.Equals(input.ShortCode))
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
                if (this.CannedMessage != null)
                    hashCode = hashCode * 59 + this.CannedMessage.GetHashCode();
                if (this.ConversationCannedMessageOid != null)
                    hashCode = hashCode * 59 + this.ConversationCannedMessageOid.GetHashCode();
                if (this.ConversationDepartmentOids != null)
                    hashCode = hashCode * 59 + this.ConversationDepartmentOids.GetHashCode();
                if (this.ShortCode != null)
                    hashCode = hashCode * 59 + this.ShortCode.GetHashCode();
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
