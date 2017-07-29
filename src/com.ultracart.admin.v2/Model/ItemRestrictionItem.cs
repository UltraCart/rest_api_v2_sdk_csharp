/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
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
    /// ItemRestrictionItem
    /// </summary>
    [DataContract]
    public partial class ItemRestrictionItem :  IEquatable<ItemRestrictionItem>, IValidatableObject
    {
        /// <summary>
        /// Restriction type
        /// </summary>
        /// <value>Restriction type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Cannotbepurchasedwith for "can not be purchased with"
            /// </summary>
            [EnumMember(Value = "can not be purchased with")]
            Cannotbepurchasedwith,
            
            /// <summary>
            /// Enum Canonlybepurchasedwith for "can only be purchased with"
            /// </summary>
            [EnumMember(Value = "can only be purchased with")]
            Canonlybepurchasedwith,
            
            /// <summary>
            /// Enum Mustbepurchasedwith for "must be purchased with"
            /// </summary>
            [EnumMember(Value = "must be purchased with")]
            Mustbepurchasedwith
        }

        /// <summary>
        /// Restriction type
        /// </summary>
        /// <value>Restriction type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRestrictionItem" /> class.
        /// </summary>
        /// <param name="RestrictMerchantItemId">Restrict item id.</param>
        /// <param name="RestrictMerchantItemOid">Restrict item object identifier.</param>
        /// <param name="Type">Restriction type.</param>
        public ItemRestrictionItem(string RestrictMerchantItemId = default(string), int? RestrictMerchantItemOid = default(int?), TypeEnum? Type = default(TypeEnum?))
        {
            this.RestrictMerchantItemId = RestrictMerchantItemId;
            this.RestrictMerchantItemOid = RestrictMerchantItemOid;
            this.Type = Type;
        }
        
        /// <summary>
        /// Restrict item id
        /// </summary>
        /// <value>Restrict item id</value>
        [DataMember(Name="restrict_merchant_item_id", EmitDefaultValue=false)]
        public string RestrictMerchantItemId { get; set; }

        /// <summary>
        /// Restrict item object identifier
        /// </summary>
        /// <value>Restrict item object identifier</value>
        [DataMember(Name="restrict_merchant_item_oid", EmitDefaultValue=false)]
        public int? RestrictMerchantItemOid { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemRestrictionItem {\n");
            sb.Append("  RestrictMerchantItemId: ").Append(RestrictMerchantItemId).Append("\n");
            sb.Append("  RestrictMerchantItemOid: ").Append(RestrictMerchantItemOid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ItemRestrictionItem);
        }

        /// <summary>
        /// Returns true if ItemRestrictionItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemRestrictionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemRestrictionItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RestrictMerchantItemId == other.RestrictMerchantItemId ||
                    this.RestrictMerchantItemId != null &&
                    this.RestrictMerchantItemId.Equals(other.RestrictMerchantItemId)
                ) && 
                (
                    this.RestrictMerchantItemOid == other.RestrictMerchantItemOid ||
                    this.RestrictMerchantItemOid != null &&
                    this.RestrictMerchantItemOid.Equals(other.RestrictMerchantItemOid)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.RestrictMerchantItemId != null)
                    hash = hash * 59 + this.RestrictMerchantItemId.GetHashCode();
                if (this.RestrictMerchantItemOid != null)
                    hash = hash * 59 + this.RestrictMerchantItemOid.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
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
