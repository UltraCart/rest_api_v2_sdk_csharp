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
    /// OrderInternal
    /// </summary>
    [DataContract]
    public partial class OrderInternal :  IEquatable<OrderInternal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInternal" /> class.
        /// </summary>
        /// <param name="ExportedToAccounting">True if the order has been exported to QuickBooks. If QuickBooks is not configured, then this will already be true.</param>
        /// <param name="MerchantNotes">Merchant notes.</param>
        /// <param name="PlacedByUser">If placed via the BEOE, this is the user that placed the order.</param>
        /// <param name="RefundByUser">User that issued the refund.</param>
        /// <param name="SalesRepCode">Sales rep code associated with the order.</param>
        public OrderInternal(bool? ExportedToAccounting = default(bool?), string MerchantNotes = default(string), string PlacedByUser = default(string), string RefundByUser = default(string), string SalesRepCode = default(string))
        {
            this.ExportedToAccounting = ExportedToAccounting;
            this.MerchantNotes = MerchantNotes;
            this.PlacedByUser = PlacedByUser;
            this.RefundByUser = RefundByUser;
            this.SalesRepCode = SalesRepCode;
        }
        
        /// <summary>
        /// True if the order has been exported to QuickBooks. If QuickBooks is not configured, then this will already be true
        /// </summary>
        /// <value>True if the order has been exported to QuickBooks. If QuickBooks is not configured, then this will already be true</value>
        [DataMember(Name="exported_to_accounting", EmitDefaultValue=false)]
        public bool? ExportedToAccounting { get; set; }

        /// <summary>
        /// Merchant notes
        /// </summary>
        /// <value>Merchant notes</value>
        [DataMember(Name="merchant_notes", EmitDefaultValue=false)]
        public string MerchantNotes { get; set; }

        /// <summary>
        /// If placed via the BEOE, this is the user that placed the order
        /// </summary>
        /// <value>If placed via the BEOE, this is the user that placed the order</value>
        [DataMember(Name="placed_by_user", EmitDefaultValue=false)]
        public string PlacedByUser { get; set; }

        /// <summary>
        /// User that issued the refund
        /// </summary>
        /// <value>User that issued the refund</value>
        [DataMember(Name="refund_by_user", EmitDefaultValue=false)]
        public string RefundByUser { get; set; }

        /// <summary>
        /// Sales rep code associated with the order
        /// </summary>
        /// <value>Sales rep code associated with the order</value>
        [DataMember(Name="sales_rep_code", EmitDefaultValue=false)]
        public string SalesRepCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderInternal {\n");
            sb.Append("  ExportedToAccounting: ").Append(ExportedToAccounting).Append("\n");
            sb.Append("  MerchantNotes: ").Append(MerchantNotes).Append("\n");
            sb.Append("  PlacedByUser: ").Append(PlacedByUser).Append("\n");
            sb.Append("  RefundByUser: ").Append(RefundByUser).Append("\n");
            sb.Append("  SalesRepCode: ").Append(SalesRepCode).Append("\n");
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
            return this.Equals(input as OrderInternal);
        }

        /// <summary>
        /// Returns true if OrderInternal instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderInternal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderInternal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExportedToAccounting == input.ExportedToAccounting ||
                    (this.ExportedToAccounting != null &&
                    this.ExportedToAccounting.Equals(input.ExportedToAccounting))
                ) && 
                (
                    this.MerchantNotes == input.MerchantNotes ||
                    (this.MerchantNotes != null &&
                    this.MerchantNotes.Equals(input.MerchantNotes))
                ) && 
                (
                    this.PlacedByUser == input.PlacedByUser ||
                    (this.PlacedByUser != null &&
                    this.PlacedByUser.Equals(input.PlacedByUser))
                ) && 
                (
                    this.RefundByUser == input.RefundByUser ||
                    (this.RefundByUser != null &&
                    this.RefundByUser.Equals(input.RefundByUser))
                ) && 
                (
                    this.SalesRepCode == input.SalesRepCode ||
                    (this.SalesRepCode != null &&
                    this.SalesRepCode.Equals(input.SalesRepCode))
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
                if (this.ExportedToAccounting != null)
                    hashCode = hashCode * 59 + this.ExportedToAccounting.GetHashCode();
                if (this.MerchantNotes != null)
                    hashCode = hashCode * 59 + this.MerchantNotes.GetHashCode();
                if (this.PlacedByUser != null)
                    hashCode = hashCode * 59 + this.PlacedByUser.GetHashCode();
                if (this.RefundByUser != null)
                    hashCode = hashCode * 59 + this.RefundByUser.GetHashCode();
                if (this.SalesRepCode != null)
                    hashCode = hashCode * 59 + this.SalesRepCode.GetHashCode();
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
            // SalesRepCode (string) maxLength
            if(this.SalesRepCode != null && this.SalesRepCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalesRepCode, length must be less than 10.", new [] { "SalesRepCode" });
            }

            yield break;
        }
    }

}
