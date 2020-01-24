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
    /// ItemWishlistMember
    /// </summary>
    [DataContract]
    public partial class ItemWishlistMember :  IEquatable<ItemWishlistMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemWishlistMember" /> class.
        /// </summary>
        /// <param name="WishlistMemberInstanceDescription">WishList Member instance description.</param>
        /// <param name="WishlistMemberInstanceOid">WishList Member instance object identifier.</param>
        /// <param name="WishlistMemberSku">WishList Member SKU.</param>
        public ItemWishlistMember(string WishlistMemberInstanceDescription = default(string), int? WishlistMemberInstanceOid = default(int?), string WishlistMemberSku = default(string))
        {
            this.WishlistMemberInstanceDescription = WishlistMemberInstanceDescription;
            this.WishlistMemberInstanceOid = WishlistMemberInstanceOid;
            this.WishlistMemberSku = WishlistMemberSku;
        }
        
        /// <summary>
        /// WishList Member instance description
        /// </summary>
        /// <value>WishList Member instance description</value>
        [DataMember(Name="wishlist_member_instance_description", EmitDefaultValue=false)]
        public string WishlistMemberInstanceDescription { get; set; }

        /// <summary>
        /// WishList Member instance object identifier
        /// </summary>
        /// <value>WishList Member instance object identifier</value>
        [DataMember(Name="wishlist_member_instance_oid", EmitDefaultValue=false)]
        public int? WishlistMemberInstanceOid { get; set; }

        /// <summary>
        /// WishList Member SKU
        /// </summary>
        /// <value>WishList Member SKU</value>
        [DataMember(Name="wishlist_member_sku", EmitDefaultValue=false)]
        public string WishlistMemberSku { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemWishlistMember {\n");
            sb.Append("  WishlistMemberInstanceDescription: ").Append(WishlistMemberInstanceDescription).Append("\n");
            sb.Append("  WishlistMemberInstanceOid: ").Append(WishlistMemberInstanceOid).Append("\n");
            sb.Append("  WishlistMemberSku: ").Append(WishlistMemberSku).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as ItemWishlistMember);
        }

        /// <summary>
        /// Returns true if ItemWishlistMember instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemWishlistMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemWishlistMember input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WishlistMemberInstanceDescription == input.WishlistMemberInstanceDescription ||
                    (this.WishlistMemberInstanceDescription != null &&
                    this.WishlistMemberInstanceDescription.Equals(input.WishlistMemberInstanceDescription))
                ) && 
                (
                    this.WishlistMemberInstanceOid == input.WishlistMemberInstanceOid ||
                    (this.WishlistMemberInstanceOid != null &&
                    this.WishlistMemberInstanceOid.Equals(input.WishlistMemberInstanceOid))
                ) && 
                (
                    this.WishlistMemberSku == input.WishlistMemberSku ||
                    (this.WishlistMemberSku != null &&
                    this.WishlistMemberSku.Equals(input.WishlistMemberSku))
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
                if (this.WishlistMemberInstanceDescription != null)
                    hashCode = hashCode * 59 + this.WishlistMemberInstanceDescription.GetHashCode();
                if (this.WishlistMemberInstanceOid != null)
                    hashCode = hashCode * 59 + this.WishlistMemberInstanceOid.GetHashCode();
                if (this.WishlistMemberSku != null)
                    hashCode = hashCode * 59 + this.WishlistMemberSku.GetHashCode();
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
            // WishlistMemberSku (string) maxLength
            if(this.WishlistMemberSku != null && this.WishlistMemberSku.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WishlistMemberSku, length must be less than 25.", new [] { "WishlistMemberSku" });
            }

            yield break;
        }
    }

}
