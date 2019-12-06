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
    /// EmailCampaign
    /// </summary>
    [DataContract]
    public partial class EmailCampaign :  IEquatable<EmailCampaign>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCampaign" /> class.
        /// </summary>
        /// <param name="ClickRateFormatted">Click rate of emails.</param>
        /// <param name="CreatedDts">Created date.</param>
        /// <param name="Deleted">True if this campaign was deleted.</param>
        /// <param name="EmailCampaignUuid">Email campaign UUID.</param>
        /// <param name="EmailCommunicationSequenceUuid">Email communication sequence UUID.</param>
        /// <param name="Memberships">List and segment memberships.</param>
        /// <param name="MerchantId">Merchant ID.</param>
        /// <param name="Name">Name of email campaign.</param>
        /// <param name="OpenRateFormatted">Open rate of emails.</param>
        /// <param name="RevenueFormatted">Revenue associated with campaign.</param>
        /// <param name="ScheduledDts">Scheduled date.</param>
        /// <param name="Status">Status of the campaign of draft, archived, and sent.</param>
        /// <param name="StatusDts">Timestamp when the last status change happened.</param>
        /// <param name="StorefrontOid">Storefront oid.</param>
        public EmailCampaign(string ClickRateFormatted = default(string), string CreatedDts = default(string), bool? Deleted = default(bool?), string EmailCampaignUuid = default(string), string EmailCommunicationSequenceUuid = default(string), List<EmailListSegmentMembership> Memberships = default(List<EmailListSegmentMembership>), string MerchantId = default(string), string Name = default(string), string OpenRateFormatted = default(string), string RevenueFormatted = default(string), string ScheduledDts = default(string), string Status = default(string), string StatusDts = default(string), int? StorefrontOid = default(int?))
        {
            this.ClickRateFormatted = ClickRateFormatted;
            this.CreatedDts = CreatedDts;
            this.Deleted = Deleted;
            this.EmailCampaignUuid = EmailCampaignUuid;
            this.EmailCommunicationSequenceUuid = EmailCommunicationSequenceUuid;
            this.Memberships = Memberships;
            this.MerchantId = MerchantId;
            this.Name = Name;
            this.OpenRateFormatted = OpenRateFormatted;
            this.RevenueFormatted = RevenueFormatted;
            this.ScheduledDts = ScheduledDts;
            this.Status = Status;
            this.StatusDts = StatusDts;
            this.StorefrontOid = StorefrontOid;
        }
        
        /// <summary>
        /// Click rate of emails
        /// </summary>
        /// <value>Click rate of emails</value>
        [DataMember(Name="click_rate_formatted", EmitDefaultValue=false)]
        public string ClickRateFormatted { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        /// <value>Created date</value>
        [DataMember(Name="created_dts", EmitDefaultValue=false)]
        public string CreatedDts { get; set; }

        /// <summary>
        /// True if this campaign was deleted
        /// </summary>
        /// <value>True if this campaign was deleted</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Email campaign UUID
        /// </summary>
        /// <value>Email campaign UUID</value>
        [DataMember(Name="email_campaign_uuid", EmitDefaultValue=false)]
        public string EmailCampaignUuid { get; set; }

        /// <summary>
        /// Email communication sequence UUID
        /// </summary>
        /// <value>Email communication sequence UUID</value>
        [DataMember(Name="email_communication_sequence_uuid", EmitDefaultValue=false)]
        public string EmailCommunicationSequenceUuid { get; set; }

        /// <summary>
        /// List and segment memberships
        /// </summary>
        /// <value>List and segment memberships</value>
        [DataMember(Name="memberships", EmitDefaultValue=false)]
        public List<EmailListSegmentMembership> Memberships { get; set; }

        /// <summary>
        /// Merchant ID
        /// </summary>
        /// <value>Merchant ID</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Name of email campaign
        /// </summary>
        /// <value>Name of email campaign</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Open rate of emails
        /// </summary>
        /// <value>Open rate of emails</value>
        [DataMember(Name="open_rate_formatted", EmitDefaultValue=false)]
        public string OpenRateFormatted { get; set; }

        /// <summary>
        /// Revenue associated with campaign
        /// </summary>
        /// <value>Revenue associated with campaign</value>
        [DataMember(Name="revenue_formatted", EmitDefaultValue=false)]
        public string RevenueFormatted { get; set; }

        /// <summary>
        /// Scheduled date
        /// </summary>
        /// <value>Scheduled date</value>
        [DataMember(Name="scheduled_dts", EmitDefaultValue=false)]
        public string ScheduledDts { get; set; }

        /// <summary>
        /// Status of the campaign of draft, archived, and sent
        /// </summary>
        /// <value>Status of the campaign of draft, archived, and sent</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Timestamp when the last status change happened
        /// </summary>
        /// <value>Timestamp when the last status change happened</value>
        [DataMember(Name="status_dts", EmitDefaultValue=false)]
        public string StatusDts { get; set; }

        /// <summary>
        /// Storefront oid
        /// </summary>
        /// <value>Storefront oid</value>
        [DataMember(Name="storefront_oid", EmitDefaultValue=false)]
        public int? StorefrontOid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailCampaign {\n");
            sb.Append("  ClickRateFormatted: ").Append(ClickRateFormatted).Append("\n");
            sb.Append("  CreatedDts: ").Append(CreatedDts).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  EmailCampaignUuid: ").Append(EmailCampaignUuid).Append("\n");
            sb.Append("  EmailCommunicationSequenceUuid: ").Append(EmailCommunicationSequenceUuid).Append("\n");
            sb.Append("  Memberships: ").Append(Memberships).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpenRateFormatted: ").Append(OpenRateFormatted).Append("\n");
            sb.Append("  RevenueFormatted: ").Append(RevenueFormatted).Append("\n");
            sb.Append("  ScheduledDts: ").Append(ScheduledDts).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDts: ").Append(StatusDts).Append("\n");
            sb.Append("  StorefrontOid: ").Append(StorefrontOid).Append("\n");
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
            return this.Equals(input as EmailCampaign);
        }

        /// <summary>
        /// Returns true if EmailCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailCampaign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClickRateFormatted == input.ClickRateFormatted ||
                    (this.ClickRateFormatted != null &&
                    this.ClickRateFormatted.Equals(input.ClickRateFormatted))
                ) && 
                (
                    this.CreatedDts == input.CreatedDts ||
                    (this.CreatedDts != null &&
                    this.CreatedDts.Equals(input.CreatedDts))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.EmailCampaignUuid == input.EmailCampaignUuid ||
                    (this.EmailCampaignUuid != null &&
                    this.EmailCampaignUuid.Equals(input.EmailCampaignUuid))
                ) && 
                (
                    this.EmailCommunicationSequenceUuid == input.EmailCommunicationSequenceUuid ||
                    (this.EmailCommunicationSequenceUuid != null &&
                    this.EmailCommunicationSequenceUuid.Equals(input.EmailCommunicationSequenceUuid))
                ) && 
                (
                    this.Memberships == input.Memberships ||
                    this.Memberships != null &&
                    this.Memberships.SequenceEqual(input.Memberships)
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
                    this.OpenRateFormatted == input.OpenRateFormatted ||
                    (this.OpenRateFormatted != null &&
                    this.OpenRateFormatted.Equals(input.OpenRateFormatted))
                ) && 
                (
                    this.RevenueFormatted == input.RevenueFormatted ||
                    (this.RevenueFormatted != null &&
                    this.RevenueFormatted.Equals(input.RevenueFormatted))
                ) && 
                (
                    this.ScheduledDts == input.ScheduledDts ||
                    (this.ScheduledDts != null &&
                    this.ScheduledDts.Equals(input.ScheduledDts))
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
                if (this.ClickRateFormatted != null)
                    hashCode = hashCode * 59 + this.ClickRateFormatted.GetHashCode();
                if (this.CreatedDts != null)
                    hashCode = hashCode * 59 + this.CreatedDts.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.EmailCampaignUuid != null)
                    hashCode = hashCode * 59 + this.EmailCampaignUuid.GetHashCode();
                if (this.EmailCommunicationSequenceUuid != null)
                    hashCode = hashCode * 59 + this.EmailCommunicationSequenceUuid.GetHashCode();
                if (this.Memberships != null)
                    hashCode = hashCode * 59 + this.Memberships.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OpenRateFormatted != null)
                    hashCode = hashCode * 59 + this.OpenRateFormatted.GetHashCode();
                if (this.RevenueFormatted != null)
                    hashCode = hashCode * 59 + this.RevenueFormatted.GetHashCode();
                if (this.ScheduledDts != null)
                    hashCode = hashCode * 59 + this.ScheduledDts.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDts != null)
                    hashCode = hashCode * 59 + this.StatusDts.GetHashCode();
                if (this.StorefrontOid != null)
                    hashCode = hashCode * 59 + this.StorefrontOid.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 250.", new [] { "Name" });
            }

            yield break;
        }
    }

}
