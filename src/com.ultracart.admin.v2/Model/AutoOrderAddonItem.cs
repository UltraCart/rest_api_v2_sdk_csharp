/*
 * UltraCart Rest API V2
 *
 * UltraCart REST API Version 2
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: support@ultracart.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = com.ultracart.admin.v2.Client.OpenAPIDateConverter;

namespace com.ultracart.admin.v2.Model
{
    /// <summary>
    /// AutoOrderAddonItem
    /// </summary>
    [DataContract]
    public partial class AutoOrderAddonItem :  IEquatable<AutoOrderAddonItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoOrderAddonItem" /> class.
        /// </summary>
        /// <param name="arbitraryUnitCost">arbitraryUnitCost.</param>
        /// <param name="freeShipping">freeShipping.</param>
        /// <param name="itemId">itemId.</param>
        /// <param name="nextXOrders">nextXOrders.</param>
        /// <param name="options">Options associated with this item.</param>
        /// <param name="quantity">quantity.</param>
        public AutoOrderAddonItem(decimal arbitraryUnitCost = default(decimal), bool freeShipping = default(bool), string itemId = default(string), int nextXOrders = default(int), List<AutoOrderAddonItemOption> options = default(List<AutoOrderAddonItemOption>), int quantity = default(int))
        {
            this.ArbitraryUnitCost = arbitraryUnitCost;
            this.FreeShipping = freeShipping;
            this.ItemId = itemId;
            this.NextXOrders = nextXOrders;
            this.Options = options;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Gets or Sets ArbitraryUnitCost
        /// </summary>
        [DataMember(Name="arbitrary_unit_cost", EmitDefaultValue=false)]
        public decimal ArbitraryUnitCost { get; set; }

        /// <summary>
        /// Gets or Sets FreeShipping
        /// </summary>
        [DataMember(Name="free_shipping", EmitDefaultValue=false)]
        public bool FreeShipping { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or Sets NextXOrders
        /// </summary>
        [DataMember(Name="next_x_orders", EmitDefaultValue=false)]
        public int NextXOrders { get; set; }

        /// <summary>
        /// Options associated with this item
        /// </summary>
        /// <value>Options associated with this item</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<AutoOrderAddonItemOption> Options { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoOrderAddonItem {\n");
            sb.Append("  ArbitraryUnitCost: ").Append(ArbitraryUnitCost).Append("\n");
            sb.Append("  FreeShipping: ").Append(FreeShipping).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  NextXOrders: ").Append(NextXOrders).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoOrderAddonItem);
        }

        /// <summary>
        /// Returns true if AutoOrderAddonItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoOrderAddonItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoOrderAddonItem input)
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
                    this.FreeShipping == input.FreeShipping ||
                    (this.FreeShipping != null &&
                    this.FreeShipping.Equals(input.FreeShipping))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.NextXOrders == input.NextXOrders ||
                    (this.NextXOrders != null &&
                    this.NextXOrders.Equals(input.NextXOrders))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                if (this.FreeShipping != null)
                    hashCode = hashCode * 59 + this.FreeShipping.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.NextXOrders != null)
                    hashCode = hashCode * 59 + this.NextXOrders.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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
