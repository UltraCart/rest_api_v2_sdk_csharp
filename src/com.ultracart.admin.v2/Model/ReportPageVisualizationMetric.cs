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
    /// ReportPageVisualizationMetric
    /// </summary>
    [DataContract]
    public partial class ReportPageVisualizationMetric :  IEquatable<ReportPageVisualizationMetric>, IValidatableObject
    {
        /// <summary>
        /// Aggregation to perform
        /// </summary>
        /// <value>Aggregation to perform</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AggregationEnum
        {
            
            /// <summary>
            /// Enum Sum for value: sum
            /// </summary>
            [EnumMember(Value = "sum")]
            Sum = 1,
            
            /// <summary>
            /// Enum Count for value: count
            /// </summary>
            [EnumMember(Value = "count")]
            Count = 2,
            
            /// <summary>
            /// Enum Min for value: min
            /// </summary>
            [EnumMember(Value = "min")]
            Min = 3,
            
            /// <summary>
            /// Enum Max for value: max
            /// </summary>
            [EnumMember(Value = "max")]
            Max = 4,
            
            /// <summary>
            /// Enum Avg for value: avg
            /// </summary>
            [EnumMember(Value = "avg")]
            Avg = 5
        }

        /// <summary>
        /// Aggregation to perform
        /// </summary>
        /// <value>Aggregation to perform</value>
        [DataMember(Name="aggregation", EmitDefaultValue=false)]
        public AggregationEnum? Aggregation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportPageVisualizationMetric" /> class.
        /// </summary>
        /// <param name="aggregation">Aggregation to perform.</param>
        /// <param name="_as">Return the column as a different name.</param>
        /// <param name="column">column.</param>
        /// <param name="round">Number of places after the decimal point to round the number to..</param>
        public ReportPageVisualizationMetric(AggregationEnum? aggregation = default(AggregationEnum?), string _as = default(string), string column = default(string), int? round = default(int?))
        {
            this.Aggregation = aggregation;
            this.As = _as;
            this.Column = column;
            this.Round = round;
        }
        

        /// <summary>
        /// Return the column as a different name
        /// </summary>
        /// <value>Return the column as a different name</value>
        [DataMember(Name="as", EmitDefaultValue=false)]
        public string As { get; set; }

        /// <summary>
        /// Gets or Sets Column
        /// </summary>
        [DataMember(Name="column", EmitDefaultValue=false)]
        public string Column { get; set; }

        /// <summary>
        /// Number of places after the decimal point to round the number to.
        /// </summary>
        /// <value>Number of places after the decimal point to round the number to.</value>
        [DataMember(Name="round", EmitDefaultValue=false)]
        public int? Round { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportPageVisualizationMetric {\n");
            sb.Append("  Aggregation: ").Append(Aggregation).Append("\n");
            sb.Append("  As: ").Append(As).Append("\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
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
            return this.Equals(input as ReportPageVisualizationMetric);
        }

        /// <summary>
        /// Returns true if ReportPageVisualizationMetric instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportPageVisualizationMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportPageVisualizationMetric input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aggregation == input.Aggregation ||
                    (this.Aggregation != null &&
                    this.Aggregation.Equals(input.Aggregation))
                ) && 
                (
                    this.As == input.As ||
                    (this.As != null &&
                    this.As.Equals(input.As))
                ) && 
                (
                    this.Column == input.Column ||
                    (this.Column != null &&
                    this.Column.Equals(input.Column))
                ) && 
                (
                    this.Round == input.Round ||
                    (this.Round != null &&
                    this.Round.Equals(input.Round))
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
                if (this.Aggregation != null)
                    hashCode = hashCode * 59 + this.Aggregation.GetHashCode();
                if (this.As != null)
                    hashCode = hashCode * 59 + this.As.GetHashCode();
                if (this.Column != null)
                    hashCode = hashCode * 59 + this.Column.GetHashCode();
                if (this.Round != null)
                    hashCode = hashCode * 59 + this.Round.GetHashCode();
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
