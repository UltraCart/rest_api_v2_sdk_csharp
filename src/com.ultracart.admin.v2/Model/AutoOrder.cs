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
    /// AutoOrder
    /// </summary>
    [DataContract]
    public partial class AutoOrder :  IEquatable<AutoOrder>, IValidatableObject
    {
        /// <summary>
        /// The status of the auto order
        /// </summary>
        /// <value>The status of the auto order</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled = 2,

            /// <summary>
            /// Enum Disabled for value: disabled
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled = 3

        }

        /// <summary>
        /// The status of the auto order
        /// </summary>
        /// <value>The status of the auto order</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoOrder" /> class.
        /// </summary>
        /// <param name="autoOrderCode">Unique code assigned to this auto order.</param>
        /// <param name="autoOrderOid">Auto order object identifier.</param>
        /// <param name="cancelAfterNextXOrders">Cancel this auto order after X additional rebills.</param>
        /// <param name="cancelDowngrade">True if the auto order was canceled because the customer purchased a downgrade item.</param>
        /// <param name="cancelReason">The reason this auto order was canceled by either merchant or customer.</param>
        /// <param name="cancelUpgrade">True if the auto order was canceled because the customer purchased an upgrade item.</param>
        /// <param name="canceledByUser">The user that canceled the auto order.</param>
        /// <param name="canceledDts">The date/time that the auto order was canceled.</param>
        /// <param name="completed">True if the auto order ran successfully to completion.</param>
        /// <param name="creditCardAttempt">The number of credit card attempts that have taken place.</param>
        /// <param name="disabledDts">The date/time the auto order was disabled due to failed rebills.</param>
        /// <param name="enabled">True if this auto order is enabled.</param>
        /// <param name="failureReason">The reason this auto order failed during the last rebill attempt.</param>
        /// <param name="items">The items that are setup to rebill.</param>
        /// <param name="logs">Logs associated with this auto order.</param>
        /// <param name="nextAttempt">The next time that the auto order will be attempted for processing.</param>
        /// <param name="originalOrder">originalOrder.</param>
        /// <param name="originalOrderId">The original order id that this auto order is associated with..</param>
        /// <param name="overrideAffiliateId">Override the affiliate id given credit for rebills of this auto order.</param>
        /// <param name="rebillOrders">Rebill orders that have taken place on this auto order.</param>
        /// <param name="rotatingTransactionGatewayCode">The RTG code associated with this order for future rebills.</param>
        /// <param name="status">The status of the auto order.</param>
        public AutoOrder(string autoOrderCode = default(string), int autoOrderOid = default(int), int cancelAfterNextXOrders = default(int), bool cancelDowngrade = default(bool), string cancelReason = default(string), bool cancelUpgrade = default(bool), string canceledByUser = default(string), string canceledDts = default(string), bool completed = default(bool), int creditCardAttempt = default(int), string disabledDts = default(string), bool enabled = default(bool), string failureReason = default(string), List<AutoOrderItem> items = default(List<AutoOrderItem>), List<AutoOrderLog> logs = default(List<AutoOrderLog>), string nextAttempt = default(string), Order originalOrder = default(Order), string originalOrderId = default(string), int overrideAffiliateId = default(int), List<Order> rebillOrders = default(List<Order>), string rotatingTransactionGatewayCode = default(string), StatusEnum? status = default(StatusEnum?))
        {
            this.AutoOrderCode = autoOrderCode;
            this.AutoOrderOid = autoOrderOid;
            this.CancelAfterNextXOrders = cancelAfterNextXOrders;
            this.CancelDowngrade = cancelDowngrade;
            this.CancelReason = cancelReason;
            this.CancelUpgrade = cancelUpgrade;
            this.CanceledByUser = canceledByUser;
            this.CanceledDts = canceledDts;
            this.Completed = completed;
            this.CreditCardAttempt = creditCardAttempt;
            this.DisabledDts = disabledDts;
            this.Enabled = enabled;
            this.FailureReason = failureReason;
            this.Items = items;
            this.Logs = logs;
            this.NextAttempt = nextAttempt;
            this.OriginalOrder = originalOrder;
            this.OriginalOrderId = originalOrderId;
            this.OverrideAffiliateId = overrideAffiliateId;
            this.RebillOrders = rebillOrders;
            this.RotatingTransactionGatewayCode = rotatingTransactionGatewayCode;
            this.Status = status;
        }

        /// <summary>
        /// Unique code assigned to this auto order
        /// </summary>
        /// <value>Unique code assigned to this auto order</value>
        [DataMember(Name="auto_order_code", EmitDefaultValue=false)]
        public string AutoOrderCode { get; set; }

        /// <summary>
        /// Auto order object identifier
        /// </summary>
        /// <value>Auto order object identifier</value>
        [DataMember(Name="auto_order_oid", EmitDefaultValue=false)]
        public int AutoOrderOid { get; set; }

        /// <summary>
        /// Cancel this auto order after X additional rebills
        /// </summary>
        /// <value>Cancel this auto order after X additional rebills</value>
        [DataMember(Name="cancel_after_next_x_orders", EmitDefaultValue=false)]
        public int CancelAfterNextXOrders { get; set; }

        /// <summary>
        /// True if the auto order was canceled because the customer purchased a downgrade item
        /// </summary>
        /// <value>True if the auto order was canceled because the customer purchased a downgrade item</value>
        [DataMember(Name="cancel_downgrade", EmitDefaultValue=false)]
        public bool CancelDowngrade { get; set; }

        /// <summary>
        /// The reason this auto order was canceled by either merchant or customer
        /// </summary>
        /// <value>The reason this auto order was canceled by either merchant or customer</value>
        [DataMember(Name="cancel_reason", EmitDefaultValue=false)]
        public string CancelReason { get; set; }

        /// <summary>
        /// True if the auto order was canceled because the customer purchased an upgrade item
        /// </summary>
        /// <value>True if the auto order was canceled because the customer purchased an upgrade item</value>
        [DataMember(Name="cancel_upgrade", EmitDefaultValue=false)]
        public bool CancelUpgrade { get; set; }

        /// <summary>
        /// The user that canceled the auto order
        /// </summary>
        /// <value>The user that canceled the auto order</value>
        [DataMember(Name="canceled_by_user", EmitDefaultValue=false)]
        public string CanceledByUser { get; set; }

        /// <summary>
        /// The date/time that the auto order was canceled
        /// </summary>
        /// <value>The date/time that the auto order was canceled</value>
        [DataMember(Name="canceled_dts", EmitDefaultValue=false)]
        public string CanceledDts { get; set; }

        /// <summary>
        /// True if the auto order ran successfully to completion
        /// </summary>
        /// <value>True if the auto order ran successfully to completion</value>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public bool Completed { get; set; }

        /// <summary>
        /// The number of credit card attempts that have taken place
        /// </summary>
        /// <value>The number of credit card attempts that have taken place</value>
        [DataMember(Name="credit_card_attempt", EmitDefaultValue=false)]
        public int CreditCardAttempt { get; set; }

        /// <summary>
        /// The date/time the auto order was disabled due to failed rebills
        /// </summary>
        /// <value>The date/time the auto order was disabled due to failed rebills</value>
        [DataMember(Name="disabled_dts", EmitDefaultValue=false)]
        public string DisabledDts { get; set; }

        /// <summary>
        /// True if this auto order is enabled
        /// </summary>
        /// <value>True if this auto order is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The reason this auto order failed during the last rebill attempt
        /// </summary>
        /// <value>The reason this auto order failed during the last rebill attempt</value>
        [DataMember(Name="failure_reason", EmitDefaultValue=false)]
        public string FailureReason { get; set; }

        /// <summary>
        /// The items that are setup to rebill
        /// </summary>
        /// <value>The items that are setup to rebill</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<AutoOrderItem> Items { get; set; }

        /// <summary>
        /// Logs associated with this auto order
        /// </summary>
        /// <value>Logs associated with this auto order</value>
        [DataMember(Name="logs", EmitDefaultValue=false)]
        public List<AutoOrderLog> Logs { get; set; }

        /// <summary>
        /// The next time that the auto order will be attempted for processing
        /// </summary>
        /// <value>The next time that the auto order will be attempted for processing</value>
        [DataMember(Name="next_attempt", EmitDefaultValue=false)]
        public string NextAttempt { get; set; }

        /// <summary>
        /// Gets or Sets OriginalOrder
        /// </summary>
        [DataMember(Name="original_order", EmitDefaultValue=false)]
        public Order OriginalOrder { get; set; }

        /// <summary>
        /// The original order id that this auto order is associated with.
        /// </summary>
        /// <value>The original order id that this auto order is associated with.</value>
        [DataMember(Name="original_order_id", EmitDefaultValue=false)]
        public string OriginalOrderId { get; set; }

        /// <summary>
        /// Override the affiliate id given credit for rebills of this auto order
        /// </summary>
        /// <value>Override the affiliate id given credit for rebills of this auto order</value>
        [DataMember(Name="override_affiliate_id", EmitDefaultValue=false)]
        public int OverrideAffiliateId { get; set; }

        /// <summary>
        /// Rebill orders that have taken place on this auto order
        /// </summary>
        /// <value>Rebill orders that have taken place on this auto order</value>
        [DataMember(Name="rebill_orders", EmitDefaultValue=false)]
        public List<Order> RebillOrders { get; set; }

        /// <summary>
        /// The RTG code associated with this order for future rebills
        /// </summary>
        /// <value>The RTG code associated with this order for future rebills</value>
        [DataMember(Name="rotating_transaction_gateway_code", EmitDefaultValue=false)]
        public string RotatingTransactionGatewayCode { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoOrder {\n");
            sb.Append("  AutoOrderCode: ").Append(AutoOrderCode).Append("\n");
            sb.Append("  AutoOrderOid: ").Append(AutoOrderOid).Append("\n");
            sb.Append("  CancelAfterNextXOrders: ").Append(CancelAfterNextXOrders).Append("\n");
            sb.Append("  CancelDowngrade: ").Append(CancelDowngrade).Append("\n");
            sb.Append("  CancelReason: ").Append(CancelReason).Append("\n");
            sb.Append("  CancelUpgrade: ").Append(CancelUpgrade).Append("\n");
            sb.Append("  CanceledByUser: ").Append(CanceledByUser).Append("\n");
            sb.Append("  CanceledDts: ").Append(CanceledDts).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  CreditCardAttempt: ").Append(CreditCardAttempt).Append("\n");
            sb.Append("  DisabledDts: ").Append(DisabledDts).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
            sb.Append("  NextAttempt: ").Append(NextAttempt).Append("\n");
            sb.Append("  OriginalOrder: ").Append(OriginalOrder).Append("\n");
            sb.Append("  OriginalOrderId: ").Append(OriginalOrderId).Append("\n");
            sb.Append("  OverrideAffiliateId: ").Append(OverrideAffiliateId).Append("\n");
            sb.Append("  RebillOrders: ").Append(RebillOrders).Append("\n");
            sb.Append("  RotatingTransactionGatewayCode: ").Append(RotatingTransactionGatewayCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AutoOrder);
        }

        /// <summary>
        /// Returns true if AutoOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoOrderCode == input.AutoOrderCode ||
                    (this.AutoOrderCode != null &&
                    this.AutoOrderCode.Equals(input.AutoOrderCode))
                ) && 
                (
                    this.AutoOrderOid == input.AutoOrderOid ||
                    (this.AutoOrderOid != null &&
                    this.AutoOrderOid.Equals(input.AutoOrderOid))
                ) && 
                (
                    this.CancelAfterNextXOrders == input.CancelAfterNextXOrders ||
                    (this.CancelAfterNextXOrders != null &&
                    this.CancelAfterNextXOrders.Equals(input.CancelAfterNextXOrders))
                ) && 
                (
                    this.CancelDowngrade == input.CancelDowngrade ||
                    (this.CancelDowngrade != null &&
                    this.CancelDowngrade.Equals(input.CancelDowngrade))
                ) && 
                (
                    this.CancelReason == input.CancelReason ||
                    (this.CancelReason != null &&
                    this.CancelReason.Equals(input.CancelReason))
                ) && 
                (
                    this.CancelUpgrade == input.CancelUpgrade ||
                    (this.CancelUpgrade != null &&
                    this.CancelUpgrade.Equals(input.CancelUpgrade))
                ) && 
                (
                    this.CanceledByUser == input.CanceledByUser ||
                    (this.CanceledByUser != null &&
                    this.CanceledByUser.Equals(input.CanceledByUser))
                ) && 
                (
                    this.CanceledDts == input.CanceledDts ||
                    (this.CanceledDts != null &&
                    this.CanceledDts.Equals(input.CanceledDts))
                ) && 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && 
                (
                    this.CreditCardAttempt == input.CreditCardAttempt ||
                    (this.CreditCardAttempt != null &&
                    this.CreditCardAttempt.Equals(input.CreditCardAttempt))
                ) && 
                (
                    this.DisabledDts == input.DisabledDts ||
                    (this.DisabledDts != null &&
                    this.DisabledDts.Equals(input.DisabledDts))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.FailureReason == input.FailureReason ||
                    (this.FailureReason != null &&
                    this.FailureReason.Equals(input.FailureReason))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Logs == input.Logs ||
                    this.Logs != null &&
                    input.Logs != null &&
                    this.Logs.SequenceEqual(input.Logs)
                ) && 
                (
                    this.NextAttempt == input.NextAttempt ||
                    (this.NextAttempt != null &&
                    this.NextAttempt.Equals(input.NextAttempt))
                ) && 
                (
                    this.OriginalOrder == input.OriginalOrder ||
                    (this.OriginalOrder != null &&
                    this.OriginalOrder.Equals(input.OriginalOrder))
                ) && 
                (
                    this.OriginalOrderId == input.OriginalOrderId ||
                    (this.OriginalOrderId != null &&
                    this.OriginalOrderId.Equals(input.OriginalOrderId))
                ) && 
                (
                    this.OverrideAffiliateId == input.OverrideAffiliateId ||
                    (this.OverrideAffiliateId != null &&
                    this.OverrideAffiliateId.Equals(input.OverrideAffiliateId))
                ) && 
                (
                    this.RebillOrders == input.RebillOrders ||
                    this.RebillOrders != null &&
                    input.RebillOrders != null &&
                    this.RebillOrders.SequenceEqual(input.RebillOrders)
                ) && 
                (
                    this.RotatingTransactionGatewayCode == input.RotatingTransactionGatewayCode ||
                    (this.RotatingTransactionGatewayCode != null &&
                    this.RotatingTransactionGatewayCode.Equals(input.RotatingTransactionGatewayCode))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AutoOrderCode != null)
                    hashCode = hashCode * 59 + this.AutoOrderCode.GetHashCode();
                if (this.AutoOrderOid != null)
                    hashCode = hashCode * 59 + this.AutoOrderOid.GetHashCode();
                if (this.CancelAfterNextXOrders != null)
                    hashCode = hashCode * 59 + this.CancelAfterNextXOrders.GetHashCode();
                if (this.CancelDowngrade != null)
                    hashCode = hashCode * 59 + this.CancelDowngrade.GetHashCode();
                if (this.CancelReason != null)
                    hashCode = hashCode * 59 + this.CancelReason.GetHashCode();
                if (this.CancelUpgrade != null)
                    hashCode = hashCode * 59 + this.CancelUpgrade.GetHashCode();
                if (this.CanceledByUser != null)
                    hashCode = hashCode * 59 + this.CanceledByUser.GetHashCode();
                if (this.CanceledDts != null)
                    hashCode = hashCode * 59 + this.CanceledDts.GetHashCode();
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.CreditCardAttempt != null)
                    hashCode = hashCode * 59 + this.CreditCardAttempt.GetHashCode();
                if (this.DisabledDts != null)
                    hashCode = hashCode * 59 + this.DisabledDts.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.FailureReason != null)
                    hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Logs != null)
                    hashCode = hashCode * 59 + this.Logs.GetHashCode();
                if (this.NextAttempt != null)
                    hashCode = hashCode * 59 + this.NextAttempt.GetHashCode();
                if (this.OriginalOrder != null)
                    hashCode = hashCode * 59 + this.OriginalOrder.GetHashCode();
                if (this.OriginalOrderId != null)
                    hashCode = hashCode * 59 + this.OriginalOrderId.GetHashCode();
                if (this.OverrideAffiliateId != null)
                    hashCode = hashCode * 59 + this.OverrideAffiliateId.GetHashCode();
                if (this.RebillOrders != null)
                    hashCode = hashCode * 59 + this.RebillOrders.GetHashCode();
                if (this.RotatingTransactionGatewayCode != null)
                    hashCode = hashCode * 59 + this.RotatingTransactionGatewayCode.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
