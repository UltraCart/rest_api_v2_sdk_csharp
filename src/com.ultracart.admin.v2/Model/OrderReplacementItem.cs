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
    /// OrderReplacementItem
    /// </summary>
    [DataContract]
    public partial class OrderReplacementItem :  IEquatable<OrderReplacementItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderReplacementItem" /> class.
        /// </summary>
        /// <param name="ArbitraryUnitCost">Cost to charge the customer if specified.  If not specified then the default item cost is used..</param>
        /// <param name="MerchantItemId">Item ID.</param>
        /// <param name="Quantity">Quantity.</param>
        public OrderReplacementItem(decimal? ArbitraryUnitCost = default(decimal?), string MerchantItemId = default(string), decimal? Quantity = default(decimal?))
        {
            this.ArbitraryUnitCost = ArbitraryUnitCost;
            this.MerchantItemId = MerchantItemId;
            this.Quantity = Quantity;
        }
        
        /// <summary>
        /// Cost to charge the customer if specified.  If not specified then the default item cost is used.
        /// </summary>
        /// <value>Cost to charge the customer if specified.  If not specified then the default item cost is used.</value>
        [DataMember(Name="arbitrary_unit_cost", EmitDefaultValue=false)]
        public decimal? ArbitraryUnitCost { get; set; }

        /// <summary>
        /// Item ID
        /// </summary>
        /// <value>Item ID</value>
        [DataMember(Name="merchant_item_id", EmitDefaultValue=false)]
        public string MerchantItemId { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        /// <value>Quantity</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderReplacementItem {\n");
            sb.Append("  ArbitraryUnitCost: ").Append(ArbitraryUnitCost).Append("\n");
            sb.Append("  MerchantItemId: ").Append(MerchantItemId).Append("\n");
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
            return this.Equals(input as OrderReplacementItem);
        }

        /// <summary>
        /// Returns true if OrderReplacementItem instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderReplacementItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderReplacementItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArbitraryUnitCost == input.ArbitraryUnitCost ||
                    (this.ArbitraryUnitCost != null &&
                    this.ArbitraryUnitCost.Equals(input.ArbitraryUnitCost))
                ) && 
                (
                    this.MerchantItemId == input.MerchantItemId ||
                    (this.MerchantItemId != null &&
                    this.MerchantItemId.Equals(input.MerchantItemId))
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
                if (this.ArbitraryUnitCost != null)
                    hashCode = hashCode * 59 + this.ArbitraryUnitCost.GetHashCode();
                if (this.MerchantItemId != null)
                    hashCode = hashCode * 59 + this.MerchantItemId.GetHashCode();
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
            // MerchantItemId (string) maxLength
            if(this.MerchantItemId != null && this.MerchantItemId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantItemId, length must be less than 20.", new [] { "MerchantItemId" });
            }

            yield break;
        }
    }

}
