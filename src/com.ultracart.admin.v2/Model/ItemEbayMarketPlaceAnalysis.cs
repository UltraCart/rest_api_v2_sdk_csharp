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
    /// ItemEbayMarketPlaceAnalysis
    /// </summary>
    [DataContract]
    public partial class ItemEbayMarketPlaceAnalysis :  IEquatable<ItemEbayMarketPlaceAnalysis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemEbayMarketPlaceAnalysis" /> class.
        /// </summary>
        /// <param name="AdjustedPrice">Adjusted price.</param>
        /// <param name="AdjustedShipping">Adjusted shipping.</param>
        /// <param name="AdjustedTotal">Adjusted total.</param>
        /// <param name="Cogs">Cost of goods sold.</param>
        /// <param name="FinalValueFee">Final value fee.</param>
        /// <param name="MinimumAdvertisedPrice">Minimum advertised price.</param>
        /// <param name="OtherListings">Other listings.</param>
        /// <param name="OurListing">OurListing.</param>
        /// <param name="Overhead">Overhead.</param>
        /// <param name="ProfitPotential">Profit potential.</param>
        public ItemEbayMarketPlaceAnalysis(decimal? AdjustedPrice = default(decimal?), decimal? AdjustedShipping = default(decimal?), decimal? AdjustedTotal = default(decimal?), decimal? Cogs = default(decimal?), decimal? FinalValueFee = default(decimal?), decimal? MinimumAdvertisedPrice = default(decimal?), List<ItemEbayMarketListing> OtherListings = default(List<ItemEbayMarketListing>), ItemEbayMarketListing OurListing = default(ItemEbayMarketListing), decimal? Overhead = default(decimal?), decimal? ProfitPotential = default(decimal?))
        {
            this.AdjustedPrice = AdjustedPrice;
            this.AdjustedShipping = AdjustedShipping;
            this.AdjustedTotal = AdjustedTotal;
            this.Cogs = Cogs;
            this.FinalValueFee = FinalValueFee;
            this.MinimumAdvertisedPrice = MinimumAdvertisedPrice;
            this.OtherListings = OtherListings;
            this.OurListing = OurListing;
            this.Overhead = Overhead;
            this.ProfitPotential = ProfitPotential;
        }
        
        /// <summary>
        /// Adjusted price
        /// </summary>
        /// <value>Adjusted price</value>
        [DataMember(Name="adjusted_price", EmitDefaultValue=false)]
        public decimal? AdjustedPrice { get; set; }

        /// <summary>
        /// Adjusted shipping
        /// </summary>
        /// <value>Adjusted shipping</value>
        [DataMember(Name="adjusted_shipping", EmitDefaultValue=false)]
        public decimal? AdjustedShipping { get; set; }

        /// <summary>
        /// Adjusted total
        /// </summary>
        /// <value>Adjusted total</value>
        [DataMember(Name="adjusted_total", EmitDefaultValue=false)]
        public decimal? AdjustedTotal { get; set; }

        /// <summary>
        /// Cost of goods sold
        /// </summary>
        /// <value>Cost of goods sold</value>
        [DataMember(Name="cogs", EmitDefaultValue=false)]
        public decimal? Cogs { get; set; }

        /// <summary>
        /// Final value fee
        /// </summary>
        /// <value>Final value fee</value>
        [DataMember(Name="final_value_fee", EmitDefaultValue=false)]
        public decimal? FinalValueFee { get; set; }

        /// <summary>
        /// Minimum advertised price
        /// </summary>
        /// <value>Minimum advertised price</value>
        [DataMember(Name="minimum_advertised_price", EmitDefaultValue=false)]
        public decimal? MinimumAdvertisedPrice { get; set; }

        /// <summary>
        /// Other listings
        /// </summary>
        /// <value>Other listings</value>
        [DataMember(Name="other_listings", EmitDefaultValue=false)]
        public List<ItemEbayMarketListing> OtherListings { get; set; }

        /// <summary>
        /// Gets or Sets OurListing
        /// </summary>
        [DataMember(Name="our_listing", EmitDefaultValue=false)]
        public ItemEbayMarketListing OurListing { get; set; }

        /// <summary>
        /// Overhead
        /// </summary>
        /// <value>Overhead</value>
        [DataMember(Name="overhead", EmitDefaultValue=false)]
        public decimal? Overhead { get; set; }

        /// <summary>
        /// Profit potential
        /// </summary>
        /// <value>Profit potential</value>
        [DataMember(Name="profit_potential", EmitDefaultValue=false)]
        public decimal? ProfitPotential { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemEbayMarketPlaceAnalysis {\n");
            sb.Append("  AdjustedPrice: ").Append(AdjustedPrice).Append("\n");
            sb.Append("  AdjustedShipping: ").Append(AdjustedShipping).Append("\n");
            sb.Append("  AdjustedTotal: ").Append(AdjustedTotal).Append("\n");
            sb.Append("  Cogs: ").Append(Cogs).Append("\n");
            sb.Append("  FinalValueFee: ").Append(FinalValueFee).Append("\n");
            sb.Append("  MinimumAdvertisedPrice: ").Append(MinimumAdvertisedPrice).Append("\n");
            sb.Append("  OtherListings: ").Append(OtherListings).Append("\n");
            sb.Append("  OurListing: ").Append(OurListing).Append("\n");
            sb.Append("  Overhead: ").Append(Overhead).Append("\n");
            sb.Append("  ProfitPotential: ").Append(ProfitPotential).Append("\n");
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
            return this.Equals(input as ItemEbayMarketPlaceAnalysis);
        }

        /// <summary>
        /// Returns true if ItemEbayMarketPlaceAnalysis instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemEbayMarketPlaceAnalysis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemEbayMarketPlaceAnalysis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdjustedPrice == input.AdjustedPrice ||
                    (this.AdjustedPrice != null &&
                    this.AdjustedPrice.Equals(input.AdjustedPrice))
                ) && 
                (
                    this.AdjustedShipping == input.AdjustedShipping ||
                    (this.AdjustedShipping != null &&
                    this.AdjustedShipping.Equals(input.AdjustedShipping))
                ) && 
                (
                    this.AdjustedTotal == input.AdjustedTotal ||
                    (this.AdjustedTotal != null &&
                    this.AdjustedTotal.Equals(input.AdjustedTotal))
                ) && 
                (
                    this.Cogs == input.Cogs ||
                    (this.Cogs != null &&
                    this.Cogs.Equals(input.Cogs))
                ) && 
                (
                    this.FinalValueFee == input.FinalValueFee ||
                    (this.FinalValueFee != null &&
                    this.FinalValueFee.Equals(input.FinalValueFee))
                ) && 
                (
                    this.MinimumAdvertisedPrice == input.MinimumAdvertisedPrice ||
                    (this.MinimumAdvertisedPrice != null &&
                    this.MinimumAdvertisedPrice.Equals(input.MinimumAdvertisedPrice))
                ) && 
                (
                    this.OtherListings == input.OtherListings ||
                    this.OtherListings != null &&
                    this.OtherListings.SequenceEqual(input.OtherListings)
                ) && 
                (
                    this.OurListing == input.OurListing ||
                    (this.OurListing != null &&
                    this.OurListing.Equals(input.OurListing))
                ) && 
                (
                    this.Overhead == input.Overhead ||
                    (this.Overhead != null &&
                    this.Overhead.Equals(input.Overhead))
                ) && 
                (
                    this.ProfitPotential == input.ProfitPotential ||
                    (this.ProfitPotential != null &&
                    this.ProfitPotential.Equals(input.ProfitPotential))
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
                if (this.AdjustedPrice != null)
                    hashCode = hashCode * 59 + this.AdjustedPrice.GetHashCode();
                if (this.AdjustedShipping != null)
                    hashCode = hashCode * 59 + this.AdjustedShipping.GetHashCode();
                if (this.AdjustedTotal != null)
                    hashCode = hashCode * 59 + this.AdjustedTotal.GetHashCode();
                if (this.Cogs != null)
                    hashCode = hashCode * 59 + this.Cogs.GetHashCode();
                if (this.FinalValueFee != null)
                    hashCode = hashCode * 59 + this.FinalValueFee.GetHashCode();
                if (this.MinimumAdvertisedPrice != null)
                    hashCode = hashCode * 59 + this.MinimumAdvertisedPrice.GetHashCode();
                if (this.OtherListings != null)
                    hashCode = hashCode * 59 + this.OtherListings.GetHashCode();
                if (this.OurListing != null)
                    hashCode = hashCode * 59 + this.OurListing.GetHashCode();
                if (this.Overhead != null)
                    hashCode = hashCode * 59 + this.Overhead.GetHashCode();
                if (this.ProfitPotential != null)
                    hashCode = hashCode * 59 + this.ProfitPotential.GetHashCode();
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
