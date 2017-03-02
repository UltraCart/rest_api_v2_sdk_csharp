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
    /// CartPayment
    /// </summary>
    [DataContract]
    public partial class CartPayment :  IEquatable<CartPayment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartPayment" /> class.
        /// </summary>
        /// <param name="Amazon">Amazon.</param>
        /// <param name="Check">Check.</param>
        /// <param name="CreditCard">CreditCard.</param>
        /// <param name="PaymentMethod">Payment method.</param>
        /// <param name="PurchaseOrder">PurchaseOrder.</param>
        public CartPayment(CartPaymentAmazon Amazon = null, CartPaymentCheck Check = null, CartPaymentCreditCard CreditCard = null, string PaymentMethod = null, CartPaymentPurchaseOrder PurchaseOrder = null)
        {
            this.Amazon = Amazon;
            this.Check = Check;
            this.CreditCard = CreditCard;
            this.PaymentMethod = PaymentMethod;
            this.PurchaseOrder = PurchaseOrder;
        }
        
        /// <summary>
        /// Gets or Sets Amazon
        /// </summary>
        [DataMember(Name="amazon", EmitDefaultValue=false)]
        public CartPaymentAmazon Amazon { get; set; }
        /// <summary>
        /// Gets or Sets Check
        /// </summary>
        [DataMember(Name="check", EmitDefaultValue=false)]
        public CartPaymentCheck Check { get; set; }
        /// <summary>
        /// Gets or Sets CreditCard
        /// </summary>
        [DataMember(Name="credit_card", EmitDefaultValue=false)]
        public CartPaymentCreditCard CreditCard { get; set; }
        /// <summary>
        /// Payment method
        /// </summary>
        /// <value>Payment method</value>
        [DataMember(Name="payment_method", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }
        /// <summary>
        /// Gets or Sets PurchaseOrder
        /// </summary>
        [DataMember(Name="purchase_order", EmitDefaultValue=false)]
        public CartPaymentPurchaseOrder PurchaseOrder { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartPayment {\n");
            sb.Append("  Amazon: ").Append(Amazon).Append("\n");
            sb.Append("  Check: ").Append(Check).Append("\n");
            sb.Append("  CreditCard: ").Append(CreditCard).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PurchaseOrder: ").Append(PurchaseOrder).Append("\n");
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
            return this.Equals(obj as CartPayment);
        }

        /// <summary>
        /// Returns true if CartPayment instances are equal
        /// </summary>
        /// <param name="other">Instance of CartPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartPayment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Amazon == other.Amazon ||
                    this.Amazon != null &&
                    this.Amazon.Equals(other.Amazon)
                ) && 
                (
                    this.Check == other.Check ||
                    this.Check != null &&
                    this.Check.Equals(other.Check)
                ) && 
                (
                    this.CreditCard == other.CreditCard ||
                    this.CreditCard != null &&
                    this.CreditCard.Equals(other.CreditCard)
                ) && 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
                ) && 
                (
                    this.PurchaseOrder == other.PurchaseOrder ||
                    this.PurchaseOrder != null &&
                    this.PurchaseOrder.Equals(other.PurchaseOrder)
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
                if (this.Amazon != null)
                    hash = hash * 59 + this.Amazon.GetHashCode();
                if (this.Check != null)
                    hash = hash * 59 + this.Check.GetHashCode();
                if (this.CreditCard != null)
                    hash = hash * 59 + this.CreditCard.GetHashCode();
                if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                if (this.PurchaseOrder != null)
                    hash = hash * 59 + this.PurchaseOrder.GetHashCode();
                return hash;
            }
        }
    }

}
