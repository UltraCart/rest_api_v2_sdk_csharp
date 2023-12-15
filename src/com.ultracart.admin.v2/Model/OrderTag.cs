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
    /// OrderTag
    /// </summary>
    [DataContract]
    public partial class OrderTag :  IEquatable<OrderTag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTag" /> class.
        /// </summary>
        /// <param name="tagValue">Tag Value.</param>
        public OrderTag(string tagValue = default(string))
        {
            this.TagValue = tagValue;
        }
        
        /// <summary>
        /// Tag Value
        /// </summary>
        /// <value>Tag Value</value>
        [DataMember(Name="tag_value", EmitDefaultValue=false)]
        public string TagValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderTag {\n");
            sb.Append("  TagValue: ").Append(TagValue).Append("\n");
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
            return this.Equals(input as OrderTag);
        }

        /// <summary>
        /// Returns true if OrderTag instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderTag input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TagValue == input.TagValue ||
                    (this.TagValue != null &&
                    this.TagValue.Equals(input.TagValue))
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
                if (this.TagValue != null)
                    hashCode = hashCode * 59 + this.TagValue.GetHashCode();
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
            // TagValue (string) maxLength
            if(this.TagValue != null && this.TagValue.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TagValue, length must be less than 100.", new [] { "TagValue" });
            }

            yield break;
        }
    }

}
