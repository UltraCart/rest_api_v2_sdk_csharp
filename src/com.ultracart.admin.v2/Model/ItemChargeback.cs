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
    /// ItemChargeback
    /// </summary>
    [DataContract]
    public partial class ItemChargeback :  IEquatable<ItemChargeback>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemChargeback" /> class.
        /// </summary>
        /// <param name="Addendums">Addendums.</param>
        /// <param name="AdjustmentRequests">Adjustment requests.</param>
        public ItemChargeback(List<ItemChargebackAddendum> Addendums = default(List<ItemChargebackAddendum>), List<ItemChargebackAdjustmentRequest> AdjustmentRequests = default(List<ItemChargebackAdjustmentRequest>))
        {
            this.Addendums = Addendums;
            this.AdjustmentRequests = AdjustmentRequests;
        }
        
        /// <summary>
        /// Addendums
        /// </summary>
        /// <value>Addendums</value>
        [DataMember(Name="addendums", EmitDefaultValue=false)]
        public List<ItemChargebackAddendum> Addendums { get; set; }

        /// <summary>
        /// Adjustment requests
        /// </summary>
        /// <value>Adjustment requests</value>
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
                    this.Addendums.SequenceEqual(input.Addendums)
                ) && 
                (
                    this.AdjustmentRequests == input.AdjustmentRequests ||
                    this.AdjustmentRequests != null &&
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
