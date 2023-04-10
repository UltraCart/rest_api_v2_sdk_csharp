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
    /// AccountsReceivableRetryConfig
    /// </summary>
    [DataContract]
    public partial class AccountsReceivableRetryConfig :  IEquatable<AccountsReceivableRetryConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsReceivableRetryConfig" /> class.
        /// </summary>
        /// <param name="active">True if the retry should run daily.  False puts the retry service into an inactive state for this merchant..</param>
        /// <param name="allowProcessLinkedAccounts">True if this account has linked accounts that it can process..</param>
        /// <param name="cancelAutoOrder">If true also cancel the auto order if the order is rejected at the end.</param>
        /// <param name="currentServicePlan">The current service plan that the account is on..</param>
        /// <param name="dailyActivityList">A list of days and what actions should take place on those days after an order reaches accounts receivable.</param>
        /// <param name="managedByLinkedAccountMerchantId">If not null, this account is managed by the specified parent merchant id..</param>
        /// <param name="merchantId">UltraCart merchant ID.</param>
        /// <param name="notifyEmails">A list of email addresses to receive summary notifications from the retry service..</param>
        /// <param name="notifyRejections">If true, email addresses are notified of rejections..</param>
        /// <param name="notifySuccesses">If true, email addresses are notified of successful charges..</param>
        /// <param name="processLinkedAccounts">If true, all linked accounts are also processed using the same rules..</param>
        /// <param name="processingPercentage">The percentage rate charged for the service..</param>
        /// <param name="rejectAtEnd">If true, the order is rejected the day after the last configured activity day.</param>
        /// <param name="transactionRejects">Array of key/value pairs that when found in the response cause the rejection of the transaction..</param>
        /// <param name="trialMode">True if the account is currently in trial mode.  Set to false to exit trial mode..</param>
        /// <param name="trialModeExpirationDts">The date when trial mode expires.  If this date is reached without exiting trial mode, the service will de-activate..</param>
        public AccountsReceivableRetryConfig(bool? active = default(bool?), bool? allowProcessLinkedAccounts = default(bool?), bool? cancelAutoOrder = default(bool?), string currentServicePlan = default(string), List<AccountsReceivableRetryDayActivity> dailyActivityList = default(List<AccountsReceivableRetryDayActivity>), bool? managedByLinkedAccountMerchantId = default(bool?), string merchantId = default(string), List<string> notifyEmails = default(List<string>), bool? notifyRejections = default(bool?), bool? notifySuccesses = default(bool?), bool? processLinkedAccounts = default(bool?), string processingPercentage = default(string), bool? rejectAtEnd = default(bool?), List<AccountsReceivableRetryTransactionReject> transactionRejects = default(List<AccountsReceivableRetryTransactionReject>), bool? trialMode = default(bool?), string trialModeExpirationDts = default(string))
        {
            this.Active = active;
            this.AllowProcessLinkedAccounts = allowProcessLinkedAccounts;
            this.CancelAutoOrder = cancelAutoOrder;
            this.CurrentServicePlan = currentServicePlan;
            this.DailyActivityList = dailyActivityList;
            this.ManagedByLinkedAccountMerchantId = managedByLinkedAccountMerchantId;
            this.MerchantId = merchantId;
            this.NotifyEmails = notifyEmails;
            this.NotifyRejections = notifyRejections;
            this.NotifySuccesses = notifySuccesses;
            this.ProcessLinkedAccounts = processLinkedAccounts;
            this.ProcessingPercentage = processingPercentage;
            this.RejectAtEnd = rejectAtEnd;
            this.TransactionRejects = transactionRejects;
            this.TrialMode = trialMode;
            this.TrialModeExpirationDts = trialModeExpirationDts;
        }
        
        /// <summary>
        /// True if the retry should run daily.  False puts the retry service into an inactive state for this merchant.
        /// </summary>
        /// <value>True if the retry should run daily.  False puts the retry service into an inactive state for this merchant.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// True if this account has linked accounts that it can process.
        /// </summary>
        /// <value>True if this account has linked accounts that it can process.</value>
        [DataMember(Name="allow_process_linked_accounts", EmitDefaultValue=false)]
        public bool? AllowProcessLinkedAccounts { get; set; }

        /// <summary>
        /// If true also cancel the auto order if the order is rejected at the end
        /// </summary>
        /// <value>If true also cancel the auto order if the order is rejected at the end</value>
        [DataMember(Name="cancel_auto_order", EmitDefaultValue=false)]
        public bool? CancelAutoOrder { get; set; }

        /// <summary>
        /// The current service plan that the account is on.
        /// </summary>
        /// <value>The current service plan that the account is on.</value>
        [DataMember(Name="current_service_plan", EmitDefaultValue=false)]
        public string CurrentServicePlan { get; set; }

        /// <summary>
        /// A list of days and what actions should take place on those days after an order reaches accounts receivable
        /// </summary>
        /// <value>A list of days and what actions should take place on those days after an order reaches accounts receivable</value>
        [DataMember(Name="daily_activity_list", EmitDefaultValue=false)]
        public List<AccountsReceivableRetryDayActivity> DailyActivityList { get; set; }

        /// <summary>
        /// If not null, this account is managed by the specified parent merchant id.
        /// </summary>
        /// <value>If not null, this account is managed by the specified parent merchant id.</value>
        [DataMember(Name="managed_by_linked_account_merchant_id", EmitDefaultValue=false)]
        public bool? ManagedByLinkedAccountMerchantId { get; set; }

        /// <summary>
        /// UltraCart merchant ID
        /// </summary>
        /// <value>UltraCart merchant ID</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// A list of email addresses to receive summary notifications from the retry service.
        /// </summary>
        /// <value>A list of email addresses to receive summary notifications from the retry service.</value>
        [DataMember(Name="notify_emails", EmitDefaultValue=false)]
        public List<string> NotifyEmails { get; set; }

        /// <summary>
        /// If true, email addresses are notified of rejections.
        /// </summary>
        /// <value>If true, email addresses are notified of rejections.</value>
        [DataMember(Name="notify_rejections", EmitDefaultValue=false)]
        public bool? NotifyRejections { get; set; }

        /// <summary>
        /// If true, email addresses are notified of successful charges.
        /// </summary>
        /// <value>If true, email addresses are notified of successful charges.</value>
        [DataMember(Name="notify_successes", EmitDefaultValue=false)]
        public bool? NotifySuccesses { get; set; }

        /// <summary>
        /// If true, all linked accounts are also processed using the same rules.
        /// </summary>
        /// <value>If true, all linked accounts are also processed using the same rules.</value>
        [DataMember(Name="process_linked_accounts", EmitDefaultValue=false)]
        public bool? ProcessLinkedAccounts { get; set; }

        /// <summary>
        /// The percentage rate charged for the service.
        /// </summary>
        /// <value>The percentage rate charged for the service.</value>
        [DataMember(Name="processing_percentage", EmitDefaultValue=false)]
        public string ProcessingPercentage { get; set; }

        /// <summary>
        /// If true, the order is rejected the day after the last configured activity day
        /// </summary>
        /// <value>If true, the order is rejected the day after the last configured activity day</value>
        [DataMember(Name="reject_at_end", EmitDefaultValue=false)]
        public bool? RejectAtEnd { get; set; }

        /// <summary>
        /// Array of key/value pairs that when found in the response cause the rejection of the transaction.
        /// </summary>
        /// <value>Array of key/value pairs that when found in the response cause the rejection of the transaction.</value>
        [DataMember(Name="transaction_rejects", EmitDefaultValue=false)]
        public List<AccountsReceivableRetryTransactionReject> TransactionRejects { get; set; }

        /// <summary>
        /// True if the account is currently in trial mode.  Set to false to exit trial mode.
        /// </summary>
        /// <value>True if the account is currently in trial mode.  Set to false to exit trial mode.</value>
        [DataMember(Name="trial_mode", EmitDefaultValue=false)]
        public bool? TrialMode { get; set; }

        /// <summary>
        /// The date when trial mode expires.  If this date is reached without exiting trial mode, the service will de-activate.
        /// </summary>
        /// <value>The date when trial mode expires.  If this date is reached without exiting trial mode, the service will de-activate.</value>
        [DataMember(Name="trial_mode_expiration_dts", EmitDefaultValue=false)]
        public string TrialModeExpirationDts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountsReceivableRetryConfig {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AllowProcessLinkedAccounts: ").Append(AllowProcessLinkedAccounts).Append("\n");
            sb.Append("  CancelAutoOrder: ").Append(CancelAutoOrder).Append("\n");
            sb.Append("  CurrentServicePlan: ").Append(CurrentServicePlan).Append("\n");
            sb.Append("  DailyActivityList: ").Append(DailyActivityList).Append("\n");
            sb.Append("  ManagedByLinkedAccountMerchantId: ").Append(ManagedByLinkedAccountMerchantId).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  NotifyEmails: ").Append(NotifyEmails).Append("\n");
            sb.Append("  NotifyRejections: ").Append(NotifyRejections).Append("\n");
            sb.Append("  NotifySuccesses: ").Append(NotifySuccesses).Append("\n");
            sb.Append("  ProcessLinkedAccounts: ").Append(ProcessLinkedAccounts).Append("\n");
            sb.Append("  ProcessingPercentage: ").Append(ProcessingPercentage).Append("\n");
            sb.Append("  RejectAtEnd: ").Append(RejectAtEnd).Append("\n");
            sb.Append("  TransactionRejects: ").Append(TransactionRejects).Append("\n");
            sb.Append("  TrialMode: ").Append(TrialMode).Append("\n");
            sb.Append("  TrialModeExpirationDts: ").Append(TrialModeExpirationDts).Append("\n");
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
            return this.Equals(input as AccountsReceivableRetryConfig);
        }

        /// <summary>
        /// Returns true if AccountsReceivableRetryConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountsReceivableRetryConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountsReceivableRetryConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.AllowProcessLinkedAccounts == input.AllowProcessLinkedAccounts ||
                    (this.AllowProcessLinkedAccounts != null &&
                    this.AllowProcessLinkedAccounts.Equals(input.AllowProcessLinkedAccounts))
                ) && 
                (
                    this.CancelAutoOrder == input.CancelAutoOrder ||
                    (this.CancelAutoOrder != null &&
                    this.CancelAutoOrder.Equals(input.CancelAutoOrder))
                ) && 
                (
                    this.CurrentServicePlan == input.CurrentServicePlan ||
                    (this.CurrentServicePlan != null &&
                    this.CurrentServicePlan.Equals(input.CurrentServicePlan))
                ) && 
                (
                    this.DailyActivityList == input.DailyActivityList ||
                    this.DailyActivityList != null &&
                    this.DailyActivityList.SequenceEqual(input.DailyActivityList)
                ) && 
                (
                    this.ManagedByLinkedAccountMerchantId == input.ManagedByLinkedAccountMerchantId ||
                    (this.ManagedByLinkedAccountMerchantId != null &&
                    this.ManagedByLinkedAccountMerchantId.Equals(input.ManagedByLinkedAccountMerchantId))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.NotifyEmails == input.NotifyEmails ||
                    this.NotifyEmails != null &&
                    this.NotifyEmails.SequenceEqual(input.NotifyEmails)
                ) && 
                (
                    this.NotifyRejections == input.NotifyRejections ||
                    (this.NotifyRejections != null &&
                    this.NotifyRejections.Equals(input.NotifyRejections))
                ) && 
                (
                    this.NotifySuccesses == input.NotifySuccesses ||
                    (this.NotifySuccesses != null &&
                    this.NotifySuccesses.Equals(input.NotifySuccesses))
                ) && 
                (
                    this.ProcessLinkedAccounts == input.ProcessLinkedAccounts ||
                    (this.ProcessLinkedAccounts != null &&
                    this.ProcessLinkedAccounts.Equals(input.ProcessLinkedAccounts))
                ) && 
                (
                    this.ProcessingPercentage == input.ProcessingPercentage ||
                    (this.ProcessingPercentage != null &&
                    this.ProcessingPercentage.Equals(input.ProcessingPercentage))
                ) && 
                (
                    this.RejectAtEnd == input.RejectAtEnd ||
                    (this.RejectAtEnd != null &&
                    this.RejectAtEnd.Equals(input.RejectAtEnd))
                ) && 
                (
                    this.TransactionRejects == input.TransactionRejects ||
                    this.TransactionRejects != null &&
                    this.TransactionRejects.SequenceEqual(input.TransactionRejects)
                ) && 
                (
                    this.TrialMode == input.TrialMode ||
                    (this.TrialMode != null &&
                    this.TrialMode.Equals(input.TrialMode))
                ) && 
                (
                    this.TrialModeExpirationDts == input.TrialModeExpirationDts ||
                    (this.TrialModeExpirationDts != null &&
                    this.TrialModeExpirationDts.Equals(input.TrialModeExpirationDts))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.AllowProcessLinkedAccounts != null)
                    hashCode = hashCode * 59 + this.AllowProcessLinkedAccounts.GetHashCode();
                if (this.CancelAutoOrder != null)
                    hashCode = hashCode * 59 + this.CancelAutoOrder.GetHashCode();
                if (this.CurrentServicePlan != null)
                    hashCode = hashCode * 59 + this.CurrentServicePlan.GetHashCode();
                if (this.DailyActivityList != null)
                    hashCode = hashCode * 59 + this.DailyActivityList.GetHashCode();
                if (this.ManagedByLinkedAccountMerchantId != null)
                    hashCode = hashCode * 59 + this.ManagedByLinkedAccountMerchantId.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.NotifyEmails != null)
                    hashCode = hashCode * 59 + this.NotifyEmails.GetHashCode();
                if (this.NotifyRejections != null)
                    hashCode = hashCode * 59 + this.NotifyRejections.GetHashCode();
                if (this.NotifySuccesses != null)
                    hashCode = hashCode * 59 + this.NotifySuccesses.GetHashCode();
                if (this.ProcessLinkedAccounts != null)
                    hashCode = hashCode * 59 + this.ProcessLinkedAccounts.GetHashCode();
                if (this.ProcessingPercentage != null)
                    hashCode = hashCode * 59 + this.ProcessingPercentage.GetHashCode();
                if (this.RejectAtEnd != null)
                    hashCode = hashCode * 59 + this.RejectAtEnd.GetHashCode();
                if (this.TransactionRejects != null)
                    hashCode = hashCode * 59 + this.TransactionRejects.GetHashCode();
                if (this.TrialMode != null)
                    hashCode = hashCode * 59 + this.TrialMode.GetHashCode();
                if (this.TrialModeExpirationDts != null)
                    hashCode = hashCode * 59 + this.TrialModeExpirationDts.GetHashCode();
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
