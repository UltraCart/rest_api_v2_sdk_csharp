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
    /// LibraryItemAsset
    /// </summary>
    [DataContract]
    public partial class LibraryItemAsset :  IEquatable<LibraryItemAsset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryItemAsset" /> class.
        /// </summary>
        /// <param name="mimeType">mimeType.</param>
        /// <param name="url">url.</param>
        public LibraryItemAsset(string mimeType = default(string), string url = default(string))
        {
            this.MimeType = mimeType;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name="mime_type", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LibraryItemAsset {\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as LibraryItemAsset);
        }

        /// <summary>
        /// Returns true if LibraryItemAsset instances are equal
        /// </summary>
        /// <param name="input">Instance of LibraryItemAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LibraryItemAsset input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
