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
    /// ItemKitComponent
    /// </summary>
    [DataContract]
    public partial class ItemKitComponent :  IEquatable<ItemKitComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemKitComponent" /> class.
        /// </summary>
        /// <param name="ComponentCost">Component item cost.</param>
        /// <param name="ComponentDescription">Component item description.</param>
        /// <param name="ComponentMerchantItemId">Component item ID.</param>
        /// <param name="ComponentMerchantItemOid">Component item object identifier.</param>
        /// <param name="Quantity">Quantity.</param>
        public ItemKitComponent(decimal? ComponentCost = default(decimal?), string ComponentDescription = default(string), string ComponentMerchantItemId = default(string), int? ComponentMerchantItemOid = default(int?), int? Quantity = default(int?))
        {
            this.ComponentCost = ComponentCost;
            this.ComponentDescription = ComponentDescription;
            this.ComponentMerchantItemId = ComponentMerchantItemId;
            this.ComponentMerchantItemOid = ComponentMerchantItemOid;
            this.Quantity = Quantity;
        }
        
        /// <summary>
        /// Component item cost
        /// </summary>
        /// <value>Component item cost</value>
        [DataMember(Name="component_cost", EmitDefaultValue=false)]
        public decimal? ComponentCost { get; set; }

        /// <summary>
        /// Component item description
        /// </summary>
        /// <value>Component item description</value>
        [DataMember(Name="component_description", EmitDefaultValue=false)]
        public string ComponentDescription { get; set; }

        /// <summary>
        /// Component item ID
        /// </summary>
        /// <value>Component item ID</value>
        [DataMember(Name="component_merchant_item_id", EmitDefaultValue=false)]
        public string ComponentMerchantItemId { get; set; }

        /// <summary>
        /// Component item object identifier
        /// </summary>
        /// <value>Component item object identifier</value>
        [DataMember(Name="component_merchant_item_oid", EmitDefaultValue=false)]
        public int? ComponentMerchantItemOid { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        /// <value>Quantity</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemKitComponent {\n");
            sb.Append("  ComponentCost: ").Append(ComponentCost).Append("\n");
            sb.Append("  ComponentDescription: ").Append(ComponentDescription).Append("\n");
            sb.Append("  ComponentMerchantItemId: ").Append(ComponentMerchantItemId).Append("\n");
            sb.Append("  ComponentMerchantItemOid: ").Append(ComponentMerchantItemOid).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as ItemKitComponent);
        }

        /// <summary>
        /// Returns true if ItemKitComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemKitComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemKitComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComponentCost == input.ComponentCost ||
                    (this.ComponentCost != null &&
                    this.ComponentCost.Equals(input.ComponentCost))
                ) && 
                (
                    this.ComponentDescription == input.ComponentDescription ||
                    (this.ComponentDescription != null &&
                    this.ComponentDescription.Equals(input.ComponentDescription))
                ) && 
                (
                    this.ComponentMerchantItemId == input.ComponentMerchantItemId ||
                    (this.ComponentMerchantItemId != null &&
                    this.ComponentMerchantItemId.Equals(input.ComponentMerchantItemId))
                ) && 
                (
                    this.ComponentMerchantItemOid == input.ComponentMerchantItemOid ||
                    (this.ComponentMerchantItemOid != null &&
                    this.ComponentMerchantItemOid.Equals(input.ComponentMerchantItemOid))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.ComponentCost != null)
                    hashCode = hashCode * 59 + this.ComponentCost.GetHashCode();
                if (this.ComponentDescription != null)
                    hashCode = hashCode * 59 + this.ComponentDescription.GetHashCode();
                if (this.ComponentMerchantItemId != null)
                    hashCode = hashCode * 59 + this.ComponentMerchantItemId.GetHashCode();
                if (this.ComponentMerchantItemOid != null)
                    hashCode = hashCode * 59 + this.ComponentMerchantItemOid.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
