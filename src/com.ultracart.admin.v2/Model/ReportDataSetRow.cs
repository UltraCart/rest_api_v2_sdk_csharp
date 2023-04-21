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
    /// ReportDataSetRow
    /// </summary>
    [DataContract]
    public partial class ReportDataSetRow :  IEquatable<ReportDataSetRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDataSetRow" /> class.
        /// </summary>
        /// <param name="c">c.</param>
        public ReportDataSetRow(List<ReportDataSetColumn> c = default(List<ReportDataSetColumn>))
        {
            this.C = c;
        }
        
        /// <summary>
        /// Gets or Sets C
        /// </summary>
        [DataMember(Name="c", EmitDefaultValue=false)]
        public List<ReportDataSetColumn> C { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportDataSetRow {\n");
            sb.Append("  C: ").Append(C).Append("\n");
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
            return this.Equals(input as ReportDataSetRow);
        }

        /// <summary>
        /// Returns true if ReportDataSetRow instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportDataSetRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportDataSetRow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.C == input.C ||
                    this.C != null &&
                    this.C.SequenceEqual(input.C)
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
                if (this.C != null)
                    hashCode = hashCode * 59 + this.C.GetHashCode();
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