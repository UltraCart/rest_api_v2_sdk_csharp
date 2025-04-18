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
    /// CustomerLoyalty
    /// </summary>
    [DataContract]
    public partial class CustomerLoyalty :  IEquatable<CustomerLoyalty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerLoyalty" /> class.
        /// </summary>
        /// <param name="currentPoints">Current points.</param>
        /// <param name="internalGiftCertificate">internalGiftCertificate.</param>
        /// <param name="internalGiftCertificateBalance">Loyalty Cashback / Store credit balance (internal gift certificate balance).</param>
        /// <param name="internalGiftCertificateOid">Internal gift certificate oid used to tracking loyalty cashback / store credit..</param>
        /// <param name="ledgerEntries">Ledger entries.</param>
        /// <param name="pendingPoints">Pending Points.</param>
        /// <param name="redemptions">Redemptions.</param>
        public CustomerLoyalty(int currentPoints = default(int), GiftCertificate internalGiftCertificate = default(GiftCertificate), string internalGiftCertificateBalance = default(string), int internalGiftCertificateOid = default(int), List<CustomerLoyaltyLedger> ledgerEntries = default(List<CustomerLoyaltyLedger>), int pendingPoints = default(int), List<CustomerLoyaltyRedemption> redemptions = default(List<CustomerLoyaltyRedemption>))
        {
            this.CurrentPoints = currentPoints;
            this.InternalGiftCertificate = internalGiftCertificate;
            this.InternalGiftCertificateBalance = internalGiftCertificateBalance;
            this.InternalGiftCertificateOid = internalGiftCertificateOid;
            this.LedgerEntries = ledgerEntries;
            this.PendingPoints = pendingPoints;
            this.Redemptions = redemptions;
        }

        /// <summary>
        /// Current points
        /// </summary>
        /// <value>Current points</value>
        [DataMember(Name="current_points", EmitDefaultValue=false)]
        public int CurrentPoints { get; set; }

        /// <summary>
        /// Gets or Sets InternalGiftCertificate
        /// </summary>
        [DataMember(Name="internal_gift_certificate", EmitDefaultValue=false)]
        public GiftCertificate InternalGiftCertificate { get; set; }

        /// <summary>
        /// Loyalty Cashback / Store credit balance (internal gift certificate balance)
        /// </summary>
        /// <value>Loyalty Cashback / Store credit balance (internal gift certificate balance)</value>
        [DataMember(Name="internal_gift_certificate_balance", EmitDefaultValue=false)]
        public string InternalGiftCertificateBalance { get; set; }

        /// <summary>
        /// Internal gift certificate oid used to tracking loyalty cashback / store credit.
        /// </summary>
        /// <value>Internal gift certificate oid used to tracking loyalty cashback / store credit.</value>
        [DataMember(Name="internal_gift_certificate_oid", EmitDefaultValue=false)]
        public int InternalGiftCertificateOid { get; set; }

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
        public int PendingPoints { get; set; }

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
            sb.Append("  InternalGiftCertificate: ").Append(InternalGiftCertificate).Append("\n");
            sb.Append("  InternalGiftCertificateBalance: ").Append(InternalGiftCertificateBalance).Append("\n");
            sb.Append("  InternalGiftCertificateOid: ").Append(InternalGiftCertificateOid).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
                    this.InternalGiftCertificate == input.InternalGiftCertificate ||
                    (this.InternalGiftCertificate != null &&
                    this.InternalGiftCertificate.Equals(input.InternalGiftCertificate))
                ) && 
                (
                    this.InternalGiftCertificateBalance == input.InternalGiftCertificateBalance ||
                    (this.InternalGiftCertificateBalance != null &&
                    this.InternalGiftCertificateBalance.Equals(input.InternalGiftCertificateBalance))
                ) && 
                (
                    this.InternalGiftCertificateOid == input.InternalGiftCertificateOid ||
                    (this.InternalGiftCertificateOid != null &&
                    this.InternalGiftCertificateOid.Equals(input.InternalGiftCertificateOid))
                ) && 
                (
                    this.LedgerEntries == input.LedgerEntries ||
                    this.LedgerEntries != null &&
                    input.LedgerEntries != null &&
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
                    input.Redemptions != null &&
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
                if (this.InternalGiftCertificate != null)
                    hashCode = hashCode * 59 + this.InternalGiftCertificate.GetHashCode();
                if (this.InternalGiftCertificateBalance != null)
                    hashCode = hashCode * 59 + this.InternalGiftCertificateBalance.GetHashCode();
                if (this.InternalGiftCertificateOid != null)
                    hashCode = hashCode * 59 + this.InternalGiftCertificateOid.GetHashCode();
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
