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
    /// LibraryItemAttribute
    /// </summary>
    [DataContract]
    public partial class LibraryItemAttribute :  IEquatable<LibraryItemAttribute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryItemAttribute" /> class.
        /// </summary>
        /// <param name="libraryItemOid">libraryItemOid.</param>
        /// <param name="name">name.</param>
        /// <param name="value">value.</param>
        public LibraryItemAttribute(int? libraryItemOid = default(int?), string name = default(string), string value = default(string))
        {
            this.LibraryItemOid = libraryItemOid;
            this.Name = name;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets LibraryItemOid
        /// </summary>
        [DataMember(Name="libraryItemOid", EmitDefaultValue=false)]
        public int? LibraryItemOid { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            sb.Append("class LibraryItemAttribute {\n");
            sb.Append("  LibraryItemOid: ").Append(LibraryItemOid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as LibraryItemAttribute);
        }

        /// <summary>
        /// Returns true if LibraryItemAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of LibraryItemAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LibraryItemAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LibraryItemOid == input.LibraryItemOid ||
                    (this.LibraryItemOid != null &&
                    this.LibraryItemOid.Equals(input.LibraryItemOid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.LibraryItemOid != null)
                    hashCode = hashCode * 59 + this.LibraryItemOid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
