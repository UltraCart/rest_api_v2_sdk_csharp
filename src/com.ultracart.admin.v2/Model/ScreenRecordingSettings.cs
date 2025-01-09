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
    /// ScreenRecordingSettings
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingSettings :  IEquatable<ScreenRecordingSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingSettings" /> class.
        /// </summary>
        /// <param name="costPerThousand">Cost per one thousand sessions.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="retentionInterval">How long screen recording data is retained.</param>
        /// <param name="sessionsCurrentBillingPeriod">sessionsCurrentBillingPeriod.</param>
        /// <param name="sessionsLastBillingPeriod">sessionsLastBillingPeriod.</param>
        /// <param name="sessionsTrialBillingPeriod">sessionsTrialBillingPeriod.</param>
        /// <param name="trialExpiration">trialExpiration.</param>
        /// <param name="trialExpired">trialExpired.</param>
        public ScreenRecordingSettings(decimal costPerThousand = default(decimal), bool enabled = default(bool), string retentionInterval = default(string), int sessionsCurrentBillingPeriod = default(int), int sessionsLastBillingPeriod = default(int), int sessionsTrialBillingPeriod = default(int), string trialExpiration = default(string), bool trialExpired = default(bool))
        {
            this.CostPerThousand = costPerThousand;
            this.Enabled = enabled;
            this.RetentionInterval = retentionInterval;
            this.SessionsCurrentBillingPeriod = sessionsCurrentBillingPeriod;
            this.SessionsLastBillingPeriod = sessionsLastBillingPeriod;
            this.SessionsTrialBillingPeriod = sessionsTrialBillingPeriod;
            this.TrialExpiration = trialExpiration;
            this.TrialExpired = trialExpired;
        }

        /// <summary>
        /// Cost per one thousand sessions
        /// </summary>
        /// <value>Cost per one thousand sessions</value>
        [DataMember(Name="cost_per_thousand", EmitDefaultValue=false)]
        public decimal CostPerThousand { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// How long screen recording data is retained
        /// </summary>
        /// <value>How long screen recording data is retained</value>
        [DataMember(Name="retention_interval", EmitDefaultValue=false)]
        public string RetentionInterval { get; set; }

        /// <summary>
        /// Gets or Sets SessionsCurrentBillingPeriod
        /// </summary>
        [DataMember(Name="sessions_current_billing_period", EmitDefaultValue=false)]
        public int SessionsCurrentBillingPeriod { get; set; }

        /// <summary>
        /// Gets or Sets SessionsLastBillingPeriod
        /// </summary>
        [DataMember(Name="sessions_last_billing_period", EmitDefaultValue=false)]
        public int SessionsLastBillingPeriod { get; set; }

        /// <summary>
        /// Gets or Sets SessionsTrialBillingPeriod
        /// </summary>
        [DataMember(Name="sessions_trial_billing_period", EmitDefaultValue=false)]
        public int SessionsTrialBillingPeriod { get; set; }

        /// <summary>
        /// Gets or Sets TrialExpiration
        /// </summary>
        [DataMember(Name="trial_expiration", EmitDefaultValue=false)]
        public string TrialExpiration { get; set; }

        /// <summary>
        /// Gets or Sets TrialExpired
        /// </summary>
        [DataMember(Name="trial_expired", EmitDefaultValue=false)]
        public bool TrialExpired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingSettings {\n");
            sb.Append("  CostPerThousand: ").Append(CostPerThousand).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  RetentionInterval: ").Append(RetentionInterval).Append("\n");
            sb.Append("  SessionsCurrentBillingPeriod: ").Append(SessionsCurrentBillingPeriod).Append("\n");
            sb.Append("  SessionsLastBillingPeriod: ").Append(SessionsLastBillingPeriod).Append("\n");
            sb.Append("  SessionsTrialBillingPeriod: ").Append(SessionsTrialBillingPeriod).Append("\n");
            sb.Append("  TrialExpiration: ").Append(TrialExpiration).Append("\n");
            sb.Append("  TrialExpired: ").Append(TrialExpired).Append("\n");
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
            return this.Equals(input as ScreenRecordingSettings);
        }

        /// <summary>
        /// Returns true if ScreenRecordingSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecordingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CostPerThousand == input.CostPerThousand ||
                    (this.CostPerThousand != null &&
                    this.CostPerThousand.Equals(input.CostPerThousand))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.RetentionInterval == input.RetentionInterval ||
                    (this.RetentionInterval != null &&
                    this.RetentionInterval.Equals(input.RetentionInterval))
                ) && 
                (
                    this.SessionsCurrentBillingPeriod == input.SessionsCurrentBillingPeriod ||
                    (this.SessionsCurrentBillingPeriod != null &&
                    this.SessionsCurrentBillingPeriod.Equals(input.SessionsCurrentBillingPeriod))
                ) && 
                (
                    this.SessionsLastBillingPeriod == input.SessionsLastBillingPeriod ||
                    (this.SessionsLastBillingPeriod != null &&
                    this.SessionsLastBillingPeriod.Equals(input.SessionsLastBillingPeriod))
                ) && 
                (
                    this.SessionsTrialBillingPeriod == input.SessionsTrialBillingPeriod ||
                    (this.SessionsTrialBillingPeriod != null &&
                    this.SessionsTrialBillingPeriod.Equals(input.SessionsTrialBillingPeriod))
                ) && 
                (
                    this.TrialExpiration == input.TrialExpiration ||
                    (this.TrialExpiration != null &&
                    this.TrialExpiration.Equals(input.TrialExpiration))
                ) && 
                (
                    this.TrialExpired == input.TrialExpired ||
                    (this.TrialExpired != null &&
                    this.TrialExpired.Equals(input.TrialExpired))
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
                if (this.CostPerThousand != null)
                    hashCode = hashCode * 59 + this.CostPerThousand.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.RetentionInterval != null)
                    hashCode = hashCode * 59 + this.RetentionInterval.GetHashCode();
                if (this.SessionsCurrentBillingPeriod != null)
                    hashCode = hashCode * 59 + this.SessionsCurrentBillingPeriod.GetHashCode();
                if (this.SessionsLastBillingPeriod != null)
                    hashCode = hashCode * 59 + this.SessionsLastBillingPeriod.GetHashCode();
                if (this.SessionsTrialBillingPeriod != null)
                    hashCode = hashCode * 59 + this.SessionsTrialBillingPeriod.GetHashCode();
                if (this.TrialExpiration != null)
                    hashCode = hashCode * 59 + this.TrialExpiration.GetHashCode();
                if (this.TrialExpired != null)
                    hashCode = hashCode * 59 + this.TrialExpired.GetHashCode();
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
