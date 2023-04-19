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
    /// ReportFilter
    /// </summary>
    [DataContract]
    public partial class ReportFilter :  IEquatable<ReportFilter>, IValidatableObject
    {
        /// <summary>
        /// Type of filter
        /// </summary>
        /// <value>Type of filter</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Daterange for value: date range
            /// </summary>
            [EnumMember(Value = "date range")]
            Daterange = 1,
            
            /// <summary>
            /// Enum Datecomparison for value: date comparison
            /// </summary>
            [EnumMember(Value = "date comparison")]
            Datecomparison = 2,
            
            /// <summary>
            /// Enum Singlevalue for value: single value
            /// </summary>
            [EnumMember(Value = "single value")]
            Singlevalue = 3,
            
            /// <summary>
            /// Enum Multiplevalues for value: multiple values
            /// </summary>
            [EnumMember(Value = "multiple values")]
            Multiplevalues = 4
        }

        /// <summary>
        /// Type of filter
        /// </summary>
        /// <value>Type of filter</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportFilter" /> class.
        /// </summary>
        /// <param name="config">A JSON representation of the configuration for this visualization.</param>
        /// <param name="connections">How this filter connects to the data sources and columns.</param>
        /// <param name="name">name.</param>
        /// <param name="styles">A JSON representation of the style configuration for this visualization.</param>
        /// <param name="timezone">The timezone that the date range is querying on..</param>
        /// <param name="type">Type of filter.</param>
        /// <param name="uuid">Unique UUID assigned to the filter.  Assists when returning values that the filter can use..</param>
        /// <param name="values">The selected values for the filter.  When used, some type conversion will need to occur..</param>
        public ReportFilter(string config = default(string), List<ReportFilterConnection> connections = default(List<ReportFilterConnection>), string name = default(string), string styles = default(string), string timezone = default(string), TypeEnum? type = default(TypeEnum?), string uuid = default(string), List<string> values = default(List<string>))
        {
            this.Config = config;
            this.Connections = connections;
            this.Name = name;
            this.Styles = styles;
            this.Timezone = timezone;
            this.Type = type;
            this.Uuid = uuid;
            this.Values = values;
        }
        
        /// <summary>
        /// A JSON representation of the configuration for this visualization
        /// </summary>
        /// <value>A JSON representation of the configuration for this visualization</value>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public string Config { get; set; }

        /// <summary>
        /// How this filter connects to the data sources and columns
        /// </summary>
        /// <value>How this filter connects to the data sources and columns</value>
        [DataMember(Name="connections", EmitDefaultValue=false)]
        public List<ReportFilterConnection> Connections { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A JSON representation of the style configuration for this visualization
        /// </summary>
        /// <value>A JSON representation of the style configuration for this visualization</value>
        [DataMember(Name="styles", EmitDefaultValue=false)]
        public string Styles { get; set; }

        /// <summary>
        /// The timezone that the date range is querying on.
        /// </summary>
        /// <value>The timezone that the date range is querying on.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }


        /// <summary>
        /// Unique UUID assigned to the filter.  Assists when returning values that the filter can use.
        /// </summary>
        /// <value>Unique UUID assigned to the filter.  Assists when returning values that the filter can use.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// The selected values for the filter.  When used, some type conversion will need to occur.
        /// </summary>
        /// <value>The selected values for the filter.  When used, some type conversion will need to occur.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportFilter {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Connections: ").Append(Connections).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Styles: ").Append(Styles).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as ReportFilter);
        }

        /// <summary>
        /// Returns true if ReportFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportFilter input)
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
                    this.Connections == input.Connections ||
                    this.Connections != null &&
                    this.Connections.SequenceEqual(input.Connections)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Styles == input.Styles ||
                    (this.Styles != null &&
                    this.Styles.Equals(input.Styles))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.Connections != null)
                    hashCode = hashCode * 59 + this.Connections.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Styles != null)
                    hashCode = hashCode * 59 + this.Styles.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
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
