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
    /// CheckoutHandoffResponse
    /// </summary>
    [DataContract]
    public partial class CheckoutHandoffResponse :  IEquatable<CheckoutHandoffResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutHandoffResponse" /> class.
        /// </summary>
        /// <param name="Cart">Cart.</param>
        /// <param name="Errors">Errors that occurred which are preventing the handoff operation.  Display these to the customer..</param>
        /// <param name="RedirectToUrl">The URL that you should redirect the customers browser to.</param>
        public CheckoutHandoffResponse(Cart Cart = null, List<string> Errors = null, string RedirectToUrl = null)
        {
            this.Cart = Cart;
            this.Errors = Errors;
            this.RedirectToUrl = RedirectToUrl;
        }
        
        /// <summary>
        /// Gets or Sets Cart
        /// </summary>
        [DataMember(Name="cart", EmitDefaultValue=false)]
        public Cart Cart { get; set; }
        /// <summary>
        /// Errors that occurred which are preventing the handoff operation.  Display these to the customer.
        /// </summary>
        /// <value>Errors that occurred which are preventing the handoff operation.  Display these to the customer.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }
        /// <summary>
        /// The URL that you should redirect the customers browser to
        /// </summary>
        /// <value>The URL that you should redirect the customers browser to</value>
        [DataMember(Name="redirect_to_url", EmitDefaultValue=false)]
        public string RedirectToUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutHandoffResponse {\n");
            sb.Append("  Cart: ").Append(Cart).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  RedirectToUrl: ").Append(RedirectToUrl).Append("\n");
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
            return this.Equals(obj as CheckoutHandoffResponse);
        }

        /// <summary>
        /// Returns true if CheckoutHandoffResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CheckoutHandoffResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutHandoffResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cart == other.Cart ||
                    this.Cart != null &&
                    this.Cart.Equals(other.Cart)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.RedirectToUrl == other.RedirectToUrl ||
                    this.RedirectToUrl != null &&
                    this.RedirectToUrl.Equals(other.RedirectToUrl)
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
                if (this.Cart != null)
                    hash = hash * 59 + this.Cart.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.RedirectToUrl != null)
                    hash = hash * 59 + this.RedirectToUrl.GetHashCode();
                return hash;
            }
        }
    }

}
