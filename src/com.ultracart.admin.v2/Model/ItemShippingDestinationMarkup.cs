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
    /// ItemShippingDestinationMarkup
    /// </summary>
    [DataContract]
    public partial class ItemShippingDestinationMarkup :  IEquatable<ItemShippingDestinationMarkup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemShippingDestinationMarkup" /> class.
        /// </summary>
        /// <param name="CountryCode">Country code (ISO-3166 two letter).</param>
        /// <param name="FlatFee">Flat fee.</param>
        /// <param name="PerItem">Per item.</param>
        /// <param name="PostalCode">Postal code.</param>
        /// <param name="ShippingMethod">Shipping method.</param>
        /// <param name="State">State.</param>
        public ItemShippingDestinationMarkup(string CountryCode = null, decimal? FlatFee = null, decimal? PerItem = null, string PostalCode = null, string ShippingMethod = null, string State = null)
        {
            this.CountryCode = CountryCode;
            this.FlatFee = FlatFee;
            this.PerItem = PerItem;
            this.PostalCode = PostalCode;
            this.ShippingMethod = ShippingMethod;
            this.State = State;
        }
        
        /// <summary>
        /// Country code (ISO-3166 two letter)
        /// </summary>
        /// <value>Country code (ISO-3166 two letter)</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// Flat fee
        /// </summary>
        /// <value>Flat fee</value>
        [DataMember(Name="flat_fee", EmitDefaultValue=false)]
        public decimal? FlatFee { get; set; }
        /// <summary>
        /// Per item
        /// </summary>
        /// <value>Per item</value>
        [DataMember(Name="per_item", EmitDefaultValue=false)]
        public decimal? PerItem { get; set; }
        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// Shipping method
        /// </summary>
        /// <value>Shipping method</value>
        [DataMember(Name="shipping_method", EmitDefaultValue=false)]
        public string ShippingMethod { get; set; }
        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemShippingDestinationMarkup {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  FlatFee: ").Append(FlatFee).Append("\n");
            sb.Append("  PerItem: ").Append(PerItem).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as ItemShippingDestinationMarkup);
        }

        /// <summary>
        /// Returns true if ItemShippingDestinationMarkup instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemShippingDestinationMarkup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemShippingDestinationMarkup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.FlatFee == other.FlatFee ||
                    this.FlatFee != null &&
                    this.FlatFee.Equals(other.FlatFee)
                ) && 
                (
                    this.PerItem == other.PerItem ||
                    this.PerItem != null &&
                    this.PerItem.Equals(other.PerItem)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.ShippingMethod == other.ShippingMethod ||
                    this.ShippingMethod != null &&
                    this.ShippingMethod.Equals(other.ShippingMethod)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.FlatFee != null)
                    hash = hash * 59 + this.FlatFee.GetHashCode();
                if (this.PerItem != null)
                    hash = hash * 59 + this.PerItem.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.ShippingMethod != null)
                    hash = hash * 59 + this.ShippingMethod.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                return hash;
            }
        }
    }

}
