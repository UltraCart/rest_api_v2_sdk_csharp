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
    /// ReportDataSetSchema
    /// </summary>
    [DataContract]
    public partial class ReportDataSetSchema :  IEquatable<ReportDataSetSchema>, IValidatableObject
    {
        /// <summary>
        /// Type of the column.
        /// </summary>
        /// <value>Type of the column.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BIGNUMERIC for value: BIGNUMERIC
            /// </summary>
            [EnumMember(Value = "BIGNUMERIC")]
            BIGNUMERIC = 1,

            /// <summary>
            /// Enum BOOL for value: BOOL
            /// </summary>
            [EnumMember(Value = "BOOL")]
            BOOL = 2,

            /// <summary>
            /// Enum DATE for value: DATE
            /// </summary>
            [EnumMember(Value = "DATE")]
            DATE = 3,

            /// <summary>
            /// Enum DATETIME for value: DATETIME
            /// </summary>
            [EnumMember(Value = "DATETIME")]
            DATETIME = 4,

            /// <summary>
            /// Enum FLOAT64 for value: FLOAT64
            /// </summary>
            [EnumMember(Value = "FLOAT64")]
            FLOAT64 = 5,

            /// <summary>
            /// Enum INT64 for value: INT64
            /// </summary>
            [EnumMember(Value = "INT64")]
            INT64 = 6,

            /// <summary>
            /// Enum JSON for value: JSON
            /// </summary>
            [EnumMember(Value = "JSON")]
            JSON = 7,

            /// <summary>
            /// Enum NUMERIC for value: NUMERIC
            /// </summary>
            [EnumMember(Value = "NUMERIC")]
            NUMERIC = 8,

            /// <summary>
            /// Enum STRING for value: STRING
            /// </summary>
            [EnumMember(Value = "STRING")]
            STRING = 9,

            /// <summary>
            /// Enum TIME for value: TIME
            /// </summary>
            [EnumMember(Value = "TIME")]
            TIME = 10,

            /// <summary>
            /// Enum TIMESTAMP for value: TIMESTAMP
            /// </summary>
            [EnumMember(Value = "TIMESTAMP")]
            TIMESTAMP = 11

        }

        /// <summary>
        /// Type of the column.
        /// </summary>
        /// <value>Type of the column.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDataSetSchema" /> class.
        /// </summary>
        /// <param name="config">A JSON representation of the configuration for this visualization.</param>
        /// <param name="name">name.</param>
        /// <param name="type">Type of the column..</param>
        public ReportDataSetSchema(string config = default(string), string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Config = config;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// A JSON representation of the configuration for this visualization
        /// </summary>
        /// <value>A JSON representation of the configuration for this visualization</value>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public string Config { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportDataSetSchema {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ReportDataSetSchema);
        }

        /// <summary>
        /// Returns true if ReportDataSetSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportDataSetSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportDataSetSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
