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
    /// Distance
    /// </summary>
    [DataContract]
    public partial class Distance :  IEquatable<Distance>, IValidatableObject
    {
        /// <summary>
        /// Unit of measure
        /// </summary>
        /// <value>Unit of measure</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UomEnum
        {
            
            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 1,
            
            /// <summary>
            /// Enum CM for value: CM
            /// </summary>
            [EnumMember(Value = "CM")]
            CM = 2
        }

        /// <summary>
        /// Unit of measure
        /// </summary>
        /// <value>Unit of measure</value>
        [DataMember(Name="uom", EmitDefaultValue=false)]
        public UomEnum? Uom { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Distance" /> class.
        /// </summary>
        /// <param name="uom">Unit of measure.</param>
        /// <param name="value">The distance measured in UOM.</param>
        public Distance(UomEnum? uom = default(UomEnum?), decimal? value = default(decimal?))
        {
            this.Uom = uom;
            this.Value = value;
        }
        

        /// <summary>
        /// The distance measured in UOM
        /// </summary>
        /// <value>The distance measured in UOM</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Distance {\n");
            sb.Append("  Uom: ").Append(Uom).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as Distance);
        }

        /// <summary>
        /// Returns true if Distance instances are equal
        /// </summary>
        /// <param name="input">Instance of Distance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Distance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uom == input.Uom ||
                    (this.Uom != null &&
                    this.Uom.Equals(input.Uom))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Uom != null)
                    hashCode = hashCode * 59 + this.Uom.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
