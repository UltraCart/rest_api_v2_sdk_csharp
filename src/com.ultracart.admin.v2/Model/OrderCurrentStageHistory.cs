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
    /// OrderCurrentStageHistory
    /// </summary>
    [DataContract]
    public partial class OrderCurrentStageHistory :  IEquatable<OrderCurrentStageHistory>, IValidatableObject
    {
        /// <summary>
        /// New stage that the order is in.
        /// </summary>
        /// <value>New stage that the order is in.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AfterStageEnum
        {
            
            /// <summary>
            /// Enum AccountsReceivable for value: Accounts Receivable
            /// </summary>
            [EnumMember(Value = "Accounts Receivable")]
            AccountsReceivable = 1,
            
            /// <summary>
            /// Enum PendingClearance for value: Pending Clearance
            /// </summary>
            [EnumMember(Value = "Pending Clearance")]
            PendingClearance = 2,
            
            /// <summary>
            /// Enum FraudReview for value: Fraud Review
            /// </summary>
            [EnumMember(Value = "Fraud Review")]
            FraudReview = 3,
            
            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected = 4,
            
            /// <summary>
            /// Enum ShippingDepartment for value: Shipping Department
            /// </summary>
            [EnumMember(Value = "Shipping Department")]
            ShippingDepartment = 5,
            
            /// <summary>
            /// Enum CompletedOrder for value: Completed Order
            /// </summary>
            [EnumMember(Value = "Completed Order")]
            CompletedOrder = 6,
            
            /// <summary>
            /// Enum QuoteRequest for value: Quote Request
            /// </summary>
            [EnumMember(Value = "Quote Request")]
            QuoteRequest = 7,
            
            /// <summary>
            /// Enum QuoteSent for value: Quote Sent
            /// </summary>
            [EnumMember(Value = "Quote Sent")]
            QuoteSent = 8,
            
            /// <summary>
            /// Enum LeastCostRouting for value: Least Cost Routing
            /// </summary>
            [EnumMember(Value = "Least Cost Routing")]
            LeastCostRouting = 9,
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 10,
            
            /// <summary>
            /// Enum PreOrdered for value: Pre-ordered
            /// </summary>
            [EnumMember(Value = "Pre-ordered")]
            PreOrdered = 11,
            
            /// <summary>
            /// Enum AdvancedOrderRouting for value: Advanced Order Routing
            /// </summary>
            [EnumMember(Value = "Advanced Order Routing")]
            AdvancedOrderRouting = 12,
            
            /// <summary>
            /// Enum Hold for value: Hold
            /// </summary>
            [EnumMember(Value = "Hold")]
            Hold = 13
        }

        /// <summary>
        /// New stage that the order is in.
        /// </summary>
        /// <value>New stage that the order is in.</value>
        [DataMember(Name="after_stage", EmitDefaultValue=false)]
        public AfterStageEnum? AfterStage { get; set; }
        /// <summary>
        /// Previous stage that the order was in.
        /// </summary>
        /// <value>Previous stage that the order was in.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BeforeStageEnum
        {
            
            /// <summary>
            /// Enum AccountsReceivable for value: Accounts Receivable
            /// </summary>
            [EnumMember(Value = "Accounts Receivable")]
            AccountsReceivable = 1,
            
            /// <summary>
            /// Enum PendingClearance for value: Pending Clearance
            /// </summary>
            [EnumMember(Value = "Pending Clearance")]
            PendingClearance = 2,
            
            /// <summary>
            /// Enum FraudReview for value: Fraud Review
            /// </summary>
            [EnumMember(Value = "Fraud Review")]
            FraudReview = 3,
            
            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected = 4,
            
            /// <summary>
            /// Enum ShippingDepartment for value: Shipping Department
            /// </summary>
            [EnumMember(Value = "Shipping Department")]
            ShippingDepartment = 5,
            
            /// <summary>
            /// Enum CompletedOrder for value: Completed Order
            /// </summary>
            [EnumMember(Value = "Completed Order")]
            CompletedOrder = 6,
            
            /// <summary>
            /// Enum QuoteRequest for value: Quote Request
            /// </summary>
            [EnumMember(Value = "Quote Request")]
            QuoteRequest = 7,
            
            /// <summary>
            /// Enum QuoteSent for value: Quote Sent
            /// </summary>
            [EnumMember(Value = "Quote Sent")]
            QuoteSent = 8,
            
            /// <summary>
            /// Enum LeastCostRouting for value: Least Cost Routing
            /// </summary>
            [EnumMember(Value = "Least Cost Routing")]
            LeastCostRouting = 9,
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 10,
            
            /// <summary>
            /// Enum PreOrdered for value: Pre-ordered
            /// </summary>
            [EnumMember(Value = "Pre-ordered")]
            PreOrdered = 11,
            
            /// <summary>
            /// Enum AdvancedOrderRouting for value: Advanced Order Routing
            /// </summary>
            [EnumMember(Value = "Advanced Order Routing")]
            AdvancedOrderRouting = 12,
            
            /// <summary>
            /// Enum Hold for value: Hold
            /// </summary>
            [EnumMember(Value = "Hold")]
            Hold = 13
        }

        /// <summary>
        /// Previous stage that the order was in.
        /// </summary>
        /// <value>Previous stage that the order was in.</value>
        [DataMember(Name="before_stage", EmitDefaultValue=false)]
        public BeforeStageEnum? BeforeStage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCurrentStageHistory" /> class.
        /// </summary>
        /// <param name="afterStage">New stage that the order is in..</param>
        /// <param name="beforeStage">Previous stage that the order was in..</param>
        /// <param name="transitionDts">Date/time that the stage transitioned.</param>
        public OrderCurrentStageHistory(AfterStageEnum? afterStage = default(AfterStageEnum?), BeforeStageEnum? beforeStage = default(BeforeStageEnum?), string transitionDts = default(string))
        {
            this.AfterStage = afterStage;
            this.BeforeStage = beforeStage;
            this.TransitionDts = transitionDts;
        }
        


        /// <summary>
        /// Date/time that the stage transitioned
        /// </summary>
        /// <value>Date/time that the stage transitioned</value>
        [DataMember(Name="transition_dts", EmitDefaultValue=false)]
        public string TransitionDts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderCurrentStageHistory {\n");
            sb.Append("  AfterStage: ").Append(AfterStage).Append("\n");
            sb.Append("  BeforeStage: ").Append(BeforeStage).Append("\n");
            sb.Append("  TransitionDts: ").Append(TransitionDts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as OrderCurrentStageHistory);
        }

        /// <summary>
        /// Returns true if OrderCurrentStageHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderCurrentStageHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderCurrentStageHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AfterStage == input.AfterStage ||
                    (this.AfterStage != null &&
                    this.AfterStage.Equals(input.AfterStage))
                ) && 
                (
                    this.BeforeStage == input.BeforeStage ||
                    (this.BeforeStage != null &&
                    this.BeforeStage.Equals(input.BeforeStage))
                ) && 
                (
                    this.TransitionDts == input.TransitionDts ||
                    (this.TransitionDts != null &&
                    this.TransitionDts.Equals(input.TransitionDts))
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
                if (this.AfterStage != null)
                    hashCode = hashCode * 59 + this.AfterStage.GetHashCode();
                if (this.BeforeStage != null)
                    hashCode = hashCode * 59 + this.BeforeStage.GetHashCode();
                if (this.TransitionDts != null)
                    hashCode = hashCode * 59 + this.TransitionDts.GetHashCode();
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
