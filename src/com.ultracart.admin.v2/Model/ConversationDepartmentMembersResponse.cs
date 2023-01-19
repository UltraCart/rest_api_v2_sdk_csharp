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
    /// ConversationDepartmentMembersResponse
    /// </summary>
    [DataContract]
    public partial class ConversationDepartmentMembersResponse :  IEquatable<ConversationDepartmentMembersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationDepartmentMembersResponse" /> class.
        /// </summary>
        /// <param name="conversationDepartmentMembers">conversationDepartmentMembers.</param>
        /// <param name="error">error.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="success">Indicates if API call was successful.</param>
        /// <param name="warning">warning.</param>
        public ConversationDepartmentMembersResponse(List<ConversationDepartmentMember> conversationDepartmentMembers = default(List<ConversationDepartmentMember>), Error error = default(Error), ResponseMetadata metadata = default(ResponseMetadata), bool success = default(bool), Warning warning = default(Warning))
        {
            this.ConversationDepartmentMembers = conversationDepartmentMembers;
            this.Error = error;
            this.Metadata = metadata;
            this.Success = success;
            this.Warning = warning;
        }

        /// <summary>
        /// Gets or Sets ConversationDepartmentMembers
        /// </summary>
        [DataMember(Name="conversation_department_members", EmitDefaultValue=false)]
        public List<ConversationDepartmentMember> ConversationDepartmentMembers { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Indicates if API call was successful
        /// </summary>
        /// <value>Indicates if API call was successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Warning
        /// </summary>
        [DataMember(Name="warning", EmitDefaultValue=false)]
        public Warning Warning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationDepartmentMembersResponse {\n");
            sb.Append("  ConversationDepartmentMembers: ").Append(ConversationDepartmentMembers).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Warning: ").Append(Warning).Append("\n");
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
            return this.Equals(input as ConversationDepartmentMembersResponse);
        }

        /// <summary>
        /// Returns true if ConversationDepartmentMembersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationDepartmentMembersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationDepartmentMembersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConversationDepartmentMembers == input.ConversationDepartmentMembers ||
                    this.ConversationDepartmentMembers != null &&
                    input.ConversationDepartmentMembers != null &&
                    this.ConversationDepartmentMembers.SequenceEqual(input.ConversationDepartmentMembers)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Warning == input.Warning ||
                    (this.Warning != null &&
                    this.Warning.Equals(input.Warning))
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
                if (this.ConversationDepartmentMembers != null)
                    hashCode = hashCode * 59 + this.ConversationDepartmentMembers.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Warning != null)
                    hashCode = hashCode * 59 + this.Warning.GetHashCode();
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