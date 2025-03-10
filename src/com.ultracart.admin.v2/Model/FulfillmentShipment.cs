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
    /// FulfillmentShipment
    /// </summary>
    [DataContract]
    public partial class FulfillmentShipment :  IEquatable<FulfillmentShipment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentShipment" /> class.
        /// </summary>
        /// <param name="fulfillmentFee">Fees charged by the fulfillment company other than the shipping cost to process the order..</param>
        /// <param name="orderId">Order ID that was shipped.</param>
        /// <param name="packageCost">The cost of the packaging used to sent this shipment.</param>
        /// <param name="shippingCost">The actual total cost of shipping this order.</param>
        /// <param name="trackingNumbers">Tracking numbers associated with the shipment.</param>
        public FulfillmentShipment(decimal fulfillmentFee = default(decimal), string orderId = default(string), decimal packageCost = default(decimal), decimal shippingCost = default(decimal), List<string> trackingNumbers = default(List<string>))
        {
            this.FulfillmentFee = fulfillmentFee;
            this.OrderId = orderId;
            this.PackageCost = packageCost;
            this.ShippingCost = shippingCost;
            this.TrackingNumbers = trackingNumbers;
        }

        /// <summary>
        /// Fees charged by the fulfillment company other than the shipping cost to process the order.
        /// </summary>
        /// <value>Fees charged by the fulfillment company other than the shipping cost to process the order.</value>
        [DataMember(Name="fulfillment_fee", EmitDefaultValue=false)]
        public decimal FulfillmentFee { get; set; }

        /// <summary>
        /// Order ID that was shipped
        /// </summary>
        /// <value>Order ID that was shipped</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The cost of the packaging used to sent this shipment
        /// </summary>
        /// <value>The cost of the packaging used to sent this shipment</value>
        [DataMember(Name="package_cost", EmitDefaultValue=false)]
        public decimal PackageCost { get; set; }

        /// <summary>
        /// The actual total cost of shipping this order
        /// </summary>
        /// <value>The actual total cost of shipping this order</value>
        [DataMember(Name="shipping_cost", EmitDefaultValue=false)]
        public decimal ShippingCost { get; set; }

        /// <summary>
        /// Tracking numbers associated with the shipment
        /// </summary>
        /// <value>Tracking numbers associated with the shipment</value>
        [DataMember(Name="tracking_numbers", EmitDefaultValue=false)]
        public List<string> TrackingNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentShipment {\n");
            sb.Append("  FulfillmentFee: ").Append(FulfillmentFee).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PackageCost: ").Append(PackageCost).Append("\n");
            sb.Append("  ShippingCost: ").Append(ShippingCost).Append("\n");
            sb.Append("  TrackingNumbers: ").Append(TrackingNumbers).Append("\n");
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
            return this.Equals(input as FulfillmentShipment);
        }

        /// <summary>
        /// Returns true if FulfillmentShipment instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentShipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentShipment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FulfillmentFee == input.FulfillmentFee ||
                    (this.FulfillmentFee != null &&
                    this.FulfillmentFee.Equals(input.FulfillmentFee))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PackageCost == input.PackageCost ||
                    (this.PackageCost != null &&
                    this.PackageCost.Equals(input.PackageCost))
                ) && 
                (
                    this.ShippingCost == input.ShippingCost ||
                    (this.ShippingCost != null &&
                    this.ShippingCost.Equals(input.ShippingCost))
                ) && 
                (
                    this.TrackingNumbers == input.TrackingNumbers ||
                    this.TrackingNumbers != null &&
                    input.TrackingNumbers != null &&
                    this.TrackingNumbers.SequenceEqual(input.TrackingNumbers)
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
                if (this.FulfillmentFee != null)
                    hashCode = hashCode * 59 + this.FulfillmentFee.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PackageCost != null)
                    hashCode = hashCode * 59 + this.PackageCost.GetHashCode();
                if (this.ShippingCost != null)
                    hashCode = hashCode * 59 + this.ShippingCost.GetHashCode();
                if (this.TrackingNumbers != null)
                    hashCode = hashCode * 59 + this.TrackingNumbers.GetHashCode();
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
