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
    /// EmailStat
    /// </summary>
    [DataContract]
    public partial class EmailStat :  IEquatable<EmailStat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailStat" /> class.
        /// </summary>
        /// <param name="ClickCount">Count of clicked emails.</param>
        /// <param name="ClickCountFormatted">Count of clicked emails, formatted.</param>
        /// <param name="DeliveredCount">Count of delivered emails.</param>
        /// <param name="DeliveredCountFormatted">Count of delivered emails, formatted.</param>
        /// <param name="KickboxCount">Count of emails kicked.</param>
        /// <param name="KickboxCountFormatted">Count of emails kicked, formatted.</param>
        /// <param name="MerchantId">Merchant ID.</param>
        /// <param name="Name">List or segment name.</param>
        /// <param name="OpenCount">Count of opened emails.</param>
        /// <param name="OpenCountFormatted">Count of opened emails, formatted.</param>
        /// <param name="OrderCount">Count of orders.</param>
        /// <param name="OrderCountFormatted">Count of orders, formatted.</param>
        /// <param name="PermanentBounceCount">Count of emails permanently bounced.</param>
        /// <param name="PermanentBounceCountFormatted">Count of emails permanently bounced, formatted.</param>
        /// <param name="Profit">Profit.</param>
        /// <param name="ProfitFormatted">Profit, formatted.</param>
        /// <param name="Revenue">Revenue.</param>
        /// <param name="RevenueFormatted">Revenue, formatted.</param>
        /// <param name="SendCount">Count of emails sent.</param>
        /// <param name="SendCountFormatted">Count of emails sent, formatted.</param>
        /// <param name="SkippedCount">Count of skipped emails.</param>
        /// <param name="SkippedCountFormatted">Count of skipped emails, formatted.</param>
        /// <param name="SpamCount">Count of emails classified as spam.</param>
        /// <param name="SpamCountFormatted">Count of emails classified as spam, formatted.</param>
        /// <param name="StatType">Campaign, Flow or None (for anything else).</param>
        /// <param name="Status">Status of campaign or flow.</param>
        /// <param name="StatusDts">Status dts of campaign or flow.</param>
        /// <param name="StorefrontOid">Storefront oid.</param>
        /// <param name="Uuid">List or segment uuid.</param>
        /// <param name="ViewCount">Count of views.</param>
        /// <param name="ViewCountFormatted">Count of views, formatted.</param>
        public EmailStat(int? ClickCount = default(int?), string ClickCountFormatted = default(string), int? DeliveredCount = default(int?), string DeliveredCountFormatted = default(string), int? KickboxCount = default(int?), string KickboxCountFormatted = default(string), string MerchantId = default(string), string Name = default(string), int? OpenCount = default(int?), string OpenCountFormatted = default(string), int? OrderCount = default(int?), string OrderCountFormatted = default(string), int? PermanentBounceCount = default(int?), string PermanentBounceCountFormatted = default(string), decimal? Profit = default(decimal?), string ProfitFormatted = default(string), decimal? Revenue = default(decimal?), string RevenueFormatted = default(string), int? SendCount = default(int?), string SendCountFormatted = default(string), int? SkippedCount = default(int?), string SkippedCountFormatted = default(string), int? SpamCount = default(int?), string SpamCountFormatted = default(string), string StatType = default(string), string Status = default(string), string StatusDts = default(string), int? StorefrontOid = default(int?), string Uuid = default(string), int? ViewCount = default(int?), string ViewCountFormatted = default(string))
        {
            this.ClickCount = ClickCount;
            this.ClickCountFormatted = ClickCountFormatted;
            this.DeliveredCount = DeliveredCount;
            this.DeliveredCountFormatted = DeliveredCountFormatted;
            this.KickboxCount = KickboxCount;
            this.KickboxCountFormatted = KickboxCountFormatted;
            this.MerchantId = MerchantId;
            this.Name = Name;
            this.OpenCount = OpenCount;
            this.OpenCountFormatted = OpenCountFormatted;
            this.OrderCount = OrderCount;
            this.OrderCountFormatted = OrderCountFormatted;
            this.PermanentBounceCount = PermanentBounceCount;
            this.PermanentBounceCountFormatted = PermanentBounceCountFormatted;
            this.Profit = Profit;
            this.ProfitFormatted = ProfitFormatted;
            this.Revenue = Revenue;
            this.RevenueFormatted = RevenueFormatted;
            this.SendCount = SendCount;
            this.SendCountFormatted = SendCountFormatted;
            this.SkippedCount = SkippedCount;
            this.SkippedCountFormatted = SkippedCountFormatted;
            this.SpamCount = SpamCount;
            this.SpamCountFormatted = SpamCountFormatted;
            this.StatType = StatType;
            this.Status = Status;
            this.StatusDts = StatusDts;
            this.StorefrontOid = StorefrontOid;
            this.Uuid = Uuid;
            this.ViewCount = ViewCount;
            this.ViewCountFormatted = ViewCountFormatted;
        }
        
        /// <summary>
        /// Count of clicked emails
        /// </summary>
        /// <value>Count of clicked emails</value>
        [DataMember(Name="click_count", EmitDefaultValue=false)]
        public int? ClickCount { get; set; }

        /// <summary>
        /// Count of clicked emails, formatted
        /// </summary>
        /// <value>Count of clicked emails, formatted</value>
        [DataMember(Name="click_count_formatted", EmitDefaultValue=false)]
        public string ClickCountFormatted { get; set; }

        /// <summary>
        /// Count of delivered emails
        /// </summary>
        /// <value>Count of delivered emails</value>
        [DataMember(Name="delivered_count", EmitDefaultValue=false)]
        public int? DeliveredCount { get; set; }

        /// <summary>
        /// Count of delivered emails, formatted
        /// </summary>
        /// <value>Count of delivered emails, formatted</value>
        [DataMember(Name="delivered_count_formatted", EmitDefaultValue=false)]
        public string DeliveredCountFormatted { get; set; }

        /// <summary>
        /// Count of emails kicked
        /// </summary>
        /// <value>Count of emails kicked</value>
        [DataMember(Name="kickbox_count", EmitDefaultValue=false)]
        public int? KickboxCount { get; set; }

        /// <summary>
        /// Count of emails kicked, formatted
        /// </summary>
        /// <value>Count of emails kicked, formatted</value>
        [DataMember(Name="kickbox_count_formatted", EmitDefaultValue=false)]
        public string KickboxCountFormatted { get; set; }

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
        /// Count of opened emails
        /// </summary>
        /// <value>Count of opened emails</value>
        [DataMember(Name="open_count", EmitDefaultValue=false)]
        public int? OpenCount { get; set; }

        /// <summary>
        /// Count of opened emails, formatted
        /// </summary>
        /// <value>Count of opened emails, formatted</value>
        [DataMember(Name="open_count_formatted", EmitDefaultValue=false)]
        public string OpenCountFormatted { get; set; }

        /// <summary>
        /// Count of orders
        /// </summary>
        /// <value>Count of orders</value>
        [DataMember(Name="order_count", EmitDefaultValue=false)]
        public int? OrderCount { get; set; }

        /// <summary>
        /// Count of orders, formatted
        /// </summary>
        /// <value>Count of orders, formatted</value>
        [DataMember(Name="order_count_formatted", EmitDefaultValue=false)]
        public string OrderCountFormatted { get; set; }

        /// <summary>
        /// Count of emails permanently bounced
        /// </summary>
        /// <value>Count of emails permanently bounced</value>
        [DataMember(Name="permanent_bounce_count", EmitDefaultValue=false)]
        public int? PermanentBounceCount { get; set; }

        /// <summary>
        /// Count of emails permanently bounced, formatted
        /// </summary>
        /// <value>Count of emails permanently bounced, formatted</value>
        [DataMember(Name="permanent_bounce_count_formatted", EmitDefaultValue=false)]
        public string PermanentBounceCountFormatted { get; set; }

        /// <summary>
        /// Profit
        /// </summary>
        /// <value>Profit</value>
        [DataMember(Name="profit", EmitDefaultValue=false)]
        public decimal? Profit { get; set; }

        /// <summary>
        /// Profit, formatted
        /// </summary>
        /// <value>Profit, formatted</value>
        [DataMember(Name="profit_formatted", EmitDefaultValue=false)]
        public string ProfitFormatted { get; set; }

        /// <summary>
        /// Revenue
        /// </summary>
        /// <value>Revenue</value>
        [DataMember(Name="revenue", EmitDefaultValue=false)]
        public decimal? Revenue { get; set; }

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
        public int? SendCount { get; set; }

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
        public int? SkippedCount { get; set; }

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
        public int? SpamCount { get; set; }

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
        /// Storefront oid
        /// </summary>
        /// <value>Storefront oid</value>
        [DataMember(Name="storefront_oid", EmitDefaultValue=false)]
        public int? StorefrontOid { get; set; }

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
        public int? ViewCount { get; set; }

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
            sb.Append("class EmailStat {\n");
            sb.Append("  ClickCount: ").Append(ClickCount).Append("\n");
            sb.Append("  ClickCountFormatted: ").Append(ClickCountFormatted).Append("\n");
            sb.Append("  DeliveredCount: ").Append(DeliveredCount).Append("\n");
            sb.Append("  DeliveredCountFormatted: ").Append(DeliveredCountFormatted).Append("\n");
            sb.Append("  KickboxCount: ").Append(KickboxCount).Append("\n");
            sb.Append("  KickboxCountFormatted: ").Append(KickboxCountFormatted).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpenCount: ").Append(OpenCount).Append("\n");
            sb.Append("  OpenCountFormatted: ").Append(OpenCountFormatted).Append("\n");
            sb.Append("  OrderCount: ").Append(OrderCount).Append("\n");
            sb.Append("  OrderCountFormatted: ").Append(OrderCountFormatted).Append("\n");
            sb.Append("  PermanentBounceCount: ").Append(PermanentBounceCount).Append("\n");
            sb.Append("  PermanentBounceCountFormatted: ").Append(PermanentBounceCountFormatted).Append("\n");
            sb.Append("  Profit: ").Append(Profit).Append("\n");
            sb.Append("  ProfitFormatted: ").Append(ProfitFormatted).Append("\n");
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
            sb.Append("  StorefrontOid: ").Append(StorefrontOid).Append("\n");
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
            return this.Equals(input as EmailStat);
        }

        /// <summary>
        /// Returns true if EmailStat instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailStat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailStat input)
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
                    this.KickboxCount == input.KickboxCount ||
                    (this.KickboxCount != null &&
                    this.KickboxCount.Equals(input.KickboxCount))
                ) && 
                (
                    this.KickboxCountFormatted == input.KickboxCountFormatted ||
                    (this.KickboxCountFormatted != null &&
                    this.KickboxCountFormatted.Equals(input.KickboxCountFormatted))
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
                    this.OpenCount == input.OpenCount ||
                    (this.OpenCount != null &&
                    this.OpenCount.Equals(input.OpenCount))
                ) && 
                (
                    this.OpenCountFormatted == input.OpenCountFormatted ||
                    (this.OpenCountFormatted != null &&
                    this.OpenCountFormatted.Equals(input.OpenCountFormatted))
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
                    this.PermanentBounceCount == input.PermanentBounceCount ||
                    (this.PermanentBounceCount != null &&
                    this.PermanentBounceCount.Equals(input.PermanentBounceCount))
                ) && 
                (
                    this.PermanentBounceCountFormatted == input.PermanentBounceCountFormatted ||
                    (this.PermanentBounceCountFormatted != null &&
                    this.PermanentBounceCountFormatted.Equals(input.PermanentBounceCountFormatted))
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
                    this.StorefrontOid == input.StorefrontOid ||
                    (this.StorefrontOid != null &&
                    this.StorefrontOid.Equals(input.StorefrontOid))
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
                if (this.DeliveredCount != null)
                    hashCode = hashCode * 59 + this.DeliveredCount.GetHashCode();
                if (this.DeliveredCountFormatted != null)
                    hashCode = hashCode * 59 + this.DeliveredCountFormatted.GetHashCode();
                if (this.KickboxCount != null)
                    hashCode = hashCode * 59 + this.KickboxCount.GetHashCode();
                if (this.KickboxCountFormatted != null)
                    hashCode = hashCode * 59 + this.KickboxCountFormatted.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OpenCount != null)
                    hashCode = hashCode * 59 + this.OpenCount.GetHashCode();
                if (this.OpenCountFormatted != null)
                    hashCode = hashCode * 59 + this.OpenCountFormatted.GetHashCode();
                if (this.OrderCount != null)
                    hashCode = hashCode * 59 + this.OrderCount.GetHashCode();
                if (this.OrderCountFormatted != null)
                    hashCode = hashCode * 59 + this.OrderCountFormatted.GetHashCode();
                if (this.PermanentBounceCount != null)
                    hashCode = hashCode * 59 + this.PermanentBounceCount.GetHashCode();
                if (this.PermanentBounceCountFormatted != null)
                    hashCode = hashCode * 59 + this.PermanentBounceCountFormatted.GetHashCode();
                if (this.Profit != null)
                    hashCode = hashCode * 59 + this.Profit.GetHashCode();
                if (this.ProfitFormatted != null)
                    hashCode = hashCode * 59 + this.ProfitFormatted.GetHashCode();
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
                if (this.StorefrontOid != null)
                    hashCode = hashCode * 59 + this.StorefrontOid.GetHashCode();
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