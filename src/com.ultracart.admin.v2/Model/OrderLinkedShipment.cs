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
    /// OrderLinkedShipment
    /// </summary>
    [DataContract]
    public partial class OrderLinkedShipment :  IEquatable<OrderLinkedShipment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLinkedShipment" /> class.
        /// </summary>
        /// <param name="HasLinkedShipment">True if this order has child linked shipments.</param>
        /// <param name="LinkedShipment">True if this order is linked to another parent order.</param>
        /// <param name="LinkedShipmentChannelPartnerOrderIds">The child linked shipment channel partner order ids.</param>
        /// <param name="LinkedShipmentOrderIds">The child linked shipment order ids.</param>
        /// <param name="LinkedShipmentToOrderId">The parent order id that this one is linked to.</param>
        public OrderLinkedShipment(bool? HasLinkedShipment = null, bool? LinkedShipment = null, List<string> LinkedShipmentChannelPartnerOrderIds = null, List<string> LinkedShipmentOrderIds = null, string LinkedShipmentToOrderId = null)
        {
            this.HasLinkedShipment = HasLinkedShipment;
            this.LinkedShipment = LinkedShipment;
            this.LinkedShipmentChannelPartnerOrderIds = LinkedShipmentChannelPartnerOrderIds;
            this.LinkedShipmentOrderIds = LinkedShipmentOrderIds;
            this.LinkedShipmentToOrderId = LinkedShipmentToOrderId;
        }
        
        /// <summary>
        /// True if this order has child linked shipments
        /// </summary>
        /// <value>True if this order has child linked shipments</value>
        [DataMember(Name="has_linked_shipment", EmitDefaultValue=false)]
        public bool? HasLinkedShipment { get; set; }
        /// <summary>
        /// True if this order is linked to another parent order
        /// </summary>
        /// <value>True if this order is linked to another parent order</value>
        [DataMember(Name="linked_shipment", EmitDefaultValue=false)]
        public bool? LinkedShipment { get; set; }
        /// <summary>
        /// The child linked shipment channel partner order ids
        /// </summary>
        /// <value>The child linked shipment channel partner order ids</value>
        [DataMember(Name="linked_shipment_channel_partner_order_ids", EmitDefaultValue=false)]
        public List<string> LinkedShipmentChannelPartnerOrderIds { get; set; }
        /// <summary>
        /// The child linked shipment order ids
        /// </summary>
        /// <value>The child linked shipment order ids</value>
        [DataMember(Name="linked_shipment_order_ids", EmitDefaultValue=false)]
        public List<string> LinkedShipmentOrderIds { get; set; }
        /// <summary>
        /// The parent order id that this one is linked to
        /// </summary>
        /// <value>The parent order id that this one is linked to</value>
        [DataMember(Name="linked_shipment_to_order_id", EmitDefaultValue=false)]
        public string LinkedShipmentToOrderId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLinkedShipment {\n");
            sb.Append("  HasLinkedShipment: ").Append(HasLinkedShipment).Append("\n");
            sb.Append("  LinkedShipment: ").Append(LinkedShipment).Append("\n");
            sb.Append("  LinkedShipmentChannelPartnerOrderIds: ").Append(LinkedShipmentChannelPartnerOrderIds).Append("\n");
            sb.Append("  LinkedShipmentOrderIds: ").Append(LinkedShipmentOrderIds).Append("\n");
            sb.Append("  LinkedShipmentToOrderId: ").Append(LinkedShipmentToOrderId).Append("\n");
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
            return this.Equals(obj as OrderLinkedShipment);
        }

        /// <summary>
        /// Returns true if OrderLinkedShipment instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderLinkedShipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLinkedShipment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HasLinkedShipment == other.HasLinkedShipment ||
                    this.HasLinkedShipment != null &&
                    this.HasLinkedShipment.Equals(other.HasLinkedShipment)
                ) && 
                (
                    this.LinkedShipment == other.LinkedShipment ||
                    this.LinkedShipment != null &&
                    this.LinkedShipment.Equals(other.LinkedShipment)
                ) && 
                (
                    this.LinkedShipmentChannelPartnerOrderIds == other.LinkedShipmentChannelPartnerOrderIds ||
                    this.LinkedShipmentChannelPartnerOrderIds != null &&
                    this.LinkedShipmentChannelPartnerOrderIds.SequenceEqual(other.LinkedShipmentChannelPartnerOrderIds)
                ) && 
                (
                    this.LinkedShipmentOrderIds == other.LinkedShipmentOrderIds ||
                    this.LinkedShipmentOrderIds != null &&
                    this.LinkedShipmentOrderIds.SequenceEqual(other.LinkedShipmentOrderIds)
                ) && 
                (
                    this.LinkedShipmentToOrderId == other.LinkedShipmentToOrderId ||
                    this.LinkedShipmentToOrderId != null &&
                    this.LinkedShipmentToOrderId.Equals(other.LinkedShipmentToOrderId)
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
                if (this.HasLinkedShipment != null)
                    hash = hash * 59 + this.HasLinkedShipment.GetHashCode();
                if (this.LinkedShipment != null)
                    hash = hash * 59 + this.LinkedShipment.GetHashCode();
                if (this.LinkedShipmentChannelPartnerOrderIds != null)
                    hash = hash * 59 + this.LinkedShipmentChannelPartnerOrderIds.GetHashCode();
                if (this.LinkedShipmentOrderIds != null)
                    hash = hash * 59 + this.LinkedShipmentOrderIds.GetHashCode();
                if (this.LinkedShipmentToOrderId != null)
                    hash = hash * 59 + this.LinkedShipmentToOrderId.GetHashCode();
                return hash;
            }
        }
    }

}
