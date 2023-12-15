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
    /// ReportDataSetColumn
    /// </summary>
    [DataContract]
    public partial class ReportDataSetColumn :  IEquatable<ReportDataSetColumn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDataSetColumn" /> class.
        /// </summary>
        /// <param name="_in">_in.</param>
        /// <param name="n">n.</param>
        /// <param name="vd">vd.</param>
        /// <param name="vdt">vdt.</param>
        /// <param name="vn">vn.</param>
        /// <param name="vs">vs.</param>
        public ReportDataSetColumn(bool _in = default(bool), string n = default(string), string vd = default(string), string vdt = default(string), decimal vn = default(decimal), string vs = default(string))
        {
            this.In = _in;
            this.N = n;
            this.Vd = vd;
            this.Vdt = vdt;
            this.Vn = vn;
            this.Vs = vs;
        }

        /// <summary>
        /// Gets or Sets In
        /// </summary>
        [DataMember(Name="in", EmitDefaultValue=false)]
        public bool In { get; set; }

        /// <summary>
        /// Gets or Sets N
        /// </summary>
        [DataMember(Name="n", EmitDefaultValue=false)]
        public string N { get; set; }

        /// <summary>
        /// Gets or Sets Vd
        /// </summary>
        [DataMember(Name="vd", EmitDefaultValue=false)]
        public string Vd { get; set; }

        /// <summary>
        /// Gets or Sets Vdt
        /// </summary>
        [DataMember(Name="vdt", EmitDefaultValue=false)]
        public string Vdt { get; set; }

        /// <summary>
        /// Gets or Sets Vn
        /// </summary>
        [DataMember(Name="vn", EmitDefaultValue=false)]
        public decimal Vn { get; set; }

        /// <summary>
        /// Gets or Sets Vs
        /// </summary>
        [DataMember(Name="vs", EmitDefaultValue=false)]
        public string Vs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportDataSetColumn {\n");
            sb.Append("  In: ").Append(In).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  Vd: ").Append(Vd).Append("\n");
            sb.Append("  Vdt: ").Append(Vdt).Append("\n");
            sb.Append("  Vn: ").Append(Vn).Append("\n");
            sb.Append("  Vs: ").Append(Vs).Append("\n");
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
            return this.Equals(input as ReportDataSetColumn);
        }

        /// <summary>
        /// Returns true if ReportDataSetColumn instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportDataSetColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportDataSetColumn input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.In == input.In ||
                    (this.In != null &&
                    this.In.Equals(input.In))
                ) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) && 
                (
                    this.Vd == input.Vd ||
                    (this.Vd != null &&
                    this.Vd.Equals(input.Vd))
                ) && 
                (
                    this.Vdt == input.Vdt ||
                    (this.Vdt != null &&
                    this.Vdt.Equals(input.Vdt))
                ) && 
                (
                    this.Vn == input.Vn ||
                    (this.Vn != null &&
                    this.Vn.Equals(input.Vn))
                ) && 
                (
                    this.Vs == input.Vs ||
                    (this.Vs != null &&
                    this.Vs.Equals(input.Vs))
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
                if (this.In != null)
                    hashCode = hashCode * 59 + this.In.GetHashCode();
                if (this.N != null)
                    hashCode = hashCode * 59 + this.N.GetHashCode();
                if (this.Vd != null)
                    hashCode = hashCode * 59 + this.Vd.GetHashCode();
                if (this.Vdt != null)
                    hashCode = hashCode * 59 + this.Vdt.GetHashCode();
                if (this.Vn != null)
                    hashCode = hashCode * 59 + this.Vn.GetHashCode();
                if (this.Vs != null)
                    hashCode = hashCode * 59 + this.Vs.GetHashCode();
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
