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
    /// BrowserOS
    /// </summary>
    [DataContract]
    public partial class BrowserOS :  IEquatable<BrowserOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserOS" /> class.
        /// </summary>
        /// <param name="family">family.</param>
        /// <param name="major">major.</param>
        /// <param name="minor">minor.</param>
        /// <param name="patch">patch.</param>
        /// <param name="patchMinor">patchMinor.</param>
        public BrowserOS(string family = default(string), string major = default(string), string minor = default(string), string patch = default(string), string patchMinor = default(string))
        {
            this.Family = family;
            this.Major = major;
            this.Minor = minor;
            this.Patch = patch;
            this.PatchMinor = patchMinor;
        }
        
        /// <summary>
        /// Gets or Sets Family
        /// </summary>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public string Family { get; set; }

        /// <summary>
        /// Gets or Sets Major
        /// </summary>
        [DataMember(Name="major", EmitDefaultValue=false)]
        public string Major { get; set; }

        /// <summary>
        /// Gets or Sets Minor
        /// </summary>
        [DataMember(Name="minor", EmitDefaultValue=false)]
        public string Minor { get; set; }

        /// <summary>
        /// Gets or Sets Patch
        /// </summary>
        [DataMember(Name="patch", EmitDefaultValue=false)]
        public string Patch { get; set; }

        /// <summary>
        /// Gets or Sets PatchMinor
        /// </summary>
        [DataMember(Name="patch_minor", EmitDefaultValue=false)]
        public string PatchMinor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrowserOS {\n");
            sb.Append("  Family: ").Append(Family).Append("\n");
            sb.Append("  Major: ").Append(Major).Append("\n");
            sb.Append("  Minor: ").Append(Minor).Append("\n");
            sb.Append("  Patch: ").Append(Patch).Append("\n");
            sb.Append("  PatchMinor: ").Append(PatchMinor).Append("\n");
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
            return this.Equals(input as BrowserOS);
        }

        /// <summary>
        /// Returns true if BrowserOS instances are equal
        /// </summary>
        /// <param name="input">Instance of BrowserOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrowserOS input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Family == input.Family ||
                    (this.Family != null &&
                    this.Family.Equals(input.Family))
                ) && 
                (
                    this.Major == input.Major ||
                    (this.Major != null &&
                    this.Major.Equals(input.Major))
                ) && 
                (
                    this.Minor == input.Minor ||
                    (this.Minor != null &&
                    this.Minor.Equals(input.Minor))
                ) && 
                (
                    this.Patch == input.Patch ||
                    (this.Patch != null &&
                    this.Patch.Equals(input.Patch))
                ) && 
                (
                    this.PatchMinor == input.PatchMinor ||
                    (this.PatchMinor != null &&
                    this.PatchMinor.Equals(input.PatchMinor))
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
                if (this.Family != null)
                    hashCode = hashCode * 59 + this.Family.GetHashCode();
                if (this.Major != null)
                    hashCode = hashCode * 59 + this.Major.GetHashCode();
                if (this.Minor != null)
                    hashCode = hashCode * 59 + this.Minor.GetHashCode();
                if (this.Patch != null)
                    hashCode = hashCode * 59 + this.Patch.GetHashCode();
                if (this.PatchMinor != null)
                    hashCode = hashCode * 59 + this.PatchMinor.GetHashCode();
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
