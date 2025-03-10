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
    /// ConversationEventQueuePosition
    /// </summary>
    [DataContract]
    public partial class ConversationEventQueuePosition :  IEquatable<ConversationEventQueuePosition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEventQueuePosition" /> class.
        /// </summary>
        /// <param name="available">True if agents are logged into the queue.</param>
        /// <param name="position">Position in the queue.  Value will be -1 if they cant be found in the queue..</param>
        public ConversationEventQueuePosition(bool available = default(bool), int position = default(int))
        {
            this.Available = available;
            this.Position = position;
        }

        /// <summary>
        /// True if agents are logged into the queue
        /// </summary>
        /// <value>True if agents are logged into the queue</value>
        [DataMember(Name="available", EmitDefaultValue=false)]
        public bool Available { get; set; }

        /// <summary>
        /// Position in the queue.  Value will be -1 if they cant be found in the queue.
        /// </summary>
        /// <value>Position in the queue.  Value will be -1 if they cant be found in the queue.</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int Position { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationEventQueuePosition {\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return this.Equals(input as ConversationEventQueuePosition);
        }

        /// <summary>
        /// Returns true if ConversationEventQueuePosition instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationEventQueuePosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationEventQueuePosition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
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
                if (this.Available != null)
                    hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
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
