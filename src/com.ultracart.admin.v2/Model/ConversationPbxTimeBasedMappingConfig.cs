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
    /// ConversationPbxTimeBasedMappingConfig
    /// </summary>
    [DataContract]
    public partial class ConversationPbxTimeBasedMappingConfig :  IEquatable<ConversationPbxTimeBasedMappingConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationPbxTimeBasedMappingConfig" /> class.
        /// </summary>
        /// <param name="defaultMapping">defaultMapping.</param>
        /// <param name="mappings">Mappings.</param>
        public ConversationPbxTimeBasedMappingConfig(ConversationPbxTimeBasedMapping defaultMapping = default(ConversationPbxTimeBasedMapping), List<ConversationPbxTimeBasedMapping> mappings = default(List<ConversationPbxTimeBasedMapping>))
        {
            this.DefaultMapping = defaultMapping;
            this.Mappings = mappings;
        }

        /// <summary>
        /// Gets or Sets DefaultMapping
        /// </summary>
        [DataMember(Name="default_mapping", EmitDefaultValue=false)]
        public ConversationPbxTimeBasedMapping DefaultMapping { get; set; }

        /// <summary>
        /// Mappings
        /// </summary>
        /// <value>Mappings</value>
        [DataMember(Name="mappings", EmitDefaultValue=false)]
        public List<ConversationPbxTimeBasedMapping> Mappings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationPbxTimeBasedMappingConfig {\n");
            sb.Append("  DefaultMapping: ").Append(DefaultMapping).Append("\n");
            sb.Append("  Mappings: ").Append(Mappings).Append("\n");
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
            return this.Equals(input as ConversationPbxTimeBasedMappingConfig);
        }

        /// <summary>
        /// Returns true if ConversationPbxTimeBasedMappingConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationPbxTimeBasedMappingConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationPbxTimeBasedMappingConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultMapping == input.DefaultMapping ||
                    (this.DefaultMapping != null &&
                    this.DefaultMapping.Equals(input.DefaultMapping))
                ) && 
                (
                    this.Mappings == input.Mappings ||
                    this.Mappings != null &&
                    input.Mappings != null &&
                    this.Mappings.SequenceEqual(input.Mappings)
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
                if (this.DefaultMapping != null)
                    hashCode = hashCode * 59 + this.DefaultMapping.GetHashCode();
                if (this.Mappings != null)
                    hashCode = hashCode * 59 + this.Mappings.GetHashCode();
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
