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
    /// ItemTaxExemption
    /// </summary>
    [DataContract]
    public partial class ItemTaxExemption :  IEquatable<ItemTaxExemption>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemTaxExemption" /> class.
        /// </summary>
        /// <param name="City">City.</param>
        /// <param name="CountryCode">Country code (ISO-3166 two letter).</param>
        /// <param name="County">County.</param>
        /// <param name="PostalCode">Postal code.</param>
        /// <param name="StateCode">State code.</param>
        public ItemTaxExemption(string City = null, string CountryCode = null, string County = null, string PostalCode = null, string StateCode = null)
        {
            this.City = City;
            this.CountryCode = CountryCode;
            this.County = County;
            this.PostalCode = PostalCode;
            this.StateCode = StateCode;
        }
        
        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Country code (ISO-3166 two letter)
        /// </summary>
        /// <value>Country code (ISO-3166 two letter)</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// County
        /// </summary>
        /// <value>County</value>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }
        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// State code
        /// </summary>
        /// <value>State code</value>
        [DataMember(Name="state_code", EmitDefaultValue=false)]
        public string StateCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemTaxExemption {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
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
            return this.Equals(obj as ItemTaxExemption);
        }

        /// <summary>
        /// Returns true if ItemTaxExemption instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemTaxExemption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemTaxExemption other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.County == other.County ||
                    this.County != null &&
                    this.County.Equals(other.County)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.StateCode == other.StateCode ||
                    this.StateCode != null &&
                    this.StateCode.Equals(other.StateCode)
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
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.County != null)
                    hash = hash * 59 + this.County.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.StateCode != null)
                    hash = hash * 59 + this.StateCode.GetHashCode();
                return hash;
            }
        }
    }

}
