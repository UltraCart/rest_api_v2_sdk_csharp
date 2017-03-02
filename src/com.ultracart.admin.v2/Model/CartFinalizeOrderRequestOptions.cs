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
    /// CartFinalizeOrderRequestOptions
    /// </summary>
    [DataContract]
    public partial class CartFinalizeOrderRequestOptions :  IEquatable<CartFinalizeOrderRequestOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartFinalizeOrderRequestOptions" /> class.
        /// </summary>
        /// <param name="AutoApprovePurchaseOrder">Automatically approve the purchase order.</param>
        /// <param name="ChannelPartnerCode">Channel partner code to associate this order with.</param>
        /// <param name="ChannelPartnerOid">Channel partner oid to associate this order with.</param>
        /// <param name="ChannelPartnerOrderId">Channel partner order id for reference.</param>
        /// <param name="ConsiderRecurring">Consider this order a recurring order for the purposes of payment gateway recurring flag.</param>
        /// <param name="CreditCardAuthorizationAmount">If the order was authorized outside of UltraCart, this is the amount of the authorization.</param>
        /// <param name="CreditCardAuthorizationDate">If the order was authorized outside of UltraCart, this is the date/time of the authorization.</param>
        /// <param name="CreditCardAuthorizationReferenceNumber">If the order was authorized outside of UltraCart, this is the authorization reference number.</param>
        /// <param name="NoRealtimePaymentProcessing">Prevents normal real-time processing of the payment and sends the order to Accounts Receivable.</param>
        /// <param name="SetupNextCart">True if the system should create another cart automatically if the current cart was logged into a profile.</param>
        /// <param name="SkipPaymentProcessing">Skip payment processing and move the order on to shipping (or completed if no shipping required).</param>
        /// <param name="StoreCompleted">True the order in the completed stage.</param>
        /// <param name="StoreIfPaymentDeclines">Store the order in accounts receivable if the payment declines.</param>
        public CartFinalizeOrderRequestOptions(bool? AutoApprovePurchaseOrder = null, string ChannelPartnerCode = null, int? ChannelPartnerOid = null, string ChannelPartnerOrderId = null, bool? ConsiderRecurring = null, decimal? CreditCardAuthorizationAmount = null, string CreditCardAuthorizationDate = null, string CreditCardAuthorizationReferenceNumber = null, bool? NoRealtimePaymentProcessing = null, bool? SetupNextCart = null, bool? SkipPaymentProcessing = null, bool? StoreCompleted = null, bool? StoreIfPaymentDeclines = null)
        {
            this.AutoApprovePurchaseOrder = AutoApprovePurchaseOrder;
            this.ChannelPartnerCode = ChannelPartnerCode;
            this.ChannelPartnerOid = ChannelPartnerOid;
            this.ChannelPartnerOrderId = ChannelPartnerOrderId;
            this.ConsiderRecurring = ConsiderRecurring;
            this.CreditCardAuthorizationAmount = CreditCardAuthorizationAmount;
            this.CreditCardAuthorizationDate = CreditCardAuthorizationDate;
            this.CreditCardAuthorizationReferenceNumber = CreditCardAuthorizationReferenceNumber;
            this.NoRealtimePaymentProcessing = NoRealtimePaymentProcessing;
            this.SetupNextCart = SetupNextCart;
            this.SkipPaymentProcessing = SkipPaymentProcessing;
            this.StoreCompleted = StoreCompleted;
            this.StoreIfPaymentDeclines = StoreIfPaymentDeclines;
        }
        
        /// <summary>
        /// Automatically approve the purchase order
        /// </summary>
        /// <value>Automatically approve the purchase order</value>
        [DataMember(Name="auto_approve_purchase_order", EmitDefaultValue=false)]
        public bool? AutoApprovePurchaseOrder { get; set; }
        /// <summary>
        /// Channel partner code to associate this order with
        /// </summary>
        /// <value>Channel partner code to associate this order with</value>
        [DataMember(Name="channel_partner_code", EmitDefaultValue=false)]
        public string ChannelPartnerCode { get; set; }
        /// <summary>
        /// Channel partner oid to associate this order with
        /// </summary>
        /// <value>Channel partner oid to associate this order with</value>
        [DataMember(Name="channel_partner_oid", EmitDefaultValue=false)]
        public int? ChannelPartnerOid { get; set; }
        /// <summary>
        /// Channel partner order id for reference
        /// </summary>
        /// <value>Channel partner order id for reference</value>
        [DataMember(Name="channel_partner_order_id", EmitDefaultValue=false)]
        public string ChannelPartnerOrderId { get; set; }
        /// <summary>
        /// Consider this order a recurring order for the purposes of payment gateway recurring flag
        /// </summary>
        /// <value>Consider this order a recurring order for the purposes of payment gateway recurring flag</value>
        [DataMember(Name="consider_recurring", EmitDefaultValue=false)]
        public bool? ConsiderRecurring { get; set; }
        /// <summary>
        /// If the order was authorized outside of UltraCart, this is the amount of the authorization
        /// </summary>
        /// <value>If the order was authorized outside of UltraCart, this is the amount of the authorization</value>
        [DataMember(Name="credit_card_authorization_amount", EmitDefaultValue=false)]
        public decimal? CreditCardAuthorizationAmount { get; set; }
        /// <summary>
        /// If the order was authorized outside of UltraCart, this is the date/time of the authorization
        /// </summary>
        /// <value>If the order was authorized outside of UltraCart, this is the date/time of the authorization</value>
        [DataMember(Name="credit_card_authorization_date", EmitDefaultValue=false)]
        public string CreditCardAuthorizationDate { get; set; }
        /// <summary>
        /// If the order was authorized outside of UltraCart, this is the authorization reference number
        /// </summary>
        /// <value>If the order was authorized outside of UltraCart, this is the authorization reference number</value>
        [DataMember(Name="credit_card_authorization_reference_number", EmitDefaultValue=false)]
        public string CreditCardAuthorizationReferenceNumber { get; set; }
        /// <summary>
        /// Prevents normal real-time processing of the payment and sends the order to Accounts Receivable
        /// </summary>
        /// <value>Prevents normal real-time processing of the payment and sends the order to Accounts Receivable</value>
        [DataMember(Name="no_realtime_payment_processing", EmitDefaultValue=false)]
        public bool? NoRealtimePaymentProcessing { get; set; }
        /// <summary>
        /// True if the system should create another cart automatically if the current cart was logged into a profile
        /// </summary>
        /// <value>True if the system should create another cart automatically if the current cart was logged into a profile</value>
        [DataMember(Name="setup_next_cart", EmitDefaultValue=false)]
        public bool? SetupNextCart { get; set; }
        /// <summary>
        /// Skip payment processing and move the order on to shipping (or completed if no shipping required)
        /// </summary>
        /// <value>Skip payment processing and move the order on to shipping (or completed if no shipping required)</value>
        [DataMember(Name="skip_payment_processing", EmitDefaultValue=false)]
        public bool? SkipPaymentProcessing { get; set; }
        /// <summary>
        /// True the order in the completed stage
        /// </summary>
        /// <value>True the order in the completed stage</value>
        [DataMember(Name="store_completed", EmitDefaultValue=false)]
        public bool? StoreCompleted { get; set; }
        /// <summary>
        /// Store the order in accounts receivable if the payment declines
        /// </summary>
        /// <value>Store the order in accounts receivable if the payment declines</value>
        [DataMember(Name="store_if_payment_declines", EmitDefaultValue=false)]
        public bool? StoreIfPaymentDeclines { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartFinalizeOrderRequestOptions {\n");
            sb.Append("  AutoApprovePurchaseOrder: ").Append(AutoApprovePurchaseOrder).Append("\n");
            sb.Append("  ChannelPartnerCode: ").Append(ChannelPartnerCode).Append("\n");
            sb.Append("  ChannelPartnerOid: ").Append(ChannelPartnerOid).Append("\n");
            sb.Append("  ChannelPartnerOrderId: ").Append(ChannelPartnerOrderId).Append("\n");
            sb.Append("  ConsiderRecurring: ").Append(ConsiderRecurring).Append("\n");
            sb.Append("  CreditCardAuthorizationAmount: ").Append(CreditCardAuthorizationAmount).Append("\n");
            sb.Append("  CreditCardAuthorizationDate: ").Append(CreditCardAuthorizationDate).Append("\n");
            sb.Append("  CreditCardAuthorizationReferenceNumber: ").Append(CreditCardAuthorizationReferenceNumber).Append("\n");
            sb.Append("  NoRealtimePaymentProcessing: ").Append(NoRealtimePaymentProcessing).Append("\n");
            sb.Append("  SetupNextCart: ").Append(SetupNextCart).Append("\n");
            sb.Append("  SkipPaymentProcessing: ").Append(SkipPaymentProcessing).Append("\n");
            sb.Append("  StoreCompleted: ").Append(StoreCompleted).Append("\n");
            sb.Append("  StoreIfPaymentDeclines: ").Append(StoreIfPaymentDeclines).Append("\n");
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
            return this.Equals(obj as CartFinalizeOrderRequestOptions);
        }

        /// <summary>
        /// Returns true if CartFinalizeOrderRequestOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of CartFinalizeOrderRequestOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartFinalizeOrderRequestOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AutoApprovePurchaseOrder == other.AutoApprovePurchaseOrder ||
                    this.AutoApprovePurchaseOrder != null &&
                    this.AutoApprovePurchaseOrder.Equals(other.AutoApprovePurchaseOrder)
                ) && 
                (
                    this.ChannelPartnerCode == other.ChannelPartnerCode ||
                    this.ChannelPartnerCode != null &&
                    this.ChannelPartnerCode.Equals(other.ChannelPartnerCode)
                ) && 
                (
                    this.ChannelPartnerOid == other.ChannelPartnerOid ||
                    this.ChannelPartnerOid != null &&
                    this.ChannelPartnerOid.Equals(other.ChannelPartnerOid)
                ) && 
                (
                    this.ChannelPartnerOrderId == other.ChannelPartnerOrderId ||
                    this.ChannelPartnerOrderId != null &&
                    this.ChannelPartnerOrderId.Equals(other.ChannelPartnerOrderId)
                ) && 
                (
                    this.ConsiderRecurring == other.ConsiderRecurring ||
                    this.ConsiderRecurring != null &&
                    this.ConsiderRecurring.Equals(other.ConsiderRecurring)
                ) && 
                (
                    this.CreditCardAuthorizationAmount == other.CreditCardAuthorizationAmount ||
                    this.CreditCardAuthorizationAmount != null &&
                    this.CreditCardAuthorizationAmount.Equals(other.CreditCardAuthorizationAmount)
                ) && 
                (
                    this.CreditCardAuthorizationDate == other.CreditCardAuthorizationDate ||
                    this.CreditCardAuthorizationDate != null &&
                    this.CreditCardAuthorizationDate.Equals(other.CreditCardAuthorizationDate)
                ) && 
                (
                    this.CreditCardAuthorizationReferenceNumber == other.CreditCardAuthorizationReferenceNumber ||
                    this.CreditCardAuthorizationReferenceNumber != null &&
                    this.CreditCardAuthorizationReferenceNumber.Equals(other.CreditCardAuthorizationReferenceNumber)
                ) && 
                (
                    this.NoRealtimePaymentProcessing == other.NoRealtimePaymentProcessing ||
                    this.NoRealtimePaymentProcessing != null &&
                    this.NoRealtimePaymentProcessing.Equals(other.NoRealtimePaymentProcessing)
                ) && 
                (
                    this.SetupNextCart == other.SetupNextCart ||
                    this.SetupNextCart != null &&
                    this.SetupNextCart.Equals(other.SetupNextCart)
                ) && 
                (
                    this.SkipPaymentProcessing == other.SkipPaymentProcessing ||
                    this.SkipPaymentProcessing != null &&
                    this.SkipPaymentProcessing.Equals(other.SkipPaymentProcessing)
                ) && 
                (
                    this.StoreCompleted == other.StoreCompleted ||
                    this.StoreCompleted != null &&
                    this.StoreCompleted.Equals(other.StoreCompleted)
                ) && 
                (
                    this.StoreIfPaymentDeclines == other.StoreIfPaymentDeclines ||
                    this.StoreIfPaymentDeclines != null &&
                    this.StoreIfPaymentDeclines.Equals(other.StoreIfPaymentDeclines)
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
                if (this.AutoApprovePurchaseOrder != null)
                    hash = hash * 59 + this.AutoApprovePurchaseOrder.GetHashCode();
                if (this.ChannelPartnerCode != null)
                    hash = hash * 59 + this.ChannelPartnerCode.GetHashCode();
                if (this.ChannelPartnerOid != null)
                    hash = hash * 59 + this.ChannelPartnerOid.GetHashCode();
                if (this.ChannelPartnerOrderId != null)
                    hash = hash * 59 + this.ChannelPartnerOrderId.GetHashCode();
                if (this.ConsiderRecurring != null)
                    hash = hash * 59 + this.ConsiderRecurring.GetHashCode();
                if (this.CreditCardAuthorizationAmount != null)
                    hash = hash * 59 + this.CreditCardAuthorizationAmount.GetHashCode();
                if (this.CreditCardAuthorizationDate != null)
                    hash = hash * 59 + this.CreditCardAuthorizationDate.GetHashCode();
                if (this.CreditCardAuthorizationReferenceNumber != null)
                    hash = hash * 59 + this.CreditCardAuthorizationReferenceNumber.GetHashCode();
                if (this.NoRealtimePaymentProcessing != null)
                    hash = hash * 59 + this.NoRealtimePaymentProcessing.GetHashCode();
                if (this.SetupNextCart != null)
                    hash = hash * 59 + this.SetupNextCart.GetHashCode();
                if (this.SkipPaymentProcessing != null)
                    hash = hash * 59 + this.SkipPaymentProcessing.GetHashCode();
                if (this.StoreCompleted != null)
                    hash = hash * 59 + this.StoreCompleted.GetHashCode();
                if (this.StoreIfPaymentDeclines != null)
                    hash = hash * 59 + this.StoreIfPaymentDeclines.GetHashCode();
                return hash;
            }
        }
    }

}
