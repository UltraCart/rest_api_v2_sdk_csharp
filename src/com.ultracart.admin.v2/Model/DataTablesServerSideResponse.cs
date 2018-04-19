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
    /// DataTablesServerSideResponse
    /// </summary>
    [DataContract]
    public partial class DataTablesServerSideResponse :  IEquatable<DataTablesServerSideResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTablesServerSideResponse" /> class.
        /// </summary>
        /// <param name="Draw">Draw.</param>
        /// <param name="RecordsFiltered">RecordsFiltered.</param>
        /// <param name="RecordsTotal">RecordsTotal.</param>
        public DataTablesServerSideResponse(int? Draw = default(int?), int? RecordsFiltered = default(int?), int? RecordsTotal = default(int?))
        {
            this.Draw = Draw;
            this.RecordsFiltered = RecordsFiltered;
            this.RecordsTotal = RecordsTotal;
        }
        
        /// <summary>
        /// Gets or Sets Draw
        /// </summary>
        [DataMember(Name="draw", EmitDefaultValue=false)]
        public int? Draw { get; set; }

        /// <summary>
        /// Gets or Sets RecordsFiltered
        /// </summary>
        [DataMember(Name="recordsFiltered", EmitDefaultValue=false)]
        public int? RecordsFiltered { get; set; }

        /// <summary>
        /// Gets or Sets RecordsTotal
        /// </summary>
        [DataMember(Name="recordsTotal", EmitDefaultValue=false)]
        public int? RecordsTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataTablesServerSideResponse {\n");
            sb.Append("  Draw: ").Append(Draw).Append("\n");
            sb.Append("  RecordsFiltered: ").Append(RecordsFiltered).Append("\n");
            sb.Append("  RecordsTotal: ").Append(RecordsTotal).Append("\n");
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
            return this.Equals(input as DataTablesServerSideResponse);
        }

        /// <summary>
        /// Returns true if DataTablesServerSideResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTablesServerSideResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTablesServerSideResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Draw == input.Draw ||
                    (this.Draw != null &&
                    this.Draw.Equals(input.Draw))
                ) && 
                (
                    this.RecordsFiltered == input.RecordsFiltered ||
                    (this.RecordsFiltered != null &&
                    this.RecordsFiltered.Equals(input.RecordsFiltered))
                ) && 
                (
                    this.RecordsTotal == input.RecordsTotal ||
                    (this.RecordsTotal != null &&
                    this.RecordsTotal.Equals(input.RecordsTotal))
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
                if (this.Draw != null)
                    hashCode = hashCode * 59 + this.Draw.GetHashCode();
                if (this.RecordsFiltered != null)
                    hashCode = hashCode * 59 + this.RecordsFiltered.GetHashCode();
                if (this.RecordsTotal != null)
                    hashCode = hashCode * 59 + this.RecordsTotal.GetHashCode();
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
