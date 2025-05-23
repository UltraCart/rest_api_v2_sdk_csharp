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
    /// CustomerEmailListChanges
    /// </summary>
    [DataContract]
    public partial class CustomerEmailListChanges :  IEquatable<CustomerEmailListChanges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerEmailListChanges" /> class.
        /// </summary>
        /// <param name="addToLists">Add this customer to these email lists.</param>
        /// <param name="removeFromLists">Remove this customer from these email lists.</param>
        public CustomerEmailListChanges(List<string> addToLists = default(List<string>), List<string> removeFromLists = default(List<string>))
        {
            this.AddToLists = addToLists;
            this.RemoveFromLists = removeFromLists;
        }

        /// <summary>
        /// Add this customer to these email lists
        /// </summary>
        /// <value>Add this customer to these email lists</value>
        [DataMember(Name="add_to_lists", EmitDefaultValue=false)]
        public List<string> AddToLists { get; set; }

        /// <summary>
        /// Remove this customer from these email lists
        /// </summary>
        /// <value>Remove this customer from these email lists</value>
        [DataMember(Name="remove_from_lists", EmitDefaultValue=false)]
        public List<string> RemoveFromLists { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerEmailListChanges {\n");
            sb.Append("  AddToLists: ").Append(AddToLists).Append("\n");
            sb.Append("  RemoveFromLists: ").Append(RemoveFromLists).Append("\n");
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
            return this.Equals(input as CustomerEmailListChanges);
        }

        /// <summary>
        /// Returns true if CustomerEmailListChanges instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerEmailListChanges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerEmailListChanges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddToLists == input.AddToLists ||
                    this.AddToLists != null &&
                    input.AddToLists != null &&
                    this.AddToLists.SequenceEqual(input.AddToLists)
                ) && 
                (
                    this.RemoveFromLists == input.RemoveFromLists ||
                    this.RemoveFromLists != null &&
                    input.RemoveFromLists != null &&
                    this.RemoveFromLists.SequenceEqual(input.RemoveFromLists)
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
                if (this.AddToLists != null)
                    hashCode = hashCode * 59 + this.AddToLists.GetHashCode();
                if (this.RemoveFromLists != null)
                    hashCode = hashCode * 59 + this.RemoveFromLists.GetHashCode();
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
