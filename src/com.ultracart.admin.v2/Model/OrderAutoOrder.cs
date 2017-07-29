/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
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
    /// OrderAutoOrder
    /// </summary>
    [DataContract]
    public partial class OrderAutoOrder :  IEquatable<OrderAutoOrder>, IValidatableObject
    {
        /// <summary>
        /// The status of the auto order
        /// </summary>
        /// <value>The status of the auto order</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Canceled for "canceled"
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Disabled for "disabled"
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled
        }

        /// <summary>
        /// The status of the auto order
        /// </summary>
        /// <value>The status of the auto order</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAutoOrder" /> class.
        /// </summary>
        /// <param name="AutoOrderCode">Unique identifier assigned to the auto order.</param>
        /// <param name="OriginalOrderId">Orignal order id that started this auto order sequence.</param>
        /// <param name="Status">The status of the auto order.</param>
        public OrderAutoOrder(string AutoOrderCode = default(string), string OriginalOrderId = default(string), StatusEnum? Status = default(StatusEnum?))
        {
            this.AutoOrderCode = AutoOrderCode;
            this.OriginalOrderId = OriginalOrderId;
            this.Status = Status;
        }
        
        /// <summary>
        /// Unique identifier assigned to the auto order
        /// </summary>
        /// <value>Unique identifier assigned to the auto order</value>
        [DataMember(Name="auto_order_code", EmitDefaultValue=false)]
        public string AutoOrderCode { get; set; }

        /// <summary>
        /// Orignal order id that started this auto order sequence
        /// </summary>
        /// <value>Orignal order id that started this auto order sequence</value>
        [DataMember(Name="original_order_id", EmitDefaultValue=false)]
        public string OriginalOrderId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderAutoOrder {\n");
            sb.Append("  AutoOrderCode: ").Append(AutoOrderCode).Append("\n");
            sb.Append("  OriginalOrderId: ").Append(OriginalOrderId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrderAutoOrder);
        }

        /// <summary>
        /// Returns true if OrderAutoOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderAutoOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderAutoOrder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AutoOrderCode == other.AutoOrderCode ||
                    this.AutoOrderCode != null &&
                    this.AutoOrderCode.Equals(other.AutoOrderCode)
                ) && 
                (
                    this.OriginalOrderId == other.OriginalOrderId ||
                    this.OriginalOrderId != null &&
                    this.OriginalOrderId.Equals(other.OriginalOrderId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AutoOrderCode != null)
                    hash = hash * 59 + this.AutoOrderCode.GetHashCode();
                if (this.OriginalOrderId != null)
                    hash = hash * 59 + this.OriginalOrderId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
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
