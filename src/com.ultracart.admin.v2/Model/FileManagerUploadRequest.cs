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
    /// FileManagerUploadRequest
    /// </summary>
    [DataContract]
    public partial class FileManagerUploadRequest :  IEquatable<FileManagerUploadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileManagerUploadRequest" /> class.
        /// </summary>
        /// <param name="filename">filename.</param>
        /// <param name="key">key.</param>
        /// <param name="parentStorefrontFsDirectoryOid">parentStorefrontFsDirectoryOid.</param>
        public FileManagerUploadRequest(string filename = default(string), string key = default(string), int parentStorefrontFsDirectoryOid = default(int))
        {
            this.Filename = filename;
            this.Key = key;
            this.ParentStorefrontFsDirectoryOid = parentStorefrontFsDirectoryOid;
        }

        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets ParentStorefrontFsDirectoryOid
        /// </summary>
        [DataMember(Name="parent_storefront_fs_directory_oid", EmitDefaultValue=false)]
        public int ParentStorefrontFsDirectoryOid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileManagerUploadRequest {\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  ParentStorefrontFsDirectoryOid: ").Append(ParentStorefrontFsDirectoryOid).Append("\n");
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
            return this.Equals(input as FileManagerUploadRequest);
        }

        /// <summary>
        /// Returns true if FileManagerUploadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FileManagerUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileManagerUploadRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.ParentStorefrontFsDirectoryOid == input.ParentStorefrontFsDirectoryOid ||
                    (this.ParentStorefrontFsDirectoryOid != null &&
                    this.ParentStorefrontFsDirectoryOid.Equals(input.ParentStorefrontFsDirectoryOid))
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
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.ParentStorefrontFsDirectoryOid != null)
                    hashCode = hashCode * 59 + this.ParentStorefrontFsDirectoryOid.GetHashCode();
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
