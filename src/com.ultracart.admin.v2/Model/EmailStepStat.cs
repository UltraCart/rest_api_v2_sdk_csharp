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
    /// EmailStepStat
    /// </summary>
    [DataContract]
    public partial class EmailStepStat :  IEquatable<EmailStepStat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailStepStat" /> class.
        /// </summary>
        /// <param name="leftClickCount">click count (left side).</param>
        /// <param name="leftClickCountFormatted">click count formatted (left side).</param>
        /// <param name="leftConversionCount">conversion count (left/default side).</param>
        /// <param name="leftConversionCountFormatted">conversion count formatted (left/default side).</param>
        /// <param name="leftCustomerCount">customer count (left/default side).</param>
        /// <param name="leftCustomerCountFormatted">customer count formatted (left/default side).</param>
        /// <param name="leftDeliveredCount">delivered count (left side).</param>
        /// <param name="leftDeliveredCountFormatted">delivered count formatted (left side).</param>
        /// <param name="leftOrderCount">order count (left/default side).</param>
        /// <param name="leftOrderCountFormatted">order count formatted (left/default side).</param>
        /// <param name="leftProfit">profit (left/default side).</param>
        /// <param name="leftProfitFormatted">profit formatted (left/default side).</param>
        /// <param name="leftRevenue">revenue (left/default side).</param>
        /// <param name="leftRevenueFormatted">revenue formatted (left/default side).</param>
        /// <param name="leftSendCount">send count (left side).</param>
        /// <param name="leftSendCountFormatted">send count formatted (left side).</param>
        /// <param name="leftSkippedCount">conversion count (left side).</param>
        /// <param name="leftSkippedCountFormatted">skipped count formatted (left side).</param>
        /// <param name="leftUnsubscribeCount">unsubscribe count (left side).</param>
        /// <param name="leftUnsubscribeCountFormatted">unsubscribe count formatted (left side).</param>
        /// <param name="rightConversionCount">conversion count (right side).</param>
        /// <param name="rightConversionCountFormatted">conversion count formatted (right side).</param>
        /// <param name="rightCustomerCount">customer count (right side).</param>
        /// <param name="rightCustomerCountFormatted">customer count formatted (right side).</param>
        /// <param name="rightOrderCount">order count (right side).</param>
        /// <param name="rightOrderCountFormatted">order count formatted (right side).</param>
        /// <param name="rightProfit">profit (right side).</param>
        /// <param name="rightProfitFormatted">profit formatted (right side).</param>
        /// <param name="rightRevenue">revenue (right side).</param>
        /// <param name="rightRevenueFormatted">revenue formatted (right side).</param>
        public EmailStepStat(int? leftClickCount = default(int?), string leftClickCountFormatted = default(string), int? leftConversionCount = default(int?), string leftConversionCountFormatted = default(string), int? leftCustomerCount = default(int?), string leftCustomerCountFormatted = default(string), int? leftDeliveredCount = default(int?), string leftDeliveredCountFormatted = default(string), int? leftOrderCount = default(int?), string leftOrderCountFormatted = default(string), decimal? leftProfit = default(decimal?), string leftProfitFormatted = default(string), decimal? leftRevenue = default(decimal?), string leftRevenueFormatted = default(string), int? leftSendCount = default(int?), string leftSendCountFormatted = default(string), int? leftSkippedCount = default(int?), string leftSkippedCountFormatted = default(string), int? leftUnsubscribeCount = default(int?), string leftUnsubscribeCountFormatted = default(string), int? rightConversionCount = default(int?), string rightConversionCountFormatted = default(string), int? rightCustomerCount = default(int?), string rightCustomerCountFormatted = default(string), int? rightOrderCount = default(int?), string rightOrderCountFormatted = default(string), decimal? rightProfit = default(decimal?), string rightProfitFormatted = default(string), decimal? rightRevenue = default(decimal?), string rightRevenueFormatted = default(string))
        {
            this.LeftClickCount = leftClickCount;
            this.LeftClickCountFormatted = leftClickCountFormatted;
            this.LeftConversionCount = leftConversionCount;
            this.LeftConversionCountFormatted = leftConversionCountFormatted;
            this.LeftCustomerCount = leftCustomerCount;
            this.LeftCustomerCountFormatted = leftCustomerCountFormatted;
            this.LeftDeliveredCount = leftDeliveredCount;
            this.LeftDeliveredCountFormatted = leftDeliveredCountFormatted;
            this.LeftOrderCount = leftOrderCount;
            this.LeftOrderCountFormatted = leftOrderCountFormatted;
            this.LeftProfit = leftProfit;
            this.LeftProfitFormatted = leftProfitFormatted;
            this.LeftRevenue = leftRevenue;
            this.LeftRevenueFormatted = leftRevenueFormatted;
            this.LeftSendCount = leftSendCount;
            this.LeftSendCountFormatted = leftSendCountFormatted;
            this.LeftSkippedCount = leftSkippedCount;
            this.LeftSkippedCountFormatted = leftSkippedCountFormatted;
            this.LeftUnsubscribeCount = leftUnsubscribeCount;
            this.LeftUnsubscribeCountFormatted = leftUnsubscribeCountFormatted;
            this.RightConversionCount = rightConversionCount;
            this.RightConversionCountFormatted = rightConversionCountFormatted;
            this.RightCustomerCount = rightCustomerCount;
            this.RightCustomerCountFormatted = rightCustomerCountFormatted;
            this.RightOrderCount = rightOrderCount;
            this.RightOrderCountFormatted = rightOrderCountFormatted;
            this.RightProfit = rightProfit;
            this.RightProfitFormatted = rightProfitFormatted;
            this.RightRevenue = rightRevenue;
            this.RightRevenueFormatted = rightRevenueFormatted;
        }
        
        /// <summary>
        /// click count (left side)
        /// </summary>
        /// <value>click count (left side)</value>
        [DataMember(Name="left_click_count", EmitDefaultValue=false)]
        public int? LeftClickCount { get; set; }

        /// <summary>
        /// click count formatted (left side)
        /// </summary>
        /// <value>click count formatted (left side)</value>
        [DataMember(Name="left_click_count_formatted", EmitDefaultValue=false)]
        public string LeftClickCountFormatted { get; set; }

        /// <summary>
        /// conversion count (left/default side)
        /// </summary>
        /// <value>conversion count (left/default side)</value>
        [DataMember(Name="left_conversion_count", EmitDefaultValue=false)]
        public int? LeftConversionCount { get; set; }

        /// <summary>
        /// conversion count formatted (left/default side)
        /// </summary>
        /// <value>conversion count formatted (left/default side)</value>
        [DataMember(Name="left_conversion_count_formatted", EmitDefaultValue=false)]
        public string LeftConversionCountFormatted { get; set; }

        /// <summary>
        /// customer count (left/default side)
        /// </summary>
        /// <value>customer count (left/default side)</value>
        [DataMember(Name="left_customer_count", EmitDefaultValue=false)]
        public int? LeftCustomerCount { get; set; }

        /// <summary>
        /// customer count formatted (left/default side)
        /// </summary>
        /// <value>customer count formatted (left/default side)</value>
        [DataMember(Name="left_customer_count_formatted", EmitDefaultValue=false)]
        public string LeftCustomerCountFormatted { get; set; }

        /// <summary>
        /// delivered count (left side)
        /// </summary>
        /// <value>delivered count (left side)</value>
        [DataMember(Name="left_delivered_count", EmitDefaultValue=false)]
        public int? LeftDeliveredCount { get; set; }

        /// <summary>
        /// delivered count formatted (left side)
        /// </summary>
        /// <value>delivered count formatted (left side)</value>
        [DataMember(Name="left_delivered_count_formatted", EmitDefaultValue=false)]
        public string LeftDeliveredCountFormatted { get; set; }

        /// <summary>
        /// order count (left/default side)
        /// </summary>
        /// <value>order count (left/default side)</value>
        [DataMember(Name="left_order_count", EmitDefaultValue=false)]
        public int? LeftOrderCount { get; set; }

        /// <summary>
        /// order count formatted (left/default side)
        /// </summary>
        /// <value>order count formatted (left/default side)</value>
        [DataMember(Name="left_order_count_formatted", EmitDefaultValue=false)]
        public string LeftOrderCountFormatted { get; set; }

        /// <summary>
        /// profit (left/default side)
        /// </summary>
        /// <value>profit (left/default side)</value>
        [DataMember(Name="left_profit", EmitDefaultValue=false)]
        public decimal? LeftProfit { get; set; }

        /// <summary>
        /// profit formatted (left/default side)
        /// </summary>
        /// <value>profit formatted (left/default side)</value>
        [DataMember(Name="left_profit_formatted", EmitDefaultValue=false)]
        public string LeftProfitFormatted { get; set; }

        /// <summary>
        /// revenue (left/default side)
        /// </summary>
        /// <value>revenue (left/default side)</value>
        [DataMember(Name="left_revenue", EmitDefaultValue=false)]
        public decimal? LeftRevenue { get; set; }

        /// <summary>
        /// revenue formatted (left/default side)
        /// </summary>
        /// <value>revenue formatted (left/default side)</value>
        [DataMember(Name="left_revenue_formatted", EmitDefaultValue=false)]
        public string LeftRevenueFormatted { get; set; }

        /// <summary>
        /// send count (left side)
        /// </summary>
        /// <value>send count (left side)</value>
        [DataMember(Name="left_send_count", EmitDefaultValue=false)]
        public int? LeftSendCount { get; set; }

        /// <summary>
        /// send count formatted (left side)
        /// </summary>
        /// <value>send count formatted (left side)</value>
        [DataMember(Name="left_send_count_formatted", EmitDefaultValue=false)]
        public string LeftSendCountFormatted { get; set; }

        /// <summary>
        /// conversion count (left side)
        /// </summary>
        /// <value>conversion count (left side)</value>
        [DataMember(Name="left_skipped_count", EmitDefaultValue=false)]
        public int? LeftSkippedCount { get; set; }

        /// <summary>
        /// skipped count formatted (left side)
        /// </summary>
        /// <value>skipped count formatted (left side)</value>
        [DataMember(Name="left_skipped_count_formatted", EmitDefaultValue=false)]
        public string LeftSkippedCountFormatted { get; set; }

        /// <summary>
        /// unsubscribe count (left side)
        /// </summary>
        /// <value>unsubscribe count (left side)</value>
        [DataMember(Name="left_unsubscribe_count", EmitDefaultValue=false)]
        public int? LeftUnsubscribeCount { get; set; }

        /// <summary>
        /// unsubscribe count formatted (left side)
        /// </summary>
        /// <value>unsubscribe count formatted (left side)</value>
        [DataMember(Name="left_unsubscribe_count_formatted", EmitDefaultValue=false)]
        public string LeftUnsubscribeCountFormatted { get; set; }

        /// <summary>
        /// conversion count (right side)
        /// </summary>
        /// <value>conversion count (right side)</value>
        [DataMember(Name="right_conversion_count", EmitDefaultValue=false)]
        public int? RightConversionCount { get; set; }

        /// <summary>
        /// conversion count formatted (right side)
        /// </summary>
        /// <value>conversion count formatted (right side)</value>
        [DataMember(Name="right_conversion_count_formatted", EmitDefaultValue=false)]
        public string RightConversionCountFormatted { get; set; }

        /// <summary>
        /// customer count (right side)
        /// </summary>
        /// <value>customer count (right side)</value>
        [DataMember(Name="right_customer_count", EmitDefaultValue=false)]
        public int? RightCustomerCount { get; set; }

        /// <summary>
        /// customer count formatted (right side)
        /// </summary>
        /// <value>customer count formatted (right side)</value>
        [DataMember(Name="right_customer_count_formatted", EmitDefaultValue=false)]
        public string RightCustomerCountFormatted { get; set; }

        /// <summary>
        /// order count (right side)
        /// </summary>
        /// <value>order count (right side)</value>
        [DataMember(Name="right_order_count", EmitDefaultValue=false)]
        public int? RightOrderCount { get; set; }

        /// <summary>
        /// order count formatted (right side)
        /// </summary>
        /// <value>order count formatted (right side)</value>
        [DataMember(Name="right_order_count_formatted", EmitDefaultValue=false)]
        public string RightOrderCountFormatted { get; set; }

        /// <summary>
        /// profit (right side)
        /// </summary>
        /// <value>profit (right side)</value>
        [DataMember(Name="right_profit", EmitDefaultValue=false)]
        public decimal? RightProfit { get; set; }

        /// <summary>
        /// profit formatted (right side)
        /// </summary>
        /// <value>profit formatted (right side)</value>
        [DataMember(Name="right_profit_formatted", EmitDefaultValue=false)]
        public string RightProfitFormatted { get; set; }

        /// <summary>
        /// revenue (right side)
        /// </summary>
        /// <value>revenue (right side)</value>
        [DataMember(Name="right_revenue", EmitDefaultValue=false)]
        public decimal? RightRevenue { get; set; }

        /// <summary>
        /// revenue formatted (right side)
        /// </summary>
        /// <value>revenue formatted (right side)</value>
        [DataMember(Name="right_revenue_formatted", EmitDefaultValue=false)]
        public string RightRevenueFormatted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailStepStat {\n");
            sb.Append("  LeftClickCount: ").Append(LeftClickCount).Append("\n");
            sb.Append("  LeftClickCountFormatted: ").Append(LeftClickCountFormatted).Append("\n");
            sb.Append("  LeftConversionCount: ").Append(LeftConversionCount).Append("\n");
            sb.Append("  LeftConversionCountFormatted: ").Append(LeftConversionCountFormatted).Append("\n");
            sb.Append("  LeftCustomerCount: ").Append(LeftCustomerCount).Append("\n");
            sb.Append("  LeftCustomerCountFormatted: ").Append(LeftCustomerCountFormatted).Append("\n");
            sb.Append("  LeftDeliveredCount: ").Append(LeftDeliveredCount).Append("\n");
            sb.Append("  LeftDeliveredCountFormatted: ").Append(LeftDeliveredCountFormatted).Append("\n");
            sb.Append("  LeftOrderCount: ").Append(LeftOrderCount).Append("\n");
            sb.Append("  LeftOrderCountFormatted: ").Append(LeftOrderCountFormatted).Append("\n");
            sb.Append("  LeftProfit: ").Append(LeftProfit).Append("\n");
            sb.Append("  LeftProfitFormatted: ").Append(LeftProfitFormatted).Append("\n");
            sb.Append("  LeftRevenue: ").Append(LeftRevenue).Append("\n");
            sb.Append("  LeftRevenueFormatted: ").Append(LeftRevenueFormatted).Append("\n");
            sb.Append("  LeftSendCount: ").Append(LeftSendCount).Append("\n");
            sb.Append("  LeftSendCountFormatted: ").Append(LeftSendCountFormatted).Append("\n");
            sb.Append("  LeftSkippedCount: ").Append(LeftSkippedCount).Append("\n");
            sb.Append("  LeftSkippedCountFormatted: ").Append(LeftSkippedCountFormatted).Append("\n");
            sb.Append("  LeftUnsubscribeCount: ").Append(LeftUnsubscribeCount).Append("\n");
            sb.Append("  LeftUnsubscribeCountFormatted: ").Append(LeftUnsubscribeCountFormatted).Append("\n");
            sb.Append("  RightConversionCount: ").Append(RightConversionCount).Append("\n");
            sb.Append("  RightConversionCountFormatted: ").Append(RightConversionCountFormatted).Append("\n");
            sb.Append("  RightCustomerCount: ").Append(RightCustomerCount).Append("\n");
            sb.Append("  RightCustomerCountFormatted: ").Append(RightCustomerCountFormatted).Append("\n");
            sb.Append("  RightOrderCount: ").Append(RightOrderCount).Append("\n");
            sb.Append("  RightOrderCountFormatted: ").Append(RightOrderCountFormatted).Append("\n");
            sb.Append("  RightProfit: ").Append(RightProfit).Append("\n");
            sb.Append("  RightProfitFormatted: ").Append(RightProfitFormatted).Append("\n");
            sb.Append("  RightRevenue: ").Append(RightRevenue).Append("\n");
            sb.Append("  RightRevenueFormatted: ").Append(RightRevenueFormatted).Append("\n");
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
            return this.Equals(input as EmailStepStat);
        }

        /// <summary>
        /// Returns true if EmailStepStat instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailStepStat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailStepStat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LeftClickCount == input.LeftClickCount ||
                    (this.LeftClickCount != null &&
                    this.LeftClickCount.Equals(input.LeftClickCount))
                ) && 
                (
                    this.LeftClickCountFormatted == input.LeftClickCountFormatted ||
                    (this.LeftClickCountFormatted != null &&
                    this.LeftClickCountFormatted.Equals(input.LeftClickCountFormatted))
                ) && 
                (
                    this.LeftConversionCount == input.LeftConversionCount ||
                    (this.LeftConversionCount != null &&
                    this.LeftConversionCount.Equals(input.LeftConversionCount))
                ) && 
                (
                    this.LeftConversionCountFormatted == input.LeftConversionCountFormatted ||
                    (this.LeftConversionCountFormatted != null &&
                    this.LeftConversionCountFormatted.Equals(input.LeftConversionCountFormatted))
                ) && 
                (
                    this.LeftCustomerCount == input.LeftCustomerCount ||
                    (this.LeftCustomerCount != null &&
                    this.LeftCustomerCount.Equals(input.LeftCustomerCount))
                ) && 
                (
                    this.LeftCustomerCountFormatted == input.LeftCustomerCountFormatted ||
                    (this.LeftCustomerCountFormatted != null &&
                    this.LeftCustomerCountFormatted.Equals(input.LeftCustomerCountFormatted))
                ) && 
                (
                    this.LeftDeliveredCount == input.LeftDeliveredCount ||
                    (this.LeftDeliveredCount != null &&
                    this.LeftDeliveredCount.Equals(input.LeftDeliveredCount))
                ) && 
                (
                    this.LeftDeliveredCountFormatted == input.LeftDeliveredCountFormatted ||
                    (this.LeftDeliveredCountFormatted != null &&
                    this.LeftDeliveredCountFormatted.Equals(input.LeftDeliveredCountFormatted))
                ) && 
                (
                    this.LeftOrderCount == input.LeftOrderCount ||
                    (this.LeftOrderCount != null &&
                    this.LeftOrderCount.Equals(input.LeftOrderCount))
                ) && 
                (
                    this.LeftOrderCountFormatted == input.LeftOrderCountFormatted ||
                    (this.LeftOrderCountFormatted != null &&
                    this.LeftOrderCountFormatted.Equals(input.LeftOrderCountFormatted))
                ) && 
                (
                    this.LeftProfit == input.LeftProfit ||
                    (this.LeftProfit != null &&
                    this.LeftProfit.Equals(input.LeftProfit))
                ) && 
                (
                    this.LeftProfitFormatted == input.LeftProfitFormatted ||
                    (this.LeftProfitFormatted != null &&
                    this.LeftProfitFormatted.Equals(input.LeftProfitFormatted))
                ) && 
                (
                    this.LeftRevenue == input.LeftRevenue ||
                    (this.LeftRevenue != null &&
                    this.LeftRevenue.Equals(input.LeftRevenue))
                ) && 
                (
                    this.LeftRevenueFormatted == input.LeftRevenueFormatted ||
                    (this.LeftRevenueFormatted != null &&
                    this.LeftRevenueFormatted.Equals(input.LeftRevenueFormatted))
                ) && 
                (
                    this.LeftSendCount == input.LeftSendCount ||
                    (this.LeftSendCount != null &&
                    this.LeftSendCount.Equals(input.LeftSendCount))
                ) && 
                (
                    this.LeftSendCountFormatted == input.LeftSendCountFormatted ||
                    (this.LeftSendCountFormatted != null &&
                    this.LeftSendCountFormatted.Equals(input.LeftSendCountFormatted))
                ) && 
                (
                    this.LeftSkippedCount == input.LeftSkippedCount ||
                    (this.LeftSkippedCount != null &&
                    this.LeftSkippedCount.Equals(input.LeftSkippedCount))
                ) && 
                (
                    this.LeftSkippedCountFormatted == input.LeftSkippedCountFormatted ||
                    (this.LeftSkippedCountFormatted != null &&
                    this.LeftSkippedCountFormatted.Equals(input.LeftSkippedCountFormatted))
                ) && 
                (
                    this.LeftUnsubscribeCount == input.LeftUnsubscribeCount ||
                    (this.LeftUnsubscribeCount != null &&
                    this.LeftUnsubscribeCount.Equals(input.LeftUnsubscribeCount))
                ) && 
                (
                    this.LeftUnsubscribeCountFormatted == input.LeftUnsubscribeCountFormatted ||
                    (this.LeftUnsubscribeCountFormatted != null &&
                    this.LeftUnsubscribeCountFormatted.Equals(input.LeftUnsubscribeCountFormatted))
                ) && 
                (
                    this.RightConversionCount == input.RightConversionCount ||
                    (this.RightConversionCount != null &&
                    this.RightConversionCount.Equals(input.RightConversionCount))
                ) && 
                (
                    this.RightConversionCountFormatted == input.RightConversionCountFormatted ||
                    (this.RightConversionCountFormatted != null &&
                    this.RightConversionCountFormatted.Equals(input.RightConversionCountFormatted))
                ) && 
                (
                    this.RightCustomerCount == input.RightCustomerCount ||
                    (this.RightCustomerCount != null &&
                    this.RightCustomerCount.Equals(input.RightCustomerCount))
                ) && 
                (
                    this.RightCustomerCountFormatted == input.RightCustomerCountFormatted ||
                    (this.RightCustomerCountFormatted != null &&
                    this.RightCustomerCountFormatted.Equals(input.RightCustomerCountFormatted))
                ) && 
                (
                    this.RightOrderCount == input.RightOrderCount ||
                    (this.RightOrderCount != null &&
                    this.RightOrderCount.Equals(input.RightOrderCount))
                ) && 
                (
                    this.RightOrderCountFormatted == input.RightOrderCountFormatted ||
                    (this.RightOrderCountFormatted != null &&
                    this.RightOrderCountFormatted.Equals(input.RightOrderCountFormatted))
                ) && 
                (
                    this.RightProfit == input.RightProfit ||
                    (this.RightProfit != null &&
                    this.RightProfit.Equals(input.RightProfit))
                ) && 
                (
                    this.RightProfitFormatted == input.RightProfitFormatted ||
                    (this.RightProfitFormatted != null &&
                    this.RightProfitFormatted.Equals(input.RightProfitFormatted))
                ) && 
                (
                    this.RightRevenue == input.RightRevenue ||
                    (this.RightRevenue != null &&
                    this.RightRevenue.Equals(input.RightRevenue))
                ) && 
                (
                    this.RightRevenueFormatted == input.RightRevenueFormatted ||
                    (this.RightRevenueFormatted != null &&
                    this.RightRevenueFormatted.Equals(input.RightRevenueFormatted))
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
                if (this.LeftClickCount != null)
                    hashCode = hashCode * 59 + this.LeftClickCount.GetHashCode();
                if (this.LeftClickCountFormatted != null)
                    hashCode = hashCode * 59 + this.LeftClickCountFormatted.GetHashCode();
                if (this.LeftConversionCount != null)
                    hashCode = hashCode * 59 + this.LeftConversionCount.GetHashCode();
                if (this.LeftConversionCountFormatted != null)
                    hashCode = hashCode * 59 + this.LeftConversionCountFormatted.GetHashCode();
                if (this.LeftCustomerCount != null)
                    hashCode = hashCode * 59 + this.LeftCustomerCount.GetHashCode();
                if (this.LeftCustomerCountFormatted != null)
                    hashCode = hashCode * 59 + this.LeftCustomerCountFormatted.GetHashCode();
                if (this.LeftDeliveredCount != null)
                    hashCode = hashCode * 59 + this.LeftDeliveredCount.GetHashCode();
                if (this.LeftDeliveredCountFormatted != null)
                    hashCode = hashCode * 59 + this.LeftDeliveredCountFormatted.GetHashCode();
                if (this.LeftOrderCount != null)
                    hashCode = hashCode * 59 + this.LeftOrderCount.GetHashCode();
                if (this.LeftOrderCountFormatted != null)
                    hashCode = hashCode * 59 + this.LeftOrderCountFormatted.GetHashCode();
                if (this.LeftProfit != null)
                    hashCode = hashCode * 59 + this.LeftProfit.GetHashCode();
                if (this.LeftProfitFormatted != null)
                    hashCode = hashCode * 59 + this.LeftProfitFormatted.GetHashCode();
                if (this.LeftRevenue != null)
                    hashCode = hashCode * 59 + this.LeftRevenue.GetHashCode();
                if (this.LeftRevenueFormatted != null)
                    hashCode = hashCode * 59 + this.LeftRevenueFormatted.GetHashCode();
                if (this.LeftSendCount != null)
                    hashCode = hashCode * 59 + this.LeftSendCount.GetHashCode();
                if (this.LeftSendCountFormatted != null)
                    hashCode = hashCode * 59 + this.LeftSendCountFormatted.GetHashCode();
                if (this.LeftSkippedCount != null)
                    hashCode = hashCode * 59 + this.LeftSkippedCount.GetHashCode();
                if (this.LeftSkippedCountFormatted != null)
                    hashCode = hashCode * 59 + this.LeftSkippedCountFormatted.GetHashCode();
                if (this.LeftUnsubscribeCount != null)
                    hashCode = hashCode * 59 + this.LeftUnsubscribeCount.GetHashCode();
                if (this.LeftUnsubscribeCountFormatted != null)
                    hashCode = hashCode * 59 + this.LeftUnsubscribeCountFormatted.GetHashCode();
                if (this.RightConversionCount != null)
                    hashCode = hashCode * 59 + this.RightConversionCount.GetHashCode();
                if (this.RightConversionCountFormatted != null)
                    hashCode = hashCode * 59 + this.RightConversionCountFormatted.GetHashCode();
                if (this.RightCustomerCount != null)
                    hashCode = hashCode * 59 + this.RightCustomerCount.GetHashCode();
                if (this.RightCustomerCountFormatted != null)
                    hashCode = hashCode * 59 + this.RightCustomerCountFormatted.GetHashCode();
                if (this.RightOrderCount != null)
                    hashCode = hashCode * 59 + this.RightOrderCount.GetHashCode();
                if (this.RightOrderCountFormatted != null)
                    hashCode = hashCode * 59 + this.RightOrderCountFormatted.GetHashCode();
                if (this.RightProfit != null)
                    hashCode = hashCode * 59 + this.RightProfit.GetHashCode();
                if (this.RightProfitFormatted != null)
                    hashCode = hashCode * 59 + this.RightProfitFormatted.GetHashCode();
                if (this.RightRevenue != null)
                    hashCode = hashCode * 59 + this.RightRevenue.GetHashCode();
                if (this.RightRevenueFormatted != null)
                    hashCode = hashCode * 59 + this.RightRevenueFormatted.GetHashCode();
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
