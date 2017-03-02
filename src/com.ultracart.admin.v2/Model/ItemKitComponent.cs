/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
 *
 * OpenAPI spec version: 2.0.0
 * Contact: support@ultracart.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace com.ultracart.admin.v2.Model
{
    /// <summary>
    /// ItemKitComponent
    /// </summary>
    [DataContract]
    public partial class ItemKitComponent :  IEquatable<ItemKitComponent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemKitComponent" /> class.
        /// </summary>
        /// <param name="ComponentCost">Component item cost.</param>
        /// <param name="ComponentDescription">Component item description.</param>
        /// <param name="ComponentMerchantItemId">Component item ID.</param>
        /// <param name="ComponentMerchantItemOid">Component item object identifier.</param>
        /// <param name="Quantity">Quantity.</param>
        public ItemKitComponent(decimal? ComponentCost = null, string ComponentDescription = null, string ComponentMerchantItemId = null, int? ComponentMerchantItemOid = null, int? Quantity = null)
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ItemKitComponent);
        }

        /// <summary>
        /// Returns true if ItemKitComponent instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemKitComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemKitComponent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ComponentCost == other.ComponentCost ||
                    this.ComponentCost != null &&
                    this.ComponentCost.Equals(other.ComponentCost)
                ) && 
                (
                    this.ComponentDescription == other.ComponentDescription ||
                    this.ComponentDescription != null &&
                    this.ComponentDescription.Equals(other.ComponentDescription)
                ) && 
                (
                    this.ComponentMerchantItemId == other.ComponentMerchantItemId ||
                    this.ComponentMerchantItemId != null &&
                    this.ComponentMerchantItemId.Equals(other.ComponentMerchantItemId)
                ) && 
                (
                    this.ComponentMerchantItemOid == other.ComponentMerchantItemOid ||
                    this.ComponentMerchantItemOid != null &&
                    this.ComponentMerchantItemOid.Equals(other.ComponentMerchantItemOid)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
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
                if (this.ComponentCost != null)
                    hash = hash * 59 + this.ComponentCost.GetHashCode();
                if (this.ComponentDescription != null)
                    hash = hash * 59 + this.ComponentDescription.GetHashCode();
                if (this.ComponentMerchantItemId != null)
                    hash = hash * 59 + this.ComponentMerchantItemId.GetHashCode();
                if (this.ComponentMerchantItemOid != null)
                    hash = hash * 59 + this.ComponentMerchantItemOid.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                return hash;
            }
        }
    }

}
