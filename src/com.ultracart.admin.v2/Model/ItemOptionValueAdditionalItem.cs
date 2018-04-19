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
    /// ItemOptionValueAdditionalItem
    /// </summary>
    [DataContract]
    public partial class ItemOptionValueAdditionalItem :  IEquatable<ItemOptionValueAdditionalItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemOptionValueAdditionalItem" /> class.
        /// </summary>
        /// <param name="AdditionalMerchantItemId">Additional item id.</param>
        /// <param name="AdditionalMerchantItemOid">Additional item object identifier.</param>
        public ItemOptionValueAdditionalItem(string AdditionalMerchantItemId = default(string), int? AdditionalMerchantItemOid = default(int?))
        {
            this.AdditionalMerchantItemId = AdditionalMerchantItemId;
            this.AdditionalMerchantItemOid = AdditionalMerchantItemOid;
        }
        
        /// <summary>
        /// Additional item id
        /// </summary>
        /// <value>Additional item id</value>
        [DataMember(Name="additional_merchant_item_id", EmitDefaultValue=false)]
        public string AdditionalMerchantItemId { get; set; }

        /// <summary>
        /// Additional item object identifier
        /// </summary>
        /// <value>Additional item object identifier</value>
        [DataMember(Name="additional_merchant_item_oid", EmitDefaultValue=false)]
        public int? AdditionalMerchantItemOid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemOptionValueAdditionalItem {\n");
            sb.Append("  AdditionalMerchantItemId: ").Append(AdditionalMerchantItemId).Append("\n");
            sb.Append("  AdditionalMerchantItemOid: ").Append(AdditionalMerchantItemOid).Append("\n");
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
            return this.Equals(input as ItemOptionValueAdditionalItem);
        }

        /// <summary>
        /// Returns true if ItemOptionValueAdditionalItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemOptionValueAdditionalItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemOptionValueAdditionalItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalMerchantItemId == input.AdditionalMerchantItemId ||
                    (this.AdditionalMerchantItemId != null &&
                    this.AdditionalMerchantItemId.Equals(input.AdditionalMerchantItemId))
                ) && 
                (
                    this.AdditionalMerchantItemOid == input.AdditionalMerchantItemOid ||
                    (this.AdditionalMerchantItemOid != null &&
                    this.AdditionalMerchantItemOid.Equals(input.AdditionalMerchantItemOid))
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
                if (this.AdditionalMerchantItemId != null)
                    hashCode = hashCode * 59 + this.AdditionalMerchantItemId.GetHashCode();
                if (this.AdditionalMerchantItemOid != null)
                    hashCode = hashCode * 59 + this.AdditionalMerchantItemOid.GetHashCode();
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
