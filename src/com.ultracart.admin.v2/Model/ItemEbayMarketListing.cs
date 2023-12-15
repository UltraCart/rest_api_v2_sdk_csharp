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
    /// ItemEbayMarketListing
    /// </summary>
    [DataContract]
    public partial class ItemEbayMarketListing :  IEquatable<ItemEbayMarketListing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemEbayMarketListing" /> class.
        /// </summary>
        /// <param name="auctionId">Auction ID.</param>
        /// <param name="price">Price.</param>
        /// <param name="seller">Seller.</param>
        /// <param name="shipping">Shipping.</param>
        /// <param name="total">Total.</param>
        public ItemEbayMarketListing(string auctionId = default(string), decimal? price = default(decimal?), string seller = default(string), decimal? shipping = default(decimal?), decimal? total = default(decimal?))
        {
            this.AuctionId = auctionId;
            this.Price = price;
            this.Seller = seller;
            this.Shipping = shipping;
            this.Total = total;
        }
        
        /// <summary>
        /// Auction ID
        /// </summary>
        /// <value>Auction ID</value>
        [DataMember(Name="auction_id", EmitDefaultValue=false)]
        public string AuctionId { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        /// <value>Price</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal? Price { get; set; }

        /// <summary>
        /// Seller
        /// </summary>
        /// <value>Seller</value>
        [DataMember(Name="seller", EmitDefaultValue=false)]
        public string Seller { get; set; }

        /// <summary>
        /// Shipping
        /// </summary>
        /// <value>Shipping</value>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public decimal? Shipping { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        /// <value>Total</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemEbayMarketListing {\n");
            sb.Append("  AuctionId: ").Append(AuctionId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Seller: ").Append(Seller).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ItemEbayMarketListing);
        }

        /// <summary>
        /// Returns true if ItemEbayMarketListing instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemEbayMarketListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemEbayMarketListing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuctionId == input.AuctionId ||
                    (this.AuctionId != null &&
                    this.AuctionId.Equals(input.AuctionId))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Seller == input.Seller ||
                    (this.Seller != null &&
                    this.Seller.Equals(input.Seller))
                ) && 
                (
                    this.Shipping == input.Shipping ||
                    (this.Shipping != null &&
                    this.Shipping.Equals(input.Shipping))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.AuctionId != null)
                    hashCode = hashCode * 59 + this.AuctionId.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Seller != null)
                    hashCode = hashCode * 59 + this.Seller.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
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
