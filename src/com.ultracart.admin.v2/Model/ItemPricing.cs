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
    /// ItemPricing
    /// </summary>
    [DataContract]
    public partial class ItemPricing :  IEquatable<ItemPricing>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPricing" /> class.
        /// </summary>
        /// <param name="AllowArbitraryCost">AllowArbitraryCost.</param>
        /// <param name="ArbitraryCostVelocityCode">ArbitraryCostVelocityCode.</param>
        /// <param name="AutomaticPricingTierName">AutomaticPricingTierName.</param>
        /// <param name="AutomaticPricingTierOid">AutomaticPricingTierOid.</param>
        /// <param name="Cogs">Cogs.</param>
        /// <param name="Cost">Cost.</param>
        /// <param name="CurrencyCode">CurrencyCode.</param>
        /// <param name="ManufacturerSuggestedRetailPrice">ManufacturerSuggestedRetailPrice.</param>
        /// <param name="MaximumArbitraryCost">MaximumArbitraryCost.</param>
        /// <param name="MinimumAdvertisedPrice">MinimumAdvertisedPrice.</param>
        /// <param name="MinimumArbitraryCost">MinimumArbitraryCost.</param>
        /// <param name="MixAndMatchGroup">MixAndMatchGroup.</param>
        /// <param name="MixAndMatchGroupOid">MixAndMatchGroupOid.</param>
        /// <param name="SaleCost">SaleCost.</param>
        /// <param name="SaleEnd">SaleEnd.</param>
        /// <param name="SaleStart">SaleStart.</param>
        /// <param name="Tiers">Tiers.</param>
        public ItemPricing(bool? AllowArbitraryCost = null, string ArbitraryCostVelocityCode = null, string AutomaticPricingTierName = null, int? AutomaticPricingTierOid = null, double? Cogs = null, double? Cost = null, string CurrencyCode = null, double? ManufacturerSuggestedRetailPrice = null, double? MaximumArbitraryCost = null, double? MinimumAdvertisedPrice = null, double? MinimumArbitraryCost = null, string MixAndMatchGroup = null, int? MixAndMatchGroupOid = null, double? SaleCost = null, string SaleEnd = null, string SaleStart = null, List<ItemPricingTier> Tiers = null)
        {
            this.AllowArbitraryCost = AllowArbitraryCost;
            this.ArbitraryCostVelocityCode = ArbitraryCostVelocityCode;
            this.AutomaticPricingTierName = AutomaticPricingTierName;
            this.AutomaticPricingTierOid = AutomaticPricingTierOid;
            this.Cogs = Cogs;
            this.Cost = Cost;
            this.CurrencyCode = CurrencyCode;
            this.ManufacturerSuggestedRetailPrice = ManufacturerSuggestedRetailPrice;
            this.MaximumArbitraryCost = MaximumArbitraryCost;
            this.MinimumAdvertisedPrice = MinimumAdvertisedPrice;
            this.MinimumArbitraryCost = MinimumArbitraryCost;
            this.MixAndMatchGroup = MixAndMatchGroup;
            this.MixAndMatchGroupOid = MixAndMatchGroupOid;
            this.SaleCost = SaleCost;
            this.SaleEnd = SaleEnd;
            this.SaleStart = SaleStart;
            this.Tiers = Tiers;
        }
        
        /// <summary>
        /// Gets or Sets AllowArbitraryCost
        /// </summary>
        [DataMember(Name="allow_arbitrary_cost", EmitDefaultValue=false)]
        public bool? AllowArbitraryCost { get; set; }
        /// <summary>
        /// Gets or Sets ArbitraryCostVelocityCode
        /// </summary>
        [DataMember(Name="arbitrary_cost_velocity_code", EmitDefaultValue=false)]
        public string ArbitraryCostVelocityCode { get; set; }
        /// <summary>
        /// Gets or Sets AutomaticPricingTierName
        /// </summary>
        [DataMember(Name="automatic_pricing_tier_name", EmitDefaultValue=false)]
        public string AutomaticPricingTierName { get; set; }
        /// <summary>
        /// Gets or Sets AutomaticPricingTierOid
        /// </summary>
        [DataMember(Name="automatic_pricing_tier_oid", EmitDefaultValue=false)]
        public int? AutomaticPricingTierOid { get; set; }
        /// <summary>
        /// Gets or Sets Cogs
        /// </summary>
        [DataMember(Name="cogs", EmitDefaultValue=false)]
        public double? Cogs { get; set; }
        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public double? Cost { get; set; }
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Gets or Sets ManufacturerSuggestedRetailPrice
        /// </summary>
        [DataMember(Name="manufacturer_suggested_retail_price", EmitDefaultValue=false)]
        public double? ManufacturerSuggestedRetailPrice { get; set; }
        /// <summary>
        /// Gets or Sets MaximumArbitraryCost
        /// </summary>
        [DataMember(Name="maximum_arbitrary_cost", EmitDefaultValue=false)]
        public double? MaximumArbitraryCost { get; set; }
        /// <summary>
        /// Gets or Sets MinimumAdvertisedPrice
        /// </summary>
        [DataMember(Name="minimum_advertised_price", EmitDefaultValue=false)]
        public double? MinimumAdvertisedPrice { get; set; }
        /// <summary>
        /// Gets or Sets MinimumArbitraryCost
        /// </summary>
        [DataMember(Name="minimum_arbitrary_cost", EmitDefaultValue=false)]
        public double? MinimumArbitraryCost { get; set; }
        /// <summary>
        /// Gets or Sets MixAndMatchGroup
        /// </summary>
        [DataMember(Name="mix_and_match_group", EmitDefaultValue=false)]
        public string MixAndMatchGroup { get; set; }
        /// <summary>
        /// Gets or Sets MixAndMatchGroupOid
        /// </summary>
        [DataMember(Name="mix_and_match_group_oid", EmitDefaultValue=false)]
        public int? MixAndMatchGroupOid { get; set; }
        /// <summary>
        /// Gets or Sets SaleCost
        /// </summary>
        [DataMember(Name="sale_cost", EmitDefaultValue=false)]
        public double? SaleCost { get; set; }
        /// <summary>
        /// Gets or Sets SaleEnd
        /// </summary>
        [DataMember(Name="sale_end", EmitDefaultValue=false)]
        public string SaleEnd { get; set; }
        /// <summary>
        /// Gets or Sets SaleStart
        /// </summary>
        [DataMember(Name="sale_start", EmitDefaultValue=false)]
        public string SaleStart { get; set; }
        /// <summary>
        /// Gets or Sets Tiers
        /// </summary>
        [DataMember(Name="tiers", EmitDefaultValue=false)]
        public List<ItemPricingTier> Tiers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemPricing {\n");
            sb.Append("  AllowArbitraryCost: ").Append(AllowArbitraryCost).Append("\n");
            sb.Append("  ArbitraryCostVelocityCode: ").Append(ArbitraryCostVelocityCode).Append("\n");
            sb.Append("  AutomaticPricingTierName: ").Append(AutomaticPricingTierName).Append("\n");
            sb.Append("  AutomaticPricingTierOid: ").Append(AutomaticPricingTierOid).Append("\n");
            sb.Append("  Cogs: ").Append(Cogs).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ManufacturerSuggestedRetailPrice: ").Append(ManufacturerSuggestedRetailPrice).Append("\n");
            sb.Append("  MaximumArbitraryCost: ").Append(MaximumArbitraryCost).Append("\n");
            sb.Append("  MinimumAdvertisedPrice: ").Append(MinimumAdvertisedPrice).Append("\n");
            sb.Append("  MinimumArbitraryCost: ").Append(MinimumArbitraryCost).Append("\n");
            sb.Append("  MixAndMatchGroup: ").Append(MixAndMatchGroup).Append("\n");
            sb.Append("  MixAndMatchGroupOid: ").Append(MixAndMatchGroupOid).Append("\n");
            sb.Append("  SaleCost: ").Append(SaleCost).Append("\n");
            sb.Append("  SaleEnd: ").Append(SaleEnd).Append("\n");
            sb.Append("  SaleStart: ").Append(SaleStart).Append("\n");
            sb.Append("  Tiers: ").Append(Tiers).Append("\n");
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
            return this.Equals(obj as ItemPricing);
        }

        /// <summary>
        /// Returns true if ItemPricing instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemPricing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemPricing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowArbitraryCost == other.AllowArbitraryCost ||
                    this.AllowArbitraryCost != null &&
                    this.AllowArbitraryCost.Equals(other.AllowArbitraryCost)
                ) && 
                (
                    this.ArbitraryCostVelocityCode == other.ArbitraryCostVelocityCode ||
                    this.ArbitraryCostVelocityCode != null &&
                    this.ArbitraryCostVelocityCode.Equals(other.ArbitraryCostVelocityCode)
                ) && 
                (
                    this.AutomaticPricingTierName == other.AutomaticPricingTierName ||
                    this.AutomaticPricingTierName != null &&
                    this.AutomaticPricingTierName.Equals(other.AutomaticPricingTierName)
                ) && 
                (
                    this.AutomaticPricingTierOid == other.AutomaticPricingTierOid ||
                    this.AutomaticPricingTierOid != null &&
                    this.AutomaticPricingTierOid.Equals(other.AutomaticPricingTierOid)
                ) && 
                (
                    this.Cogs == other.Cogs ||
                    this.Cogs != null &&
                    this.Cogs.Equals(other.Cogs)
                ) && 
                (
                    this.Cost == other.Cost ||
                    this.Cost != null &&
                    this.Cost.Equals(other.Cost)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.ManufacturerSuggestedRetailPrice == other.ManufacturerSuggestedRetailPrice ||
                    this.ManufacturerSuggestedRetailPrice != null &&
                    this.ManufacturerSuggestedRetailPrice.Equals(other.ManufacturerSuggestedRetailPrice)
                ) && 
                (
                    this.MaximumArbitraryCost == other.MaximumArbitraryCost ||
                    this.MaximumArbitraryCost != null &&
                    this.MaximumArbitraryCost.Equals(other.MaximumArbitraryCost)
                ) && 
                (
                    this.MinimumAdvertisedPrice == other.MinimumAdvertisedPrice ||
                    this.MinimumAdvertisedPrice != null &&
                    this.MinimumAdvertisedPrice.Equals(other.MinimumAdvertisedPrice)
                ) && 
                (
                    this.MinimumArbitraryCost == other.MinimumArbitraryCost ||
                    this.MinimumArbitraryCost != null &&
                    this.MinimumArbitraryCost.Equals(other.MinimumArbitraryCost)
                ) && 
                (
                    this.MixAndMatchGroup == other.MixAndMatchGroup ||
                    this.MixAndMatchGroup != null &&
                    this.MixAndMatchGroup.Equals(other.MixAndMatchGroup)
                ) && 
                (
                    this.MixAndMatchGroupOid == other.MixAndMatchGroupOid ||
                    this.MixAndMatchGroupOid != null &&
                    this.MixAndMatchGroupOid.Equals(other.MixAndMatchGroupOid)
                ) && 
                (
                    this.SaleCost == other.SaleCost ||
                    this.SaleCost != null &&
                    this.SaleCost.Equals(other.SaleCost)
                ) && 
                (
                    this.SaleEnd == other.SaleEnd ||
                    this.SaleEnd != null &&
                    this.SaleEnd.Equals(other.SaleEnd)
                ) && 
                (
                    this.SaleStart == other.SaleStart ||
                    this.SaleStart != null &&
                    this.SaleStart.Equals(other.SaleStart)
                ) && 
                (
                    this.Tiers == other.Tiers ||
                    this.Tiers != null &&
                    this.Tiers.SequenceEqual(other.Tiers)
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
                if (this.AllowArbitraryCost != null)
                    hash = hash * 59 + this.AllowArbitraryCost.GetHashCode();
                if (this.ArbitraryCostVelocityCode != null)
                    hash = hash * 59 + this.ArbitraryCostVelocityCode.GetHashCode();
                if (this.AutomaticPricingTierName != null)
                    hash = hash * 59 + this.AutomaticPricingTierName.GetHashCode();
                if (this.AutomaticPricingTierOid != null)
                    hash = hash * 59 + this.AutomaticPricingTierOid.GetHashCode();
                if (this.Cogs != null)
                    hash = hash * 59 + this.Cogs.GetHashCode();
                if (this.Cost != null)
                    hash = hash * 59 + this.Cost.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.ManufacturerSuggestedRetailPrice != null)
                    hash = hash * 59 + this.ManufacturerSuggestedRetailPrice.GetHashCode();
                if (this.MaximumArbitraryCost != null)
                    hash = hash * 59 + this.MaximumArbitraryCost.GetHashCode();
                if (this.MinimumAdvertisedPrice != null)
                    hash = hash * 59 + this.MinimumAdvertisedPrice.GetHashCode();
                if (this.MinimumArbitraryCost != null)
                    hash = hash * 59 + this.MinimumArbitraryCost.GetHashCode();
                if (this.MixAndMatchGroup != null)
                    hash = hash * 59 + this.MixAndMatchGroup.GetHashCode();
                if (this.MixAndMatchGroupOid != null)
                    hash = hash * 59 + this.MixAndMatchGroupOid.GetHashCode();
                if (this.SaleCost != null)
                    hash = hash * 59 + this.SaleCost.GetHashCode();
                if (this.SaleEnd != null)
                    hash = hash * 59 + this.SaleEnd.GetHashCode();
                if (this.SaleStart != null)
                    hash = hash * 59 + this.SaleStart.GetHashCode();
                if (this.Tiers != null)
                    hash = hash * 59 + this.Tiers.GetHashCode();
                return hash;
            }
        }
    }

}
