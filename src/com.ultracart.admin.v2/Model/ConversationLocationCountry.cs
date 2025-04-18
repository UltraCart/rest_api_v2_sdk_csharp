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
    /// ConversationLocationCountry
    /// </summary>
    [DataContract]
    public partial class ConversationLocationCountry :  IEquatable<ConversationLocationCountry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationLocationCountry" /> class.
        /// </summary>
        /// <param name="iso2">iso2.</param>
        /// <param name="name">name.</param>
        /// <param name="stateProvinces">stateProvinces.</param>
        public ConversationLocationCountry(string iso2 = default(string), string name = default(string), List<ConversationLocationStateProvince> stateProvinces = default(List<ConversationLocationStateProvince>))
        {
            this.Iso2 = iso2;
            this.Name = name;
            this.StateProvinces = stateProvinces;
        }

        /// <summary>
        /// Gets or Sets Iso2
        /// </summary>
        [DataMember(Name="iso2", EmitDefaultValue=false)]
        public string Iso2 { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets StateProvinces
        /// </summary>
        [DataMember(Name="state_provinces", EmitDefaultValue=false)]
        public List<ConversationLocationStateProvince> StateProvinces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationLocationCountry {\n");
            sb.Append("  Iso2: ").Append(Iso2).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StateProvinces: ").Append(StateProvinces).Append("\n");
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
            return this.Equals(input as ConversationLocationCountry);
        }

        /// <summary>
        /// Returns true if ConversationLocationCountry instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationLocationCountry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationLocationCountry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Iso2 == input.Iso2 ||
                    (this.Iso2 != null &&
                    this.Iso2.Equals(input.Iso2))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StateProvinces == input.StateProvinces ||
                    this.StateProvinces != null &&
                    input.StateProvinces != null &&
                    this.StateProvinces.SequenceEqual(input.StateProvinces)
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
                if (this.Iso2 != null)
                    hashCode = hashCode * 59 + this.Iso2.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StateProvinces != null)
                    hashCode = hashCode * 59 + this.StateProvinces.GetHashCode();
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
