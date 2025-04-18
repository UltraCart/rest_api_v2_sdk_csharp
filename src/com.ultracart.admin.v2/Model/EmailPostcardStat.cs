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
    /// EmailPostcardStat
    /// </summary>
    [DataContract]
    public partial class EmailPostcardStat :  IEquatable<EmailPostcardStat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailPostcardStat" /> class.
        /// </summary>
        /// <param name="clickCount">Count of clicked emails.</param>
        /// <param name="clickCountFormatted">Count of clicked emails, formatted.</param>
        /// <param name="conversionCount">Count of conversions.</param>
        /// <param name="conversionCountFormatted">Count of conversions, formatted.</param>
        /// <param name="deliveredCount">Count of delivered emails.</param>
        /// <param name="deliveredCountFormatted">Count of delivered emails, formatted.</param>
        /// <param name="merchantId">Merchant ID.</param>
        /// <param name="name">List or segment name.</param>
        /// <param name="orderCount">Count of orders.</param>
        /// <param name="orderCountFormatted">Count of orders, formatted.</param>
        /// <param name="profit">Profit.</param>
        /// <param name="profitFormatted">Profit, formatted.</param>
        /// <param name="returnToSenderCount">Count of return to sender.</param>
        /// <param name="returnToSenderCountFormatted">Count of return to sender, formatted.</param>
        /// <param name="revenue">Revenue.</param>
        /// <param name="revenueFormatted">Revenue, formatted.</param>
        /// <param name="sendCount">Count of emails sent.</param>
        /// <param name="sendCountFormatted">Count of emails sent, formatted.</param>
        /// <param name="skippedCount">Count of skipped emails.</param>
        /// <param name="skippedCountFormatted">Count of skipped emails, formatted.</param>
        /// <param name="spamCount">Count of emails classified as spam.</param>
        /// <param name="spamCountFormatted">Count of emails classified as spam, formatted.</param>
        /// <param name="statType">Campaign, Flow or None (for anything else).</param>
        /// <param name="status">Status of campaign or flow.</param>
        /// <param name="statusDts">Status dts of campaign or flow.</param>
        /// <param name="steps">steps.</param>
        /// <param name="storefrontOid">Storefront oid.</param>
        /// <param name="unsubscribeCount">Count of emails classified as unsubscribe.</param>
        /// <param name="unsubscribeCountFormatted">Count of emails classified as unsubscribe, formatted.</param>
        /// <param name="uuid">List or segment uuid.</param>
        /// <param name="viewCount">Count of views.</param>
        /// <param name="viewCountFormatted">Count of views, formatted.</param>
        public EmailPostcardStat(int clickCount = default(int), string clickCountFormatted = default(string), int conversionCount = default(int), string conversionCountFormatted = default(string), int deliveredCount = default(int), string deliveredCountFormatted = default(string), string merchantId = default(string), string name = default(string), int orderCount = default(int), string orderCountFormatted = default(string), decimal profit = default(decimal), string profitFormatted = default(string), int returnToSenderCount = default(int), string returnToSenderCountFormatted = default(string), decimal revenue = default(decimal), string revenueFormatted = default(string), int sendCount = default(int), string sendCountFormatted = default(string), int skippedCount = default(int), string skippedCountFormatted = default(string), int spamCount = default(int), string spamCountFormatted = default(string), string statType = default(string), string status = default(string), string statusDts = default(string), List<EmailPostcardStat> steps = default(List<EmailPostcardStat>), int storefrontOid = default(int), int unsubscribeCount = default(int), string unsubscribeCountFormatted = default(string), string uuid = default(string), int viewCount = default(int), string viewCountFormatted = default(string))
        {
            this.ClickCount = clickCount;
            this.ClickCountFormatted = clickCountFormatted;
            this.ConversionCount = conversionCount;
            this.ConversionCountFormatted = conversionCountFormatted;
            this.DeliveredCount = deliveredCount;
            this.DeliveredCountFormatted = deliveredCountFormatted;
            this.MerchantId = merchantId;
            this.Name = name;
            this.OrderCount = orderCount;
            this.OrderCountFormatted = orderCountFormatted;
            this.Profit = profit;
            this.ProfitFormatted = profitFormatted;
            this.ReturnToSenderCount = returnToSenderCount;
            this.ReturnToSenderCountFormatted = returnToSenderCountFormatted;
            this.Revenue = revenue;
            this.RevenueFormatted = revenueFormatted;
            this.SendCount = sendCount;
            this.SendCountFormatted = sendCountFormatted;
            this.SkippedCount = skippedCount;
            this.SkippedCountFormatted = skippedCountFormatted;
            this.SpamCount = spamCount;
            this.SpamCountFormatted = spamCountFormatted;
            this.StatType = statType;
            this.Status = status;
            this.StatusDts = statusDts;
            this.Steps = steps;
            this.StorefrontOid = storefrontOid;
            this.UnsubscribeCount = unsubscribeCount;
            this.UnsubscribeCountFormatted = unsubscribeCountFormatted;
            this.Uuid = uuid;
            this.ViewCount = viewCount;
            this.ViewCountFormatted = viewCountFormatted;
        }

        /// <summary>
        /// Count of clicked emails
        /// </summary>
        /// <value>Count of clicked emails</value>
        [DataMember(Name="click_count", EmitDefaultValue=false)]
        public int ClickCount { get; set; }

        /// <summary>
        /// Count of clicked emails, formatted
        /// </summary>
        /// <value>Count of clicked emails, formatted</value>
        [DataMember(Name="click_count_formatted", EmitDefaultValue=false)]
        public string ClickCountFormatted { get; set; }

        /// <summary>
        /// Count of conversions
        /// </summary>
        /// <value>Count of conversions</value>
        [DataMember(Name="conversion_count", EmitDefaultValue=false)]
        public int ConversionCount { get; set; }

        /// <summary>
        /// Count of conversions, formatted
        /// </summary>
        /// <value>Count of conversions, formatted</value>
        [DataMember(Name="conversion_count_formatted", EmitDefaultValue=false)]
        public string ConversionCountFormatted { get; set; }

        /// <summary>
        /// Count of delivered emails
        /// </summary>
        /// <value>Count of delivered emails</value>
        [DataMember(Name="delivered_count", EmitDefaultValue=false)]
        public int DeliveredCount { get; set; }

        /// <summary>
        /// Count of delivered emails, formatted
        /// </summary>
        /// <value>Count of delivered emails, formatted</value>
        [DataMember(Name="delivered_count_formatted", EmitDefaultValue=false)]
        public string DeliveredCountFormatted { get; set; }

        /// <summary>
        /// Merchant ID
        /// </summary>
        /// <value>Merchant ID</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// List or segment name
        /// </summary>
        /// <value>List or segment name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Count of orders
        /// </summary>
        /// <value>Count of orders</value>
        [DataMember(Name="order_count", EmitDefaultValue=false)]
        public int OrderCount { get; set; }

        /// <summary>
        /// Count of orders, formatted
        /// </summary>
        /// <value>Count of orders, formatted</value>
        [DataMember(Name="order_count_formatted", EmitDefaultValue=false)]
        public string OrderCountFormatted { get; set; }

        /// <summary>
        /// Profit
        /// </summary>
        /// <value>Profit</value>
        [DataMember(Name="profit", EmitDefaultValue=false)]
        public decimal Profit { get; set; }

        /// <summary>
        /// Profit, formatted
        /// </summary>
        /// <value>Profit, formatted</value>
        [DataMember(Name="profit_formatted", EmitDefaultValue=false)]
        public string ProfitFormatted { get; set; }

        /// <summary>
        /// Count of return to sender
        /// </summary>
        /// <value>Count of return to sender</value>
        [DataMember(Name="return_to_sender_count", EmitDefaultValue=false)]
        public int ReturnToSenderCount { get; set; }

        /// <summary>
        /// Count of return to sender, formatted
        /// </summary>
        /// <value>Count of return to sender, formatted</value>
        [DataMember(Name="return_to_sender_count_formatted", EmitDefaultValue=false)]
        public string ReturnToSenderCountFormatted { get; set; }

        /// <summary>
        /// Revenue
        /// </summary>
        /// <value>Revenue</value>
        [DataMember(Name="revenue", EmitDefaultValue=false)]
        public decimal Revenue { get; set; }

        /// <summary>
        /// Revenue, formatted
        /// </summary>
        /// <value>Revenue, formatted</value>
        [DataMember(Name="revenue_formatted", EmitDefaultValue=false)]
        public string RevenueFormatted { get; set; }

        /// <summary>
        /// Count of emails sent
        /// </summary>
        /// <value>Count of emails sent</value>
        [DataMember(Name="send_count", EmitDefaultValue=false)]
        public int SendCount { get; set; }

        /// <summary>
        /// Count of emails sent, formatted
        /// </summary>
        /// <value>Count of emails sent, formatted</value>
        [DataMember(Name="send_count_formatted", EmitDefaultValue=false)]
        public string SendCountFormatted { get; set; }

        /// <summary>
        /// Count of skipped emails
        /// </summary>
        /// <value>Count of skipped emails</value>
        [DataMember(Name="skipped_count", EmitDefaultValue=false)]
        public int SkippedCount { get; set; }

        /// <summary>
        /// Count of skipped emails, formatted
        /// </summary>
        /// <value>Count of skipped emails, formatted</value>
        [DataMember(Name="skipped_count_formatted", EmitDefaultValue=false)]
        public string SkippedCountFormatted { get; set; }

        /// <summary>
        /// Count of emails classified as spam
        /// </summary>
        /// <value>Count of emails classified as spam</value>
        [DataMember(Name="spam_count", EmitDefaultValue=false)]
        public int SpamCount { get; set; }

        /// <summary>
        /// Count of emails classified as spam, formatted
        /// </summary>
        /// <value>Count of emails classified as spam, formatted</value>
        [DataMember(Name="spam_count_formatted", EmitDefaultValue=false)]
        public string SpamCountFormatted { get; set; }

        /// <summary>
        /// Campaign, Flow or None (for anything else)
        /// </summary>
        /// <value>Campaign, Flow or None (for anything else)</value>
        [DataMember(Name="stat_type", EmitDefaultValue=false)]
        public string StatType { get; set; }

        /// <summary>
        /// Status of campaign or flow
        /// </summary>
        /// <value>Status of campaign or flow</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Status dts of campaign or flow
        /// </summary>
        /// <value>Status dts of campaign or flow</value>
        [DataMember(Name="status_dts", EmitDefaultValue=false)]
        public string StatusDts { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<EmailPostcardStat> Steps { get; set; }

        /// <summary>
        /// Storefront oid
        /// </summary>
        /// <value>Storefront oid</value>
        [DataMember(Name="storefront_oid", EmitDefaultValue=false)]
        public int StorefrontOid { get; set; }

        /// <summary>
        /// Count of emails classified as unsubscribe
        /// </summary>
        /// <value>Count of emails classified as unsubscribe</value>
        [DataMember(Name="unsubscribe_count", EmitDefaultValue=false)]
        public int UnsubscribeCount { get; set; }

        /// <summary>
        /// Count of emails classified as unsubscribe, formatted
        /// </summary>
        /// <value>Count of emails classified as unsubscribe, formatted</value>
        [DataMember(Name="unsubscribe_count_formatted", EmitDefaultValue=false)]
        public string UnsubscribeCountFormatted { get; set; }

        /// <summary>
        /// List or segment uuid
        /// </summary>
        /// <value>List or segment uuid</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Count of views
        /// </summary>
        /// <value>Count of views</value>
        [DataMember(Name="view_count", EmitDefaultValue=false)]
        public int ViewCount { get; set; }

        /// <summary>
        /// Count of views, formatted
        /// </summary>
        /// <value>Count of views, formatted</value>
        [DataMember(Name="view_count_formatted", EmitDefaultValue=false)]
        public string ViewCountFormatted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailPostcardStat {\n");
            sb.Append("  ClickCount: ").Append(ClickCount).Append("\n");
            sb.Append("  ClickCountFormatted: ").Append(ClickCountFormatted).Append("\n");
            sb.Append("  ConversionCount: ").Append(ConversionCount).Append("\n");
            sb.Append("  ConversionCountFormatted: ").Append(ConversionCountFormatted).Append("\n");
            sb.Append("  DeliveredCount: ").Append(DeliveredCount).Append("\n");
            sb.Append("  DeliveredCountFormatted: ").Append(DeliveredCountFormatted).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrderCount: ").Append(OrderCount).Append("\n");
            sb.Append("  OrderCountFormatted: ").Append(OrderCountFormatted).Append("\n");
            sb.Append("  Profit: ").Append(Profit).Append("\n");
            sb.Append("  ProfitFormatted: ").Append(ProfitFormatted).Append("\n");
            sb.Append("  ReturnToSenderCount: ").Append(ReturnToSenderCount).Append("\n");
            sb.Append("  ReturnToSenderCountFormatted: ").Append(ReturnToSenderCountFormatted).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  RevenueFormatted: ").Append(RevenueFormatted).Append("\n");
            sb.Append("  SendCount: ").Append(SendCount).Append("\n");
            sb.Append("  SendCountFormatted: ").Append(SendCountFormatted).Append("\n");
            sb.Append("  SkippedCount: ").Append(SkippedCount).Append("\n");
            sb.Append("  SkippedCountFormatted: ").Append(SkippedCountFormatted).Append("\n");
            sb.Append("  SpamCount: ").Append(SpamCount).Append("\n");
            sb.Append("  SpamCountFormatted: ").Append(SpamCountFormatted).Append("\n");
            sb.Append("  StatType: ").Append(StatType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDts: ").Append(StatusDts).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  StorefrontOid: ").Append(StorefrontOid).Append("\n");
            sb.Append("  UnsubscribeCount: ").Append(UnsubscribeCount).Append("\n");
            sb.Append("  UnsubscribeCountFormatted: ").Append(UnsubscribeCountFormatted).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ViewCount: ").Append(ViewCount).Append("\n");
            sb.Append("  ViewCountFormatted: ").Append(ViewCountFormatted).Append("\n");
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
            return this.Equals(input as EmailPostcardStat);
        }

        /// <summary>
        /// Returns true if EmailPostcardStat instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailPostcardStat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailPostcardStat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClickCount == input.ClickCount ||
                    (this.ClickCount != null &&
                    this.ClickCount.Equals(input.ClickCount))
                ) && 
                (
                    this.ClickCountFormatted == input.ClickCountFormatted ||
                    (this.ClickCountFormatted != null &&
                    this.ClickCountFormatted.Equals(input.ClickCountFormatted))
                ) && 
                (
                    this.ConversionCount == input.ConversionCount ||
                    (this.ConversionCount != null &&
                    this.ConversionCount.Equals(input.ConversionCount))
                ) && 
                (
                    this.ConversionCountFormatted == input.ConversionCountFormatted ||
                    (this.ConversionCountFormatted != null &&
                    this.ConversionCountFormatted.Equals(input.ConversionCountFormatted))
                ) && 
                (
                    this.DeliveredCount == input.DeliveredCount ||
                    (this.DeliveredCount != null &&
                    this.DeliveredCount.Equals(input.DeliveredCount))
                ) && 
                (
                    this.DeliveredCountFormatted == input.DeliveredCountFormatted ||
                    (this.DeliveredCountFormatted != null &&
                    this.DeliveredCountFormatted.Equals(input.DeliveredCountFormatted))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OrderCount == input.OrderCount ||
                    (this.OrderCount != null &&
                    this.OrderCount.Equals(input.OrderCount))
                ) && 
                (
                    this.OrderCountFormatted == input.OrderCountFormatted ||
                    (this.OrderCountFormatted != null &&
                    this.OrderCountFormatted.Equals(input.OrderCountFormatted))
                ) && 
                (
                    this.Profit == input.Profit ||
                    (this.Profit != null &&
                    this.Profit.Equals(input.Profit))
                ) && 
                (
                    this.ProfitFormatted == input.ProfitFormatted ||
                    (this.ProfitFormatted != null &&
                    this.ProfitFormatted.Equals(input.ProfitFormatted))
                ) && 
                (
                    this.ReturnToSenderCount == input.ReturnToSenderCount ||
                    (this.ReturnToSenderCount != null &&
                    this.ReturnToSenderCount.Equals(input.ReturnToSenderCount))
                ) && 
                (
                    this.ReturnToSenderCountFormatted == input.ReturnToSenderCountFormatted ||
                    (this.ReturnToSenderCountFormatted != null &&
                    this.ReturnToSenderCountFormatted.Equals(input.ReturnToSenderCountFormatted))
                ) && 
                (
                    this.Revenue == input.Revenue ||
                    (this.Revenue != null &&
                    this.Revenue.Equals(input.Revenue))
                ) && 
                (
                    this.RevenueFormatted == input.RevenueFormatted ||
                    (this.RevenueFormatted != null &&
                    this.RevenueFormatted.Equals(input.RevenueFormatted))
                ) && 
                (
                    this.SendCount == input.SendCount ||
                    (this.SendCount != null &&
                    this.SendCount.Equals(input.SendCount))
                ) && 
                (
                    this.SendCountFormatted == input.SendCountFormatted ||
                    (this.SendCountFormatted != null &&
                    this.SendCountFormatted.Equals(input.SendCountFormatted))
                ) && 
                (
                    this.SkippedCount == input.SkippedCount ||
                    (this.SkippedCount != null &&
                    this.SkippedCount.Equals(input.SkippedCount))
                ) && 
                (
                    this.SkippedCountFormatted == input.SkippedCountFormatted ||
                    (this.SkippedCountFormatted != null &&
                    this.SkippedCountFormatted.Equals(input.SkippedCountFormatted))
                ) && 
                (
                    this.SpamCount == input.SpamCount ||
                    (this.SpamCount != null &&
                    this.SpamCount.Equals(input.SpamCount))
                ) && 
                (
                    this.SpamCountFormatted == input.SpamCountFormatted ||
                    (this.SpamCountFormatted != null &&
                    this.SpamCountFormatted.Equals(input.SpamCountFormatted))
                ) && 
                (
                    this.StatType == input.StatType ||
                    (this.StatType != null &&
                    this.StatType.Equals(input.StatType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusDts == input.StatusDts ||
                    (this.StatusDts != null &&
                    this.StatusDts.Equals(input.StatusDts))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.StorefrontOid == input.StorefrontOid ||
                    (this.StorefrontOid != null &&
                    this.StorefrontOid.Equals(input.StorefrontOid))
                ) && 
                (
                    this.UnsubscribeCount == input.UnsubscribeCount ||
                    (this.UnsubscribeCount != null &&
                    this.UnsubscribeCount.Equals(input.UnsubscribeCount))
                ) && 
                (
                    this.UnsubscribeCountFormatted == input.UnsubscribeCountFormatted ||
                    (this.UnsubscribeCountFormatted != null &&
                    this.UnsubscribeCountFormatted.Equals(input.UnsubscribeCountFormatted))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.ViewCount == input.ViewCount ||
                    (this.ViewCount != null &&
                    this.ViewCount.Equals(input.ViewCount))
                ) && 
                (
                    this.ViewCountFormatted == input.ViewCountFormatted ||
                    (this.ViewCountFormatted != null &&
                    this.ViewCountFormatted.Equals(input.ViewCountFormatted))
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
                if (this.ClickCount != null)
                    hashCode = hashCode * 59 + this.ClickCount.GetHashCode();
                if (this.ClickCountFormatted != null)
                    hashCode = hashCode * 59 + this.ClickCountFormatted.GetHashCode();
                if (this.ConversionCount != null)
                    hashCode = hashCode * 59 + this.ConversionCount.GetHashCode();
                if (this.ConversionCountFormatted != null)
                    hashCode = hashCode * 59 + this.ConversionCountFormatted.GetHashCode();
                if (this.DeliveredCount != null)
                    hashCode = hashCode * 59 + this.DeliveredCount.GetHashCode();
                if (this.DeliveredCountFormatted != null)
                    hashCode = hashCode * 59 + this.DeliveredCountFormatted.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrderCount != null)
                    hashCode = hashCode * 59 + this.OrderCount.GetHashCode();
                if (this.OrderCountFormatted != null)
                    hashCode = hashCode * 59 + this.OrderCountFormatted.GetHashCode();
                if (this.Profit != null)
                    hashCode = hashCode * 59 + this.Profit.GetHashCode();
                if (this.ProfitFormatted != null)
                    hashCode = hashCode * 59 + this.ProfitFormatted.GetHashCode();
                if (this.ReturnToSenderCount != null)
                    hashCode = hashCode * 59 + this.ReturnToSenderCount.GetHashCode();
                if (this.ReturnToSenderCountFormatted != null)
                    hashCode = hashCode * 59 + this.ReturnToSenderCountFormatted.GetHashCode();
                if (this.Revenue != null)
                    hashCode = hashCode * 59 + this.Revenue.GetHashCode();
                if (this.RevenueFormatted != null)
                    hashCode = hashCode * 59 + this.RevenueFormatted.GetHashCode();
                if (this.SendCount != null)
                    hashCode = hashCode * 59 + this.SendCount.GetHashCode();
                if (this.SendCountFormatted != null)
                    hashCode = hashCode * 59 + this.SendCountFormatted.GetHashCode();
                if (this.SkippedCount != null)
                    hashCode = hashCode * 59 + this.SkippedCount.GetHashCode();
                if (this.SkippedCountFormatted != null)
                    hashCode = hashCode * 59 + this.SkippedCountFormatted.GetHashCode();
                if (this.SpamCount != null)
                    hashCode = hashCode * 59 + this.SpamCount.GetHashCode();
                if (this.SpamCountFormatted != null)
                    hashCode = hashCode * 59 + this.SpamCountFormatted.GetHashCode();
                if (this.StatType != null)
                    hashCode = hashCode * 59 + this.StatType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDts != null)
                    hashCode = hashCode * 59 + this.StatusDts.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.StorefrontOid != null)
                    hashCode = hashCode * 59 + this.StorefrontOid.GetHashCode();
                if (this.UnsubscribeCount != null)
                    hashCode = hashCode * 59 + this.UnsubscribeCount.GetHashCode();
                if (this.UnsubscribeCountFormatted != null)
                    hashCode = hashCode * 59 + this.UnsubscribeCountFormatted.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.ViewCount != null)
                    hashCode = hashCode * 59 + this.ViewCount.GetHashCode();
                if (this.ViewCountFormatted != null)
                    hashCode = hashCode * 59 + this.ViewCountFormatted.GetHashCode();
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
