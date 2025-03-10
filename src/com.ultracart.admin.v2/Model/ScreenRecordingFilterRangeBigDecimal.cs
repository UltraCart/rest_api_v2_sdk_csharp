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
    /// ScreenRecordingFilterRangeBigDecimal
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingFilterRangeBigDecimal :  IEquatable<ScreenRecordingFilterRangeBigDecimal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingFilterRangeBigDecimal" /> class.
        /// </summary>
        /// <param name="eq">eq.</param>
        /// <param name="gt">gt.</param>
        /// <param name="gte">gte.</param>
        /// <param name="lt">lt.</param>
        /// <param name="lte">lte.</param>
        public ScreenRecordingFilterRangeBigDecimal(decimal eq = default(decimal), decimal gt = default(decimal), decimal gte = default(decimal), decimal lt = default(decimal), decimal lte = default(decimal))
        {
            this.Eq = eq;
            this.Gt = gt;
            this.Gte = gte;
            this.Lt = lt;
            this.Lte = lte;
        }

        /// <summary>
        /// Gets or Sets Eq
        /// </summary>
        [DataMember(Name="eq", EmitDefaultValue=false)]
        public decimal Eq { get; set; }

        /// <summary>
        /// Gets or Sets Gt
        /// </summary>
        [DataMember(Name="gt", EmitDefaultValue=false)]
        public decimal Gt { get; set; }

        /// <summary>
        /// Gets or Sets Gte
        /// </summary>
        [DataMember(Name="gte", EmitDefaultValue=false)]
        public decimal Gte { get; set; }

        /// <summary>
        /// Gets or Sets Lt
        /// </summary>
        [DataMember(Name="lt", EmitDefaultValue=false)]
        public decimal Lt { get; set; }

        /// <summary>
        /// Gets or Sets Lte
        /// </summary>
        [DataMember(Name="lte", EmitDefaultValue=false)]
        public decimal Lte { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingFilterRangeBigDecimal {\n");
            sb.Append("  Eq: ").Append(Eq).Append("\n");
            sb.Append("  Gt: ").Append(Gt).Append("\n");
            sb.Append("  Gte: ").Append(Gte).Append("\n");
            sb.Append("  Lt: ").Append(Lt).Append("\n");
            sb.Append("  Lte: ").Append(Lte).Append("\n");
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
            return this.Equals(input as ScreenRecordingFilterRangeBigDecimal);
        }

        /// <summary>
        /// Returns true if ScreenRecordingFilterRangeBigDecimal instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecordingFilterRangeBigDecimal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingFilterRangeBigDecimal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Eq == input.Eq ||
                    (this.Eq != null &&
                    this.Eq.Equals(input.Eq))
                ) && 
                (
                    this.Gt == input.Gt ||
                    (this.Gt != null &&
                    this.Gt.Equals(input.Gt))
                ) && 
                (
                    this.Gte == input.Gte ||
                    (this.Gte != null &&
                    this.Gte.Equals(input.Gte))
                ) && 
                (
                    this.Lt == input.Lt ||
                    (this.Lt != null &&
                    this.Lt.Equals(input.Lt))
                ) && 
                (
                    this.Lte == input.Lte ||
                    (this.Lte != null &&
                    this.Lte.Equals(input.Lte))
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
                if (this.Eq != null)
                    hashCode = hashCode * 59 + this.Eq.GetHashCode();
                if (this.Gt != null)
                    hashCode = hashCode * 59 + this.Gt.GetHashCode();
                if (this.Gte != null)
                    hashCode = hashCode * 59 + this.Gte.GetHashCode();
                if (this.Lt != null)
                    hashCode = hashCode * 59 + this.Lt.GetHashCode();
                if (this.Lte != null)
                    hashCode = hashCode * 59 + this.Lte.GetHashCode();
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
