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
    /// ResultSet
    /// </summary>
    [DataContract]
    public partial class ResultSet :  IEquatable<ResultSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSet" /> class.
        /// </summary>
        /// <param name="Count">Number of results in this set.</param>
        /// <param name="Limit">Maximum number of results that can be returned in a set.</param>
        /// <param name="More">True if there are more results to query.</param>
        /// <param name="NextOffset">The next offset that you should query to retrieve more results.</param>
        /// <param name="Offset">Offset of this result set (zero based).</param>
        /// <param name="TotalRecords">The total number of records in the result set.  May be null if the number is not known and the client should continue iterating as long as more is true..</param>
        public ResultSet(int? Count = default(int?), int? Limit = default(int?), bool? More = default(bool?), int? NextOffset = default(int?), int? Offset = default(int?), int? TotalRecords = default(int?))
        {
            this.Count = Count;
            this.Limit = Limit;
            this.More = More;
            this.NextOffset = NextOffset;
            this.Offset = Offset;
            this.TotalRecords = TotalRecords;
        }
        
        /// <summary>
        /// Number of results in this set
        /// </summary>
        /// <value>Number of results in this set</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Maximum number of results that can be returned in a set
        /// </summary>
        /// <value>Maximum number of results that can be returned in a set</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// True if there are more results to query
        /// </summary>
        /// <value>True if there are more results to query</value>
        [DataMember(Name="more", EmitDefaultValue=false)]
        public bool? More { get; set; }

        /// <summary>
        /// The next offset that you should query to retrieve more results
        /// </summary>
        /// <value>The next offset that you should query to retrieve more results</value>
        [DataMember(Name="next_offset", EmitDefaultValue=false)]
        public int? NextOffset { get; set; }

        /// <summary>
        /// Offset of this result set (zero based)
        /// </summary>
        /// <value>Offset of this result set (zero based)</value>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// The total number of records in the result set.  May be null if the number is not known and the client should continue iterating as long as more is true.
        /// </summary>
        /// <value>The total number of records in the result set.  May be null if the number is not known and the client should continue iterating as long as more is true.</value>
        [DataMember(Name="total_records", EmitDefaultValue=false)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultSet {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  More: ").Append(More).Append("\n");
            sb.Append("  NextOffset: ").Append(NextOffset).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
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
            return this.Equals(obj as ResultSet);
        }

        /// <summary>
        /// Returns true if ResultSet instances are equal
        /// </summary>
        /// <param name="other">Instance of ResultSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.More == other.More ||
                    this.More != null &&
                    this.More.Equals(other.More)
                ) && 
                (
                    this.NextOffset == other.NextOffset ||
                    this.NextOffset != null &&
                    this.NextOffset.Equals(other.NextOffset)
                ) && 
                (
                    this.Offset == other.Offset ||
                    this.Offset != null &&
                    this.Offset.Equals(other.Offset)
                ) && 
                (
                    this.TotalRecords == other.TotalRecords ||
                    this.TotalRecords != null &&
                    this.TotalRecords.Equals(other.TotalRecords)
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
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.More != null)
                    hash = hash * 59 + this.More.GetHashCode();
                if (this.NextOffset != null)
                    hash = hash * 59 + this.NextOffset.GetHashCode();
                if (this.Offset != null)
                    hash = hash * 59 + this.Offset.GetHashCode();
                if (this.TotalRecords != null)
                    hash = hash * 59 + this.TotalRecords.GetHashCode();
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
