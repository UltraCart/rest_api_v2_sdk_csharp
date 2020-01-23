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
    /// ItemPricing
    /// </summary>
    [DataContract]
    public partial class ItemPricing :  IEquatable<ItemPricing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPricing" /> class.
        /// </summary>
        /// <param name="AllowArbitraryCost">Allow arbitrary cost.</param>
        /// <param name="ArbitraryCostVelocityCode">Arbitrary cost velocity code.</param>
        /// <param name="AutomaticPricingTierName">Automatic pricing tier name.</param>
        /// <param name="AutomaticPricingTierOid">Automatic pricing tier object identifier.</param>
        /// <param name="Cogs">Cost of goods sold.</param>
        /// <param name="Cost">Cost.</param>
        /// <param name="CurrencyCode">Currency code.</param>
        /// <param name="ManufacturerSuggestedRetailPrice">Manufacturer suggested retail price.</param>
        /// <param name="MaximumArbitraryCost">Maximum arbitrary cost.</param>
        /// <param name="MinimumAdvertisedPrice">Minimum advertised price.</param>
        /// <param name="MinimumArbitraryCost">Minimum arbitrary cost.</param>
        /// <param name="MixAndMatchGroup">Mix and match group.</param>
        /// <param name="MixAndMatchGroupOid">Mix and match group object identifier.</param>
        /// <param name="SaleCost">Sale cost.</param>
        /// <param name="SaleEnd">Sale end.</param>
        /// <param name="SaleStart">Sale start.</param>
        /// <param name="Tiers">Tiers.</param>
        public ItemPricing(bool? AllowArbitraryCost = default(bool?), string ArbitraryCostVelocityCode = default(string), string AutomaticPricingTierName = default(string), int? AutomaticPricingTierOid = default(int?), decimal? Cogs = default(decimal?), decimal? Cost = default(decimal?), string CurrencyCode = default(string), decimal? ManufacturerSuggestedRetailPrice = default(decimal?), decimal? MaximumArbitraryCost = default(decimal?), decimal? MinimumAdvertisedPrice = default(decimal?), decimal? MinimumArbitraryCost = default(decimal?), string MixAndMatchGroup = default(string), int? MixAndMatchGroupOid = default(int?), decimal? SaleCost = default(decimal?), string SaleEnd = default(string), string SaleStart = default(string), List<ItemPricingTier> Tiers = default(List<ItemPricingTier>))
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
        /// Allow arbitrary cost
        /// </summary>
        /// <value>Allow arbitrary cost</value>
        [DataMember(Name="allow_arbitrary_cost", EmitDefaultValue=false)]
        public bool? AllowArbitraryCost { get; set; }

        /// <summary>
        /// Arbitrary cost velocity code
        /// </summary>
        /// <value>Arbitrary cost velocity code</value>
        [DataMember(Name="arbitrary_cost_velocity_code", EmitDefaultValue=false)]
        public string ArbitraryCostVelocityCode { get; set; }

        /// <summary>
        /// Automatic pricing tier name
        /// </summary>
        /// <value>Automatic pricing tier name</value>
        [DataMember(Name="automatic_pricing_tier_name", EmitDefaultValue=false)]
        public string AutomaticPricingTierName { get; set; }

        /// <summary>
        /// Automatic pricing tier object identifier
        /// </summary>
        /// <value>Automatic pricing tier object identifier</value>
        [DataMember(Name="automatic_pricing_tier_oid", EmitDefaultValue=false)]
        public int? AutomaticPricingTierOid { get; set; }

        /// <summary>
        /// Cost of goods sold
        /// </summary>
        /// <value>Cost of goods sold</value>
        [DataMember(Name="cogs", EmitDefaultValue=false)]
        public decimal? Cogs { get; set; }

        /// <summary>
        /// Cost
        /// </summary>
        /// <value>Cost</value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Currency code
        /// </summary>
        /// <value>Currency code</value>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Manufacturer suggested retail price
        /// </summary>
        /// <value>Manufacturer suggested retail price</value>
        [DataMember(Name="manufacturer_suggested_retail_price", EmitDefaultValue=false)]
        public decimal? ManufacturerSuggestedRetailPrice { get; set; }

        /// <summary>
        /// Maximum arbitrary cost
        /// </summary>
        /// <value>Maximum arbitrary cost</value>
        [DataMember(Name="maximum_arbitrary_cost", EmitDefaultValue=false)]
        public decimal? MaximumArbitraryCost { get; set; }

        /// <summary>
        /// Minimum advertised price
        /// </summary>
        /// <value>Minimum advertised price</value>
        [DataMember(Name="minimum_advertised_price", EmitDefaultValue=false)]
        public decimal? MinimumAdvertisedPrice { get; set; }

        /// <summary>
        /// Minimum arbitrary cost
        /// </summary>
        /// <value>Minimum arbitrary cost</value>
        [DataMember(Name="minimum_arbitrary_cost", EmitDefaultValue=false)]
        public decimal? MinimumArbitraryCost { get; set; }

        /// <summary>
        /// Mix and match group
        /// </summary>
        /// <value>Mix and match group</value>
        [DataMember(Name="mix_and_match_group", EmitDefaultValue=false)]
        public string MixAndMatchGroup { get; set; }

        /// <summary>
        /// Mix and match group object identifier
        /// </summary>
        /// <value>Mix and match group object identifier</value>
        [DataMember(Name="mix_and_match_group_oid", EmitDefaultValue=false)]
        public int? MixAndMatchGroupOid { get; set; }

        /// <summary>
        /// Sale cost
        /// </summary>
        /// <value>Sale cost</value>
        [DataMember(Name="sale_cost", EmitDefaultValue=false)]
        public decimal? SaleCost { get; set; }

        /// <summary>
        /// Sale end
        /// </summary>
        /// <value>Sale end</value>
        [DataMember(Name="sale_end", EmitDefaultValue=false)]
        public string SaleEnd { get; set; }

        /// <summary>
        /// Sale start
        /// </summary>
        /// <value>Sale start</value>
        [DataMember(Name="sale_start", EmitDefaultValue=false)]
        public string SaleStart { get; set; }

        /// <summary>
        /// Tiers
        /// </summary>
        /// <value>Tiers</value>
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemPricing);
        }

        /// <summary>
        /// Returns true if ItemPricing instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemPricing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemPricing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowArbitraryCost == input.AllowArbitraryCost ||
                    (this.AllowArbitraryCost != null &&
                    this.AllowArbitraryCost.Equals(input.AllowArbitraryCost))
                ) && 
                (
                    this.ArbitraryCostVelocityCode == input.ArbitraryCostVelocityCode ||
                    (this.ArbitraryCostVelocityCode != null &&
                    this.ArbitraryCostVelocityCode.Equals(input.ArbitraryCostVelocityCode))
                ) && 
                (
                    this.AutomaticPricingTierName == input.AutomaticPricingTierName ||
                    (this.AutomaticPricingTierName != null &&
                    this.AutomaticPricingTierName.Equals(input.AutomaticPricingTierName))
                ) && 
                (
                    this.AutomaticPricingTierOid == input.AutomaticPricingTierOid ||
                    (this.AutomaticPricingTierOid != null &&
                    this.AutomaticPricingTierOid.Equals(input.AutomaticPricingTierOid))
                ) && 
                (
                    this.Cogs == input.Cogs ||
                    (this.Cogs != null &&
                    this.Cogs.Equals(input.Cogs))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.ManufacturerSuggestedRetailPrice == input.ManufacturerSuggestedRetailPrice ||
                    (this.ManufacturerSuggestedRetailPrice != null &&
                    this.ManufacturerSuggestedRetailPrice.Equals(input.ManufacturerSuggestedRetailPrice))
                ) && 
                (
                    this.MaximumArbitraryCost == input.MaximumArbitraryCost ||
                    (this.MaximumArbitraryCost != null &&
                    this.MaximumArbitraryCost.Equals(input.MaximumArbitraryCost))
                ) && 
                (
                    this.MinimumAdvertisedPrice == input.MinimumAdvertisedPrice ||
                    (this.MinimumAdvertisedPrice != null &&
                    this.MinimumAdvertisedPrice.Equals(input.MinimumAdvertisedPrice))
                ) && 
                (
                    this.MinimumArbitraryCost == input.MinimumArbitraryCost ||
                    (this.MinimumArbitraryCost != null &&
                    this.MinimumArbitraryCost.Equals(input.MinimumArbitraryCost))
                ) && 
                (
                    this.MixAndMatchGroup == input.MixAndMatchGroup ||
                    (this.MixAndMatchGroup != null &&
                    this.MixAndMatchGroup.Equals(input.MixAndMatchGroup))
                ) && 
                (
                    this.MixAndMatchGroupOid == input.MixAndMatchGroupOid ||
                    (this.MixAndMatchGroupOid != null &&
                    this.MixAndMatchGroupOid.Equals(input.MixAndMatchGroupOid))
                ) && 
                (
                    this.SaleCost == input.SaleCost ||
                    (this.SaleCost != null &&
                    this.SaleCost.Equals(input.SaleCost))
                ) && 
                (
                    this.SaleEnd == input.SaleEnd ||
                    (this.SaleEnd != null &&
                    this.SaleEnd.Equals(input.SaleEnd))
                ) && 
                (
                    this.SaleStart == input.SaleStart ||
                    (this.SaleStart != null &&
                    this.SaleStart.Equals(input.SaleStart))
                ) && 
                (
                    this.Tiers == input.Tiers ||
                    this.Tiers != null &&
                    this.Tiers.SequenceEqual(input.Tiers)
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
                if (this.AllowArbitraryCost != null)
                    hashCode = hashCode * 59 + this.AllowArbitraryCost.GetHashCode();
                if (this.ArbitraryCostVelocityCode != null)
                    hashCode = hashCode * 59 + this.ArbitraryCostVelocityCode.GetHashCode();
                if (this.AutomaticPricingTierName != null)
                    hashCode = hashCode * 59 + this.AutomaticPricingTierName.GetHashCode();
                if (this.AutomaticPricingTierOid != null)
                    hashCode = hashCode * 59 + this.AutomaticPricingTierOid.GetHashCode();
                if (this.Cogs != null)
                    hashCode = hashCode * 59 + this.Cogs.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.ManufacturerSuggestedRetailPrice != null)
                    hashCode = hashCode * 59 + this.ManufacturerSuggestedRetailPrice.GetHashCode();
                if (this.MaximumArbitraryCost != null)
                    hashCode = hashCode * 59 + this.MaximumArbitraryCost.GetHashCode();
                if (this.MinimumAdvertisedPrice != null)
                    hashCode = hashCode * 59 + this.MinimumAdvertisedPrice.GetHashCode();
                if (this.MinimumArbitraryCost != null)
                    hashCode = hashCode * 59 + this.MinimumArbitraryCost.GetHashCode();
                if (this.MixAndMatchGroup != null)
                    hashCode = hashCode * 59 + this.MixAndMatchGroup.GetHashCode();
                if (this.MixAndMatchGroupOid != null)
                    hashCode = hashCode * 59 + this.MixAndMatchGroupOid.GetHashCode();
                if (this.SaleCost != null)
                    hashCode = hashCode * 59 + this.SaleCost.GetHashCode();
                if (this.SaleEnd != null)
                    hashCode = hashCode * 59 + this.SaleEnd.GetHashCode();
                if (this.SaleStart != null)
                    hashCode = hashCode * 59 + this.SaleStart.GetHashCode();
                if (this.Tiers != null)
                    hashCode = hashCode * 59 + this.Tiers.GetHashCode();
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
            // ArbitraryCostVelocityCode (string) maxLength
            if(this.ArbitraryCostVelocityCode != null && this.ArbitraryCostVelocityCode.Length > 10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ArbitraryCostVelocityCode, length must be less than 10000.", new [] { "ArbitraryCostVelocityCode" });
            }

            // CurrencyCode (string) maxLength
            if(this.CurrencyCode != null && this.CurrencyCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrencyCode, length must be less than 3.", new [] { "CurrencyCode" });
            }

            yield break;
        }
    }

}
