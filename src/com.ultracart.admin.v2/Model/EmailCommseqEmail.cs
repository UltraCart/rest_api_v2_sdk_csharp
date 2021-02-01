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
    /// EmailCommseqEmail
    /// </summary>
    [DataContract]
    public partial class EmailCommseqEmail :  IEquatable<EmailCommseqEmail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCommseqEmail" /> class.
        /// </summary>
        /// <param name="deleted">Deleted.</param>
        /// <param name="editedByUser">Edited by user.</param>
        /// <param name="emailCommunicationSequenceEmailUuid">Email communication sequence email uuid.</param>
        /// <param name="emailCommunicationSequenceUuid">Email commseq UUID.</param>
        /// <param name="emailContainerCjson">Email container cjson.</param>
        /// <param name="emailContainerCjsonLastModifiedDts">Timestamp the last time the container was modified..</param>
        /// <param name="emailTemplateVmPath">Email template virtual path.</param>
        /// <param name="filterProfileEquationJson">Filter profile equation json.</param>
        /// <param name="individuallyRender">Individually render.</param>
        /// <param name="libraryItemOid">If this item was ever added to the Code Library, this is the oid for that library item, or 0 if never added before.  This value is used to determine if a library item should be inserted or updated..</param>
        /// <param name="merchantId">Merchant ID.</param>
        /// <param name="pendingReview">True if the content of this email is pending review by UltraCart.</param>
        /// <param name="previewText">Preview text.</param>
        /// <param name="rejected">True if the content of this email was rejected during review by UltraCart.</param>
        /// <param name="requiresReview">True if the content of this email is requires review by UltraCart.</param>
        /// <param name="screenshotLargeFullUrl">URL to screenshot in large form factor full page.</param>
        /// <param name="screenshotLargeViewportUrl">URL to screenshot in large form factor viewport.</param>
        /// <param name="screenshotSmallFullUrl">URL to screenshot in small form factor full page.</param>
        /// <param name="screenshotSmallViewportUrl">URL to screenshot in small form factor viewport.</param>
        /// <param name="smartSending">Smart sending.</param>
        /// <param name="storefrontOid">Storefront oid.</param>
        /// <param name="subject">Subject.</param>
        /// <param name="transactionalEmail">Transactional email.</param>
        /// <param name="version">Version.</param>
        public EmailCommseqEmail(bool? deleted = default(bool?), string editedByUser = default(string), string emailCommunicationSequenceEmailUuid = default(string), string emailCommunicationSequenceUuid = default(string), string emailContainerCjson = default(string), string emailContainerCjsonLastModifiedDts = default(string), string emailTemplateVmPath = default(string), string filterProfileEquationJson = default(string), bool? individuallyRender = default(bool?), int? libraryItemOid = default(int?), string merchantId = default(string), bool? pendingReview = default(bool?), string previewText = default(string), bool? rejected = default(bool?), bool? requiresReview = default(bool?), string screenshotLargeFullUrl = default(string), string screenshotLargeViewportUrl = default(string), string screenshotSmallFullUrl = default(string), string screenshotSmallViewportUrl = default(string), bool? smartSending = default(bool?), int? storefrontOid = default(int?), string subject = default(string), bool? transactionalEmail = default(bool?), int? version = default(int?))
        {
            this.Deleted = deleted;
            this.EditedByUser = editedByUser;
            this.EmailCommunicationSequenceEmailUuid = emailCommunicationSequenceEmailUuid;
            this.EmailCommunicationSequenceUuid = emailCommunicationSequenceUuid;
            this.EmailContainerCjson = emailContainerCjson;
            this.EmailContainerCjsonLastModifiedDts = emailContainerCjsonLastModifiedDts;
            this.EmailTemplateVmPath = emailTemplateVmPath;
            this.FilterProfileEquationJson = filterProfileEquationJson;
            this.IndividuallyRender = individuallyRender;
            this.LibraryItemOid = libraryItemOid;
            this.MerchantId = merchantId;
            this.PendingReview = pendingReview;
            this.PreviewText = previewText;
            this.Rejected = rejected;
            this.RequiresReview = requiresReview;
            this.ScreenshotLargeFullUrl = screenshotLargeFullUrl;
            this.ScreenshotLargeViewportUrl = screenshotLargeViewportUrl;
            this.ScreenshotSmallFullUrl = screenshotSmallFullUrl;
            this.ScreenshotSmallViewportUrl = screenshotSmallViewportUrl;
            this.SmartSending = smartSending;
            this.StorefrontOid = storefrontOid;
            this.Subject = subject;
            this.TransactionalEmail = transactionalEmail;
            this.Version = version;
        }
        
        /// <summary>
        /// Deleted
        /// </summary>
        /// <value>Deleted</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Edited by user
        /// </summary>
        /// <value>Edited by user</value>
        [DataMember(Name="edited_by_user", EmitDefaultValue=false)]
        public string EditedByUser { get; set; }

        /// <summary>
        /// Email communication sequence email uuid
        /// </summary>
        /// <value>Email communication sequence email uuid</value>
        [DataMember(Name="email_communication_sequence_email_uuid", EmitDefaultValue=false)]
        public string EmailCommunicationSequenceEmailUuid { get; set; }

        /// <summary>
        /// Email commseq UUID
        /// </summary>
        /// <value>Email commseq UUID</value>
        [DataMember(Name="email_communication_sequence_uuid", EmitDefaultValue=false)]
        public string EmailCommunicationSequenceUuid { get; set; }

        /// <summary>
        /// Email container cjson
        /// </summary>
        /// <value>Email container cjson</value>
        [DataMember(Name="email_container_cjson", EmitDefaultValue=false)]
        public string EmailContainerCjson { get; set; }

        /// <summary>
        /// Timestamp the last time the container was modified.
        /// </summary>
        /// <value>Timestamp the last time the container was modified.</value>
        [DataMember(Name="email_container_cjson_last_modified_dts", EmitDefaultValue=false)]
        public string EmailContainerCjsonLastModifiedDts { get; set; }

        /// <summary>
        /// Email template virtual path
        /// </summary>
        /// <value>Email template virtual path</value>
        [DataMember(Name="email_template_vm_path", EmitDefaultValue=false)]
        public string EmailTemplateVmPath { get; set; }

        /// <summary>
        /// Filter profile equation json
        /// </summary>
        /// <value>Filter profile equation json</value>
        [DataMember(Name="filter_profile_equation_json", EmitDefaultValue=false)]
        public string FilterProfileEquationJson { get; set; }

        /// <summary>
        /// Individually render
        /// </summary>
        /// <value>Individually render</value>
        [DataMember(Name="individually_render", EmitDefaultValue=false)]
        public bool? IndividuallyRender { get; set; }

        /// <summary>
        /// If this item was ever added to the Code Library, this is the oid for that library item, or 0 if never added before.  This value is used to determine if a library item should be inserted or updated.
        /// </summary>
        /// <value>If this item was ever added to the Code Library, this is the oid for that library item, or 0 if never added before.  This value is used to determine if a library item should be inserted or updated.</value>
        [DataMember(Name="library_item_oid", EmitDefaultValue=false)]
        public int? LibraryItemOid { get; set; }

        /// <summary>
        /// Merchant ID
        /// </summary>
        /// <value>Merchant ID</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// True if the content of this email is pending review by UltraCart
        /// </summary>
        /// <value>True if the content of this email is pending review by UltraCart</value>
        [DataMember(Name="pending_review", EmitDefaultValue=false)]
        public bool? PendingReview { get; set; }

        /// <summary>
        /// Preview text
        /// </summary>
        /// <value>Preview text</value>
        [DataMember(Name="preview_text", EmitDefaultValue=false)]
        public string PreviewText { get; set; }

        /// <summary>
        /// True if the content of this email was rejected during review by UltraCart
        /// </summary>
        /// <value>True if the content of this email was rejected during review by UltraCart</value>
        [DataMember(Name="rejected", EmitDefaultValue=false)]
        public bool? Rejected { get; set; }

        /// <summary>
        /// True if the content of this email is requires review by UltraCart
        /// </summary>
        /// <value>True if the content of this email is requires review by UltraCart</value>
        [DataMember(Name="requires_review", EmitDefaultValue=false)]
        public bool? RequiresReview { get; set; }

        /// <summary>
        /// URL to screenshot in large form factor full page
        /// </summary>
        /// <value>URL to screenshot in large form factor full page</value>
        [DataMember(Name="screenshot_large_full_url", EmitDefaultValue=false)]
        public string ScreenshotLargeFullUrl { get; set; }

        /// <summary>
        /// URL to screenshot in large form factor viewport
        /// </summary>
        /// <value>URL to screenshot in large form factor viewport</value>
        [DataMember(Name="screenshot_large_viewport_url", EmitDefaultValue=false)]
        public string ScreenshotLargeViewportUrl { get; set; }

        /// <summary>
        /// URL to screenshot in small form factor full page
        /// </summary>
        /// <value>URL to screenshot in small form factor full page</value>
        [DataMember(Name="screenshot_small_full_url", EmitDefaultValue=false)]
        public string ScreenshotSmallFullUrl { get; set; }

        /// <summary>
        /// URL to screenshot in small form factor viewport
        /// </summary>
        /// <value>URL to screenshot in small form factor viewport</value>
        [DataMember(Name="screenshot_small_viewport_url", EmitDefaultValue=false)]
        public string ScreenshotSmallViewportUrl { get; set; }

        /// <summary>
        /// Smart sending
        /// </summary>
        /// <value>Smart sending</value>
        [DataMember(Name="smart_sending", EmitDefaultValue=false)]
        public bool? SmartSending { get; set; }

        /// <summary>
        /// Storefront oid
        /// </summary>
        /// <value>Storefront oid</value>
        [DataMember(Name="storefront_oid", EmitDefaultValue=false)]
        public int? StorefrontOid { get; set; }

        /// <summary>
        /// Subject
        /// </summary>
        /// <value>Subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Transactional email
        /// </summary>
        /// <value>Transactional email</value>
        [DataMember(Name="transactional_email", EmitDefaultValue=false)]
        public bool? TransactionalEmail { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        /// <value>Version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailCommseqEmail {\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  EditedByUser: ").Append(EditedByUser).Append("\n");
            sb.Append("  EmailCommunicationSequenceEmailUuid: ").Append(EmailCommunicationSequenceEmailUuid).Append("\n");
            sb.Append("  EmailCommunicationSequenceUuid: ").Append(EmailCommunicationSequenceUuid).Append("\n");
            sb.Append("  EmailContainerCjson: ").Append(EmailContainerCjson).Append("\n");
            sb.Append("  EmailContainerCjsonLastModifiedDts: ").Append(EmailContainerCjsonLastModifiedDts).Append("\n");
            sb.Append("  EmailTemplateVmPath: ").Append(EmailTemplateVmPath).Append("\n");
            sb.Append("  FilterProfileEquationJson: ").Append(FilterProfileEquationJson).Append("\n");
            sb.Append("  IndividuallyRender: ").Append(IndividuallyRender).Append("\n");
            sb.Append("  LibraryItemOid: ").Append(LibraryItemOid).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  PendingReview: ").Append(PendingReview).Append("\n");
            sb.Append("  PreviewText: ").Append(PreviewText).Append("\n");
            sb.Append("  Rejected: ").Append(Rejected).Append("\n");
            sb.Append("  RequiresReview: ").Append(RequiresReview).Append("\n");
            sb.Append("  ScreenshotLargeFullUrl: ").Append(ScreenshotLargeFullUrl).Append("\n");
            sb.Append("  ScreenshotLargeViewportUrl: ").Append(ScreenshotLargeViewportUrl).Append("\n");
            sb.Append("  ScreenshotSmallFullUrl: ").Append(ScreenshotSmallFullUrl).Append("\n");
            sb.Append("  ScreenshotSmallViewportUrl: ").Append(ScreenshotSmallViewportUrl).Append("\n");
            sb.Append("  SmartSending: ").Append(SmartSending).Append("\n");
            sb.Append("  StorefrontOid: ").Append(StorefrontOid).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TransactionalEmail: ").Append(TransactionalEmail).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as EmailCommseqEmail);
        }

        /// <summary>
        /// Returns true if EmailCommseqEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailCommseqEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailCommseqEmail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.EditedByUser == input.EditedByUser ||
                    (this.EditedByUser != null &&
                    this.EditedByUser.Equals(input.EditedByUser))
                ) && 
                (
                    this.EmailCommunicationSequenceEmailUuid == input.EmailCommunicationSequenceEmailUuid ||
                    (this.EmailCommunicationSequenceEmailUuid != null &&
                    this.EmailCommunicationSequenceEmailUuid.Equals(input.EmailCommunicationSequenceEmailUuid))
                ) && 
                (
                    this.EmailCommunicationSequenceUuid == input.EmailCommunicationSequenceUuid ||
                    (this.EmailCommunicationSequenceUuid != null &&
                    this.EmailCommunicationSequenceUuid.Equals(input.EmailCommunicationSequenceUuid))
                ) && 
                (
                    this.EmailContainerCjson == input.EmailContainerCjson ||
                    (this.EmailContainerCjson != null &&
                    this.EmailContainerCjson.Equals(input.EmailContainerCjson))
                ) && 
                (
                    this.EmailContainerCjsonLastModifiedDts == input.EmailContainerCjsonLastModifiedDts ||
                    (this.EmailContainerCjsonLastModifiedDts != null &&
                    this.EmailContainerCjsonLastModifiedDts.Equals(input.EmailContainerCjsonLastModifiedDts))
                ) && 
                (
                    this.EmailTemplateVmPath == input.EmailTemplateVmPath ||
                    (this.EmailTemplateVmPath != null &&
                    this.EmailTemplateVmPath.Equals(input.EmailTemplateVmPath))
                ) && 
                (
                    this.FilterProfileEquationJson == input.FilterProfileEquationJson ||
                    (this.FilterProfileEquationJson != null &&
                    this.FilterProfileEquationJson.Equals(input.FilterProfileEquationJson))
                ) && 
                (
                    this.IndividuallyRender == input.IndividuallyRender ||
                    (this.IndividuallyRender != null &&
                    this.IndividuallyRender.Equals(input.IndividuallyRender))
                ) && 
                (
                    this.LibraryItemOid == input.LibraryItemOid ||
                    (this.LibraryItemOid != null &&
                    this.LibraryItemOid.Equals(input.LibraryItemOid))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.PendingReview == input.PendingReview ||
                    (this.PendingReview != null &&
                    this.PendingReview.Equals(input.PendingReview))
                ) && 
                (
                    this.PreviewText == input.PreviewText ||
                    (this.PreviewText != null &&
                    this.PreviewText.Equals(input.PreviewText))
                ) && 
                (
                    this.Rejected == input.Rejected ||
                    (this.Rejected != null &&
                    this.Rejected.Equals(input.Rejected))
                ) && 
                (
                    this.RequiresReview == input.RequiresReview ||
                    (this.RequiresReview != null &&
                    this.RequiresReview.Equals(input.RequiresReview))
                ) && 
                (
                    this.ScreenshotLargeFullUrl == input.ScreenshotLargeFullUrl ||
                    (this.ScreenshotLargeFullUrl != null &&
                    this.ScreenshotLargeFullUrl.Equals(input.ScreenshotLargeFullUrl))
                ) && 
                (
                    this.ScreenshotLargeViewportUrl == input.ScreenshotLargeViewportUrl ||
                    (this.ScreenshotLargeViewportUrl != null &&
                    this.ScreenshotLargeViewportUrl.Equals(input.ScreenshotLargeViewportUrl))
                ) && 
                (
                    this.ScreenshotSmallFullUrl == input.ScreenshotSmallFullUrl ||
                    (this.ScreenshotSmallFullUrl != null &&
                    this.ScreenshotSmallFullUrl.Equals(input.ScreenshotSmallFullUrl))
                ) && 
                (
                    this.ScreenshotSmallViewportUrl == input.ScreenshotSmallViewportUrl ||
                    (this.ScreenshotSmallViewportUrl != null &&
                    this.ScreenshotSmallViewportUrl.Equals(input.ScreenshotSmallViewportUrl))
                ) && 
                (
                    this.SmartSending == input.SmartSending ||
                    (this.SmartSending != null &&
                    this.SmartSending.Equals(input.SmartSending))
                ) && 
                (
                    this.StorefrontOid == input.StorefrontOid ||
                    (this.StorefrontOid != null &&
                    this.StorefrontOid.Equals(input.StorefrontOid))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.TransactionalEmail == input.TransactionalEmail ||
                    (this.TransactionalEmail != null &&
                    this.TransactionalEmail.Equals(input.TransactionalEmail))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.EditedByUser != null)
                    hashCode = hashCode * 59 + this.EditedByUser.GetHashCode();
                if (this.EmailCommunicationSequenceEmailUuid != null)
                    hashCode = hashCode * 59 + this.EmailCommunicationSequenceEmailUuid.GetHashCode();
                if (this.EmailCommunicationSequenceUuid != null)
                    hashCode = hashCode * 59 + this.EmailCommunicationSequenceUuid.GetHashCode();
                if (this.EmailContainerCjson != null)
                    hashCode = hashCode * 59 + this.EmailContainerCjson.GetHashCode();
                if (this.EmailContainerCjsonLastModifiedDts != null)
                    hashCode = hashCode * 59 + this.EmailContainerCjsonLastModifiedDts.GetHashCode();
                if (this.EmailTemplateVmPath != null)
                    hashCode = hashCode * 59 + this.EmailTemplateVmPath.GetHashCode();
                if (this.FilterProfileEquationJson != null)
                    hashCode = hashCode * 59 + this.FilterProfileEquationJson.GetHashCode();
                if (this.IndividuallyRender != null)
                    hashCode = hashCode * 59 + this.IndividuallyRender.GetHashCode();
                if (this.LibraryItemOid != null)
                    hashCode = hashCode * 59 + this.LibraryItemOid.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.PendingReview != null)
                    hashCode = hashCode * 59 + this.PendingReview.GetHashCode();
                if (this.PreviewText != null)
                    hashCode = hashCode * 59 + this.PreviewText.GetHashCode();
                if (this.Rejected != null)
                    hashCode = hashCode * 59 + this.Rejected.GetHashCode();
                if (this.RequiresReview != null)
                    hashCode = hashCode * 59 + this.RequiresReview.GetHashCode();
                if (this.ScreenshotLargeFullUrl != null)
                    hashCode = hashCode * 59 + this.ScreenshotLargeFullUrl.GetHashCode();
                if (this.ScreenshotLargeViewportUrl != null)
                    hashCode = hashCode * 59 + this.ScreenshotLargeViewportUrl.GetHashCode();
                if (this.ScreenshotSmallFullUrl != null)
                    hashCode = hashCode * 59 + this.ScreenshotSmallFullUrl.GetHashCode();
                if (this.ScreenshotSmallViewportUrl != null)
                    hashCode = hashCode * 59 + this.ScreenshotSmallViewportUrl.GetHashCode();
                if (this.SmartSending != null)
                    hashCode = hashCode * 59 + this.SmartSending.GetHashCode();
                if (this.StorefrontOid != null)
                    hashCode = hashCode * 59 + this.StorefrontOid.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.TransactionalEmail != null)
                    hashCode = hashCode * 59 + this.TransactionalEmail.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
