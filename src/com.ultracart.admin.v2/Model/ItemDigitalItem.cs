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
    /// ItemDigitalItem
    /// </summary>
    [DataContract]
    public partial class ItemDigitalItem :  IEquatable<ItemDigitalItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDigitalItem" /> class.
        /// </summary>
        /// <param name="creationDts">File creation date.</param>
        /// <param name="description">Description of the digital item.</param>
        /// <param name="fileSize">File size.</param>
        /// <param name="mimeType">Mime type associated with the file.</param>
        /// <param name="originalFilename">Original filename.</param>
        public ItemDigitalItem(string creationDts = default(string), string description = default(string), long fileSize = default(long), string mimeType = default(string), string originalFilename = default(string))
        {
            this.CreationDts = creationDts;
            this.Description = description;
            this.FileSize = fileSize;
            this.MimeType = mimeType;
            this.OriginalFilename = originalFilename;
        }

        /// <summary>
        /// File creation date
        /// </summary>
        /// <value>File creation date</value>
        [DataMember(Name="creation_dts", EmitDefaultValue=false)]
        public string CreationDts { get; set; }

        /// <summary>
        /// Description of the digital item
        /// </summary>
        /// <value>Description of the digital item</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// File size
        /// </summary>
        /// <value>File size</value>
        [DataMember(Name="file_size", EmitDefaultValue=false)]
        public long FileSize { get; set; }

        /// <summary>
        /// Mime type associated with the file
        /// </summary>
        /// <value>Mime type associated with the file</value>
        [DataMember(Name="mime_type", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Original filename
        /// </summary>
        /// <value>Original filename</value>
        [DataMember(Name="original_filename", EmitDefaultValue=false)]
        public string OriginalFilename { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemDigitalItem {\n");
            sb.Append("  CreationDts: ").Append(CreationDts).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  OriginalFilename: ").Append(OriginalFilename).Append("\n");
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
            return this.Equals(input as ItemDigitalItem);
        }

        /// <summary>
        /// Returns true if ItemDigitalItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemDigitalItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemDigitalItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreationDts == input.CreationDts ||
                    (this.CreationDts != null &&
                    this.CreationDts.Equals(input.CreationDts))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    (this.FileSize != null &&
                    this.FileSize.Equals(input.FileSize))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.OriginalFilename == input.OriginalFilename ||
                    (this.OriginalFilename != null &&
                    this.OriginalFilename.Equals(input.OriginalFilename))
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
                if (this.CreationDts != null)
                    hashCode = hashCode * 59 + this.CreationDts.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FileSize != null)
                    hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.OriginalFilename != null)
                    hashCode = hashCode * 59 + this.OriginalFilename.GetHashCode();
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
            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 200.", new [] { "Description" });
            }


            // MimeType (string) maxLength
            if(this.MimeType != null && this.MimeType.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MimeType, length must be less than 100.", new [] { "MimeType" });
            }


            // OriginalFilename (string) maxLength
            if(this.OriginalFilename != null && this.OriginalFilename.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OriginalFilename, length must be less than 250.", new [] { "OriginalFilename" });
            }


            yield break;
        }
    }

}
