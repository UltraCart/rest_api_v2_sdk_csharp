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
    /// ItemPricingTier
    /// </summary>
    [DataContract]
    public partial class ItemPricingTier :  IEquatable<ItemPricingTier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPricingTier" /> class.
        /// </summary>
        /// <param name="DefaultTier">True if this is the default tier.</param>
        /// <param name="Discounts">Discounts.</param>
        /// <param name="Limit">Limit.</param>
        /// <param name="Name">Pricing tier name.</param>
        /// <param name="PricingTierOid">Pricing tier object identifier.</param>
        public ItemPricingTier(bool? DefaultTier = default(bool?), List<ItemPricingTierDiscount> Discounts = default(List<ItemPricingTierDiscount>), ItemPricingTierLimit Limit = default(ItemPricingTierLimit), string Name = default(string), int? PricingTierOid = default(int?))
        {
            this.DefaultTier = DefaultTier;
            this.Discounts = Discounts;
            this.Limit = Limit;
            this.Name = Name;
            this.PricingTierOid = PricingTierOid;
        }
        
        /// <summary>
        /// True if this is the default tier
        /// </summary>
        /// <value>True if this is the default tier</value>
        [DataMember(Name="default_tier", EmitDefaultValue=false)]
        public bool? DefaultTier { get; set; }

        /// <summary>
        /// Discounts
        /// </summary>
        /// <value>Discounts</value>
        [DataMember(Name="discounts", EmitDefaultValue=false)]
        public List<ItemPricingTierDiscount> Discounts { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public ItemPricingTierLimit Limit { get; set; }

        /// <summary>
        /// Pricing tier name
        /// </summary>
        /// <value>Pricing tier name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Pricing tier object identifier
        /// </summary>
        /// <value>Pricing tier object identifier</value>
        [DataMember(Name="pricing_tier_oid", EmitDefaultValue=false)]
        public int? PricingTierOid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemPricingTier {\n");
            sb.Append("  DefaultTier: ").Append(DefaultTier).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PricingTierOid: ").Append(PricingTierOid).Append("\n");
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
            return this.Equals(input as ItemPricingTier);
        }

        /// <summary>
        /// Returns true if ItemPricingTier instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemPricingTier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemPricingTier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultTier == input.DefaultTier ||
                    (this.DefaultTier != null &&
                    this.DefaultTier.Equals(input.DefaultTier))
                ) && 
                (
                    this.Discounts == input.Discounts ||
                    this.Discounts != null &&
                    this.Discounts.SequenceEqual(input.Discounts)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PricingTierOid == input.PricingTierOid ||
                    (this.PricingTierOid != null &&
                    this.PricingTierOid.Equals(input.PricingTierOid))
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
                if (this.DefaultTier != null)
                    hashCode = hashCode * 59 + this.DefaultTier.GetHashCode();
                if (this.Discounts != null)
                    hashCode = hashCode * 59 + this.Discounts.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PricingTierOid != null)
                    hashCode = hashCode * 59 + this.PricingTierOid.GetHashCode();
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
