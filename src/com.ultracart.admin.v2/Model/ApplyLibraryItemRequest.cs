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
    /// ApplyLibraryItemRequest
    /// </summary>
    [DataContract]
    public partial class ApplyLibraryItemRequest :  IEquatable<ApplyLibraryItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyLibraryItemRequest" /> class.
        /// </summary>
        /// <param name="emailUuid">Normal emails are applied to an existing email object, so when requesting a library item to be applied to an email, supply the email uuid.  This is only for normal emails.  Transactional emails do not have a uuid..</param>
        /// <param name="libraryItemOid">Library item oid that you wish to apply to the given StoreFront.</param>
        /// <param name="postcardUuid">The postcard uuid you wish to apply to a given StoreFront..</param>
        /// <param name="storefrontOid">StoreFront oid where content originates necessary for tracking down relative assets.</param>
        public ApplyLibraryItemRequest(string emailUuid = default(string), int libraryItemOid = default(int), string postcardUuid = default(string), int storefrontOid = default(int))
        {
            this.EmailUuid = emailUuid;
            this.LibraryItemOid = libraryItemOid;
            this.PostcardUuid = postcardUuid;
            this.StorefrontOid = storefrontOid;
        }

        /// <summary>
        /// Normal emails are applied to an existing email object, so when requesting a library item to be applied to an email, supply the email uuid.  This is only for normal emails.  Transactional emails do not have a uuid.
        /// </summary>
        /// <value>Normal emails are applied to an existing email object, so when requesting a library item to be applied to an email, supply the email uuid.  This is only for normal emails.  Transactional emails do not have a uuid.</value>
        [DataMember(Name="email_uuid", EmitDefaultValue=false)]
        public string EmailUuid { get; set; }

        /// <summary>
        /// Library item oid that you wish to apply to the given StoreFront
        /// </summary>
        /// <value>Library item oid that you wish to apply to the given StoreFront</value>
        [DataMember(Name="library_item_oid", EmitDefaultValue=false)]
        public int LibraryItemOid { get; set; }

        /// <summary>
        /// The postcard uuid you wish to apply to a given StoreFront.
        /// </summary>
        /// <value>The postcard uuid you wish to apply to a given StoreFront.</value>
        [DataMember(Name="postcard_uuid", EmitDefaultValue=false)]
        public string PostcardUuid { get; set; }

        /// <summary>
        /// StoreFront oid where content originates necessary for tracking down relative assets
        /// </summary>
        /// <value>StoreFront oid where content originates necessary for tracking down relative assets</value>
        [DataMember(Name="storefront_oid", EmitDefaultValue=false)]
        public int StorefrontOid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyLibraryItemRequest {\n");
            sb.Append("  EmailUuid: ").Append(EmailUuid).Append("\n");
            sb.Append("  LibraryItemOid: ").Append(LibraryItemOid).Append("\n");
            sb.Append("  PostcardUuid: ").Append(PostcardUuid).Append("\n");
            sb.Append("  StorefrontOid: ").Append(StorefrontOid).Append("\n");
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
            return this.Equals(input as ApplyLibraryItemRequest);
        }

        /// <summary>
        /// Returns true if ApplyLibraryItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplyLibraryItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplyLibraryItemRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailUuid == input.EmailUuid ||
                    (this.EmailUuid != null &&
                    this.EmailUuid.Equals(input.EmailUuid))
                ) && 
                (
                    this.LibraryItemOid == input.LibraryItemOid ||
                    (this.LibraryItemOid != null &&
                    this.LibraryItemOid.Equals(input.LibraryItemOid))
                ) && 
                (
                    this.PostcardUuid == input.PostcardUuid ||
                    (this.PostcardUuid != null &&
                    this.PostcardUuid.Equals(input.PostcardUuid))
                ) && 
                (
                    this.StorefrontOid == input.StorefrontOid ||
                    (this.StorefrontOid != null &&
                    this.StorefrontOid.Equals(input.StorefrontOid))
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
                if (this.EmailUuid != null)
                    hashCode = hashCode * 59 + this.EmailUuid.GetHashCode();
                if (this.LibraryItemOid != null)
                    hashCode = hashCode * 59 + this.LibraryItemOid.GetHashCode();
                if (this.PostcardUuid != null)
                    hashCode = hashCode * 59 + this.PostcardUuid.GetHashCode();
                if (this.StorefrontOid != null)
                    hashCode = hashCode * 59 + this.StorefrontOid.GetHashCode();
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
