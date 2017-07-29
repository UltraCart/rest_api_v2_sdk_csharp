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
    /// OrderBuysafe
    /// </summary>
    [DataContract]
    public partial class OrderBuysafe :  IEquatable<OrderBuysafe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBuysafe" /> class.
        /// </summary>
        /// <param name="BuysafeBondAvailable">True if a buySAFE bond was available for purchase on this order.</param>
        /// <param name="BuysafeBondCost">BuysafeBondCost.</param>
        /// <param name="BuysafeBondFree">True if the buySAFE bond was free for this order.</param>
        /// <param name="BuysafeBondRefunded">BuysafeBondRefunded.</param>
        /// <param name="BuysafeBondWanted">True if the buySAFE bond was wanted by the customer.</param>
        /// <param name="BuysafeShoppingCartId">Shopping cart ID associated with the buySAFE bond.</param>
        public OrderBuysafe(bool? BuysafeBondAvailable = default(bool?), Currency BuysafeBondCost = default(Currency), bool? BuysafeBondFree = default(bool?), Currency BuysafeBondRefunded = default(Currency), bool? BuysafeBondWanted = default(bool?), string BuysafeShoppingCartId = default(string))
        {
            this.BuysafeBondAvailable = BuysafeBondAvailable;
            this.BuysafeBondCost = BuysafeBondCost;
            this.BuysafeBondFree = BuysafeBondFree;
            this.BuysafeBondRefunded = BuysafeBondRefunded;
            this.BuysafeBondWanted = BuysafeBondWanted;
            this.BuysafeShoppingCartId = BuysafeShoppingCartId;
        }
        
        /// <summary>
        /// True if a buySAFE bond was available for purchase on this order
        /// </summary>
        /// <value>True if a buySAFE bond was available for purchase on this order</value>
        [DataMember(Name="buysafe_bond_available", EmitDefaultValue=false)]
        public bool? BuysafeBondAvailable { get; set; }

        /// <summary>
        /// Gets or Sets BuysafeBondCost
        /// </summary>
        [DataMember(Name="buysafe_bond_cost", EmitDefaultValue=false)]
        public Currency BuysafeBondCost { get; set; }

        /// <summary>
        /// True if the buySAFE bond was free for this order
        /// </summary>
        /// <value>True if the buySAFE bond was free for this order</value>
        [DataMember(Name="buysafe_bond_free", EmitDefaultValue=false)]
        public bool? BuysafeBondFree { get; set; }

        /// <summary>
        /// Gets or Sets BuysafeBondRefunded
        /// </summary>
        [DataMember(Name="buysafe_bond_refunded", EmitDefaultValue=false)]
        public Currency BuysafeBondRefunded { get; set; }

        /// <summary>
        /// True if the buySAFE bond was wanted by the customer
        /// </summary>
        /// <value>True if the buySAFE bond was wanted by the customer</value>
        [DataMember(Name="buysafe_bond_wanted", EmitDefaultValue=false)]
        public bool? BuysafeBondWanted { get; set; }

        /// <summary>
        /// Shopping cart ID associated with the buySAFE bond
        /// </summary>
        /// <value>Shopping cart ID associated with the buySAFE bond</value>
        [DataMember(Name="buysafe_shopping_cart_id", EmitDefaultValue=false)]
        public string BuysafeShoppingCartId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderBuysafe {\n");
            sb.Append("  BuysafeBondAvailable: ").Append(BuysafeBondAvailable).Append("\n");
            sb.Append("  BuysafeBondCost: ").Append(BuysafeBondCost).Append("\n");
            sb.Append("  BuysafeBondFree: ").Append(BuysafeBondFree).Append("\n");
            sb.Append("  BuysafeBondRefunded: ").Append(BuysafeBondRefunded).Append("\n");
            sb.Append("  BuysafeBondWanted: ").Append(BuysafeBondWanted).Append("\n");
            sb.Append("  BuysafeShoppingCartId: ").Append(BuysafeShoppingCartId).Append("\n");
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
            return this.Equals(obj as OrderBuysafe);
        }

        /// <summary>
        /// Returns true if OrderBuysafe instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderBuysafe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderBuysafe other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BuysafeBondAvailable == other.BuysafeBondAvailable ||
                    this.BuysafeBondAvailable != null &&
                    this.BuysafeBondAvailable.Equals(other.BuysafeBondAvailable)
                ) && 
                (
                    this.BuysafeBondCost == other.BuysafeBondCost ||
                    this.BuysafeBondCost != null &&
                    this.BuysafeBondCost.Equals(other.BuysafeBondCost)
                ) && 
                (
                    this.BuysafeBondFree == other.BuysafeBondFree ||
                    this.BuysafeBondFree != null &&
                    this.BuysafeBondFree.Equals(other.BuysafeBondFree)
                ) && 
                (
                    this.BuysafeBondRefunded == other.BuysafeBondRefunded ||
                    this.BuysafeBondRefunded != null &&
                    this.BuysafeBondRefunded.Equals(other.BuysafeBondRefunded)
                ) && 
                (
                    this.BuysafeBondWanted == other.BuysafeBondWanted ||
                    this.BuysafeBondWanted != null &&
                    this.BuysafeBondWanted.Equals(other.BuysafeBondWanted)
                ) && 
                (
                    this.BuysafeShoppingCartId == other.BuysafeShoppingCartId ||
                    this.BuysafeShoppingCartId != null &&
                    this.BuysafeShoppingCartId.Equals(other.BuysafeShoppingCartId)
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
                if (this.BuysafeBondAvailable != null)
                    hash = hash * 59 + this.BuysafeBondAvailable.GetHashCode();
                if (this.BuysafeBondCost != null)
                    hash = hash * 59 + this.BuysafeBondCost.GetHashCode();
                if (this.BuysafeBondFree != null)
                    hash = hash * 59 + this.BuysafeBondFree.GetHashCode();
                if (this.BuysafeBondRefunded != null)
                    hash = hash * 59 + this.BuysafeBondRefunded.GetHashCode();
                if (this.BuysafeBondWanted != null)
                    hash = hash * 59 + this.BuysafeBondWanted.GetHashCode();
                if (this.BuysafeShoppingCartId != null)
                    hash = hash * 59 + this.BuysafeShoppingCartId.GetHashCode();
                return hash;
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
