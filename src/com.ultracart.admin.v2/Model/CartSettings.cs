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
    /// CartSettings
    /// </summary>
    [DataContract]
    public partial class CartSettings :  IEquatable<CartSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartSettings" /> class.
        /// </summary>
        /// <param name="Billing">Billing.</param>
        /// <param name="Gift">Gift.</param>
        /// <param name="Payment">Payment.</param>
        /// <param name="Shipping">Shipping.</param>
        /// <param name="Taxes">Taxes.</param>
        /// <param name="Terms">Terms.</param>
        public CartSettings(CartSettingsBilling Billing = null, CartSettingsGift Gift = null, CartSettingsPayment Payment = null, CartSettingsShipping Shipping = null, CartSettingsTaxes Taxes = null, CartSettingsTerms Terms = null)
        {
            this.Billing = Billing;
            this.Gift = Gift;
            this.Payment = Payment;
            this.Shipping = Shipping;
            this.Taxes = Taxes;
            this.Terms = Terms;
        }
        
        /// <summary>
        /// Gets or Sets Billing
        /// </summary>
        [DataMember(Name="billing", EmitDefaultValue=false)]
        public CartSettingsBilling Billing { get; set; }
        /// <summary>
        /// Gets or Sets Gift
        /// </summary>
        [DataMember(Name="gift", EmitDefaultValue=false)]
        public CartSettingsGift Gift { get; set; }
        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name="payment", EmitDefaultValue=false)]
        public CartSettingsPayment Payment { get; set; }
        /// <summary>
        /// Gets or Sets Shipping
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public CartSettingsShipping Shipping { get; set; }
        /// <summary>
        /// Gets or Sets Taxes
        /// </summary>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public CartSettingsTaxes Taxes { get; set; }
        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public CartSettingsTerms Terms { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartSettings {\n");
            sb.Append("  Billing: ").Append(Billing).Append("\n");
            sb.Append("  Gift: ").Append(Gift).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
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
            return this.Equals(obj as CartSettings);
        }

        /// <summary>
        /// Returns true if CartSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of CartSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Billing == other.Billing ||
                    this.Billing != null &&
                    this.Billing.Equals(other.Billing)
                ) && 
                (
                    this.Gift == other.Gift ||
                    this.Gift != null &&
                    this.Gift.Equals(other.Gift)
                ) && 
                (
                    this.Payment == other.Payment ||
                    this.Payment != null &&
                    this.Payment.Equals(other.Payment)
                ) && 
                (
                    this.Shipping == other.Shipping ||
                    this.Shipping != null &&
                    this.Shipping.Equals(other.Shipping)
                ) && 
                (
                    this.Taxes == other.Taxes ||
                    this.Taxes != null &&
                    this.Taxes.Equals(other.Taxes)
                ) && 
                (
                    this.Terms == other.Terms ||
                    this.Terms != null &&
                    this.Terms.Equals(other.Terms)
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
                if (this.Billing != null)
                    hash = hash * 59 + this.Billing.GetHashCode();
                if (this.Gift != null)
                    hash = hash * 59 + this.Gift.GetHashCode();
                if (this.Payment != null)
                    hash = hash * 59 + this.Payment.GetHashCode();
                if (this.Shipping != null)
                    hash = hash * 59 + this.Shipping.GetHashCode();
                if (this.Taxes != null)
                    hash = hash * 59 + this.Taxes.GetHashCode();
                if (this.Terms != null)
                    hash = hash * 59 + this.Terms.GetHashCode();
                return hash;
            }
        }
    }

}
