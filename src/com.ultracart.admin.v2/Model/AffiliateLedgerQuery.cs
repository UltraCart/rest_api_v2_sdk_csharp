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
    /// AffiliateLedgerQuery
    /// </summary>
    [DataContract]
    public partial class AffiliateLedgerQuery :  IEquatable<AffiliateLedgerQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateLedgerQuery" /> class.
        /// </summary>
        /// <param name="AffiliateOid">Affiliate ID associated with the ledger.</param>
        /// <param name="ItemId">Item id associated with the ledger entry.</param>
        /// <param name="OrderId">Order ID associated with the ledger entries.</param>
        /// <param name="SubId">Sub ID value passed on the click that generated the ledger.</param>
        /// <param name="TransactionDtsBegin">Minimum transaction date/time to return.</param>
        /// <param name="TransactionDtsEnd">Maximum transaction date/time to return.</param>
        public AffiliateLedgerQuery(int? AffiliateOid = default(int?), string ItemId = default(string), string OrderId = default(string), string SubId = default(string), string TransactionDtsBegin = default(string), string TransactionDtsEnd = default(string))
        {
            this.AffiliateOid = AffiliateOid;
            this.ItemId = ItemId;
            this.OrderId = OrderId;
            this.SubId = SubId;
            this.TransactionDtsBegin = TransactionDtsBegin;
            this.TransactionDtsEnd = TransactionDtsEnd;
        }
        
        /// <summary>
        /// Affiliate ID associated with the ledger
        /// </summary>
        /// <value>Affiliate ID associated with the ledger</value>
        [DataMember(Name="affiliate_oid", EmitDefaultValue=false)]
        public int? AffiliateOid { get; set; }

        /// <summary>
        /// Item id associated with the ledger entry
        /// </summary>
        /// <value>Item id associated with the ledger entry</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Order ID associated with the ledger entries
        /// </summary>
        /// <value>Order ID associated with the ledger entries</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Sub ID value passed on the click that generated the ledger
        /// </summary>
        /// <value>Sub ID value passed on the click that generated the ledger</value>
        [DataMember(Name="sub_id", EmitDefaultValue=false)]
        public string SubId { get; set; }

        /// <summary>
        /// Minimum transaction date/time to return
        /// </summary>
        /// <value>Minimum transaction date/time to return</value>
        [DataMember(Name="transaction_dts_begin", EmitDefaultValue=false)]
        public string TransactionDtsBegin { get; set; }

        /// <summary>
        /// Maximum transaction date/time to return
        /// </summary>
        /// <value>Maximum transaction date/time to return</value>
        [DataMember(Name="transaction_dts_end", EmitDefaultValue=false)]
        public string TransactionDtsEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffiliateLedgerQuery {\n");
            sb.Append("  AffiliateOid: ").Append(AffiliateOid).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  SubId: ").Append(SubId).Append("\n");
            sb.Append("  TransactionDtsBegin: ").Append(TransactionDtsBegin).Append("\n");
            sb.Append("  TransactionDtsEnd: ").Append(TransactionDtsEnd).Append("\n");
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
            return this.Equals(input as AffiliateLedgerQuery);
        }

        /// <summary>
        /// Returns true if AffiliateLedgerQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of AffiliateLedgerQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffiliateLedgerQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AffiliateOid == input.AffiliateOid ||
                    (this.AffiliateOid != null &&
                    this.AffiliateOid.Equals(input.AffiliateOid))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.SubId == input.SubId ||
                    (this.SubId != null &&
                    this.SubId.Equals(input.SubId))
                ) && 
                (
                    this.TransactionDtsBegin == input.TransactionDtsBegin ||
                    (this.TransactionDtsBegin != null &&
                    this.TransactionDtsBegin.Equals(input.TransactionDtsBegin))
                ) && 
                (
                    this.TransactionDtsEnd == input.TransactionDtsEnd ||
                    (this.TransactionDtsEnd != null &&
                    this.TransactionDtsEnd.Equals(input.TransactionDtsEnd))
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
                if (this.AffiliateOid != null)
                    hashCode = hashCode * 59 + this.AffiliateOid.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.SubId != null)
                    hashCode = hashCode * 59 + this.SubId.GetHashCode();
                if (this.TransactionDtsBegin != null)
                    hashCode = hashCode * 59 + this.TransactionDtsBegin.GetHashCode();
                if (this.TransactionDtsEnd != null)
                    hashCode = hashCode * 59 + this.TransactionDtsEnd.GetHashCode();
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
