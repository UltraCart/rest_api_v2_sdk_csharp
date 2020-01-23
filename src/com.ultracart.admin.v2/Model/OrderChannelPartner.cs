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
    /// OrderChannelPartner
    /// </summary>
    [DataContract]
    public partial class OrderChannelPartner :  IEquatable<OrderChannelPartner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderChannelPartner" /> class.
        /// </summary>
        /// <param name="AutoApprovePurchaseOrder">If true, any purchase order submitted is automatically approved.</param>
        /// <param name="ChannelPartnerCode">The code of the channel partner.</param>
        /// <param name="ChannelPartnerData">Additional data provided by the channel partner, read-only.</param>
        /// <param name="ChannelPartnerOid">Channel partner object identifier, read-only and available on existing channel orders only..</param>
        /// <param name="ChannelPartnerOrderId">The order ID assigned by the channel partner for this order.</param>
        /// <param name="NoRealtimePaymentProcessing">Indicates this order should be placed in Account Receivable for later payment processing.</param>
        /// <param name="SkipPaymentProcessing">Indicates this order was already paid for via a channel purchase and no payment collection should be attempted.</param>
        /// <param name="StoreCompleted">Instructs UltraCart to skip shipping department and mark this order as fully complete.  Set this flag if you have already shipped product for this order..</param>
        /// <param name="StoreIfPaymentDeclines">If true, any failed payment will place the order in Accounts Receivable rather than rejecting it..</param>
        /// <param name="TreatWarningsAsErrors">Any warnings are raised as errors and halt the import of the order.</param>
        public OrderChannelPartner(bool? AutoApprovePurchaseOrder = default(bool?), string ChannelPartnerCode = default(string), string ChannelPartnerData = default(string), int? ChannelPartnerOid = default(int?), string ChannelPartnerOrderId = default(string), bool? NoRealtimePaymentProcessing = default(bool?), bool? SkipPaymentProcessing = default(bool?), bool? StoreCompleted = default(bool?), bool? StoreIfPaymentDeclines = default(bool?), bool? TreatWarningsAsErrors = default(bool?))
        {
            this.AutoApprovePurchaseOrder = AutoApprovePurchaseOrder;
            this.ChannelPartnerCode = ChannelPartnerCode;
            this.ChannelPartnerData = ChannelPartnerData;
            this.ChannelPartnerOid = ChannelPartnerOid;
            this.ChannelPartnerOrderId = ChannelPartnerOrderId;
            this.NoRealtimePaymentProcessing = NoRealtimePaymentProcessing;
            this.SkipPaymentProcessing = SkipPaymentProcessing;
            this.StoreCompleted = StoreCompleted;
            this.StoreIfPaymentDeclines = StoreIfPaymentDeclines;
            this.TreatWarningsAsErrors = TreatWarningsAsErrors;
        }
        
        /// <summary>
        /// If true, any purchase order submitted is automatically approved
        /// </summary>
        /// <value>If true, any purchase order submitted is automatically approved</value>
        [DataMember(Name="auto_approve_purchase_order", EmitDefaultValue=false)]
        public bool? AutoApprovePurchaseOrder { get; set; }

        /// <summary>
        /// The code of the channel partner
        /// </summary>
        /// <value>The code of the channel partner</value>
        [DataMember(Name="channel_partner_code", EmitDefaultValue=false)]
        public string ChannelPartnerCode { get; set; }

        /// <summary>
        /// Additional data provided by the channel partner, read-only
        /// </summary>
        /// <value>Additional data provided by the channel partner, read-only</value>
        [DataMember(Name="channel_partner_data", EmitDefaultValue=false)]
        public string ChannelPartnerData { get; set; }

        /// <summary>
        /// Channel partner object identifier, read-only and available on existing channel orders only.
        /// </summary>
        /// <value>Channel partner object identifier, read-only and available on existing channel orders only.</value>
        [DataMember(Name="channel_partner_oid", EmitDefaultValue=false)]
        public int? ChannelPartnerOid { get; set; }

        /// <summary>
        /// The order ID assigned by the channel partner for this order
        /// </summary>
        /// <value>The order ID assigned by the channel partner for this order</value>
        [DataMember(Name="channel_partner_order_id", EmitDefaultValue=false)]
        public string ChannelPartnerOrderId { get; set; }

        /// <summary>
        /// Indicates this order should be placed in Account Receivable for later payment processing
        /// </summary>
        /// <value>Indicates this order should be placed in Account Receivable for later payment processing</value>
        [DataMember(Name="no_realtime_payment_processing", EmitDefaultValue=false)]
        public bool? NoRealtimePaymentProcessing { get; set; }

        /// <summary>
        /// Indicates this order was already paid for via a channel purchase and no payment collection should be attempted
        /// </summary>
        /// <value>Indicates this order was already paid for via a channel purchase and no payment collection should be attempted</value>
        [DataMember(Name="skip_payment_processing", EmitDefaultValue=false)]
        public bool? SkipPaymentProcessing { get; set; }

        /// <summary>
        /// Instructs UltraCart to skip shipping department and mark this order as fully complete.  Set this flag if you have already shipped product for this order.
        /// </summary>
        /// <value>Instructs UltraCart to skip shipping department and mark this order as fully complete.  Set this flag if you have already shipped product for this order.</value>
        [DataMember(Name="store_completed", EmitDefaultValue=false)]
        public bool? StoreCompleted { get; set; }

        /// <summary>
        /// If true, any failed payment will place the order in Accounts Receivable rather than rejecting it.
        /// </summary>
        /// <value>If true, any failed payment will place the order in Accounts Receivable rather than rejecting it.</value>
        [DataMember(Name="store_if_payment_declines", EmitDefaultValue=false)]
        public bool? StoreIfPaymentDeclines { get; set; }

        /// <summary>
        /// Any warnings are raised as errors and halt the import of the order
        /// </summary>
        /// <value>Any warnings are raised as errors and halt the import of the order</value>
        [DataMember(Name="treat_warnings_as_errors", EmitDefaultValue=false)]
        public bool? TreatWarningsAsErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderChannelPartner {\n");
            sb.Append("  AutoApprovePurchaseOrder: ").Append(AutoApprovePurchaseOrder).Append("\n");
            sb.Append("  ChannelPartnerCode: ").Append(ChannelPartnerCode).Append("\n");
            sb.Append("  ChannelPartnerData: ").Append(ChannelPartnerData).Append("\n");
            sb.Append("  ChannelPartnerOid: ").Append(ChannelPartnerOid).Append("\n");
            sb.Append("  ChannelPartnerOrderId: ").Append(ChannelPartnerOrderId).Append("\n");
            sb.Append("  NoRealtimePaymentProcessing: ").Append(NoRealtimePaymentProcessing).Append("\n");
            sb.Append("  SkipPaymentProcessing: ").Append(SkipPaymentProcessing).Append("\n");
            sb.Append("  StoreCompleted: ").Append(StoreCompleted).Append("\n");
            sb.Append("  StoreIfPaymentDeclines: ").Append(StoreIfPaymentDeclines).Append("\n");
            sb.Append("  TreatWarningsAsErrors: ").Append(TreatWarningsAsErrors).Append("\n");
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
            return this.Equals(input as OrderChannelPartner);
        }

        /// <summary>
        /// Returns true if OrderChannelPartner instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderChannelPartner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderChannelPartner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoApprovePurchaseOrder == input.AutoApprovePurchaseOrder ||
                    (this.AutoApprovePurchaseOrder != null &&
                    this.AutoApprovePurchaseOrder.Equals(input.AutoApprovePurchaseOrder))
                ) && 
                (
                    this.ChannelPartnerCode == input.ChannelPartnerCode ||
                    (this.ChannelPartnerCode != null &&
                    this.ChannelPartnerCode.Equals(input.ChannelPartnerCode))
                ) && 
                (
                    this.ChannelPartnerData == input.ChannelPartnerData ||
                    (this.ChannelPartnerData != null &&
                    this.ChannelPartnerData.Equals(input.ChannelPartnerData))
                ) && 
                (
                    this.ChannelPartnerOid == input.ChannelPartnerOid ||
                    (this.ChannelPartnerOid != null &&
                    this.ChannelPartnerOid.Equals(input.ChannelPartnerOid))
                ) && 
                (
                    this.ChannelPartnerOrderId == input.ChannelPartnerOrderId ||
                    (this.ChannelPartnerOrderId != null &&
                    this.ChannelPartnerOrderId.Equals(input.ChannelPartnerOrderId))
                ) && 
                (
                    this.NoRealtimePaymentProcessing == input.NoRealtimePaymentProcessing ||
                    (this.NoRealtimePaymentProcessing != null &&
                    this.NoRealtimePaymentProcessing.Equals(input.NoRealtimePaymentProcessing))
                ) && 
                (
                    this.SkipPaymentProcessing == input.SkipPaymentProcessing ||
                    (this.SkipPaymentProcessing != null &&
                    this.SkipPaymentProcessing.Equals(input.SkipPaymentProcessing))
                ) && 
                (
                    this.StoreCompleted == input.StoreCompleted ||
                    (this.StoreCompleted != null &&
                    this.StoreCompleted.Equals(input.StoreCompleted))
                ) && 
                (
                    this.StoreIfPaymentDeclines == input.StoreIfPaymentDeclines ||
                    (this.StoreIfPaymentDeclines != null &&
                    this.StoreIfPaymentDeclines.Equals(input.StoreIfPaymentDeclines))
                ) && 
                (
                    this.TreatWarningsAsErrors == input.TreatWarningsAsErrors ||
                    (this.TreatWarningsAsErrors != null &&
                    this.TreatWarningsAsErrors.Equals(input.TreatWarningsAsErrors))
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
                if (this.AutoApprovePurchaseOrder != null)
                    hashCode = hashCode * 59 + this.AutoApprovePurchaseOrder.GetHashCode();
                if (this.ChannelPartnerCode != null)
                    hashCode = hashCode * 59 + this.ChannelPartnerCode.GetHashCode();
                if (this.ChannelPartnerData != null)
                    hashCode = hashCode * 59 + this.ChannelPartnerData.GetHashCode();
                if (this.ChannelPartnerOid != null)
                    hashCode = hashCode * 59 + this.ChannelPartnerOid.GetHashCode();
                if (this.ChannelPartnerOrderId != null)
                    hashCode = hashCode * 59 + this.ChannelPartnerOrderId.GetHashCode();
                if (this.NoRealtimePaymentProcessing != null)
                    hashCode = hashCode * 59 + this.NoRealtimePaymentProcessing.GetHashCode();
                if (this.SkipPaymentProcessing != null)
                    hashCode = hashCode * 59 + this.SkipPaymentProcessing.GetHashCode();
                if (this.StoreCompleted != null)
                    hashCode = hashCode * 59 + this.StoreCompleted.GetHashCode();
                if (this.StoreIfPaymentDeclines != null)
                    hashCode = hashCode * 59 + this.StoreIfPaymentDeclines.GetHashCode();
                if (this.TreatWarningsAsErrors != null)
                    hashCode = hashCode * 59 + this.TreatWarningsAsErrors.GetHashCode();
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
