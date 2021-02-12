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
    /// EmailPerformanceDaily
    /// </summary>
    [DataContract]
    public partial class EmailPerformanceDaily :  IEquatable<EmailPerformanceDaily>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailPerformanceDaily" /> class.
        /// </summary>
        /// <param name="bounceCount">Bounce count.</param>
        /// <param name="deliveredCount">Delivered count.</param>
        /// <param name="revenue">Revenue.</param>
        /// <param name="sequenceSendCount">Total sequence (campaign/flow) emails sent.</param>
        /// <param name="spamCount">Spam complaints.</param>
        /// <param name="statDts">The date that these statistcs are for.</param>
        /// <param name="transactionalSendCount">Total transactions emails sent.</param>
        public EmailPerformanceDaily(int? bounceCount = default(int?), int? deliveredCount = default(int?), decimal? revenue = default(decimal?), int? sequenceSendCount = default(int?), int? spamCount = default(int?), string statDts = default(string), int? transactionalSendCount = default(int?))
        {
            this.BounceCount = bounceCount;
            this.DeliveredCount = deliveredCount;
            this.Revenue = revenue;
            this.SequenceSendCount = sequenceSendCount;
            this.SpamCount = spamCount;
            this.StatDts = statDts;
            this.TransactionalSendCount = transactionalSendCount;
        }
        
        /// <summary>
        /// Bounce count
        /// </summary>
        /// <value>Bounce count</value>
        [DataMember(Name="bounce_count", EmitDefaultValue=false)]
        public int? BounceCount { get; set; }

        /// <summary>
        /// Delivered count
        /// </summary>
        /// <value>Delivered count</value>
        [DataMember(Name="delivered_count", EmitDefaultValue=false)]
        public int? DeliveredCount { get; set; }

        /// <summary>
        /// Revenue
        /// </summary>
        /// <value>Revenue</value>
        [DataMember(Name="revenue", EmitDefaultValue=false)]
        public decimal? Revenue { get; set; }

        /// <summary>
        /// Total sequence (campaign/flow) emails sent
        /// </summary>
        /// <value>Total sequence (campaign/flow) emails sent</value>
        [DataMember(Name="sequence_send_count", EmitDefaultValue=false)]
        public int? SequenceSendCount { get; set; }

        /// <summary>
        /// Spam complaints
        /// </summary>
        /// <value>Spam complaints</value>
        [DataMember(Name="spam_count", EmitDefaultValue=false)]
        public int? SpamCount { get; set; }

        /// <summary>
        /// The date that these statistcs are for
        /// </summary>
        /// <value>The date that these statistcs are for</value>
        [DataMember(Name="stat_dts", EmitDefaultValue=false)]
        public string StatDts { get; set; }

        /// <summary>
        /// Total transactions emails sent
        /// </summary>
        /// <value>Total transactions emails sent</value>
        [DataMember(Name="transactional_send_count", EmitDefaultValue=false)]
        public int? TransactionalSendCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailPerformanceDaily {\n");
            sb.Append("  BounceCount: ").Append(BounceCount).Append("\n");
            sb.Append("  DeliveredCount: ").Append(DeliveredCount).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  SequenceSendCount: ").Append(SequenceSendCount).Append("\n");
            sb.Append("  SpamCount: ").Append(SpamCount).Append("\n");
            sb.Append("  StatDts: ").Append(StatDts).Append("\n");
            sb.Append("  TransactionalSendCount: ").Append(TransactionalSendCount).Append("\n");
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
            return this.Equals(input as EmailPerformanceDaily);
        }

        /// <summary>
        /// Returns true if EmailPerformanceDaily instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailPerformanceDaily to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailPerformanceDaily input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BounceCount == input.BounceCount ||
                    (this.BounceCount != null &&
                    this.BounceCount.Equals(input.BounceCount))
                ) && 
                (
                    this.DeliveredCount == input.DeliveredCount ||
                    (this.DeliveredCount != null &&
                    this.DeliveredCount.Equals(input.DeliveredCount))
                ) && 
                (
                    this.Revenue == input.Revenue ||
                    (this.Revenue != null &&
                    this.Revenue.Equals(input.Revenue))
                ) && 
                (
                    this.SequenceSendCount == input.SequenceSendCount ||
                    (this.SequenceSendCount != null &&
                    this.SequenceSendCount.Equals(input.SequenceSendCount))
                ) && 
                (
                    this.SpamCount == input.SpamCount ||
                    (this.SpamCount != null &&
                    this.SpamCount.Equals(input.SpamCount))
                ) && 
                (
                    this.StatDts == input.StatDts ||
                    (this.StatDts != null &&
                    this.StatDts.Equals(input.StatDts))
                ) && 
                (
                    this.TransactionalSendCount == input.TransactionalSendCount ||
                    (this.TransactionalSendCount != null &&
                    this.TransactionalSendCount.Equals(input.TransactionalSendCount))
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
                if (this.BounceCount != null)
                    hashCode = hashCode * 59 + this.BounceCount.GetHashCode();
                if (this.DeliveredCount != null)
                    hashCode = hashCode * 59 + this.DeliveredCount.GetHashCode();
                if (this.Revenue != null)
                    hashCode = hashCode * 59 + this.Revenue.GetHashCode();
                if (this.SequenceSendCount != null)
                    hashCode = hashCode * 59 + this.SequenceSendCount.GetHashCode();
                if (this.SpamCount != null)
                    hashCode = hashCode * 59 + this.SpamCount.GetHashCode();
                if (this.StatDts != null)
                    hashCode = hashCode * 59 + this.StatDts.GetHashCode();
                if (this.TransactionalSendCount != null)
                    hashCode = hashCode * 59 + this.TransactionalSendCount.GetHashCode();
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