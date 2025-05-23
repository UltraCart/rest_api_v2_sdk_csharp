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
    /// AffiliateLedger
    /// </summary>
    [DataContract]
    public partial class AffiliateLedger :  IEquatable<AffiliateLedger>, IValidatableObject
    {
        /// <summary>
        /// Transaction state
        /// </summary>
        /// <value>Transaction state</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionStateEnum
        {
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 1,

            /// <summary>
            /// Enum Posted for value: Posted
            /// </summary>
            [EnumMember(Value = "Posted")]
            Posted = 2,

            /// <summary>
            /// Enum Approved for value: Approved
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved = 3,

            /// <summary>
            /// Enum Paid for value: Paid
            /// </summary>
            [EnumMember(Value = "Paid")]
            Paid = 4,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected = 5,

            /// <summary>
            /// Enum PartiallyPaid for value: Partially Paid
            /// </summary>
            [EnumMember(Value = "Partially Paid")]
            PartiallyPaid = 6

        }

        /// <summary>
        /// Transaction state
        /// </summary>
        /// <value>Transaction state</value>
        [DataMember(Name="transaction_state", EmitDefaultValue=false)]
        public TransactionStateEnum? TransactionState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateLedger" /> class.
        /// </summary>
        /// <param name="affiliateClickOid">Unique object identifier for the click associated with this ledger entry.</param>
        /// <param name="affiliateLedgerOid">Affiliate ledger object ID associated with this ledger.</param>
        /// <param name="affiliateLinkOid">Unique object identifier for the link that this click is associated with.</param>
        /// <param name="affiliateOid">Affiliate object ID associated with this transaction.</param>
        /// <param name="assignedByUser">User that assigned the transaction if it was done manually.</param>
        /// <param name="click">click.</param>
        /// <param name="itemId">Item ID associated with this transaction.</param>
        /// <param name="link">link.</param>
        /// <param name="order">order.</param>
        /// <param name="orderId">Order ID associated with this transaction.</param>
        /// <param name="originalTransactionDts">Date/time of the original transaction for reversals.</param>
        /// <param name="subId">Sub ID associated with transaction (from the click).</param>
        /// <param name="tierNumber">Tier number that this transaction earned.</param>
        /// <param name="transactionAmount">Transaction amount.</param>
        /// <param name="transactionAmountPaid">Amount of the transaction that has been paid out..</param>
        /// <param name="transactionDts">Date/time that the transaction was made.</param>
        /// <param name="transactionMemo">Memo explaining the transaction.</param>
        /// <param name="transactionPercentage">Percentage associated with this transaction.</param>
        /// <param name="transactionState">Transaction state.</param>
        public AffiliateLedger(int affiliateClickOid = default(int), int affiliateLedgerOid = default(int), int affiliateLinkOid = default(int), int affiliateOid = default(int), string assignedByUser = default(string), AffiliateClick click = default(AffiliateClick), string itemId = default(string), AffiliateLink link = default(AffiliateLink), Order order = default(Order), string orderId = default(string), string originalTransactionDts = default(string), string subId = default(string), int tierNumber = default(int), decimal transactionAmount = default(decimal), decimal transactionAmountPaid = default(decimal), string transactionDts = default(string), string transactionMemo = default(string), decimal transactionPercentage = default(decimal), TransactionStateEnum? transactionState = default(TransactionStateEnum?))
        {
            this.AffiliateClickOid = affiliateClickOid;
            this.AffiliateLedgerOid = affiliateLedgerOid;
            this.AffiliateLinkOid = affiliateLinkOid;
            this.AffiliateOid = affiliateOid;
            this.AssignedByUser = assignedByUser;
            this.Click = click;
            this.ItemId = itemId;
            this.Link = link;
            this.Order = order;
            this.OrderId = orderId;
            this.OriginalTransactionDts = originalTransactionDts;
            this.SubId = subId;
            this.TierNumber = tierNumber;
            this.TransactionAmount = transactionAmount;
            this.TransactionAmountPaid = transactionAmountPaid;
            this.TransactionDts = transactionDts;
            this.TransactionMemo = transactionMemo;
            this.TransactionPercentage = transactionPercentage;
            this.TransactionState = transactionState;
        }

        /// <summary>
        /// Unique object identifier for the click associated with this ledger entry
        /// </summary>
        /// <value>Unique object identifier for the click associated with this ledger entry</value>
        [DataMember(Name="affiliate_click_oid", EmitDefaultValue=false)]
        public int AffiliateClickOid { get; set; }

        /// <summary>
        /// Affiliate ledger object ID associated with this ledger
        /// </summary>
        /// <value>Affiliate ledger object ID associated with this ledger</value>
        [DataMember(Name="affiliate_ledger_oid", EmitDefaultValue=false)]
        public int AffiliateLedgerOid { get; set; }

        /// <summary>
        /// Unique object identifier for the link that this click is associated with
        /// </summary>
        /// <value>Unique object identifier for the link that this click is associated with</value>
        [DataMember(Name="affiliate_link_oid", EmitDefaultValue=false)]
        public int AffiliateLinkOid { get; set; }

        /// <summary>
        /// Affiliate object ID associated with this transaction
        /// </summary>
        /// <value>Affiliate object ID associated with this transaction</value>
        [DataMember(Name="affiliate_oid", EmitDefaultValue=false)]
        public int AffiliateOid { get; set; }

        /// <summary>
        /// User that assigned the transaction if it was done manually
        /// </summary>
        /// <value>User that assigned the transaction if it was done manually</value>
        [DataMember(Name="assigned_by_user", EmitDefaultValue=false)]
        public string AssignedByUser { get; set; }

        /// <summary>
        /// Gets or Sets Click
        /// </summary>
        [DataMember(Name="click", EmitDefaultValue=false)]
        public AffiliateClick Click { get; set; }

        /// <summary>
        /// Item ID associated with this transaction
        /// </summary>
        /// <value>Item ID associated with this transaction</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public AffiliateLink Link { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public Order Order { get; set; }

        /// <summary>
        /// Order ID associated with this transaction
        /// </summary>
        /// <value>Order ID associated with this transaction</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Date/time of the original transaction for reversals
        /// </summary>
        /// <value>Date/time of the original transaction for reversals</value>
        [DataMember(Name="original_transaction_dts", EmitDefaultValue=false)]
        public string OriginalTransactionDts { get; set; }

        /// <summary>
        /// Sub ID associated with transaction (from the click)
        /// </summary>
        /// <value>Sub ID associated with transaction (from the click)</value>
        [DataMember(Name="sub_id", EmitDefaultValue=false)]
        public string SubId { get; set; }

        /// <summary>
        /// Tier number that this transaction earned
        /// </summary>
        /// <value>Tier number that this transaction earned</value>
        [DataMember(Name="tier_number", EmitDefaultValue=false)]
        public int TierNumber { get; set; }

        /// <summary>
        /// Transaction amount
        /// </summary>
        /// <value>Transaction amount</value>
        [DataMember(Name="transaction_amount", EmitDefaultValue=false)]
        public decimal TransactionAmount { get; set; }

        /// <summary>
        /// Amount of the transaction that has been paid out.
        /// </summary>
        /// <value>Amount of the transaction that has been paid out.</value>
        [DataMember(Name="transaction_amount_paid", EmitDefaultValue=false)]
        public decimal TransactionAmountPaid { get; set; }

        /// <summary>
        /// Date/time that the transaction was made
        /// </summary>
        /// <value>Date/time that the transaction was made</value>
        [DataMember(Name="transaction_dts", EmitDefaultValue=false)]
        public string TransactionDts { get; set; }

        /// <summary>
        /// Memo explaining the transaction
        /// </summary>
        /// <value>Memo explaining the transaction</value>
        [DataMember(Name="transaction_memo", EmitDefaultValue=false)]
        public string TransactionMemo { get; set; }

        /// <summary>
        /// Percentage associated with this transaction
        /// </summary>
        /// <value>Percentage associated with this transaction</value>
        [DataMember(Name="transaction_percentage", EmitDefaultValue=false)]
        public decimal TransactionPercentage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffiliateLedger {\n");
            sb.Append("  AffiliateClickOid: ").Append(AffiliateClickOid).Append("\n");
            sb.Append("  AffiliateLedgerOid: ").Append(AffiliateLedgerOid).Append("\n");
            sb.Append("  AffiliateLinkOid: ").Append(AffiliateLinkOid).Append("\n");
            sb.Append("  AffiliateOid: ").Append(AffiliateOid).Append("\n");
            sb.Append("  AssignedByUser: ").Append(AssignedByUser).Append("\n");
            sb.Append("  Click: ").Append(Click).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OriginalTransactionDts: ").Append(OriginalTransactionDts).Append("\n");
            sb.Append("  SubId: ").Append(SubId).Append("\n");
            sb.Append("  TierNumber: ").Append(TierNumber).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionAmountPaid: ").Append(TransactionAmountPaid).Append("\n");
            sb.Append("  TransactionDts: ").Append(TransactionDts).Append("\n");
            sb.Append("  TransactionMemo: ").Append(TransactionMemo).Append("\n");
            sb.Append("  TransactionPercentage: ").Append(TransactionPercentage).Append("\n");
            sb.Append("  TransactionState: ").Append(TransactionState).Append("\n");
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
            return this.Equals(input as AffiliateLedger);
        }

        /// <summary>
        /// Returns true if AffiliateLedger instances are equal
        /// </summary>
        /// <param name="input">Instance of AffiliateLedger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffiliateLedger input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AffiliateClickOid == input.AffiliateClickOid ||
                    (this.AffiliateClickOid != null &&
                    this.AffiliateClickOid.Equals(input.AffiliateClickOid))
                ) && 
                (
                    this.AffiliateLedgerOid == input.AffiliateLedgerOid ||
                    (this.AffiliateLedgerOid != null &&
                    this.AffiliateLedgerOid.Equals(input.AffiliateLedgerOid))
                ) && 
                (
                    this.AffiliateLinkOid == input.AffiliateLinkOid ||
                    (this.AffiliateLinkOid != null &&
                    this.AffiliateLinkOid.Equals(input.AffiliateLinkOid))
                ) && 
                (
                    this.AffiliateOid == input.AffiliateOid ||
                    (this.AffiliateOid != null &&
                    this.AffiliateOid.Equals(input.AffiliateOid))
                ) && 
                (
                    this.AssignedByUser == input.AssignedByUser ||
                    (this.AssignedByUser != null &&
                    this.AssignedByUser.Equals(input.AssignedByUser))
                ) && 
                (
                    this.Click == input.Click ||
                    (this.Click != null &&
                    this.Click.Equals(input.Click))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                    this.OriginalTransactionDts == input.OriginalTransactionDts ||
                    (this.OriginalTransactionDts != null &&
                    this.OriginalTransactionDts.Equals(input.OriginalTransactionDts))
                ) && 
                (
                    this.SubId == input.SubId ||
                    (this.SubId != null &&
                    this.SubId.Equals(input.SubId))
                ) && 
                (
                    this.TierNumber == input.TierNumber ||
                    (this.TierNumber != null &&
                    this.TierNumber.Equals(input.TierNumber))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.TransactionAmountPaid == input.TransactionAmountPaid ||
                    (this.TransactionAmountPaid != null &&
                    this.TransactionAmountPaid.Equals(input.TransactionAmountPaid))
                ) && 
                (
                    this.TransactionDts == input.TransactionDts ||
                    (this.TransactionDts != null &&
                    this.TransactionDts.Equals(input.TransactionDts))
                ) && 
                (
                    this.TransactionMemo == input.TransactionMemo ||
                    (this.TransactionMemo != null &&
                    this.TransactionMemo.Equals(input.TransactionMemo))
                ) && 
                (
                    this.TransactionPercentage == input.TransactionPercentage ||
                    (this.TransactionPercentage != null &&
                    this.TransactionPercentage.Equals(input.TransactionPercentage))
                ) && 
                (
                    this.TransactionState == input.TransactionState ||
                    (this.TransactionState != null &&
                    this.TransactionState.Equals(input.TransactionState))
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
                if (this.AffiliateClickOid != null)
                    hashCode = hashCode * 59 + this.AffiliateClickOid.GetHashCode();
                if (this.AffiliateLedgerOid != null)
                    hashCode = hashCode * 59 + this.AffiliateLedgerOid.GetHashCode();
                if (this.AffiliateLinkOid != null)
                    hashCode = hashCode * 59 + this.AffiliateLinkOid.GetHashCode();
                if (this.AffiliateOid != null)
                    hashCode = hashCode * 59 + this.AffiliateOid.GetHashCode();
                if (this.AssignedByUser != null)
                    hashCode = hashCode * 59 + this.AssignedByUser.GetHashCode();
                if (this.Click != null)
                    hashCode = hashCode * 59 + this.Click.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OriginalTransactionDts != null)
                    hashCode = hashCode * 59 + this.OriginalTransactionDts.GetHashCode();
                if (this.SubId != null)
                    hashCode = hashCode * 59 + this.SubId.GetHashCode();
                if (this.TierNumber != null)
                    hashCode = hashCode * 59 + this.TierNumber.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.TransactionAmountPaid != null)
                    hashCode = hashCode * 59 + this.TransactionAmountPaid.GetHashCode();
                if (this.TransactionDts != null)
                    hashCode = hashCode * 59 + this.TransactionDts.GetHashCode();
                if (this.TransactionMemo != null)
                    hashCode = hashCode * 59 + this.TransactionMemo.GetHashCode();
                if (this.TransactionPercentage != null)
                    hashCode = hashCode * 59 + this.TransactionPercentage.GetHashCode();
                if (this.TransactionState != null)
                    hashCode = hashCode * 59 + this.TransactionState.GetHashCode();
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
