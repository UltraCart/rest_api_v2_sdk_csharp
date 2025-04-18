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
    /// ItemChargeback
    /// </summary>
    [DataContract]
    public partial class ItemChargeback :  IEquatable<ItemChargeback>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemChargeback" /> class.
        /// </summary>
        /// <param name="addendums">Addendums (deprecated).</param>
        /// <param name="adjustmentRequests">Adjustment requests (deprecated).</param>
        public ItemChargeback(List<ItemChargebackAddendum> addendums = default(List<ItemChargebackAddendum>), List<ItemChargebackAdjustmentRequest> adjustmentRequests = default(List<ItemChargebackAdjustmentRequest>))
        {
            this.Addendums = addendums;
            this.AdjustmentRequests = adjustmentRequests;
        }

        /// <summary>
        /// Addendums (deprecated)
        /// </summary>
        /// <value>Addendums (deprecated)</value>
        [DataMember(Name="addendums", EmitDefaultValue=false)]
        public List<ItemChargebackAddendum> Addendums { get; set; }

        /// <summary>
        /// Adjustment requests (deprecated)
        /// </summary>
        /// <value>Adjustment requests (deprecated)</value>
        [DataMember(Name="adjustment_requests", EmitDefaultValue=false)]
        public List<ItemChargebackAdjustmentRequest> AdjustmentRequests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemChargeback {\n");
            sb.Append("  Addendums: ").Append(Addendums).Append("\n");
            sb.Append("  AdjustmentRequests: ").Append(AdjustmentRequests).Append("\n");
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
            return this.Equals(input as ItemChargeback);
        }

        /// <summary>
        /// Returns true if ItemChargeback instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemChargeback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemChargeback input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Addendums == input.Addendums ||
                    this.Addendums != null &&
                    input.Addendums != null &&
                    this.Addendums.SequenceEqual(input.Addendums)
                ) && 
                (
                    this.AdjustmentRequests == input.AdjustmentRequests ||
                    this.AdjustmentRequests != null &&
                    input.AdjustmentRequests != null &&
                    this.AdjustmentRequests.SequenceEqual(input.AdjustmentRequests)
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
                if (this.Addendums != null)
                    hashCode = hashCode * 59 + this.Addendums.GetHashCode();
                if (this.AdjustmentRequests != null)
                    hashCode = hashCode * 59 + this.AdjustmentRequests.GetHashCode();
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
