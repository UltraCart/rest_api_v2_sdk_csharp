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
    /// CustomerLoyalty
    /// </summary>
    [DataContract]
    public partial class CustomerLoyalty :  IEquatable<CustomerLoyalty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerLoyalty" /> class.
        /// </summary>
        /// <param name="currentPoints">Current Points.</param>
        /// <param name="ledgerEntries">Ledger entries.</param>
        /// <param name="pendingPoints">Pending Points.</param>
        /// <param name="redemptions">Redemptions.</param>
        public CustomerLoyalty(int? currentPoints = default(int?), List<CustomerLoyaltyLedger> ledgerEntries = default(List<CustomerLoyaltyLedger>), int? pendingPoints = default(int?), List<CustomerLoyaltyRedemption> redemptions = default(List<CustomerLoyaltyRedemption>))
        {
            this.CurrentPoints = currentPoints;
            this.LedgerEntries = ledgerEntries;
            this.PendingPoints = pendingPoints;
            this.Redemptions = redemptions;
        }
        
        /// <summary>
        /// Current Points
        /// </summary>
        /// <value>Current Points</value>
        [DataMember(Name="current_points", EmitDefaultValue=false)]
        public int? CurrentPoints { get; set; }

        /// <summary>
        /// Ledger entries
        /// </summary>
        /// <value>Ledger entries</value>
        [DataMember(Name="ledger_entries", EmitDefaultValue=false)]
        public List<CustomerLoyaltyLedger> LedgerEntries { get; set; }

        /// <summary>
        /// Pending Points
        /// </summary>
        /// <value>Pending Points</value>
        [DataMember(Name="pending_points", EmitDefaultValue=false)]
        public int? PendingPoints { get; set; }

        /// <summary>
        /// Redemptions
        /// </summary>
        /// <value>Redemptions</value>
        [DataMember(Name="redemptions", EmitDefaultValue=false)]
        public List<CustomerLoyaltyRedemption> Redemptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerLoyalty {\n");
            sb.Append("  CurrentPoints: ").Append(CurrentPoints).Append("\n");
            sb.Append("  LedgerEntries: ").Append(LedgerEntries).Append("\n");
            sb.Append("  PendingPoints: ").Append(PendingPoints).Append("\n");
            sb.Append("  Redemptions: ").Append(Redemptions).Append("\n");
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
            return this.Equals(input as CustomerLoyalty);
        }

        /// <summary>
        /// Returns true if CustomerLoyalty instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerLoyalty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerLoyalty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentPoints == input.CurrentPoints ||
                    (this.CurrentPoints != null &&
                    this.CurrentPoints.Equals(input.CurrentPoints))
                ) && 
                (
                    this.LedgerEntries == input.LedgerEntries ||
                    this.LedgerEntries != null &&
                    this.LedgerEntries.SequenceEqual(input.LedgerEntries)
                ) && 
                (
                    this.PendingPoints == input.PendingPoints ||
                    (this.PendingPoints != null &&
                    this.PendingPoints.Equals(input.PendingPoints))
                ) && 
                (
                    this.Redemptions == input.Redemptions ||
                    this.Redemptions != null &&
                    this.Redemptions.SequenceEqual(input.Redemptions)
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
                if (this.CurrentPoints != null)
                    hashCode = hashCode * 59 + this.CurrentPoints.GetHashCode();
                if (this.LedgerEntries != null)
                    hashCode = hashCode * 59 + this.LedgerEntries.GetHashCode();
                if (this.PendingPoints != null)
                    hashCode = hashCode * 59 + this.PendingPoints.GetHashCode();
                if (this.Redemptions != null)
                    hashCode = hashCode * 59 + this.Redemptions.GetHashCode();
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
