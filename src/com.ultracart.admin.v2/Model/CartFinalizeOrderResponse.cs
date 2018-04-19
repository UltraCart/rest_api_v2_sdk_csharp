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
    /// CartFinalizeOrderResponse
    /// </summary>
    [DataContract]
    public partial class CartFinalizeOrderResponse :  IEquatable<CartFinalizeOrderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartFinalizeOrderResponse" /> class.
        /// </summary>
        /// <param name="Errors">Error messages if the order could not be completed.</param>
        /// <param name="NextCart">NextCart.</param>
        /// <param name="Order">Order.</param>
        /// <param name="OrderId">Order ID assigned to the order.</param>
        /// <param name="Successful">True if the cart was converted successfully to an order.</param>
        public CartFinalizeOrderResponse(List<string> Errors = default(List<string>), Cart NextCart = default(Cart), Order Order = default(Order), string OrderId = default(string), bool? Successful = default(bool?))
        {
            this.Errors = Errors;
            this.NextCart = NextCart;
            this.Order = Order;
            this.OrderId = OrderId;
            this.Successful = Successful;
        }
        
        /// <summary>
        /// Error messages if the order could not be completed
        /// </summary>
        /// <value>Error messages if the order could not be completed</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Gets or Sets NextCart
        /// </summary>
        [DataMember(Name="next_cart", EmitDefaultValue=false)]
        public Cart NextCart { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public Order Order { get; set; }

        /// <summary>
        /// Order ID assigned to the order
        /// </summary>
        /// <value>Order ID assigned to the order</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// True if the cart was converted successfully to an order
        /// </summary>
        /// <value>True if the cart was converted successfully to an order</value>
        [DataMember(Name="successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartFinalizeOrderResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  NextCart: ").Append(NextCart).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
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
            return this.Equals(input as CartFinalizeOrderResponse);
        }

        /// <summary>
        /// Returns true if CartFinalizeOrderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CartFinalizeOrderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartFinalizeOrderResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.NextCart == input.NextCart ||
                    (this.NextCart != null &&
                    this.NextCart.Equals(input.NextCart))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.NextCart != null)
                    hashCode = hashCode * 59 + this.NextCart.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
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
