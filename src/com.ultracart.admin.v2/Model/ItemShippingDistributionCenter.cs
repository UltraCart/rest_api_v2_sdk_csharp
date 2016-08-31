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
    /// ItemShippingDistributionCenter
    /// </summary>
    [DataContract]
    public partial class ItemShippingDistributionCenter :  IEquatable<ItemShippingDistributionCenter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemShippingDistributionCenter" /> class.
        /// </summary>
        /// <param name="AllocatedToPlacedOrders">AllocatedToPlacedOrders.</param>
        /// <param name="AllocatedToShoppingCarts">AllocatedToShoppingCarts.</param>
        /// <param name="AvailableToAllocate">AvailableToAllocate.</param>
        /// <param name="DesiredInventoryLevel">DesiredInventoryLevel.</param>
        /// <param name="DistributionCenterCode">DistributionCenterCode.</param>
        /// <param name="DistributionCenterOid">DistributionCenterOid.</param>
        /// <param name="Eta">Eta.</param>
        /// <param name="Handles">Handles.</param>
        /// <param name="InventoryLevel">InventoryLevel.</param>
        /// <param name="MaximumBackorder">MaximumBackorder.</param>
        /// <param name="ReorderInventoryLevel">ReorderInventoryLevel.</param>
        /// <param name="Sku">Sku.</param>
        /// <param name="StockPickingLocation">StockPickingLocation.</param>
        public ItemShippingDistributionCenter(double? AllocatedToPlacedOrders = null, double? AllocatedToShoppingCarts = null, double? AvailableToAllocate = null, double? DesiredInventoryLevel = null, string DistributionCenterCode = null, int? DistributionCenterOid = null, string Eta = null, bool? Handles = null, double? InventoryLevel = null, int? MaximumBackorder = null, double? ReorderInventoryLevel = null, string Sku = null, string StockPickingLocation = null)
        {
            this.AllocatedToPlacedOrders = AllocatedToPlacedOrders;
            this.AllocatedToShoppingCarts = AllocatedToShoppingCarts;
            this.AvailableToAllocate = AvailableToAllocate;
            this.DesiredInventoryLevel = DesiredInventoryLevel;
            this.DistributionCenterCode = DistributionCenterCode;
            this.DistributionCenterOid = DistributionCenterOid;
            this.Eta = Eta;
            this.Handles = Handles;
            this.InventoryLevel = InventoryLevel;
            this.MaximumBackorder = MaximumBackorder;
            this.ReorderInventoryLevel = ReorderInventoryLevel;
            this.Sku = Sku;
            this.StockPickingLocation = StockPickingLocation;
        }
        
        /// <summary>
        /// Gets or Sets AllocatedToPlacedOrders
        /// </summary>
        [DataMember(Name="allocated_to_placed_orders", EmitDefaultValue=false)]
        public double? AllocatedToPlacedOrders { get; set; }
        /// <summary>
        /// Gets or Sets AllocatedToShoppingCarts
        /// </summary>
        [DataMember(Name="allocated_to_shopping_carts", EmitDefaultValue=false)]
        public double? AllocatedToShoppingCarts { get; set; }
        /// <summary>
        /// Gets or Sets AvailableToAllocate
        /// </summary>
        [DataMember(Name="available_to_allocate", EmitDefaultValue=false)]
        public double? AvailableToAllocate { get; set; }
        /// <summary>
        /// Gets or Sets DesiredInventoryLevel
        /// </summary>
        [DataMember(Name="desired_inventory_level", EmitDefaultValue=false)]
        public double? DesiredInventoryLevel { get; set; }
        /// <summary>
        /// Gets or Sets DistributionCenterCode
        /// </summary>
        [DataMember(Name="distribution_center_code", EmitDefaultValue=false)]
        public string DistributionCenterCode { get; set; }
        /// <summary>
        /// Gets or Sets DistributionCenterOid
        /// </summary>
        [DataMember(Name="distribution_center_oid", EmitDefaultValue=false)]
        public int? DistributionCenterOid { get; set; }
        /// <summary>
        /// Gets or Sets Eta
        /// </summary>
        [DataMember(Name="eta", EmitDefaultValue=false)]
        public string Eta { get; set; }
        /// <summary>
        /// Gets or Sets Handles
        /// </summary>
        [DataMember(Name="handles", EmitDefaultValue=false)]
        public bool? Handles { get; set; }
        /// <summary>
        /// Gets or Sets InventoryLevel
        /// </summary>
        [DataMember(Name="inventory_level", EmitDefaultValue=false)]
        public double? InventoryLevel { get; set; }
        /// <summary>
        /// Gets or Sets MaximumBackorder
        /// </summary>
        [DataMember(Name="maximum_backorder", EmitDefaultValue=false)]
        public int? MaximumBackorder { get; set; }
        /// <summary>
        /// Gets or Sets ReorderInventoryLevel
        /// </summary>
        [DataMember(Name="reorder_inventory_level", EmitDefaultValue=false)]
        public double? ReorderInventoryLevel { get; set; }
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
        /// <summary>
        /// Gets or Sets StockPickingLocation
        /// </summary>
        [DataMember(Name="stock_picking_location", EmitDefaultValue=false)]
        public string StockPickingLocation { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemShippingDistributionCenter {\n");
            sb.Append("  AllocatedToPlacedOrders: ").Append(AllocatedToPlacedOrders).Append("\n");
            sb.Append("  AllocatedToShoppingCarts: ").Append(AllocatedToShoppingCarts).Append("\n");
            sb.Append("  AvailableToAllocate: ").Append(AvailableToAllocate).Append("\n");
            sb.Append("  DesiredInventoryLevel: ").Append(DesiredInventoryLevel).Append("\n");
            sb.Append("  DistributionCenterCode: ").Append(DistributionCenterCode).Append("\n");
            sb.Append("  DistributionCenterOid: ").Append(DistributionCenterOid).Append("\n");
            sb.Append("  Eta: ").Append(Eta).Append("\n");
            sb.Append("  Handles: ").Append(Handles).Append("\n");
            sb.Append("  InventoryLevel: ").Append(InventoryLevel).Append("\n");
            sb.Append("  MaximumBackorder: ").Append(MaximumBackorder).Append("\n");
            sb.Append("  ReorderInventoryLevel: ").Append(ReorderInventoryLevel).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  StockPickingLocation: ").Append(StockPickingLocation).Append("\n");
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
            return this.Equals(obj as ItemShippingDistributionCenter);
        }

        /// <summary>
        /// Returns true if ItemShippingDistributionCenter instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemShippingDistributionCenter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemShippingDistributionCenter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllocatedToPlacedOrders == other.AllocatedToPlacedOrders ||
                    this.AllocatedToPlacedOrders != null &&
                    this.AllocatedToPlacedOrders.Equals(other.AllocatedToPlacedOrders)
                ) && 
                (
                    this.AllocatedToShoppingCarts == other.AllocatedToShoppingCarts ||
                    this.AllocatedToShoppingCarts != null &&
                    this.AllocatedToShoppingCarts.Equals(other.AllocatedToShoppingCarts)
                ) && 
                (
                    this.AvailableToAllocate == other.AvailableToAllocate ||
                    this.AvailableToAllocate != null &&
                    this.AvailableToAllocate.Equals(other.AvailableToAllocate)
                ) && 
                (
                    this.DesiredInventoryLevel == other.DesiredInventoryLevel ||
                    this.DesiredInventoryLevel != null &&
                    this.DesiredInventoryLevel.Equals(other.DesiredInventoryLevel)
                ) && 
                (
                    this.DistributionCenterCode == other.DistributionCenterCode ||
                    this.DistributionCenterCode != null &&
                    this.DistributionCenterCode.Equals(other.DistributionCenterCode)
                ) && 
                (
                    this.DistributionCenterOid == other.DistributionCenterOid ||
                    this.DistributionCenterOid != null &&
                    this.DistributionCenterOid.Equals(other.DistributionCenterOid)
                ) && 
                (
                    this.Eta == other.Eta ||
                    this.Eta != null &&
                    this.Eta.Equals(other.Eta)
                ) && 
                (
                    this.Handles == other.Handles ||
                    this.Handles != null &&
                    this.Handles.Equals(other.Handles)
                ) && 
                (
                    this.InventoryLevel == other.InventoryLevel ||
                    this.InventoryLevel != null &&
                    this.InventoryLevel.Equals(other.InventoryLevel)
                ) && 
                (
                    this.MaximumBackorder == other.MaximumBackorder ||
                    this.MaximumBackorder != null &&
                    this.MaximumBackorder.Equals(other.MaximumBackorder)
                ) && 
                (
                    this.ReorderInventoryLevel == other.ReorderInventoryLevel ||
                    this.ReorderInventoryLevel != null &&
                    this.ReorderInventoryLevel.Equals(other.ReorderInventoryLevel)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.StockPickingLocation == other.StockPickingLocation ||
                    this.StockPickingLocation != null &&
                    this.StockPickingLocation.Equals(other.StockPickingLocation)
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
                if (this.AllocatedToPlacedOrders != null)
                    hash = hash * 59 + this.AllocatedToPlacedOrders.GetHashCode();
                if (this.AllocatedToShoppingCarts != null)
                    hash = hash * 59 + this.AllocatedToShoppingCarts.GetHashCode();
                if (this.AvailableToAllocate != null)
                    hash = hash * 59 + this.AvailableToAllocate.GetHashCode();
                if (this.DesiredInventoryLevel != null)
                    hash = hash * 59 + this.DesiredInventoryLevel.GetHashCode();
                if (this.DistributionCenterCode != null)
                    hash = hash * 59 + this.DistributionCenterCode.GetHashCode();
                if (this.DistributionCenterOid != null)
                    hash = hash * 59 + this.DistributionCenterOid.GetHashCode();
                if (this.Eta != null)
                    hash = hash * 59 + this.Eta.GetHashCode();
                if (this.Handles != null)
                    hash = hash * 59 + this.Handles.GetHashCode();
                if (this.InventoryLevel != null)
                    hash = hash * 59 + this.InventoryLevel.GetHashCode();
                if (this.MaximumBackorder != null)
                    hash = hash * 59 + this.MaximumBackorder.GetHashCode();
                if (this.ReorderInventoryLevel != null)
                    hash = hash * 59 + this.ReorderInventoryLevel.GetHashCode();
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                if (this.StockPickingLocation != null)
                    hash = hash * 59 + this.StockPickingLocation.GetHashCode();
                return hash;
            }
        }
    }

}
