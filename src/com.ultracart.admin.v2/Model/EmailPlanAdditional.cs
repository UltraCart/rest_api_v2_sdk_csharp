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
    /// EmailPlanAdditional
    /// </summary>
    [DataContract]
    public partial class EmailPlanAdditional :  IEquatable<EmailPlanAdditional>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailPlanAdditional" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="canDowngrade">canDowngrade.</param>
        /// <param name="canUpgrade">canUpgrade.</param>
        /// <param name="cost">cost.</param>
        /// <param name="costChange">costChange.</param>
        /// <param name="costChangeFormatted">costChangeFormatted.</param>
        /// <param name="costFormatted">costFormatted.</param>
        /// <param name="customers">customers.</param>
        /// <param name="emails">emails.</param>
        public EmailPlanAdditional(bool? active = default(bool?), bool? canDowngrade = default(bool?), bool? canUpgrade = default(bool?), decimal? cost = default(decimal?), decimal? costChange = default(decimal?), string costChangeFormatted = default(string), string costFormatted = default(string), int? customers = default(int?), int? emails = default(int?))
        {
            this.Active = active;
            this.CanDowngrade = canDowngrade;
            this.CanUpgrade = canUpgrade;
            this.Cost = cost;
            this.CostChange = costChange;
            this.CostChangeFormatted = costChangeFormatted;
            this.CostFormatted = costFormatted;
            this.Customers = customers;
            this.Emails = emails;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets CanDowngrade
        /// </summary>
        [DataMember(Name="can_downgrade", EmitDefaultValue=false)]
        public bool? CanDowngrade { get; set; }

        /// <summary>
        /// Gets or Sets CanUpgrade
        /// </summary>
        [DataMember(Name="can_upgrade", EmitDefaultValue=false)]
        public bool? CanUpgrade { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Gets or Sets CostChange
        /// </summary>
        [DataMember(Name="cost_change", EmitDefaultValue=false)]
        public decimal? CostChange { get; set; }

        /// <summary>
        /// Gets or Sets CostChangeFormatted
        /// </summary>
        [DataMember(Name="cost_change_formatted", EmitDefaultValue=false)]
        public string CostChangeFormatted { get; set; }

        /// <summary>
        /// Gets or Sets CostFormatted
        /// </summary>
        [DataMember(Name="cost_formatted", EmitDefaultValue=false)]
        public string CostFormatted { get; set; }

        /// <summary>
        /// Gets or Sets Customers
        /// </summary>
        [DataMember(Name="customers", EmitDefaultValue=false)]
        public int? Customers { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public int? Emails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailPlanAdditional {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CanDowngrade: ").Append(CanDowngrade).Append("\n");
            sb.Append("  CanUpgrade: ").Append(CanUpgrade).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CostChange: ").Append(CostChange).Append("\n");
            sb.Append("  CostChangeFormatted: ").Append(CostChangeFormatted).Append("\n");
            sb.Append("  CostFormatted: ").Append(CostFormatted).Append("\n");
            sb.Append("  Customers: ").Append(Customers).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
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
            return this.Equals(input as EmailPlanAdditional);
        }

        /// <summary>
        /// Returns true if EmailPlanAdditional instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailPlanAdditional to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailPlanAdditional input)
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
                    this.CanDowngrade == input.CanDowngrade ||
                    (this.CanDowngrade != null &&
                    this.CanDowngrade.Equals(input.CanDowngrade))
                ) && 
                (
                    this.CanUpgrade == input.CanUpgrade ||
                    (this.CanUpgrade != null &&
                    this.CanUpgrade.Equals(input.CanUpgrade))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.CostChange == input.CostChange ||
                    (this.CostChange != null &&
                    this.CostChange.Equals(input.CostChange))
                ) && 
                (
                    this.CostChangeFormatted == input.CostChangeFormatted ||
                    (this.CostChangeFormatted != null &&
                    this.CostChangeFormatted.Equals(input.CostChangeFormatted))
                ) && 
                (
                    this.CostFormatted == input.CostFormatted ||
                    (this.CostFormatted != null &&
                    this.CostFormatted.Equals(input.CostFormatted))
                ) && 
                (
                    this.Customers == input.Customers ||
                    (this.Customers != null &&
                    this.Customers.Equals(input.Customers))
                ) && 
                (
                    this.Emails == input.Emails ||
                    (this.Emails != null &&
                    this.Emails.Equals(input.Emails))
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
                if (this.CanDowngrade != null)
                    hashCode = hashCode * 59 + this.CanDowngrade.GetHashCode();
                if (this.CanUpgrade != null)
                    hashCode = hashCode * 59 + this.CanUpgrade.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.CostChange != null)
                    hashCode = hashCode * 59 + this.CostChange.GetHashCode();
                if (this.CostChangeFormatted != null)
                    hashCode = hashCode * 59 + this.CostChangeFormatted.GetHashCode();
                if (this.CostFormatted != null)
                    hashCode = hashCode * 59 + this.CostFormatted.GetHashCode();
                if (this.Customers != null)
                    hashCode = hashCode * 59 + this.Customers.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
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
