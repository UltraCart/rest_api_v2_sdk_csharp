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
    /// LibraryItemAccount
    /// </summary>
    [DataContract]
    public partial class LibraryItemAccount :  IEquatable<LibraryItemAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryItemAccount" /> class.
        /// </summary>
        /// <param name="libraryItemAccountOid">libraryItemAccountOid.</param>
        /// <param name="libraryItemOid">libraryItemOid.</param>
        /// <param name="otherMerchantId">otherMerchantId.</param>
        public LibraryItemAccount(int libraryItemAccountOid = default(int), int libraryItemOid = default(int), string otherMerchantId = default(string))
        {
            this.LibraryItemAccountOid = libraryItemAccountOid;
            this.LibraryItemOid = libraryItemOid;
            this.OtherMerchantId = otherMerchantId;
        }

        /// <summary>
        /// Gets or Sets LibraryItemAccountOid
        /// </summary>
        [DataMember(Name="library_item_account_oid", EmitDefaultValue=false)]
        public int LibraryItemAccountOid { get; set; }

        /// <summary>
        /// Gets or Sets LibraryItemOid
        /// </summary>
        [DataMember(Name="library_item_oid", EmitDefaultValue=false)]
        public int LibraryItemOid { get; set; }

        /// <summary>
        /// Gets or Sets OtherMerchantId
        /// </summary>
        [DataMember(Name="other_merchant_id", EmitDefaultValue=false)]
        public string OtherMerchantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LibraryItemAccount {\n");
            sb.Append("  LibraryItemAccountOid: ").Append(LibraryItemAccountOid).Append("\n");
            sb.Append("  LibraryItemOid: ").Append(LibraryItemOid).Append("\n");
            sb.Append("  OtherMerchantId: ").Append(OtherMerchantId).Append("\n");
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
            return this.Equals(input as LibraryItemAccount);
        }

        /// <summary>
        /// Returns true if LibraryItemAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of LibraryItemAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LibraryItemAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LibraryItemAccountOid == input.LibraryItemAccountOid ||
                    (this.LibraryItemAccountOid != null &&
                    this.LibraryItemAccountOid.Equals(input.LibraryItemAccountOid))
                ) && 
                (
                    this.LibraryItemOid == input.LibraryItemOid ||
                    (this.LibraryItemOid != null &&
                    this.LibraryItemOid.Equals(input.LibraryItemOid))
                ) && 
                (
                    this.OtherMerchantId == input.OtherMerchantId ||
                    (this.OtherMerchantId != null &&
                    this.OtherMerchantId.Equals(input.OtherMerchantId))
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
                if (this.LibraryItemAccountOid != null)
                    hashCode = hashCode * 59 + this.LibraryItemAccountOid.GetHashCode();
                if (this.LibraryItemOid != null)
                    hashCode = hashCode * 59 + this.LibraryItemOid.GetHashCode();
                if (this.OtherMerchantId != null)
                    hashCode = hashCode * 59 + this.OtherMerchantId.GetHashCode();
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
