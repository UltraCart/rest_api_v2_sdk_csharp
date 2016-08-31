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
    /// ItemPricingTierLimit
    /// </summary>
    [DataContract]
    public partial class ItemPricingTierLimit :  IEquatable<ItemPricingTierLimit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPricingTierLimit" /> class.
        /// </summary>
        /// <param name="CumulativeOrderLimit">CumulativeOrderLimit.</param>
        /// <param name="IndividualOrderLimit">IndividualOrderLimit.</param>
        /// <param name="MultipleQuantity">MultipleQuantity.</param>
        public ItemPricingTierLimit(int? CumulativeOrderLimit = null, int? IndividualOrderLimit = null, int? MultipleQuantity = null)
        {
            this.CumulativeOrderLimit = CumulativeOrderLimit;
            this.IndividualOrderLimit = IndividualOrderLimit;
            this.MultipleQuantity = MultipleQuantity;
        }
        
        /// <summary>
        /// Gets or Sets CumulativeOrderLimit
        /// </summary>
        [DataMember(Name="cumulative_order_limit", EmitDefaultValue=false)]
        public int? CumulativeOrderLimit { get; set; }
        /// <summary>
        /// Gets or Sets IndividualOrderLimit
        /// </summary>
        [DataMember(Name="individual_order_limit", EmitDefaultValue=false)]
        public int? IndividualOrderLimit { get; set; }
        /// <summary>
        /// Gets or Sets MultipleQuantity
        /// </summary>
        [DataMember(Name="multiple_quantity", EmitDefaultValue=false)]
        public int? MultipleQuantity { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemPricingTierLimit {\n");
            sb.Append("  CumulativeOrderLimit: ").Append(CumulativeOrderLimit).Append("\n");
            sb.Append("  IndividualOrderLimit: ").Append(IndividualOrderLimit).Append("\n");
            sb.Append("  MultipleQuantity: ").Append(MultipleQuantity).Append("\n");
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
            return this.Equals(obj as ItemPricingTierLimit);
        }

        /// <summary>
        /// Returns true if ItemPricingTierLimit instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemPricingTierLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemPricingTierLimit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CumulativeOrderLimit == other.CumulativeOrderLimit ||
                    this.CumulativeOrderLimit != null &&
                    this.CumulativeOrderLimit.Equals(other.CumulativeOrderLimit)
                ) && 
                (
                    this.IndividualOrderLimit == other.IndividualOrderLimit ||
                    this.IndividualOrderLimit != null &&
                    this.IndividualOrderLimit.Equals(other.IndividualOrderLimit)
                ) && 
                (
                    this.MultipleQuantity == other.MultipleQuantity ||
                    this.MultipleQuantity != null &&
                    this.MultipleQuantity.Equals(other.MultipleQuantity)
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
                if (this.CumulativeOrderLimit != null)
                    hash = hash * 59 + this.CumulativeOrderLimit.GetHashCode();
                if (this.IndividualOrderLimit != null)
                    hash = hash * 59 + this.IndividualOrderLimit.GetHashCode();
                if (this.MultipleQuantity != null)
                    hash = hash * 59 + this.MultipleQuantity.GetHashCode();
                return hash;
            }
        }
    }

}
