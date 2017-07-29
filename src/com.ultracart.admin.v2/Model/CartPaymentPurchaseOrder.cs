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
    /// CartPaymentPurchaseOrder
    /// </summary>
    [DataContract]
    public partial class CartPaymentPurchaseOrder :  IEquatable<CartPaymentPurchaseOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartPaymentPurchaseOrder" /> class.
        /// </summary>
        /// <param name="PurchaseOrderNumber">Purchase order number.</param>
        public CartPaymentPurchaseOrder(string PurchaseOrderNumber = default(string))
        {
            this.PurchaseOrderNumber = PurchaseOrderNumber;
        }
        
        /// <summary>
        /// Purchase order number
        /// </summary>
        /// <value>Purchase order number</value>
        [DataMember(Name="purchase_order_number", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartPaymentPurchaseOrder {\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
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
            return this.Equals(obj as CartPaymentPurchaseOrder);
        }

        /// <summary>
        /// Returns true if CartPaymentPurchaseOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of CartPaymentPurchaseOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartPaymentPurchaseOrder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PurchaseOrderNumber == other.PurchaseOrderNumber ||
                    this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(other.PurchaseOrderNumber)
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
                if (this.PurchaseOrderNumber != null)
                    hash = hash * 59 + this.PurchaseOrderNumber.GetHashCode();
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
