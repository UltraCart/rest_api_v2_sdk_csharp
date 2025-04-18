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
    /// ReportDataSource
    /// </summary>
    [DataContract]
    public partial class ReportDataSource :  IEquatable<ReportDataSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDataSource" /> class.
        /// </summary>
        /// <param name="dataSourceUuid">A unique identifier assigned to the data source..</param>
        /// <param name="name">name.</param>
        /// <param name="partitionDateColumn">partitionDateColumn.</param>
        /// <param name="partitionDateSafetyDays">partitionDateSafetyDays.</param>
        /// <param name="partitionDateStrategy">The partition date strategy, defaults to weekly sunday.</param>
        /// <param name="schema">schema.</param>
        /// <param name="sql">sql.</param>
        public ReportDataSource(string dataSourceUuid = default(string), string name = default(string), string partitionDateColumn = default(string), int partitionDateSafetyDays = default(int), string partitionDateStrategy = default(string), List<ReportDataSourceSchema> schema = default(List<ReportDataSourceSchema>), string sql = default(string))
        {
            this.DataSourceUuid = dataSourceUuid;
            this.Name = name;
            this.PartitionDateColumn = partitionDateColumn;
            this.PartitionDateSafetyDays = partitionDateSafetyDays;
            this.PartitionDateStrategy = partitionDateStrategy;
            this.Schema = schema;
            this.Sql = sql;
        }

        /// <summary>
        /// A unique identifier assigned to the data source.
        /// </summary>
        /// <value>A unique identifier assigned to the data source.</value>
        [DataMember(Name="data_source_uuid", EmitDefaultValue=false)]
        public string DataSourceUuid { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PartitionDateColumn
        /// </summary>
        [DataMember(Name="partition_date_column", EmitDefaultValue=false)]
        public string PartitionDateColumn { get; set; }

        /// <summary>
        /// Gets or Sets PartitionDateSafetyDays
        /// </summary>
        [DataMember(Name="partition_date_safety_days", EmitDefaultValue=false)]
        public int PartitionDateSafetyDays { get; set; }

        /// <summary>
        /// The partition date strategy, defaults to weekly sunday
        /// </summary>
        /// <value>The partition date strategy, defaults to weekly sunday</value>
        [DataMember(Name="partition_date_strategy", EmitDefaultValue=false)]
        public string PartitionDateStrategy { get; set; }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public List<ReportDataSourceSchema> Schema { get; set; }

        /// <summary>
        /// Gets or Sets Sql
        /// </summary>
        [DataMember(Name="sql", EmitDefaultValue=false)]
        public string Sql { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportDataSource {\n");
            sb.Append("  DataSourceUuid: ").Append(DataSourceUuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PartitionDateColumn: ").Append(PartitionDateColumn).Append("\n");
            sb.Append("  PartitionDateSafetyDays: ").Append(PartitionDateSafetyDays).Append("\n");
            sb.Append("  PartitionDateStrategy: ").Append(PartitionDateStrategy).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Sql: ").Append(Sql).Append("\n");
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
            return this.Equals(input as ReportDataSource);
        }

        /// <summary>
        /// Returns true if ReportDataSource instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportDataSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportDataSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataSourceUuid == input.DataSourceUuid ||
                    (this.DataSourceUuid != null &&
                    this.DataSourceUuid.Equals(input.DataSourceUuid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PartitionDateColumn == input.PartitionDateColumn ||
                    (this.PartitionDateColumn != null &&
                    this.PartitionDateColumn.Equals(input.PartitionDateColumn))
                ) && 
                (
                    this.PartitionDateSafetyDays == input.PartitionDateSafetyDays ||
                    (this.PartitionDateSafetyDays != null &&
                    this.PartitionDateSafetyDays.Equals(input.PartitionDateSafetyDays))
                ) && 
                (
                    this.PartitionDateStrategy == input.PartitionDateStrategy ||
                    (this.PartitionDateStrategy != null &&
                    this.PartitionDateStrategy.Equals(input.PartitionDateStrategy))
                ) && 
                (
                    this.Schema == input.Schema ||
                    this.Schema != null &&
                    input.Schema != null &&
                    this.Schema.SequenceEqual(input.Schema)
                ) && 
                (
                    this.Sql == input.Sql ||
                    (this.Sql != null &&
                    this.Sql.Equals(input.Sql))
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
                if (this.DataSourceUuid != null)
                    hashCode = hashCode * 59 + this.DataSourceUuid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PartitionDateColumn != null)
                    hashCode = hashCode * 59 + this.PartitionDateColumn.GetHashCode();
                if (this.PartitionDateSafetyDays != null)
                    hashCode = hashCode * 59 + this.PartitionDateSafetyDays.GetHashCode();
                if (this.PartitionDateStrategy != null)
                    hashCode = hashCode * 59 + this.PartitionDateStrategy.GetHashCode();
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Sql != null)
                    hashCode = hashCode * 59 + this.Sql.GetHashCode();
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
