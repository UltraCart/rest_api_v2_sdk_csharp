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
    /// EmailStatPostcardSummaryRequest
    /// </summary>
    [DataContract]
    public partial class EmailStatPostcardSummaryRequest :  IEquatable<EmailStatPostcardSummaryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailStatPostcardSummaryRequest" /> class.
        /// </summary>
        /// <param name="commseqPostcardUuids">commseqPostcardUuids.</param>
        /// <param name="days">days.</param>
        public EmailStatPostcardSummaryRequest(List<string> commseqPostcardUuids = default(List<string>), int? days = default(int?))
        {
            this.CommseqPostcardUuids = commseqPostcardUuids;
            this.Days = days;
        }
        
        /// <summary>
        /// Gets or Sets CommseqPostcardUuids
        /// </summary>
        [DataMember(Name="commseq_postcard_uuids", EmitDefaultValue=false)]
        public List<string> CommseqPostcardUuids { get; set; }

        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public int? Days { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailStatPostcardSummaryRequest {\n");
            sb.Append("  CommseqPostcardUuids: ").Append(CommseqPostcardUuids).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
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
            return this.Equals(input as EmailStatPostcardSummaryRequest);
        }

        /// <summary>
        /// Returns true if EmailStatPostcardSummaryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailStatPostcardSummaryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailStatPostcardSummaryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CommseqPostcardUuids == input.CommseqPostcardUuids ||
                    this.CommseqPostcardUuids != null &&
                    this.CommseqPostcardUuids.SequenceEqual(input.CommseqPostcardUuids)
                ) && 
                (
                    this.Days == input.Days ||
                    (this.Days != null &&
                    this.Days.Equals(input.Days))
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
                if (this.CommseqPostcardUuids != null)
                    hashCode = hashCode * 59 + this.CommseqPostcardUuids.GetHashCode();
                if (this.Days != null)
                    hashCode = hashCode * 59 + this.Days.GetHashCode();
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