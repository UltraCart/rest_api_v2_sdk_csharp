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
    /// ConversationPbxMenuMapping
    /// </summary>
    [DataContract]
    public partial class ConversationPbxMenuMapping :  IEquatable<ConversationPbxMenuMapping>, IValidatableObject
    {
        /// <summary>
        /// Action
        /// </summary>
        /// <value>Action</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Timebased for value: time based
            /// </summary>
            [EnumMember(Value = "time based")]
            Timebased = 1,
            
            /// <summary>
            /// Enum Menu for value: menu
            /// </summary>
            [EnumMember(Value = "menu")]
            Menu = 2,
            
            /// <summary>
            /// Enum Queue for value: queue
            /// </summary>
            [EnumMember(Value = "queue")]
            Queue = 3,
            
            /// <summary>
            /// Enum Voicemail for value: voicemail
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail = 4,
            
            /// <summary>
            /// Enum Agent for value: agent
            /// </summary>
            [EnumMember(Value = "agent")]
            Agent = 5
        }

        /// <summary>
        /// Action
        /// </summary>
        /// <value>Action</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationPbxMenuMapping" /> class.
        /// </summary>
        /// <param name="action">Action.</param>
        /// <param name="actionTarget">Action target.  This is the UUID associated with the configuration object of that particular type..</param>
        /// <param name="digits">Digits.</param>
        /// <param name="speech">Speech.</param>
        public ConversationPbxMenuMapping(ActionEnum? action = default(ActionEnum?), string actionTarget = default(string), int? digits = default(int?), string speech = default(string))
        {
            this.Action = action;
            this.ActionTarget = actionTarget;
            this.Digits = digits;
            this.Speech = speech;
        }
        

        /// <summary>
        /// Action target.  This is the UUID associated with the configuration object of that particular type.
        /// </summary>
        /// <value>Action target.  This is the UUID associated with the configuration object of that particular type.</value>
        [DataMember(Name="action_target", EmitDefaultValue=false)]
        public string ActionTarget { get; set; }

        /// <summary>
        /// Digits
        /// </summary>
        /// <value>Digits</value>
        [DataMember(Name="digits", EmitDefaultValue=false)]
        public int? Digits { get; set; }

        /// <summary>
        /// Speech
        /// </summary>
        /// <value>Speech</value>
        [DataMember(Name="speech", EmitDefaultValue=false)]
        public string Speech { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationPbxMenuMapping {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionTarget: ").Append(ActionTarget).Append("\n");
            sb.Append("  Digits: ").Append(Digits).Append("\n");
            sb.Append("  Speech: ").Append(Speech).Append("\n");
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
            return this.Equals(input as ConversationPbxMenuMapping);
        }

        /// <summary>
        /// Returns true if ConversationPbxMenuMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationPbxMenuMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationPbxMenuMapping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.ActionTarget == input.ActionTarget ||
                    (this.ActionTarget != null &&
                    this.ActionTarget.Equals(input.ActionTarget))
                ) && 
                (
                    this.Digits == input.Digits ||
                    (this.Digits != null &&
                    this.Digits.Equals(input.Digits))
                ) && 
                (
                    this.Speech == input.Speech ||
                    (this.Speech != null &&
                    this.Speech.Equals(input.Speech))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ActionTarget != null)
                    hashCode = hashCode * 59 + this.ActionTarget.GetHashCode();
                if (this.Digits != null)
                    hashCode = hashCode * 59 + this.Digits.GetHashCode();
                if (this.Speech != null)
                    hashCode = hashCode * 59 + this.Speech.GetHashCode();
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
            // Action (string) maxLength
            if(this.Action != null && this.Action.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Action, length must be less than 30.", new [] { "Action" });
            }

            // ActionTarget (string) maxLength
            if(this.ActionTarget != null && this.ActionTarget.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ActionTarget, length must be less than 50.", new [] { "ActionTarget" });
            }

            yield break;
        }
    }

}
